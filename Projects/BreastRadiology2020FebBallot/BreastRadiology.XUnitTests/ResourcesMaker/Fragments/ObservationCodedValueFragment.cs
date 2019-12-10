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
        String ObservationCodedValueFragment
        {
            get
            {
                if (observationCodedValueFragment == null)
                    CreateObservationCodedValueFragment();
                return observationCodedValueFragment;
            }
        }
        String observationCodedValueFragment = null;

        /// <summary>
        /// Create ObservationCodedValueFragment.
        /// </summary>
        /// <returns></returns>
        void CreateObservationCodedValueFragment()
        {
            SDefEditor e = this.CreateFragment("CodedValueObservationFragment",
                    "CodedValue Observation Fragment",
                    new string[] {"Observation","CodedValue", "Fragment"},
                    ObservationUrl,
                    out observationCodedValueFragment)
                .Description("Fragment that defines values for coded observations",
                    new Markdown()
                        .Paragraph("This fragment constrains an observation to only contain coded values.")
                        .Todo(
                        )
                )
                .AddFragRef(this.HeaderFragment)
                .AddFragRef(this.BreastBodyLocationRequiredFragment)
                .AddFragRef(this.ObservationFragment)
                ;

            e.Select("value[x]")
                .Type("CodeableConcept")
                ;

            e.IntroDoc.ReviewedStatus(ReviewStatus.NotReviewed).Fragment($"Resource fragment used to by all observations whose value are a CodeableConcept.");
        }
    }
}
