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
        async StringTask USMass()
        {
            if (usMass == null)
                await CreateUSMass();
            return usMass;
        }
        String usMass = null;

        async VTask CreateUSMass()
        {
            await VTask.Run(async () =>
            {
                SDefEditor e = this.CreateEditor("BreastRadUSMass",
                        "US Mass",
                        new string[] { "US Mass" },
                        ObservationUrl,
                        $"{Group_USResources}/Finding/Mass",
                        out usMass)
                    .Description("Breast Radiology Mammography Ultra-Sound Mass Observation",
                        new Markdown()
                            .MissingObservation("a mass", "and no Shape, Orientation, Margin, Echo Pattern, or Posterior Acoustic Feature observations should be referenced by this observation")
                            .BiradHeader()
                            .BlockQuote("A mass is three dimensional and occupies space. With 2-D ultrasound, it should be seen in two")
                            .BlockQuote("different planes, and in three planes with volumetric acquisitions. Masses can be distinguished")
                            .BlockQuote("from normal anatomic structures, such as ribs or fat lobules, using two or more projections and")
                            .BlockQuote("real-time scanning.")
                            .BiradFooter()
                            .Paragraph("This observation has the following three observations:")
                            .List("Shape", "Orientation", "Margin", "Echo Pattern", "Posterior acoustic features")
                            .Todo(
                                "add mass size measurements (3 dimensional) like US?",
                                "same for asymmetry, lesion, calcification?"
                            )
                    )
                    .AddFragRef(await this.ObservationNoDeviceFragment())
                    .AddFragRef(await this.BreastBodyLocationRequiredFragment())
                    .AddFragRef(await this.ObservationSectionFragment())
                    .AddFragRef(await this.ObservationNoValueFragment())
                    .AddExtensionLink(await this.BreastBodyLocationExtension())
                    .AddFragRef(await this.ImagingStudyFragment())
                    ;
                {
                    ProfileTargetSlice[] targets = new ProfileTargetSlice[]
                    {
                    new ProfileTargetSlice(await this.BreastRadObservedSize(), 0, "1"),
                    new ProfileTargetSlice(await this.BreastRadObservedCount(), 0, "1"),
                    new ProfileTargetSlice(await this.BreastRadMassShape(), 0, "1"),
                    new ProfileTargetSlice(await this.USMassOrientation(), 0, "1"),
                    new ProfileTargetSlice(await this.USMassMargin(), 0, "*"),
                    new ProfileTargetSlice(await this.USMassEchoPattern(), 0, "1"),
                    new ProfileTargetSlice(await this.USMassPosteriorAcousticFeatures(), 0, "1"),
                    new ProfileTargetSlice(await this.BreastRadObservedChanges(), 0, "*"),
                    new ProfileTargetSlice(await this.BreastRadObservedState(), 0, "1", false)
                        //new ProfileTargetSlice(await this.MammoAssociatedFeatures, 0, "1", false)
                    };
                    e.Find("hasMember").SliceByUrl(targets);
                    e.Node.AddProfileTargets(targets);
                }

                e.IntroDoc.ReviewedStatus(ReviewStatus.NotReviewed).ObservationSection($"Ultra-Sound Mass");
            });
        }
    }
}
