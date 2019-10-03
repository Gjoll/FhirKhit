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

        String CreateUrl(String name)
        {
            return $"http://hl7.org/fhir/us/breast-radiology/StructureDefinition/{name}";
        }
        void CreateBreastRadiologyReport()
        {
            SDefEditor e = new SDefEditor("http://hl7.org/fhir/StructureDefinition/DiagnosticReport")
                .Name("BreastRadiologyReport")
                .Description(
                    "Breast Radiology Diagnostic Report." +
                    "<br>" +
                    "This diagnostic report is the base of the Breast Radiology Report, " +
                    " and contains a summary of the report findings." +
                    "<br>" +
                    "Detailed information about the results of the exam are contained in the " +
                    "Breast Radiology Observation linked to by the 'result' field."
                )
                .Url(CreateUrl("BreastRadiology_DiagnosticReport"))
                ;

            e.Select("code").Pattern = new CodeableConcept(Loinc, "10193-1");
            e.Select("category").Pattern = new CodeableConcept(Loinc, "10193-1");
            e.Select("specimen").Zero();
            e.Select("conclusion").Single();
            e.Select("conclusionCode").Single();
            e.SimpleExtension("Recommendations")
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
