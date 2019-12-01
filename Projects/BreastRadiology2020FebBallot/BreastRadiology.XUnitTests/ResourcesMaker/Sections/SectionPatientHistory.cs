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
    public partial class ResourcesMaker : ConverterBase
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
                    "Breast Radiology Patient History Section",
                    new string[] {"Patient History"},
                    ObservationUrl,
                    out sectionPatientHistory)
                .Description(new Markdown().Paragraph("Patient History Section"))
                .AddFragRef(this.PureObservationSectionFragment)
                ;
            e.Select("bodySite").Zero();
        }
    }
}
