using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.BreastRadiology.XUnitTests
{
    public static class ElementDefinitionExtensions
    {
        public static void ConfigureSliceByUrlDiscriminator(this ElementDefinition eDef)
        {
            if (eDef.Slicing == null)
            {
                eDef.Slicing = new ElementDefinition.SlicingComponent
                {
                    Ordered = true,
                    Rules = ElementDefinition.SlicingRules.OpenAtEnd
                };
            }
            eDef.Slicing.Discriminator.Add(new ElementDefinition.DiscriminatorComponent
            {
                Type = ElementDefinition.DiscriminatorType.Value,
                Path = "url"
            });
        }
    }
}
