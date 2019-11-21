﻿using System;
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
        String AbUltraSound()
        {
            //$ Fix me. Incorrect method!!!
            return this.CreateAbnormality(
                "BreastRadAbnormalityUltraSound",
                "Breast Radiology Abnormality (UltraSound)",
                new Markdown().Paragraph("UltraSound Breast Abnormality Observation"),
                "http://snomed.info/sct",
                "115341008")
                .SDef.Url;
        }
    }
}