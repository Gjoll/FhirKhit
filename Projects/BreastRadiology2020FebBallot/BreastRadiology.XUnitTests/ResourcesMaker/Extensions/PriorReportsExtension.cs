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
        String BreastRadiologyPriorReportsExtension
        {
            get
            {
                if (breastRadiologyPriorReportsExtension == null)
                    CreateBreastRadiologyPriorReportsExtension();
                return breastRadiologyPriorReportsExtension;
            }
        }
        String breastRadiologyPriorReportsExtension = null;

        String CreateBreastRadiologyPriorReportsExtension()
        {
            SDefEditor e = this.CreateEditor("BreastRadPriorReportsExtension", 
                "Prior Reports Extension",
                new string[] {"Prior Reports", "Extension"}, 
                ExtensionUrl,
                out breastRadiologyPriorReportsExtension)
                .Description(new Markdown()

                    .Paragraph("Prior Diagnostic Report extension")
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
                .TypeReference(this.BreastRadiologyReport)
                .Single()
                ;

            e.IntroDoc.ReviewedStatus(ReviewStatus.NotReviewed).Extension("Prior Reports", "include references to prior reports");
            return e.SDef.Url;
        }
    }
}
