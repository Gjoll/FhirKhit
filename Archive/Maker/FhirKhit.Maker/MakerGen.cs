﻿using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Specification.Source;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;

namespace FhirKhit.Maker
{
    public class MakerGen : ConverterBase, IDisposable
    {
        const String ComplexNameSpace = "FhirKhit.Maker.Common.Complex";
        const String ResourceNameSpace = "FhirKhit.Maker.Common.Resource";
        const String PrimitiveNameSpace = "FhirKhit.Maker.Common.Primitive";

        MakerProject project = new MakerProject();

        String ComplexBase = $"{ComplexNameSpace}.ComplexBase";
        String PrimitiveBase = $"{PrimitiveNameSpace}.PrimitiveBase";
        String ResourceBase = $"{ResourceNameSpace}.ResourceBase";

        Dictionary<String, SDefInfo> items = new Dictionary<string, SDefInfo>();
        String PrimitiveGenPath => Path.Combine(this.outputDir, "Primitive", "Generated");
        String ComplexGenPath => Path.Combine(this.outputDir, "Complex", "Generated");
        String ResourceGenPath => Path.Combine(this.outputDir, "Resource", "Generated");
        String outputDir;

        FhirStructureDefinitions sDefs;

        String CleanName(String s)
        {
            if (s.EndsWith("[x]"))
                s = s.Substring(0, s.Length - 3);
            return s.ToMachineName();
        }

        String ResourceName(String s) => $"Resource_{CleanName(s)}";
        String TypeName(String s) => $"Type_{CleanName(s)}";
        String ElementName(String s) => $"Element_{CleanName(s)}";
        String PrimitiveName(String s) => $"Primitive_{CleanName(s)}";

        public MakerGen(String outputDir)
        {
            this.outputDir = outputDir;
            sDefs = new FhirStructureDefinitions();
        }

        SDefInfo GetTypedSDef(String path)
        {
            const String fcn = "GetTypedSDef";

            if (this.items.TryGetValue(path, out SDefInfo sDef) == false)
                throw new ConvertErrorException(this.GetType().Name, fcn, $"Internal error. Item {path} not in dictionary");

            if (
                (sDef.Parent == null) &&
                (String.IsNullOrEmpty(sDef.SDef.BaseDefinition) == false)
                )
            {
                sDef.Parent = this.GetTypedSDef(sDef.SDef.BaseDefinition);

                // If TFlags unknown, use parents TFlag value.
                if (sDef.TFlag == SDefInfo.TypeFlag.Unknown)
                    sDef.TFlag = sDef.Parent.TFlag;
            }

            return sDef;
        }

        public Int32 CreateBundle()
        {
            try
            {
                sDefs.StoreFhirElements();
            }
            catch (ConvertErrorException err)
            {
                this.ConversionError(err.FileName, err.MethodName, err.Message);
            }
            catch (Exception err)
            {
                this.ConversionError(this.GetType().Name, "Execute", err.Message);
            }

            return this.Errors.Any() ? -1 : 0;
        }

        void LoadFhirElement(StructureDefinition sDef)
        {
            const String fcn = "LoadFhirElement";

            /*
             * Eliminate all but the top level resources to simplify things.
             * Add them in later????
             */
            if (sDef.Type != sDef.Name)
            {
                this.ConversionWarn(this.GetType().Name, fcn, $"Skipping resource {sDef.Name}");
                return;
            }

            SDefInfo sDefInfo = new SDefInfo
            {
                SDef = sDef
            };

            switch (sDef.Url)
            {
                case "http://hl7.org/fhir/StructureDefinition/Element":
                    sDefInfo.TFlag = SDefInfo.TypeFlag.Element;
                    break;

                case "http://hl7.org/fhir/StructureDefinition/Resource":
                    sDefInfo.TFlag = SDefInfo.TypeFlag.Resource;
                    break;

                default:
                    sDefInfo.TFlag = SDefInfo.TypeFlag.Unknown;
                    break;
            }
            this.items.Add(sDef.Url, sDefInfo);
        }

