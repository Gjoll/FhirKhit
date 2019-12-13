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
        async StringTask FindingMammo()
        {
            if (findingMammo == null)
                await CreateFindingMammo();
            return findingMammo;
        }
        String findingMammo = null;

        async VTask CreateFindingMammo()
        {
            await VTask.Run(async () =>
            {
                SDefEditor e = this.CreateEditor("BreastRadMammoFinding",
                        "Mammo Finding",
                        new string[] { "Mammo", "Finding" },
                        ObservationUrl,
                        $"{Group_MammoResources}",
                        out findingMammo)
                    .Description("Breast Radiology Mammography Finding",
                        new Markdown()
                            .Todo(
                                "Device Metrics detailing the observation devices parameters (transducer freq, etc)."
                                )
                        )
                    .AddFragRef(await this.ObservationSectionFragment())
                    .AddFragRef(await this.ObservationNoValueFragment())
                    ;
                ////$ todo. Incorrect method!!!
                //e.Find("method")
                // .FixedCodeSlice("method", "http://snomed.info/sct", "115341008")
                // .Card(1, "*")
                // ;

                {
                    ProfileTargetSlice[] targets = new ProfileTargetSlice[]
                    {
                    new ProfileTargetSlice(await this.MammoBreastDensity(), 1, "1"),
                    new ProfileTargetSlice(await this.MammoMass(), 0, "*"),
                    new ProfileTargetSlice(await this.MammoCalcification(), 0, "*"),
                    new ProfileTargetSlice(await this.MammoArchitecturalDistortion(), 0, "1"),
                    new ProfileTargetSlice(await this.MammoAsymmetries(), 0, "*"),
                    new ProfileTargetSlice(await this.MammoIntramammaryLymphNode(), 0, "1"),
                    new ProfileTargetSlice(await this.MammoSkinLesion(), 0, "*"),
                    new ProfileTargetSlice(await this.MammoSolitaryDilatedDuct(), 0, "1"),
                    new ProfileTargetSlice(await this.MammoAssociatedFeatures(), 0, "1")
                    };
                    e.Find("hasMember").SliceByUrl(targets);
                    e.Node.AddProfileTargets(targets);
                }

                e.IntroDoc.ReviewedStatus(ReviewStatus.NotReviewed).ObservationSection("MRI Abnormality");
            });
        }
    }
}