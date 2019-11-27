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
                    "Breast Radiology Mammography Mass Observation",
                    new string[] { "Mass" })
                .Description(new Markdown()
                    .Paragraph("Breast Radiology Mammography Mass Observation")
                    .Paragraph("This observation has the following three member observations")
                    .List("Shape", "Margin", "Density")
                    .Paragraph("If the CodedValue value is set to present, then references to the above member observations should be ",
                                "present and non-null, otherwise references should be empty")
                )
                .AddFragRef(this.breastBodyLocationRequiredFragmentUrl)
                .AddFragRef(this.observationSectionFragmentUrl)
                .AddFragRef(this.observationExistanceFragmentUrl)
                ;
            {
                ProfileTarget[] targets = new ProfileTarget[]
                {
                    new ProfileTarget(massShape, 0, "1"),
                    new ProfileTarget(massMargin, 0, "1"),
                    new ProfileTarget(massDensity, 0, "1")
                };
                e.Find("hasMember").SliceByUrl(targets);
                e.MapNode.AddProfileTargets(targets);
            }
            return e.SDef.Url;
        }
    }
}
