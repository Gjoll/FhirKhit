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
            if (sDef.Abstract == false)
                return false;
            if (sDef.BaseDefinition != "http://hl7.org/fhir/StructureDefinition/Resource")
                return false;
            if (sDef.Type != "Resource")
                return false;
            if (sDef.Kind != StructureDefinition.StructureDefinitionKind.Logical)
                return false;
            return true;
        }
    }
}
