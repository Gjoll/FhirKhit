using Hl7.Fhir.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

#if FHIR_R4
namespace FhirKhit.Tools.R4
#elif FHIR_R3
namespace FhirKhit.Tools.R3
#endif
{
    public static class ElementDefinitionExtensions
    {
#if FHIR_R4 || FHIR_R3
        const String DerivationExtensionUri = "http://hl7.org/fhir/StructureDefinition/elementdefinition-derivation";
#endif
        public static ElementDefinition GetOrCreateElement(this List<ElementDefinition> elements,
            String path,
            String id = null)
        {
            if (elements is null)
                throw new ArgumentNullException(nameof(elements));

            ElementDefinition retVal = elements.FindByPath(path);
            if (retVal == null)
            {
                if (id == null)
                    id = path;
                retVal = new ElementDefinition
                {
                    Path = path,
                    ElementId = id
                };
                elements.Add(retVal);
            }

            return retVal;
        }

        public static ElementDefinition FindByPath(this IEnumerable<ElementDefinition> elements, String path)
        {
            if (elements is null)
                throw new ArgumentNullException(nameof(elements));

            foreach (ElementDefinition ed in elements)
            {
                if (ed.Path == path)
                    return ed;
            }
            return null;
        }

        public static List<ElementDefinition> RemoveById(this List<ElementDefinition> elements,
            String id)
        {
            if (elements is null)
                throw new ArgumentNullException(nameof(elements));

            Int32 i = 0;
            while (i < elements.Count)
            {
                ElementDefinition e = elements[i];
                if (e.ElementId == id)
                    elements.RemoveAt(i);
                else
                    i += 1;
            }
            return elements;
        }

        public static List<ElementDefinition> RemoveByPath(this List<ElementDefinition> elements,
            String path)
        {
            if (elements is null)
                throw new ArgumentNullException(nameof(elements));

            Int32 i = 0;
            while (i < elements.Count)
            {
                ElementDefinition e = elements[i];
                if (e.Path == path)
                    elements.RemoveAt(i);
                else
                    i += 1;
            }
            return elements;
        }

        public static void InsertAfter(this List<ElementDefinition> elements,
            ElementDefinition insertAfterThis,
            params ElementDefinition[] elementsToInsert)
        {
            if (elements is null)
                throw new ArgumentNullException(nameof(elements));
            if (insertAfterThis is null)
                throw new ArgumentNullException(nameof(insertAfterThis));
            if (elementsToInsert is null)
                throw new ArgumentNullException(nameof(elementsToInsert));

            Int32 i = 0;
            while (i < elements.Count)
            {
                if (elements[i] == insertAfterThis)
                {
                    foreach (ElementDefinition e in elementsToInsert)
                        elements.Insert(++i, e);
                    return;
                }
                i += 1;
            }

            throw new Exception("Insert After element not found in element list");
        }

        public static IEnumerable<ElementDefinition> FindIdStartsWith(this IEnumerable<ElementDefinition> elements,
            String id)
        {
            if (elements is null)
                throw new ArgumentNullException(nameof(elements));

            foreach (ElementDefinition ed in elements)
            {
                if (ed.ElementId.StartsWith(id))
                    yield return ed;
            }
        }

        public static ElementDefinition FindById(this IEnumerable<ElementDefinition> elements,
            String id)
        {
            if (elements is null)
                throw new ArgumentNullException(nameof(elements));

            foreach (ElementDefinition ed in elements)
            {
                if (ed.ElementId == id)
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
            if (elements is null)
                throw new ArgumentNullException(nameof(elements));

            foreach (ElementDefinition ed in elements)
            {
                if (ed.Path.Split('.').Length == 2)
                    yield return ed;
            }
        }

        public static Dictionary<String, ElementDefinition> Dictionate(this IEnumerable<ElementDefinition> elements)
        {
            if (elements is null)
                throw new ArgumentNullException(nameof(elements));

            Dictionary<String, ElementDefinition> retVal = new Dictionary<string, ElementDefinition>();
            foreach (ElementDefinition ed in elements)
                retVal.Add(ed.Path, ed);
            return retVal;
        }

        public static ElementDefinition.TypeRefComponent GetTypeRef(this ElementDefinition elementDefinition,
            String type,
            bool createFlag = false)
        {
            if (elementDefinition is null)
                throw new ArgumentNullException(nameof(elementDefinition));

            foreach (ElementDefinition.TypeRefComponent typeRef in elementDefinition.Type)
            {
                if (typeRef.Code == type)
                    return typeRef;

            }
            if (createFlag == false)
                return null;
            {
                ElementDefinition.TypeRefComponent typeRef = new ElementDefinition.TypeRefComponent
                {
                    Code = type
                };
                elementDefinition.AddType(typeRef);
                return typeRef;
            }
        }

        public static ElementDefinition SetShort(this ElementDefinition elementDefinition,
            String value)
        {
            if (elementDefinition is null)
                throw new ArgumentNullException(nameof(elementDefinition));

            elementDefinition.Short = value;
            return elementDefinition;
        }

        public static ElementDefinition Init(this ElementDefinition elementDefinition,
            String id,
            String path,
            Int32? min,
            String max)
        {
            if (elementDefinition is null)
                throw new ArgumentNullException(nameof(elementDefinition));

            elementDefinition.ElementId = id;
            elementDefinition.Path = path;
            elementDefinition.SetCardinality(min, max);
            return elementDefinition;
        }

        public static ElementDefinition SetFixed(this ElementDefinition elementDefinition,
            Element value)
        {
            if (elementDefinition is null)
                throw new ArgumentNullException(nameof(elementDefinition));

            elementDefinition.Fixed = value;
            return elementDefinition;
        }

        public static ElementDefinition SetBase(this ElementDefinition elementDefinition,
            String path,
            Int32? min,
            String max)
        {
            if (elementDefinition is null)
                throw new ArgumentNullException(nameof(elementDefinition));

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
            if (elementDefinition is null)
                throw new ArgumentNullException(nameof(elementDefinition));

            elementDefinition.IsSummary = value;
            return elementDefinition;
        }

        public static ElementDefinition SetIsModifier(this ElementDefinition elementDefinition,
            bool value)
        {
            if (elementDefinition is null)
                throw new ArgumentNullException(nameof(elementDefinition));

            elementDefinition.IsModifier = value;
            return elementDefinition;
        }

        public static ElementDefinition SetRepresentation(this ElementDefinition elementDefinition,
            ElementDefinition.PropertyRepresentation value)
        {
            if (elementDefinition is null)
                throw new ArgumentNullException(nameof(elementDefinition));

            elementDefinition.RepresentationElement.Add(new Code<ElementDefinition.PropertyRepresentation>(value));
            return elementDefinition;
        }

        public static ElementDefinition SetAliases(this ElementDefinition elementDefinition,
            params String[] values)
        {
            if (elementDefinition is null)
                throw new ArgumentNullException(nameof(elementDefinition));

            elementDefinition.Alias = values;
            return elementDefinition;
        }

        public static ElementDefinition SetRequirements(this ElementDefinition elementDefinition,
            String value)
        {
            if (elementDefinition is null)
                throw new ArgumentNullException(nameof(elementDefinition));

            return elementDefinition.SetRequirements(new Markdown(value));
        }

        public static ElementDefinition SetRequirements(this ElementDefinition elementDefinition,
            Markdown value)
        {
            if (elementDefinition is null)
                throw new ArgumentNullException(nameof(elementDefinition));
            if (value is null)
                throw new ArgumentNullException(nameof(value));

#if FHIR_R4
            elementDefinition.Requirements = value;
#elif FHIR_R3
            elementDefinition.Requirements = value.ToString();
#else           // default
                Invalid fhir type
#endif
            return elementDefinition;
        }

        public static ElementDefinition SetDefinition(this ElementDefinition elementDefinition,
            String value)
        {
            if (elementDefinition is null)
                throw new ArgumentNullException(nameof(elementDefinition));

            return elementDefinition.SetDefinition(new Markdown(value));
        }

        public static ElementDefinition SetComment(this ElementDefinition elementDefinition,
            String value)
        {
            if (elementDefinition is null)
                throw new ArgumentNullException(nameof(elementDefinition));

            return elementDefinition.SetComment(new Markdown(value));
        }

        public static ElementDefinition SetComment(this ElementDefinition elementDefinition,
            Markdown value)
        {
            if (elementDefinition is null)
                throw new ArgumentNullException(nameof(elementDefinition));
            if (value is null)
                throw new ArgumentNullException(nameof(value));
#if FHIR_R4
            elementDefinition.Comment = value;
#elif FHIR_R3
            elementDefinition.Comment = value.Value;
#else           // default
                Invalid fhir type
#endif
            return elementDefinition;
        }

        public static ElementDefinition SetDefinition(this ElementDefinition elementDefinition,
            Markdown value)
        {
            if (elementDefinition is null)
                throw new ArgumentNullException(nameof(elementDefinition));
            if (value is null)
                throw new ArgumentNullException(nameof(value));
#if FHIR_R4
            elementDefinition.Definition = value;
#elif FHIR_R3
            elementDefinition.Definition = value.ToString();
#else           // default
                Invalid fhir type
#endif
            return elementDefinition;
        }

        /// <summary>
        /// Set minValue.
        /// </summary>
        public static ElementDefinition SetCardinalityZeroToMany(this ElementDefinition elementDefinition)
        {
            if (elementDefinition is null)
                throw new ArgumentNullException(nameof(elementDefinition));

            return elementDefinition.SetCardinality(0, "*");
        }

        /// <summary>
        /// Set minValue.
        /// </summary>
        public static ElementDefinition SetCardinalityOneToMany(this ElementDefinition elementDefinition)
        {
            if (elementDefinition is null)
                throw new ArgumentNullException(nameof(elementDefinition));

            return elementDefinition.SetCardinality(1, "*");
        }

        /// <summary>
        /// Set minValue.
        /// </summary>
        public static ElementDefinition SetCardinalityOne(this ElementDefinition elementDefinition)
        {
            if (elementDefinition is null)
                throw new ArgumentNullException(nameof(elementDefinition));

            return elementDefinition.SetCardinality(1, "1");
        }

        /// <summary>
        /// Set minValue.
        /// </summary>
        public static ElementDefinition SetCardinalityZeroToOne(this ElementDefinition elementDefinition)
        {
            if (elementDefinition is null)
                throw new ArgumentNullException(nameof(elementDefinition));

            return elementDefinition.SetCardinality(0, "1");
        }

        /// <summary>
        /// Set minValue.
        /// </summary>
        public static ElementDefinition SetCardinality(this ElementDefinition elementDefinition,
            Int32? min, String max)
        {
            if (elementDefinition is null)
                throw new ArgumentNullException(nameof(elementDefinition));
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
            if (elementDefinition is null)
                throw new ArgumentNullException(nameof(elementDefinition));
            elementDefinition.MaxValue = value;
            return elementDefinition;
        }

        /// <summary>
        /// Set minValue.
        /// </summary>
        public static ElementDefinition SetMinValue(this ElementDefinition elementDefinition,
            Element value)
        {
            if (elementDefinition is null)
                throw new ArgumentNullException(nameof(elementDefinition));
            elementDefinition.MinValue = value;
            return elementDefinition;
        }

        /// <summary>
        /// Add type.
        /// </summary>
        public static ElementDefinition AddType(this ElementDefinition elementDefinition,
            ElementDefinition.TypeRefComponent value)
        {
            if (elementDefinition is null)
                throw new ArgumentNullException(nameof(elementDefinition));
            elementDefinition.Type.Add(value);
            return elementDefinition;
        }

        /// <summary>
        /// Add type.
        /// </summary>
        public static ElementDefinition AddType(this ElementDefinition elementDefinition,
            String elementType)
        {
            if (elementDefinition is null)
                throw new ArgumentNullException(nameof(elementDefinition));

            ElementDefinition.TypeRefComponent typeRef = new ElementDefinition.TypeRefComponent
            {
#if FHIR_R4 || FHIR_R3
                Code = elementType,
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
            if (elementDefinition is null)
                throw new ArgumentNullException(nameof(elementDefinition));
            if (profile is null)
                throw new ArgumentNullException(nameof(profile));

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
                    retVal.Add(type.Code);
                }
            }
            return retVal.ToArray();
        }



#if FHIR_R4 || FHIR_R3
        public static ElementDefinition SetSliceName(this ElementDefinition elementDefinition,
            String value)
        {
            if (elementDefinition is null)
                throw new ArgumentNullException(nameof(elementDefinition));
            elementDefinition.SliceName = value;
            return elementDefinition;
        }

        /// <summary>
        /// Add type.
        /// </summary>
        public static ElementDefinition SetContentReference(this ElementDefinition elementDefinition,
            String value)
        {
            if (elementDefinition is null)
                throw new ArgumentNullException(nameof(elementDefinition));

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
            if (elementDefinition is null)
                throw new ArgumentNullException(nameof(elementDefinition));
            if (mapping is null)
                throw new ArgumentNullException(nameof(mapping));

            ElementDefinition.MappingComponent map = new ElementDefinition.MappingComponent
            {
                Identity = name
            };

            map.Comment = mapping;
            elementDefinition.Mapping.Add(map);
            return elementDefinition;
        }

        /// <summary>
        /// Method to set element definition map
        /// </summary>
        public static String GetMap(this ElementDefinition elementDefinition,
            String name)
        {
            if (elementDefinition is null)
                throw new ArgumentNullException(nameof(elementDefinition));

            foreach (ElementDefinition.MappingComponent map in elementDefinition.Mapping)
            {
                if (map.Identity == name)
                {
                    return map.Comment;
                }
            }
            return null;
        }

#if FHIR_R3
        public static ElementDefinition.ElementDefinitionBindingComponent SetBinding(this ElementDefinition elementDefinition,
            BindingStrength strength,
            String name,
            String description,
            String valueSet)
        {
            if (elementDefinition is null)
                throw new ArgumentNullException(nameof(elementDefinition));

                elementDefinition.Binding = new ElementDefinition.ElementDefinitionBindingComponent
#elif FHIR_R4
        public static ElementDefinition.ElementDefinitionBindingComponent SetBinding(this ElementDefinition elementDefinition,
            BindingStrength strength,
            String name,
            String description,
            String valueSet)
        {
            if (elementDefinition == null)
                throw new ArgumentNullException(nameof(elementDefinition));

            elementDefinition.Binding = new ElementDefinition.ElementDefinitionBindingComponent
#else           // default
                Invalid fhir type
#endif
            {
                Strength = strength,
                Description = description,
#if FHIR_R3
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


        public static void ApplySlicing(this ElementDefinition e,
            ElementDefinition.SlicingComponent slicingComponent,
            bool overrideExistingSliceDiscriminator)
        {
            bool NonCompatible()
            {
                if (e.Slicing == null)
                    return false;
                if (e.Slicing.Ordered != slicingComponent.Ordered)
                    return true;
                if (e.Slicing.Rules != slicingComponent.Rules)
                    return true;
                if (e.Slicing.Discriminator.Count != slicingComponent.Discriminator.Count)
                    return true;
                for (Int32 i = 0; i < slicingComponent.Discriminator.Count; i++)
                {
                    if (slicingComponent.Discriminator[i].Type != e.Slicing.Discriminator[i].Type)
                        return true;
                    if (slicingComponent.Discriminator[i].Path != e.Slicing.Discriminator[i].Path)
                        return true;
                }

                return false;
            }

            if (overrideExistingSliceDiscriminator)
                e.Slicing = null;
            if (e.Slicing != null)
            {
                if (NonCompatible() == true)
                    throw new Exception($"Slicing already defined in a noncompatible manner");
                return;
            }
            e.Slicing = slicingComponent;
        }
    }
}
