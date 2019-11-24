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
        String AbUltraSound()
        {
            //$ Fix me. Incorrect method!!!
            SDefEditor e =  this.CreateObservationEditor("BreastRadAbnormalityUltraSound",
                                                         "Breast Radiology Abnormality (UltraSound)")
                .Description(new Markdown().Paragraph("UltraSound Breast Abnormality Observation"))
                .AddFragRef(this.abnormalityFragmentUrl)
                ;
            e.Find("method")
             .FixedCodeSlice("method", "http://snomed.info/sct", "115341008")
             .Card(1, "*")
             ;
            return e.SDef.Url;
        }
    }
}
