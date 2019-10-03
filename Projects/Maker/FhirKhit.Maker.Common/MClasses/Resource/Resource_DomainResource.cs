using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.Maker.Common.Resource
{
    public partial class Resource_DomainResource
    {
        public void AddExtensionSlice()
        {
            ElementDefinition extDef = this.Element_Extension.CreateConstraint();
            // I assume that if slicing exists, it is how I want it. If someone else adds
            // slicing it may not be correct.
            if (extDef.Slicing == null)
            {
                extDef.Slicing = new ElementDefinition.SlicingComponent
                {
                    Ordered = false,
                    Rules = ElementDefinition.SlicingRules.Open
                };
                extDef.Slicing.Discriminator.Add(new ElementDefinition.DiscriminatorComponent
                {
                    Type = ElementDefinition.DiscriminatorType.Value,
                    Path = "url"
                });
            }
        }

        public void SimpleExtension()
        {
        }
    }
}
