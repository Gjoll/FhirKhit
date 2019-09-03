﻿using FhirKhit.SliceGen.CodeGen;
using FhirKhit.SliceGen.R4;
using FhirKhit.Tools;
using Hl7.Fhir.ElementModel;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using ElementNode = FhirKhit.SliceGen.R4.ElementNode;

namespace FhirKhit.SliceGen.CSApi
{
    public class CSCodeFormatter : ICodeFormatter
    {
        String className;
        CodeEditor code;
        CodeBlockNested nameSpaceBlock;
        CodeBlockNested classBlock;
        CodeBlockNested fieldsBlock;
        CodeBlockNested methodsBlock;
        CodeBlockNested subClassBlock;

        SliceGenerator gen;

        /// <summary>
        /// Type of the fhir resource class that the profile is derived from (the resource it profiles)
        /// </summary>
        Type fhirType;

        public CSCodeFormatter(SliceGenerator gen)
        {
            this.gen = gen;
            this.code = new CodeEditor();
        }


        /// <summary>
        /// Start namespace.
        /// </summary>
        public bool StartNameSpace(String nameSpace)
        {
            this.nameSpaceBlock = this.code.Blocks.AppendBlock();
            this.nameSpaceBlock
                .AppendCode($"/*")
                .AppendCode($" * Code in this class was auto generated by SliceGen")
                .AppendCode($"*/")
                .AppendCode($"using System;")
                .AppendCode($"using System.Linq;")
                .AppendCode($"using System.Collections.Generic;")
                .AppendCode($"using System.Reflection;")
                .AppendCode($"using System.Text;")
                .AppendCode($"using Hl7.Fhir.Model;")
                .AppendCode($"using FhirKhit.SliceGen.ShareLib;")
                .BlankLine()
                .AppendCode($"namespace {nameSpace}")
                .OpenBrace()
                ;
            return true;
        }

        /// <summary>
        /// End namespace.
        /// </summary>
        public bool EndNameSpace()
        {
            this.nameSpaceBlock
                .CloseBrace()
                ;
            this.nameSpaceBlock = null;
            return true;
        }

        /// <summary>
        /// Start creating a class.
        /// </summary>
        public bool StartClass(String className, Type fhirType)
        {
            this.className = className;
            string fhirTypeName = fhirType.FriendlyName();

            this.classBlock = this.nameSpaceBlock.AppendBlock();
            this.classBlock
                .OpenSummary()
                .AppendLine($"/// Extension class to add slicing helper methods to {fhirTypeName}")
                .CloseSummary()
                .AppendLine($"public static class {className}")
                .OpenBrace()
                ;

            this.subClassBlock = classBlock.AppendBlock();
            this.subClassBlock.AppendLine($"#region {className} sub classes");

            this.fieldsBlock = classBlock.AppendBlock();
            this.fieldsBlock.AppendLine($"#region fields {className} fields");

            this.methodsBlock = classBlock.AppendBlock();
            this.methodsBlock.AppendLine($"#region methods {className} methods");

            return true;
        }

        /// <summary>
        /// End creating a class.
        /// </summary>
        public bool EndClass()
        {
            this.classBlock
                .CloseBrace()
                ;

            this.subClassBlock
                .AppendLine($"#endregion")
                ;

            this.fieldsBlock
                .AppendLine($"#endregion")
                ;

            this.methodsBlock
                .AppendLine($"#endregion")
                ;

            fieldsBlock = null;
            methodsBlock = null;

            this.classBlock = null;
            return true;
        }

        Element GetItem(ElementNode sliceNode, String path)
        {
            const String fcn = nameof(GetItem);

            String[] pathParts = path.Split('.');
            ElementNode node = sliceNode;
            for (Int32 i = 0; i < pathParts.Length; i++)
            {
                String pathPart = pathParts[i];
                ElementNode next = null;
                foreach (ElementNode n in node.Children)
                {
                    if (n.Name == pathPart)
                    {
                        next = n;
                        break;
                    }
                }
                if (next == null)
                {
                    this.gen.ConversionError(this.GetType().Name, fcn, $"Cant find child node '{pathPart}' in '{sliceNode.Path}'");
                    return null;
                }
                node = next;
            }
            return node.Element.Fixed;
        }

