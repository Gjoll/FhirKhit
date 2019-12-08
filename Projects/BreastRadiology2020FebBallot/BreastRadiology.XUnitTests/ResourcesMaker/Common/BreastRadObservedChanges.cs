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
        String BreastRadObservedChanges
        {
            get
            {
                if (breastRadObservedChanges == null)
                    CreateBreastRadObservedChanges();
                return breastRadObservedChanges;
            }
        }
        String breastRadObservedChanges = null;

        void CreateBreastRadObservedChanges()
        {
            ValueSet binding = this.CreateValueSet(
                    "BreastRadObservedChanges",
                    "Observed Changes",
                    new Markdown()
                        .Paragraph("Breast Radiology Observed Changes"),
                    new ConceptDef[]
                    {
                        new ConceptDef("New",
                            "New Observation",
                            new Definition()
                                .Line("This is the first time item has been observed")
                            ),
                        new ConceptDef("Stable",
                            "Stable",
                            new Definition()
                                .Line("Observation of item is stable")
                            ),
                        new ConceptDef("NotSigChanged",
                            "Not Significantly Changed",
                            new Definition()
                                .Line("Item observation has not significantly changed")
                            ),
                        new ConceptDef("NoLongerSeen",
                            "No Longer Seen",
                            new Definition()
                                .Line("Item is no longer visible")
                            ),
                        new ConceptDef("IncidentalFind",
                            "Incidental Find",
                            new Definition()
                                .Line("Item observation is an incidental find")
                            ),
                        new ConceptDef("IncreaseInSize",
                            "Increase In Size",
                            new Definition()
                                .Line("Item has increased in size")
                            ),
                        new ConceptDef("DecreaseInSize",
                            "Decrease In Size",
                            new Definition()
                                .Line("Item has decreased in size")
                            ),
                        new ConceptDef("MoreDefined",
                            "More Defined",
                            new Definition()
                                .Line("Item is more defined")
                            ),
                        new ConceptDef("LessDefined",
                            "Less Defined",
                            new Definition()
                                .Line("Item is less defined")
                            ),
                        new ConceptDef("MoreProminent",
                            "More Prominent",
                            new Definition()
                                .Line("Item is more Prominent")
                            ),
                        new ConceptDef("LessProminent",
                            "Less Prominent",
                            new Definition()
                                .Line("Item is less Prominent")
                            ),
                        new ConceptDef("IncrInNumber",
                            "Increased In Number",
                            new Definition()
                                .Line("Item(s) have increased in number")
                            ),
                        new ConceptDef("DecrInNumber",
                            "Decreased In Number",
                            new Definition()
                                .Line("Item(s) have decreased in number")
                            ),
                    })
                ;

            SDefEditor e = this.CreateEditor("BreastRadObservedChanges",
                    "Observed Changes",
                    new string[] { "Changes" },
                    ObservationUrl,
                    out breastRadObservedChanges)
                .Description(new Markdown()
                    .Paragraph("Breast Radiology Observed Changes Observation")
                    .MissingObservation("an observed change")
                    )
                .AddFragRef(this.ObservationCodedValueFragment)
                .AddFragRef(this.ObservationLeafFragment)
                ;

            e.Select("value[x]")
                .Type("CodeableConcept")
                .Binding(binding.Url, BindingStrength.Required)
                ;
            e.IntroDoc.CodedObservation(e, "an abnormality observed change", binding);
        }
    }
}
