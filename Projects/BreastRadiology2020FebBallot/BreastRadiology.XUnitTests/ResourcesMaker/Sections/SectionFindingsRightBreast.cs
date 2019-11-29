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
        String SectionFindingsRightBreast
        {
            get
            {
                if (sectionFindingsRightBreast == null)
                    sectionFindingsRightBreast = CreateSectionFindingsRightBreast();
                return sectionFindingsRightBreast;
            }
        }
        String sectionFindingsRightBreast = null;

        String CreateSectionFindingsRightBreast()
        {
            SDefEditor e = this.CreateObservationEditor("BreastRadSectionFindingsRightBreast",
                    "Breast Radiology Findings Right Breast",
                    new string[] {"Right Breast"})
                .Description(new Markdown().Paragraph("Findings Right Breast Section"))
                .AddFragRef(this.ObservationSectionFragment)
                ;
            e.Select("bodySite").Zero();
            e.Find("hasMember").SliceByUrl(this.FindingBreastTargets);
            e.MapNode.AddProfileTargets(this.FindingBreastTargets);
            return e.SDef.Url;
        }
    }
}
