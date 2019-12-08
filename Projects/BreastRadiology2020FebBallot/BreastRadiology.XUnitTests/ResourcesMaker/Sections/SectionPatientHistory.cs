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
        String SectionPatientHistory
        {
            get
            {
                if (sectionPatientHistory == null)
                    CreateSectionPatientHistory();
                return sectionPatientHistory;
            }
        }
        String sectionPatientHistory = null;

        void CreateSectionPatientHistory()
        {
            SDefEditor e = this.CreateEditor("BreastRadSectionPatientHistory",
                    "Patient History Section",
                    new string[] {"Patient History"},
                    ObservationUrl,
                    out sectionPatientHistory)
                .Description(new Markdown()
                    .ReviewedStatus(ReviewStatus.NotReviewed)
                    .Paragraph("Patient History Section")
                    )
                .AddFragRef(this.ObservationSectionFragment)
                .AddFragRef(this.ObservationNoValueFragment)
                ;
            e.Select("bodySite").Zero();

            e.IntroDoc.ObservationSection($"Patient History");
        }
    }
}
