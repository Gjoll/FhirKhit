using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Converters;
using System.Text.RegularExpressions;
using Hl7.Fhir.Model;
using System.Diagnostics;

#if FHIR_R4
namespace FhirKhit.Tools.R4
#elif FHIR_R3
namespace FhirKhit.Tools.R3
#elif FHIR_R2
namespace FhirKhit.Tools.R2
#endif
{
    /// <summary>
    /// Create a filter that performs a success/fail match on an ElementDefinition.
    /// Each filter item is a regular expression
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, IsReference = false)]
    public class ElementDefinitionMatch
    {
        /// <summary>
        /// Commands to filter
        /// </summary>
        [JsonProperty("Filter")] public string Filter { get; set; }

        public ElementDefinitionMatch(String filter)
        {
            this.Filter = filter;
        }

        public ElementDefinitionMatch()
        {

        }

        /// <summary>
        /// Return the element definitions that match.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ElementDefinition> Process(ElementDefinition source, IEnumerable<ElementDefinition> elementDefinitions)
        {
            foreach (ElementDefinition elementDefinition in elementDefinitions)
            {
                if (this.IsAMatch(source, elementDefinition))
                    yield return elementDefinition;
            }
        }

        /// <summary>
        /// Return true if element definition matches.
        /// </summary>
        /// <returns></returns>
        public bool IsAMatch(ElementDefinition source,
            ElementDefinition target)
        {
            if (this.Filter == null)
                return false;
            MatchProcessor matchProcessor = new MatchProcessor();
            return matchProcessor.Compare(source, target, this.Filter);
        }

        String Format(String s)
        {
            s = s.Insert(0, "^");
            s = s.Insert(s.Length, "$");
            return s;
        }

        private Regex CreateEx(String regExText, ref Regex regExItem)
        {
            if (regExItem == null)
            {
                if (regExText == null)
                    return null;
                regExItem = new Regex(regExText, RegexOptions.Compiled | RegexOptions.Singleline);
            }
            return regExItem;
        }

        public override String ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Filter '{this.Filter}' ");
            return sb.ToString();
        }
    }
}
