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
            ValueSet binding = this.CreateValueSet(
                "BreastRadObservedState",
                "Observed State",
                new string[] {"Observed", "State", "Values"},
                "Codes for observed state of an abnormality.",
                Group_CommonCodes,
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


            {
                IntroDoc valueSetIntroDoc = new IntroDoc(Path.Combine(this.pageDir, $"ValueSet-{binding.Name}-intro.xml"));
                valueSetIntroDoc
                    .ReviewedStatus(ReviewStatus.NotReviewed)
                    .ValueSet(binding);
                    ;
                String outputPath = valueSetIntroDoc.Save();
                this.fc.Mark(outputPath);
            }

            SDefEditor e = this.CreateEditor("BreastRadObservedState",
                    "Observed State",
                    new string[] { "State" },
                    ObservationUrl,
                    $"{Group_CommonResources}/ObservedState",
                    out breastRadObservedState)
                .Description("Breast Radiology Observed State Observation",
                    new Markdown()
                        .Paragraph("This observations describes an observed change in a previously observed item.")
                        .MissingObservation("an observed change")
                        .Todo(
                            "Do we want benign appearing & probably benign? Define difference."
                        )
                 )
                .AddFragRef(this.ObservationNoDeviceFragment)
                .AddFragRef(this.ObservationCodedValueFragment)
                .AddFragRef(this.ObservationLeafFragment)
                ;

            e.Select("value[x]")
                .Type("CodeableConcept")
                .Binding(binding.Url, BindingStrength.Required)
                ;
            e.AddValueSetLink(binding);
            e.IntroDoc.ReviewedStatus(ReviewStatus.NotReviewed).CodedObservationLeafNode(e, "an abnormality observed state", binding);
        }
    }
}
