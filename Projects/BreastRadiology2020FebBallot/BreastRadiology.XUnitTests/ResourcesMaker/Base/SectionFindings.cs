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
                    "Findings",
                    new string[] {"Findings"},
                    ObservationUrl,
                    $"{Group_BaseResources}/Findings",
                    out sectionFindings)
                .Description("Findings Section",
                    new Markdown()
                    .Paragraph("This resource is the head of the tree of observations made during a breast radiology exam.")
                    .Paragraph("Child observations are referenced by the 'Observation.hasMember' field.")
                    .Todo(
                    )
                )
                .AddFragRef(this.ObservationNoDeviceFragment)
                .AddFragRef(this.ObservationSectionFragment)
                .AddFragRef(this.ObservationNoValueFragment)
                ;

            e.Select("bodySite").Zero();
            {
                ProfileTargetSlice[] targets = new ProfileTargetSlice[]
                {
                    new ProfileTargetSlice(this.BiRadsAssessmentCategory, 1, "1"),
                    new ProfileTargetSlice(SectionFindingsLeftBreast, 1, "1"),
                    new ProfileTargetSlice(SectionFindingsRightBreast, 1, "1")
                };
                e.Find("hasMember").SliceByUrl(targets);
                e.MapNode.AddProfileTargets(targets);
            }

            e.IntroDoc.ReviewedStatus(ReviewStatus.NotReviewed).ObservationSection($"Abnormality Finding");
        }
    }
}
