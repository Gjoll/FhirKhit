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
        String AbnormalityObservationFragment()
        {
            SDefEditor e = this.CreateFragment("AbnormalityObservationFragment",
                "Abnormality Observation Fragment",
                    new string[] { "Abnormality", "Observation", "Fragment" },
                ObservationUrl)
                .Description(new Hl7.Fhir.Model.Markdown("Fragment that defines values for abnormality observations values."))
                .AddFragRef(this.headerFragUrl)
                .AddFragRef(this.categoryFragmentUrl)
            ;
            e.Select("subject").Single();
            e.Select("component").Zero();
            e.Select("basedOn").Zero();
            e.Select("derivedFrom").Zero();
            e.Select("partOf").Zero();
            e.Select("focus").Zero();
            return e.SDef.Url;
        }
    }
}
