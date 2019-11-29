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
                    sectionPatientHistory = CreateSectionPatientHistory();
                return sectionPatientHistory;
            }
        }
        String sectionPatientHistory = null;

        String CreateSectionPatientHistory()
        {
            SDefEditor e = this.CreateObservationEditor("BreastRadSectionPatientHistory",
                    "Breast Radiology Patient History Section",
                    new string[] {"Patient History"})
                .Description(new Markdown().Paragraph("Patient History Section"))
                .AddFragRef(this.ObservationSectionFragment)
                ;
            e.Select("bodySite").Zero();
            return e.SDef.Url;
        }
    }
}
