using Hl7.Fhir.Model;
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
    public static class FhirExtendableExtensions
    {
        public const String NamespaceExtensionUri = "http://hl7.org/fhir/StructureDefinition/elementdefinition-namespace";
        public const string GenericExtensionUri = GlobalDefs.BaseModelDefUrl + "/ModelDef/GenericExtension";
        public const string ComposableExtensionUri = GlobalDefs.BaseModelDefUrl + "/ModelDef/Composable";
        public const string SectionPurposeExtensionUri = GlobalDefs.BaseModelDefUrl + "/ModelDef/SectionPurpose";

        public enum SectionPurporseEnums
        {
            None,
            Profile,
            CompositionTarget
        };

        public enum ComposableEnums
        {
            None,
            Flatten
        };

        /// <summary>
        /// Set Composable.
        /// </summary>
        public static ComposableEnums GetComposable(this IExtendable resource)
        {
            switch (resource)
            {
                case StructureDefinition sDef: break;
                case ElementDefinition eDef: break;
                default: throw new Exception($"Can only set Composable on an element definition");
            }

            Extension ns = resource.GetExtension(ComposableExtensionUri);
            String value = ((FhirString)ns?.Value)?.Value;
            if (value == null)
                return ComposableEnums.None;
            return (ComposableEnums) Enum.Parse(typeof(ComposableEnums), value);
        }

        /// <summary>
        /// Set Composable.
        /// </summary>
        public static void SetComposable(this IExtendable resource,
            ComposableEnums composableValue)
        {
            switch (resource)
            {
                case StructureDefinition sDef: break;
                case ElementDefinition eDef: break;
                default: throw new Exception($"Can only set composable on an element definition");
            }

            resource.AddExtension(ComposableExtensionUri, new FhirString(composableValue.ToString()));
        }

        /// <summary>
        /// Set Composable.
        /// </summary>
        public static SectionPurporseEnums GetSectionPurpose(this StructureDefinition resource)
        {
            Extension ns = resource.GetExtension(SectionPurposeExtensionUri);
            String value = ((FhirString)ns?.Value)?.Value;
            if (value == null)
                return SectionPurporseEnums.None;
            return (SectionPurporseEnums) Enum.Parse(typeof(SectionPurporseEnums), value);
        }

        /// <summary>
        /// Set Composable.
        /// </summary>
        public static StructureDefinition SetSectionPurpose(this StructureDefinition resource,
            SectionPurporseEnums sectionPurpose)
        {
            resource.AddExtension(SectionPurposeExtensionUri, new FhirString(sectionPurpose.ToString()));
            return resource;
        }

        /// <summary>
        /// Set namespace.
        /// </summary>
        public static String GetNamespace(this IExtendable resource)
        {
            switch (resource)
            {
                case StructureDefinition sDef: break;
                case ValueSet vsDef: break;
                default: throw new Exception($"Can only set namespace on a structure or valueset definition");
            }

            Extension ns = resource.GetExtension(NamespaceExtensionUri);
            return ((FhirUri)ns?.Value)?.Value;
        }

        /// <summary>
        /// Set namespace.
        /// </summary>
        public static T SetNamespace<T>(this T resource,
            String namespaceUri)
        where T : IExtendable
        {
            switch (resource)
            {
                case StructureDefinition sDef: break;
                case ValueSet vsDef: break;
                default: throw new Exception($"Can only set namespace on a structure or valueset definition");
            }

            resource.AddExtension(NamespaceExtensionUri, new FhirUri(namespaceUri));
            return resource;
        }

        /// <summary>
        /// Extension method to set Fhir generic type extension
        /// Each ElementDefinition item is one generic parameter.
        /// </summary>
        public static void AddGenericType(this IExtendable resource,
            String genericParamPath,
            String genericParamTypeUri)
        {
            // Make sure that generic name is a.b.c:d
            String[] parts = genericParamPath.Split('.');
            String[] subParts = parts[parts.Length - 1].Split(':');
            Debug.Assert(subParts.Length == 2);

            ElementDefinition genericElement = new ElementDefinition()
            {
                ElementId = genericParamPath,
                Path = genericParamPath
            };
            //$genericElement.Type.Add(new ElementDefinition.TypeRefComponent { Code = genericParamTypeUri });

            resource.AddExtension(GenericExtensionUri, genericElement);
        }

        /// <summary>
        /// Extension method to get fhir generic type extension
        /// </summary>
        /// <param name="resource"></param>
        public static IEnumerable<ElementDefinition> GetGenericTypes(this IExtendable resource)
        {
            foreach (Extension ext in resource.GetExtensions(GenericExtensionUri))
                yield return (ElementDefinition)ext.Value;
        }
    }
}
