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
        String USTissueComposition
        {
            get
            {
                if (usTissueComposition == null)
                    CreateUSTissueComposition();
                return usTissueComposition;
            }
        }
        String usTissueComposition = null;

        void CreateUSTissueComposition()
        {
            String binding = this.CreateValueSet(
                "BreastRadUSTissueComposition",
                "Breast Radiology Ultra-Sound Tissue Composition Observation",
                new Markdown()
                    .Paragraph("Breast Radiology Ultra-Sound Tissue Composition Observation")
                    .BiradHeader()
                    .MarkedDown("The wide normal variability in tissue composition seen on mammograms can also be observed")
                    .MarkedDown("on US images. Just as increasing breast density diminishes the sensitivity of mammography in the")
                    .MarkedDown("detection of small masses, heterogeneous background echotexture of the breast may affect the")
                    .MarkedDown("sensitivity of breast sonograms for lesion detection.")
                    .BiradFooter(),
                new ConceptDef[]
                {
                    new ConceptDef("Fat",
                        "Homogenous Background Echotexture - Fat",
                        "Fat lobules and uniformly echogenic bands of supporting structures " +
                        "(Cooper’s ligaments [arrows]) comprise the bulk of breast tissue."
                    ),
                    new ConceptDef("Fibroglandular",
                        "Homogenous Background Echotexture - Fibroglandular",
                        "A thick zone of homogeneously echogenic fibroglandular parenchyma is present beneath the " +
                        "thin hypoechoic layer of fat lobules. Many lesions, cancers and fibroadenomas, for example, are " +
                        "found within the fibroglandular zone or at its junction with the layer of fat."
                    ),
                    new ConceptDef("Heterogeneous",
                        "Heterogeneous Background Echo Texture",
                        "Heterogeneity can be either focal or diffuse. The breast echotexture is characterized by multiple " +
                        "small areas of increased and decreased echogenicity. Shadowing may occur at the interfaces of fat " +
                        "lobules and parenchyma. This pattern occurs in younger breasts and those with heterogeneously " +
                        "dense parenchyma depicted mammographically. Whether and how this pattern affects the sensitivity " +
                        "of sonography merits study, but technical maneuvers may help resolve interpretive dilemmas " +
                        "that occasionally result in unnecessary biopsy."
                    )
                }
            )
            .Url;

            SDefEditor e = this.CreateEditor("BreastRadUSTissueComposition",
                        "Breast Radiology Ultra-Sound Tissue Composition Observation",
                        new string[] {"Tissue","Composition"},
                        ObservationUrl,
                        out usTissueComposition)
                    .Description(new Markdown()
                        .Paragraph("Breast Radiology Ultra-Sound Tissue Composition Observation")
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
