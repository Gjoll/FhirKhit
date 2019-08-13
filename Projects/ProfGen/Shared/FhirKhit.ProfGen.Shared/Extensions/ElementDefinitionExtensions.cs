using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.ProfGen.Shared
{
    /// <summary>
    /// Extension methods that operate on element definitions 
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// Return path with added slice name.
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public static String FullPath(this ElementDefinition element)
        {
            String name = element.Path;
            if (String.IsNullOrEmpty(element.SliceName) == false)
                name += $":{element.SliceName}";
            return name;
        }

        /// <summary>
        /// Add items to element definition dictionary
        /// </summary>
        /// <param name="dict"></param>
        /// <param name="elements"></param>
        public static void Add(this Dictionary<String, ElementDefinition> dict, IEnumerable<ElementDefinition> elements)
        {
            if (elements == null)
                return ;

            foreach (ElementDefinition element in elements)
                dict.Add(element.FullPath(), element);
        }
    }
}
