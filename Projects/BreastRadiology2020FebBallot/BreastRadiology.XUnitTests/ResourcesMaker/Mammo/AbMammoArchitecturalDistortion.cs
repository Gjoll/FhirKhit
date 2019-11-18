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
        String AbMammoArchitecturalDistortion()
        {
            String binding = this.CreateValueSet(
                "BreastRadAbnormalityMammoArchitecturalDistortionFindings",
                "Breast Radiology Abnormality Architectural Distortion Findings (Mammo)",
                new Markdown()
                    .Paragraph("Breast Radiology Abnormality Architectural Distortion Findings"),
                new String[]
                {
                "a. Present",
                "b. NotPresent",
                "c. NotChecked"
                });

            SDefEditor e = this.CreateObservationEditor("BreastRadAbnormalityMammoArchitecturalDistortion",
                    "Breast Radiology Abnormality Architectural Distortion (Mammography)")
                    .Description(new Markdown().Paragraph("Mammography Breast Abnormality Architectural Distortion Observation"))
                    .AddFragRef(this.abnormalityCodedValueObservationFragmentUrl)
                    ;

            e.Select("value[x]")
                .Type("CodeableConcept")
                .Binding(binding, BindingStrength.Required)
                ;
            return e.SDef.Url;
        }
    }
}
