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
            //$ Fix me. Incorrect method!!!
            String abMammo = this.CreateObservationAbnormality(
                "BreastRadiology-Abnormality-Mammography",
                "Breast Radiology Abnormality (Mammography)",
                new Markdown().Paragraph("Mammography Breast Abnormality Observation"),
                "http://snomed.info/sct", 
                "115341008")
                .SDef.Url;

            //$ Fix me. Incorrect method!!!
            String abMRI = this.CreateObservationAbnormality(
                "BreastRadiology-Abnormality-MRI",
                "Breast Radiology Abnormality (MRI)",
                new Markdown().Paragraph("MRI Breast Abnormality Observation"),
                "http://snomed.info/sct", 
                "115341008")
                .SDef.Url;

            //$ Fix me. Incorrect method!!!
            String abUS = this.CreateObservationAbnormality(
                "BreastRadiology-Abnormality-UltraSound",
                "Breast Radiology Abnormality (UltraSound)",
                new Markdown().Paragraph("Ultra Sound Breast Abnormality Observation"),
                "http://snomed.info/sct", 
                "115341008")
                .SDef.Url;

            ObservationTarget[] abnormalityTargets = new ObservationTarget[]
            {
                new ObservationTarget(abMammo, 0, "*"),
                new ObservationTarget(abMRI, 0, "*"),
                new ObservationTarget(abUS, 0, "*")
            };

            String patientRiskUrl = CreateObservationSection(
                "BreastRadiology-Section-PatientRisk",
                "Breast Radiology Patient Risk Section",
                new Markdown().Paragraph("Patient Risk Section"))
                .SDef.Url;

            String patientHistoryUrl = CreateObservationSection(
                "BreastRadiology-Section-PatientHistory",
                "Breast Radiology Patient History Section",
                new Markdown().Paragraph("Patient History Section"))
                .SDef.Url;

            String findingsLeftUrl = CreateObservationSection(
                "BreastRadiology-Section-Findings-LeftBreast",
                "Breast Radiology Findings Left Breast",
                new Markdown().Paragraph("Findings Left Breast Section"))
                .SliceByUrl("Observation.hasMember", abnormalityTargets)
                .SDef.Url;

            String findingsRightUrl = CreateObservationSection(
                "BreastRadiology-Section-Findings-RightBreast",
                "Breast Radiology Findings Right Breast",
                new Markdown().Paragraph("Findings Right Breast Section"))
                .SliceByUrl("Observation.hasMember", abnormalityTargets)
                .SDef.Url;

            String findingsUrl = CreateObservationSection(
                "BreastRadiology-Section-Findings",
                "Breast Radiology Findings",
                new Markdown().Paragraph("Findings Section"))
                .SliceByUrl("Observation.hasMember",
                    new ObservationTarget[]
                    {
                        new ObservationTarget(findingsLeftUrl, 1, "1"),
                        new ObservationTarget(findingsRightUrl, 1, "1")
                    })
                .SDef.Url;

            String rootUrl = CreateObservationSection(
                "BreastRadiology-Section-Root",
                "Breast Radiology Root Section",
                new Markdown().Paragraph("Root Section"))
                .SliceByUrl("Observation.hasMember",
                new ObservationTarget[]
                    {
                        new ObservationTarget(patientHistoryUrl, 1, "1"),
                        new ObservationTarget(patientRiskUrl, 1, "1")
                    })
                .FixedCodeSlice("Observation.code", "observationCode", Loinc, "10193-1")
                .SDef.Url;

            CreateBreastRadiologyReport(rootUrl);
            SaveAll();
        }

        SDefEditor CreateEditor(String name, String title, String baseUrl)
        {
            if (name.Contains(" "))
                throw new Exception("Structure Def name can not contains spaces");

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

        SDefEditor CreateObservationEditor(String name, String title)
        {
            SDefEditor retVal = this.CreateEditor(name, title, ObservationUrl);
            retVal.Select("Observation.subject").Single();
            retVal.Select("Observation.component").Zero();
            retVal.Select("Observation.basedOn").Zero();
            retVal.Select("Observation.derivedFrom").Zero();
            retVal.Select("Observation.partOf").Zero();
            retVal.Select("Observation.focus").Zero();
            CreateCategorySlice(retVal, "category");

            return retVal;
        }

        void CreateCategorySlice(SDefEditor sDefEditor, String path)
        {
            var eDef = sDefEditor.Find(path);
            eDef.ElementDefinition.Min(1);
            sDefEditor.FixedCodeSlice(eDef,
                "category",
                "http://terminology.hl7.org/CodeSystem/observation-category",
                "imaging");
        }

        SDefEditor CreateObservationSection(String name, 
            String title,
            Markdown description)
        {
            SDefEditor e = CreateObservationEditor(name, title)
                .Description(description)
                ;
            e.Select("Observation.value[x]").Zero();
            e.Select("Observation.specimen").Zero();
            e.Select("Observation.device").Zero();
            e.Select("Observation.referenceRange").Zero();

            e.Select("Observation.interpretation").Zero();
            e.Select("Observation.note").Zero();
            e.Select("Observation.bodySite").Zero();
            e.Select("Observation.method").Zero();
            return e;
        }

        SDefEditor CreateObservationAbnormality(String name, String title,
            Markdown description,
            String methodCodeSet,
            String method)
        {
            SDefEditor e = CreateObservationEditor(name, title)
                .Description(description)
                ;

            e.Select("Observation.value[x]").Zero();
            e.Select("Observation.specimen").Zero();
            e.Select("Observation.referenceRange").Zero();
            e.Select("Observation.interpretation").Zero();
            e.Select("Observation.note").Zero();
            e.Select("Observation.bodySite").Zero();

            e.Find("Observation.method")
             .FixedCodeSlice("method",
                             methodCodeSet,
                             method)
             .Min(1)
             ;

            return e;
        }

        void CreateBreastRadiologyReport(String rootObservationUrl)
        {
            String CreatePriorReportsExtension(String brrDiagnosticReportUrl)
            {
                SDefEditor e2 = CreateEditor("BreastRadiology-PriorReports", "Prior Reports", ExtensionUrl)
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
                SDefEditor e3 = CreateEditor("BreastRadiology-Recommendations", "Recommendations", ExtensionUrl)
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
            SDefEditor e = CreateEditor("BreastRadiology-Report", "Breast Radiology Report", DiagnosticReportUrl)
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
            CreateCategorySlice(e, "category");
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
