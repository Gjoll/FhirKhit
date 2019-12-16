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
        async StringTask MGSkinLesion()
        {
            if (mgSkinLesion == null)
                await CreateMGSkinLesion();
            return mgSkinLesion;
        }
        String mgSkinLesion = null;

        async VTask CreateMGSkinLesion()
        {
            await VTask.Run(async () =>
            {
                SDefEditor e = this.CreateEditor("BreastRadMammoSkinLesion",
                    "Mammo Skin Lesion",
                    new string[] { "Mammo", "Skin", "Lesion" },
                    ObservationUrl,
                    $"{Group_MammoResources}/SkinLesion",
                    out mgSkinLesion)
                    .Description("Breast Radiology Mammography Skin Lesion Observation",
                        new Markdown()
                            .MissingObservation("a skin lesion")
                            .BiradHeader()
                            .BlockQuote("This finding may be described in the mammography report or annotated on the mammographic")
                            .BlockQuote("image when it projects over the breast (especially on 2 different projections), and may be mistaken")
                            .BlockQuote("for an intramammary lesion. A raised skin lesion sufficiently large to be seen at mammography")
                            .BlockQuote("should be marked by the technologist with a radiopaque device designated for use as a marker for")
                            .BlockQuote("a skin lesion.")
                            .BiradFooter()
                            .Todo(
                            )
                    )
                    .AddFragRef(await this.ObservationNoDeviceFragment())
                    .AddFragRef(await this.BreastBodyLocationRequiredFragment())
                    .AddFragRef(await this.ObservationNoValueFragment())
                    .AddFragRef(await this.ObservationSectionFragment())
                    .AddExtensionLink(await this.BreastBodyLocationExtension())
                    ;

                {
                    ProfileTargetSlice[] targets = new ProfileTargetSlice[]
                    {
                    new ProfileTargetSlice(await this.BreastRadObservedSize(), 0, "1"),
                    new ProfileTargetSlice(await this.BreastRadObservedCount(), 0, "1"),
                    new ProfileTargetSlice(await this.BreastRadObservedChanges(), 0, "*"),
                    new ProfileTargetSlice(await this.BreastRadObservedState(), 0, "1", false)
                    };
                    e.Find("hasMember").SliceByUrl(targets);
                    e.Node.AddProfileTargets(targets);
                }

                e.IntroDoc
                    .ReviewedStatus(ReviewStatus.NotReviewed)
                    .ObservationLeafNode($"Skin Lesion")
                    ;
            });
        }
    }
}
