using Hl7.Fhir.Model;
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
    public class SDefCleaner
    {
        IConversionInfo conversionInfo;

        public SDefCleaner(IConversionInfo info)
        {
            this.conversionInfo = info;
        }

        void CleanElement(StructureDefinition sDef,
            StructureDefinition parent,
            ElementDefinition element)
        {
            if ((element.Min == 0) && (element.Max == "0"))
                element.Type.Clear();

            ElementDefinition parentElement = parent.Snapshot.Element.FindByPath(element.Path);
            if (parentElement == null)
                return;

            if ((element.Type.Count > 0) &&
                (element.Type.IsExactly(parentElement.Type))
                )
                element.Type.Clear();

            if ((element.Min == parentElement.Min) && (element.Max == parentElement.Max))
            {
                element.Min = null;
                element.Max = null;
            }

            if (element.MustSupport == parentElement.MustSupport)
                element.MustSupport = null;
            if (element.IsModifier == parentElement.IsModifier)
                element.IsModifier = null;
            if (element.IsSummary == parentElement.IsSummary)
                element.IsSummary = null;
        }

        void CleanupDifferential(StructureDefinition sDef,
            StructureDefinition parent)
        {
            foreach (ElementDefinition element in sDef.Differential.Element)
            {
                CleanElement(sDef, parent, element);
            }
        }

        /// <summary>
        /// Delete all elements in the differential
        /// that are identical to the parent elements
        /// that they are supposed to modify.
        /// </summary>
        public void CleanupDifferential(StructureDefinition sDef)
        {
            if (sDef is null)
                throw new ArgumentNullException(nameof(sDef));

            const String fcn = "CleanElements";

#if FHIR_R4 || FHIR_R3
            String parentUri = sDef.BaseDefinition;
#elif FHIR_R2
           String parentUri = sDef.Base;
#endif
            if (String.IsNullOrEmpty(parentUri))
            {
                this.conversionInfo.ConversionInfo(this.GetType().Name, fcn, $"");
                return;
            }
            StructureDefinition parent = ZipFhirSource.Source.ResolveByUri(parentUri) as StructureDefinition;
            if (parent != null)
                CleanupDifferential(sDef, parent);
        }
    }
}
