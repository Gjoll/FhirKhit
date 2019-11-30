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
                    CreateFindingMri();
                return findingMri;
            }
        }
        String findingMri = null;

        void CreateFindingMri()
        {
            //$ Fix me. Incorrect method!!!
            SDefEditor e = this.CreateObservationEditor("BreastRadMRIFinding",
                    "Breast Radiology MRI Finding",
                    new string[] {"MRI", "Finding"},
                    out findingMri)
                .Description(new Markdown().Paragraph("Breast Radiology MRI Finding"))
                .AddFragRef(this.FindingSectionFragment)
            ;
            //$e.Find("method")
            //$     .FixedCodeSlice("method", "http://snomed.info/sct", "115341008")
            //$     .Card(1, "*")
            //$     ;
        }
    }
}
