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
            return this.CreateAbnormalityBooleanValue(
                "BreastRadiologyAbnormalityMammographyArchitecturalDistortion",
                "Breast Radiology Abnormality Architectural Distortion (Mammography)",
                new Markdown().Paragraph("Mammography Breast Abnormality Architectural Distortion Observation")
                )
                .ApplyBreastBodyLocation(this.breastBodyLocation)
                .SDef.Url;
        }
    }
}
