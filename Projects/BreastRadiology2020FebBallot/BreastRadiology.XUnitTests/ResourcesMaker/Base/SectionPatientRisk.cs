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
        String SectionPatientRisk
        {
            get
            {
                if (sectionPatientRisk == null)
                    CreateSectionPatientRisk();
                return sectionPatientRisk;
            }
        }
        String sectionPatientRisk = null;


        void CreateSectionPatientRisk()
        {
            SDefEditor e = this.CreateEditor("BreastRadSectionPatientRisk",
                    "Patient Risk",
                    new string[] {"Patient","Risk"},
                    ObservationUrl,
                    $"{Group_BaseResources}/PatientRisk",
                    out sectionPatientRisk)
                .Description("Patient Risk Section",
                    new Markdown()
                        .Paragraph("This observation is the section head for the patient risk observations of this exam.")
                        .Todo(
                        )
                )
                .AddFragRef(this.ObservationNoDeviceFragment)
                .AddFragRef(this.ObservationSectionFragment)
                .AddFragRef(this.ObservationNoValueFragment)
                ;
            e.Select("bodySite").Zero();

            e.IntroDoc.ReviewedStatus(ReviewStatus.NotReviewed).ObservationSection($"Patient Risk");
        }
    }
}
