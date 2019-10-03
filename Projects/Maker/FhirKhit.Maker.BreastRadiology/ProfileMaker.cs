using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using FhirKhit.Maker.Common.Resource;
using Hl7.Fhir.Model;

namespace FhirKhit.Maker.BreastRadiology
{
    public class ProfileMaker
    {
        const String outputDir = @"\Temp";

        const String Loinc = "http://loinc.org";
        const String DiagSvcSects = "http://terminology.hl7.org/CodeSystem/v2-0074";
        void CreateBreastRadiologyReport()
        {
            Common.Resource.Resource_DiagnosticReport r = new Common.Resource.Resource_DiagnosticReport
            {
                Name = "BreastRadiologyReport",
                Parent = new Common.Resource.Resource_DiagnosticReport(),
                Uri = "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/breastrad-BreastAbnormality",
                Description =
                    "Breast Radiology Diagnostic Report." +
                    "<br>" +
                    "This diagnostic report is the base of the Breast Radiology Report, " +
                    " and contains a summary of the report findings." +
                    "<br>" +
                    "Detailed information about the results of the exam are contained in the " +
                    "Breast Radiology Observation linked to by the 'result' field."
            };

            r.Element_Code.Pattern(new CodeableConcept(Loinc, "10193-1"));
            r.Element_Category.Pattern(new CodeableConcept(DiagSvcSects, "RAD"));
            r.Element_Specimen.Unused();
            r.Element_Conclusion.Card(1, 1);
            r.Element_ConclusionCode.Card(1, 1);
            r.SimpleExtension();

            r.Write(Path.Combine(outputDir, $"StructureDefinition.BreastRadiologyReport.json"));
        }
        public void CreateProfiles()
        {
            CreateBreastRadiologyReport();
        }
    }
}
