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
        async StringTask BreastRadiologyPriorReportsExtension()
        {
            if (breastRadiologyPriorReportsExtension == null)
                await CreateBreastRadiologyPriorReportsExtension();
            return breastRadiologyPriorReportsExtension;
        }
        String breastRadiologyPriorReportsExtension = null;

        async VTask CreateBreastRadiologyPriorReportsExtension()
        {
            await VTask.Run(async () =>
            {
                SDefEditor e = this.CreateEditor("BreastRadPriorReportsExtension",
                    "Prior Reports Extension",
                    "Prior Reports/Extension",
                    ExtensionUrl,
                    $"{Group_ExtensionResources}/PriorReports",
                    out breastRadiologyPriorReportsExtension)
                    .Description("Prior Diagnostic Report extension",
                        new Markdown()
                            .Paragraph("This extension defines the prior reports section of a breast radiology report, " +
                                       "linking a report to the resources that are the prior reports.")
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
                    .TypeReference(await this.BreastRadiologyReport())
                    .Single()
                    ;

                e.IntroDoc
                    .ReviewedStatus(ReviewStatus.NotReviewed)
                    .Extension("Prior Reports", "include references to prior reports")
                    ;
                e.AddLink("target", await BreastRadiologyReport(), false);
                return e.SDef.Url;
            });
        }
    }
}
