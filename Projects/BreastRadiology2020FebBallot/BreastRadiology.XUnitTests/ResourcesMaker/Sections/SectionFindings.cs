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
        String SectionFindings
        {
            get
            {
                if (sectionFindings == null)
                    CreateSectionFindings();
                return sectionFindings;
            }
        }
        String sectionFindings = null;

        void CreateSectionFindings()
        {
            SDefEditor e = this.CreateObservationEditor("BreastRadSectionFindings",
                    "Breast Radiology Findings",
                    new string[] {"Findings"},
                    out sectionFindings)
                .Description(new Markdown().Paragraph("Findings Section"))
                .AddFragRef(this.ObservationSectionFragment)
                ;

            e.Select("bodySite").Zero();
            {
                ProfileTarget[] targets = new ProfileTarget[]
                {
                    new ProfileTarget(SectionFindingsLeftBreast, 1, "1"),
                    new ProfileTarget(SectionFindingsRightBreast, 1, "1")
                };
                e.Find("hasMember").SliceByUrl(targets);
                e.MapNode.AddProfileTargets(targets);
            }
        }
    }
}
