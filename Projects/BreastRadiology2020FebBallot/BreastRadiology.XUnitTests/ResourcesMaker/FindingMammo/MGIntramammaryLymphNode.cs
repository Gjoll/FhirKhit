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
using VTask = System.Threading.Tasks.Task;
using StringTask = System.Threading.Tasks.Task<string>;

namespace BreastRadiology.XUnitTests
{
    partial class ResourcesMaker : ConverterBase
    {
        async StringTask MGIntramammaryLymphNode()
        {
            if (mgIntramammaryLymphNode == null)
                await CreateMGIntramammaryLymphNode();
            return mgIntramammaryLymphNode;
        }
        String mgIntramammaryLymphNode = null;

        async VTask CreateMGIntramammaryLymphNode()
        {
            await VTask.Run(async () =>
            {
                SDefEditor e = this.CreateEditor("BreastRadMammoIntramammaryLymphNode",
                    "Mammo Intramammary LymphNode",
                    new string[] { "Mammo", "Intramammory", "Lymph Node" },
                    ObservationUrl,
                    $"{Group_MammoResources}/IntramammaryLymphNode",
                    out mgIntramammaryLymphNode)
                    .Description("Breast Radiology Mammography Intramammary LymphNode Observation",
                        new Markdown()
                            .MissingObservation("an intramammary lymph node")
                            .BiradHeader()
                            .BlockQuote("These are circumscribed masses that are reniform and have hilar fat. They are generally 1 cm or smaller")
                            .BlockQuote("in size. They may be larger than 1 cm and characterized as normal when fat replacement is pro-")
                            .BlockQuote("nounced. They frequently occur in the lateral and usually upper portions of the breast closer to the")
                            .BlockQuote("axilla, although they may occur anywhere in the breast. They usually are seen adjacent to a vein,")
                            .BlockQuote("because the lymphatic drainage of the breast parallels the venous drainage.")
                            .BiradFooter()
                            .Todo(
                                "should this be a leaf node (how about shape, density, location, etc)."
                            )
                    )
                    .AddFragRef(await this.ObservationNoDeviceFragment())
                    .AddFragRef(await this.BreastBodyLocationRequiredFragment())
                    .AddFragRef(await this.ObservationCodedValueFragment())
                    .AddFragRef(await this.ObservationLeafFragment())
                    .AddExtensionLink(await this.BreastBodyLocationExtension())
                    ;

                e.IntroDoc.ReviewedStatus(ReviewStatus.NotReviewed).ObservationLeafNode($"Intramammary Lymph Node");
            });
        }
    }
}
