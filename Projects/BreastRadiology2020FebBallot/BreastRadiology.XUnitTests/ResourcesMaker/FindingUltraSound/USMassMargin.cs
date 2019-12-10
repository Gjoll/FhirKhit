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
        String USMassMargin
        {
            get
            {
                if (usMassMargin == null)
                    CreateUSMassMargin();
                return usMassMargin;
            }
        }
        String usMassMargin = null;

        void CreateUSMassMargin()
        {
            ValueSet binding = this.CreateValueSet(
                "BreastRadUSMassMargin",
                "US Mass Margin",
                "Ultra-sound mass margin codes.",
                Group_USCodes,
                new ConceptDef[]
                {
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
                    new ConceptDef("NotCircumscribed ",
                        "Not Circumscribed",
                        new Definition()
                        .CiteStart()
                            .Line("(historically, “well-defined” or “sharply-defined”)")
                            .Line("If any portion of the margin is NOT CIRCUMSCRIBED, the mass should be characterized as")
                            .Line("“not circumscribed.” A mass that is NOT CIRCUMSCRIBED may further be described as having")
                            .Line("indistinct, angular, microlobulated, spiculated, or any combination of these margin descriptors.")
                            .Line("“Irregular” is not used to group these marginal attributes because irregular describes the shape")
                        .CiteEnd(BiRadCitation)
                        )
                });

            String binding2 = this.CreateValueSet(
                "BreastRadUSMassMarginNotCircumscribed",
                "US Mass Margin Not Circumscribed values",
                "Ultra-sound mass margin 'Not Circumscribed' codes.",
                Group_USCodes,
                new ConceptDef[]
                {
                    new ConceptDef("Indistinct",
                        "Not Circumscribed - Indistinct",
                        new Definition()
                        .CiteStart()
                            .Line("There is no clear demarcation of the entire margin or any portion of the margin from the")
                            .Line("surrounding tissue. The boundary is poorly defined, and the significant feature is that the")
                            .Line("mass is NOT CIRCUMSCRIBED. This is meant to include “echogenic rim” (historically, echogenic")
                            .Line("halo) because one may not be able to distinguish between an indistinct margin and")
                            .Line("one that displays an echogenic rim.")
                        .CiteEnd(BiRadCitation)
                        ),
                    new ConceptDef("Angular",
                        "Not Circumscribed - Angular",
                        new Definition()
                        .CiteStart()
                            .Line("Some or all of the margin has sharp corners, often forming acute angles, but the significant")
                            .Line("feature is that the margin of the mass is NOT CIRCUMSCRIBED.")
                        .CiteEnd(BiRadCitation)
                        ),
                    new ConceptDef("Microlobulated",
                        "Not Circumscribed - Microlobulated",
                        new Definition()
                        .CiteStart()
                            .Line("The margin is characterized by short-cycle undulations, but the significant feature is that")
                            .Line("the margin of the mass is NOT CIRCUMSCRIBED.")
                        .CiteEnd(BiRadCitation)
                        ),
                    new ConceptDef("Spiculated",
                        "Not Circumscribed - Spiculated",
                        new Definition()
                        .CiteStart()
                            .Line("The margin is characterized by sharp lines radiating from the mass, often a sign of malignancy,")
                            .Line("but the significant feature is that the margin of the mass is NOT CIRCUMSCRIBED.")
                        .CiteEnd(BiRadCitation)
                        )
                })
            .Url;

            SDefEditor e = this.CreateEditor("BreastRadUSMassMargin",
                    "US Mass Margin",
                    new string[] { "Margin" },
                    ObservationUrl,
                    $"{Group_USResources}/Mass/Margin",
                    out usMassMargin)
                .Description("Breast Radiology Ultra-Sound Mass Margin Observation",
                    new Markdown()
                        .MissingObservation("a mass margin")
                        .BiradHeader()
                        .BlockQuote("The margin is the edge or border of the lesion. The descriptors of margin, like the descriptors of shape, are important predictors of whether a mass is benign or malignant. ")
                        .BiradFooter()
                        .Todo(
                        )
                )
                .AddFragRef(this.ObservationNoDeviceFragment)
                .AddFragRef(this.ObservationCodedValueFragment)
                .AddFragRef(this.ObservationLeafFragment)
                ;
            {
                CodeableConcept pattern1 = new CodeableConcept();
                pattern1.Coding.Add(new Coding(binding.Url, null));

                CodeableConcept pattern2 = new CodeableConcept();
                pattern2.Coding.Add(new Coding(binding2, null));

                PatternSlice[] patternSlices = new PatternSlice[]
                {
                    new PatternSlice("Margin",
                        "US Mass Margin Value",
                        new Markdown()
                            .Paragraph("Specifies Circumscribed or Not-Circumscribed."),
                        pattern1,
                        1,
                        "1"),
                    new PatternSlice("MarginNotCircumscribedOptions",
                        "US Mass Margin optional Not-Circumscribed specifier value",
                        new Markdown()
                            .Paragraph("Optional Not-Circumscribed values."),
                        pattern2,
                        0,
                        "*")
                };
                e.Find("value[x]")
                    .SliceByPatterns("CodeableConcept", patternSlices)
                    ;
            e.IntroDoc.ReviewedStatus(ReviewStatus.NotReviewed).CodedObservationLeafNode(e, "a mass margin", binding);
            }
        }
    }
}