        void LoadFhirElements()
        {
            const String fcn = "LoadFhirElements";

            this.ConversionInfo(this.GetType().Name, fcn, "Loading Fhir structure definitions");
            foreach (StructureDefinition sDef in this.sDefs.FhirSDefs.GetResources())
                LoadFhirElement(sDef);
        }

        void ClearSDef(StructureDefinition sDef)
        {
            sDef.Snapshot = null;
            sDef.Mapping = null;
            sDef.Text = null;
            sDef.Extension = null;
            sDef.Contact = null;
            foreach (ElementDefinition ed in sDef.Differential.Element)
            {
                ed.Mapping = null;
                ed.Constraint = null;
                ed.Extension = null;
            }
        }

        void ProcessFhirPrimitive(SDefInfo sDefInfo)
        {
            const String fcn = "ProcessFhirPrimitive";

            StructureDefinition sDef = sDefInfo.SDef;
            ClearSDef(sDef);

            this.ConversionInfo(this.GetType().Name, fcn, $"Processing Primitive {sDef.Name} {sDefInfo.TFlag}");
            String instanceName = PrimitiveName(sDef.Name);
            CodeEditor instanceEditor = this.project.CreateEditor(Path.Combine(PrimitiveGenPath, $"{instanceName}.cs"));
            CodeBlockNested instanceBlock = instanceEditor.Blocks.AppendBlock();

            instanceBlock
                .AppendCode("using System;")
                .AppendCode("using System.Diagnostics;")
                .AppendCode("using System.IO;")
                .AppendCode("using System.Linq;")
                .AppendCode("using Hl7.Fhir.Model;")
                .BlankLine()
                .AppendCode($"namespace {PrimitiveNameSpace}")
                .OpenBrace()
                .AppendCode("#region Json")
                .AppendLine("#if NEVER")
                .AppendLines("", sDef.ToFormatedJson().ToLines())
                .AppendLine("#endif")
                .AppendCode("#endregion")
                .SummaryOpen()
                .Summary($"Fhir primitive '{sDef.Name}'")
                .SummaryClose()
                .AppendCode($"public partial class {instanceName} : {PrimitiveBase}")
                .OpenBrace()
                .CloseBrace()
                .CloseBrace()
                ;
        }

