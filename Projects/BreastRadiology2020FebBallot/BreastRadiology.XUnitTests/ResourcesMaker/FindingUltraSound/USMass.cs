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
        String USMass
        {
            get
            {
                if (usMass == null)
                    CreateUSMass();
                return usMass;
            }
        }
        String usMass = null;

        void CreateUSMass()
        {
            SDefEditor e = this.CreateEditor("BreastRadUSMass",
                    "US Mass",
                    new string[] { "Mass" },
                    ObservationUrl,
                    $"{Group_UltraSoundResources}/Finding/Mass",
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
                        .Paragraph("This observation has the following three member observations")
                        .List("Shape", "Orientation", "Margin", "Echo Pattern", "Posterior acoustic features")
                        .Todo(
                            "add mass size measurements (3 dimensional) like US?",
                            "same for asymmetry, lesion, calcification?"
                        )
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
                    new ProfileTargetSlice(this.BreastRadObservedSize, 0, "1"),
                    new ProfileTargetSlice(this.BreastRadObservedCount, 0, "1"),
                    new ProfileTargetSlice(this.BreastRadMassShape, 0, "1"),
                    new ProfileTargetSlice(this.USMassOrientation, 0, "1"),
                    new ProfileTargetSlice(this.USMassMargin, 0, "1"),
                    new ProfileTargetSlice(this.USMassEchoPattern, 0, "1"),
                    new ProfileTargetSlice(this.USMassPosteriorAcousticFeatures, 0, "1"),
                    new ProfileTargetSlice(this.BreastRadObservedChanges, 0, "*"),
                    new ProfileTargetSlice(this.BreastRadObservedState, 0, "1", false)
                    //new ProfileTargetSlice(this.MammoAssociatedFeatures, 0, "1", false)
                };
                e.Find("hasMember").SliceByUrl(targets);
                e.MapNode.AddProfileTargets(targets);
            }

            e.IntroDoc.ReviewedStatus(ReviewStatus.NotReviewed).ObservationSection($"Ultra-Sound Mass");
        }
    }
}
