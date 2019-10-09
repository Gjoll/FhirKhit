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
            CreateBreastRadiologyReport();
            CreateBreastRadiologyObservation();
            SaveAll();
        }

        SDefEditor CreateEditor(String name, String baseUrl)
        {
            SDefEditor retVal = new SDefEditor(baseUrl, this.resourceDir)
                .Name(name)
                .Url(CreateUrl(name))
                .Status(ProfileStatus)
                .Title(name)
                .Publisher("Hl7 - Clinical Interoperability Council")
                .ContactUrl("http://www.hl7.org/Special/committees/cic")
                .Date(date)
                .Derivation(StructureDefinition.TypeDerivationRule.Constraint)
                .Abstract(false)
                .Type(baseUrl.LastUriPart())
                .Version(ProfileVersion)
                ;

            this.editors.Add(retVal);
            return retVal;
        }

        SDefEditor CreateObservationEditor(String name, String baseUrl)
        {
            SDefEditor retVal = this.CreateEditor(name, baseUrl);
            retVal.Select("Observation.subject").Single();
            retVal.Select("Observation.component").Zero();
            return retVal;
        }

        void CreateBreastRadiologyObservation()
        {
            SDefEditor e = CreateObservationEditor("BreastRadiologyObservation", ObservationUrl)
                .Description(
                    "Breast Radiology Diagnostic Observation." +
                    "<br>" +
                    "This observation contains a number of sections with specific observations" +
                    "pertaining to this breast radiology diagnostic report." +
                    "These sections include" +
                    "** Findings" +
                    "<br>" +
                    "Detailed information about the results of the exam are contained in the " +
                    "Breast Radiology Observation linked to by the 'result' field."
                )
                .SliceByCode("Observation", "Observation.code", "observationCode", Loinc, "10193-1");
                ;
        }

        void CreateBreastRadiologyReport()
        {
            String CreatePriorReportsExtension(String brrDiagnosticReportUrl)
            {
                SDefEditor e2 = CreateEditor("PriorReports", ExtensionUrl)
                    .Description("Breast Radiology Prior Diagnostic Report extension")
                    .Kind(StructureDefinition.StructureDefinitionKind.ComplexType)
                    .Context()
                    ;

                e2.Select("extension").Zero();
                e2.Select("url")
                    .Type("uri")
                    .Fixed(new FhirUri(e2.SDef.Url));

                String[] targets = new string[]
                {
                brrDiagnosticReportUrl
                };
                e2.Select("value[x]")
                    .Type("Reference", null, targets)
                    .Single()
                    ;
                return e2.SDef.Url;
            }

            String CreateRecommendationsExtension()
            {
                SDefEditor e3 = CreateEditor("Recommendations", ExtensionUrl)
                    .Description("Breast Radiology Diagnostic Report recommendations section extension")
                    .Kind(StructureDefinition.StructureDefinitionKind.ComplexType)
                    .Context()
                    ;

                e3.Select("extension").Zero();
                e3.Select("url")
                    .Type("uri")
                    .Fixed(new FhirUri(e3.SDef.Url));

                String[] targets = new string[]
                {
                MedicationRequestUrl,
                ServiceRequestUrl
                };
                e3.Select("value[x]")
                    .Type("Reference", null, targets)
                    .Single()
                    ;
                return e3.SDef.Url;
            }
            SDefEditor e = CreateEditor("BreastRadiologyReport", DiagnosticReportUrl)
                .Description(
                    "Breast Radiology Diagnostic Report." +
                    "<br>" +
                    "This diagnostic report is the base of the Breast Radiology Report, " +
                    " and contains a summary of the report findings." +
                    "<br>" +
                    "Detailed information about the results of the exam are contained in the " +
                    "Breast Radiology Observation linked to by the 'result' field."
                )
                .Kind(StructureDefinition.StructureDefinitionKind.Resource)
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
                .Type("Reference", null, new String[] { ObservationUrl })
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
