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
        String MammoMassDensity
        {
            get
            {
                if (mammoMassDensity == null)
                    mammoMassDensity = CreateMammoMassDensity();
                return mammoMassDensity;
            }
        }
        String mammoMassDensity = null;

        String CreateMammoMassDensity()
        {
            String binding = this.CreateValueSet(
                "BreastRadMammoMassDensity",
                "Breast Radiology Mammography Mass Density",
                new Markdown()
                    .Paragraph("Breast Mammography Radiology Mass Density"),
                    new ConceptDef[]
                    {
                        new ConceptDef("HighDensity ",
                            "High Density",
                            "X-ray attenuation of the mass is greater than the expected attenuation of an equal volume of " +
                            "fibroglandular breast tissue."),
                        new ConceptDef("EqualDensity",
                            "Equal Density",
                            "(historically, \"isodense\") " +
                            "X-ray attenuation of the mass is the same as the expected attenuation of an equal volume of " +
                            "fibroglandular breast tissue."),
                        new ConceptDef("LowDensity",
                            "Low Density",
                            "X-ray attenuation of the mass is less than the expected attenuation of an equal volume of " +
                            "fibroglandular breast tissue. A low density mass may be a group of microcysts. If such a finding " +
                            "is identified at mammography, it may very well not be malignant but appropriately may " +
                            "be worked up."),
                        new ConceptDef("FatContaining",
                            "Fat Containing",
                            "This includes all masses containing fat, such as oil cyst, lipoma or galactocele, as well as mixed "+
                            "density masses such as hamartoma. A fat-containing mass will almost always represent a " +
                            "benign mass.")
                    })
                .Url;

            SDefEditor e = this.CreateObservationEditor("BreastRadMammoMassDensity",
                        "Breast Radiology Mammography Mass Density",
                        new string[] { "Density" })
                    .Description(new Markdown()
                        .Paragraph("Breast Radiology Mammography Mass Density Observation")
                        .MissingObservation("a mass density")
                        .BiradHeader()
                        .MarkedDown("Radiographic density is considered an important feature in the evaluation of noncalcified breast masses, yet")
                        .MarkedDown("no studies assessing its value have been published. The radiographic densities of 91 biopsy-proved, nonfatty,")
                        .MarkedDown("noncalcified breast masses were evaluated by three mammographers. The density determinations made by")
                        .MarkedDown("each observer were compared with the histologic outcome for the 51 benign and 40 malignant lesions. With")
                        .MarkedDown("the kappa statistic, interobserver agreement was relatively poor (0.22 to 0.49), and intraobserver agreement for")
                        .MarkedDown("one expert mammographer was 0.50. When the majority opinion of the mammographers was used, sensitivity")
                        .MarkedDown("was 48%, specificity was 80%, and both positive and negative predictive values were 66%. As a solitary feature")
                        .MarkedDown("in lesion analysis, mammographic density is difficult to assess and is of limited value for the prediction of the")
                        .MarkedDown("benign or malignant nature of noncalcified breast masses.")
                        .BiradFooter()
                        )
                    .AddFragRef(this.ObservationCodedValueFragment)
                    ;

            e.Select("value[x]")
                .Type("CodeableConcept")
                .Binding(binding, BindingStrength.Required)
                ;
            return e.SDef.Url;
        }
    }
}
