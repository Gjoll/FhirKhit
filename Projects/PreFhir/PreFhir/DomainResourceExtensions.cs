using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PreFhir
{
    public static class DomainResourceExtensions
    {
        public static IEnumerable<String> ReferencedFragments(this DomainResource domainResource)
        {
            List<String> retVal = new List<string>();
            foreach (var extension in domainResource.Extension)
            {
                if (extension.Url == PreFhirGenerator.FragmentUrl)
                {
                    FhirUrl fragmentUrl = (FhirUrl)extension.Value;
                    retVal.Add(fragmentUrl.Value);
                }
            }

            return retVal;
        }

        public static T AddFragRef<T>(this T domainResource, StructureDefinition fragRef)
            where T : DomainResource
        {
            return domainResource.AddFragRef(fragRef.Url);
        }

        public static T AddFragRef<T>(this T domainResource, String fragRef)
            where T : DomainResource
        {
            domainResource.Extension.Add(new Extension
            {
                Url = PreFhirGenerator.FragmentUrl,
                Value = new FhirUrl(fragRef)
            });
            return domainResource;
        }
    }
}
