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
        String SectionFindingsLeftBreast
        {
            get
            {
                if (sectionFindingsLeftBreast == null)
                    sectionFindingsLeftBreast = CreateSectionFindingsLeftBreast();
                return sectionFindingsLeftBreast;
            }
        }
        String sectionFindingsLeftBreast = null;

        String CreateSectionFindingsLeftBreast()
        {
            SDefEditor e = this.CreateObservationEditor("BreastRadSectionFindingsLeftBreast",
                    "Breast Radiology Findings Left Breast",
                    new string[] {"Left Breast"})
                .Description(new Markdown().Paragraph("Findings Left Breast Section"))
                .AddFragRef(this.ObservationSectionFragment)
                ;
            e.Select("bodySite").Zero();
            e.Find("hasMember").SliceByUrl(this.FindingBreastTargets);
            e.MapNode.AddProfileTargets(this.FindingBreastTargets);
            return e.SDef.Url;
        }
    }
}
