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
                    "Breast Radiology Patient Risk Section",
                    new string[] {"Patient","Risk"},
                    ObservationUrl,
                    out sectionPatientRisk)
                .Description(new Markdown().Paragraph("Patient Risk Section"))
                .AddFragRef(this.PureObservationSectionFragment)
                ;
            e.Select("bodySite").Zero();
        }
    }
}
