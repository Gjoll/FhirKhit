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
        String SectionFindingsLeftBreast
        {
            get
            {
                if (sectionFindingsLeftBreast == null)
                     CreateSectionFindingsLeftBreast();
                return sectionFindingsLeftBreast;
            }
        }
        String sectionFindingsLeftBreast = null;

        void CreateSectionFindingsLeftBreast()
        {
            SDefEditor e = this.CreateEditor("BreastRadSectionFindingsLeftBreast",
                    "Findings Left Breast",
                    new string[] {"Left Breast"},
                    ObservationUrl,
                    $"{Group_BaseResources}/Findings/LeftBreast",
                    out sectionFindingsLeftBreast)
                .Description("Findings Left Breast Section",
                    new Markdown()
                    .Paragraph("This resource is the head of the tree of observations made of the left breast during a breast radiology exam.")
                    .Paragraph("Child observations are referenced by the 'Observation.hasMember' field")
                    .Todo(
                    )
                )
                .AddFragRef(this.ObservationNoDeviceFragment)
                .AddFragRef(this.ObservationSectionFragment)
                .AddFragRef(this.ObservationNoValueFragment)
                ;
            e.Select("bodySite").Zero();
            e.Find("hasMember").SliceByUrl(this.FindingBreastTargets);
            e.MapNode.AddProfileTargets(this.FindingBreastTargets);

            e.IntroDoc.ReviewedStatus(ReviewStatus.NotReviewed).ObservationSection($"Abnormality Left Breast Finding");
        }
    }
}
