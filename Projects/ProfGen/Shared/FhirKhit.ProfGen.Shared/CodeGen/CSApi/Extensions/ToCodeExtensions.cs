using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.ProfGen.Shared.CodeGen.CSApi.Extensions
{
    public static class ToCodeExtensions
    {
        //public static String ToCode(this CodeableConcept codeableConcept)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb
        //        .AppendLine($"new CodeableConcept")
        //        .AppendLine($"{{")
        //        .AppendLine($"Text = {codeableConcept.Text.ToCode()},")
        //        .AppendLine($"Text = {codeableConcept.Text.ToCode()},")
        //        .AppendLine($"}}")
        //        ;
        //}
        //public static String ToCode(this List<Coding> coding)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.AppendLine($"new Coding[] {{");
        //    if (coding.Count > 0)
        //    {
        //        sb.Append(coding.ToCode());
        //        for (Int32 i = 1; i < coding.Count; i++)
        //        {
        //            sb.AppendLine(",");
        //            sb.Append($"{coding.ToCode()}");
        //        }
        //    }
        //    sb.AppendLine("");
        //    sb.AppendLine($"}}");
        //    return sb.ToString();
        //}


        public static String ToCode(this Int32 i)
        {
            return i.ToString();
        }

        public static String ToCode(this Int32? i)
        {
            if (i.HasValue == false)
                return "null";
            return i.Value.ToString();
        }

        public static String ToCode(this Decimal i)
        {
            return i.ToString();
        }

        public static String ToCode(this Decimal? i)
        {
            if (i.HasValue == false)
                return "null";
            return i.Value.ToString();
        }

        public static String ToCode(this DateTimeOffset i)
        {
            if (i == null)
                return "null";
            return i.ToString();
        }

        public static String ToCode(this DateTimeOffset? i)
        {
            if (i.HasValue == false)
                return "null";
            return i.Value.ToString();
        }

        public static String ToCode(this FhirDateTime value)
        {
            if (value == null)
                return "null";
            return $"new FhirDateTime(\"{value.Value}\")";
        }

        public static String ToCode(this Coding value)
        {
            if (value == null)
                return "null";
            return $"new Coding({value.System.ToCode()}, {value.Code.ToCode()}, {value.Display.ToCode()}";
        }

        public static String ToCode(this Byte[] bytes)
        {
            if (bytes == null)
                return "null";
            StringBuilder sb = new StringBuilder();
            sb.Append("new Byte[] { ");
            if (bytes.Length > 0)
            {
                sb.Append(bytes[0].ToString());
                for (Int32 i = 1; i < bytes.Length; i++)
                    sb.Append($", bytes[0].ToString()");
            }
            sb.Append("} ");
            return sb.ToString();
        }

        public static String ToCode(this Boolean i)
        {
            return i.ToString();
        }

        public static String ToCode(this Boolean? i)
        {
            if (i.HasValue == false)
                return "null";
            return i.Value.ToString().ToLower();
        }
    }
}
