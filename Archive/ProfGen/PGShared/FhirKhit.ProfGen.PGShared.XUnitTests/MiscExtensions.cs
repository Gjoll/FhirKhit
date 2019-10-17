using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace FhirKhit.ProfGen.XUnitTests
{
    internal static class MiscExtensions
    {
        public static void SetValueList<T>(this PropertyInfo pi, object target, params T[] items)
        {
            List<T> list = new List<T>(items);
            pi.SetValue(target, list);
        }
    }
}
