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
        async StringTask MGMass()
        {
            if (mgMass == null)
                await CreateMGMass();
            return mgMass;
        }
        String mgMass = null;

        async VTask CreateMGMass()
        {
            await VTask.Run(async () =>
            {
                SDefEditor e = this.CreateEditor("BreastRadMammoMass",
                        "Mammo Mass",
                        new string[] { "Mammo", "Mass" },
                        ObservationUrl,
                        $"{Group_MammoResources}/Mass",
                        out mgMass)
                    .Description("Breast Radiology Mammography Mass Observation",
                        new Markdown()
                            .MissingObservation("a mass", "and no Shape, Margin, or Density observations should be referenced by this observation")
                            .BiradHeader()
                            .BlockQuote("\"MASS\" is three dimensional and occupies space. It is seen on two different mammographic pro-")
                            .BlockQuote("jections. It has completely or partially convex-outward borders and (when radiodense) appears")
                            .BlockQuote("denser in the center than at the periphery. If a potential mass is seen only on a single projection, it")
                            .BlockQuote("should be called an \"ASYMMETRY\" until its 3-dimensionality is confirmed")
                            .BiradFooter()
                            .Paragraph("This observation has the following member observations:")
                            .List("Shape", "Margin", "Density", "Orientation")
                            .Todo(
                                "add mass size measurements (3 dimensional) like US?",
                                "same for asymmetry, lesion, calcification?"
                            )
                    )
                    .AddFragRef(await this.ObservationNoDeviceFragment())
                    .AddFragRef(await this.BreastBodyLocationRequiredFragment())
                    .AddFragRef(await this.ObservationSectionFragment())
                    .AddFragRef(await this.ObservationNoValueFragment())
                    .AddFragRef(await this.ImagingStudyFragment())
                    .AddExtensionLink(await this.BreastBodyLocationExtension())
                    ;

                {
                    ProfileTargetSlice[] targets = new ProfileTargetSlice[]
                    {
                    new ProfileTargetSlice(await this.BreastRadObservedSize(), 0, "1"),
                    new ProfileTargetSlice(await this.BreastRadObservedCount(), 0, "1"),
                    new ProfileTargetSlice(await this.BreastRadMassShape(), 0, "1"),
                    new ProfileTargetSlice(await this.Orientation(), 0, "1"),
                    new ProfileTargetSlice(await this.MGMassMargin(), 0, "*"),
                    new ProfileTargetSlice(await this.MGMassDensity(), 0, "1"),
                    new ProfileTargetSlice(await this.BreastRadObservedChanges(), 0, "*"),
                    new ProfileTargetSlice(await this.MammoAssociatedFeatures(), 0, "1", false),
                    new ProfileTargetSlice(await this.BreastRadObservedState(), 0, "1", false)
                    };
                    e.Find("hasMember").SliceByUrl(targets);
                    e.Node.AddProfileTargets(targets);
                }

                e.IntroDoc
                    .ReviewedStatus(ReviewStatus.NotReviewed)
                    .ObservationSection("Mammography Mass")
                    ;
            });
        }
    }
}
