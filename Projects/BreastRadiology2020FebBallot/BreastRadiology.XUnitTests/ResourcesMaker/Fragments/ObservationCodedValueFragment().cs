using FhirKhit.Tools.R4;
using PreFhir;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    public partial class ResourcesMaker
    {
        String ObservationCodedValueFragment
        {
            get
            {
                if (observationCodedValueFragment == null)
                    observationCodedValueFragment = CreateObservationCodedValueFragment();
                return observationCodedValueFragment;
            }
        }
        String observationCodedValueFragment = null;

        /// <summary>
        /// Create ObservationCodedValueFragment.
        /// </summary>
        /// <returns></returns>
        String CreateObservationCodedValueFragment()
        {
            SDefEditor e = this.CreateFragment("CodedValueObservationFragment",
                    "CodedValue Observation Fragment",
                    new string[] {"Observation","CodedValue", "Fragment"},
                    ObservationUrl)
                .Description(new Hl7.Fhir.Model.Markdown("Fragment that defines values for coded observations."))
                .AddFragRef(this.HeaderFragment)
                .AddFragRef(this.BreastBodyLocationRequiredFragment)
                ;

            e.Select("value[x]")
                .Type("CodeableConcept")
                ;

            return e.SDef.Url;
        }
    }
}
