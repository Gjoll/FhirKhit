﻿using FhirKhit.Tools.R4;
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
            SDefEditor e = this.CreateFragment("AbnormalityObservation",
                "Abnormality Observation Fragment",
                ObservationUrl);
            e.AddFragRef(this.headerFragUrl);
            e.AddFragRef(this.categoryFragmentUrl);
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
