using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace FhirKhit.BreastRadiology.XUnitTests
{
    public class ResourcesMaker : ConverterBase
    {
        const String ProfileVersion = "0.0.2";
        const PublicationStatus ProfileStatus = PublicationStatus.Draft;

        const String Loinc = "http://loinc.org";

        const String ObservationUrl = "http://hl7.org/fhir/StructureDefinition/Observation";
        const String DiagnosticReportUrl = "http://hl7.org/fhir/StructureDefinition/DiagnosticReport";
        const String ExtensionUrl = "http://hl7.org/fhir/StructureDefinition/Extension";
        const String MedicationRequestUrl = "http://hl7.org/fhir/StructureDefinition/MedicationRequest";
        const String ServiceRequestUrl = "http://hl7.org/fhir/StructureDefinition/ServiceRequest";

        String resourceDir;
        FhirDateTime date = new FhirDateTime(2019, 11, 1);
        List<SDefEditor> editors = new List<SDefEditor>();

        String CreateUrl(String name)
        {
            return $"http://hl7.org/fhir/us/breast-radiology/StructureDefinition/{name}";
        }

        public ResourcesMaker(String resourceDir)
        {
            this.resourceDir = resourceDir;
        }

        public void CreateResources()
        {
            String patientRiskUrl = CreateSectionObservation("Patient Risk",
                new Markdown().Paragraph("Patient Risk Section"),
                new string[] { })
                .SDef.Url;

            String patientHistoryUrl = CreateSectionObservation("Patient History Section",
                new Markdown().Paragraph("Patient History Section"),
                new string[] { })
                .SDef.Url;

            String findingsLeftUrl = CreateSectionObservation("Findings Left Breast",
                new Markdown().Paragraph("Findings Left Breast Section"),
                new string[] { })
                .SDef.Url;

            String findingsRightUrl = CreateSectionObservation("Findings Right Breast",
                new Markdown().Paragraph("Findings Right Breast Section"),
                new string[] { })
                .SDef.Url;

            String findingsUrl = CreateSectionObservation("Findings",
                new Markdown().Paragraph("Findings Section"),
                new string[] { findingsLeftUrl, findingsRightUrl })
                .SDef.Url;

            String rootUrl = CreateSectionObservation("Root",
                new Markdown().Paragraph("Root Section"),
                new string[] { patientHistoryUrl, findingsUrl, patientRiskUrl })
                .FixedCodeSlice("Observation", "Observation.code", "observationCode", Loinc, "10193-1")
                .SDef.Url;

            CreateBreastRadiologyReport(rootUrl);
            SaveAll();
        }

        SDefEditor CreateEditor(String title, String baseUrl)
        {
            String name = title.Replace(" ", "");
            SDefEditor retVal = new SDefEditor(baseUrl, this.resourceDir)
                .Name(name)
                .Url(CreateUrl(name))
                .Status(ProfileStatus)
                .Title(title)
                .Publisher("Hl7 - Clinical Interoperability Council")
                .ContactUrl("http://www.hl7.org/Special/committees/cic")
                .Date(date)
                .Derivation(StructureDefinition.TypeDerivationRule.Constraint)
                .Abstract(false)
                .Type(baseUrl.LastUriPart())
                .Version(ProfileVersion)
                .Kind(StructureDefinition.StructureDefinitionKind.Resource)
                ;

            this.editors.Add(retVal);
            return retVal;
        }

        SDefEditor CreateObservationEditor(String title)
        {
            SDefEditor retVal = this.CreateEditor(title, ObservationUrl);
            retVal.Select("Observation.subject").Single();
            retVal.Select("Observation.component").Zero();
            return retVal;
        }

        SDefEditor CreateSectionObservation(String title,
            Markdown description,
            String[] targetsObservationProfiles)
        {
            SDefEditor e = CreateObservationEditor(title)
                .Description(description)
                ;
            if (targetsObservationProfiles != null)
            {
                //var hasMember = e. 
            }
            return e;
        }

        void CreateBreastRadiologyReport(String rootObservationUrl)
        {
            String CreatePriorReportsExtension(String brrDiagnosticReportUrl)
            {
                SDefEditor e2 = CreateEditor("Prior Reports", ExtensionUrl)
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

            String CreateRecommendationsExtension()
            {
                SDefEditor e3 = CreateEditor("Recommendations", ExtensionUrl)
                    .Description(new Markdown()
                        .Paragraph("Diagnostic Report recommendations section extension")
                    )
                    .Kind(StructureDefinition.StructureDefinitionKind.ComplexType)
                    .Context()
                    ;

                e3.Select("extension").Zero();
                e3.Select("url")
                    .Type("uri")
                    .Fixed(new FhirUri(e3.SDef.Url));

                e3.Select("value[x]")
                    .TypeReference(MedicationRequestUrl, ServiceRequestUrl)
                    .Single()
                    ;
                return e3.SDef.Url;
            }
            SDefEditor e = CreateEditor("Breast Radiology Report", DiagnosticReportUrl)
                .Description(new Markdown()
                    .Paragraph("Breast Radiology Diagnostic Report.")
                    .Paragraph("This diagnostic report has links to the data that comprise a Breast Radiology Report, including")
                    .List("references to prior breast radiology reports for this patient",
                          "references to the observations of this report",
                          "references to the recommendations of this report",
                          "a summary of the report findings in a human readable format")
                )
                ;

            String recommendationsExtensionUrl = CreateRecommendationsExtension();
            String priorReportsExtensionUrl = CreatePriorReportsExtension(e.SDef.Url);

            e.Select("code").Pattern = new CodeableConcept(Loinc, "10193-1");
            e.Select("category").Pattern = new CodeableConcept(Loinc, "10193-1");
            e.Select("specimen").Zero();
            e.Select("conclusion").Single();
            e.Select("conclusionCode").Single();
            e.SimpleExtension("Recommendations", recommendationsExtensionUrl)
                .Short("Recommendations for future care")
                .Definition("Recommendations for future care")
                .ZeroToMany();
            e.SimpleExtension("PriorReports", priorReportsExtensionUrl)
                .Short("Recommendations for future care")
                .Definition("Recommendations for future care")
                .ZeroToMany();

            e.Select("result")
                .Single()
                .TypeReference(rootObservationUrl)
                ;
        }

        void SaveAll()
        {
            foreach (SDefEditor ce in this.editors)
            {
                ce.SDef.Snapshot = null;
                ce.Write();
            }
        }
    }
}
