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
        String SectionFindingsRightBreast
        {
            get
            {
                if (sectionFindingsRightBreast == null)
                    CreateSectionFindingsRightBreast();
                return sectionFindingsRightBreast;
            }
        }
        String sectionFindingsRightBreast = null;

        void CreateSectionFindingsRightBreast()
        {
            SDefEditor e = this.CreateEditor("BreastRadSectionFindingsRightBreast",
                    "Findings Right Breast",
                    new string[] {"Right Breast"},
                    ObservationUrl,
                    "Base/Findings/RightBreast",
                    out sectionFindingsRightBreast)
                .Description(new Markdown()

                    .Paragraph("Findings Right Breast Section")
                    )
                .AddFragRef(this.ObservationNoDeviceFragment)
                .AddFragRef(this.ObservationSectionFragment)
                .AddFragRef(this.ObservationNoValueFragment)
                ;
            e.Select("bodySite").Zero();
            e.Find("hasMember").SliceByUrl(this.FindingBreastTargets);
            e.MapNode.AddProfileTargets(this.FindingBreastTargets);

            e.IntroDoc.ReviewedStatus(ReviewStatus.NotReviewed).ObservationSection($"Abnormality Right Breast Finding");
        }
    }
}
