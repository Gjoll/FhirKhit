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
    // Todo:
    // - Add body location?
    // - Add size measurement?
    // - cardinality 0..1 or 0..*?

    partial class ResourcesMaker : ConverterBase
    {
        String MammoTrabecularThickening
        {
            get
            {
                if (mammoTrabecularThickening == null)
                    CreateMammoTrabecularThickening();
                return mammoTrabecularThickening;
            }
        }
        String mammoTrabecularThickening = null;

        void CreateMammoTrabecularThickening()
        {
            SDefEditor e = this.CreateEditor("BreastRadMammoTrabecularThickening",
                "Skin Retraction",
                new string[] {"Trabecular","Thickening"},
                ObservationUrl,
                out mammoTrabecularThickening)
                .Description(new Markdown()
                    .ReviewedStatus(ReviewStatus.NotReviewed)
                    .Paragraph("Trabecular Thickening Observation")
                    .BiradHeader()
                    .BlockQuote("This is a thickening of the fibrous septa of the breast.")
                    .BiradFooter()
                    .MissingObservation("a trabecular thickening")
                )
                .AddFragRef(this.BreastBodyLocationRequiredFragment)
                .AddExtensionLink(this.BreastBodyLocationExtension)
                .AddFragRef(this.ObservationNoValueFragment)
                ;
            e.IntroDoc.ObservationLeafNode("Trabecular Thickening");
        }
    }
}
