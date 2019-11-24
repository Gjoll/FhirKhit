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
        String SectionFindingsLeftBreast(ProfileTarget[] abnormalityTargets)
        {
            SDefEditor e = this.CreateObservationEditor("BreastRadSectionFindingsLeftBreast",
                                                        "Breast Radiology Findings Left Breast")
                .Description(new Markdown().Paragraph("Findings Left Breast Section"))
                .AddFragRef(this.observationSectionFragmentUrl)
                ;
            e.Select("bodySite").Zero();
            e.Find("hasMember").SliceByUrl(abnormalityTargets);
            e.MapNode.AddProfileTargets(abnormalityTargets);
            return e.SDef.Url;
        }
    }
}
