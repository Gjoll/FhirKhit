﻿using System;
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
    // TODO: Do we need statement that breast density is required now?
    public partial class ResourcesMaker : ConverterBase
    {
        String MammoBreastDensity
        {
            get
            {
                if (mammoBreastDensity == null)
                    CreateMammoBreastDensity();
                return mammoBreastDensity;
            }
        }
        String mammoBreastDensity = null;

        void CreateMammoBreastDensity()
        {
            String binding = this.CreateValueSet(
                "BreastRadMammoBreastDensity",
                "Breast Radiology Mammography Breast Density Observation",
                new Markdown()
                    .Paragraph("Breast Radiology Mammography Breast Density/Composition Observation"),
                    new ConceptDef[]
                    {
                        new ConceptDef("Fatty",
                            "The breasts are almost entirely fatty",
                            "Unless an area containing cancer is not included in the image field of the mammogram, " +
                            "mammography is highly sensitive in this setting."
                        ),
                        new ConceptDef("Fibroglandular",
                            "Scattered areas of fibroglandular density",
                            "(historically, there are scattered fibroglandular densities). " +
                            "" +
                            "It may be helpful to distinguish breasts in which there are a few scattered areas of " +
                            "fibroglandular-density tissue from those in which there are moderate scattered areas of " +
                            "fibroglandular-density tissue. Note that there has been a subtle change in the wording " +
                            "of this category, to conform to BI-RADS® lexicon use of the term \"density\" to describe " +
                            "the degree of x-ray attenuation of breast tissue but not to represent discrete " +
                            "mammographic findings."
                        ),
                        new ConceptDef("HeterogeneouslyDense",
                            "The breasts are heterogeneously dense, which may obscure detection of small masses",
                            "It is not uncommon for some areas in such breasts to be relatively dense while other " +
                            "areas are primarily fatty. When this occurs, it may be helpful to describe the location(s) " +
                            "of the denser tissue in a second sentence, so that the referring clinician is aware that " +
                            "these are the areas in which small noncalcified lesions may be obscured. Suggested " +
                            "wordings for the second sentence include: "+
                            "" +
                            "\"The dense tissue is located anteriorly in both breasts, and the posterior portions " +
                            "are mostly fatty.\"" +
                            "" +
                            "\"Primarily dense tissue is located in the upper outer quadrants of both breasts; " +
                            "scattered areas of fibroglandular tissue are present in the remainder of the breasts.\""
                        ),
                        new ConceptDef("ExtremelyDense",
                            "The breasts are extremely dense, which lowers the sensitivity of mammography.",
                            "The sensitivity of mammography is lowest in this density category. " +
                            "The Fourth Edition of BI-RADS®, unlike previous editions, indicated quartile ranges " +
                            "of percentage dense tissue (increments of 25% density) for each of the four density " +
                            "categories, with the expectation that the assignment of breast density would be " +
                            "distributed more evenly across categories than the historical distribution of 10% fatty, " +
                            "40% scattered, 40% heterogeneously and 10% extremely dense. However, it has since " +
                            "been demonstrated in clinical practice that there has been essentially no change " +
                            "in this historical distribution across density categories, despite the 2003 guidance " +
                            "provided in the BI-RADS® Atlas."
                        ),
                    }
                )
                .Url;

            SDefEditor e = this.CreateObservationEditor("BreastRadMammoBreastDensity",
                        "Breast Radiology Mammography Breast Density Observation",
                        new string[] {"Breast","Density"},
                        out mammoBreastDensity)
                    .Description(new Markdown()
                        .Paragraph("Breast Radiology Mammography Breast Density Observation")
                        .BiradHeader()
                        .MarkedDown("The following four categories of breast composition are defined by the visually estimated content of fibroglandular-density tissue within the breasts. Please note that the ")
                        .MarkedDown("categories are listed as a, b, c, and d so as not to be confused with the numbered BI-RADS® assessment categories. If the breasts are not of apparently equal density, the ")
                        .MarkedDown("denser breast should be used to categorize breast density. The sensitivity of mammography for noncalcified lesions decreases as the BI-RADS® breast density category ")
                        .MarkedDown("increases. The denser the breast, the larger the lesion(s) that may be obscured. There is considerable intra- and inter-observer variation in visually estimating breast density ")
                        .MarkedDown("between any two adjacent density categories. Furthermore, there is only a minimal and insignificant difference in the sensitivity of mammography between the densest breast ")
                        .MarkedDown("in a lower-density category and the least dense breast in the next-higher-density category. These factors limit the clinical relevance of breast density categorization for the ")
                        .MarkedDown("individual woman. ")
                        .BiradFooter()
                    )
                    .AddFragRef(this.ObservationCodedValueFragment)
                    ;

            e.Select("value[x]")
                .Type("CodeableConcept")
                .Binding(binding, BindingStrength.Required)
                ;
            }
    }
}
