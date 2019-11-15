using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

#if FHIR_R4
namespace FhirKhit.Tools.R4
#elif FHIR_R3
namespace FhirKhit.Tools.R3
#elif FHIR_R2
namespace FhirKhit.Tools.R2
#endif
{
    public static class DomainResourceExtensions
    {
        public static void RemoveExtension(this DomainResource domainResource, String url)
        {
            Int32 i = 0;
            while (i < domainResource.Extension.Count)
            {
                Extension e = domainResource.Extension[i];
                if (e.Url == url)
                    domainResource.Extension.RemoveAt(i);
                else
                    i += 1;
            }
        }
    }
}
