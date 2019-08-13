using Hl7.Fhir.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

#if FHIR_R4
namespace FhirKhit.Tools.R4
#elif FHIR_R3
namespace FhirKhit.Tools.R3
#elif FHIR_R2
namespace FhirKhit.Tools.R2
#endif
{
    /// <summary>
    /// Mapping StructureDefinition from ModelDef to Fhir Profile
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, IsReference = false)]
    public class StructureDefinitionMap
    {
        /// <summary>
        /// Base FHIR resource that output profile is based on
        /// </summary>
        [JsonProperty("BaseResourceName")] public String BaseResourceName { get; set; }

        public StructureDefinitionMap(String baseResourceName)
        {
            this.BaseResourceName = baseResourceName;
        }

        public StructureDefinitionMap()
        {
        }
    }
}
