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
    /*
     * How do I characterise Ultra Sound equipment.
     * todo:
     * BiRads US calcifications are only listed as 
     * a) calc in a mass
     * b) calc outside a mass
     * c) intraductal calcification.
     * Can we use the Mammo calcification structure instead?
     * 
     * US Special cases (page 155 E.). 
     * How to handle.
     * 
     * Associated features:
     * Mammo/Ultra-Sound/MRI associated fetures are similar. Can we merge?
     * us has
     * - Edema
     * - Vascularity
     * - Elasticity Assessment
     * 
     * Mammo has
     * - Trabecular thickening
     * - Axillary adenopathy
     * 
     * mri has
     *  - Skin INvasion
     *  - Nipple Invasion
     * 
     * Mammo/Ultra-Sound/MRI Mass Margin are different.
     * Not Circumscribed differently.
     * Can they be aligned?
     * 
     * Mammo/Ultra-Sound/MRI Breast Density similar but not same.
     * Can they be aligned?
     * 
     */
    partial class ResourcesMaker : ConverterBase
    {
        String FindingUltraSound
        {
            get
            {
                if (findingUltraSound == null)
                    CreateFindingUltraSound();
                return findingUltraSound;
            }
        }
        String findingUltraSound = null;

        void CreateFindingUltraSound()
        {
            //$ Fix me. Incorrect method!!!
            SDefEditor e = this.CreateEditor("BreastRadUltraSoundFinding",
                    "UltraSound Finding",
                    new string[] { "UltraSound", "Finding" },
                    ObservationUrl,
                    out findingUltraSound)
                .Description(new Markdown()

                    .Paragraph("Breast Radiology Ultra Sound Finding")
                    .Paragraph("Todo: The following items need further specification.")
                    .List(
                        "Device Metrics detailing the observation devices parameters (transducer freq, etc)."
                        )
                    )
                .AddFragRef(this.ObservationSectionFragment)
                .AddFragRef(this.ObservationNoValueFragment)
                ;
            //$e.Find("method")
            //$ .FixedCodeSlice("method", "http://snomed.info/sct", "115341008")
            //$ .Card(1, "*")
            //$ ;
            {
                ProfileTargetSlice[] targets = new ProfileTargetSlice[]
                {
                    new ProfileTargetSlice(this.USTissueComposition, 1, "1"),
                    new ProfileTargetSlice(this.USMass, 0, "*"),
                    //new ProfileTargetSlice(this.MammoCalcification, 0, "*"),
                    //new ProfileTargetSlice(this.MammoArchitecturalDistortion, 0, "1"),
                    //new ProfileTargetSlice(this.MammoAsymmetries, 0, "*"),
                    //new ProfileTargetSlice(this.MammoIntramammaryLymphNode, 0, "1"),
                    //new ProfileTargetSlice(this.MammoSkinLesion, 0, "*"),
                    //new ProfileTargetSlice(this.MammoSolitaryDilatedDuct, 0, "1"),
                    //new ProfileTargetSlice(this.MammoAssociatedFeatures, 0, "1")
                };
                e.Find("hasMember").SliceByUrl(targets);
                e.MapNode.AddProfileTargets(targets);
            }
            e.IntroDoc.ReviewedStatus(ReviewStatus.NotReviewed).ObservationSection("Ultra-Sound Abnormality");
        }
    }
}
