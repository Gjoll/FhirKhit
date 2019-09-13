using FhirKhit.SliceGen.R4;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.SliceGen.SharedLib
{
    public static class ElementNodeExtensions
    {
        public static IEnumerable<Element> FixedValues(this IEnumerable<ElementNode> values)
        {
            if (values is null)
                throw new ArgumentNullException(nameof(values));

            foreach (ElementNode value in values)
            {
                if (value.Element?.Fixed != null)
                    yield return value.Element.Fixed;
            }
        }

        public static IEnumerable<ElementNode> WithFixedValue(this IEnumerable<ElementNode> values)
        {
            if (values is null)
                throw new ArgumentNullException(nameof(values));

            foreach (ElementNode value in values)
            {
                if (value.Element?.Fixed != null)
                    yield return value;
            }
        }
    }
}
