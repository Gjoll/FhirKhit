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
        async StringTask MammoCalcification()
        {
            if (mammoCalcification == null)
                await CreateMammoCalcification();
            return mammoCalcification;
        }
        String mammoCalcification = null;

        async VTask CreateMammoCalcification()
        {
            await VTask.Run(async () =>
            {
                SDefEditor e = this.CreateEditor("BreastRadMammoCalcification",
                        "Mammo Calcification",
                        new string[] { "Mammo", "Calc." },
                        ObservationUrl,
                        $"{Group_MammoResources}/Calcification",
                        out mammoCalcification)
                    .Description("Breast Radiology Mammography Calcification Observation",
                        new Markdown()
                            .MissingObservation("a calcification",
                                " and no Type or Distribution observations should be referenced by this observation")
                            .BiradHeader()
                            .BlockQuote("Calcifications that are assessed as benign at mammography are typically larger, coarser, round with")
                            .BlockQuote("smooth margins, and more easily seen than malignant calcifications. Calcifications associated with")
                            .BlockQuote("malignancy (and many benign calcifications as well) are usually very small and often require the use")
                            .BlockQuote("of magnification to be seen well. When a specific typically benign etiology cannot be assigned, a")
                            .BlockQuote("description of calcifications should include their morphology and distribution. Calcifications that are")
                            .BlockQuote("obviously benign need not be reported, especially if the interpreting physician is concerned that")
                            .BlockQuote("the referring clinician or patient might infer anything other than absolute confidence in benignity")
                            .BlockQuote("were such calcifications described in the report. However, typically benign calcifications should be")
                            .BlockQuote("reported if the interpreting physician is concerned that other observers might misinterpret them as")
                            .BlockQuote("anything but benign were such calcifications not described in the report.")
                            .BlockQuote("As an ASSOCIATED FEATURE, this may be used in conjunction with one or more other FINDING(S)")
                            .BlockQuote("to describe calcifications within or immediately adjacent to the finding(s)")
                            .BiradFooter()
                            .Paragraph("This observation has the following member observations:")
                            .List("Calcification Type", "Calcification Distribution")
                            .Todo(
                            )
                    )
                    .AddFragRef(await this.ObservationNoDeviceFragment())
                    .AddFragRef(await this.BreastBodyLocationRequiredFragment())
                    .AddFragRef(await this.ObservationSectionFragment())
                    .AddFragRef(await this.ObservationNoValueFragment())
                    .AddExtensionLink(await this.BreastBodyLocationExtension())
                    ;

                {
                    ProfileTargetSlice[] targets = new ProfileTargetSlice[]
                    {
                    new ProfileTargetSlice(await this.BreastRadObservedSize(), 0, "1"),
                    new ProfileTargetSlice(await this.BreastRadObservedCount(), 0, "1"),
                    new ProfileTargetSlice(await MammoCalcificationType(), 0, "1"),
                    new ProfileTargetSlice(await MammoCalcificationDistribution(), 0, "1"),
                    new ProfileTargetSlice(await this.BreastRadObservedChanges(), 0, "*"),
                    new ProfileTargetSlice(await this.MammoAssociatedFeatures(), 0, "1", false),
                    new ProfileTargetSlice(await this.BreastRadObservedState(), 0, "1", false)
                    };
                    e.Find("hasMember").SliceByUrl(targets);
                    e.Node.AddProfileTargets(targets);
                }
                e.IntroDoc.ReviewedStatus(ReviewStatus.NotReviewed).ObservationSection("Mammography Calcification");
            });
        }
    }
}
