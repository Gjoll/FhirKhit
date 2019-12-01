using FhirKhit.Tools.R4;
using PreFhir;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    public partial class ResourcesMaker
    {
        String PureObservationSectionFragment
        {
            get
            {
                if (pureObservationSectionFragment == null)
                    CreatePureObservationSectionFragment();
                return pureObservationSectionFragment;
            }
        }
        String pureObservationSectionFragment = null;

        /// <summary>
        /// Create PureObservationSectionFragment.
        /// </summary>
        /// <returns></returns>
        void CreatePureObservationSectionFragment()
        {
            SDefEditor e = this.CreateFragment("BreastRadPureObservationSectionFragment",
                    "BreastRad Pure Observation Fragment",
                    new string[] {"Observation","Pure-Section", "Fragment"},
                    ObservationUrl,
                    out pureObservationSectionFragment)
                .Description(new Hl7.Fhir.Model.Markdown("Fragment that constrains an observation to be a pure section."))
                .AddFragRef(this.ObservationNoValueFragment)
                ;

            e.Select("bodySite").Zero();
        }
    }
}
