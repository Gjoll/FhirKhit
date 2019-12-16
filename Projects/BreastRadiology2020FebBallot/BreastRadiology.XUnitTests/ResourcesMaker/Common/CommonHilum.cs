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
        async StringTask CommonHilum()
        {
            if (commonHilum == null)
                await CreateCommonHilum();
            return commonHilum;
        }
        String commonHilum = null;

        async VTask CreateCommonHilum()
        {
            await VTask.Run(async () =>
            {
                ValueSet binding = this.CreateValueSet(
                        "CommonHilum",
                        "Hilum Values",
                        new string[] { "Hilum", "Values" },
                        "Codes defining hilum values.",
                        Group_CommonCodes,
                        new ConceptDef[]
                        {
                        new ConceptDef("HilumFatty",
                            "Hilum Fatty",
                            new Definition()
                                .Line("Definition needed")
                            ),
                        new ConceptDef("Hilum Not Fatty",
                            "Hilum Not Fatty",
                            new Definition()
                                .Line("Definition needed")
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

                SDefEditor e = this.CreateEditor("CommonHilum",
                        "Hilum Shape",
                        new string[] { "Hilum", "Shape" },
                        ObservationUrl,
                        $"{Group_CommonResources}/Hilum",
                        out commonHilum)
                    .Description("Breast Radiology Hilum Observation",
                        new Markdown()
                            .MissingObservation("a hilum")
                            .Todo(
                                "Definition(s) needed"
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
                    .CodedObservationLeafNode(e, "a hilum", binding)
                    ;
            });
        }
    }
}
