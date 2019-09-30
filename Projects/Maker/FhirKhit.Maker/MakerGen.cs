using FhirKhit.Tools;
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
        public class SDefInfo
        {
            public enum TypeFlag
            {
                Unknown,
                Resource,
                Element,
                Extension
            }
            public TypeFlag TFlag = TypeFlag.Unknown;

            public StructureDefinition SDef;
        };
        Dictionary<String, SDefInfo> items = new Dictionary<string, SDefInfo>();

        String PrimitiveGenPath => Path.Combine(this.outputDir, "Generated", "Primitive");
        String ComplexGenPath => Path.Combine(this.outputDir, "Generated", "Complex");
        String ResourceGenPath => Path.Combine(this.outputDir, "Generated", "Resource");

        String outputDir;

        FhirStructureDefinitions sDefs;

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

            // If TFlags unknown, use parents TFlag value.
            if (sDef.TFlag == SDefInfo.TypeFlag.Unknown)
            {
                SDefInfo parentInfo = this.GetTypedSDef(sDef.SDef.BaseDefinition);
                sDef.TFlag = parentInfo.TFlag;
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

        void LoadFhirElements()
        {
            const String fcn = "LoadFhirElements";

            this.ConversionInfo(this.GetType().Name, fcn, "Loading Fhir structure definitions");
            foreach (StructureDefinition sDef in this.sDefs.FhirSDefs.GetResources())
            {
                SDefInfo sDefInfo = new SDefInfo
                {
                    SDef = sDef
                };

                switch (sDef.Url)
                {
                    case "http://hl7.org/fhir/StructureDefinition/Element":
                        sDefInfo.TFlag = SDefInfo.TypeFlag.Element;
                        break;

                    case "http://hl7.org/fhir/StructureDefinition/Extension":
                        sDefInfo.TFlag = SDefInfo.TypeFlag.Extension;
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
            }
        }

        void ProcessFhirPrimitive(SDefInfo sDefInfo)
        {
            const String fcn = "ProcessFhirPrimitive";

            StructureDefinition sDef = sDefInfo.SDef;
            ClearSDef(sDef);

            this.ConversionInfo(this.GetType().Name, fcn, $"Processing Primitive {sDef.Name} {sDefInfo.TFlag}");

            CodeEditor instanceEditor = new CodeEditor();
            CodeBlockNested instanceBlock = instanceEditor.Blocks.AppendBlock();

            String instanceName = $"{sDef.Name.ToMachineName()}_Item";

            instanceBlock
                .AppendLine("using System;")
                .AppendLine("using System.Diagnostics;")
                .AppendLine("using System.IO;")
                .AppendLine("using System.Linq;")
                .AppendLine("using Hl7.Fhir.Model;")
                .BlankLine()
                .AppendCode("namespace FhirKhit.Maker.Common")
                .OpenBrace()
                .SummaryOpen()
                .Summary($"Fhir primitive '{sDef.Name}'")
                .SummaryLines(sDef.ToFormatedJson())
                .SummaryClose()
                .AppendCode($"public class {instanceName} : Primitive_Item")
                .OpenBrace()
                .CloseBrace()
                .CloseBrace()
                ;

            instanceEditor.Save(Path.Combine(PrimitiveGenPath, $"{instanceName}.cs"));
        }

        void ProcessFhirComplex(SDefInfo sDefInfo)
        {
            const String fcn = "ProcessFhirPrimitive";

            StructureDefinition sDef = sDefInfo.SDef;
            ClearSDef(sDef);

            this.ConversionInfo(this.GetType().Name, fcn, $"Processing Complex {sDef.Name} {sDefInfo.TFlag}");

            CodeEditor instanceEditor = new CodeEditor();
            CodeBlockNested instanceBlock = instanceEditor.Blocks.AppendBlock();

            String instanceName = $"{sDef.Name.ToMachineName()}_Item";

            instanceBlock
                .AppendLine("using System;")
                .AppendLine("using System.Diagnostics;")
                .AppendLine("using System.IO;")
                .AppendLine("using System.Linq;")
                .AppendLine("using Hl7.Fhir.Model;")
                .BlankLine()
                .AppendCode("namespace FhirKhit.Maker.Common")
                .OpenBrace()
                .SummaryOpen()
                .Summary($"Fhir primitive '{sDef.Name}'")
                .SummaryLines(sDef.ToFormatedJson())
                .SummaryClose()
                .AppendCode($"public class {instanceName} : Complex_Item")
                .OpenBrace()
                .CloseBrace()
                .CloseBrace()
                ;

            instanceEditor.Save(Path.Combine(this.ComplexGenPath, $"{instanceName}.cs"));
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

                            case SDefInfo.TypeFlag.Extension:
                                break;

                            default:
                                throw new ConvertErrorException(this.GetType().Name, fcn, $"Invalid TKind {sDefInfo.TFlag}. Item {path}");
                        }
                        break;

                    case StructureDefinition.StructureDefinitionKind.Resource:
                        //this.ConversionInfo(this.GetType().Name, fcn, $"Processing resource {sDef.Name} {sDefInfo.TFlag}");
                        break;

                    default:
                        throw new ConvertErrorException(this.GetType().Name, fcn, $"Invalid kind {sDefInfo.SDef.Kind}. Item {path}");
                }
            }
        }

        void InitDir(String dir)
        {
            DirHelper.CreateDirPath(dir);
            DirHelper.CleanDir(dir);
        }

        public Int32 GenerateBaseClasses(String outputDir)
        {
            const String fcn = "GenerateBaseClasses";

            try
            {
                this.ConversionInfo(this.GetType().Name, fcn, "Starting generation of Fhir MAKER classes");
                this.outputDir = outputDir;
                InitDir(this.ComplexGenPath);
                InitDir(this.PrimitiveGenPath);
                InitDir(this.ResourceGenPath);

                //this.sDefs.StoreFhirElements();

                this.LoadFhirElements();
                this.ProcessFhirElements();
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
