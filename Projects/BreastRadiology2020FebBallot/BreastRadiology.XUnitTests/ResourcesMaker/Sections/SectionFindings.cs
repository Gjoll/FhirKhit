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
        String SectionFindings(String findingsLeftUrl,
            String findingsRightUrl)
        {
            SDefEditor e = this.CreateObservationEditor("BreastRadSectionFindings",
                                                        "Breast Radiology Findings")
                .Description(new Markdown().Paragraph("Findings Section"))
                .AddFragRef(this.observationSectionFragmentUrl)
                ;

            e.Select("bodySite").Zero();
            {
                ObservationTarget[] targets = new ObservationTarget[]
                {
                    new ObservationTarget(findingsLeftUrl, 1, "1"),
                    new ObservationTarget(findingsRightUrl, 1, "1")
                };
                e.Find("hasMember").SliceByUrl(targets);
                e.MapNode.AddObservationTargets(targets);
            }

            return e.SDef.Url;
        }
    }
}
