﻿using FhirKhit.Tools.R4;
using PreFhir;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    public partial class ResourcesMaker
    {
        String ObservationSectionFragment
        {
            get
            {
                if (observationSectionFragment == null)
                    observationSectionFragment = CreateObservationSectionFragment();
                return observationSectionFragment;
            }
        }
        String observationSectionFragment = null;

        /// <summary>
        /// Create ObservationSectionFragment.
        /// </summary>
        String CreateObservationSectionFragment()
        {
            SDefEditor e = this.CreateFragment("ObservationSectionFragment",
                "Observation Section Fragment",
                    new string[] {"Observation","Section", "Fragment"},
                ObservationUrl);
            e.Select("value[x]").Zero();
            e.Select("specimen").Zero();
            e.Select("device").Zero();
            e.Select("referenceRange").Zero();

            e.Select("interpretation").Zero();
            e.Select("note").Zero();
            e.Select("method").Zero();
            return e.SDef.Url;
        }
    }
}
