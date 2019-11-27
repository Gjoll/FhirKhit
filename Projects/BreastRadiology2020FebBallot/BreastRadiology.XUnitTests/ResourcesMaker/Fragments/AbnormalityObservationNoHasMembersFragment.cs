using FhirKhit.Tools.R4;
using PreFhir;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    public partial class ResourcesMaker
    {
        /// <summary>
        /// Create AbnormalityObservationFragment.
        /// This fragment is included in all breast abnormality observation profiles.
        /// It constrains elements that are commonly constrained in all observations.
        /// </summary>
        /// <returns></returns>
        String AbnormalityObservationNoHasMembersFragment()
        {
            SDefEditor e = this.CreateFragment("AbnormalityObservationNoHasMembersFragment",
                "Abnormality Observation with no hasMember's Fragment",
                    new string[] { "Abnormality", "Observation", "No hasMember's", "Fragment" },
                ObservationUrl)
                .Description(new Hl7.Fhir.Model.Markdown("Fragment that defines restricts abnormality observations to have no hasMember references."))
                .AddFragRef(this.headerFragUrl)
                .AddFragRef(this.categoryFragmentUrl)
            ;
            e.Select("hasMember").Single();
            return e.SDef.Url;
        }
    }
}
