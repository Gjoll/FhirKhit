using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using PreFhir;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    partial class ResourcesMaker
    {
        String ObservationNoDeviceFragment
        {
            get
            {
                if (observationNoDeviceFragment == null)
                    CreateObservationNoDeviceFragment();
                return observationNoDeviceFragment;
            }
        }
        String observationNoDeviceFragment = null;

        void CreateObservationNoDeviceFragment()
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
                .AddFragRef(this.ObservationFragment)
            ;
            e.Select("device").Zero();

            e.IntroDoc.ReviewedStatus(ReviewStatus.NotReviewed).Fragment($"Fragment for all observations that have no device.");
        }
    }
}