        void DefineClassFields(
            CodeBlockNested subClassBlock,
            CodeBlockNested fieldsBlock,
            CodeBlockNested constructorBlock,
            CodeBlockNested writeBlock,
            ElementDefinition[] elements,
            String basePath,
            String className,
            ref Int32 index)
        {
            while (index < elements.Length)
            {
                ElementDefinition ed = elements[index];

                // We know when we are at the end of a sub class, when the 
                // path does no longer start with subPath.
                String path = ed.Path;
                if (ed.Path.StartsWith(basePath) == false)
                    return;

                path = path.Substring(basePath.Length);

                String elementName = ElementName(ed.Path.LastPathPart());

                fieldsBlock
                    .AppendComment($"{index}. {elements[index].Path}")
                    .AppendCode($"public ElementDefinitionInfo {elementName};")
                    ;

                writeBlock
                    .AppendCode($"{elementName}.Write(sDef);")
                    ;

                Int32 min = 0;
                Int32 max = -1;
                if (ed.Min.HasValue)
                    min = ed.Min.Value;
                if ((String.IsNullOrEmpty(ed.Max) == false) && (ed.Max != "*"))
                    max = Int32.Parse(ed.Max);

                constructorBlock
                    .OpenBrace()
                    .AppendComment($"{index}. {elements[index].Path}")
                    .AppendCode($"this.{elementName} = new ElementDefinitionInfo")
                    .OpenBrace()
                    .AppendCode($"Name = \"{elementName}\",")
                    .AppendCode($"Path= \"{ed.Path}\",")
                    .AppendCode($"Id = \"{ed.ElementId}\",")
                    .AppendCode($"Min = {min},")
                    .AppendCode($"Max = {max},")
                    .AppendCode($"Types = new BaseType[]")
                    .OpenBrace()
                    .DefineBlock(out CodeBlockNested typesBlock)
                    .CloseBrace("")
                    .CloseBrace(";")
                    .CloseBrace("")
                    ;


                // If next elements starts with this items path, then this is a
                // subelement, so start creating sub class.
                if (
                    (index < elements.Length - 1) &&
                    (elements[index + 1].Path.StartsWith($"{ed.Path}."))
                    )
                {
                    String subClassName = TypeName(path.LastPathPart());

                    typesBlock
                        .AppendCode($"new {subClassName}")
                        .OpenBrace()
                        .CloseBrace()
                        ;

                    DefineClass(subClassBlock, elements, ref index, ed.Path, subClassName, ComplexBase, out CodeBlockNested dummy);
                }
                else
                {
                    for (Int32 typeIndex = 0; typeIndex < ed.Type.Count; typeIndex += 1)
                    {
                        String sep = typeIndex == (ed.Type.Count - 1) ? "" : ",";
                        ElementDefinition.TypeRefComponent type = ed.Type[typeIndex];
                        switch (type.Code)
                        {
                            case null:
                                break;

                            case "boolean":
                            case "integer":
                            case "decimal":
                            case "uri":
                            case "string":
                            case "base64Binary":
                            case "instant":
                            case "date":
                            case "dateTime":
                            case "time":
                            case "oid":
                            case "id":
                            case "markdown":
                            case "unsignedInt":
                            case "positiveInt":
                            case "xhtml":
                            case "code":
                            case "uuid":
                            case "url":
                            case "canonical":
                                {
                                    String sep1 = "";
                                    typesBlock
                                        .AppendCode($"new {PrimitiveNameSpace}.{PrimitiveName(type.Code)}")
                                        .OpenBrace()
                                        .AppendProfiles(type.Profile, ref sep1)
                                        .AppendTargetProfiles(type.TargetProfile, ref sep1)
                                        .CloseBrace(sep)
                                        ;
                                }
                                sep = ", ";
                                break;

                            case "CodeableConcept":
                            case "Coding":
                                {
                                    String sep1 = "";
                                    typesBlock
                                        .AppendCode($"new {ComplexNameSpace}.{TypeName(type.Code)}")
                                        .OpenBrace()
                                        .AppendProfiles(type.Profile, ref sep1)
                                        .AppendTargetProfiles(type.TargetProfile, ref sep1)
                                        .CloseBrace(sep)
                                        ;
                                }
                                sep = ", ";
                                break;

                            case "Resource":
                                {
                                    String sep1 = "";
                                    typesBlock
                                        .AppendCode($"new {ResourceNameSpace}.{ResourceName(type.Code)}")
                                        .OpenBrace()
                                        .AppendProfiles(type.Profile, ref sep1)
                                        .AppendTargetProfiles(type.TargetProfile, ref sep1)
                                        .CloseBrace(sep)
                                        ;
                                }
                                sep = ", ";
                                break;

                            case "Reference":
                                {
                                    String sep1 = "";
                                    typesBlock
                                        .AppendCode($"new {ComplexNameSpace}.{TypeName(type.Code)}")
                                        .OpenBrace()
                                        .AppendProfiles(type.Profile, ref sep1)
                                        .AppendTargetProfiles(type.TargetProfile, ref sep1)
                                        .CloseBrace(sep)
                                        ;
                                }
                                sep = ", ";
                                break;

                            default:
                                typesBlock
                                    .AppendCode($"new {ComplexNameSpace}.{TypeName(type.Code)}")
                                    .OpenBrace()
                                    .CloseBrace(sep)
                                    ;
                                sep = ", ";
                                break;
                        }
                    }
                    index += 1;
                }
            }
        }

