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
                    "Patient History",
                    new string[] {"Patient History"},
                    ObservationUrl,
                    $"{Group_BaseResources}/PatientHistory",
                    out sectionPatientHistory)
                .Description("Patient History Section",
                    new Markdown()
                    .Paragraph("This resource is the head of the tree of previous observations.")
                    .Paragraph("Child observations are referenced by the 'Observation.hasMember' field.")
                    .Todo(
                        "What resources comprise a patient history. Currently we can only reference observations - this is probably inadequate"
                        )
                )
                .AddFragRef(this.ObservationNoDeviceFragment)
                .AddFragRef(this.ObservationSectionFragment)
                .AddFragRef(this.ObservationNoValueFragment)
                ;
            e.Select("bodySite").Zero();

            e.IntroDoc.ReviewedStatus(ReviewStatus.NotReviewed).ObservationSection($"Patient History");
        }
    }
}
