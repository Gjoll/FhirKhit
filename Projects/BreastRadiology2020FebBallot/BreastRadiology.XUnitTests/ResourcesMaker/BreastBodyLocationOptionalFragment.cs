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
        /// Create BreastBodyLocationFragment.
        /// </summary>
        /// <returns></returns>
        String BreastBodyLocationOptionalFragment()
        {
            SDefEditor sDef = this.CreateFragment("BreastBodyLocationOptional",
                "Breast Body Location (Optional) Fragment",
                ObservationUrl);
            sDef
                .Select("bodySite")
                .ZeroToOne();
            sDef
                .ApplyExtension("breastBodyLocation", this.breastBodyLocationExtensionUrl)
                .ZeroToOne()
                ;

            return sDef.SDef.Url;
        }
    }
}