        void DefineClass(CodeBlockNested block,
            ElementDefinition[] elements,
            ref Int32 index,
            String basePath,
            String className,
            String parentMakerClassName,
            out CodeBlockNested constructorBlock)
        {
            basePath += '.';

            block
                .AppendComment($"{index}. {elements[index].Path}")
                .AppendCode($"public partial class {className} : {parentMakerClassName}")
                .OpenBrace()

                .DefineBlock(out CodeBlockNested subClassBlock)
                .DefineBlock(out CodeBlockNested fieldsBlock)

                .BlankLine()
                .AppendCode($"public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)")
                .OpenBrace()
                .AppendCode($"base.Write(sDef);")
                .AppendCode($"sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition")
                .OpenBrace()
                .AppendCode($"Path = \"{elements[index].Path}\",")
                .AppendCode($"ElementId = \"{elements[index].ElementId}\"")
                .CloseBrace(");")
                .DefineBlock(out CodeBlockNested writeBlock)
                .CloseBrace()

                .BlankLine()
                .AppendCode($"public {className}()")
                .OpenBrace()
                .DefineBlock(out constructorBlock)
                .CloseBrace()

                .CloseBrace()
                ;

            index += 1;
            DefineClassFields(subClassBlock,
                fieldsBlock,
                constructorBlock,
                writeBlock,
                elements,
                basePath,
                className,
                ref index);
        }

        void ProcessFhirResource(SDefInfo sDefInfo)
        {
            const String fcn = "ProcessFhirResource";

            StructureDefinition sDef = sDefInfo.SDef;
            ClearSDef(sDef);

            this.ConversionInfo(this.GetType().Name, fcn, $"Processing Resource {sDef.Name} {sDefInfo.TFlag}");

            String instanceName = ResourceName(sDef.Name);
            CodeEditor instanceEditor = this.project.CreateEditor(Path.Combine(ResourceGenPath, $"{instanceName}.cs"));
            CodeBlockNested instanceBlock = instanceEditor.Blocks.AppendBlock();
            instanceBlock
                .AppendCode("using System;")
                .AppendCode("using System.Diagnostics;")
                .AppendCode("using System.IO;")
                .AppendCode("using System.Linq;")
                .AppendCode("using Hl7.Fhir.Model;")
                .BlankLine()
                .AppendCode($"namespace {ResourceNameSpace}")
                .OpenBrace()
                .AppendCode("#region Json")
                .AppendCode("#if NEVER")
                .AppendLines("", sDef.ToFormatedJson().ToLines())
                .AppendLine("#endif")
                .AppendCode("#endregion")
                .SummaryOpen()
                .Summary($"Fhir resource '{sDef.Name}'")
                .SummaryClose()
                .DefineBlock(out CodeBlockNested classBlock)
                .CloseBrace()
                ;

            String baseClass = ResourceBase;
            if (String.IsNullOrEmpty(sDef.BaseDefinition) == false)
            {
                String name = this.ResourceName(sDef.BaseDefinition.LastUriPart());
                baseClass = $"{ResourceNameSpace}.{name}";
            }
            Int32 i = 0;
            DefineClass(classBlock,
                sDef.Differential.Element.ToArray(),
                ref i,
                sDef.Differential.Element[0].Path,
                instanceName,
                baseClass,
                out CodeBlockNested constructorBlock);

            constructorBlock
                .AppendCode($"this.Name = \"{sDef.Name}\";")
                .AppendCode($"this.Uri = \"{sDef.Url}\";")
                ;

            if (i != sDef.Differential.Element.Count)
                throw new ConvertErrorException(this.GetType().Name, fcn, $"Internal error. Invalid element index");
        }

