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
    public partial class ResourcesMaker : ConverterBase
    {
        // TODO: Should it be a AbMammoIntramammaryLymphNode be required with dataAbsent Reason set to a value if
        // this was looked for and not seen?
        // See other 'If this observation is present, and dataAbsentReason is empty's
        String FindingMammoIntramammaryLymphNode()
        {
            SDefEditor e = this.CreateObservationEditor("BreastRadFindingMammoIntramammaryLymphNode",
                    "Breast Radiology Finding Intramammary LymphNode (Mammography)",
                    new string[] { "Intramammory", "Lymph", "Node" })
                    .Description(new Markdown()
                        .Paragraph("Mammography Breast Finding Intramammary LymphNode Observation")
                        .Paragraph("If this observation is present, and dataAbsentReason is empty, then an intramammary lymph node was observed.")
                        .Paragraph("If this observation is present, and dataAbsentReason is not empty, then an intramammary lymph node distortion " +
                                    "was not observed and dataAbsentReason contains the reason why.")
                        .BiradHeader()
                        .MarkedDown("These are circumscribed masses that are reniform and have hilar fat. They are generally 1 cm or smaller")
                        .MarkedDown("in size. They may be larger than 1 cm and characterized as normal when fat replacement is pro-")
                        .MarkedDown("nounced. They frequently occur in the lateral and usually upper portions of the breast closer to the")
                        .MarkedDown("axilla, although they may occur anywhere in the breast. They usually are seen adjacent to a vein,")
                        .MarkedDown("because the lymphatic drainage of the breast parallels the venous drainage.")
                        .BiradFooter())
                    .AddFragRef(this.breastBodyLocationRequiredFragmentUrl)
                    .AddFragRef(this.findingCodedValueObservationFragmentUrl)
                    ;

            e.Select("value[x]").Zero();
            return e.SDef.Url;
        }
    }
}
