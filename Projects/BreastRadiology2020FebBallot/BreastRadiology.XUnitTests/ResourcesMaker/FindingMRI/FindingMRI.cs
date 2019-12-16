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
using VTask = System.Threading.Tasks.Task;
using StringTask = System.Threading.Tasks.Task<string>;

namespace BreastRadiology.XUnitTests
{
    partial class ResourcesMaker : ConverterBase
    {
        async StringTask FindingMri()
        {
            if (findingMri == null)
                await CreateFindingMri();
            return findingMri;
        }
        String findingMri = null;

        async VTask CreateFindingMri()
        {
            await VTask.Run(async () =>
            {
                //$ Fix me. Incorrect method!!!
                SDefEditor e = this.CreateEditor("BreastRadMRIFinding",
                        "MRI Finding",
                        new string[] { "MRI", "Finding" },
                        ObservationUrl,
                        $"{Group_MRIResources}",
                        out findingMri)
                    .Description("Breast Radiology MRI Finding",
                        new Markdown()
                            .Todo(
                                "Device Metrics detailing the observation devices parameters.",
                                "Add information about contrast enhancement/other observation specific parameters."
                            )
                    )
                    .AddFragRef(await this.ObservationSectionFragment())
                    .AddFragRef(await this.ObservationNoValueFragment())
                ;

                e.IntroDoc
                    .ReviewedStatus(ReviewStatus.NotReviewed)
                    .ObservationSection("MRI Abnormality")
                    ;
                //$e.Find("method")
                //$     .FixedCodeSlice("method", "http://snomed.info/sct", "115341008")
                //$     .Card(1, "*")
                //$     ;
            });
        }
    }
}
