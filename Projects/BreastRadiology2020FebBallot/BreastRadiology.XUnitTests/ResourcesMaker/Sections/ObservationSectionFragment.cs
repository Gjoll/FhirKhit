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
        /// Create ObservationSectionFragment.
        /// </summary>
        String ObservationSectionFragment()
        {
            SDefEditor e = this.CreateFragment("ObservationSection",
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
