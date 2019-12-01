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
    public partial class ResourcesMaker : ConverterBase
    {
        // TODO: Mass Margin and Ultra Margin treat Not Circumscribed differently. Can they be aligned?

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
            String binding = this.CreateValueSet(
                "BreastRadUSMassMargin",
                "Breast Radiology Ultra-Sound Mass Margin",
                new Markdown()
                    .Paragraph("Breast Radiology Ultra-Sound Mass Margin"),
                    new ConceptDef[]
                    {
                        new ConceptDef("Circumscribed ",
                            "Circumscribed Margin",
                            "(historically, “well-defined” or “sharply-defined”)" +
                            "A circumscribed margin is one that is well defined, with an abrupt transition between the " +
                            "lesion and the surrounding tissue. For US, to describe a mass as circumscribed, its entire margin " +
                            "must be sharply defined. Most circumscribed lesions have round or oval shapes."),
                        new ConceptDef("NotCircumscribed ",
                            "Not Circumscribed",
                            "(historically, “well-defined” or “sharply-defined”)" +
                            "If any portion of the margin is NOT CIRCUMSCRIBED, the mass should be characterized as " +
                            "“not circumscribed.” A mass that is NOT CIRCUMSCRIBED may further be described as having " +
                            "indistinct, angular, microlobulated, spiculated, or any combination of these margin descriptors. " +
                            "“Irregular” is not used to group these marginal attributes because irregular describes the shape")
                        //new ConceptDef("Obscured",
                        //    "Obscured Margin",
                        //    "A margin that is hidden by superimposed or adjacent fibroglandular tissue. This is used " +
                        //    "primarily when some of the margin of the mass is circumscribed, but the rest (more than 25%) is hidden."),
                        //new ConceptDef("Microlobulated",
                        //    "Microlobulated Margin",
                        //    "The margin is characterized by short cycle undulations. For mammography, use of this descriptor " +
                        //    "usually implies a suspicious finding."),
                        //new ConceptDef("Indistinct",
                        //    "Indistinct Margin",
                        //    "There is no clear demarcation of the entire margin, or of any portion of the margin, from the surrounding " +
                        //    "tissue. For mammography, this descriptor should not be used when the interpreting " +
                        //    "physician believes it is likely due to immediately adjacent breast tissue. Use of this descriptor " +
                        //    "usually implies a suspicious finding."),
                        //new ConceptDef("Spiculated",
                        //    "Spiculated Margin",
                        //    "The margin is characterized by lines radiating from the mass. Use of this descriptor usually " +
                        //    "implies a suspicious finding.")
                    })
                .Url;

            String binding2 = this.CreateValueSet(
                "BreastRadUSMassMarginNotCircumscribed",
                "Breast Radiology Ultra-Sound Mass Margin Not Circumscribed values",
                new Markdown()
                    .Paragraph("Breast Radiology Ultra-Sound Mass Margin Not Circumscribed Values"),
                    new ConceptDef[]
                    {
                        new ConceptDef("Indistinct",
                            "Not Circumscribed - Indistinct",
                            "There is no clear demarcation of the entire margin or any portion of the margin from the " +
                            "surrounding tissue. The boundary is poorly defined, and the significant feature is that the " +
                            "mass is NOT CIRCUMSCRIBED. This is meant to include “echogenic rim” (historically, echogenic " +
                            "halo) because one may not be able to distinguish between an indistinct margin and " +
                            "one that displays an echogenic rim."),
                        new ConceptDef("Angular",
                            "Not Circumscribed - Angular",
                            "Some or all of the margin has sharp corners, often forming acute angles, but the significant " +
                            "feature is that the margin of the mass is NOT CIRCUMSCRIBED."),
                        new ConceptDef("Microlobulated",
                            "Not Circumscribed - Microlobulated",
                            "The margin is characterized by short-cycle undulations, but the significant feature is that " +
                            "the margin of the mass is NOT CIRCUMSCRIBED."),
                        new ConceptDef("Spiculated",
                            "Not Circumscribed - Spiculated",
                            "The margin is characterized by sharp lines radiating from the mass, often a sign of malignancy, " +
                            "but the significant feature is that the margin of the mass is NOT CIRCUMSCRIBED.")
                    })
                .Url;

            SDefEditor e = this.CreateObservationEditor("BreastRadUSMassMargin",
                "Breast Radiology Ultra-Sound Mass Margin",
                new string[] { "Margin" },
                out usMassMargin)
                .Description(new Markdown()
                    .Paragraph("Breast Radiology Ultra-Sound Mass Margin Observation")
                    .MissingObservation("a mass margin")
                    .BiradHeader()
                    .MarkedDown("The margin is the edge or border of the lesion. The descriptors of margin, like the descriptors of shape, are important predictors of whether a mass is benign or malignant. ")
                    .BiradFooter()
                    )
                .AddFragRef(this.ObservationCodedValueFragment)
                ;
            {
                CodeableConcept pattern1 = new CodeableConcept();
                pattern1.Coding.Add(new Coding(binding, null));

                CodeableConcept pattern2 = new CodeableConcept();
                pattern2.Coding.Add(new Coding(binding2, null));

                PatternSlice[] patternSlices = new PatternSlice[]
                {
                    new PatternSlice("Margin",
                        "US Mass Margin Value",
                        new Markdown()
                            .Paragraph("Specifies Circumscribed or Not-Circumscribed"),
                        pattern1,
                        1,
                        "1"),
                    new PatternSlice("MarginNotCircumscribedOptions",
                        "US Mass Margin optional Not-Circumscribed specifier value",
                        new Markdown()
                            .Paragraph("Optional Not-Circumscribed values"),
                        pattern2,
                        0,
                        "*")
                };
                e.Find("value[x]")
                    .SliceByPatterns("CodeableConcept", patternSlices)
                    ;
            }
        }
    }
}
