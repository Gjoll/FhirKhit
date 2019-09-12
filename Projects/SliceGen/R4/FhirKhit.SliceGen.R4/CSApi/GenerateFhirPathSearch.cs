using FhirKhit.SliceGen.CodeGen;
using FhirKhit.SliceGen.R4;
using FhirKhit.Tools;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace FhirKhit.SliceGen.CSApi
{
    /// <summary>
    /// Generate code that performa a Fhir path search.
    /// </summary>
    public class GenerateFhirPathSearch
    {
        CodeBlockNested childBlock;
        Int32 childMethodCounter = 0;
        SliceGenerator gen;

        public GenerateFhirPathSearch(SliceGenerator gen)
        {
            this.gen = gen;
        }

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

        /// <summary>
        /// Traverse children using simple fhir path query.
        /// Return selected elements, or null if not found.
        /// </summary>
        public bool Generate(CodeBlockNested block,
            String methodModifiers,
            String methodName,
            ElementNode node,
            String path,
            out Type leafType)
        {
            const String fcn = nameof(Generate);

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
                    if (node.TryGetAnyChild(pathItem, out ElementNode next) == false)
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
            }

            block
                .AppendCode($"return {resultThis};")
                .CloseBrace()
                ;

            leafType = node.FhirItemType;

            methodHeaderBlock
                .AppendCode($"{methodModifiers} IEnumerable<{leafType.FriendlyName()}> {methodName}(IEnumerable<{fhirItemTypeName}> head)")
            ;
            return true;
        }
    }
}
