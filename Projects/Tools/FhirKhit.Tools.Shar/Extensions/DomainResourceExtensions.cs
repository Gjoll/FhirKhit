﻿using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

#if FHIR_R4
namespace FhirKhit.Tools.R4
#elif FHIR_R3
namespace FhirKhit.Tools.R3
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

#if FHIR_R4
        public static FHIRVersion? GetFhirVersion(this DomainResource domainResource)
        {
            switch (domainResource)
            {
                case StructureDefinition sDef:
                    return sDef.FhirVersion;
                case CodeSystem codeSys:
                case ValueSet valueSet:
                    return null;
                default:
                    throw new NotImplementedException($"Can not get value on unimplemented type {domainResource.GetType().Name}");
            }
        }
#endif

        public static String GetVersion(this DomainResource domainResource)
        {
            switch (domainResource)
            {
                case StructureDefinition sDef:
                    return sDef.Version;
                case CodeSystem codeSys:
                    return codeSys.Version;
                case ValueSet valueSet:
                    return valueSet.Version;
                default:
                    return null;
            }
        }

        public static String GetDate(this DomainResource domainResource)
        {
            switch (domainResource)
            {
                case StructureDefinition sDef:
                    return sDef.Date;
                case CodeSystem codeSys:
                    return codeSys.Date;
                case ValueSet valueSet:
                    return valueSet.Date;
                default:
                    throw new NotImplementedException($"Can not get value on unimplemented type {domainResource.GetType().Name}");
            }
        }

        public static String GetUrl(this DomainResource domainResource)
        {
            switch (domainResource)
            {
                case StructureDefinition sDef:
                    return sDef.Url;
                case CodeSystem codeSys:
                    return codeSys.Url;
                case ValueSet valueSet:
                    return valueSet.Url;
                default:
                    throw new NotImplementedException($"Can not get value on unimplemented type {domainResource.GetType().Name}");
            }
        }

        public static PublicationStatus? GetStatus(this DomainResource domainResource)
        {
            switch (domainResource)
            {
                case StructureDefinition sDef:
                    return sDef.Status;
                case CodeSystem codeSys:
                    return codeSys.Status;
                case ValueSet valueSet:
                    return valueSet.Status;
                default:
                    throw new NotImplementedException($"Can not get value on unimplemented type {domainResource.GetType().Name}");
            }
        }

        public static String GetPublisher(this DomainResource domainResource)
        {
            switch (domainResource)
            {
                case StructureDefinition sDef:
                    return sDef.Publisher;
                case CodeSystem codeSys:
                    return codeSys.Publisher;
                case ValueSet valueSet:
                    return valueSet.Publisher;
                default:
                    throw new NotImplementedException($"Can not get value on unimplemented type {domainResource.GetType().Name}");
            }
        }

        public static List<ContactDetail> GetContact(this DomainResource domainResource)
        {
            switch (domainResource)
            {
                case StructureDefinition sDef:
                    return sDef.Contact;
                case CodeSystem codeSys:
                    return codeSys.Contact;
                case ValueSet valueSet:
                    return valueSet.Contact;
                default:
                    throw new NotImplementedException($"Can not get value on unimplemented type {domainResource.GetType().Name}");
            }
        }

        public static String GetName(this DomainResource domainResource)
        {
            switch (domainResource)
            {
                case StructureDefinition sDef:
                    return sDef.Name;
                case CodeSystem codeSys:
                    return codeSys.Name;
                case ValueSet valueSet:
                    return valueSet.Name;
                default:
                    throw new NotImplementedException($"Can not get value on unimplemented type {domainResource.GetType().Name}");
            }
        }

    }
}
