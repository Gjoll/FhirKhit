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
        String AbMammoMassDensity()
        {
            String binding = this.CreateValueSet(
                "BreastRadAbnormalityMammoMassDensity",
                "Breast Radiology Abnormality Mammography Mass Density",
                new Markdown()
                    .Paragraph("Breast Radiology Mass Density (Mammography)"),
                new String[]
                {
                        "a. High density",
                        "b. Equal density",
                        "c. Low density",
                        "d. Fat-containing"
                });

            SDefEditor e = this.CreateObservationEditor("BreastRadAbnormalityMammoMassDensity",
                        "Breast Radiology Abnormality Mass Density (Mammography)",
                        new string[] {"Density"})
                    .Description(new Markdown().Paragraph("Breast Radiology Abnormality Mass Density Observation (Mammography)"))
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
