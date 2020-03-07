using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FhirKhit.Tools
{
    public static class StringExtensions
    {
        public static String ToMarkup(this String[] lines)
        {
            if (lines is null)
                throw new ArgumentNullException(nameof(lines));

            StringBuilder sb = new StringBuilder();
            foreach (String line in lines)
            {
                sb.AppendLine(line);
            }
            return sb.ToString();
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
        /// Return the last part of a path (i.e. a.bb.ccc == 'ccc')
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static String ReplacePathBase(this String path, String newBase)
        {
            if (path is null)
                throw new ArgumentNullException(nameof(path));

            Int32 index = path.IndexOf('.');
            if (index < 0)
                return newBase;
            Int32 index2 = path.IndexOf(':');
            if ((index2 > 0) && (index2 < index))
                index = index2;
            return $"{newBase}{path.Substring(index)}";
        }


        /// <summary>
        /// Convert string to integer
        /// </summary>
        public static Int32 ToMax(this String s)
        {
            if (s == "*")
                return Int32.MaxValue;
            return Int32.Parse(s);
        }

        /// <summary>
        /// Return the base uri part (uri - last element)
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
#pragma warning disable CA1055
        public static String BaseUriPart(this String path)
        {
            if (path is null)
                throw new ArgumentNullException(nameof(path));

            Int32 index = path.IndexOf('/');
            if (index < 0)
                return path;
            return path.Substring(0, index);
        }

        /// <summary>
        /// Return the last part of an uri path (i.e. a.bb.ccc == 'ccc')
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
#pragma warning disable CA1055
        public static String LastUriPart(this String path)
        {
            if (path is null)
                throw new ArgumentNullException(nameof(path));

            Int32 index = path.LastIndexOf('/');
            if (index < 0)
                return path;
            return path.Substring(index + 1);
        }

        /// <summary>
        /// Return the path skipping everything up to and including the first '.'
        /// </summary>
        public static String SkipFirstPathPart(this String path)
        {
            if (path is null)
                throw new ArgumentNullException(nameof(path));
            Int32 index = path.IndexOf('.') + 1;
            return path.Substring(index);
        }

        /// <summary>
        /// Return the first part of a path (i.e. a.bb.ccc == 'a')
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static String FirstPathPart(this String path)
        {
            if (path is null)
                throw new ArgumentNullException(nameof(path));
            String[] parts = path.Split('.');
            return parts.First();
        }

        /// <summary>
        /// Return the last part of a path (i.e. a.bb.ccc == 'ccc')
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static String LastPathPart(this String path)
        {
            if (path is null)
                throw new ArgumentNullException(nameof(path));
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
            if (items is null)
                throw new ArgumentNullException(nameof(items));

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

        public static String ResourceNameFromUri(this String uri)
        {
            if (uri is null)
                throw new ArgumentNullException(nameof(uri));
            return uri.Substring(uri.LastIndexOf('/') + 1);
        }

        public static String ToLocalName(this String value)
        {
            String retVal = value.ToMachineName();
            if (retVal.Length > 0)
                retVal = Char.ToLower(retVal[0]) + retVal.Substring(1);
            return retVal;
        }

        public static String ToMachineName(this String value)
        {
            if (value is null)
                throw new ArgumentNullException(nameof(value));

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


        public static String[] ToArgs(this String value)
        {
            if (value is null)
                throw new ArgumentNullException(nameof(value));

            List<String> args = new List<string>();

            bool parenFlag = false;
            StringBuilder sb = new StringBuilder();
            foreach (Char c in value)
            {
                switch (c)
                {
                    case '\t':
                    case '\r':
                    case '\n':
                    case ' ':
                        if (parenFlag == false)
                        {
                            if (sb.Length > 0)
                                args.Add(sb.ToString());
                            sb.Clear();
                        }
                        else
                        {
                            sb.Append(c);
                        }
                        break;

                    case '"':
                        sb.Append(c);
                        parenFlag = !parenFlag;
                        break;

                    default:
                        sb.Append(c);
                        break;
                }
            }

            if (sb.Length > 0)
                args.Add(sb.ToString());
            return args.ToArray();
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
                return Array.Empty<string>();
            value = value.Replace("\r", "");
            if (value.EndsWith("\n"))
                value = value.Substring(0, value.Length - 1);
            return value.Split('\n');
        }


        public static String RemoveSliceNames(this String value)
        {
            while (true)
            {
                Int32 startIndex = value.IndexOf(':');
                if (startIndex < 0)
                    return value;
                String start = value.Substring(0, startIndex);
                String end = value.Substring(startIndex);
                Int32 endIndex = end.IndexOf('.');
                if (endIndex < 0)
                    endIndex = value.Length;
                return start + end.Substring(endIndex);
            }
        }
    }
}
