using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using PreFhir;

namespace BreastRadiology.XUnitTests
{
    partial class ResourcesMaker
    {
        String BreastRadObservedState
        {
            get
            {
                if (breastRadObservedState == null)
                    CreateBreastRadObservedState();
                return breastRadObservedState;
            }
        }
        String breastRadObservedState = null;

        void CreateBreastRadObservedState()
        {
            // todo: Do we want benign appearing & probably benign? Define difference.
            ValueSet binding = this.CreateValueSet(
                    "BreastRadObservedState",
                    "Observed State",
                    new Markdown()
                        .Paragraph("Breast Radiology Observed State"),
                    new ConceptDef[]
                    {
                        new ConceptDef("Benign",
                            "Benign",
                            new Definition()
                                .Line("Item is considered benign")
                            ),
                        new ConceptDef("BenignAppearing",
                            "Benign Appearing",
                            new Definition()
                                .Line("Item appears to be benign")
                            ),
                        new ConceptDef("ProbablyBenign",
                            "Probably Benign",
                            new Definition()
                                .Line("Item is considered to be probably benign")
                            ),
                        new ConceptDef("NotSeen",
                            "Not Seen",
                            new Definition()
                                .Line("Item was not observed.")
                            ),
                        new ConceptDef("Biopsed",
                            "Biopsed",
                            new Definition()
                                .Line("Item was Biopsed")
                            )
                    })
                ;

            SDefEditor e = this.CreateEditor("BreastRadObservedState",
                    "Observed State",
                    new string[] { "State" },
                    ObservationUrl,
                    out breastRadObservedState)
                .Description(new Markdown()
                    .ReviewedStatus(ReviewStatus.NotReviewed)
                    .Paragraph("Breast Radiology Observed State Observation")
                    .MissingObservation("an observed change")
                    )
                .AddFragRef(this.ObservationCodedValueFragment)
                .AddFragRef(this.ObservationLeafFragment)
                ;

            e.Select("value[x]")
                .Type("CodeableConcept")
                .Binding(binding.Url, BindingStrength.Required)
                ;

            e.IntroDoc.CodedObservationLeafNode(e, "an abnormality observed state", binding);
        }
    }
}
