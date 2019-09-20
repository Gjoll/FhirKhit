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

namespace FhirKhit.CIMPL.DirectFhir
{
    public class DirectFhirGenerator : ConverterBase, IDisposable
    {
        String outputDir;
        Bundle fhirSDefsBundle;

        class SDefInfo
        {
            public enum TypeFlag
            {
                Unknown,
                Group,
                Element
            }
            public TypeFlag TFlag = TypeFlag.Unknown;

            public StructureDefinition SDef;
        };

        String FhirSDefsPath => Path.Combine(this.outputDir, "StructureDefinitions.json");
        Bundle FhirSDefsBundle
        {
            get
            {
                if (this.fhirSDefsBundle == null)
                {
                    if (File.Exists(this.FhirSDefsPath) == false)
                        return null;

                    FhirJsonParser parser = new FhirJsonParser();
                    this.fhirSDefsBundle = parser.Parse<Bundle>(File.ReadAllText(this.FhirSDefsPath));
                }
                return this.fhirSDefsBundle;
            }
        }

        Dictionary<String, SDefInfo> items;
        ZipSource source;
        CodeEditor entryEditor = new CodeEditor();
        CodeBlockNested entryBlock;

        CodeEditor mapEditor = new CodeEditor();
        CodeBlockNested mapBlock;

        public DirectFhirGenerator(String outputDir)
        {
            this.outputDir = outputDir;
            this.source = new ZipSource("specification.zip");
            this.items = new Dictionary<string, SDefInfo>();
        }


        void ProcessSchemaItemProperty(CodeBlockNested item,
            ElementDefinition[] elements,
            ref Int32 elementIndex)
        {
            const string fcn = "ProcessSchemaItemSpecialiation";

            const String BackboneElement = "BackboneElement";

            ElementDefinition ed = elements[elementIndex++];

            // Note: Currently we do not handle extensions.
            if (ed.Path.LastPathPart() == "extension")
                return;
            if (ed.Path.LastPathPart() == "modifierExtension")
                return;

            if (String.IsNullOrEmpty(ed.SliceName) == false)
                throw new ConvertErrorException(this.GetType().Name, fcn, $"Unexpected SliceName in element {ed.Path}.");
            if (ed.Slicing != null)
                throw new ConvertErrorException(this.GetType().Name, fcn, $"Unexpected Slice in element {ed.Path}.");
            if (ed.Fixed != null)
                throw new ConvertErrorException(this.GetType().Name, fcn, $"Unexpected Fixed in element {ed.Path}.");
            if (ed.Pattern != null)
                throw new ConvertErrorException(this.GetType().Name, fcn, $"Unexpected Pattern in element {ed.Path}.");

            String propertyName = ed.Path.LastPathPart().ToMachineName();
            item
                .AppendCode($"Property: {propertyName} {ed.Min}..{ed.Max}")
                ;

            if (propertyName == "Identifier")
                return;

            CodeBlockNested subItem = this.entryBlock.AppendBlock();
            subItem
                .BlankLine()
                ;

            if ((ed.Type.Count == 1) && (ed.Type[0].Code == BackboneElement))
            {
                subItem
                     .BlankLine()
                     .AppendLine($"// Group definition of backbone element {ed.Path}")
                     .AppendCode($"Group: {propertyName}")
                     ;

                while (elementIndex < elements.Length)
                {

                    ElementDefinition subElement = elements[elementIndex];
                    if (subElement.Path.StartsWith($"{ed.Path}.") == false)
                        break;
                    this.ProcessSchemaItemProperty(subItem, elements, ref elementIndex);
                }
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                foreach (ElementDefinition.TypeRefComponent type in ed.Type)
                {
                    String or = (sb.Length > 0) ? " or " : "";
                    switch (type.Code)
                    {
                        case "Reference":
                            if (type.Profile.Any())
                                throw new ConvertErrorException(this.GetType().Name, fcn, $"Unexpected profile in type {ed.Path}:{type.Code}.");
                            if (type.TargetProfile.Count() == 0)
                            {
                                sb.Append($"{or}Resource");
                            }
                            else
                            {
                                foreach (string target in type.TargetProfile)
                                {
                                    String targetEntryName = target.LastUriPart().ToMachineName();
                                    sb.Append($"{or}{targetEntryName}");
                                    or = " or ";
                                }
                            }
                            sb.Append($"{or}{type.Code}");
                            break;

                        default:
                            //if (type.Profile.Any())
                            //    throw new ConvertErrorException(this.GetType().Name, fcn, $"Unexpected profile in type {ed.Path}:{type.Code}.");
                            //if (type.TargetProfile.Any())
                            //    throw new ConvertErrorException(this.GetType().Name, fcn, $"Unexpected targetProfile in type {ed.Path}:{type.Code}.");
                            sb.Append(type.Code);
                            break;
                    }
                }

                subItem
                    .BlankLine()
                    .AppendLine($"// Entry definition of {ed.Path}")
                    .AppendCode($"Entry: {propertyName}")
                    ;

                if (sb.Length > 0)
                {
                    subItem
                        .AppendCode($"Value: {sb.ToString()}")
                        ;
                }
            }
        }

