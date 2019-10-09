using FhirKhit.ProfGen.PGShared.CodeGen.CSApi.Extensions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace FhirKhit.ProfGen.PGShared
{
    public static class TypeExtensions
    {
        private static Dictionary<Type, string> m_TypesToFriendlyNames = new Dictionary<Type, string>
        {
            {typeof(bool), "bool"},
            {typeof(byte), "byte"},
            {typeof(sbyte), "sbyte"},
            {typeof(char), "char"},
            {typeof(decimal), "decimal"},
            {typeof(double), "double"},
            {typeof(float), "float"},
            {typeof(int), "int"},
            {typeof(uint), "uint"},
            {typeof(long), "long"},
            {typeof(ulong), "ulong"},
            {typeof(object), "object"},
            {typeof(short), "short"},
            {typeof(ushort), "ushort"},
            {typeof(string), "string"}
        };

        static String CleanName(String name)
        {
            name = name
                .RemovePrefix("Hl7.Fhir.Model.")
            ;
            return name;
        }

        public static string FriendlyName(this Type type)
        {
            if (type is null)
                throw new ArgumentNullException(nameof(type));

            if (type.IsArray)
                return type.GetFriendlyNameOfArrayType();
            if (type.IsGenericType)
                return type.GetFriendlyNameOfGenericType();
            if (type.IsPointer)
                return type.GetFriendlyNameOfPointerType();
            var aliasName = default(string);
            if (m_TypesToFriendlyNames.TryGetValue(type, out aliasName))
                return aliasName;
            String name = CleanName(type.Name);
            if (type.DeclaringType == null)
                return name;

            String declaringName = FriendlyName(type.DeclaringType);
            return $"{declaringName}.{name}";
        }

        private static string GetFriendlyNameOfArrayType(this Type type)
        {
            var arrayMarker = string.Empty;
            while (type.IsArray)
            {
                var commas = new string(Enumerable.Repeat(',', type.GetArrayRank() - 1).ToArray());
                arrayMarker += $"[{commas}]";
                type = type.GetElementType();
            }
            return type.FriendlyName() + arrayMarker;
        }

        private static string GetFriendlyNameOfGenericType(this Type type)
        {
            if (type.GetGenericTypeDefinition() == typeof(Nullable<>))
                return type.GetGenericArguments().First().FriendlyName() + "?";
            var friendlyName = type.Name;
            var indexOfBacktick = friendlyName.IndexOf('`');
            if (indexOfBacktick > 0)
                friendlyName = friendlyName.Remove(indexOfBacktick);
            var typeParameterNames = type
                .GetGenericArguments()
                .Select(typeParameter => typeParameter.FriendlyName());
            var joinedTypeParameters = string.Join(", ", typeParameterNames);
            return string.Format("{0}<{1}>", friendlyName, joinedTypeParameters);
        }

        private static string GetFriendlyNameOfPointerType(this Type type) =>
            type.GetElementType().FriendlyName() + "*";
    }
}