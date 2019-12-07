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
    //Todo:
    // Cardinalioty?
    // Body Location?
    // Size?

    partial class ResourcesMaker : ConverterBase
    {
        String MammoAxillaryAdenopathy
        {
            get
            {
                if (mammoAxillaryAdenopathy == null)
                    CreateMammoAxillaryAdenopathy();
                return mammoAxillaryAdenopathy;
            }
        }
        String mammoAxillaryAdenopathy = null;

        void CreateMammoAxillaryAdenopathy()
        {
            SDefEditor e = this.CreateEditor("BreastRadMammoAxillaryAdenopathy",
                    "Mammo Axillary Adenopathy",
                    new string[] { "Axillary", "Adenopathy" },
                    ObservationUrl,
                    out mammoAxillaryAdenopathy)
                    .Description(new Markdown()
                        .Paragraph("Breast Radiology Mammography Axillary Adenopathy Observation")
                        .MissingObservation("an axillary adenopathy")
                        .BiradHeader()
                        .BlockQuote("Enlarged axillary lymph nodes may warrant comment, clinical correlation, and additional ")
                        .BlockQuote("evaluation, especially if new or considerably larger or rounder when compared to previous examination.")
                        .BlockQuote("A review of the patient’s medical history may elucidate the cause for axillary adenopathy, averting")
                        .BlockQuote("recommendation for additional evaluation. When one or more large axillary nodes are ")
                        .BlockQuote("substantially composed of fat, this is a normal variant.")
                        .BiradFooter()
                    )
                    .AddFragRef(this.ObservationNoValueFragment)
                    .AddFragRef(this.BreastBodyLocationRequiredFragment)
                    ;
        }
    }
}
