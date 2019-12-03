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
        String USMassPosteriorAcousticFeatures
        {
            get
            {
                if (usMassPosteriorAcousticFeatures == null)
                    CreateUSMassPosteriorAcousticFeatures();
                return usMassPosteriorAcousticFeatures;
            }
        }
        String usMassPosteriorAcousticFeatures = null;

        void CreateUSMassPosteriorAcousticFeatures()
        {
            String binding = this.CreateValueSet(
                "BreastRadUSMassPosteriorAcousticFeatures",
                "Breast Radiology Ultra-Sound Mass Posterior Acoustic Features",
                new Markdown()
                    .Paragraph("Breast Radiology Ultra-Sound Mass Posterior Acoustic Features"),
                    new ConceptDef[]
                    {
                        new ConceptDef("NoPosteriorAcousticFeatures",
                            "No Posterior Acoustic Features",
                            "No shadowing or enhancement is present deep to the mass; the echogenicity of the area " +
                            "immediately behind the mass is not different from that of adjacent tissue at the same depth."),
                        new ConceptDef("Enhancement",
                            "Enhancement",
                            "Sound transmission is unimpeded in its passage through the mass. Enhancement appears as " +
                            "a column that is more echogenic (whiter) deep to the mass. One criterion for cyst diagnosis " +
                            "is enhancement. Homogeneous solid lesions, including high-grade carcinomas, may also show enhancement."),
                        new ConceptDef("Shadowing",
                            "Shadowing",
                            "Shadowing is attenuation of the acoustic transmission. Sonographically, the area posterior to " +
                            "the mass appears darker. At the edges of curved masses, acoustic velocity changes and thin " +
                            "shadows are seen. This refractive edge shadowing is of no significance and should be distinguished " +
                            "from central shadowing, which is a property of the mass." +
                            "" +
                            "Shadowing is associated with fibrosis, with or without an underlying carcinoma. Postsurgical " +
                            "scars, fibrous mastopathy and many cancers with or without a desmoplastic response will show " +
                            "posterior acoustic shadowing. Macrocalcifications can also attenuate sound. Similar to a vertical " +
                            "(taller-than-wide) orientation, shadowing is a feature more helpful when present than when " +
                            "absent. Many cancers will exhibit enhancement or no change in posterior features, particularly " +
                            "those that are high grade."),
                        new ConceptDef("CombinedPattern",
                            "Combined Pattern",
                            "Some lesions have more than one pattern of posterior attenuation. For example, a fibroadenoma " +
                            "containing a large calcification may demonstrate shadowing posterior to the calcified " +
                            "area but enhancement of the tissues deep to the uncalcified portion. A combined pattern " +
                            "of posterior features also may be seen in lesions that are evolving. One such example is a " +
                            "post-lumpectomy seroma, which enhances posteriorly. As the fluid is resorbed and scarring " +
                            "develops, the features of fibrosis become evident as spiculation of the margins and posterior " +
                            "acoustic shadowing.")
                    })
                .Url;

            SDefEditor e = this.CreateEditor("BreastRadUSMassPosteriorAcousticFeatures",
                        "Breast Radiology Ultra-Sound Mass Posterior Acoustic Features",
                        new string[] { "UltraSound", "Mass", "Posterior Acoustic Features" },
                        ObservationUrl,
                        out usMassPosteriorAcousticFeatures)
                    .Description(new Markdown()
                        .Paragraph("Breast Radiology Ultra-Sound Mass Posterior Acoustic Features Observation")
                        .BiradHeader()
                        .BlockQuote("Posterior acoustic features represent the attenuation characteristics of a mass with respect to its")
                        .BlockQuote("acoustic transmission. Attenuation (shadowing) and enhancement are additional attributes of")
                        .BlockQuote("masses, mostly of secondary rather than primary predictive value..")
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