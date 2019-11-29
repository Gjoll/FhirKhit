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
        String FindingMammoMass(String massShape,
            String massMargin,
            String massDensity)
        {
            SDefEditor e = this.CreateObservationEditor("BreastRadFindingMammoMass",
                    "Breast Radiology Finding Mammography Mass Observation",
                    new string[] { "Mass" })
                .Description(new Markdown()
                    .Paragraph("Breast Radiology Finding Mammography Mass Observation")
                    .Paragraph("If this observation is present, and dataAbsentReason is empty, then a mass was observed " +
                                "and Shape, Margin, and Density observations should be referenced by this observation.")
                    .Paragraph("If this observation is present, and dataAbsentReason is not empty, then a calcification  " +
                                "was not observed and dataAbsentReason contains the reason why and no Shape, Margin, " +
                                "or Density observations should be referenced by this observation")
                    .BiradHeader()
                    .MarkedDown("\"MASS\" is three dimensional and occupies space. It is seen on two different mammographic pro-")
                    .MarkedDown("jections. It has completely or partially convex-outward borders and (when radiodense) appears")
                    .MarkedDown("denser in the center than at the periphery. If a potential mass is seen only on a single projection, it")
                    .MarkedDown("should be called an \"ASYMMETRY\" until its 3-dimensionality is confirmed")
                    .BiradFooter()
                    .Paragraph("This observation has the following three member observations")
                    .List("Shape", "Margin", "Density")
                    .Paragraph("If the CodedValue value is set to present, then references to the above member observations should be ",
                                "present and non-null, otherwise references should be empty")
                )
                .AddFragRef(this.breastBodyLocationRequiredFragmentUrl)
                .AddFragRef(this.observationSectionFragmentUrl)
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
            e.Select("value[x]").Zero();
            return e.SDef.Url;
        }
    }
}
