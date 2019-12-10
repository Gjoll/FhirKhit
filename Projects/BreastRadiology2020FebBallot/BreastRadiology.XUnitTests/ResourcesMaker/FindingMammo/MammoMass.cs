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
        String MammoMass
        {
            get
            {
                if (mammoMass == null)
                    CreateMammoMass();
                return mammoMass;
            }
        }
        String mammoMass = null;

        void CreateMammoMass()
        {
            SDefEditor e = this.CreateEditor("BreastRadMammoMass",
                    "Mammo Mass",
                    new string[] { "Mass" },
                    ObservationUrl,
                    $"{Group_MammoResources}/Mass",
                    out mammoMass)
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
                        .List("Shape", "Margin", "Density")
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
                    new ProfileTargetSlice(this.MammoMassMargin, 0, "1"),
                    new ProfileTargetSlice(this.MammoMassDensity, 0, "1"),
                    new ProfileTargetSlice(this.BreastRadObservedChanges, 0, "*"),
                    new ProfileTargetSlice(this.MammoAssociatedFeatures, 0, "1", false),
                    new ProfileTargetSlice(this.BreastRadObservedState, 0, "1", false)
                };
                e.Find("hasMember").SliceByUrl(targets);
                e.MapNode.AddProfileTargets(targets);
            }

            e.IntroDoc.ReviewedStatus(ReviewStatus.NotReviewed).ObservationSection("Mammography Mass");
        }
    }
}
