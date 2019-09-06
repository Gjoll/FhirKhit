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
        enum SliceAccessorTypes
        {
            Error,
            Single,
            Multiple
        };

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
        Type fhirBaseClassType;

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
        public bool StartClass(String className, Type fhirBaseClassType)
        {
            this.fhirBaseClassType = fhirBaseClassType;
            this.className = className;
            string fhirTypeName = fhirBaseClassType.FriendlyName();

            this.classBlock = this.nameSpaceBlock.AppendBlock();
            this.classBlock
                .BlankLine()
                .Summary($"Extension class to add slicing helper methods to {fhirTypeName}")
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
                    this.gen.ConversionError(this.GetType().Name, fcn, $"Cant find child node '{pathPart}' in '{sliceNode.FullPath()}'");
                    return null;
                }
                node = next;
            }
            return node.Element.Fixed;
        }

        String FixName(String[] path) => this.PathName("Fix", path);
        String ValueFilterName(String[] path) => this.PathName("ValueFilter", path);
        String PathName(String prefix, String[] path)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(prefix);
            for (Int32 i = 1; i < path.Length; i++)
            {
                String pathPart = path[i].ToMachineName();
                sb.Append(pathPart);
            }
            return sb.ToString();
        }

        /// <summary>
        /// Create slices on indicated node.
        /// </summary>
        /// <param name="elementNode">Element node containing discriminator</param>
        /// <returns></returns>
        public bool CreateSlice(ElementNode elementNode)
        {
            const String fcn = nameof(CreateSlice);

            CodeBlockNested fields;
            CodeBlockNested methods;
            ElementDefinition.DiscriminatorComponent[] discriminators = null;
            bool retVal = true;
            String accessorType = String.Empty;
            String baseTypeName;
            String baseItemTypeName;

            bool DefineSliceOnValueDiscriminator(ElementNode sliceNode,
                ElementDefinition.DiscriminatorComponent discriminator,
                String term)
            {
                String sliceName = sliceNode.Element.SliceName;

                methods
                    .BlankLine()
                    .Summary($"Return all elements at discriminator path '{discriminator.Path}'")
                    ;
                String valueFilterMethod = this.ValueFilterName(this.MakePath(sliceNode.SlicePath(), discriminator.Path));
                Type leafType;
                if (this.GenerateSearchElements(methods, "static", valueFilterMethod, elementNode, discriminator.Path, out leafType) == true)
                {
                    fields
                        .AppendCode($"new SliceOnValueDiscriminator<{baseItemTypeName}, {leafType.FriendlyName()}>")
                        .OpenBrace()
                        .AppendCode($"Path = \"{discriminator.Path}\",")
                        .AppendCode($"Pattern = {this.FixName(this.MakePath(sliceNode.SlicePath(), discriminator.Path))}(),")
                        .AppendCode($"ValueFilter = {valueFilterMethod}")
                        .CloseBrace(term)
                    ;
                }
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
                        this.gen.ConversionError(this.GetType().Name, fcn, $"TODO: discriminator.Type {discriminator.Type} currently implemented. '{elementNode.FullPath()}'");
                        return false;
                }
            }

            void CreateSliceAccessor(ElementNode sliceNode, String sliceClassName, String sliceInterfaceName)
            {
                String sliceName = sliceNode.Element.SliceName;
                String propertyPath = sliceNode.PropertyName;

                String sliceBaseClassName;
                switch (SliceAccessorType(sliceNode))
                {
                    case SliceAccessorTypes.Error:
                        sliceBaseClassName = $"??";
                        break;

                    case SliceAccessorTypes.Single:
                        sliceBaseClassName = $"ISliceAccessorSingle<{accessorType}>";
                        break;

                    case SliceAccessorTypes.Multiple:
                        sliceBaseClassName = $"ISliceAccessorMultiple<{accessorType}>";
                        break;

                    default:
                        throw new NotImplementedException("Unknown SliceAccessorTypes value");
                }

                this.methodsBlock
                    .BlankLine()
                    .Summary($"Extension method to return slice {sliceName} on {elementNode.Name}")
                    .Example(
                        $"{this.fhirBaseClassType.FriendlyName()} resource = new {this.fhirBaseClassType.FriendlyName()}();",
                        $"{this.className}.{sliceInterfaceName} sliceAccessor = resource.{propertyPath}.{sliceName}();"
                        )
                    .AppendCode($"public static {sliceInterfaceName} {sliceName}(this {baseTypeName} item)")
                    .OpenBrace()
                    .AppendCode($"{sliceClassName} retVal = new {sliceClassName}(item);")
                    .AppendCode($"return retVal;")
                    .CloseBrace()
                    ;
            }

            SliceAccessorTypes SliceAccessorType(ElementNode sliceNode)
            {
                String baseType = sliceNode.FhirType.FriendlyName();

                if (sliceNode.IsListType)
                {
                    switch (sliceNode.Element.Max.ToMax())
                    {
                        case 0:
                            this.gen.ConversionError(this.GetType().Name, fcn, $"Slice node '{sliceNode.FullPath()}' has max of 0. Not sure what I am supposed to do!");
                            return SliceAccessorTypes.Error;

                        case 1:
                            return SliceAccessorTypes.Single;

                        default:
                            return SliceAccessorTypes.Multiple;
                    }
                }
                else
                {
                    this.gen.ConversionError(this.GetType().Name, fcn, $"Slice node '{sliceNode.FullPath()}' unknown base type {baseType}");
                    return SliceAccessorTypes.Error;
                }
            }

            void CreateSliceAccessorClass(ElementNode sliceNode,
                out String sliceClassName,
                out String sliceInterfaceName)
            {
                void CreateFixCode(ElementNode node)
                {
                    if (node.Element.Fixed != null)
                    {
                        FhirConstruct.Construct(methods,
                            node.Element.Fixed,
                            this.FixName(node.SlicePath()),
                            "static",
                            out String temp);
                    }
                    foreach (ElementNode child in node.Children)
                    {
                        CreateFixCode(child);
                    }
                }

                void CreateConstructor(String className, String fieldName)
                {
                    methods
                        .BlankLine()
                        .Summary($"{className} constructor")
                        .AppendCode($"public {className}({elementNode.FhirType.FriendlyName()} items)")
                        .OpenBrace()
                        .AppendCode($"this.Items = items;")
                        .AppendCode($"this.Slicing = {fieldName};")
                        .CloseBrace()
                        ;
                }

                String sliceName = sliceNode.Element.SliceName;
                sliceClassName = $"{sliceName}Impl";
                sliceInterfaceName = $"I{sliceName}";
                String sliceBaseClassName;
                String sliceBaseInterfaceName;
                String baseType = elementNode.FhirType.FriendlyName();

                switch (SliceAccessorType(sliceNode))
                {
                    case SliceAccessorTypes.Error:
                        sliceBaseClassName = "??";
                        sliceBaseInterfaceName = "??";
                        break;

                    case SliceAccessorTypes.Single:
                        sliceBaseClassName = $"SliceListAccessorSingle<{accessorType}>";
                        sliceBaseInterfaceName = $"ISliceAccessorSingle<{accessorType}>";
                        break;

                    case SliceAccessorTypes.Multiple:
                        sliceBaseClassName = $"SliceListAccessorMultiple<{accessorType}>";
                        sliceBaseInterfaceName = $"ISliceAccessorMultiple<{accessorType}>";
                        break;

                    default:
                        throw new NotImplementedException("Unknown SliceAccessorTypes value");
                }

                this.subClassBlock
                    .BlankLine()
                    .Summary($"public interface that implements the functionality of slice {sliceClassName}")
                    .AppendCode($"public interface {sliceInterfaceName} : {sliceBaseInterfaceName}")
                    .OpenBrace()
                    .CloseBrace()
                    .BlankLine()
                    .Summary($"private class that implements the functionality of slice {sliceClassName}")
                    .AppendCode($"class {sliceClassName} : {sliceBaseClassName}, {sliceInterfaceName}")
                    .OpenBrace()
                    ;

                fields = this.subClassBlock.AppendBlock();
                fields.AppendLine($"#region {this.className}.{sliceClassName} fields");

                methods = this.subClassBlock.AppendBlock();
                methods.AppendLine($"#region {this.className}.{sliceClassName} methods");

                this.subClassBlock
                    .CloseBrace()
                    ;

                if (sliceName == null)
                {
                    this.gen.ConversionError(this.GetType().Name, fcn, $"Slice node '{elementNode.FullPath()}' lacks slice name");
                    retVal = false;
                }
                else
                {
                    String sliceFieldName = $"slicing";

                    fields
                        .BlankLine()
                        .Summary($"slicing discriminator for {elementNode.FullPath()} slice {sliceName}")
                        .AppendCode($"static Slicing<{baseItemTypeName}> {sliceFieldName} = new Slicing<{baseItemTypeName}>")
                        .OpenBrace()
                        .AppendCode($"Discriminators = new ISliceDiscriminator<{baseItemTypeName}>[]")
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
                    CreateFixCode(sliceNode);
                }

                // Recursively crete code to set values that are fixed in object.
                // If a child object needs to be fixed, make sure that parent objects are created
                // as well.
                // i.e. if a.b.c = fix(...)
                // than we need to create a and a.b as well as setting a.b.c.
                void SetFixedValues(ElementNode setNode,
                    String propertyPath)
                {
                    Int32 varNum = 0;
                    foreach (ElementNode setNodeChild in setNode.Children)
                    {
                        String childPropertyPath = $"{propertyPath}.{setNodeChild.PropertyName}";

                        String varName = $"var{varNum}";
                        varNum += 1;

                        String childItemTypeName = setNodeChild.FhirItemType.FriendlyName();
                        if (setNodeChild.IsFixed)
                        {
                            methods.AppendCode($"{childItemTypeName} {varName} = {this.FixName(setNodeChild.SlicePath())}();");
                            if (setNodeChild.IsListType)
                                methods.AppendCode($"{childPropertyPath}.Add({varName});");
                            else
                                methods.AppendCode($"{childPropertyPath} = {varName};");
                        }
                        else if (setNodeChild.HasFixedChild)
                        {
                            methods.AppendCode($"{childItemTypeName} {varName} = new {childItemTypeName}();");
                            if (setNodeChild.IsListType)
                                methods.AppendCode($"{childPropertyPath}.Add({varName});");
                            else
                                methods.AppendCode($"{childPropertyPath} = {varName};");
                            SetFixedValues(setNodeChild, varName);
                        }
                    }
                }
                methods
                    .BlankLine()
                    .Summary($"Create and initialize a new item")
                    .AppendCode($"protected override {accessorType} Create()")
                    .OpenBrace()
                    .AppendCode($"{accessorType} retVal = new {accessorType}();")
                    ;
                SetFixedValues(sliceNode, "retVal");
                methods
                    .AppendCode($"return retVal;")
                    .CloseBrace()
                    ;

                fields.AppendLine($"#endregion  // {this.className}.{sliceClassName}  fields");
                methods.AppendLine($"#endregion // {this.className}.{sliceClassName}  methods");
            }

            if (elementNode is null)
                throw new ArgumentNullException(nameof(elementNode));

            baseTypeName = elementNode.FhirType.FriendlyName();
            baseItemTypeName = elementNode.FhirItemType.FriendlyName();

            ElementDefinition.SlicingComponent sliceComponent = elementNode.Element.Slicing;
            if (sliceComponent.Ordered == true)
            {
                this.gen.ConversionError(this.GetType().Name, fcn, $"TODO: Slicing.Ordered == true not currently implemented. '{elementNode.FullPath()}'");
                return false;
            }

            if (sliceComponent.Rules != ElementDefinition.SlicingRules.Open)
            {
                this.gen.ConversionError(this.GetType().Name, fcn, $"TODO: Slicing.Rules != Open not currently implemented. '{elementNode.FullPath()}'");
                return false;
            }

            discriminators = sliceComponent.Discriminator.ToArray();
            accessorType = elementNode.FhirItemType.FriendlyName();
            foreach (ElementNode sliceNode in elementNode.Slices)
            {
                CreateSliceAccessorClass(sliceNode, out String sliceClassName, out String sliceInterfaceName);
                CreateSliceAccessor(sliceNode, sliceClassName, sliceInterfaceName);
            }

            return retVal;
        }

        public String GetCode() => this.code.ToString();

        #region Fhir Path Methods
        /// <summary>
        /// Traverse children using simple fhir path query.
        /// Return selected elements, or null if not found.
        /// </summary>
        public bool GenerateSearchElements(CodeBlockNested block,
            String methodModifiers,
            String methodName,
            ElementNode node,
            String path,
            out Type leafType)
        {
            const String fcn = nameof(GenerateSearchElements);
            CodeBlockNested childBlock;
            Int32 childMethodCounter = 0;

            // Generate GetChild method.
            String GenerateGetChild(string childPropertyName,
                Type inputType,
                Type outputType)
            {
                if (childPropertyName is null)
                    throw new ArgumentNullException(nameof(childPropertyName));

                String inputTypeBaseName = inputType.FriendlyName();
                childMethodCounter += 1;
                String childMethodName = $"GetChild_{childMethodCounter}";
                String outputTypeItemName;
                if (outputType.IsList())
                    outputTypeItemName = outputType.GenericTypeArguments[0].FriendlyName();
                else
                    outputTypeItemName = outputType.FriendlyName();

                childBlock
                    .AppendCode($"IEnumerable<{outputTypeItemName}> {childMethodName}(IEnumerable<{inputTypeBaseName}> inputElements)")
                    .OpenBrace()
                    .AppendCode($"if (inputElements != null)")
                    .OpenBrace()
                    .AppendCode($"foreach ({inputTypeBaseName} inputElement in inputElements)")
                    .OpenBrace()
                    ;

                if (outputType.IsList())
                {
                    childBlock
                        .AppendCode($"foreach ({outputType.FriendlyName()} childElement in inputElement.{childPropertyName})")
                        .OpenBrace()
                        .AppendCode($"yield return childElement;")
                        .CloseBrace()
                   ;
                }
                else
                {
                    childBlock
                        .AppendCode($"yield return inputElement.{childPropertyName};")
                   ;
                }

                childBlock
                    .CloseBrace()
                    .CloseBrace()
                    .CloseBrace()
                    ;
                return childMethodName;
            }

            if (block is null)
                throw new ArgumentNullException(nameof(block));
            if (methodModifiers is null)
                throw new ArgumentNullException(nameof(methodModifiers));
            if (methodName is null)
                throw new ArgumentNullException(nameof(methodName));
            if (node is null)
                throw new ArgumentNullException(nameof(node));
            if (path is null)
                throw new ArgumentNullException(nameof(path));

            //String fhirTypeName = node.FhirType.FriendlyName();
            String fhirItemTypeName = node.FhirItemType.FriendlyName();
            // we need to write header after we determine leaf node type.
            CodeBlockNested methodHeaderBlock = block.AppendBlock();

            block
                .OpenBrace()
                .BlankLine()
                ;

            childBlock = block.AppendBlock();

            String[] pathItems = path.Split('.');
            Int32 i = 0;

            if (pathItems[0] == node.Name)
                i += 1;

            Int32 resultCounter = 0;
            leafType = null;
            String resultThis = "head";

            while (i < pathItems.Length)
            {
                resultCounter += 1;
                String resultNext = $"result{resultCounter}";

                String pathItem = pathItems[i++];
                if (pathItem.StartsWith("resolve("))
                {
                    this.gen.ConversionError(this.GetType().Name, fcn, $"TODO: FhirPath operator {pathItem} not implemented");
                    return false;
                }
                else if (pathItem.StartsWith("extension(\""))
                {
                    this.gen.ConversionError(this.GetType().Name, fcn, $"TODO: FhirPath operator {pathItem} not implemented");
                    return false;
                }
                else if (pathItem.StartsWith("ofType("))
                {
                    this.gen.ConversionError(this.GetType().Name, fcn, $"TODO: FhirPath operator {pathItem} not implemented");
                    return false;
                }
                else
                {
                    if (node.TryGetChild(pathItem, out ElementNode next) == false)
                    {
                        if (node.TryGetCommonChild(pathItem, out next) == false)
                        {
                            this.gen.ConversionError(this.GetType().Name, fcn, $"Child {pathItem} not found");
                            return false;
                        }
                    }

                    Type nodeType = node.FhirItemType;
                    PropertyInfo childProperty = nodeType.GetPropertyByFhirName(pathItem);
                    String childPropertyName = childProperty.Name;
                    String childMethodName = GenerateGetChild(childPropertyName, nodeType, childProperty.PropertyType);

                    block.AppendCode($"IEnumerable<{next.FhirItemType.FriendlyName()}> {resultNext} = {childMethodName}({resultThis});");
                    resultThis = resultNext;
                    node = next;
                }
                block.AppendCode($"return {resultThis};");
            }

            block
                .CloseBrace()
                ;

            leafType = node.FhirItemType;

            methodHeaderBlock
                .AppendCode($"{methodModifiers} IEnumerable<{leafType.FriendlyName()}> {methodName}(IEnumerable<{fhirItemTypeName}> head)")
            ;
            return true;
        }

        /// <summary>
        /// Create method to set element at indicated path to passed value.
        /// </summary>
        public bool GenerateSetElements(CodeBlockNested block,
            ElementNode node,
            String baseName,
            String path,
            String leafNodeValue = null)
        {
            const String fcn = nameof(GenerateSetElements);
            CodeBlockNested childBlock;

            void GenerateSetChildCode(ref string containerName,
                Type containerType,
                string itemName,
                Type itemType,
                String value)
            {
                if (containerName is null)
                    throw new ArgumentNullException(nameof(containerName));
                if (itemName is null)
                    throw new ArgumentNullException(nameof(itemName));

                String containerTypeName = containerType.FriendlyName();
                String itemTypeName = itemType.FriendlyName();

                if (value == null)
                    value = $"new {itemTypeName}()";

                if (containerType.IsList())
                {
                    childBlock
                        .AppendCode($"if ({containerName}.Count == 0)")
                        .AppendCode($"    {containerName}.Add({value});")
                        ;
                    containerName = $"{containerName}[0].{itemName}";
                }
                else
                {
                    childBlock
                        .AppendCode($"if ({containerName}.{itemName} == null)")
                        .AppendCode($"    {containerName}.{itemName} = {value};")
                        ;
                    containerName = $"{containerName}.{itemName}";
                }
            }

            if (block is null)
                throw new ArgumentNullException(nameof(block));
            if (node is null)
                throw new ArgumentNullException(nameof(node));
            if (path is null)
                throw new ArgumentNullException(nameof(path));

            String[] pathItems = path.Split('.');
            Int32 i = 0;

            if (pathItems[0] == node.Name)
                i += 1;

            childBlock = block.AppendBlock();
            String fullName = baseName;
            while (i < pathItems.Length)
            {
                String pathItem = pathItems[i];
                if (pathItem.StartsWith("resolve("))
                {
                    this.gen.ConversionError(this.GetType().Name, fcn, $"TODO: FhirPath operator {pathItem} not implemented");
                    return false;
                }
                else if (pathItem.StartsWith("extension(\""))
                {
                    this.gen.ConversionError(this.GetType().Name, fcn, $"TODO: FhirPath operator {pathItem} not implemented");
                    return false;
                }
                else if (pathItem.StartsWith("ofType("))
                {
                    this.gen.ConversionError(this.GetType().Name, fcn, $"TODO: FhirPath operator {pathItem} not implemented");
                    return false;
                }
                else
                {
                    if (node.TryGetChild(pathItem, out ElementNode next) == false)
                    {
                        if (node.TryGetCommonChild(pathItem, out next) == false)
                        {
                            this.gen.ConversionError(this.GetType().Name, fcn, $"Child {pathItem} not found");
                            return false;
                        }
                    }

                    PropertyInfo childProperty = node.FhirItemType.GetPropertyByFhirName(pathItem);
                    String value = null;
                    if (i == pathItems.Length - 1)
                        value = leafNodeValue;
                    GenerateSetChildCode(ref fullName, node.FhirItemType, childProperty.Name, next.FhirType, value);
                    node = next;
                }
                i += 1;
            }
            return true;
        }
        #endregion

        public String[] MakePath(String subPath)
        {
            if (subPath is null)
                throw new ArgumentNullException(nameof(subPath));

            List<String> retVal = new List<string>();
            foreach (String pathPart in subPath.Split('.'))
            {
                foreach (String pathPart2 in pathPart.Split(':'))
                    retVal.Add(pathPart2);
            }
            return retVal.ToArray();
        }

        public String[] MakePath(String[] basePath, String subPath)
        {
            List<String> retVal = new List<string>(basePath);
            retVal.AddRange(MakePath(subPath));
            return retVal.ToArray();
        }
    }
}
