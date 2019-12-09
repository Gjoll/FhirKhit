using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadiology.XUnitTests
{
    partial class ResourcesMaker : ConverterBase
    {
        String MammoNippleRetraction
        {
            get
            {
                if (mammoNippleRetraction == null)
                    CreateMammoNippleRetraction();
                return mammoNippleRetraction;
            }
        }
        String mammoNippleRetraction = null;

        void CreateMammoNippleRetraction()
        {
            SDefEditor e = this.CreateEditor("BreastRadMammoNippleRetraction",
                "Mammo Nipple Retraction",
                new string[] { "Nipple", "Retraction" },
                ObservationUrl,
                out mammoNippleRetraction)
                .Description(new Markdown()

                    .Paragraph("Breast Radiology Mammography Nipple Retraction Observation")
                    .MissingObservation("a nipple retraction")
                    .BiradHeader()
                    .BlockQuote("The nipple is pulled in. This should not be confused with nipple inversion, which is often bilateral ")
                    .BlockQuote("and which in the absence of any suspicious findings and when stable for a long period of time, ")
                    .BlockQuote("is not a sign of malignancy. However, if nipple retraction is new, suspicion for underlying malignancy is increased.")
                    .BiradFooter()
                )
                .AddFragRef(this.ObservationNoValueFragment)
                .AddFragRef(this.BreastBodyLocationRequiredFragment)
                .AddExtensionLink(this.BreastBodyLocationExtension)
                ;

            e.IntroDoc.ReviewedStatus(ReviewStatus.NotReviewed).ObservationLeafNode("Nipple Retraction");
        }
    }
}
