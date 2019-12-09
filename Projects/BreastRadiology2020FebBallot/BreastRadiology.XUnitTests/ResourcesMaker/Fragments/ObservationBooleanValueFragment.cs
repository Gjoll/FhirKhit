using FhirKhit.Tools.R4;
using PreFhir;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    partial class ResourcesMaker
    {
        String ObservationBooleanValueFragment
        {
            get
            {
                if (observationBooleanValueFragment == null)
                    CreateObservationBooleanValueFragment();
                return observationBooleanValueFragment;
            }
        }
        String observationBooleanValueFragment = null;

        /// <summary>
        /// Create ObservationBooleanValueFragment.
        /// </summary>
        /// <returns></returns>
        void CreateObservationBooleanValueFragment()
        {
            SDefEditor e = this.CreateFragment("BooleanValueObservationFragment",
                    "BooleanValue Observation Fragment",
                    new string[] {"Observation","BooleanValue", "Fragment"},
                    ObservationUrl,
                    out observationBooleanValueFragment)
                .Description(new Hl7.Fhir.Model.Markdown()

                    .Paragraph("Fragment that defines a boolean values observation.")
                    )
                .AddFragRef(this.HeaderFragment)
                .AddFragRef(this.BreastBodyLocationRequiredFragment)
                .AddFragRef(this.ObservationFragment)
                ;

            e.Select("value[x]")
                .Type("boolean")
                ;


            e.IntroDoc.ReviewedStatus(ReviewStatus.NotReviewed).Fragment($"Resource fragment used to by all observations whose value are a Boolean.");
        }
    }
}
