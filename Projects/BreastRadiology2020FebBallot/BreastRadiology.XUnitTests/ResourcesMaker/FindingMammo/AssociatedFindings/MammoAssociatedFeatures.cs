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
        String MammoAssociatedFeatures
        {
            get
            {
                if (mammoAssociatedFeatures == null)
                    mammoAssociatedFeatures = CreateMammoAssociatedFeatures();
                return mammoAssociatedFeatures;
            }
        }
        String mammoAssociatedFeatures = null;

        String CreateMammoAssociatedFeatures()
        {
            SDefEditor e = this.CreateObservationEditor("BreastRadMammoAssociatedFeatures",
                    "Breast Radiology Mammography Associated Features",
                    new string[] {"Mammo", "Associated", "Features"})
                .Description(new Markdown()
                            .Paragraph("Mammography Associated Features Observation")
                            .Paragraph("Used with masses, asymmetries, or calcifications, or may stand alone as " +
                            "Features when no other abnormality is present.")
                            )
                .AddFragRef(this.FindingSectionFragment)
                ;
            {
                ProfileTarget[] targets = new ProfileTarget[]
                {
                //    new ProfileTarget(mammoBreastDensity, 1, "1"),
                //    new ProfileTarget(mammoMass, 0, "*"),
                //    new ProfileTarget(calc, 0, "*"),
                //    new ProfileTarget(archDist, 0, "1"),
                //    new ProfileTarget(asymetries, 0, "*"),
                //    new ProfileTarget(intramammaryLymphNode, 1, "1"),
                //    new ProfileTarget(skinLesions, 0, "*"),
                //    new ProfileTarget(solitaryDilatedDuct, 1, "1")
                };
                e.Find("hasMember").SliceByUrl(targets);
                e.MapNode.AddProfileTargets(targets);
            }
            return e.SDef.Url;
        }
    }
}
