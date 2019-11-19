using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PreFhir
{
    public static class StructureDefinitionExtensions
    {
        public static ElementDefinition FindElement(this IEnumerable<ElementDefinition> elements, String path)
        {
            foreach (ElementDefinition e in elements)
            {
                if (e.Path == path)
                    return e;
            }

            return null;
        }

        public static bool IsExactly<T>(this IEnumerable<T> thisList, IEnumerable<T> otherList)
            where T : IDeepComparable
        {
            if (thisList.Count() != otherList.Count())
                return false;

            IEnumerator<T> thisEnum = thisList.GetEnumerator();
            IEnumerator<T> otherEnum = otherList.GetEnumerator();
            for (Int32 i = 0; i < thisList.Count(); i++)
            {
                thisEnum.MoveNext();
                otherEnum.MoveNext();
                if (thisEnum.Current.IsExactly(otherEnum.Current) == false)
                    return false;
            }

            return true;
        }

        public static bool IsFragment(this StructureDefinition sDef)
        {
            Extension e = sDef.GetExtension(PreFhirGenerator.IsFragmentUrl);
            if (e == null)
                return false;
            FhirBoolean b = (FhirBoolean)e.Value;
            if (b.Value.HasValue == false)
                return false;
            return b.Value.Value;
        }
    }
}
