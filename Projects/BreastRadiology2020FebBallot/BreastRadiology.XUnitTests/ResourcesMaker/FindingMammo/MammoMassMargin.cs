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
        String MammoMassMargin
        {
            get
            {
                if (mammoMassMargin == null)
                    CreateMammoMassMargin();
                return mammoMassMargin;
            }
        }
        String mammoMassMargin = null;

        void CreateMammoMassMargin()
        {
            String binding = this.CreateValueSet(
                "BreastRadMammoMassMargin",
                "Breast Radiology Mammography Mass Margin",
                new Markdown()
                    .Paragraph("Breast Radiology Mammography Mass Margin"),
                    new ConceptDef[]
                    {
                        new ConceptDef("Circumscribed ",
                            "Circumscribed Margin",
                            "(historically, \"well defined\" or \"sharply defined\") " +
                            "The margin is sharply demarcated with an abrupt transition between the lesion and the surrounding tissue. "+
                            "For mammography, if part of the margin is obscured, at least 75% of the margin must be well " +
                            "defined for a mass to qualify as \"circumscribed\". A mass for which any portion of the margin " +
                            "is indistinct, microlobulated, or spiculated should be classified on the basis of the latter " +
                            "(the most suspicious component)."),
                        new ConceptDef("Obscured",
                            "Obscured Margin",
                            "A margin that is hidden by superimposed or adjacent fibroglandular tissue. This is used " +
                            "primarily when some of the margin of the mass is circumscribed, but the rest (more than 25%) is hidden."),
                        new ConceptDef("Microlobulated",
                            "Microlobulated Margin",
                            "The margin is characterized by short cycle undulations. For mammography, use of this descriptor " +
                            "usually implies a suspicious finding."),
                        new ConceptDef("Indistinct",
                            "Indistinct Margin",
                            "There is no clear demarcation of the entire margin, or of any portion of the margin, from the surrounding " +
                            "tissue. For mammography, this descriptor should not be used when the interpreting " +
                            "physician believes it is likely due to immediately adjacent breast tissue. Use of this descriptor " +
                            "usually implies a suspicious finding."),
                        new ConceptDef("Spiculated",
                            "Spiculated Margin",
                            "The margin is characterized by lines radiating from the mass. Use of this descriptor usually " +
                            "implies a suspicious finding.")
                    })
                .Url;

            SDefEditor e = this.CreateEditor("BreastRadMammoMassMargin",
                "Breast Radiology Mammography Mass Margin",
                new string[] { "Margin" },
                ObservationUrl,
                out mammoMassMargin)
                .Description(new Markdown()
                    .Paragraph("Breast Radiology Mammography Mass Margin Observation")
                    .MissingObservation("a mass margin")
                    .BiradHeader()
                    .MarkedDown("The margin is the edge or border of the lesion. The descriptors of margin, like the descriptors of shape, are important predictors of whether a mass is benign or malignant. ")
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
