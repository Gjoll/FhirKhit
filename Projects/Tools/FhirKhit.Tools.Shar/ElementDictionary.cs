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
    public class ElementDictionary
    {
        Dictionary<String, ElementDefinition> elementDictionary;

        /// <summary>
        /// Make dictionary by path. Ignore first part of path, as that is different for each resource.
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public ElementDictionary(IEnumerable<ElementDefinition> definitions)
        {
            this.elementDictionary = new Dictionary<String, ElementDefinition>();
            if (definitions != null)
                foreach (ElementDefinition e in definitions)
                    this.Add(e);
        }

        /// <summary>
        /// Get part of path that is not specific to resource (i.e. skip all up to and including first '.');
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        static String UniquePath(ElementDefinition e)
        {
            Int32 periodIndex = e.Path.IndexOf('.');
            if (periodIndex <= 0)
                return "";
            return e.Path.Substring(periodIndex);
        }

        /// <summary>
        /// Fine element definition with same path (except for first part)
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public void Add(ElementDefinition e)
        {
            if (e is null)
                throw new ArgumentNullException(nameof(e));
            String path = ElementDictionary.UniquePath(e);
            if (path == null)
                throw new Exception($"Invalid path for elemend {e.ElementId}");

            elementDictionary.Add(path, e);
        }

        /// <summary>
        /// Fine element definition with same path (except for first part)
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public bool TryFindMatch(ElementDefinition e, out ElementDefinition match)
        {
            if (e is null)
                throw new ArgumentNullException(nameof(e));
            String uniquePath = ElementDictionary.UniquePath(e);
            return this.elementDictionary.TryGetValue(uniquePath, out match);
        }
    }
}
