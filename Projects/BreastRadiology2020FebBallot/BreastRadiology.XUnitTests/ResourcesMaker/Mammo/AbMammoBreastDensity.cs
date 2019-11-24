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

namespace BreastRadiology.XUnitTests
{
    public partial class ResourcesMaker : ConverterBase
    {
        String AbMammoBreastDensity()
        {
            String binding = this.CreateValueSet(
                "BreastRadBreastDensity",
                "Breast Radiology Breast Density",
                new Markdown()
                    .Paragraph("Breast Radiology Mammography Breast Composition"),
                new String[]
                {
                        "Not Checked",
                        "a. The breasts are almost entirely fatty",
                        "b. There are scattered areas of fibroglandular density",
                        "c. The breasts are heterogeneously dense, which may obscure detection of small masses",
                        "d. The breasts are extremely dense, which lowers the sensitivity of mammography"
                });

            SDefEditor e = this.CreateObservationEditor("BreastRadAbnormalityMammoBreastDensity",
                        "Breast Radiology Abnormality Breast Density (Mammography)",
                        new string[] {"Breast","Density"})
                    .Description(new Markdown().Paragraph("Mammography Breast Abnormality Breast Density Observation"))
                    .AddFragRef(this.abnormalityCodedValueObservationFragmentUrl)
                    ;

            e.Select("value[x]")
                .Type("CodeableConcept")
                .Binding(binding, BindingStrength.Required)
                ;
                return e.SDef.Url;        }
    }
}
