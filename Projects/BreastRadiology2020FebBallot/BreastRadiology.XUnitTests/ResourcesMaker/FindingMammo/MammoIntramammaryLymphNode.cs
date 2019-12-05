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
        String MammoIntramammaryLymphNode
        {
            get
            {
                if (mammoIntramammaryLymphNode == null)
                    CreateMammoIntramammaryLymphNode();
                return mammoIntramammaryLymphNode;
            }
        }
        String mammoIntramammaryLymphNode = null;

        void CreateMammoIntramammaryLymphNode()
        {
            SDefEditor e = this.CreateEditor("BreastRadMammoIntramammaryLymphNode",
                    "Breast Radiology Mammography Intramammary LymphNode Observation",
                    new string[] { "Intramammory", "Lymph Node" },
                    ObservationUrl,
                    out mammoIntramammaryLymphNode)
                    .Description(new Markdown()
                        .Paragraph("Breast Radiology Mammography Intramammary LymphNode Observation")
                        .MissingObservation("an intramammary lymph node")
                        .BiradHeader()
                        .BlockQuote("These are circumscribed masses that are reniform and have hilar fat. They are generally 1 cm or smaller")
                        .BlockQuote("in size. They may be larger than 1 cm and characterized as normal when fat replacement is pro-")
                        .BlockQuote("nounced. They frequently occur in the lateral and usually upper portions of the breast closer to the")
                        .BlockQuote("axilla, although they may occur anywhere in the breast. They usually are seen adjacent to a vein,")
                        .BlockQuote("because the lymphatic drainage of the breast parallels the venous drainage.")
                        .BiradFooter())
                    .AddFragRef(this.BreastBodyLocationRequiredFragment)
                    .AddFragRef(this.ObservationCodedValueFragment)
                    .AddFragRef(this.ObservationLeafFragment)
                    ;
        }
    }
}
