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
    partial class ResourcesMaker : ConverterBase
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
            SDefEditor e = this.CreateEditor("BreastRadSectionFindings",
                    "Breast Radiology Findings",
                    new string[] {"Findings"},
                    ObservationUrl,
                    out sectionFindings)
                .Description(new Markdown().Paragraph("Findings Section"))
                .AddFragRef(this.ObservationSectionFragment)
                .AddFragRef(this.ObservationNoValueFragment)
                ;

            e.Select("bodySite").Zero();
            {
                ProfileTargetSlice[] targets = new ProfileTargetSlice[]
                {
                    new ProfileTargetSlice(SectionFindingsLeftBreast, 1, "1"),
                    new ProfileTargetSlice(SectionFindingsRightBreast, 1, "1")
                };
                e.Find("hasMember").SliceByUrl(targets);
                e.MapNode.AddProfileTargets(targets);
            }
        }
    }
}
