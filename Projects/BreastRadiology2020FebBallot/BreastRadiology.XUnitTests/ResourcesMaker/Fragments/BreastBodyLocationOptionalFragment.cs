using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using PreFhir;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    partial class ResourcesMaker
    {
        String BreastBodyLocationOptionalFragment
        {
            get
            {
                if (breastBodyLocationOptionalFragment == null)
                    CreateBreastBodyLocationOptionalFragment();
                return breastBodyLocationOptionalFragment;
            }
        }
        String breastBodyLocationOptionalFragment = null;

        /// <summary>
        /// Create BreastBodyLocationFragment.
        /// </summary>
        /// <returns></returns>
        void CreateBreastBodyLocationOptionalFragment()
        {
            SDefEditor e = this.CreateFragment("BreastBodyLocationOptionalFragment",
                                "Breast Body Location (Optional) Fragment",
                                new string[] {"Breast","Body", "Location", "Fragment", "(Optional)"},
                                ObservationUrl,
                                out breastBodyLocationOptionalFragment)
                .Description(new Markdown()
                    .ReviewedStatus(ReviewStatus.NotReviewed)
                    .Paragraph("Fragment definition for a Required Breast Body Location")
                    )
                .AddFragRef(this.HeaderFragment)
                ;
            e
                .Select("bodySite")
                .ZeroToOne()
                ;
            e
                .ApplyExtension("breastBodyLocation", this.BreastBodyLocationExtension, true, false)
                .ZeroToOne()
                ;

            e.IntroDoc.Fragment($"Resource fragment used by various observations to include an optional breast body location.");
        }
    }
}
