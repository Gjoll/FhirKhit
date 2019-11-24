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
        String AbMammoMass(String massShape,
            String massMargin,
            String massDensity)
        {
            SDefEditor e = this.CreateObservationEditor("BreastRadMammoMass",
                                                        "Breast Radiology Mammography Mass Observation")
                .Description(new Markdown()
                    .Paragraph("Breast Radiology Mammography Mass Observation")
                    .Paragraph("This observation has the following three member observations")
                    .List("Shape", "Margin", "Density")
                )
                .AddFragRef(this.breastBodyLocationRequiredFragmentUrl)
                .AddFragRef(this.observationSectionFragmentUrl)
                ;
            {
                ProfileTarget[] targets = new ProfileTarget[]
                {
                    new ProfileTarget(massShape, 1, "1"),
                    new ProfileTarget(massMargin, 1, "1"),
                    new ProfileTarget(massDensity, 1, "1")
                };
                e.Find("hasMember").SliceByUrl(targets);
                e.MapNode.AddProfileTargets(targets);
            }
            return e.SDef.Url;
        }
    }
}
