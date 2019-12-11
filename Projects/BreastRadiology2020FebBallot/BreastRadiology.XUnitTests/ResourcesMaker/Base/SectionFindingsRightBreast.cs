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
                    $"{Group_BaseResources}/Findings/RightBreast",
                    out sectionFindingsRightBreast)
                .Description("Findings Right Breast Section",
                    new Markdown()
                    .Paragraph("This resource is the head of the tree of observations made of the right breast during a breast radiology exam.")
                    .Paragraph("Child observations are referenced by the 'Observation.hasMember' field.")
                    .Todo(
                    )
                )
                .AddFragRef(this.ObservationNoDeviceFragment)
                .AddFragRef(this.ObservationSectionFragment)
                .AddFragRef(this.ObservationNoValueFragment)
                ;
            e.Select("bodySite").Zero();
            e.Find("hasMember").SliceByUrl(this.FindingBreastTargets);
            e.Node.AddProfileTargets(this.FindingBreastTargets);

            e.IntroDoc.ReviewedStatus(ReviewStatus.NotReviewed).ObservationSection($"Abnormality Right Breast Finding");
        }
    }
}
