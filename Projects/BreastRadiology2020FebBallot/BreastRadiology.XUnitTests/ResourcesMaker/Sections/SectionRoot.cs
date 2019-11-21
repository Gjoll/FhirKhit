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

namespace FhirKhit.BreastRadiology.XUnitTests
{
    public partial class ResourcesMaker : ConverterBase
    {
        String SectionRoot(String patientHistoryUrl, 
            String findingsUrl,
            String patientRiskUrl)
        {
            SDefEditor e = this.CreateObservationEditor("BreastRadSectionRoot",
                                                        "Breast Radiology Root Section")
                .Description(new Markdown().Paragraph("Root Section"))
                .AddFragRef(this.observationSectionFragmentUrl)
                ;
                e.Find("hasMember")
                    .SliceByUrl(new ObservationTarget[]
                        {
                            new ObservationTarget(patientHistoryUrl, 1, "1"),
                           new ObservationTarget(findingsUrl, 1, "1"),
                            new ObservationTarget(patientRiskUrl, 1, "1")
                        });
                e.Find("code").FixedCodeSlice("observationCode", Loinc, "10193-1");
                e.Select("bodySite").Zero();
                return e.SDef.Url;
        }
    }
}
