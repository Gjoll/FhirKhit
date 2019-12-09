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
        String MammoCalcification
        {
            get
            {
                if (mammoCalcification == null)
                    CreateMammoCalcification();
                return mammoCalcification;
            }
        }
        String mammoCalcification = null;

        void CreateMammoCalcification()
        {
            SDefEditor e = this.CreateEditor("BreastRadMammoCalcification",
                    "Mammo Calcification",
                    new string[] {"Calcification"},
                    ObservationUrl,
                    out mammoCalcification)
                .Description(new Markdown()

                    .Paragraph("Breast Radiology Mammography Calcification Observation")
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
                    .Paragraph("This observation has the following two member observations")
                    .List("Calcification Type", "Calcification Distribution")
                )
                .AddFragRef(this.ObservationNoDeviceFragment)
                .AddFragRef(this.BreastBodyLocationRequiredFragment)
                .AddExtensionLink(this.BreastBodyLocationExtension)
                .AddFragRef(this.ObservationSectionFragment)
                .AddFragRef(this.ObservationNoValueFragment)
                ;

            {
                ProfileTargetSlice[] targets = new ProfileTargetSlice[]
                {
                    new ProfileTargetSlice(this.BreastRadSize, 0, "1"),
                    new ProfileTargetSlice(this.BreastRadCount, 0, "1"),
                    new ProfileTargetSlice(MammoCalcificationType, 0, "1"),
                    new ProfileTargetSlice(MammoCalcificationDistribution, 0, "1"),
                    new ProfileTargetSlice(this.BreastRadObservedChanges, 0, "*"),
                    new ProfileTargetSlice(this.MammoAssociatedFeatures, 0, "1", false),
                    new ProfileTargetSlice(this.BreastRadObservedState, 0, "1", false)
                };
                e.Find("hasMember").SliceByUrl(targets);
                e.MapNode.AddProfileTargets(targets);
            }
            e.IntroDoc.ReviewedStatus(ReviewStatus.NotReviewed).ObservationSection("Mammography Calcification");
        }
    }
}
