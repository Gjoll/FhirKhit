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

namespace FhirKhit.BreastRadiology.XUnitTests
{
    public partial class ResourcesMaker : ConverterBase
    {
        void BreastRadiologyReport(String rootObservationUrl)
        {
            SDefEditor e = this.CreateEditor("BreastRadReport",
                "Breast Radiology Report",
                "DiagnosticReport",
                DiagnosticReportUrl,
                DiagnosticReportUrl)
                .Description(new Markdown()
                    .Paragraph("Breast Radiology Diagnostic Report.")
                    .Paragraph("This diagnostic report has links to the data that comprise a Breast Radiology Report, including")
                    .List("references to prior breast radiology reports for this patient",
                          "references to the observations of this report",
                          "references to the recommendations of this report",
                          "a summary of the report findings in a human readable format")
                )
                ;

            e.AddFragRef(this.headerFragUrl);
            String recommendationsUrl = this.BreastRadiologyRecommendationsExtension();
            String priorReportsUrl = this.BreastRadiologyPriorReportsExtension(e.SDef.Url);

            e.Select("code").Pattern = new CodeableConcept(Loinc, "10193-1");
            this.CreateCategorySlice(e, "category");
            e.Select("specimen").Zero();
            e.Select("conclusion").Single();
            e.Select("conclusionCode").Single();
            e.ApplyExtension("Recommendations", recommendationsUrl)
                .Short("Recommendations for future care")
                .Definition("Recommendations for future care")
                .ZeroToMany();
            e.ApplyExtension("PriorReports", priorReportsUrl)
                .Short("Recommendations for future care")
                .Definition("Recommendations for future care")
                .ZeroToMany();

            e.Select("result")
                .Single()
                .TypeReference(rootObservationUrl)
                ;
        }
    }
}
