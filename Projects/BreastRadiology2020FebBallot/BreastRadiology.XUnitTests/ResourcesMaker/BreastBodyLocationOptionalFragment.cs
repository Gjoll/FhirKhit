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
        /// Create BreastBodyLocationFragment.
        /// </summary>
        /// <returns></returns>
        String BreastBodyLocationOptionalFragment()
        {
            SDefEditor e = this.CreateFragment("BreastBodyLocationOptional",
                                "Breast Body Location (Optional) Fragment",
                    new string[] {"Breast","Body", "Location", "Fragment", "(Optional)"},
                                ObservationUrl)
                .AddFragRef(this.headerFragUrl)
                ;
            e
                .Select("bodySite")
                .ZeroToOne()
                ;
            e
                .ApplyExtension("breastBodyLocation", this.breastBodyLocationExtensionUrl)
                .ZeroToOne()
                ;

            return e.SDef.Url;
        }
    }
}
