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
        String BreastBodyLocationRequiredFragment()
        {
            SDefEditor sDef = this.CreateFragment("BreastBodyLocationRequired",
                "Breast Body Location (Required) Fragment",
                ObservationUrl);
            sDef
                .Select("bodySite")
                .Single();
            sDef
                .ApplyExtension("breastBodyLocation", this.breastBodyLocationExtensionUrl)
                .Single()
                ;

            return sDef.SDef.Url;
        }
    }
}
