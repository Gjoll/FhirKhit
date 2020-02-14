using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;


#if FHIR_R4
namespace FhirKhit.Tools.R4
#elif FHIR_R3
namespace FhirKhit.Tools.R3
#endif
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
