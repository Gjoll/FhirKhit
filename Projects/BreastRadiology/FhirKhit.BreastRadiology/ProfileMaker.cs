using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Hl7.Fhir.Model;

namespace FhirKhit.BreastRadiology
{
    public class ProfileMaker
    {
        const String outputDir = @"\Temp";

        const String Loinc = "http://loinc.org";
        const String DiagSvcSects = "http://terminology.hl7.org/CodeSystem/v2-0074";

        const String DiagnosticReportUrl = "http://hl7.org/fhir/StructureDefinition/DiagnosticReport";
        const String ExtensionUrl = "http://hl7.org/fhir/StructureDefinition/Extension";
        const String MedicationRequestUrl = "http://hl7.org/fhir/StructureDefinition/MedicationRequest";
        const String ServiceRequestUrl = "http://hl7.org/fhir/StructureDefinition/ServiceRequest";

        FhirDateTime date = new FhirDateTime(2019, 11, 1);
        String CreateUrl(String name)
        {
            return $"http://hl7.org/fhir/us/breast-radiology/StructureDefinition/{name}";
        }

        SDefEditor CreateEditor(String name, String baseUrl)
        {
            return new SDefEditor(baseUrl)
                .Name(name)
                .Url(CreateUrl(name))
                .Status(PublicationStatus.Draft)
                .Title(name)
                .Publisher("Hl7 - Clinical Interoperability Council")
                .ContactUrl("http://www.hl7.org/Special/committees/cic")
                .Date(date)
                .Derivation(StructureDefinition.TypeDerivationRule.Constraint)
                .Abstract(false)
                ;
        }

        String CreateRecommendationsExtension()
        {
            SDefEditor e = CreateEditor("Recommendations", ExtensionUrl)
                .Description("Breast Radiology Diagnostic Report recommendations section extension")
                .Kind(StructureDefinition.StructureDefinitionKind.ComplexType)
                ;

            e.Select("extension").Zero();
            e.Select("url")
                .Type("uri")
                .Fixed(new FhirUri(e.SDef.Url));

            String[] targets = new string[]
            {
                MedicationRequestUrl,
                ServiceRequestUrl
            };
            e.Select("value[x]")
                .Type("Reference", null, targets)
                .Single()
                ;
            e.Write(outputDir);
            return e.SDef.Url;
        }

        void CreateBreastRadiologyReport()
        {
            String recommendationsExtensionUrl = CreateRecommendationsExtension();

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

            e.Select("code").Pattern = new CodeableConcept(Loinc, "10193-1");
            e.Select("category").Pattern = new CodeableConcept(Loinc, "10193-1");
            e.Select("specimen").Zero();
            e.Select("conclusion").Single();
            e.Select("conclusionCode").Single();
            e.SimpleExtension("Recommendations", recommendationsExtensionUrl)
                .Short("Recommendations for future care")
                .Definition("Recommendations for future care")
                .ZeroToMany();

            e.Write(outputDir);
        }
        public void CreateProfiles()
        {
            CreateBreastRadiologyReport();
        }
    }
}
