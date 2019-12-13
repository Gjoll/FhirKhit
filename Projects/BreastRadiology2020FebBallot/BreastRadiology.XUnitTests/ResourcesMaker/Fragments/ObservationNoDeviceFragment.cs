using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using PreFhir;
using System;
using System.Collections.Generic;
using System.Text;
using VTask = System.Threading.Tasks.Task;
using StringTask = System.Threading.Tasks.Task<string>;
namespace BreastRadiology.XUnitTests
{
    partial class ResourcesMaker
    {
        public async StringTask ObservationNoDeviceFragment()
        {
            if (observationNoDeviceFragment == null)
                await CreateObservationNoDeviceFragment();
            return observationNoDeviceFragment;
        }
        String observationNoDeviceFragment = null;

        async VTask CreateObservationNoDeviceFragment()
        {
            await VTask.Run(async () =>
            {
                SDefEditor e = this.CreateFragment("BreastRadObservationNoDeviceFragment",
                    "BreastRad Observation NoDevice Fragment",
                        new string[] { "NoDevice", "Observation", "Fragment" },
                    ObservationUrl,
                    out observationNoDeviceFragment)
                    .Description("Fragment that constrains Observations to have not device data.",
                        new Markdown()
                            .Paragraph("Fragment for all observations that have no device.")
                            .Todo(
                            )
                    )
                    .AddFragRef(await this.ObservationFragment())
                ;
                e.Select("device").Zero();

                e.IntroDoc.ReviewedStatus(ReviewStatus.NotReviewed).Fragment($"Fragment for all observations that have no device.");
            });
        }
    }
}
