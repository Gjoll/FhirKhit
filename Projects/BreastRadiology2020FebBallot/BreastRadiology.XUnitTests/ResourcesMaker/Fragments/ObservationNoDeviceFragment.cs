using FhirKhit.Tools.R4;
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
                .Description(new Hl7.Fhir.Model.Markdown()
                    .Paragraph("Fragment for all observations that have no device.")
                    )
                .AddFragRef(this.ObservationFragment)
            ;
            e.Select("device").Zero();

            e.IntroDoc.ReviewedStatus(ReviewStatus.NotReviewed).Fragment($"Fragment for all observations that have no device.");
        }
    }
}