        void ProcessSchemaItemSpecialiation(SDefInfo sDefInfo)
        {
            const string fcn = "ProcessSchemaItemSpecialiation";

            StructureDefinition sDef = sDefInfo.SDef;

            String parent = sDef.BaseDefinition.LastUriPart();
            String description = sDef.Description.ToString();
            String name = sDef.Snapshot.Element[0].Path;
            // remove items that derive directly from primitives.
            switch (parent)
            {
                case "boolean":
                case "integer":
                case "decimal":
                case "uri":
                case "string":
                case "base64Binary":
                case "instant":
                case "dateTime":
                case "time":
                case "oid":
                case "id":
                case "markdown":
                case "unsignedInt":
                case "positiveInt":
                case "xhtml":
                    this.ConversionInfo(this.GetType().Name, fcn, $"Ignoring '{name}' because it derives from primitive '{parent}'");
                    return;
            }

            this.CreateEditors(name);

            CodeBlockNested item = this.entryBlock.AppendBlock();

            String typeName;
            switch (sDefInfo.TFlag)
            {
                case SDefInfo.TypeFlag.Element:
                    typeName = "Element";
                    break;
                case SDefInfo.TypeFlag.Group:
                    typeName = "Group";
                    break;
                default:
                    throw new ConvertErrorException(this.GetType().Name, fcn, $"Invalid TFlag value");
            }

            item
                .BlankLine()
                .Comment($"{sDef.Url}")
                .AppendCode($"{typeName}: {name}")
                .AppendCode($"Parent: {parent}")
                .AppendCode($"Description: \"{description}\"")
                ;

            ElementDefinition[] elements = sDef.Differential.Element.ToArray();
            Int32 elementIndex = 1;
            while (elementIndex < elements.Length)
                this.ProcessSchemaItemProperty(item, elements, ref elementIndex);

            this.SaveEditors();
        }

        void ProcessFhirElement(SDefInfo sDefInfo)
        {
            StructureDefinition sDef = sDefInfo.SDef;

            String baseDefinition = sDef.BaseDefinition;
            switch (sDef.BaseDefinition)
            {
                case "http://hl7.org/fhir/StructureDefinition/Extension":
                    break;

                default:
                    if (sDef.Derivation == StructureDefinition.TypeDerivationRule.Specialization)
                        this.ProcessSchemaItemSpecialiation(sDefInfo);
                    break;
            }
        }

