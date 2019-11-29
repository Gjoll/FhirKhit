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
                    findingMammo = CreateFindingMammo();
                return findingMammo;
            }
        }
        String findingMammo = null;

        String CreateFindingMammo()
        {
            SDefEditor e = this.CreateObservationEditor("BreastRadFindingMammo",
                    "Breast Radiology Finding Mammography",
                    new string[] {"Mammo", "Finding"})
                .Description(new Markdown()
                            .Paragraph("Mammography Breast Finding Mammography Observation")
                            .BiradHeader()
                            .MarkedDown("A \"MASS\" is three dimensional and occupies space. It is seen on two different mammographic pro-")
                            .MarkedDown("jections. It has completely or partially convex-outward borders and (when radiodense) appears")
                            .MarkedDown("denser in the center than at the periphery. If a potential mass is seen only on a single projection, it")
                            .MarkedDown("should be called an \"ASYMMETRY\" until its 3-dimensionality is confirmed (See Section D on Asym-")
                            .MarkedDown("metries and also the Guidance chapter). (Insert links/page #s)")
                            .BiradFooter()
                            )
                .AddFragRef(this.FindingSectionFragment)
                ;
            ////$ todo. Incorrect method!!!
            //e.Find("method")
            // .FixedCodeSlice("method", "http://snomed.info/sct", "115341008")
            // .Card(1, "*")
            // ;

            {
                ProfileTarget[] targets = new ProfileTarget[]
                {
                    new ProfileTarget(this.FindingMammoBreastDensity, 1, "1"),
                    new ProfileTarget(this.FindingMammoMass, 0, "*"),
                    new ProfileTarget(this.FindingMammoCalcification, 0, "*"),
                    new ProfileTarget(this.FindingMammoArchitecturalDistortion, 0, "1"),
                    new ProfileTarget(this.FindingMammoAsymmetries, 0, "*"),
                    new ProfileTarget(this.FindingMammoIntramammaryLymphNode, 1, "1"),
                    new ProfileTarget(this.FindingMammoSkinLesion, 0, "*"),
                    new ProfileTarget(this.FindingMammoSolitaryDilatedDuct, 1, "1")
                };
                e.Find("hasMember").SliceByUrl(targets);
                e.MapNode.AddProfileTargets(targets);
            }
            return e.SDef.Url;
        }
    }
}
