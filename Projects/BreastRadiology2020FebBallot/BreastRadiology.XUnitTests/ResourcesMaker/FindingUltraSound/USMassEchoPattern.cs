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
using PreFhir;

namespace BreastRadiology.XUnitTests
{
    partial class ResourcesMaker : ConverterBase
    {
        String USMassEchoPattern
        {
            get
            {
                if (usMassEchoPattern == null)
                    CreateUSMassEchoPattern();
                return usMassEchoPattern;
            }
        }
        String usMassEchoPattern = null;

        void CreateUSMassEchoPattern()
        {
            String binding = this.CreateValueSet(
                "BreastRadUSMassEchoPattern",
                "Breast Radiology Ultra-Sound Mass Echo Pattern",
                new Markdown()
                    .Paragraph("Breast Radiology Ultra-Sound Mass Echo Pattern"),
                    new ConceptDef[]
                    {
                        new ConceptDef("Anechoic",
                            "Anechoic",
                            "Without internal echoes."),
                        new ConceptDef("Hyperechoic",
                            "Hyperechoic",
                            "Hyperechogenicity is defined as having increased echogenicity relative to fat or equal to fibroglandular tissue."),
                        new ConceptDef("ComplexCysticAndSolid",
                            "Complex Cystic and Solid",
                            "A complex mass contains both anechoic (cystic or fluid) and echogenic (solid) components."),
                        new ConceptDef("Hypoechoic",
                            "Hypoechoic",
                            "The term “hypoechoic” is defined relative to subcutaneous fat; hypoechoic masses, less " +
                            "echogenic than fat, are characterized by low-level echoes throughout (for example, " +
                            "complicated cysts and fibroadenomas)"),
                        new ConceptDef("Isoechoic",
                            "Isoechoic",
                            "Isoechogenicity is defined as having the same echogenicity as subcutaneous fat. Isoechoic " +
                            "masses may be relatively inconspicuous, particularly when they are situated within an area of " +
                            "fat lobules. This may limit the sensitivity of US, especially at screening, in which the presence " +
                            "and location of such a mass is not known at the time of examination."),

                        new ConceptDef("Heterogeneous",
                            "Heterogeneous",
                            "A mixture of echogenic patterns within a solid mass. Heterogeneity has little prognostic " +
                            "value in differentiating benign from malignant masses, but it is not uncommon to observe " +
                            "heterogeneity in fibroadenomas as well as cancers. Clumped areas of different echogenicity " +
                            "may elevate the suspicion for malignancy, particularly in a mass whose margins are not " +
                            "circumscribed and whose shape is irregular.")
                    })
                .Url;

            SDefEditor e = this.CreateEditor("BreastRadUSMassEchoPattern",
                        "Breast Radiology Ultra-Sound Mass Echo Pattern",
                        new string[] { "UltraSound", "Mass", "Echo Pattern" },
                        ObservationUrl,
                        out usMassEchoPattern)
                    .Description(new Markdown()
                        .Paragraph("Breast Radiology Ultra-Sound Mass Echo Pattern Observation")
                        .BiradHeader()
                        .BiRadLine("The echogenicity of most benign and malignant masses is hypoechoic compared with ")
                        .BiRadLine("mammary fat. While many completely echogenic masses are benign, prospective assessment as")
                        .BiRadLine("benign has greater dependency on marginal circumscription. Although the echo pattern")
                        .BiRadLine("contributes with other feature categories to the assessment of a breast lesion, echogenicity")
                        .BiRadLine("alone has little specificity.")
                        .BiradFooter()
                        )
                    .AddFragRef(this.ObservationCodedValueFragment)
                .AddFragRef(this.ObservationLeafFragment)
                    ;

            e.Select("value[x]")
                .Type("CodeableConcept")
                .Binding(binding, BindingStrength.Required)
                ;
        }
    }
}
