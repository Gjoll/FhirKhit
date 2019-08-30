using Hl7.Fhir.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

#if FHIR_R4
namespace FhirKhit.Tools.R4
#elif FHIR_R3
namespace FhirKhit.Tools.R3
#elif FHIR_R2
namespace FhirKhit.Tools.R2
#endif
{
    public static class FhirStructureDefinitionExtensions
    {
        /// <summary>
        /// Get all value set bindings in structure definition.
        /// </summary>
        //public static IEnumerable<Uri> GetBoundValueSets(this StructureDefinition structureDefinition)

        /// <summary>
        /// Get all value set bindings in structure definition.
        /// </summary>
        public static IEnumerable<Uri> GetBoundValueSets(this StructureDefinition sDef)
        {
            if (sDef is null)
                throw new ArgumentNullException(nameof(sDef ));


            foreach (ElementDefinition elementDefinition in sDef.Differential.Element)
            {
                switch (elementDefinition.Binding?.ValueSet)
                {
#if FHIR_R4
                    case String canonicalUrl:
                        yield return new Uri(canonicalUrl);
#elif FHIR_R2 || FHIR_R3
                    case FhirString canonicalUrl:
                        yield return new Uri(canonicalUrl.Value);
#else           // default
                Invalid fhir type
#endif
                        break;

                    case null:
                        break;

                    default:
                        throw new NotImplementedException($"Unknown elementDefinition.Binding.ValueSet type {elementDefinition.Binding.ValueSet.GetType()}");
                }
            }
        }

        public static ElementDefinition AddSnapElement(this StructureDefinition sDef,
            String id,
            String propertyPath)
        {
            if (sDef is null)
                throw new ArgumentNullException(nameof(sDef ));

            ElementDefinition retVal = new ElementDefinition
            {
                ElementId = id,
                Min = 0,
                Max = "1",
                Path = propertyPath,
                Type = new List<ElementDefinition.TypeRefComponent>()
            };
            sDef.AddSnapElement(retVal);
            return retVal;
        }

        public static void AddSnapElement(this StructureDefinition sDef, ElementDefinition elementDefinition)
        {
            if (sDef is null)
                throw new ArgumentNullException(nameof(sDef ));

            if (sDef.Snapshot == null)
                sDef.Snapshot = new StructureDefinition.SnapshotComponent();
            sDef.Snapshot.Element.Add(elementDefinition);
        }

        public static ElementDefinition AddDiffElement(this StructureDefinition sDef,
            String id,
            String propertyPath)
        {
            if (sDef is null)
                throw new ArgumentNullException(nameof(sDef ));

            ElementDefinition retVal = new ElementDefinition
            {
                ElementId = id,
                Min = 0,
                Max = "1",
                Path = propertyPath,
                Type = new List<ElementDefinition.TypeRefComponent>()
            };
            sDef.AddDiffElement(retVal);
            return retVal;
        }

        public static void AddDiffElement(this StructureDefinition sDef, ElementDefinition elementDefinition)
        {
            if (sDef is null)
                throw new ArgumentNullException(nameof(sDef ));

            if (sDef.Differential == null)
                sDef.Differential = new StructureDefinition.DifferentialComponent();
            sDef.Differential.Element.Add(elementDefinition);
        }

        public static ElementDefinition Element(this StructureDefinition sDef, Int32 index)
        {
            if (sDef is null)
                throw new ArgumentNullException(nameof(sDef));


            return sDef.Differential.Element[index];
        }

        public static Int32 ElementCount(this StructureDefinition sDef)
        {
            if (sDef is null)
                throw new ArgumentNullException(nameof(sDef ));

            if (sDef.Differential?.Element == null)
                return 0;
            return sDef.Differential.Element.Count;
        }

        public static StructureDefinition Init(this StructureDefinition sDef, String id, String name)
        {
            if (sDef is null)
                throw new ArgumentNullException(nameof(sDef ));

            sDef.Kind = StructureDefinition.StructureDefinitionKind.Resource;
            sDef.Id = id.ToMachineName();
            sDef.Name = name.ToMachineName();
            sDef.Differential = new StructureDefinition.DifferentialComponent();
            return sDef;
        }

        public static StructureDefinition InitDifferential(this StructureDefinition sDef)
        {
            if (sDef is null)
                throw new ArgumentNullException(nameof(sDef ));

            if (sDef.Differential == null)
                sDef.Differential = new StructureDefinition.DifferentialComponent();

            if (sDef.Differential.Element.Count != 0)
                throw new Exception($"Differential already has elements");

            sDef.Differential = new StructureDefinition.DifferentialComponent();
            sDef.Differential.Element.Add(
                new ElementDefinition
                {
                    ElementId = sDef.Id,
                    Path = sDef.Id,
                    Short = sDef.Name,
#if FHIR_R3
                    Comment = $"{sDef.Name} Logical Model"
#elif FHIR_R4
                    Comment = new Markdown($"{sDef.Name} Logical Model")
#endif
                });
            return sDef;
        }

        public static void InitExtensions(this StructureDefinition sDef)
        {
            if (sDef is null)
                throw new ArgumentNullException(nameof(sDef));

            String extensionPath = $"{sDef.Differential.Element[0].Path}.extension";
            ElementDefinition e = sDef.Differential.Element.FindByPath(extensionPath);
            if (e == null)
            {
                e = new ElementDefinition()
                {
                    ElementId = extensionPath,
                    Path = extensionPath,
                };
                sDef.Differential.Element.Insert(1, e);
            }
            {
                ElementDefinition.SlicingComponent slicingComponent = new ElementDefinition.SlicingComponent()
                {
                    Rules = ElementDefinition.SlicingRules.Open,
                    Ordered = false
                };
#if FHIR_R2
                slicingComponent.Discriminator = new String[] { "url" };
#elif FHIR_R3 || FHIR_R4
                slicingComponent.Discriminator.Add(new ElementDefinition.DiscriminatorComponent
                {
                    Type = ElementDefinition.DiscriminatorType.Value,
                    Path = "url"
                });
#endif
                e.Slicing = slicingComponent;
            }
        }

#if FHIR_R4 || FHIR_R3
        /// <summary>
        /// Set StructureDefinition.type to indicated value.
        /// </summary>
        public static StructureDefinition SetType(this StructureDefinition sDef, String type)
        {
            if (sDef is null)
                throw new ArgumentNullException(nameof(sDef));

            sDef.Type = type;
            return sDef;
        }

        /// <summary>
        /// Set Derivation.
        /// </summary>
        public static StructureDefinition SetDerivation(this StructureDefinition sDef,
            StructureDefinition.TypeDerivationRule value)
        {
            if (sDef is null)
                throw new ArgumentNullException(nameof(sDef));
            sDef.Derivation = value;
            return sDef;
        }
#endif

        /// <summary>
        /// Set Derivation.
        /// </summary>
        public static StructureDefinition SetDescription(this StructureDefinition sDef,
            String value)
        {
            return sDef.SetDescription(new Markdown(value));
        }

        /// <summary>
        /// Set Derivation.
        /// </summary>
        public static StructureDefinition SetDescription(this StructureDefinition sDef,
            Markdown value)
        {
            if (sDef is null)
                throw new ArgumentNullException(nameof(sDef ));
            if (value is null)
                throw new ArgumentNullException(nameof(value ));
#if FHIR_R3 || FHIR_R4
            sDef.Description = value;
#elif FHIR_R2
            sDef.Description = value.Value;
#else // default
                Invalid fhir type
#endif
            return sDef;
        }

        /// <summary>
        /// Set StructureDefinition.baseDefinition to indicated value.
        /// </summary>
        public static StructureDefinition SetBaseDefinition(this StructureDefinition sDef, String baseDefinition)
        {
            if (sDef is null)
                throw new ArgumentNullException(nameof(sDef));

            if (baseDefinition is null)
                throw new ArgumentNullException(nameof(baseDefinition));

            if (baseDefinition.ToLower().StartsWith("http:") == false)
                baseDefinition = "http://hl7.org/fhir/StructureDefinition/" + baseDefinition;
#if FHIR_R4 || FHIR_R3
            sDef.BaseDefinition = baseDefinition;
#elif FHIR_R2
            sDef.Base = baseDefinition;
#else           // default
                Invalid fhir type
#endif
            return sDef;
        }

        /// <summary>
        /// Method to set element definition map
        /// </summary>
        public static StructureDefinition SetMap(this StructureDefinition sDef,
            String name,
            String mapping)
        {
            if (sDef is null)
                throw new ArgumentNullException(nameof(sDef ));
            if (mapping is null)
                throw new ArgumentNullException(nameof(mapping));

            StructureDefinition.MappingComponent map = new StructureDefinition.MappingComponent
            {
                Identity = name,
                Name = name
            };

#if FHIR_R4 || FHIR_R3
            map.Comment = mapping;
#elif FHIR_R2
            //$$$$map.UserData.Add("map", mapping);
#else           // default
                Invalid fhir type
#endif

            sDef.Mapping.Add(map);
            return sDef;
        }

        /// <summary>
        /// Method to set element definition map
        /// </summary>
        public static String GetMap(this StructureDefinition sDef,
            String name)
        {
            if (sDef is null)
                throw new ArgumentNullException(nameof(sDef ));

            foreach (StructureDefinition.MappingComponent map in sDef.Mapping)
            {
                if (map.Identity == name)
                {
#if FHIR_R4 || FHIR_R3
                    return map.Comment;
#elif FHIR_R2
                    //$$$$if (map.UserData.TryGetValue("map", out object data) == true)
                    //$$$$    return data as string;
#else           // default
                Invalid fhir type
#endif
                }
            }
            return null;
        }
    }
}
