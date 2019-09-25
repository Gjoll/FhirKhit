using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.SliceGen.SharedLib
{
    public static class ElementExtensions
    {
        /// <summary>
        /// Return an ienumerable for a singleton element.
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public static IEnumerable<Element> ToEnumerable(Element element)
        {
            if (element == null)
                return Array.Empty<Element>();
            return new Element[] { element };
        }

        /// <summary>
        /// Return an ienumerable for a list of elements.
        /// </summary>
        /// <param name="elements"></param>
        /// <returns></returns>
        public static IEnumerable<Element> ToEnumerable<T>(IEnumerable<T> elements)
            where T : Element
        {
            if (elements != null)
            {
                foreach (T element in elements)
                    yield return element;
            }
        }
    }
}
