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
        String FindingMri
        {
            get
            {
                if (findingMri== null)
                    findingMri = CreateFindingMri();
                return findingMri;
            }
        }
        String findingMri = null;

        String CreateFindingMri()
        {
            //$ Fix me. Incorrect method!!!
            SDefEditor e = this.CreateObservationEditor("BreastRadAbnormalityMRI",
                    "Breast Radiology Abnormality (MRI)",
                    new string[] {"MRI","Abnormality"})
                .Description(new Markdown().Paragraph("MRI Breast Abnormality Observation"))
                .AddFragRef(this.FindingSectionFragment)
            ;
            e.Find("method")
                 .FixedCodeSlice("method", "http://snomed.info/sct", "115341008")
                 .Card(1, "*")
                 ;

            return e.SDef.Url;
        }
    }
}
