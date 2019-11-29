using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using PreFhir;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    public partial class ResourcesMaker
    {
        /// <summary>
        /// Create Valu set that defines the codes for existance.
        /// </summary>
        void ExistanceValueSet(out String existanceUrl, out String notObservedUrl)
        {
            CodeSystem cs;
            ConceptDef[] codes = new ConceptDef[]
            {
                new ConceptDef("Present", "Value is present", "Value was observed and is present."),
                new ConceptDef("NotPresent", "Value was found to be not present", "An observation for the value was made and found to not be present."),
                new ConceptDef("NotChecked", "No attempt was made tt observe value", "An observation for the value was not made. Its existance is indeterminate.")
            };

            {
                ValueSet vs = this.CreateValueSet(
                        "BreastRadExistance",
                        "Breast Radiology Existance Value",
                        new Markdown().Paragraph("Breast Radiology codes to define existance of a value"),
                        codes,
                        out cs)
                        ;
                existanceUrl = vs.Url;
            }
            {
                ValueSet notObservedVS = new ValueSet
                {
                    Id = $"NotObservedVS",
                    Url = $"http://hl7.org/fhir/us/breast-radiology/CodeSystem/NotObservedVS",
                    Name = $"NotObservedVS",
                    Title = "NotObservedVS",
                    Description = new Markdown().Paragraph("Reasons why an observation found no results")
                };
                notObservedVS.AddFragRef(this.headerFragUrl);


                ValueSet.ConceptSetComponent vsComp = new ValueSet.ConceptSetComponent
                {
                    System = cs.Url
                };
                notObservedVS.Compose = new ValueSet.ComposeComponent();
                notObservedVS.Compose.Include.Add(vsComp);

                vsComp.Concept.Add(new ValueSet.ConceptReferenceComponent
                {
                    Code = codes[1].Code,
                    Display = codes[1].Display
                });

                vsComp.Concept.Add(new ValueSet.ConceptReferenceComponent
                {
                    Code = codes[2].Code,
                    Display = codes[2].Display
                });

                resources.Add(Path.Combine(this.resourceDir, $"ValueSet-NotObservedVS.json"), notObservedVS);
                notObservedUrl = notObservedVS.Url;
            }
        }
    }
}
