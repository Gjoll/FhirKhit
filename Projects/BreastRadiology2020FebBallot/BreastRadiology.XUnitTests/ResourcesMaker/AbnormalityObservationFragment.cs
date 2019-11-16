using FhirKhit.Tools.R4;
using PreFhir;
using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.BreastRadiology.XUnitTests
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
            SDefEditor sDef = this.CreateFragment("AbnormalityObservationFragment",
                "Abnormality Observation Fragment",
                ObservationUrl);
            sDef.Select("subject").Single();
            sDef.Select("component").Zero();
            sDef.Select("basedOn").Zero();
            sDef.Select("derivedFrom").Zero();
            sDef.Select("partOf").Zero();
            sDef.Select("focus").Zero();
            this.CreateCategorySlice(sDef, "category");
            sDef.SDef.AddFragRef(this.headerFragUrl);
            return sDef.SDef.Url;
        }
    }
}
