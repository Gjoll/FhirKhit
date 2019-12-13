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
        String BreastRadiologyRecommendationsExtension
        {
            get
            {
                if (breastRadiologyRecommendationsExtension == null)
                    CreateBreastRadiologyRecommendationsExtension();
                return breastRadiologyRecommendationsExtension;
            }
        }
        String breastRadiologyRecommendationsExtension = null;

        String CreateBreastRadiologyRecommendationsExtension()
        {
            SDefEditor e = this.CreateEditor("BreastRadRecommendationsExtension",
                "Recommendations Extension",
                new string[] { "Recommendations", "Extension" },
                ExtensionUrl,
                 $"{Group_ExtensionResources}/Recommendations",
               out breastRadiologyRecommendationsExtension)
                .Description("Diagnostic Report recommendations section extension",
                new Markdown()
                    .Paragraph("This extension defines the recommendations section of a breast radiology report, " +
                                "linking a report to the resources that are its recommendations.")
                    .Todo(
                    )
                )
                .Kind(StructureDefinition.StructureDefinitionKind.ComplexType)
                .Context()
                ;
            e.AddFragRef(this.HeaderFragment);

            e.Select("extension").Zero();
            e.Select("url")
                .Type("uri")
                .Fixed(new FhirUri(e.SDef.Url));

            e.Select("value[x]")
                .TypeReference(MedicationRequestUrl, ServiceRequestUrl)
                .Single()
                ;

            e.IntroDoc.ReviewedStatus(ReviewStatus.NotReviewed).Extension("Recommendations", "include references to recommendations");
            e.Node.AddLink("target", MedicationRequestUrl, false);
            e.Node.AddLink("target", ServiceRequestUrl, false);
            return e.SDef.Url;
        }
    }
}
