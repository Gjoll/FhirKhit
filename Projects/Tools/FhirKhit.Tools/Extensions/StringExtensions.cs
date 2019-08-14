using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FhirKhit.Tools
{
    public static class StringExtensions
    {
        /// <summary>
        /// Return the last part of a path (i.e. a.bb.ccc == 'ccc')
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static String ReplacePathBase(this String path, String newBase)
        {
            Int32 index = path.IndexOf('.');
            if (index < 0)
                return newBase;
            Int32 index2 = path.IndexOf(':');
            if ((index2 > 0) && (index2 < index))
                index = index2;
            return $"{newBase}{path.Substring(index)}";
        }

        /// <summary>
        /// Return the last part of an uri path (i.e. a.bb.ccc == 'ccc')
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static String LastUriPart(this String path)
        {
            Int32 index = path.LastIndexOf('/');
            if (index < 0)
                return path;
            return path.Substring(index+1);
        }

        /// <summary>
        /// Return the last part of a path (i.e. a.bb.ccc == 'ccc')
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static String LastPathPart(this String path)
        {
            String[] parts = path.Split('.');
            return parts.Last();
        }

        /// <summary>
        /// Create a period seperated string from an array of strings. (i.e. a.b.c)
        /// </summary>
        /// <param name="items"></param>
        /// <param name="start"></param>
        /// <returns></returns>
        public static String ToPath(this List<String> items, Int32 start = 0)
        {
            StringBuilder sb = new StringBuilder();
            if (items.Count > start)
            {
                sb.Append(items[start]);
                for (Int32 i = start + 1; i < items.Count; i++)
                    sb.Append($".{items[i]}");
            }
            return sb.ToString();
        }

        /// <summary>
        /// Compare two strings. Treat null and empty as same.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Int32 NullCompareTo(this String a, String b)
        {
            if (
                (string.IsNullOrEmpty(a) == true) &&
                (string.IsNullOrEmpty(b) == true)
                )
                return 0;
            return string.Compare(a, b);
        }

        public static String ResourceNameFromUri(this String uri) => uri.Substring(uri.LastIndexOf('/') + 1);

        public static String ToLocalName(this String value)
        {
            String retVal = value.ToMachineName();
            if (retVal.Length > 0)
                retVal = Char.ToLower(retVal[0]) + retVal.Substring(1);
            return retVal;
        }

        public static String ToMachineName(this String value)
        {
            StringBuilder sb = new StringBuilder();
            Boolean capFlag = true;
            foreach (Char c in value)
            {
                if (char.IsLetterOrDigit(c))
                {
                    if (capFlag == true)
                    {
                        sb.Append(char.ToUpper(c));
                        capFlag = false;
                    }
                    else
                    {
                        sb.Append(c);
                    }
                }
                else if (c == '_')
                {
                    sb.Append(c);
                    capFlag = false;
                }
                else
                    capFlag = true;
            }

            return sb.ToString();
        }

        public static String ValueOrDef(this String value, String defaultValue)
        {
            if (value != null)
                return value;
            return defaultValue;
        }

        public static String ValueOrError(this String value)
        {
            if (value == null)
                throw new Exception("Invalid value");
            return value;
        }

        public static String[] ToLines(this String value)
        {
            if (value == null)
                return new string[0];
            value = value.Replace("\r", "");
            if (value.EndsWith("\n"))
                value = value.Substring(0, value.Length - 1);
            return value.Split('\n');
        }
    }
}
