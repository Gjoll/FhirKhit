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
        async StringTask BreastRadiologyImpressionsExtension()
        {
            if (breastRadiologyImpressionsExtension == null)
                await CreateBreastRadiologyImpressionsExtension();
            return breastRadiologyImpressionsExtension;
        }
        String breastRadiologyImpressionsExtension = null;

        async VTask CreateBreastRadiologyImpressionsExtension()
        {
            SDefEditor e = this.CreateEditor("BreastRadImpressionsExtension",
                "Impressions Extension",
                new string[] { "Impressions", "Extension" },
                ExtensionUrl,
                $"{Group_ExtensionResources}/Impressions",
                out breastRadiologyImpressionsExtension)
                .Description("Impressions extension",
                    new Markdown()
                        .Paragraph("This extension defines the impressions section of a breast radiology report, " +
                                   "linking a report to the resources that the exam impressions.")
                        .Todo(
                        )
                )
                .Kind(StructureDefinition.StructureDefinitionKind.ComplexType)
                .Context()
                ;
            e.AddFragRef(await this.HeaderFragment());

            e.Select("extension").Zero();
            e.Select("url")
                .Type("uri")
                .Fixed(new FhirUri(e.SDef.Url));

            e.Select("value[x]")
                .TypeReference(await BreastRadImpression())
                .ZeroToMany()
                ;

            e.IntroDoc.ReviewedStatus(ReviewStatus.NotReviewed).Extension("Prior Reports", "include references to prior reports");

            e.Node.AddLink("target", ClinicalImpressionUrl, false);
        }
    }
}
