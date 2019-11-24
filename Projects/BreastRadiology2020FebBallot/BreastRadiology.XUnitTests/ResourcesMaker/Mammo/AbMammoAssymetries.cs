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
        String AbMammoAssymetries()
        {
            String binding = this.CreateValueSet(
                "Assymetries",
                "Assymetries",
                new Markdown()
                    .Paragraph("Breast Radiology Mammography Assymetries"),
                new String[]
                {
                    "a. Diffuse",
                    "b. Regional",
                    "c. Grouped",
                    "d. Linear",
                    "e. Segmental"
                });

            SDefEditor e = this.CreateObservationEditor("BreastRadAbnormalityMammoAssymetries",
                                                        "Breast Radiology Abnormality Assymetries (Mammography)")
                    .Description(new Markdown().Paragraph("Mammography Breast Abnormality Assymetries Observation"))
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
