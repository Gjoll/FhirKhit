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
        String AbMammoMassMargin()
        {
                String binding = this.CreateValueSet(
                    "BreastRadAbnormalityMammoMassMargin",
                    "Breast Radiology Abnormality Mammography Mass Margin",
                    new Markdown()
                        .Paragraph("Breast Radiology Mass Margin (Mammography)"),
                    new String[]
                    {
                            "a. Circumscribed",
                            "b. Obscured",
                            "c. Microlobulated",
                            "d. Indistinct",
                            "e. Spiculated"
                    });

                SDefEditor e = this.CreateObservationEditor("BreastRadAbnormalityMammoMassMargin",
                    "Breast Radiology Abnormality Mass Margin (Mammography)",
                    new string[] {"Mass","Margin"})
                    .Description(new Markdown().Paragraph("Breast Radiology Abnormality Mass Margin Observation (Mammography)"))
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
