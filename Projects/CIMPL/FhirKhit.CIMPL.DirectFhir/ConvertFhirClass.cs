using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace FhirKhit.CIMPL.DirectFhir
{
    /// <summary>
    /// Create a single fhir structuredefinition to its CIMPL equivalent.
    /// </summary>
    class ConvertFhirClass
    {
        CodeBlockNested mainBlock;
        DirectFhirGenerator gen;
        DirectFhirGenerator.SDefInfo sDefInfo;
        StructureDefinition sDef;
        Int32 elementIndex;
        ElementDefinition[] elements;

        public ConvertFhirClass(DirectFhirGenerator gen,
            DirectFhirGenerator.SDefInfo sDefInfo,
            CodeBlockNested mainBlock)
        {
            this.sDefInfo = sDefInfo;
            this.gen = gen;
            this.sDef = this.sDefInfo.SDef;
            this.mainBlock = mainBlock;
            this.elements = sDef.Differential.Element.ToArray();
            elementIndex = 1;
        }

        public void Convert()
        {
            const string fcn = "Convert";

            //CodeEditor mapEditor = new CodeEditor();
            //mapEditor.SavePath = Path.Combine(this.outputDir, $"{name}_map_r4.txt");

            //CodeBlockNested mapBlock = mapEditor.Blocks.AppendBlock();
            //mapBlock
            //    .AppendLine($"Grammar: Map 5.1")
            //    .AppendLine($"Namespace: {NSBase}")
            //    .AppendLine($"Target: FHIR_R4")
            //    ;

            Debug.Assert(sDefInfo.SDef.Snapshot.Element[0].Path.ToLower().Contains("backboneelement") == false);

            String typeName;
            switch (sDefInfo.TFlag)
            {
                case DirectFhirGenerator.SDefInfo.TypeFlag.Entry:
                    typeName = "Entry";
                    break;
                case DirectFhirGenerator.SDefInfo.TypeFlag.Group:
                    typeName = "Group";
                    break;
                default:
                    throw new ConvertErrorException(this.GetType().Name, fcn, $"Invalid TFlag value");
            }

            String parent = sDef.BaseDefinition.LastUriPart();
            String description = this.gen.ToDescription(sDef.Description);
            String entryName = ProcessEntry(sDef.ToFormatedJson(), elements[0].Path, null, typeName, parent, description, sDef.Url);

            mainBlock
                .BlankLine()
                .AppendCode($"{typeName}: {entryName.LastPathPart()}")
                .AppendCode($"Parent: {entryName}")
                .AppendCode($"Description: \"{description}\"")
                ;

            if (elementIndex != elements.Length)
                throw new ConvertErrorException(this.GetType().Name, fcn, $"Internal error. ElementIndex not correct");

            //mapEditor.Save();
        }


        /// <summary>
        /// Create new file containing the definition for the new item.
        /// The new entry is created in its own namespace.
        /// </summary>
        /// <param name="json"></param>
        /// <param name="path"></param>
        /// <param name="typeName"></param>
        /// <param name="name"></param>
        /// <param name="parent"></param>
        /// <param name="description"></param>
        /// <param name="comment"></param>
        /// <param name="elements"></param>
        /// <param name="elementIndex"></param>
        String ProcessEntry(String json,
            String path,
            String suffix,
            String typeName,
            String parent,
            String description,
            String comment)
        {
            CodeBlockNested entryBlock = this.gen.CreateEntryEditor(path);
            CodeBlockNested classBlock = entryBlock.AppendBlock();
            CodeBlockNested propertydefinitionsBlock = entryBlock.AppendBlock();

            String name = path.LastPathPart().ToMachineName();
            if (String.IsNullOrEmpty(suffix) == false)
                name += suffix;
            classBlock
                .AppendComment(json)
                .BlankLine()
                .AppendComment(comment)
                .AppendCode($"{typeName}: {name}")
                ;
            switch (parent)
            {
                case "Element":
                    break;

                default:
                    classBlock.AppendCode($"Parent: {this.gen.NameSpace(parent)}.{parent}");
                    break;
            }
            classBlock
                .AppendCode($"Description: \"{description}\"")
                ;

            while (elementIndex < elements.Length)
            {
                ElementDefinition subElement = elements[elementIndex];
                if (subElement.Path.StartsWith($"{path}.") == false)
                    break;
                this.ProcessProperty(classBlock, propertydefinitionsBlock, path);
            }

            return $"{this.gen.NameSpace(path)}.{name}";
        }


        void ProcessProperty(CodeBlockNested classBlock,
            CodeBlockNested propertiesBlock,
            String path)
        {
            const string fcn = "ProcessProperty";
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
            if (propertyName == "Value")
                propertyName = "ValueZ";

            String fullPropertyName;

            if ((ed.Type.Count == 1) && (ed.Type[0].Code == BackboneElement))
            {
                fullPropertyName = ProcessEntry(null, ed.Path, "Group", "Group", BackboneElement, $"Group definition of {ed.Path}", null);
            }
            else
            {
                fullPropertyName = $"{this.gen.NameSpace(path)}.{propertyName}";
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
                                sb.Append($"{or}{this.gen.NameSpace("Resource")}Resource");
                            }
                            else
                            {
                                foreach (string target in type.TargetProfile)
                                {
                                    String targetEntryName = target.LastUriPart().ToMachineName();
                                    sb.Append($"{or}{this.gen.NameSpace(targetEntryName)}.{targetEntryName}");
                                    or = " or ";
                                }
                            }
                            break;

                        default:
                            //if (type.Profile.Any())
                            //    throw new ConvertErrorException(this.GetType().Name, fcn, $"Unexpected profile in type {ed.Path}:{type.Code}.");
                            //if (type.TargetProfile.Any())
                            //    throw new ConvertErrorException(this.GetType().Name, fcn, $"Unexpected targetProfile in type {ed.Path}:{type.Code}.");
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
                                    sb.Append($"{or}{type.Code}");
                                    break;

                                case "CodeableConcept":
                                case "code":
                                    sb.Append($"{or}concept");
                                    break;

                                case "url":
                                case "canonical":
                                    sb.Append($"{or}uri");
                                    break;

                                default:
                                    sb.Append($"{or}{this.gen.NameSpace(type.Code)}.{type.Code.ToMachineName()}");
                                    break;
                            }
                            break;
                    }
                }

                propertiesBlock
                    .BlankLine()
                    .AppendLine($"// Entry definition of {ed.Path}")
                    .AppendCode($"Element: {propertyName}")
                    ;

                if (sb.Length > 0)
                {
                    propertiesBlock
                        .AppendCode($"Value: {sb.ToString()}")
                        ;
                }
            }

            classBlock
                .AppendCode($"Property: {fullPropertyName} {ed.Min}..{ed.Max}")
                ;
        }
    }
}
