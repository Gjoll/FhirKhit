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
        String AbMassShape()
        {
            String binding = this.CreateValueSet(
                "BreastRadAbnormalityMassShape",
                "Breast Radiology Abnormality Mass Shape",
                new Markdown()
                    .Paragraph("Breast Radiology Mass Shape"),
                new String[]
                {
                "a. Oval",
                "b. Round",
                "c. Irregular"
                });

            SDefEditor e = this.CreateObservationEditor("BreastRadAbnormalityMassShape",
                "Breast Radiology Abnormality Mass Shape",
                new string[] {"Shape"})
                .Description(new Markdown().Paragraph("Breast Radiology Abnormality Mass Shape Observation"))
                    ;

            e.Select("value[x]")
                .Type("CodeableConcept")
                .Binding(binding, BindingStrength.Required)
                ;
            return e.SDef.Url;
        }
    }
}
