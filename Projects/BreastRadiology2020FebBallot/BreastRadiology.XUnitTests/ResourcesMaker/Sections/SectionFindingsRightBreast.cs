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
        String SectionFindingsRightBreast(ObservationTarget[] abnormalityTargets)
        {
            SDefEditor e = this.CreateObservationEditor("BreastRadSectionFindingsRightBreast",
                                                        "Breast Radiology Findings Right Breast")
                .Description(new Markdown().Paragraph("Findings Right Breast Section"))
                .AddFragRef(this.observationSectionFragmentUrl)
                ;
            e.Select("bodySite").Zero();
            e.Find("hasMember").SliceByUrl(abnormalityTargets);
            e.MapNode.AddObservationTargets(abnormalityTargets);
            return e.SDef.Url;
        }
    }
}
