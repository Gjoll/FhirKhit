using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace FhirKhit.CIMPL.DirectFhir
{
    /// <summary>
    /// Create a single fhir structuredefinition to its CIMPL equivalent.
    /// </summary>
    class ConvertFhirClass
    {
        DirectFhirGenerator gen;
        DirectFhirGenerator.SDefInfo sDefInfo;
        StructureDefinition sDef;
        Int32 elementIndex;
        ElementDefinition[] elements;

        public ConvertFhirClass(DirectFhirGenerator gen,
            DirectFhirGenerator.SDefInfo sDefInfo)
        {
            this.sDefInfo = sDefInfo;
            this.gen = gen;
            this.sDef = this.sDefInfo.SDef;
            this.elements = sDef.Differential.Element.ToArray();
            elementIndex = 1;
        }

        public void Convert()
        {
            const string fcn = "Convert";

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

            String parent = sDef.BaseDefinition?.LastUriPart();
            String description = this.gen.ToDescription(sDef.Description);
            String entryName = ProcessEntry(sDef.ToFormatedJson(), elements[0].Path, null, typeName, parent, description, sDef.Url);

            if (elementIndex != elements.Length)
                throw new ConvertErrorException(this.GetType().Name, fcn, $"Internal error. ElementIndex not correct");
        }


        /// <summary>
        /// Create new file containing the definition for the new item.
        /// The new entry is created in its own namespace.
        /// </summary>
        String ProcessEntry(String json,
            String path,
            String suffix,
            String typeName,
            String parent,
            String description,
            String comment)
        {
            CodeBlockNested mapBlock = this.gen.CreateMapEditor(path);
            return ProcessSubEntry(0, mapBlock, json, path, path, suffix, typeName, parent, description, comment);
        }

        String IndentStr(Int32 indent)
        {
            StringBuilder sb = new StringBuilder();
            for (Int32 i = 0; i < indent; i++)
                sb.Append("    ");
            return sb.ToString();
        }
        /// <summary>
        /// Create new file containing the definition for the new item.
        /// The new entry is created in its own namespace.
        /// </summary>
        String ProcessSubEntry(Int32 indent,
            CodeBlockNested mapBlock,
            String json,
            String elementPath,
            String entryPath,
            String suffix,
            String typeName,
            String parent,
            String description,
            String comment)
        {
            CodeBlockNested entryBlock = this.gen.CreateEntryEditor(elementPath);
            CodeBlockNested classBlock = entryBlock.AppendBlock();
            CodeBlockNested propertydefinitionsBlock = entryBlock.AppendBlock();

            String entryName = elementPath.LastPathPart().ToMachineName();
            if (String.IsNullOrEmpty(suffix) == false)
            {
                entryName += suffix;
                entryPath += suffix;
            }
            classBlock
                .AppendComment(json)
                .BlankLine()
                .AppendComment(comment)
                .AppendCode($"{typeName}: {entryName}")
                ;

            String mapColon = (indent == 0) ? ":" : "";
            mapBlock
                .BlankLine()
                .AppendCode($"{IndentStr(indent)}{entryPath} maps to {elementPath}{mapColon}")
                ;

            switch (parent)
            {
                case null:
                case "Resource":
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
                if (subElement.Path.StartsWith($"{elementPath}.") == false)
                    break;
                this.ProcessProperty(indent, classBlock, propertydefinitionsBlock, mapBlock, elementPath, entryPath, entryName);
            }

            return $"{this.gen.NameSpace(elementPath)}.{entryName}";
        }


        bool HasChildren(ElementDefinition ed)
        {
            if (this.elementIndex >= this.elements.Length)
                return false;
            if (this.elements[this.elementIndex].Path.StartsWith($"{ed.Path}.") == false)
                return false;
            return true;
        }

        bool ContainsType(ElementDefinition ed, String code)
        {
            if (ed.Type == null)
                return false;
            foreach (var type in ed.Type)
            {
                if (type.Code == code)
                    return true;
            }
            return false;
        }

        void ProcessProperty(Int32 indent,
            CodeBlockNested classBlock,
            CodeBlockNested propertiesBlock,
            CodeBlockNested mapBlock,
            String elementPath,
            String entryPath,
            String entryName)
        {
            const string fcn = "ProcessProperty";
            const String BackboneElementStr = "BackboneElement";
            const String ElementStr = "Element";

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
            if (propertyName == entryName)
                propertyName = $"{propertyName}Value";

            String fullPropertyName;

            propertiesBlock
                .BlankLine()
                .AppendLine($"// Entry definition of {ed.Path}")
                .AppendCode($"Element: {propertyName}")
                ;

            String propertyPath = $"{entryPath}.{propertyName}";
            mapBlock.AppendLine($"{IndentStr(indent+1)}{propertyPath} maps to {ed.Path}");

            if (this.ContainsType(ed, BackboneElementStr))
            {
                if (ed.Type.Count != 1)
                    throw new ConvertErrorException(this.GetType().Name, fcn, $"Backbone element {ed.Path} has multiple types.");
                if (this.HasChildren(ed) == false)
                    throw new ConvertErrorException(this.GetType().Name, fcn, $"Backbone element {ed.Path} has no children.");

                fullPropertyName = ProcessSubEntry(indent + 1, mapBlock, null, ed.Path, propertyPath, "Group", "Group", BackboneElementStr, $"Group definition of {ed.Path}", null);
            }
            else if (this.ContainsType(ed, ElementStr))
            {
                if (ed.Type.Count != 1)
                    throw new ConvertErrorException(this.GetType().Name, fcn, $"Element {ed.Path} has multiple types.");
                if (this.HasChildren(ed) == false)
                    throw new ConvertErrorException(this.GetType().Name, fcn, $"Element {ed.Path} has no children.");

                fullPropertyName = ProcessSubEntry(indent + 1, mapBlock, null, ed.Path, propertyPath, "Group", "Group", ElementStr, $"Group definition of {ed.Path}", null);
            }
            else
            {
                HashSet<String> outputTypes = new HashSet<string>();
                bool firstFlag = true;
                void OutputType(String pType)
                {
                    if (outputTypes.Contains(pType))
                        return;
                    outputTypes.Add(pType);
                    if (firstFlag)
                        propertiesBlock.AppendCode($"Value: {pType}");
                    else
                        propertiesBlock.AppendCode($"    or {pType}");
                    firstFlag = false;
                }

                fullPropertyName = $"{this.gen.NameSpace(elementPath)}.{propertyName}";
                foreach (ElementDefinition.TypeRefComponent type in ed.Type)
                {
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
                            OutputType($"{type.Code}");
                            break;

                        case "CodeableConcept":
                        case "code":
                            OutputType($"concept");
                            break;

                        case "uuid":
                        case "url":
                        case "canonical":
                            OutputType($"uri");
                            break;

                        case "Reference":
                            if (type.Profile.Any())
                                throw new ConvertErrorException(this.GetType().Name, fcn, $"Unexpected profile in type {ed.Path}:{type.Code}.");
                            if (type.TargetProfile.Count() == 0)
                            {
                                OutputType($"{this.gen.NameSpace("Resource")}.Resource");
                            }
                            else
                            {
                                foreach (string target in type.TargetProfile)
                                {
                                    String targetEntryName = target.LastUriPart().ToMachineName();
                                    OutputType($"{this.gen.NameSpace(targetEntryName)}.{targetEntryName}");
                                }
                            }
                            break;

                        default:
                            OutputType($"{this.gen.NameSpace(type.Code)}.{type.Code.ToMachineName()}");
                            break;
                    }
                }
            }

            classBlock
                .AppendCode($"Property: {fullPropertyName} {ed.Min}..{ed.Max}")
                ;
        }
    }
}
