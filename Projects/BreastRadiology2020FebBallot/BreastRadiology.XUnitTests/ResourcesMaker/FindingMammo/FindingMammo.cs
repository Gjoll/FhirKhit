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
                    "Breast Radiology Mammography Finding",
                    new string[] {"Mammo", "Finding"},
                    ObservationUrl,
                    out findingMammo)
                .Description(new Markdown()
                            .Paragraph("Breast Radiology Mammography Finding")
                            .BiradHeader()
                            .MarkedDown("A \"MASS\" is three dimensional and occupies space. It is seen on two different mammographic pro-")
                            .MarkedDown("jections. It has completely or partially convex-outward borders and (when radiodense) appears")
                            .MarkedDown("denser in the center than at the periphery. If a potential mass is seen only on a single projection, it")
                            .MarkedDown("should be called an \"ASYMMETRY\" until its 3-dimensionality is confirmed (See Section D on Asym-")
                            .MarkedDown("metries and also the Guidance chapter). (Insert links/page #s)")
                            .BiradFooter()
                            )
                .AddFragRef(this.PureObservationSectionFragment)
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
        }
    }
}
