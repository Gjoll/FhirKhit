using FhirKhit.Tools;
using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.SliceGen.R4.CSApi
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
        /// Return seleted element, or null if not found.
        /// </summary>
        public bool Generate(CodeBlockNested block,
            String methodModifiers,
            String methodName,
            ElementNode node,
            String path)
        {
            const String fcn = nameof(Generate);

            void GenerateGetChild(String childMethodName, string childPropertyName)
            {
                if (childMethodName is null)
                    throw new ArgumentNullException(nameof(childMethodName));

                block
                    .AppendCode($"IEnumerable<Element> {childMethodName}(IEnumerable<Element> elements)")
                    .OpenBrace()
                    .AppendCode($"if (elements == null)")
                    .AppendCode($"    return Array.Empty<Element>();")
                    .AppendCode($"foreach (Element element in elements)")
                    .OpenBrace()
                    .AppendCode($"foreach (Element childElement element.{childPropertyName}.ToEnumerable)")
                    .OpenBrace()
                    .AppendCode($"yield return childElement;")
                    .CloseBrace()
                    .CloseBrace()
                    .CloseBrace()
                    ;
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

            String fhirTypeName = node.FhirType.FriendlyName();
            block
                .OpenSummary()
                    .AppendSummary($"Method to find element at simple fhir path '{path}'.")
                    .CloseSummary()
                    .AppendCode($"{methodModifiers} Element {methodName}({fhirTypeName} head)")
                    .OpenBrace()
                    .BlankLine()
                    .AppendCode($"IEnumerable<Element> results = head.ToEnumerable();")
                ;

            String[] pathItems = path.Split('.');
            Int32 i = 0;

            if (pathItems[0] == node.Name)
                i += 1;

            while (i < pathItems.Length)
            {
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

                    node = next;
                    block.AppendCode($"results = results.GetNamedChildren(\"{pathItem}\");");
                    block.AppendCode($"if (results == null) return null;");
                }
            }
            return true;
        }
    }
}
