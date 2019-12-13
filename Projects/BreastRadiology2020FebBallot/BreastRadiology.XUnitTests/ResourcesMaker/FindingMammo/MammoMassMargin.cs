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
        async StringTask MammoMassMargin()
        {
            if (mammoMassMargin == null)
                await CreateMammoMassMargin();
            return mammoMassMargin;
        }
        String mammoMassMargin = null;

        async VTask CreateMammoMassMargin()
        {
            await VTask.Run(async () =>
            {
                ValueSet binding = this.CreateValueSet(
                    "BreastRadMammoMassMargin",
                    "Mammo Mass Margin",
                    new string[] { "Mammo", "Mass", "Margin", "Values" },
                    "Mammography mass margin codes.",
                    Group_MammoCodes,
                    new ConceptDef[]
                    {
                    new ConceptDef("Circumscribed ",
                        "Circumscribed Margin",
                        new Definition()
                        .CiteStart()
                            .Line("(historically, \"well defined\" or \"sharply defined\")")
                            .Line("The margin is sharply demarcated with an abrupt transition between the lesion and the surrounding tissue.")
                            .Line("For mammography, if part of the margin is obscured, at least 75% of the margin must be well")
                            .Line("defined for a mass to qualify as \"circumscribed\". A mass for which any portion of the margin")
                            .Line("is indistinct, microlobulated, or spiculated should be classified on the basis of the latter")
                            .Line("(the most suspicious component).")
                        .CiteEnd(BiRadCitation)
                        ),
                    new ConceptDef("Obscured",
                        "Obscured Margin",
                        new Definition()
                        .CiteStart()
                            .Line("A margin that is hidden by superimposed or adjacent fibroglandular tissue. This is used")
                            .Line("primarily when some of the margin of the mass is circumscribed, but the rest (more than 25%) is hidden.")
                        .CiteEnd(BiRadCitation)
                        ),
                    new ConceptDef("Microlobulated",
                        "Microlobulated Margin",
                        new Definition()
                        .CiteStart()
                            .Line("The margin is characterized by short cycle undulations. For mammography, use of this descriptor")
                            .Line("usually implies a suspicious finding.")
                        .CiteEnd(BiRadCitation)
                        ),
                    new ConceptDef("Indistinct",
                        "Indistinct Margin",
                        new Definition()
                        .CiteStart()
                            .Line("There is no clear demarcation of the entire margin, or of any portion of the margin, from the surrounding")
                            .Line("tissue. For mammography, this descriptor should not be used when the interpreting")
                            .Line("physician believes it is likely due to immediately adjacent breast tissue. Use of this descriptor")
                            .Line("usually implies a suspicious finding.")
                        .CiteEnd(BiRadCitation)
                        ),
                    new ConceptDef("Spiculated",
                        "Spiculated Margin",
                        new Definition()
                        .CiteStart()
                            .Line("The margin is characterized by lines radiating from the mass. Use of this descriptor usually")
                            .Line("implies a suspicious finding.")
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

                SDefEditor e = this.CreateEditor("BreastRadMammoMassMargin",
                    "Mammo Mass Margin",
                    new string[] { "Mammo", "Mass", "Margin" },
                    ObservationUrl,
                    $"{Group_MammoResources}/Mass/Margin",
                    out mammoMassMargin)
                    .Description("Breast Radiology Mammography Mass Margin Observation",
                        new Markdown()
                            .MissingObservation("a mass margin")
                            .BiradHeader()
                            .BlockQuote("The margin is the edge or border of the lesion. The descriptors of margin, like the descriptors of shape, are important predictors of whether a mass is benign or malignant. ")
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
                e.IntroDoc.ReviewedStatus(ReviewStatus.NotReviewed).CodedObservationLeafNode(e, "a mammography mass margin", binding);
            });
        }
    }
}
