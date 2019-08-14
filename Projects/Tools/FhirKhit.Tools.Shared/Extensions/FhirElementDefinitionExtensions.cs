using Hl7.Fhir.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

#if FHIR_R4
namespace FhirKhit.Tools.R4
#elif FHIR_R3
namespace FhirKhit.Tools.R3
#elif FHIR_R2
namespace FhirKhit.Tools.R2
#endif
{
    public static class FhirElementDefinitionExtensions
    {
        const String DerivationExtensionUri = "http://hl7.org/fhir/StructureDefinition/elementdefinition-derivation";
        const String MappingComponentId = "ModelDef.MapToProfile";
        const String CIMPLMap = "ModelDef.CIMPLMap";

        public static ElementDefinition GetOrCreateElement(this List<ElementDefinition> elements, String path)
        {
            ElementDefinition retVal = elements.FindByPath(path);
            if (retVal == null)
            {
                retVal = new ElementDefinition
                {
                    Path = path
                };
                elements.Add(retVal);
            }

            return retVal;
        }

        public static ElementDefinition FindByPath(this IEnumerable<ElementDefinition> elements, String path)
        {
            foreach (ElementDefinition ed in elements)
            {
                if (ed.Path == path)
                    return ed;
            }
            return null;
        }

        /// <summary>
        /// Return only the top level element definitions (ignore nested elements)
        /// </summary>
        /// <param name="elements"></param>
        /// <returns></returns>
        public static IEnumerable<ElementDefinition> TopLevelElements(this IEnumerable<ElementDefinition> elements)
        {
            foreach (ElementDefinition ed in elements)
            {
                if (ed.Path.Split('.').Length == 2)
                    yield return ed;
            }
        }

        public static Dictionary<String, ElementDefinition> Dictionate(this IEnumerable<ElementDefinition> elements)
        {
            Dictionary<String, ElementDefinition> retVal = new Dictionary<string, ElementDefinition>();
            foreach (ElementDefinition ed in elements)
                retVal.Add(ed.Path, ed);
            return retVal;
        }

        public static ElementDefinition.TypeRefComponent GetTypeRef(this ElementDefinition elementDefinition,
            String type,
            bool createFlag = false)
        {
#if FHIR_R2
            FHIRDefinedType fType = type.ToFhirType();
#endif

            foreach (ElementDefinition.TypeRefComponent typeRef in elementDefinition.Type)
            {
#if FHIR_R4 || FHIR_R3
                if (typeRef.Code == type)
                    return typeRef;
#elif FHIR_R2
                if (typeRef.Code == fType)
                    return typeRef;
#else           // default
                Invalid fhir type
#endif

            }
            if (createFlag == false)
                return null;
            {
                ElementDefinition.TypeRefComponent typeRef = new ElementDefinition.TypeRefComponent
                {
#if FHIR_R4 || FHIR_R3
                    Code = type
#elif FHIR_R2
                Code = fType
#else           // default
                Invalid fhir type
#endif
                };
                elementDefinition.AddType(typeRef);
                return typeRef;
            }
        }

        public static ElementDefinition SetShort(this ElementDefinition elementDefinition,
            String value)
        {
            elementDefinition.Short = value;
            return elementDefinition;
        }

        public static ElementDefinition Init(this ElementDefinition elementDefinition,
            String id,
            String path,
            Int32? min,
            String max)
        {
            elementDefinition.ElementId = id;
            elementDefinition.Path = path;
            elementDefinition.SetCardinality(min, max);
            return elementDefinition;
        }

        public static ElementDefinition  SetFixed(this ElementDefinition elementDefinition,
            Element value)
        {
            elementDefinition.Fixed = value;
            return elementDefinition;
        }

        public static ElementDefinition SetBase(this ElementDefinition elementDefinition,
            String path,
            Int32? min,
            String max)
        {
            elementDefinition.Base = new ElementDefinition.BaseComponent
            {
                Path = path,
                Min = min,
                Max = max
            };
            return elementDefinition;
        }

        public static ElementDefinition SetIsSummary(this ElementDefinition elementDefinition,
            bool value)
        {
            elementDefinition.IsSummary = value;
            return elementDefinition;
        }

        public static ElementDefinition SetIsModifier(this ElementDefinition elementDefinition,
            bool value)
        {
            elementDefinition.IsModifier = value;
            return elementDefinition;
        }

        public static ElementDefinition SetRepresentation(this ElementDefinition elementDefinition,
            ElementDefinition.PropertyRepresentation value)
        {
            elementDefinition.RepresentationElement.Add(new Code<ElementDefinition.PropertyRepresentation>(value));
            return elementDefinition;
        }

        public static ElementDefinition SetAliases(this ElementDefinition elementDefinition,
            params String[] values)
        {
            elementDefinition.Alias = values;
            return elementDefinition;
        }

        public static ElementDefinition SetRequirements(this ElementDefinition elementDefinition,
            String value)
        {
            return elementDefinition.SetRequirements(new Markdown(value));
        }

        public static ElementDefinition SetRequirements(this ElementDefinition elementDefinition,
            Markdown value)
        {
#if FHIR_R4
            elementDefinition.Requirements = value;
#elif FHIR_R3 || FHIR_R2
            elementDefinition.Requirements = value.ToString();
#else           // default
                Invalid fhir type
#endif
            return elementDefinition;
        }

        public static ElementDefinition SetDefinition(this ElementDefinition elementDefinition,
            String value)
        {
            return elementDefinition.SetDefinition(new Markdown(value));
        }

        public static ElementDefinition SetComment(this ElementDefinition elementDefinition,
            String value)
        {
            return elementDefinition.SetComment(new Markdown(value));
        }

        public static ElementDefinition SetComment(this ElementDefinition elementDefinition,
            Markdown value)
        {
#if FHIR_R4
            elementDefinition.Comment = value;
#elif FHIR_R3
            elementDefinition.Comment = value.Value;
#elif  FHIR_R2
#else           // default
                Invalid fhir type
#endif
            return elementDefinition;
        }

        public static ElementDefinition SetDefinition(this ElementDefinition elementDefinition,
            Markdown value)
        {
#if FHIR_R4
            elementDefinition.Definition = value;
#elif FHIR_R3 || FHIR_R2
            elementDefinition.Definition = value.ToString();
#else           // default
                Invalid fhir type
#endif
            return elementDefinition;
        }

        /// <summary>
        /// Set minValue.
        /// </summary>
        public static ElementDefinition SetCardinalityZeroToMany(this ElementDefinition elementDefinition) => elementDefinition.SetCardinality(0, "*");

        /// <summary>
        /// Set minValue.
        /// </summary>
        public static ElementDefinition SetCardinalityOneToMany(this ElementDefinition elementDefinition) => elementDefinition.SetCardinality(1, "*");

        /// <summary>
        /// Set minValue.
        /// </summary>
        public static ElementDefinition SetCardinalityOne(this ElementDefinition elementDefinition) => elementDefinition.SetCardinality(1, "1");

        /// <summary>
        /// Set minValue.
        /// </summary>
        public static ElementDefinition SetCardinalityZeroToOne(this ElementDefinition elementDefinition) => elementDefinition.SetCardinality(0, "1");

        /// <summary>
        /// Set minValue.
        /// </summary>
        public static ElementDefinition SetCardinality(this ElementDefinition elementDefinition,
            Int32? min, String max)
        {
            elementDefinition.Min = min;
            elementDefinition.Max = max;
            return elementDefinition;
        }

        /// <summary>
        /// Set maxValue.
        /// </summary>
        public static ElementDefinition SetMaxValue(this ElementDefinition elementDefinition,
            Element value)
        {
            elementDefinition.MaxValue = value;
            return elementDefinition;
        }

        /// <summary>
        /// Set minValue.
        /// </summary>
        public static ElementDefinition SetMinValue(this ElementDefinition elementDefinition,
            Element value)
        {
            elementDefinition.MinValue = value;
            return elementDefinition;
        }

        /// <summary>
        /// Add type.
        /// </summary>
        public static ElementDefinition AddType(this ElementDefinition elementDefinition,
            ElementDefinition.TypeRefComponent value)
        {
            elementDefinition.Type.Add(value);
            return elementDefinition;
        }

        /// <summary>
        /// Add type.
        /// </summary>
        public static ElementDefinition AddType(this ElementDefinition elementDefinition,
            String elementType)
        {
            ElementDefinition.TypeRefComponent typeRef = new ElementDefinition.TypeRefComponent
            {
#if FHIR_R4 || FHIR_R3
                Code = elementType,
#elif FHIR_R2
                Code = elementType.ToFhirType()
#else           // default
                Invalid fhir type
#endif
            };
            if (elementDefinition.Type == null)
                elementDefinition.Type = new List<ElementDefinition.TypeRefComponent>();
            elementDefinition.Type.Add(typeRef);
            return elementDefinition;
        }

        /// <summary>
        /// Add type.
        /// </summary>
        public static ElementDefinition AddReferenceType(this ElementDefinition elementDefinition,
            String profile)
        {
            if (profile.ToLower().StartsWith("http") == false)
                throw new Exception($"{profile} doesnt appear to be a proper url");
            String elementType = "Reference";

            ElementDefinition.TypeRefComponent typeRef = new ElementDefinition.TypeRefComponent
            {
#if FHIR_R4
                Code = elementType,
                TargetProfile = new String[] { profile }
#elif FHIR_R3
                Code = elementType,
                TargetProfile = profile
#elif FHIR_R2
                Code = elementType.ToFhirType(),
#endif
            };
            if (elementDefinition.Type == null)
                elementDefinition.Type = new List<ElementDefinition.TypeRefComponent>();
            elementDefinition.Type.Add(typeRef);
            return elementDefinition;
        }

        /// <summary>
        /// Extension method to get fhir generic type extension
        /// </summary>
        static void DoDeleteMap(this ElementDefinition elementDefinition,
            String map)
        {
            foreach (ElementDefinition.MappingComponent mapComponent in elementDefinition.Mapping)
            {
                if (String.Compare(mapComponent.Identity, map, StringComparison.InvariantCulture) == 0)
                {
                    elementDefinition.Mapping.Remove(mapComponent);
                    return;
                }
            }
        }

        /// <summary>
        /// Method to set element definition map
        /// </summary>
        static void DoSetMap(this ElementDefinition elementDefinition,
            String map,
            String text)
        {
            ElementDefinition.MappingComponent mapComponent = new ElementDefinition.MappingComponent
            {
                Identity = map,
                Language = "text/json",
                Map = text
            };

            elementDefinition.Mapping.Add(mapComponent);
        }

        /// <summary>
        /// Extension method to get fhir generic type extension
        /// </summary>
        static T DoGetMap<T>(this ElementDefinition elementDefinition,
            String map)
            where T : class
        {
            foreach (ElementDefinition.MappingComponent mapComponent in elementDefinition.Mapping)
            {
                if (String.Compare(mapComponent.Identity, map, StringComparison.InvariantCulture) == 0)
                {
                    String jsonText = mapComponent.Map;
                    return JsonConvert.DeserializeObject<T>(jsonText);
                }
            }
            return null;
        }

        /// <summary>
        /// Return array of the names of each element definition type defined
        /// in the indicated element definition. i.e. integer, string, etc.
        /// </summary>
        /// <returns></returns>
        public static String[] TypeNames(this ElementDefinition elementDef)
        {
            List<string> retVal = new List<String>();
            if (elementDef != null)
            {
                foreach (ElementDefinition.TypeRefComponent type in elementDef.Type)
                {
#if FHIR_R4 || FHIR_R3
                    retVal.Add(type.Code);
#elif FHIR_R2
                    if (type.Code.HasValue)
                        retVal.Add(ModelInfo.FhirTypeToFhirTypeName(type.Code.Value));
#endif
                }
            }
            return retVal.ToArray();
        }



#if FHIR_R4 || FHIR_R3
        public static ElementDefinition SetSliceName(this ElementDefinition elementDefinition,
            String value)
        {
            elementDefinition.SliceName = value;
            return elementDefinition;
        }

        /// <summary>
        /// Add type.
        /// </summary>
        public static ElementDefinition SetContentReference(this ElementDefinition elementDefinition,
            String value)
        {
            elementDefinition.ContentReference = value;
            return elementDefinition;
        }


        /// <summary>
        /// Get Derivation enumeration .
        /// </summary>
        public static StructureDefinition.TypeDerivationRule GetDerivation(this ElementDefinition elementDefinition)
        {
            Extension ns = elementDefinition.GetExtension(DerivationExtensionUri);
            if (ns == null)
                throw new Exception("Missing Derivation extension element");
            Code value = (Code)ns.Value;
            switch (value.Value)
            {
                case "specialization": return StructureDefinition.TypeDerivationRule.Specialization;
                case "constraint": return StructureDefinition.TypeDerivationRule.Constraint;
                default: throw new Exception($"Unexpected value in Derivation code {value.Value}");
            }
        }
        /// <summary>
        /// Set Derivation.
        /// </summary>
        public static ElementDefinition SetDerivation(this ElementDefinition elementDefinition,
            StructureDefinition.TypeDerivationRule value)
        {
            String strValue = value.ToString().ToLower();
            elementDefinition.AddExtension(DerivationExtensionUri, new Code(strValue));
            return elementDefinition;
        }
#endif

        /// <summary>
        /// Method to set element definition map
        /// </summary>
        public static ElementDefinition SetMap(this ElementDefinition elementDefinition,
            String name,
            String mapping)
        {
            ElementDefinition.MappingComponent map = new ElementDefinition.MappingComponent
            {
                Identity = name
            };

#if FHIR_R4 || FHIR_R3
            map.Comment = mapping;
#elif FHIR_R2
            //$$$map.UserData.Add("map", mapping);
#else           // default
                Invalid fhir type
#endif

            elementDefinition.Mapping.Add(map);
            return elementDefinition;
        }

        /// <summary>
        /// Method to set element definition map
        /// </summary>
        public static String GetMap(this ElementDefinition elementDefinition,
            String name)
        {
            foreach (ElementDefinition.MappingComponent map in elementDefinition.Mapping)
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

#if FHIR_R2
        public static ElementDefinition.BindingComponent SetBinding(this ElementDefinition elementDefinition,
            BindingStrength strength,
            String name,
            String description,
            String valueSet)
        {
            elementDefinition.Binding = new ElementDefinition.BindingComponent
#elif FHIR_R3
        public static ElementDefinition.ElementDefinitionBindingComponent SetBinding(this ElementDefinition elementDefinition,
            BindingStrength strength,
            String name,
            String description,
            String valueSet)
        {
                elementDefinition.Binding = new ElementDefinition.ElementDefinitionBindingComponent
#elif FHIR_R4
        public static ElementDefinition.ElementDefinitionBindingComponent SetBinding(this ElementDefinition elementDefinition,
            BindingStrength strength,
            String name,
            String description,
            String valueSet)
        {
            elementDefinition.Binding = new ElementDefinition.ElementDefinitionBindingComponent
#else           // default
                Invalid fhir type
#endif
            {
                Strength = strength,
                Description = description,
#if FHIR_R2 || FHIR_R3
                ValueSet = new FhirUri(valueSet),
#elif FHIR_R4
                ValueSet = valueSet,
#else           // default
                Invalid fhir type
#endif
            };
            elementDefinition.Binding.AddExtension(@"http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName", new FhirString(name));
            return elementDefinition.Binding;
        }
    }
}
