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
        String AbnormalityMammographyArchitecturalDistortion()
        {
            String binding = CreateValueSet(
                "BreastRadiologyAbnormalityMammographyArchitecturalDistortionFindings",
                "Breast Radiology Abnormality Architectural Distortion Findings (Mammo)",
                new Markdown()
                    .Paragraph("Breast Radiology Abnormality Architectural Distortion Findings"),
                new String[]
                {
                "a. Present",
                "b. NotPresent",
                "c. NotChecked"
                });

            return this.CreateAbnormalityCodedValue(
                    "BreastRadiologyAbnormalityMammographyArchitecturalDistortion",
                    "Breast Radiology Abnormality Architectural Distortion (Mammography)",
                    new Markdown().Paragraph("Mammography Breast Abnormality Architectural Distortion Observation"),
                    binding)
                .ApplyBreastBodyLocation(this.breastBodyLocation)
                .SDef.Url;
        }
    }
}
