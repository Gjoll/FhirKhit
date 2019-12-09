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
    // todo: Should Observation.device be mare required?
    partial class ResourcesMaker : ConverterBase
    {
        String FindingMri
        {
            get
            {
                if (findingMri== null)
                    CreateFindingMri();
                return findingMri;
            }
        }
        String findingMri = null;

        void CreateFindingMri()
        {
            //$ Fix me. Incorrect method!!!
            SDefEditor e = this.CreateEditor("BreastRadMRIFinding",
                    "MRI Finding",
                    new string[] {"MRI", "Finding"},
                    ObservationUrl,
                    out findingMri)
                .Description(new Markdown()

                    .Paragraph("Breast Radiology MRI Finding")
                    .Paragraph("Todo: The following items need further specification.")
                    .List(
                        "Device Metrics detailing the observation devices parameters.",
                        "Add information about contrast enhancement/other observation specific parameters."
                        )
                    )
                .AddFragRef(this.ObservationSectionFragment)
                .AddFragRef(this.ObservationNoValueFragment)
            ;

            e.IntroDoc.ReviewedStatus(ReviewStatus.NotReviewed).ObservationSection("MRI Abnormality");
            //$e.Find("method")
            //$     .FixedCodeSlice("method", "http://snomed.info/sct", "115341008")
            //$     .Card(1, "*")
            //$     ;
        }
    }
}
