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
    /// Mapping ElementDefinition from ModelDef to Fhir Profile
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, IsReference = false)]
    public class ElementDefinitionMap
    {
        MapProcessor MapProcessor = new MapProcessor();

        /// <summary>
        /// Filters against ElementDefinition
        /// </summary>
        [JsonProperty("TargetMatch")] public ElementDefinitionMatch TargetMatch { get; set; }

        /// <summary>
        /// Field Terminology Source from modellabs.
        /// </summary>
        [JsonProperty("FieldTerminologySource")] public String FieldTerminologySource { get; set; }

        /// <summary>
        /// Field Terminology Source from modellabs.
        /// </summary>
        [JsonProperty("FieldTerminologyId")] public String FieldTerminologyId { get; set; }

        /// <summary>
        /// Field Terminology Display from modellabs.
        /// </summary>
        [JsonProperty("FieldTerminologyDisplay")] public String FieldTerminologyDisplay { get; set; }

        /// <summary>
        /// Mapping commands
        /// </summary>
        [JsonProperty("MapCommands")] public String MapCommands { get; set; }

        public ElementDefinitionMap(ElementDefinitionMatch targetMatch,
            String mapCommands,
            String fieldTerminologySource,
            String fieldTerminologyId,
            String fieldTerminologyDisplay)
        {
            this.TargetMatch = targetMatch;
            this.MapCommands = mapCommands;
            this.FieldTerminologyId = fieldTerminologyId;
            this.FieldTerminologySource = fieldTerminologySource;
            this.FieldTerminologyDisplay = fieldTerminologyDisplay;
        }

        public ElementDefinitionMap()
        {
        }

        /// <summary>
        /// Map to a simple extension
        /// </summary>
        /// <param name="modelDefCache"></param>
        /// <param name="sourceStructureDefinition"></param>
        /// <param name="targetStructureDefinition"></param>
        /// <param name="outputProfile"></param>
        /// <param name="sourceElement"></param>
        /// <param name="date"></param>
        public void MapExtension(ModelDefProject modelDefCache,
            StructureDefinition sourceStructureDefinition,
            StructureDefinition targetStructureDefinition,
            StructureDefinition outputProfile,
            ElementDefinition sourceElement,
            FhirDateTime date)
        {
            this.MapElementToTarget(modelDefCache,
                sourceStructureDefinition,
                targetStructureDefinition,
                outputProfile,
                sourceElement,
                null,
                date);
        }

        public ElementDefinition MapElement(ModelDefProject modelDefCache,
            StructureDefinition sourceStructureDefinition,
            StructureDefinition targetStructureDefinition,
            StructureDefinition outputProfile,
            ElementDefinition sourceElement,
            IEnumerable<ElementDefinition> targetElements,
            FhirDateTime date = null)
        {
            ElementDefinition[] targetMatches = this.TargetMatch.Process(sourceElement, targetElements).ToArray();
            switch (targetMatches.Length)
            {
                case 0:
                    return null;

                case 1:
                    {
                        ElementDefinition targetMatch = targetMatches[0];
                        this.MapElementToTarget(modelDefCache,
                            sourceStructureDefinition,
                            targetStructureDefinition,
                            outputProfile,
                            sourceElement,
                            targetMatch,
                            date);
                        return targetMatch;
                    }

                default:
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine($"Multiple targets match filter '{this.TargetMatch.Filter}'");
                        Int32 i = 0;
                        foreach (ElementDefinition targetMatch in targetMatches)
                            sb.AppendLine($"  {(++i).ToString()}. {targetMatch.Path}");

                        Log.Error("ElementDefinitionMap.Map", sb.ToString());
                        throw new Exception(sb.ToString());
                    }
            }
        }

        /// <summary>
        /// Map source element to target element.
        /// </summary>
        void MapElementToTarget(ModelDefProject modelDefCache,
            StructureDefinition sourceStructureDefinition,
            StructureDefinition targetStructureDefinition,
            StructureDefinition outputProfile,
            ElementDefinition sourceElement,
            ElementDefinition targetMatch,
            FhirDateTime date = null)
        {
            if (date == null)
                date = new FhirDateTime(DateTimeOffset.Now);
            if (this.MapCommands == null)
                return;

            this.MapProcessor.ExecuteMapCommands(modelDefCache,
                sourceStructureDefinition,
                targetStructureDefinition,
                outputProfile,
                sourceElement,
                targetMatch,
                this,
                date);
        }
    }
}
