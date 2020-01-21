using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

#if FHIR_R4
namespace FhirKhit.Tools.R4
#elif FHIR_R3
namespace FhirKhit.Tools.R3
#endif
{
    static class Compare
    {
        public static bool? ClearIfSame(bool? itemBase, bool? itemMod)
        {
            if ((itemBase.HasValue == false) || (itemMod.HasValue == false))
            {
                if ((itemBase.HasValue == false) && (itemMod.HasValue == false))
                    return null;
                return itemMod;
            }
            if (itemBase.Value == itemMod.Value)
                return null;
            return itemMod;
        }

        public static String ClearIfSame(String itemBase, String itemMod)
        {
            if ((itemBase == null) || (itemMod == null))
            {
                if ((itemBase == null) && (itemMod == null))
                    return null;
                return itemMod;
            }

            if (itemBase == itemMod)
                return null;
            return itemMod;
        }

        public static T ClearIfSame<T>(T itemBase, T itemMod)
            where T : class, IDeepComparable
        {
            if ((itemBase == null) || (itemMod == null))
            {
                if ((itemBase == null) && (itemMod == null))
                    return null;
                return itemMod;
            }

            if (itemBase.IsExactly(itemMod) == true)
                return null;
            return itemMod;
        }

        public static List<T> ClearIfSame<T>(List<T> itemBase, List<T> itemMod)
            where T : class, IDeepComparable
        {
            if ((itemBase == null) || (itemMod == null))
            {
                if ((itemBase == null) && (itemMod == null))
                    return new List<T>();
                return itemMod;
            }
            if (itemBase.IsExactly(itemMod) == true)
                return new List<T>();
            return itemMod;
        }
    }
}