        /// <summary>
        /// Create slices on indicated node.
        /// </summary>
        /// <param name="elementNode">Element node containing discriminator</param>
        /// <returns></returns>
        public bool CreateSlice(ElementNode elementNode)
        {
            const String fcn = nameof(CreateSlice);

            Int32 patternCount = 1;
            CodeBlockNested fields;
            CodeBlockNested methods;
            CodeBlockNested methodCreate;
            ElementDefinition.DiscriminatorComponent[] discriminators = null;
            bool retVal = true;
            String accessorType = String.Empty;

            bool DefineSliceOnValueDiscriminator(ElementNode sliceNode,
                ElementDefinition.DiscriminatorComponent discriminator,
                String term)
            {
                Element b = this.GetItem(sliceNode, discriminator.Path);
                if (b == null)
                    return false;

                String sliceName = sliceNode.Element.SliceName;

                String patternMethod = $"Fix_{patternCount}";
                patternCount += 1;

                methods
                    .OpenSummary()
                    .AppendSummary($"Method to define fixed field used in slice accessor.")
                    .CloseSummary()
                    ;
                FhirConstruct.Construct(methods, b, patternMethod, "static", out String temp);

                methods
                    .OpenSummary()
                    .AppendSummary($"Return all elements at discriminator path '{discriminator.Path}'")
                    .CloseSummary()
                    ;
                String fhirPathMethod = "GetDiscriminatorElements";
                {
                    GenerateSimpleFhirPathMethod gi = new GenerateSimpleFhirPathMethod(this.gen);
                    gi.GenerateSearchElements(methods, "private", fhirPathMethod, elementNode, discriminator.Path);
                }

                fields
                    .AppendCode($"new SliceOnValueDiscriminator")
                    .OpenBrace()
                    .AppendCode($"Path = \"{discriminator.Path}\",")
                    .AppendCode($"Pattern = {patternMethod}()")
                    .CloseBrace(term)
                ;

                GenerateSimpleFhirPathMethod g = new GenerateSimpleFhirPathMethod(this.gen);
                g.GenerateSetElements(methodCreate, elementNode, "retVal", discriminator.Path, $"{patternMethod}()");

                return true;
            }

            bool DefineDiscriminator(ElementNode sliceNode,
                ElementDefinition.DiscriminatorComponent discriminator,
                String term)
            {
                switch (discriminator.Type)
                {
                    case ElementDefinition.DiscriminatorType.Value:
                        return DefineSliceOnValueDiscriminator(sliceNode, discriminator, term);

                    default:
                        this.gen.ConversionError(this.GetType().Name, fcn, $"TODO: discriminator.Type {discriminator.Type} currently implemented. '{elementNode.Path}'");
                        return false;
                }
            }

            void CreateSliceAccessor(ElementNode sliceNode, String sliceClassName)
            {
                String sliceName = sliceNode.Element.SliceName;
                String baseTypeName = elementNode.FhirType.FriendlyName();

                this.methodsBlock
                    .OpenSummary()
                    .AppendSummary($"Extension method to return slice {sliceName} on {elementNode.Name}")
                    .CloseSummary()
                    .AppendCode($"public static {sliceClassName} {sliceName}(this {baseTypeName} item)")
                    .OpenBrace()
                    .AppendCode($"{sliceClassName} retVal = new {sliceClassName}(item);")
                    .AppendCode($"return retVal;")
                    .CloseBrace()
                    ;
            }

            void CreateSliceAccessorClass(ElementNode sliceNode, out String sliceClassName)
            {
                void CreateConstructor(String className, String fieldName)
                {
                    methods
                        .OpenSummary()
                        .AppendSummary($"{className} constructor")
                        .CloseSummary()
                        .AppendCode($"public {className}({elementNode.FhirType.FriendlyName()} items)")
                        .OpenBrace()
                        .AppendCode($"this.items = items;")
                        .AppendCode($"this.Slicing = {fieldName};")
                        .CloseBrace()
                        ;
                }

                String sliceName = sliceNode.Element.SliceName;
                sliceClassName = $"{sliceName}Impl";
                String sliceBaseClassName;
                String baseType = elementNode.FhirType.FriendlyName();

                if (baseType.StartsWith("List<"))
                {
                    switch (sliceNode.Element.Max.ToMax())
                    {
                        case 0:
                            this.gen.ConversionError(this.GetType().Name, fcn, $"Slice node '{elementNode.Path}' has max of 0. Not sure what I am supposed to do!");
                            retVal = false;
                            return;

                        case 1:
                            sliceBaseClassName = $"SliceListAccessorSingle<{accessorType}>";
                            break;

                        default:
                            sliceBaseClassName = $"SliceListAccessorMultiple<{accessorType}>";
                            break;
                    }
                }
                else
                {
                    this.gen.ConversionError(this.GetType().Name, fcn, $"Slice node '{elementNode.Path}' unknown base type {baseType}");
                    retVal = false;
                    return;
                }

                this.subClassBlock
                    .AppendCode($"public class {sliceClassName} : {sliceBaseClassName}")
                    .OpenBrace()
                    ;

                fields = this.subClassBlock.AppendBlock();
                fields.AppendLine($"#region {this.className}.{sliceClassName} fields");

                methods = this.subClassBlock.AppendBlock();
                methods.AppendLine($"#region {this.className}.{sliceClassName} methods");
                methodCreate = methods.AppendBlock();

                this.subClassBlock
                    .CloseBrace()
                    ;

                methodCreate
                    .OpenSummary()
                    .AppendSummary($"Create and initialize a new item")
                    .CloseSummary()
                    .AppendCode($"protected override {accessorType} Create()")
                    .OpenBrace()
                    .AppendCode($"{accessorType} retVal = new {accessorType}();")
                    ;

                patternCount = 1;
                if (sliceName == null)
                {
                    this.gen.ConversionError(this.GetType().Name, fcn, $"Slice node '{elementNode.Path}' lacks slice name");
                    retVal = false;
                }
                else
                {
                    String sliceFieldName = $"slicing";

                    fields
                        .OpenSummary()
                        .AppendSummary($"Pointer to element containing all slice(s) elements")
                        .CloseSummary()
                        .OpenSummary()
                        .AppendSummary($"slicing discriminator for {elementNode.Path} slice {sliceName}")
                        .CloseSummary()
                        .AppendCode($"static Slicing {sliceFieldName} = new Slicing")
                        .OpenBrace()
                        .AppendCode($"Discriminators = new ISliceDiscriminator[]")
                        .OpenBrace()
                        ;

                    for (Int32 i = 0; i < discriminators.Length; i++)
                    {
                        ElementDefinition.DiscriminatorComponent discriminator = discriminators[i];
                        String term = (i < discriminators.Length - 1) ? "," : "";
                        if (DefineDiscriminator(sliceNode, discriminator, term) == false)
                            retVal = false;
                    }

                    fields
                        .CloseBrace()
                        .CloseBrace(";")
                        ;

                    CreateConstructor(sliceClassName, sliceFieldName);
                }

                methodCreate
                    .AppendCode($"return retVal;")
                    .CloseBrace()
                    ;

                fields.AppendLine($"#endregion  // {this.className}.{sliceClassName}  fields");
                methods.AppendLine($"#endregion // {this.className}.{sliceClassName}  methods");
            }

            if (elementNode is null)
                throw new ArgumentNullException(nameof(elementNode));

            ElementDefinition.SlicingComponent sliceComponent = elementNode.Element.Slicing;
            if (sliceComponent.Ordered == true)
            {
                this.gen.ConversionError(this.GetType().Name, fcn, $"TODO: Slicing.Ordered == true not currently implemented. '{elementNode.Path}'");
                return false;
            }

            if (sliceComponent.Rules != ElementDefinition.SlicingRules.Open)
            {
                this.gen.ConversionError(this.GetType().Name, fcn, $"TODO: Slicing.Rules != Open not currently implemented. '{elementNode.Path}'");
                return false;
            }

            discriminators = sliceComponent.Discriminator.ToArray();
            accessorType = elementNode.FhirItemType.FriendlyName();
            foreach (ElementNode sliceNode in elementNode.Slices)
            {
                CreateSliceAccessorClass(sliceNode, out String sliceClassName);
                CreateSliceAccessor(sliceNode, sliceClassName);
            }

            return retVal;
        }

        public String GetCode() => this.code.ToString();
    }
}
