using FhirKhit.Tools;
using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.SliceGen.CSApi
{
    public static class CSMisc
    {
        public static String ValueFilterName(String[] path) => CSMisc.PathName("ValueFilter", path);

        public static String PathName(String prefix, String[] path)
        {
            if (path is null)
                throw new ArgumentNullException(nameof(path));

            StringBuilder sb = new StringBuilder();
            sb.Append(prefix);
            for (Int32 i = 1; i < path.Length; i++)
            {
                String pathPart = path[i].ToMachineName();
                sb.Append(pathPart);
            }
            return sb.ToString();
        }

        public static String[] MakePath(String subPath)
        {
            if (subPath is null)
                throw new ArgumentNullException(nameof(subPath));

            List<String> retVal = new List<string>();
            foreach (String pathPart in subPath.Split('.'))
            {
                foreach (String pathPart2 in pathPart.Split(':'))
                    retVal.Add(pathPart2);
            }
            return retVal.ToArray();
        }

        public static String[] MakePath(String[] basePath, String subPath)
        {
            List<String> retVal = new List<string>(basePath);
            retVal.AddRange(MakePath(subPath));
            return retVal.ToArray();
        }
    }
}
