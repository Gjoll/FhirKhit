using FhirKhit.Tools;
using Hl7.Fhir.Model;
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
        class SDefInfo
        {
            public enum TypeFlag
            {
                Unknown,
                Group,
                Entry
            }
            public TypeFlag TFlag = TypeFlag.Unknown;

            public StructureDefinition SDef;
        };

        Dictionary<String, SDefInfo> items;

        ZipSource source;

        CodeEditor entryEditor = new CodeEditor();
        CodeBlockNested entryBlock;

        CodeEditor mapEditor = new CodeEditor();
        CodeBlockNested mapBlock;

        public DirectFhirGenerator()
        {
            source = new ZipSource("specification.zip");
            this.items = new Dictionary<string, SDefInfo>();
        }


        void ProcessSchemaItemSpecialiation(SDefInfo sDefInfo)
        {
            StructureDefinition sDef = sDefInfo.SDef;

            const string fcn = "ProcessSchemaItemSpecialiation";

            CodeBlockNested item = entryBlock.AppendBlock();
            CodeBlockNested vars = entryBlock.AppendBlock();

            String description = sDef.Description.ToString();
            String name = sDef.Snapshot.Element[0].Path;
            String parent = sDef.BaseDefinition.LastUriPart();

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
            String typeName;
            switch (sDefInfo.TFlag)
            {
                case SDefInfo.TypeFlag.Entry:
                    typeName = "Entry";
                    break;
                case SDefInfo.TypeFlag.Group:
                    typeName = "Group";
                    break;
                default:
                    throw new ConvertErrorException(this.GetType().Name, fcn, $"Invalid TFlag value");
            }

            item
                .BlankLine()
                .Comment(description)
                .AppendCode($"{typeName}: {name}")
                .AppendCode($"Parent: {parent}")
                ;

            foreach (ElementDefinition ed in sDef.Differential.Element.Skip(1))
            {
                if (ed.Path.Split('.').Length != 2)
                    throw new ConvertErrorException(this.GetType().Name, fcn, $"Invalid element {ed.Path}. Too many parts. Expected 2");
                String propertyName = ed.Path.LastPathPart();
            }

            //    foreach (JToken property in properties.Children())
            //    {
            //        String pName = "";
            //        item
            //            .AppendCode($"Property: {pName}")
            //            ;

            //    }
        }

        void ProcessFhirElement(SDefInfo sDefInfo)
        {
            StructureDefinition sDef = sDefInfo.SDef;

            String baseDefinition = sDef.BaseDefinition;
            switch (sDef.BaseDefinition)
            {
                case "http://hl7.org/fhir/StructureDefinition/Element":
                case "http://hl7.org/fhir/StructureDefinition/Extension":
                    break;

                default:
                    if (sDef.Derivation == StructureDefinition.TypeDerivationRule.Specialization)
                        ProcessSchemaItemSpecialiation(sDefInfo);
                    break;
            }
        }

        void LoadFhirElements()
        {
            // const String fcn = "ProcessFhirElements";

            foreach (string uri in this.source.ListResourceUris())
            {
                StructureDefinition sDef = source.ResolveByUri(uri) as StructureDefinition;
                if (sDef != null)
                {
                    SDefInfo sDefInfo = new SDefInfo
                    {
                        SDef = sDef,
                        TFlag = SDefInfo.TypeFlag.Unknown
                    };

                    switch (uri)
                    {
                        case "http://hl7.org/fhir/StructureDefinition/Element":
                            sDefInfo.TFlag = SDefInfo.TypeFlag.Group;
                            break;

                        case "http://hl7.org/fhir/StructureDefinition/Resource":
                            sDefInfo.TFlag = SDefInfo.TypeFlag.Entry;
                            break;
                    }

                    this.items.Add(sDef.Url, sDefInfo);
                }
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
                SDefInfo sDef = GetTypedSDef(path);
                ProcessFhirElement(sDef);
            }
        }

        void CreateEditors(String outputDir)
        {
            this.entryEditor = new CodeEditor();
            this.entryEditor.SavePath = Path.Combine(outputDir, "DirectFhir.txt");

            this.mapEditor = new CodeEditor();
            this.mapEditor.SavePath = Path.Combine(outputDir, "DirectFhir_map_r4.txt");

            entryBlock = entryEditor.Blocks.AppendBlock();
            entryBlock
                .AppendLine($"Grammar: DataElement 6.0")
                .AppendLine($"Namespace: fhir.datatype")
                .AppendLine($"Description: \"Base fhir element definitions. Autogenerated\"")
                ;

            mapBlock = mapEditor.Blocks.AppendBlock();
            mapBlock
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

        public Int32 GenerateBaseClasses(String outputDir)
        {
            try
            {
                CreateEditors(outputDir);
                LoadFhirElements();
                ProcessFhirElements();
                SaveEditors();
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
