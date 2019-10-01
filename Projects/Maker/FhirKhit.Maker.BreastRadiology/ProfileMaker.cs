using System;
using System.Collections.Generic;
using System.Text;
using FhirKhit.Maker.Common.Resource;
using Hl7.Fhir.Model;

namespace FhirKhit.Maker.BreastRadiology
{
    public class ProfileMaker
    {
        const String Loinc = "http://loinc.org";
        const String DiagSvcSects = "http://terminology.hl7.org/CodeSystem/v2-0074";
        void CreateBreastRadiologyReport()
        {
            Common.Resource.DiagnosticReport r = new Common.Resource.DiagnosticReport
            {
                Description =
                    "Breast Radiology Diagnostic Report." +
                    "<br>" +
                    "This diagnostic report is the base of the Breast Radiology Report, " +
                    " and contains a summary of the report findings." +
                    "<br>" +
                    "Detailed information about the results of the exam are contained in the " +
                    "Breast Radiology Observation linked to by the 'result' field."
            };

            r.Elements.Code.Pattern(new CodeableConcept(Loinc, "10193-1"));
            r.Elements.Category.Pattern(new CodeableConcept(DiagSvcSects, "RAD"));
            r.Elements.Specimen.Unused();
            r.Elements.Conclusion.Card(1, 1);
            r.Elements.ConclusionCode.Card(1, 1);
        }
        public void CreateProfiles()
        {
        }
    }
}
