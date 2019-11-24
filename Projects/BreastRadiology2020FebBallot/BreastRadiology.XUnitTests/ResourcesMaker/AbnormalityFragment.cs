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
        /// Create AbnormalityFragment.
        /// </summary>
        String AbnormalityFragment()
        {
            SDefEditor e = this.CreateFragment("Abnormality",
                    "Abnormality Fragment",
                    new string[] {"Abnormality", "Fragment"},
                    ObservationUrl)
                ;

            e.Select("value[x]").Zero();
            e.Select("specimen").Zero();
            e.Select("referenceRange").Zero();
            e.Select("interpretation").Zero();
            e.Select("note").Zero();
            // todo: Add body site info.
            //e.Select("bodySite").Zero();

            return e.SDef.Url;
        }
    }
}
