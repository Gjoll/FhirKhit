using FhirKhit.Tools;
using Hl7.Fhir.Introspection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace FhirKhit.SliceGen.R4
{
    public static class TypeExtensions
    {
        private static string GetFriendlyNameOfPointerType(this Type type) =>
            type.GetElementType().FriendlyName() + "*";

        public static PropertyInfo GetPropertyByFhirName(this Type fhirType,
            String fhirName)
        {
            if (fhirType is null)
                throw new ArgumentNullException(nameof(fhirType));

            foreach (PropertyInfo pi in fhirType.GetProperties())
            {
                FhirElementAttribute attribute = pi.GetCustomAttribute<FhirElementAttribute>();
                if (attribute != null)
                {
                    if (attribute.Name == fhirName)
                        return pi;
                }
            }
            return null;
        }
    }
}