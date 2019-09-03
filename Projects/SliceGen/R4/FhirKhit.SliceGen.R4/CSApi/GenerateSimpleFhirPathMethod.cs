using FhirKhit.SliceGen.CodeGen;
using FhirKhit.SliceGen.R4;
using FhirKhit.Tools;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace FhirKhit.SliceGen.CSApi
{
    public class GenerateSimpleFhirPathMethod
    {
        SliceGenerator gen;

        public GenerateSimpleFhirPathMethod(SliceGenerator gen)
        {
            this.gen = gen;
        }

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
                String outputTypeBaseName = outputType.FriendlyName();
                childMethodCounter += 1;
                String childMethodName = $"GetChild_{childMethodCounter}";
                String outputTypeItemName;
                if (outputTypeBaseName.StartsWith("List<"))
                    outputTypeItemName = outputType.GenericTypeArguments[0].FriendlyName();
                else
                    outputTypeItemName = outputTypeBaseName;


                childBlock
                    .AppendCode($"IEnumerable<{outputTypeItemName}> {childMethodName}(IEnumerable<{inputTypeBaseName}> inputElements)")
                    .OpenBrace()
                    .AppendCode($"if (inputElements != null)")
                    .OpenBrace()
                    .AppendCode($"foreach ({inputTypeBaseName} inputElement in inputElements)")
                    .OpenBrace()
                    ;

                if (outputType.FriendlyName().StartsWith("List<"))
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
                    if (
                        (node.TryGetChild(pathItem, out ElementNode next) == false) ||
                        (next == null)
                        )
                    {
                        this.gen.ConversionError(this.GetType().Name, fcn, $"Child {pathItem} not found");
                        return false;
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
        /// Create method to set element at indicated path to pased value.
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

                if (containerTypeName.StartsWith("List<"))
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
                    if (
                        (node.TryGetChild(pathItem, out ElementNode next) == false) ||
                        (next == null)
                        )
                    {
                        this.gen.ConversionError(this.GetType().Name, fcn, $"Child {pathItem} not found");
                        return false;
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
    }
}
