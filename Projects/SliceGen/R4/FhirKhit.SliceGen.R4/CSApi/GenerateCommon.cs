using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.SliceGen.R4
{
    public static class GenerateCommon
    {
        public static bool Ignore(FHIRAllTypes fhirType)
        {
            switch (fhirType)
            {
                case FHIRAllTypes.Resource:
                case FHIRAllTypes.DomainResource:
                case FHIRAllTypes.BackboneElement:
                case FHIRAllTypes.Element:
                    return true;
                default:
                    return false;
            }
        }
    }
}
