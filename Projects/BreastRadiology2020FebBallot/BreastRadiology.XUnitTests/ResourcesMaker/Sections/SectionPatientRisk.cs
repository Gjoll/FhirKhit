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
        String SectionPatientRisk()
        {
            SDefEditor e = this.CreateObservationEditor("BreastRadSectionPatientRisk",
                    "Breast Radiology Patient Risk Section",
                    new string[] {"Patient","Risk"})
                .Description(new Markdown().Paragraph("Patient Risk Section"))
                .AddFragRef(this.observationSectionFragmentUrl)
                ;
            e.Select("bodySite").Zero();
            return e.SDef.Url;
        }
    }
}
