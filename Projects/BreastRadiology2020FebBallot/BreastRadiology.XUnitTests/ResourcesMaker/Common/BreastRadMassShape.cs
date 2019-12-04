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
        String BreastRadMassShape
        {
            get
            {
                if (breastRadMassShape == null)
                    CreateBreastRadMassShape();
                return breastRadMassShape;
            }
        }
        String breastRadMassShape = null;

        void CreateBreastRadMassShape()
        {
            ValueSet vs = this.CreateValueSet(
                    "BreastRadMassShape",
                    "Breast Radiology Mass Shape",
                    new Markdown()
                        .Paragraph("Breast Radiology Mass Shape"),
                    new ConceptDef[]
                    {
                        new ConceptDef("Oval", 
                            "Elliptical/Egg-shaped Mass", 
                            new Definition()
                            .CiteStart()
                                .Line("A mass that is elliptical or egg-shaped (may include 2 or 3 undulations, , i.e., \"gently lobulated\" or \"macrolobulated\").")
                            .CiteEnd(BiRadCitation)
                            ),
                        new ConceptDef("Round", 
                            "Round Mass", 
                            new Definition()
                            .CiteStart()
                                .Line("A mass that is spherical, ball-shaped, circular, or globular in shape.")
                                .Line("A round mass has an anteroposterior diameter equal to its transverse diameter")
                                .Line("and to qualify as a ROUND mass, it must be circular in perpendicular projections.")
                                .Line("Breast masses with a ROUND shape are not commonly seen with breast ultrasound.")
                            .CiteEnd(BiRadCitation)
                            ),
                        new ConceptDef("Irregular", 
                            "Irregular Mass", 
                            new Definition()
                            .CiteStart()
                                .Line("The shape of the mass is neither round nor oval.")
                                .Line("For mammography, use of this descriptor usually implies a suspicious finding.")
                            .CiteEnd(BiRadCitation)
                            )
                    })
                ;

            String binding = vs.Url;

            SDefEditor e = this.CreateEditor("BreastRadMassShape",
                    "Breast Radiology Mass Shape",
                    new string[] { "Shape" },
                    ObservationUrl,
                    out breastRadMassShape)
                .Description(new Markdown()
                    .Paragraph("Breast Radiology Mass Shape Observation")
                    .MissingObservation("a mass shape")
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