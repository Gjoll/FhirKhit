using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

#if FHIR_R4
namespace FhirKhit.Tools.R4
#elif FHIR_R3
namespace FhirKhit.Tools.R3
#endif
{
    public static class Misc
    {
        public static bool IsEmpty<T>(this T? s)
        where T : struct
        {
            return s.HasValue == false;
        }

        public static bool IsEmpty(this String s)
        {
            return String.IsNullOrEmpty(s);
        }

        public static bool IsEmpty<T>(this IList<T> list)
        {
            if (list == null)
                return true;
            if (list.Count == 0)
                return true;
            return false;
        }
    }
}
