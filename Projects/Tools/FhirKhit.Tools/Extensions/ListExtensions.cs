using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.Tools
{
    public static class ListExtensions
    {
        /// <summary>
        /// Remove the first element of a list and return it.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static T RemoveFirst<T>(this List<T> list)
            where T : class
        {
            if (list is null)
                throw new ArgumentNullException(nameof(list));

            if (list.Count == 0)
                return null;

            T retVal = list[0];
            list.RemoveAt(0);
            return retVal;
        }
    }
}
