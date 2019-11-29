using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using PreFhir;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    public partial class ResourcesMaker
    {
        String BreastBodyLocationRequiredFragment
        {
            get
            {
                if (breastBodyLocationRequiredFragment == null)
                    breastBodyLocationRequiredFragment = CreateBreastBodyLocationRequiredFragment();
                return breastBodyLocationRequiredFragment;
            }
        }
        String breastBodyLocationRequiredFragment = null;


        /// <summary>
        /// Create BreastBodyLocationFragment.
        /// </summary>
        /// <returns></returns>
        String CreateBreastBodyLocationRequiredFragment()
        {
            SDefEditor e = this.CreateFragment("BreastBodyLocationRequiredFragment",
                    "Breast Body Location (Required) Fragment",
                    new string[] {"Breast","Body", "Location", "Fragment", "(Required)"},
                    ObservationUrl)
                .Description(new Markdown("Fragment definition for an required Breast Body Location"))
                .AddFragRef(this.HeaderFragment);
                ;
            e
                .Select("bodySite")
                .Single()
                ;
            e
                .ApplyExtension("breastBodyLocation", this.BreastBodyLocationExtension)
                .Single()
                ;

            return e.SDef.Url;
        }
    }
}
