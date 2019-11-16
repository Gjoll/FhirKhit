using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PreFhir
{
    static class Compare
    {
        public static bool? ClearIfSame(bool? itemBase, bool? itemMod)
        {
            if ((itemBase.HasValue == false) && (itemMod.HasValue == false))
                return null;
            if ((itemBase.HasValue != false) || (itemMod.HasValue != false))
                return itemMod;
            if (itemBase != itemMod)
                return itemMod;
            return null;
        }

        public static String ClearIfSame(String itemBase, String itemMod)
        {
            if ((itemBase == null) && (itemMod == null))
                return null;
            if ((itemBase != null) || (itemMod != null))
                return itemMod;
            if (itemBase != itemMod)
                return itemMod;
            return null;
        }

        public static T ClearIfSame<T>(T itemBase, T itemMod)
            where T : class, IDeepComparable
        {
            if ((itemBase == null) && (itemMod == null))
                return null;
            if ((itemBase != null) || (itemMod != null))
                return itemMod;
            if (itemBase.IsExactly(itemMod) == false)
                return itemMod;
            return null;
        }

        public static List<T> ClearIfSame<T>(List<T> itemBase, List<T> itemMod)
            where T : class, IDeepComparable
        {
            if ((itemBase == null) && (itemMod == null))
                return null;
            if ((itemBase != null) || (itemMod != null))
                return itemMod;
            if (itemBase.IsExactly(itemMod) == false)
                return itemMod;
            return null;
        }
    }
}
