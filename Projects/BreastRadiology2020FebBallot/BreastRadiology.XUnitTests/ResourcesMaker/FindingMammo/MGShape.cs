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
using VTask = System.Threading.Tasks.Task;
using StringTask = System.Threading.Tasks.Task<string>;

namespace BreastRadiology.XUnitTests
{
    partial class ResourcesMaker
    {
        async StringTask MGShape()
        {
            if (this.mgShape == null)
                await this.CreateMammoShape();
            return this.mgShape;
        }
        String mgShape = null;

        async VTask CreateMammoShape()
        {
            await VTask.Run(async () =>
            {
                ValueSet binding = this.CreateValueSet(
                        "MammoShape",
                        "Shape",
                        "Shape/Values",
                        "Codes defining shape values.",
                        Group_CommonCodes,
                        new ConceptDef[]
                        {
                        new ConceptDef("Irregular",
                            "Irregular Shape",
                            new Definition()
                            .CiteStart()
                                .Line("The shape is neither round nor oval.")
                                .Line("For mammography, use of this descriptor usually implies a suspicious finding.")
                            .CiteEnd(BiRadCitation)
                            ),
                        new ConceptDef("Lobulated",
                            "Lobulated Shape",
                            new Definition()
                                .Line("Penrad")
                            ),
                        new ConceptDef("Oval",
                            "Elliptical/Egg-shaped",
                            new Definition()
                            .CiteStart()
                                .Line("Shape is elliptical or egg-shaped (may include 2 or 3 undulations, , i.e., \"gently lobulated\" or \"macrolobulated\").")
                            .CiteEnd(BiRadCitation)
                            ),
                        new ConceptDef("Reniform",
                            "Reniform Shape",
                            new Definition()
                                .Line("Penrad")
                            ),
                        new ConceptDef("Round",
                            "Round Shape",
                            new Definition()
                            .CiteStart()
                                .Line("A mass that is spherical, ball-shaped, circular, or globular in shape.")
                                .Line("A round mass has an anteroposterior diameter equal to its transverse diameter")
                                .Line("and to qualify as a ROUND mass, it must be circular in perpendicular projections.")
                                .Line("Breast masses with a ROUND shape are not commonly seen with breast ultrasound.")
                            .CiteEnd(BiRadCitation)
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

                SDefEditor e = this.CreateEditor("MammoShape",
                        "Shape",
                        "Shape",
                        ObservationUrl,
                        $"{Group_CommonResources}/Shape",
                        out this.mgShape)
                    .Description("Breast Radiology Shape Observation",
                        new Markdown()
                            .MissingObservation("a shape")
                            .Todo(
                            "Make one common codesystem for Mammo and Common shape"
                            )
                    )
                    .AddFragRef(await this.ObservationNoDeviceFragment())
                    .AddFragRef(await this.ObservationCodedValueFragment())
                    .AddFragRef(await this.ObservationLeafFragment())
                    ;

                e.Select("value[x]")
                    .Type("CodeableConcept")
                    .Binding(binding.Url, BindingStrength.Required)
                    ;
                e.AddValueSetLink(binding);
                e.IntroDoc
                    .ReviewedStatus(ReviewStatus.NotReviewed)
                    .CodedObservationLeafNode(e, "a shape", binding)
                    ;
            });
        }
    }
}
