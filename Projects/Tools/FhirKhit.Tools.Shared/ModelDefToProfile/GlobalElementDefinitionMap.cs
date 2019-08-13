using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Converters;
using System.Text.RegularExpressions;
using Hl7.Fhir.Model;

#if FHIR_R4
namespace FhirKhit.Tools.R4
#elif FHIR_R3
namespace FhirKhit.Tools.R3
#elif FHIR_R2
namespace FhirKhit.Tools.R2
#endif
{
    /// <summary>
    /// Mapping from ModelDef to Fhir Profile
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, IsReference = false)]
    public class GlobalElementDefinitionMap
    {
        /// <summary>
        /// Filters against ElementDefinition for source elements for this map 
        /// </summary>
        [JsonProperty("SourceMatch")] public ElementDefinitionMatch SourceMatch{ get; set; }

        /// <summary>
        /// Map
        /// </summary>
        [JsonProperty("Map")] public ElementDefinitionMap Map { get; set; }

        public GlobalElementDefinitionMap(ElementDefinitionMatch sourceMatch,
            ElementDefinitionMap map)
        {
            this.SourceMatch = sourceMatch;
            this.Map = map;
        }

        public GlobalElementDefinitionMap()
        {
        }
    }
}
