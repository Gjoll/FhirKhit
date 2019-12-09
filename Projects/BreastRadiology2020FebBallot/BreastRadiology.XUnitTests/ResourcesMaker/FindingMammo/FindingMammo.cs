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
    // todo: Should Observation.device be mare required?
    partial class ResourcesMaker : ConverterBase
    {
        String FindingMammo
        {
            get
            {
                if (findingMammo == null)
                    CreateFindingMammo();
                return findingMammo;
            }
        }
        String findingMammo = null;

        void CreateFindingMammo()
        {
            SDefEditor e = this.CreateEditor("BreastRadMammoFinding",
                    "Mammo Finding",
                    new string[] {"Mammo", "Finding"},
                    ObservationUrl,
                    out findingMammo)
                .Description(new Markdown()

                    .Paragraph("Breast Radiology Mammography Finding")
                    .Paragraph("Todo: The following items need further specification.")
                    .List(
                        "Device Metrics detailing the observation devices parameters (transducer freq, etc)."
                        )
                    )
                .AddFragRef(this.ObservationSectionFragment)
                .AddFragRef(this.ObservationNoValueFragment)
                ;
            ////$ todo. Incorrect method!!!
            //e.Find("method")
            // .FixedCodeSlice("method", "http://snomed.info/sct", "115341008")
            // .Card(1, "*")
            // ;

            {
                ProfileTargetSlice[] targets = new ProfileTargetSlice[]
                {
                    new ProfileTargetSlice(this.MammoBreastDensity, 1, "1"),
                    new ProfileTargetSlice(this.MammoMass, 0, "*"),
                    new ProfileTargetSlice(this.MammoCalcification, 0, "*"),
                    new ProfileTargetSlice(this.MammoArchitecturalDistortion, 0, "1"),
                    new ProfileTargetSlice(this.MammoAsymmetries, 0, "*"),
                    new ProfileTargetSlice(this.MammoIntramammaryLymphNode, 0, "1"),
                    new ProfileTargetSlice(this.MammoSkinLesion, 0, "*"),
                    new ProfileTargetSlice(this.MammoSolitaryDilatedDuct, 0, "1"),
                    new ProfileTargetSlice(this.MammoAssociatedFeatures, 0, "1")
                };
                e.Find("hasMember").SliceByUrl(targets);
                e.MapNode.AddProfileTargets(targets);
            }

            e.IntroDoc.ReviewedStatus(ReviewStatus.NotReviewed).ObservationSection("MRI Abnormality");
        }
    }
}
