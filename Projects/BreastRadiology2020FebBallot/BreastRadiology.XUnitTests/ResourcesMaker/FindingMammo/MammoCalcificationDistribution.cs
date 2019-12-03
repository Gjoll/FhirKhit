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
    partial class ResourcesMaker : ConverterBase
    {
        String MammoCalcificationDistribution
        {
            get
            {
                if (mammoCalcificationDistribution == null)
                    CreateMammoCalcificationDistribution();
                return mammoCalcificationDistribution;
            }
        }
        String mammoCalcificationDistribution = null;

        void CreateMammoCalcificationDistribution()
        {
            String binding = this.CreateValueSet(
                "MammoCalcificationDistribution",
                "Mammography Calcification Distribution",
                new Markdown()
                    .Paragraph("Mammography Calcification Distribution")
                    .BiradHeader()
                    .BiRadLine("These descriptors are used to indicate the arrangement of calcifications in the breast. Multiple")
                    .BiRadLine("similar groups may be described in the report when there is more than one group of calcifications")
                    .BiRadLine("that are similar in morphology and distribution. In evaluating the likelihood of malignancy for calcifications, ")
                    .BiRadLine("distribution is at least as important as morphology.")
                    .BiradFooter(),
                    new ConceptDef[]
                    {
                        new ConceptDef("Diffuse",
                            "Diffuse Calcification Distribution",
                            "(historically, \"scattered\")" +
                            "These are calcifications that are distributed randomly throughout the breast. Punctate and " +
                            "amorphous calcifications in this distribution are almost always benign, especially if bilateral."
                        ),
                        new ConceptDef("Regional ",
                            "Regional  Calcification Distribution",
                            "This descriptor is used for numerous calcifications that occupy a large portion of breast tissue " +
                            "(more than 2 cm in greatest dimension), not conforming to a duct distribution. Since this " +
                            "distribution may involve most of a quadrant or even more than a single quadrant, malignancy " +
                            "is less likely. However, overall evaluation of regional calcifications must include particle shape " +
                            "(morphology) as well as distribution."
                        ),
                        new ConceptDef("Grouped ",
                            "Grouped  Calcification Distribution",
                            "(historically, \"clustered\")" +
                            "This term should be used when relatively few calcifications occupy a small portion of breast " +
                            "tissue. The lower limit for use of this descriptor is usually when 5 calcifications are grouped " +
                            "within 1 cm of each other or when a definable pattern is identified. The upper limit for use " +
                            "of this descriptor is when larger numbers of calcifications are grouped within 2 cm of each other."
                        ),
                        new ConceptDef("Linear ",
                            "Linear  Calcification Distribution",
                            "These are calcifications arrayed in a line. This distribution may elevate suspicion for malignancy, " +
                            "as it suggests deposits in a duct. Note that both vascular and large rod-like calcifications " +
                            "also are usually linear in distribution, but that these typically benign calcifications have " +
                            "a characteristically benign morphology."
                        ),
                        new ConceptDef("Segmental",
                            "Segmental Calcification Distribution",
                            "Calcifications in a segmental distribution are of concern because they suggest deposits in a " +
                            "duct or ducts and their branches, raising the possibility of extensive or multifocal breast cancer " +
                            "in a lobe or segment of the breast. Although benign causes of segmental calcifications exist " +
                            "(e.g. large rod-like), the smooth, rod-like morphology and large size of benign calcifications " +
                            "distinguish them from finer, more pleomorphic or heterogeneous malignant calcifications. " +
                            "A segmental distribution may elevate the degree of suspicion for calcifications such as punctate or amorphous forms."
                        )
                    }
                )
                .Url;

            SDefEditor e =  this.CreateEditor("BreastRadMammoCalcificationDistribution",
                    "Breast Radiology Mammography Calcification Distribution Observation",
                    new string[] {"Mammo", "Calc", "Distribution"},
                    ObservationUrl,
                    out mammoCalcificationDistribution)
                .Description(new Markdown().Paragraph("Breast Radiology Mammography Calcification Distribution Observation"))
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
