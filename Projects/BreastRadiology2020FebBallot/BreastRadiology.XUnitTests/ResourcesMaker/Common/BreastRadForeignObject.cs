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
        String BreastRadForeignObject
        {
            get
            {
                if (breastRadForeignObject == null)
                    CreateBreastRadForeignObject();
                return breastRadForeignObject;
            }
        }
        String breastRadForeignObject = null;

        void CreateBreastRadForeignObject()
        {
            ValueSet binding = this.CreateValueSet(
                    "BreastRadAbnormalities",
                    "Foreign Object",
                    "Foreign object codes defining types of foreign objects observed during a Breast Radiology exam",
                    Group_CommonCodes,
                    new ConceptDef[]
                    {
                        new ConceptDef("BB", 
                            "BB", 
                            new Definition()
                            ),
                        new ConceptDef("BiopsyClip", 
                            "Biopsy Clip", 
                            new Definition()
                            ),
                        new ConceptDef("BiopsyClipTitanium", 
                            "Biopsy Clip Titanium", 
                            new Definition()
                            ),
                        new ConceptDef("CatheterSleeve", 
                            "Catheter Sleeve", 
                            new Definition()
                            ),
                        new ConceptDef("ChemotherapyPort", 
                            "Chemotherapy Port", 
                            new Definition()
                            ),
                        new ConceptDef("Coil", 
                            "Coil", 
                            new Definition()
                            ),
                        new ConceptDef("GunShotWound", 
                            "Gun Shot Wound", 
                            new Definition()
                            ),
                        new ConceptDef("Metal", 
                            "Metal", 
                            new Definition()
                            ),
                        new ConceptDef("MetallicObjects", 
                            "Metallic Objects", 
                            new Definition()
                            ),
                        new ConceptDef("Needle", 
                            "Needle", 
                            new Definition()
                            ),
                        new ConceptDef("NippleJewelery", 
                            "Nipple Jewelery", 
                            new Definition()
                            ),
                        new ConceptDef("NonMetallicBody", 
                            "Non Metallic Body", 
                            new Definition()
                            ),
                        new ConceptDef("PaceMaker", 
                            "Pace Maker", 
                            new Definition()
                            ),
                        new ConceptDef("RadioactivePellet", 
                            "Radioactive Pellet", 
                            new Definition()
                            ),
                        new ConceptDef("Sponge", 
                            "Sponge", 
                            new Definition()
                            ),
                        new ConceptDef("SurgicalClip", 
                            "Surgical Clip", 
                            new Definition()
                            ),
                        new ConceptDef("Swab", 
                            "Swab", 
                            new Definition()
                            ),
                        new ConceptDef("Wire", 
                            "Wire", 
                            new Definition()
                            ),
                        new ConceptDef("WireFragment", 
                            "WireFragment", 
                            new Definition()
                            )
                    })
                ;

            SDefEditor e = this.CreateEditor("BreastRadForeignObject",
                    "ForeignObject",
                    new string[] { "ForeignObject" },
                    ObservationUrl,
                    $"{Group_CommonResources}/Foreign",
                    out breastRadForeignObject)
                .Description("Breast Radiology Foreign Object Observation",
                    new Markdown()
                        .Paragraph("These are foreign objects found during a breast radiology exam:")
                        .Todo(
                            "there is no way to say that the following abnormalities do not exist, only that one does exist.",
                            "fill in code descriptions",
                            "How are metal and metallic codes different",
                            "body jewelery codes",
                            "are wire and wire fragment codes the same."
                        )
                )
                .AddFragRef(this.ObservationNoDeviceFragment)
                .AddFragRef(this.ObservationCodedValueFragment)
                .AddFragRef(this.ObservationSectionFragment)
                ;

            {
                ProfileTargetSlice[] targets = new ProfileTargetSlice[]
                {
                    new ProfileTargetSlice(this.BreastRadObservedChanges, 0, "*"),
                    new ProfileTargetSlice(this.BreastRadObservedSize, 0, "1"),
                    new ProfileTargetSlice(this.BreastRadObservedCount, 0, "1")
                };
                e.Find("hasMember").SliceByUrl(targets);
                e.MapNode.AddProfileTargets(targets);
            }

            e.Select("value[x]")
                .Type("CodeableConcept")
                .Binding(binding.Url, BindingStrength.Required)
                ;
            e.IntroDoc.ReviewedStatus(ReviewStatus.NotReviewed).CodedObservationLeafNode(e, "an ForeignObject", binding);
        }
    }
}
