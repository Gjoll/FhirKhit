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
        public String BreastRadiologyReport
        {
            get
            {
                if (breastRadiologyReport == null)
                    CreateBreastRadiologyReport();
                return breastRadiologyReport;
            }
        }
        String breastRadiologyReport = null;


        void CreateBreastRadiologyReport()
        {
            SDefEditor e = this.CreateEditor("BreastRadReport",
                "Breast Radiology Report",
                new string[] {"Breast","Radiology","Report"},
                DiagnosticReportUrl,
                "Base",
                out breastRadiologyReport)
                .Description("Breast Radiology Diagnostic Report", 
                    new Markdown()
                        .Paragraph("This diagnostic report has links to the data that comprise a Breast Radiology Report, including")
                        .List("references to prior breast radiology reports for this patient",
                              "references to the observations of this report",
                              "references to the recommendations of this report",
                              "a summary of the report findings in a human readable format")
                        .Todo(
                        )
                )
                .AddFragRef(this.HeaderFragment)
                .AddFragRef(this.CategoryFragment)
                ;

            e.Select("code").Pattern = new CodeableConcept(Loinc, "10193-1");
            e.Select("specimen").Zero();
            e.Select("conclusion").Single();
            e.Select("conclusionCode").Single();
            e.ApplyExtension("Recommendations", this.BreastRadiologyRecommendationsExtension)
                .Short("Recommendations for future care")
                .Definition("Recommendations for future care")
                .ZeroToMany();
            e.ApplyExtension("PriorReports", this.BreastRadiologyPriorReportsExtension)
                .Short("Recommendations for future care")
                .Definition("Recommendations for future care")
                .ZeroToMany();

            ProfileTargetSlice[] targets = new ProfileTargetSlice[]
            {
                    new ProfileTargetSlice(this.SectionPatientHistory, 1, "1"),
                    new ProfileTargetSlice(this.SectionFindings, 1, "1"),
                    new ProfileTargetSlice(this.SectionPatientRisk, 1, "1")
            };
            e.Find("result").SliceByUrl(targets);
            e.MapNode.AddProfileTargets(targets);

            e.IntroDoc
                .Paragraph(
                    $"This resource is the base of the Breast Radiology Report.",
                    $"Detailed information about the report is contained in sub sections referenced by this resource."
                    );
        }
    }
}
