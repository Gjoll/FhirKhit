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
        async StringTask USMassMargin()
        {
            if (this.usMassMargin == null)
                await this.CreateUSMassMargin();
            return this.usMassMargin;
        }
        String usMassMargin = null;

        async VTask CreateUSMassMargin()
        {
            await VTask.Run(async () =>
            {
                CodeSystem cs = await this.CreateCodeSystem(
                    "BreastRadUSMassMargin",
                    "US Mass Margin",
                    "US Mass/Margin Values",
                    "Ultra-sound mass margin codes.",
                    Group_USCodes,
                    new ConceptDef[]
                    {
                    new ConceptDef("Angular",
                        "Not Circumscribed - Angular",
                        new Definition()
                        .CiteStart()
                            .Line("Some or all of the margin has sharp corners, often forming acute angles, but the significant")
                            .Line("feature is that the margin of the mass is NOT CIRCUMSCRIBED.")
                        .CiteEnd(BiRadCitation)
                        ),
                    new ConceptDef("Circumscribed ",
                        "Circumscribed Margin",
                        new Definition()
                        .CiteStart()
                            .Line("(historically, “well-defined” or “sharply-defined”)")
                            .Line("A circumscribed margin is one that is well defined, with an abrupt transition between the")
                            .Line("lesion and the surrounding tissue. For US, to describe a mass as circumscribed, its entire margin")
                            .Line("must be sharply defined. Most circumscribed lesions have round or oval shapes.")
                        .CiteEnd(BiRadCitation)
                        ),
                    new ConceptDef("Indistinct",
                        "Indistinct Margin",
                        new Definition()
                        .CiteStart()
                            .Line("There is no clear demarcation of the entire margin or any portion of the margin from the")
                            .Line("surrounding tissue. The boundary is poorly defined, and the significant feature is that the")
                            .Line("mass is NOT CIRCUMSCRIBED. This is meant to include “echogenic rim” (historically, echogenic")
                            .Line("halo) because one may not be able to distinguish between an indistinct margin and")
                            .Line("one that displays an echogenic rim.")
                        .CiteEnd(BiRadCitation)
                        ),
                    new ConceptDef("IntraductalExtension",
                        "Intraductal Extension",
                        new Definition()
                            .Line("Penrad specific.")
                        ),
                    new ConceptDef("Irregular",
                        "Irregular Margin",
                        new Definition()
                            .Line("Penrad specific.")
                        ),
                    new ConceptDef("Lobulated",
                        "Lobulated Margin",
                        new Definition()
                            .Line("Penrad specific.")
                        ),
                    new ConceptDef("Microlobulated",
                        "Not Circumscribed - Microlobulated",
                        new Definition()
                        .CiteStart()
                            .Line("The margin is characterized by short-cycle undulations, but the significant feature is that")
                            .Line("the margin of the mass is NOT CIRCUMSCRIBED.")
                        .CiteEnd(BiRadCitation)
                        ),
                    new ConceptDef("NonCircumscribed",
                        "Non Circumscribed Margin",
                        new Definition()
                        .CiteStart()
                        .CiteEnd(BiRadCitation)
                        ),
                    new ConceptDef("Smooth",
                        "Smooth Margin",
                        new Definition()
                            .Line("Penrad specific.")
                        ),
                    new ConceptDef("Spiculated",
                        "Not Circumscribed - Spiculated",
                        new Definition()
                        .CiteStart()
                            .Line("The margin is characterized by sharp lines radiating from the mass, often a sign of malignancy,")
                            .Line("but the significant feature is that the margin of the mass is NOT CIRCUMSCRIBED.")
                        .CiteEnd(BiRadCitation)
                        )
                    });

                ValueSet binding = await this.CreateValueSet(
                    "BreastRadUSMassMargin",
                    "US Mass Margin",
                    "US Mass/Margin Values",
                    "Ultra-sound mass margin codes.",
                    Group_USCodes,
                    cs);

                {
                    IntroDoc valueSetIntroDoc = new IntroDoc(Path.Combine(this.pageDir, $"ValueSet-{binding.Name}-intro.xml"));
                    valueSetIntroDoc
                        .ReviewedStatus(ReviewStatus.NotReviewed)
                        .ValueSet(binding);
                    ;
                    String outputPath = valueSetIntroDoc.Save();
                    this.fc.Mark(outputPath);
                }

                SDefEditor e = this.CreateEditor("BreastRadUSMassMargin",
                        "US Mass Margin",
                        "US Mass/Margin",
                        ObservationUrl,
                        $"{Group_USResources}/Mass/Margin",
                        out this.usMassMargin)
                    .Description("Breast Radiology Ultra-Sound Mass Margin Observation",
                        new Markdown()
                            .MissingObservation("a mass margin")
                            .BiradHeader()
                            .BlockQuote("The margin is the edge or border of the lesion. The descriptors of margin, like the descriptors of shape, are important predictors of whether a mass is benign or malignant. ")
                            .BiradFooter()
                            .Todo(
                                "Is Irregular incorrect? Note from ACR B.3.A. 'Irregular' is not used to group these marginal attributes because irregular describes the shape of a mass.",
                                "Is non-circumscribed a stand along value, or implied by selection fo on or more non-circumscribed values? "
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
                    .CodedObservationLeafNode(e, "a mammography mass margin", binding)
                    ;
            });
        }
    }
}
