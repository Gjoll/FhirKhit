using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
        }

        public void Constrain()
        {
            //const string fcn = "Constrain";

            // Modify the path to start with the constrained class name, not the base class name as
            // constraints do by default.
            ElementDefinition[] elements = this.sDef.Differential.Element.ToArray();
            this.elements = new ElementDefinition[elements.Length];
            for (Int32 i = 0; i < elements.Length; i++)
            {
                ElementDefinition e = elements[i];
                e.Path = $"{this.sDef.Id}.{e.Path.SkipFirstPathPart()}";
                this.elements[i] = e;
            }
            Specialize();
        }

        public void Specialize()
        {
            const string fcn = "Specialize";

            this.elements = this.sDef.Differential.Element.ToArray();
            this.elementIndex = 1;

            String typeName;
            switch (this.sDefInfo.TFlag)
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

            String parent = this.sDef.BaseDefinition?.LastUriPart();
            String description = this.gen.ToDescription(this.sDef.Description);
            this.ProcessEntry(this.sDef.Id, null, typeName, parent, description, this.sDef.Url);
        }


        /// <summary>
        /// Create new file containing the definition for the new item.
        /// The new entry is created in its own namespace.
        /// </summary>
        void ProcessEntry(String path,
            String suffix,
            String typeName,
            String parent,
            String description,
            String comment)
        {
            const string fcn = "ProcessEntry";

            switch (path)
            {
                // Hand code "Element" type. Element appears to have a non standard typeref
                // which the c# library doesn't handle (_code = extension....)
                case "Element":
                    {
                        ElementDefinition sole = this.elements[0];
                        this.elements = new ElementDefinition[] {sole};
                        CodeBlockNested mapBlock = this.gen.CreateMapEditor(path);
                        this.ProcessSubEntry(0, mapBlock, path, path, suffix, typeName, parent, description, comment);
                        if (this.elementIndex != this.elements.Length)
                            throw new ConvertErrorException(this.GetType().Name, fcn, $"Internal error. ElementIndex not correct");
                    }
                    break;

                case "StructureDefinition":
                case "ElementDefinition":
                case "Bundle":
                case "CodeableConcept":
                case "Coding":

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
                    break;

                default:
                    {
                        CodeBlockNested mapBlock = this.gen.CreateMapEditor(path);
                        this.ProcessSubEntry(0, mapBlock, path, path, suffix, typeName, parent, description, comment);
                        if (this.elementIndex != this.elements.Length)
                            throw new ConvertErrorException(this.GetType().Name, fcn, $"Internal error. ElementIndex not correct");
                    }
                    break;
            }
        }

        /// <summary>
        /// Create new file containing the definition for the new item.
        /// The new entry is created in its own namespace.
        /// </summary>
        String ProcessSubEntry(Int32 indent,
            CodeBlockNested mapBlock,
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
                .BlankLine()
                .AppendComment(comment)
                .AppendCode($"{typeName}: {entryName}")
                ;

            if (indent == 0)
            {
                mapBlock
                    .BlankLine()
                    .AppendCode($"{entryPath} maps to {elementPath}:")
                    ;
            }
            else
            {
                mapBlock
                    .BlankLine()
                    .AppendCode($"    {entryPath.SkipFirstPathPart()} maps to {elementPath.SkipFirstPathPart()}")
                    ;
            }

            switch (parent)
            {
                case null:
                case "Resource":
                case "Element":
                    break;

                default:
                    this.gen.AddResourceToProcess(parent, false);
                    classBlock.AppendCode($"Parent: {this.gen.NameSpace(parent)}.{parent}");
                    break;
            }
            classBlock
                .AppendCode($"Description: \"{description}\"")
                ;

            while (this.elementIndex < this.elements.Length)
            {
                ElementDefinition subElement = this.elements[this.elementIndex];
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

            ElementDefinition ed = this.elements[this.elementIndex++];

            // Note: Currently we do not handle extensions.
            if (ed.Path.LastPathPart() == "extension")
                return;
            if (ed.Path.LastPathPart() == "modifierExtension")
                return;

            if (String.IsNullOrEmpty(ed.SliceName) == false)
            {
                this.gen.ConversionWarn(this.GetType().Name, fcn, "Ignoring slice");
            }
            if (ed.Slicing != null)
            {
                this.gen.ConversionWarn(this.GetType().Name, fcn, "Ignoring slicing");
            }

            //if (ed.Fixed != null)
            //    throw new ConvertErrorException(this.GetType().Name, fcn, $"Unexpected Fixed in element {ed.Path}.");
            //if (ed.Pattern != null)
            //    throw new ConvertErrorException(this.GetType().Name, fcn, $"Unexpected Pattern in element {ed.Path}.");

            String propertyName = ed.Path.LastPathPart().ToMachineName();
            if (propertyName == "Value")
                propertyName = "ValueZ";
            if (propertyName == entryName)
                propertyName = $"{propertyName}Value";

            String fullPropertyName;
            String propertyPath = $"{entryPath}.{propertyName}";

            if (this.ContainsType(ed, BackboneElementStr))
            {
                if (ed.Type.Count != 1)
                    throw new ConvertErrorException(this.GetType().Name, fcn, $"Backbone element {ed.Path} has multiple types.");
                if (this.HasChildren(ed) == false)
                    throw new ConvertErrorException(this.GetType().Name, fcn, $"Backbone element {ed.Path} has no children.");

                fullPropertyName = this.ProcessSubEntry(indent + 1, mapBlock, ed.Path, propertyPath, "Group", "Group", BackboneElementStr, $"Group definition of {ed.Path}", null);
            }
            else if (this.ContainsType(ed, ElementStr))
            {
                if (ed.Type.Count != 1)
                    throw new ConvertErrorException(this.GetType().Name, fcn, $"Element {ed.Path} has multiple types.");
                if (this.HasChildren(ed) == false)
                    throw new ConvertErrorException(this.GetType().Name, fcn, $"Element {ed.Path} has no children.");

                fullPropertyName = this.ProcessSubEntry(indent + 1, mapBlock, ed.Path, propertyPath, "Group", "Group", ElementStr, $"Group definition of {ed.Path}", null);
            }
            else
            {
                propertiesBlock
                    .BlankLine()
                    .AppendLine($"// Entry definition of {ed.Path}")
                    .AppendCode($"Element: {propertyName}")
                    ;

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

                mapBlock.AppendCode($"    {propertyPath.SkipFirstPathPart()} maps to {ed.Path.SkipFirstPathPart()}");
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
                        case "Coding":
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
                                this.gen.AddResourceToProcess("Resource", true);
                                OutputType($"{this.gen.NameSpace("Resource")}.Resource");
                            }
                            else
                            {
                                foreach (string target in type.TargetProfile)
                                {
                                    this.gen.AddResourcePathToProcess(target, true);
                                    String targetEntryName = target.LastUriPart().ToMachineName();
                                    OutputType($"{this.gen.NameSpace(targetEntryName)}.{targetEntryName}");
                                }
                            }
                            break;

                        default:

                            if (type.Profile.Count() == 0)
                            {
                                this.gen.AddResourceToProcess(type.Code, true);
                                OutputType($"{this.gen.NameSpace(type.Code)}.{type.Code.ToMachineName()}");
                            }
                            else
                            {
                                foreach (string profile in type.Profile)
                                {
                                    this.gen.AddResourcePathToProcess(profile, true);
                                    String profileName = profile.LastUriPart().ToMachineName();
                                    OutputType($"{this.gen.NameSpace(profileName)}.{profileName}");
                                }
                            }


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
