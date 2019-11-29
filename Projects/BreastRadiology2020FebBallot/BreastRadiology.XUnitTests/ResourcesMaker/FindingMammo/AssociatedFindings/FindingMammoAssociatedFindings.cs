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
        String FindingMammoAssociatedFindings
        {
            get
            {
                if (findingMammoAssociatedFindings == null)
                    findingMammoAssociatedFindings = CreateFindingMammoAssociatedFindings();
                return findingMammoAssociatedFindings;
            }
        }
        String findingMammoAssociatedFindings = null;

        String CreateFindingMammoAssociatedFindings()
        {
            SDefEditor e = this.CreateObservationEditor("BreastRadFindingAssociatedFindings",
                    "Breast Radiology Finding Mammography Associated Findings",
                    new string[] {"Mammo", "Finding"})
                .Description(new Markdown()
                            .Paragraph("Mammography Breast Finding Mammography Associated Findings Observation")
                            )
                .AddFragRef(this.FindingSectionFragment)
                ;
            ////$ todo. Incorrect method!!!
            //e.Find("method")
            // .FixedCodeSlice("method", "http://snomed.info/sct", "115341008")
            // .Card(1, "*")
            // ;

            {
                //ProfileTarget[] targets = new ProfileTarget[]
                //{
                //    new ProfileTarget(mammoBreastDensity, 1, "1"),
                //    new ProfileTarget(mammoMass, 0, "*"),
                //    new ProfileTarget(calc, 0, "*"),
                //    new ProfileTarget(archDist, 0, "1"),
                //    new ProfileTarget(asymetries, 0, "*"),
                //    new ProfileTarget(intramammaryLymphNode, 1, "1"),
                //    new ProfileTarget(skinLesions, 0, "*"),
                //    new ProfileTarget(solitaryDilatedDuct, 1, "1")
                //};
                //e.Find("hasMember").SliceByUrl(targets);
                //e.MapNode.AddProfileTargets(targets);
            }
            return e.SDef.Url;
        }
    }
}
