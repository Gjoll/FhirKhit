using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

#if FHIR_R4
namespace FhirKhit.Tools.R4
#elif FHIR_R3
namespace FhirKhit.Tools.R3
#endif
{
    public static class ElementNodeExtensions
    {
        public static IEnumerable<Element> FixedValues(this IEnumerable<ElementDefinitionNode> values)
        {
            if (values is null)
                throw new ArgumentNullException(nameof(values));

            foreach (ElementDefinitionNode value in values)
            {
                if (value.Element?.Fixed != null)
                    yield return value.Element.Fixed;
            }
        }

        public static IEnumerable<ElementDefinitionNode> WithFixedValue(this IEnumerable<ElementDefinitionNode> values)
        {
            if (values is null)
                throw new ArgumentNullException(nameof(values));

            foreach (ElementDefinitionNode value in values)
            {
                if (value.Element?.Fixed != null)
                    yield return value;
            }
        }
    }
}
