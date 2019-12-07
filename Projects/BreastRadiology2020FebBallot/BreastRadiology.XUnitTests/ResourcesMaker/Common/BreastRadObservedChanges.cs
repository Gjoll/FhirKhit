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
            ValueSet vs = this.CreateValueSet(
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
                                .Line("Item has increased in siz")
                            ),
                        new ConceptDef("DecreaseInSize",
                            "Decrease In Size",
                            new Definition()
                                .Line("Item has decreased in siz")
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
                        new ConceptDef("MorePriminent",
                            "More Priminent",
                            new Definition()
                                .Line("Item is more Priminent")
                            ),
                        new ConceptDef("LessPriminent",
                            "Less Priminent",
                            new Definition()
                                .Line("Item is less Priminent")
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

            String binding = vs.Url;

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
                .Binding(binding, BindingStrength.Required)
                ;
        }
    }
}
