using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.SliceGen.R4
{
    public static class ElementExtensions
    {
        /// <summary>
        /// Traverse children using simple fhir path query.
        /// Return seleted element, or null if not found.
        /// </summary>
        public static Element SimpleFhirPath(this Element element, String path)
        {
            if (element is null)
                throw new ArgumentNullException(nameof(element));
            if (path is null)
                throw new ArgumentNullException(nameof(path));

            Element node = element;
            String[] pathItems = path.Split('.');
            Int32 i = 0;

            while (i < pathItems.Length)
            {
                String pathItem = pathItems[i++];
                if (pathItem.StartsWith("resolve("))
                {
                    throw new NotImplementedException($"TODO: FhirPath operator {pathItem} not implemented");
                }
                else if (pathItem.StartsWith("extension(\""))
                {
                    throw new NotImplementedException($"TODO: FhirPath operator {pathItem} not implemented");
                }
                else if (pathItem.StartsWith("ofType("))
                {
                    throw new NotImplementedException($"TODO: FhirPath operator {pathItem} not implemented");
                }
                else
                {
                    //if (this.TryGetChild(pathItem, out ElementNode next) == false)
                    //    return null;
                    //node = next;
                }
            }
            return node;
        }
    }
}
