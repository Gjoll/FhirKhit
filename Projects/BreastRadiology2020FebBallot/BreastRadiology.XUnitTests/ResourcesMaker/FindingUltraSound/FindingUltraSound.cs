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
    public partial class ResourcesMaker : ConverterBase
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
            SDefEditor e =  this.CreateObservationEditor("BreastRadUltraSoundFinding",
                    "Breast Radiology UltraSound Finding",
                    new string[] {"UltraSound"},
                    out findingUltraSound)
                .Description(new Markdown().Paragraph("Breast Radiology Ultra Sound Finding"))
                .AddFragRef(this.FindingSectionFragment)
                ;
            //$e.Find("method")
            //$ .FixedCodeSlice("method", "http://snomed.info/sct", "115341008")
            //$ .Card(1, "*")
            //$ ;
            {
                ProfileTarget[] targets = new ProfileTarget[]
                {
                    new ProfileTarget(this.USTissueComposition, 1, "1"),
                    //new ProfileTarget(this.MammoMass, 0, "*"),
                    //new ProfileTarget(this.MammoCalcification, 0, "*"),
                    //new ProfileTarget(this.MammoArchitecturalDistortion, 0, "1"),
                    //new ProfileTarget(this.MammoAsymmetries, 0, "*"),
                    //new ProfileTarget(this.MammoIntramammaryLymphNode, 0, "1"),
                    //new ProfileTarget(this.MammoSkinLesion, 0, "*"),
                    //new ProfileTarget(this.MammoSolitaryDilatedDuct, 0, "1"),
                    //new ProfileTarget(this.MammoAssociatedFeatures, 0, "1")
                };
                e.Find("hasMember").SliceByUrl(targets);
                e.MapNode.AddProfileTargets(targets);
            }
        }
    }
}
