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
        /// Create BreastBodyLocationFragment.
        /// </summary>
        /// <returns></returns>
        String BreastBodyLocationRequiredFragment()
        {
            SDefEditor e = this.CreateFragment("BreastBodyLocationRequired",
                    "Breast Body Location (Required) Fragment",
                    new string[] {"Breast","Body", "Location", "Fragment", "(Required)"},
                    ObservationUrl)
                .AddFragRef(this.headerFragUrl);
                ;
            e
                .Select("bodySite")
                .Single()
                ;
            e
                .ApplyExtension("breastBodyLocation", this.breastBodyLocationExtensionUrl)
                .Single()
                ;

            return e.SDef.Url;
        }
    }
}
