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
using VTask = System.Threading.Tasks.Task;
using StringTask = System.Threading.Tasks.Task<string>;

namespace BreastRadiology.XUnitTests
{
    partial class ResourcesMaker : ConverterBase
    {
        async StringTask USMassEchoPattern()
        {
            if (this.usMassEchoPattern == null)
                await this.CreateUSMassEchoPattern();
            return this.usMassEchoPattern;
        }
        String usMassEchoPattern = null;

        async VTask CreateUSMassEchoPattern()
        {
            await VTask.Run(async () =>
            {
                ValueSet binding = this.CreateValueSet(
                    "BreastRadUSMassEchoPattern",
                    "US Mass Echo Pattern",
                    "US Mass/Echo Pattern/Values",
                    "Ultra-sound mass echo pattern codes.",
                    Group_USCodes,
                    new ConceptDef[]
                    {
                    new ConceptDef("Anechoic",
                        "Anechoic",
                        new Definition()
                        .CiteStart()
                            .Line("Without internal echoes.")
                        .CiteEnd(BiRadCitation)
                        ),
                    new ConceptDef("ComplexCysticAndSolid",
                        "Complex Cystic and Solid",
                        new Definition()
                        .CiteStart()
                            .Line("A complex mass contains both anechoic (cystic or fluid) and echogenic (solid) components.")
                        .CiteEnd(BiRadCitation)
                        ),
                     new ConceptDef("Heterogeneous",
                        "Heterogeneous",
                        new Definition()
                        .CiteStart()
                            .Line("A mixture of echogenic patterns within a solid mass. Heterogeneity has little prognostic")
                            .Line("value in differentiating benign from malignant masses, but it is not uncommon to observe")
                            .Line("heterogeneity in fibroadenomas as well as cancers. Clumped areas of different echogenicity")
                            .Line("may elevate the suspicion for malignancy, particularly in a mass whose margins are not")
                            .Line("circumscribed and whose shape is irregular.")
                        .CiteEnd(BiRadCitation)
                        ),
                   new ConceptDef("Hyperechoic",
                        "Hyperechoic",
                        new Definition()
                        .CiteStart()
                            .Line("Hyperechogenicity is defined as having increased echogenicity relative to fat or equal to fibroglandular tissue.")
                        .CiteEnd(BiRadCitation)
                        ),
                    new ConceptDef("Hypoechoic",
                        "Hypoechoic",
                        new Definition()
                        .CiteStart()
                            .Line("The term “hypoechoic” is defined relative to subcutaneous fat; hypoechoic masses, less")
                            .Line("echogenic than fat, are characterized by low-level echoes throughout (for example,")
                            .Line("complicated cysts and fibroadenomas)")
                        .CiteEnd(BiRadCitation)
                        ),
                    new ConceptDef("Isoechoic",
                        "Isoechoic",
                        new Definition()
                        .CiteStart()
                            .Line("Isoechogenicity is defined as having the same echogenicity as subcutaneous fat. Isoechoic")
                            .Line("masses may be relatively inconspicuous, particularly when they are situated within an area of")
                            .Line("fat lobules. This may limit the sensitivity of US, especially at screening, in which the presence")
                            .Line("and location of such a mass is not known at the time of examination.")
                        .CiteEnd(BiRadCitation)
                        )
                    });


                {
                    IntroDoc valueSetIntroDoc = new IntroDoc(Path.Combine(this.pageDir, $"ValueSet-{binding.Name}-intro.xml"));
                    valueSetIntroDoc
                        .ReviewedStatus(ReviewStatus.NotReviewed)
                        .ValueSet(binding);
                    ;
                    String outputPath = valueSetIntroDoc.Save();
                    this.fc.Mark(outputPath);
                }

                SDefEditor e = this.CreateEditor("BreastRadUSMassEchoPattern",
                        "US Mass Echo Pattern",
                        "US Mass/Echo Pattern",
                        ObservationUrl,
                        $"{Group_USResources}/Mass/EchoPattern",
                        out this.usMassEchoPattern)
                    .Description("Breast Radiology Ultra-Sound Mass Echo Pattern Observation",
                        new Markdown()
                            .BiradHeader()
                            .BlockQuote("The echogenicity of most benign and malignant masses is hypoechoic compared with ")
                            .BlockQuote("mammary fat. While many completely echogenic masses are benign, prospective assessment as")
                            .BlockQuote("benign has greater dependency on marginal circumscription. Although the echo pattern")
                            .BlockQuote("contributes with other feature categories to the assessment of a breast lesion, echogenicity")
                            .BlockQuote("alone has little specificity.")
                            .BiradFooter()
                            .Todo(
                            )
                        )
                    .AddFragRef(await this.ObservationNoDeviceFragment())
                    .AddFragRef(await this.ObservationCodedValueFragment())
                    .AddFragRef(await this.ObservationLeafFragment())
                    ;

                e.Select("value[x]")
                    .Type("CodeableConcept")
                    .Binding(binding.Url, BindingStrength.Required)
                    ;
                e.AddValueSetLink(binding);
                e.IntroDoc
                    .ReviewedStatus(ReviewStatus.NotReviewed)
                    .CodedObservationLeafNode(e, "an ultra-sound mass echo pattern", binding)
                    ;
            });
        }
    }
}