        /// <summary>
        /// To save time, store all structure definitions in a fhir bundle file. This need only be run when we get a new 
        /// FHIR version.
        /// </summary>
        void StoreFhirElements()
        {
            // const String fcn = "ProcessFhirElements";

            this.fhirSDefsBundle = new Bundle();
            foreach (string uri in this.source.ListResourceUris())
            {
                StructureDefinition sDef = this.source.ResolveByUri(uri) as StructureDefinition;
                if (sDef != null)
                {
                    // This is to get rid of the http://....//de-... entries.
                    if (sDef.Snapshot.Element[0].Path.Split('.').Length == 1)
                        this.fhirSDefsBundle.AddResourceEntry(sDef, sDef.Url);
                }
            }
            this.fhirSDefsBundle.SaveJson(this.FhirSDefsPath);
        }

        void LoadFhirElements()
        {
            // const String fcn = "ProcessFhirElements";

            foreach (StructureDefinition sDef in this.FhirSDefsBundle.GetResources())
            {
                SDefInfo sDefInfo = new SDefInfo
                {
                    SDef = sDef,
                    TFlag = SDefInfo.TypeFlag.Unknown
                };

                switch (sDef.Url)
                {
                    case "http://hl7.org/fhir/StructureDefinition/Element":
                        sDefInfo.TFlag = SDefInfo.TypeFlag.Group;
                        break;

                    case "http://hl7.org/fhir/StructureDefinition/Resource":
                        sDefInfo.TFlag = SDefInfo.TypeFlag.Element;
                        break;
                }

                this.items.Add(sDef.Url, sDefInfo);
            }
        }

        SDefInfo GetTypedSDef(String path)
        {
            const String fcn = "GetTypedSDef";

            if (this.items.TryGetValue(path, out SDefInfo sDef) == false)
                throw new ConvertErrorException(this.GetType().Name, fcn, $"Internal error. Item {path} not in dictionary");

            // If TFlag s unknown, use parents TFlag value.
            if (sDef.TFlag == SDefInfo.TypeFlag.Unknown)
            {
                String baseDefinition = sDef.SDef.BaseDefinition;
                SDefInfo parentInfo = this.GetTypedSDef(baseDefinition);
                sDef.TFlag = parentInfo.TFlag;
            }

            return sDef;
        }

        void ProcessFhirElements()
        {
            const String fcn = "ProcessFhirElements";

            foreach (string path in this.items.Keys)
            {
                SDefInfo sDef = this.GetTypedSDef(path);
                Debug.Assert(sDef.SDef.Url.ToLower().Contains("money") == false);
                this.ProcessFhirElement(sDef);
            }
        }

        void CreateEditors(String baseName)
        {
            this.entryEditor = new CodeEditor();
            this.entryEditor.SavePath = Path.Combine(this.outputDir, $"{baseName}.txt");

            this.mapEditor = new CodeEditor();
            this.mapEditor.SavePath = Path.Combine(this.outputDir, $"{baseName}_map_r4.txt");

            this.entryBlock = this.entryEditor.Blocks.AppendBlock();
            this.entryBlock
                .AppendLine($"Grammar: DataElement 6.0")
                .AppendLine($"Namespace: fhir.datatype")
                .AppendLine($"Description: \"Base fhir element definitions. Autogenerated\"")
                ;

            this.mapBlock = this.mapEditor.Blocks.AppendBlock();
            this.mapBlock
                .AppendLine($"Grammar: Map 5.1")
                .AppendLine($"Namespace: fhir.datatype")
                .AppendLine($"Target: FHIR_R4")
                ;

        }

        void SaveEditors()
        {
            this.entryEditor.Save();
            this.mapEditor.Save();
        }

        public Int32 CreateBundle()
        {
            try
            {
                this.StoreFhirElements();
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

        public Int32 GenerateBaseClasses()
        {
            try
            {
                if (File.Exists(this.FhirSDefsPath) == false)
                    this.StoreFhirElements();

                this.LoadFhirElements();
                this.ProcessFhirElements();
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

        public void Dispose()
        {
        }
    }
}