        void ProcessFhirComplex(SDefInfo sDefInfo)
        {
            const String fcn = "ProcessFhirPrimitive";

            StructureDefinition sDef = sDefInfo.SDef;
            ClearSDef(sDef);

            this.ConversionInfo(this.GetType().Name, fcn, $"Processing Complex {sDef.Name} {sDefInfo.TFlag}");

            String instanceName = TypeName(sDef.Name);
            CodeEditor instanceEditor = this.project.CreateEditor(Path.Combine(ComplexGenPath, $"{instanceName}.cs"));
            CodeBlockNested instanceBlock = instanceEditor.Blocks.AppendBlock();

            instanceBlock
                .AppendCode("using System;")
                .AppendCode("using System.Diagnostics;")
                .AppendCode("using System.IO;")
                .AppendCode("using System.Linq;")
                .AppendCode("using Hl7.Fhir.Model;")
                .BlankLine()
                .AppendCode($"namespace {ComplexNameSpace}")
                .OpenBrace()
                .AppendCode("#region Json")
                .AppendLine("#if NEVER")
                .AppendLines("", sDef.ToFormatedJson().ToLines())
                .AppendLine("#endif")
                .AppendCode("#endregion")
                .SummaryOpen()
                .Summary($"Fhir complex '{sDef.Name}'")
                .SummaryClose()
                .DefineBlock(out CodeBlockNested classBlock)
                .CloseBrace()
                ;

            Int32 i = 0;
            DefineClass(classBlock,
                sDef.Differential.Element.ToArray(),
                ref i,
                sDef.Differential.Element[0].Path,
                instanceName,
                ComplexBase,
                out CodeBlockNested dummy);

            if (i != sDef.Differential.Element.Count)
                throw new ConvertErrorException(this.GetType().Name, fcn, $"Internal error. Invalid element index");
        }

        void ProcessFhirElements()
        {
            const String fcn = "ProcessFhirElements";

            foreach (string path in this.items.Keys)
            {
                SDefInfo sDefInfo = this.GetTypedSDef(path);
                StructureDefinition sDef = sDefInfo.SDef;
                switch (sDefInfo.SDef.Kind)
                {
                    case StructureDefinition.StructureDefinitionKind.PrimitiveType:
                        ProcessFhirPrimitive(sDefInfo);
                        break;

                    case StructureDefinition.StructureDefinitionKind.Logical:
                        break;

                    case StructureDefinition.StructureDefinitionKind.ComplexType:
                        switch (sDefInfo.TFlag)
                        {
                            case SDefInfo.TypeFlag.Element:
                                ProcessFhirComplex(sDefInfo);
                                break;

                            default:
                                throw new ConvertErrorException(this.GetType().Name, fcn, $"Invalid TKind {sDefInfo.TFlag}. Item {path}");
                        }
                        break;

                    case StructureDefinition.StructureDefinitionKind.Resource:
                        ProcessFhirResource(sDefInfo);
                        break;

                    default:
                        throw new ConvertErrorException(this.GetType().Name, fcn, $"Invalid kind {sDefInfo.SDef.Kind}. Item {path}");
                }
            }
        }

        public Int32 GenerateBaseClasses(String outputDir)
        {
            const String fcn = "GenerateBaseClasses";

            try
            {
                this.ConversionInfo(this.GetType().Name, fcn, "Starting generation of Fhir MAKER classes");
                this.outputDir = outputDir;
                this.project.CreateFileCleaner(this.ComplexGenPath);
                this.project.CreateFileCleaner(this.PrimitiveGenPath);
                this.project.CreateFileCleaner(this.ResourceGenPath);

                //this.sDefs.StoreFhirElements();

                this.LoadFhirElements();
                this.ProcessFhirElements();

                this.ConversionInfo(this.GetType().Name, fcn, "Saving modified files");
                this.project.Save();

                this.ConversionInfo(this.GetType().Name, fcn, "Completed generation of Fhir MAKER classes");
            }
            catch (ConvertErrorException err)
            {
                this.ConversionError(err.FileName, err.MethodName, err.Message);
            }
            catch (Exception err)
            {
                this.ConversionError(this.GetType().Name, "Execute", err.Message);
            }

            this.ConversionInfo(this.GetType().Name, fcn, "Completed generation of CIMPL classes");
            return this.Errors.Any() ? -1 : 0;
        }

        public void Dispose()
        {
        }

    }
}
