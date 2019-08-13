using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
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
    /// Flattens a ModelDef.
    /// </summary>
    public class ModelDefFlattener : ConverterBase
    {
        protected readonly ModelDefProject inputModels;
        protected readonly ModelDefProject outputModels;

        public ModelDefFlattener(ModelDefProject inputModels,
            ModelDefProject outputModels)
        {
            this.inputModels = inputModels;
            this.outputModels = outputModels;
        }

        /// <summary>
        /// Flatten each model def in modelDefs and replace old item with new
        /// flattened one.
        /// </summary>
        /// <param name="modelDefProject"></param>
        public bool Flatten()
        {
            const String fcn = "ModelDefFlattener.Flatten";

            this.ClearMessages();

            foreach (StructureDefinition modelDef in inputModels.GetModelDefinitions().ToArray())
            {
                switch (modelDef.GetSectionPurpose())
                {
                    case FhirExtendableExtensions.SectionPurporseEnums.CompositionTarget:
                        break;

                    case FhirExtendableExtensions.SectionPurporseEnums.Profile:
                        StructureDefinition flattened = this.Flatten(modelDef);
                        FixNames(flattened, modelDef.Differential.Element[0].Path);
                        if (flattened != null)
                            outputModels.AddModelDef(flattened);
                        break;

                    default:
                        this.ConversionError(this.GetType().Name, fcn, $"Unexpected Section Purpose ({modelDef.GetSectionPurpose()})");
                        break;
                }
            }

            return this.Errors.Any() == false;
        }

        StructureDefinition Flatten(StructureDefinition modelDef)
        {
            const String fcn = "ModelDefFlattener.Flatten";

            try
            {
                StructureDefinition outputStructDef = new StructureDefinition();
                String fhirBaseResource = null;
                this.Merge(modelDef, outputStructDef, ref fhirBaseResource);
#if FHIR_R4
                outputStructDef.Derivation = StructureDefinition.TypeDerivationRule.Specialization;
#elif FHIR_R3
                outputStructDef.Derivation = StructureDefinition.TypeDerivationRule.Specialization;
#elif FHIR_R2
#endif
                return outputStructDef;
            }
            catch (Exception err)
            {
                this.ConversionError(this.GetType().Name, fcn, err.Message);
            }

            return null;
        }

        void Merge(StructureDefinition modelDef,
            StructureDefinition outputStructDef,
            ref String fhirBaseResource)
        {
#if FHIR_R4
            String baseDefinition = modelDef.BaseDefinition;
#elif FHIR_R3
            String baseDefinition = modelDef.BaseDefinition;
#elif FHIR_R2
            String baseDefinition = modelDef.Base;
#endif

            if (string.IsNullOrWhiteSpace(baseDefinition) == false)
            {
                if (baseDefinition.ToLower().StartsWith("http://hl7.org/fhir/structuredefinition") == false)
                {
#if FHIR_R4 || FHIR_R3
                    if (ModelDefBases.FindModelByUrl(modelDef.BaseDefinition, out StructureDefinition baseModelDef) == false)
                        throw new Exception($"Model Definition {modelDef.BaseDefinition} not found in base cache");
#elif FHIR_R2
                    if (ModelDefBases.FindModelByUrl(modelDef.Base, out StructureDefinition baseModelDef) == false)
                        throw new Exception($"Model Definition {modelDef.Base} not found in base cache");
#endif
                    this.Merge(baseModelDef, outputStructDef, ref fhirBaseResource);
                }
                else
                    fhirBaseResource = baseDefinition;
            }

            this.MergeStructDefs(modelDef, outputStructDef);
        }

        void FixNames(StructureDefinition flattened, String baseName)
        {
            foreach (ElementDefinition sourceElement in flattened.Differential.Element)
            {
                sourceElement.ElementId = sourceElement.ElementId.ReplacePathBase(baseName);
                sourceElement.Path = sourceElement.Path.ReplacePathBase(baseName);
            }
        }
        protected void MergeCompositionTargetElements(ElementDefinition sourceElement,
            StructureDefinition target,
            ElementDictionary targetElements)
        {
            const String fcn = "ModelDefFlattener.MergeCompositionTargetElements";
#if FHIR_R2
            String targetUrl = sourceElement.Type[0].Profile.First();
#elif FHIR_R3
            String targetUrl = sourceElement.Type[0].Profile;
#elif FHIR_R4
            String targetUrl = sourceElement.Type[0].Profile.First();
#endif
            if (this.inputModels.FindModelByUrl(targetUrl, out StructureDefinition compositionTarget) == false)
            {
                this.ConversionError(this.GetType().Name, fcn, $"Can not find composistion target ({targetUrl})");
                return;
            }

            foreach (ElementDefinition compositionElement in compositionTarget.Differential.Element.Skip(1))
            {
                ElementDefinition targetElement = new ElementDefinition();
                targetElement.Path = compositionElement.Path;
                targetElement.ElementId = compositionElement.ElementId;
                target.Differential.Element.Add(targetElement);
                targetElements.Add(targetElement);
                MergeElementDefiniton(compositionElement, target, targetElement);
            }
        }

        protected void MergeElementDefinitons(ElementDefinition sourceElement,
            StructureDefinition target,
            ElementDictionary targetElements)
        {
            if (targetElements.TryFindMatch(sourceElement, out ElementDefinition targetElement) == false)
            {
                targetElement = new ElementDefinition();
                targetElement.Path = sourceElement.Path;
                targetElement.ElementId = sourceElement.ElementId;
                target.Differential.Element.Add(targetElement);
                targetElements.Add(targetElement);
            }
            MergeElementDefiniton(sourceElement, target, targetElement);
        }

        protected void MergeElementDefiniton(ElementDefinition sourceElement,
            StructureDefinition target,
            ElementDefinition targetElement)
        {
            Type elementType = sourceElement.GetType();
            foreach (PropertyInfo elementTypeProperty in elementType.GetProperties())
            {
                MethodInfo getElementDefinitionMethod = elementTypeProperty.GetGetMethod();
                MethodInfo setElementDefinitionMethod = elementTypeProperty.GetSetMethod();
                Object resultElementDefinition = getElementDefinitionMethod.Invoke(sourceElement, null);
                switch (resultElementDefinition)
                {
                    case null:
                        break;

                    default:
                        if (setElementDefinitionMethod != null)
                            setElementDefinitionMethod.Invoke(targetElement, new[] { resultElementDefinition });
                        break;
                }
            }
        }

        protected void MergeStructDefs(StructureDefinition source, StructureDefinition target)
        {
            // const String fcn = "ModelDefFlattener.MergeStructDefs";

            Type sourceStructureType = source.GetType();
            PropertyInfo[] sourceProperties = sourceStructureType.GetProperties().ToArray();

            ElementDictionary targetElements = new ElementDictionary(target?.Differential?.Element);

            foreach (PropertyInfo sourceProperty in sourceProperties)
            {
                MethodInfo getSourcePropertyMethod = sourceProperty.GetGetMethod();
                MethodInfo setSourcePropertyMethod = sourceProperty.GetSetMethod();
                Object result = getSourcePropertyMethod.Invoke(source, null);
                switch (result)
                {
                    case null:
                        break;

                    case StructureDefinition.DifferentialComponent differentialComponent:
                        if (target.Differential == null)
                            target.Differential = new StructureDefinition.DifferentialComponent();
                        foreach (ElementDefinition sourceElement in source.Differential.Element)
                        {
                            switch (sourceElement.GetComposable())
                            {
                                case FhirExtendableExtensions.ComposableEnums.Flatten:
                                    this.MergeCompositionTargetElements(sourceElement, target, targetElements);
                                    break;

                                case FhirExtendableExtensions.ComposableEnums.None:
                                    this.MergeElementDefinitons(sourceElement, target, targetElements);
                                    break;

                                default:
                                    throw new NotImplementedException($"Invalid Composable value {sourceElement.GetComposable()}");
                            }
                        }
                        break;

                    case StructureDefinition.SnapshotComponent snapshotComponent:
                        break;

                    default:
                        if (setSourcePropertyMethod != null)
                            setSourcePropertyMethod.Invoke(target, new[] { result });
                        break;
                }
            }
        }

        protected List<T> Merge<T>(List<T> source, List<T> target)
        where T : Element
        {
            if (source != null)
                return source;
            return target;
        }

        protected T Merge<T>(T source, T target)
            where T : Element
        {
            if (source != null)
                return source;
            return target;
        }
    }
}
