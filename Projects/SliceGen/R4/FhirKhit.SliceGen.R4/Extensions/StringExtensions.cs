using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.SliceGen.R4
{
    public static class StringExtensions
    {
        public static String ToCode(this String s)
        {
            if (s == null)
                return "null";
            return $"\"{s}\"";
        }

        public static String RemovePrefix(this String s, string prefix)
        {
            if (s is null)
                throw new ArgumentNullException(nameof(s));
            if (prefix is null)
                throw new ArgumentNullException(nameof(prefix));

            if (s.StartsWith(prefix))
                s = s.Substring(prefix.Length);
            return s;
        }

        public static String RemoveSuffix(this String s, string suffix)
        {
            if (s is null)
                throw new ArgumentNullException(nameof(s));
            if (suffix is null)
                throw new ArgumentNullException(nameof(suffix));

            if (s.EndsWith(suffix))
                s = s.Substring(0, s.Length - suffix.Length);
            return s;
        }

        public static String UncapFirstLetter(this String s)
        {
            if (s is null)
                throw new ArgumentNullException(nameof(s));
            switch (s.Length)
            {
                case 0: return String.Empty;
                case 1: return Char.ToLower(s[0]).ToString();
                default: return Char.ToLower(s[0]) + s.Substring(1);
            }
        }

        public static String CapFirstLetter(this String s)
        {
            if (s is null)
                throw new ArgumentNullException(nameof(s));
            switch (s.Length)
            {
                case 0: return String.Empty;
                case 1: return Char.ToUpper(s[0]).ToString();
                default: return Char.ToUpper(s[0]) + s.Substring(1);
            }
        }

        /// <summary>
        /// Convert a uri to a value set to the enum name defined in the c# api.
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static String ToValueSetEnumName(this String s)
        {
            if (s is null)
                throw new ArgumentNullException(nameof(s));
            Int32 index = s.LastIndexOf('/');
            String name = s.Substring(index + 1);
            name = $"{Char.ToUpper(name[0])}{name.Substring(1)}";
            index = name.LastIndexOf('|');
            if (index >= 0)
                name = name.Substring(0, index);

            while (true)
            {
                Int32 i = name.IndexOfAny(new char[] { ' ', '-', '_' });
                if (i < 0)
                    break;
                String firstPart = name.Substring(0, i);
                String secondPart = name.Substring(i + 1, name.Length - i - 1);
                name = firstPart + secondPart.CapFirstLetter();
            }

            return name;
        }

        public static String CleanName(this String s)
        {
            if (s is null)
                throw new ArgumentNullException(nameof(s));
            {
                Int32 openBraceIndex = s.IndexOf("[");
                if (openBraceIndex >= 0)
                {
                    Int32 closeBraceIndex = s.IndexOf("]");
                    if (closeBraceIndex != s.Length - 1)
                        throw new Exception($"Missing or misplaced ']' in name");
                    s = s.Substring(0, openBraceIndex);
                }
            }
            while (true)
            {
                Int32 i = s.IndexOfAny(new char[] { ' ', '-'});
                if (i < 0)
                    break;
                String firstPart = s.Substring(0, i);
                String secondPart = s.Substring(i + 1, s.Length - i - 1);
                s = firstPart + secondPart.CapFirstLetter();
            }

            return s;
        }

        public static String FormatPropertyName(this String s) => s.CapFirstLetter().CleanName();

        public static String FormatFieldName(this String s) => $"_{s.UncapFirstLetter().CleanName()}";

        public static String FormatClassName(this String s) => $"{s.CapFirstLetter().CleanName()}";

        public static Int32 MaxValue(this string value, Int32 defaultValue)
        {
            switch (value)
            {
                case null:
                case "":
                    return defaultValue;

                case "*":
                    return Int32.MaxValue;

                default:
                    return Int32.Parse(value);
            }

        }

    }
}
