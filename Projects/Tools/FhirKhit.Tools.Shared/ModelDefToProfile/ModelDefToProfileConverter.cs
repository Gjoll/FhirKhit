using Hl7.Fhir.Model;
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
    /// Converts ModelDef's to StructureDef's
    /// </summary>
    public class ModelDefToProfileConverter : ConverterBase
    {
        public FhirDateTime Date { get; set; } = new FhirDateTime(DateTimeOffset.Now);
        protected StructureDefinition outputProfile;
        protected List<ElementDefinition> sourceElements;
        protected List<ElementDefinition> targetElements;
        protected readonly ModelDefProject inputCache;
        protected readonly ModelDefProject outputCache;

        public ModelDefToProfileConverter(ModelDefProject inputCache,
            ModelDefProject outputCache)
        {
            this.inputCache = inputCache;
            this.outputCache = outputCache;
            this.outputCache.ProjectData = this.inputCache.ProjectData;
        }

        public bool MapAll()
        {
            this.ClearMessages();

            foreach (StructureDefinition modelDef in this.inputCache.GetModelDefinitions())
                this.MapModelDef(modelDef);

            foreach (StructureDefinition extension in this.inputCache.GetExtensions())
                this.outputCache.AddExtension(extension);

            foreach (ValueSet valueSet in this.inputCache.GetValueSets())
                this.outputCache.AddValueSet(valueSet);

            return this.Errors.Any() == false;
        }

        protected void MapModelDef(StructureDefinition modelDef)
        {
            const String fcn = "ModelDefToProfileConverter.MapModelDef";
            if (modelDef.Differential.Element.Count <= 1)
            {
                this.ConversionWarn(this.GetType().Name, fcn, $"ModelDef {modelDef.Name} has no elements and is being ignored");
                return;
            }

            StructureDefinitionMap sdMap = modelDef.GetModelDefToProfileMap();
            this.MapToProfile(modelDef, sdMap.BaseResourceName);
        }

        protected void MapToProfile(StructureDefinition modelDef, String fhirResourceName)
        {
            StructureDefinition sdef = ZipFhirSource.Source.ResolveByUri($"http://hl7.org/fhir/StructureDefinition/{fhirResourceName}") as StructureDefinition;
            foreach (ElementDefinition sourceElement in modelDef.Differential.Element)
            {
                sourceElement.ElementId = sourceElement.ElementId.ReplacePathBase(fhirResourceName);
                sourceElement.Path = sourceElement.Path.ReplacePathBase(fhirResourceName);
            }
            this.MapToProfile(modelDef, sdef);
        }

        /// <summary>
        /// Return global element definition maps.
        /// </summary>
        protected IEnumerable<GlobalElementDefinitionMap> GlobalMappings()
        {
            /*
             * Map all items that are of the same type and name from the source to the target
             */
            yield return new GlobalElementDefinitionMap(
                    new ElementDefinitionMatch("true"),
                    new ElementDefinitionMap(
                        new ElementDefinitionMatch("(target.path == source.path)"),
                        "Overwrite();",
                        "SNOMED",
                        "1000000",
                        "???")
                );
        }

        /// <summary>
        /// Perform all mappings that are globally defined.
        /// </summary>
        protected bool DoGlobalMapping(StructureDefinition modelDef,
            StructureDefinition fhirResource,
            ElementDefinition sourceElement)
        {
            const String fcn = "ModelDefToProfileConverter.DoGlobalMappings";

            foreach (GlobalElementDefinitionMap globalMap in this.GlobalMappings())
            {
                try
                {
                    if (this.DoGlobalMapping(modelDef, fhirResource, sourceElement, globalMap) == true)
                        return true;
                }
                catch (Exception e)
                {
                    StringBuilder sb = new StringBuilder();
                    sb
                        .AppendLine($"Global map failed '{e.Message}'")
                        .AppendLine($"    SourceElement '{sourceElement.Path}'")
                        .AppendLine($"    SourceMatch '{globalMap.SourceMatch.Filter}'")
                        .AppendLine($"    Map '{globalMap.Map.MapCommands}'")
                        .AppendLine($"    Target Filter'{globalMap.Map.TargetMatch.Filter}'")
                        ;
                    this.ConversionError(this.GetType().Name, fcn, sb.ToString());
                }
            }
            return false;
        }

        /// <summary>
        /// Perform all mappings that are globally defined.
        /// </summary>
        protected bool DoGlobalMapping(StructureDefinition modelDef,
            StructureDefinition fhirResource,
            ElementDefinition sourceElement,
            GlobalElementDefinitionMap globalMap)
        {
            const String fcn = "ModelDefToProfileConverter.DoGlobalMappings";
            if (globalMap.SourceMatch.IsAMatch(sourceElement, sourceElement) == false)
                return false;
            switch (globalMap.Map.TargetMatch.Filter)
            {
                case "Extension":
                    Log.Info(fcn,
                        $"Explicit map {sourceElement.Path}->ComplexExtension ['{globalMap.Map.MapCommands}']");
                    globalMap.Map.MapExtension(this.outputCache,
                        modelDef,
                        fhirResource,
                        this.outputProfile,
                        sourceElement,
                        this.Date);
                    this.sourceElements.Remove(sourceElement);
                    return true;

                default:
                    ElementDefinition targetMatch = globalMap.Map.MapElement(this.outputCache,
                        modelDef,
                        fhirResource,
                        this.outputProfile,
                        sourceElement,
                        this.targetElements,
                        this.Date);
                    if (targetMatch != null)
                    {
                        this.targetElements.Remove(targetMatch);
                        Log.Info(fcn,
                            $"Global map '{sourceElement.Path}' -> '{targetMatch.Path}' ['{globalMap.Map.MapCommands}']");
                        this.sourceElements.Remove(sourceElement);
                        return true;
                    }
                    break;
            }

            return false;
        }

        /// <summary>
        /// Perform all mappings that are explicitly defined in the source element definition.
        /// </summary>
        protected bool DoExplicitMapping(StructureDefinition modelDef,
            StructureDefinition fhirResource,
            ElementDefinition sourceElement,
            ElementDefinitionMap map)
        {
            const String fcn = "ModelDefToProfileConverter.DoExplicitMappings";
            try
            {
                if (map == null)
                    return false;
                switch (map.TargetMatch.Filter)
                {

                    // Map to seperate extensions.
                    case "Extension":
                        map.MapExtension(this.outputCache,
                            modelDef,
                            fhirResource,
                            this.outputProfile,
                            sourceElement,
                            this.Date);
                        Log.Info(fcn,
                            $"Explicit map {sourceElement.Path}->Extension ['{map.MapCommands}']");
                        break;

                    default:
                        ElementDefinition targetMatch = map.MapElement(this.outputCache,
                            modelDef,
                            fhirResource,
                            this.outputProfile,
                            sourceElement,
                            this.targetElements,
                            this.Date);
                        //this.targetElements.Remove(targetMatch);
                        Log.Info(fcn,
                            $"Explicit map {sourceElement.Path}->{targetMatch}.path ['{map.MapCommands}']");
                        break;
                }
                return true;
            }
            catch (Exception err)
            {
                this.ConversionError(this.GetType().Name, fcn, $"Error mapping '{sourceElement.Path}'\nMatch Filter: '{map.TargetMatch.Filter}'\nMap: {map.MapCommands}\n{err.Message}");
                return false;
            }
        }

        protected void PatchElementIds(StructureDefinition modelDef)
        {
            String idSuffix = modelDef.Name.ToLocalName();

            foreach (ElementDefinition e in modelDef.Differential.Element)
            {
                String id = e.ElementId;
                if (id != null)
                {
                    Int32 pIndex = id.IndexOf('.');

                    if (pIndex < 0)
                    {
                        e.ElementId = e.ElementId + $":{idSuffix}";
                    }
                    else
                    {
                        String start = id.Substring(0, pIndex);
                        String end = id.Substring(pIndex);
                        e.ElementId = $"{start}:{idSuffix}{end}";
                    }
                }
            }
        }
        protected void MapToProfile(StructureDefinition modelDef,
            StructureDefinition fhirResource)
        {
            const String fcn = "ModelDefToProfileConverter.MapToProfile";

            this.outputProfile = new StructureDefinition
            {
                Abstract = false,
                DateElement = this.Date,
                Description = modelDef.Description,
                Snapshot = null,
                Status = modelDef.Status,
                //Text = modelDef.Text,
                Url = modelDef.Url,
#if FHIR_R4
                BaseDefinition = fhirResource.Url,
                Derivation = StructureDefinition.TypeDerivationRule.Constraint,
                Title = modelDef.Title,
                Type = fhirResource.Type,
                Version = FhirKhitVersion.FhirVersion
#elif FHIR_R3
                BaseDefinition = fhirResource.Url,
                Derivation = StructureDefinition.TypeDerivationRule.Constraint,
                Differential = new StructureDefinition.DifferentialComponent(),
                Kind = StructureDefinition.StructureDefinitionKind.ComplexType,
                Title = modelDef.Title,
                Type = fhirResource.Name,
                Version = FhirKhitVersion.FhirVersion
#elif FHIR_R2
                Base = fhirResource.Url,
                //Derivation = StructureDefinition.TypeDerivationRule.Constraint,
                ConstrainedType = fhirResource.Name.ToFhirType(),
                //Title = modelDef.Title,
                //Type = fhirResource.Type,
                Version = FhirKhitVersion.FhirVersion
#endif
            };

            this.outputProfile
                .Init(modelDef.Id, modelDef.Name)
                ;
#if FHIR_R4
            this.outputProfile.FhirVersion = FhirKhitVersion.FhirVersionEnum;
#elif FHIR_R3
            this.outputProfile.FhirVersion = FhirKhitVersion.FhirVersion;
#elif FHIR_R2
            this.outputProfile.FhirVersion = FhirKhitVersion.FhirVersion;
#endif

            this.targetElements = fhirResource.Snapshot.Element.ToList();

            // Note: Source must have been flattened so differential contains all modified elements.
            this.sourceElements = modelDef.Differential.Element.ToList();

            foreach (ElementDefinition sourceElement in this.sourceElements.ToArray())
            {
                try
                {
                    ElementDefinitionMap map = sourceElement.GetMap();
                    if (
                        (this.DoExplicitMapping(modelDef, fhirResource, sourceElement, map)) ||
                        (this.DoGlobalMapping(modelDef, fhirResource, sourceElement))
                        )
                        this.sourceElements.Remove(sourceElement);

                }
                catch (Exception e)
                {
                    StringBuilder sb = new StringBuilder();
                    sb
                        .AppendLine($"Map failed '{e.Message}'")
                        .AppendLine($"    SourceElement '{sourceElement.Path}'")
                        ;
                    this.ConversionError(this.GetType().Name, fcn, sb.ToString());
                }
            }

            foreach (ElementDefinition sourceElement in this.sourceElements)
                this.ConversionError(this.GetType().Name, fcn, $"{sourceElement.Path} was not mapped to a target element");

#if FHIR_R4 || FHIR_R3
            this.PatchElementIds(this.outputProfile);
#endif
            this.outputCache.AddModelDef(this.outputProfile);
        }
    }
}
