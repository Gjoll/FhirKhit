using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.ProfGen.PGShared
{
    /// <summary>
    /// Extension methods that operate on element definitions 
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// Return path with added slice name.
        /// </summary>
        /// <param name="elementDefinition"></param>
        /// <returns></returns>
        public static String FullPath(this ElementDefinition elementDefinition)
        {
            if (elementDefinition is null)
                throw new ArgumentNullException(nameof(elementDefinition));

            String name = elementDefinition.Path;
            if (String.IsNullOrEmpty(elementDefinition.SliceName) == false)
                name += $":{elementDefinition.SliceName}";
            return name;
        }

        /// <summary>
        /// Add items to element definition dictionary
        /// </summary>
        /// <param name="dict"></param>
        /// <param name="elements"></param>
        public static void Add(this Dictionary<String, ElementDefinition> dict, IEnumerable<ElementDefinition> elements)
        {
            if (dict is null)
                throw new ArgumentNullException(nameof(dict));
            if (elements == null)
                return ;

            foreach (ElementDefinition element in elements)
                dict.Add(element.FullPath(), element);
        }
    }
}
