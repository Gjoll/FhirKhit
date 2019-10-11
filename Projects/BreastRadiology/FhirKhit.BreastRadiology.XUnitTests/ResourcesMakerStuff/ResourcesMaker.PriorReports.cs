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

namespace FhirKhit.BreastRadiology.XUnitTests
{
    public partial class ResourcesMaker : ConverterBase
    {
        String BreastRadiologyPriorReports(String brrDiagnosticReportUrl)
        {
            SDefEditor e2 = CreateEditor("BreastRadiologyPriorReports", "Prior Reports", ExtensionUrl)
                .Description(new Markdown()
                    .Paragraph("Prior Diagnostic Report extension")
                    )
                .Kind(StructureDefinition.StructureDefinitionKind.ComplexType)
                .Context()
                ;

            e2.Select("extension").Zero();
            e2.Select("url")
                .Type("uri")
                .Fixed(new FhirUri(e2.SDef.Url));

            e2.Select("value[x]")
                .TypeReference(brrDiagnosticReportUrl)
                .Single()
                ;
            return e2.SDef.Url;
        }
    }
}
