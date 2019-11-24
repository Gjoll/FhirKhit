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
        String AbMammoCalcifications(String calcType,
            String calcDistribution)
        {
            SDefEditor e = this.CreateObservationEditor("BreastRadMammoCalcifications",
                                                        "Breast Radiology Mammography Calcifications Observation")
                .Description(
                    new Markdown()
                        .Paragraph("Breast Radiology Mammography Calcifications Observation")
                        .Paragraph("This observation has the following two member observations")
                        .List("Calcification Type", "Calcification Distribution")
                    )
                .AddFragRef(this.breastBodyLocationRequiredFragmentUrl)
                .AddFragRef(this.observationSectionFragmentUrl)
                ;

            {
                ProfileTarget[] targets = new ProfileTarget[]
                {
                            new ProfileTarget(calcType, 1, "1"),
                            new ProfileTarget(calcDistribution, 1, "1")
                };
                e.Find("hasMember").SliceByUrl(targets);
                e.MapNode.AddProfileTargets(targets);
            }
            return e.SDef.Url;
        }
    }
}
