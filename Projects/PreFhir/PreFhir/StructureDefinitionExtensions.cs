using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PreFhir
{
    public static class StructureDefinitionExtensions
    {
        public static bool IsFragment(this StructureDefinition sDef)
        {
            Extension e = sDef.GetExtension(PreFhirGenerator.IsFragmentUrl);
            if (e == null)
                return false;
            FhirBoolean b = (FhirBoolean)e.Value;
            if (b.Value.HasValue == false)
                return false;
            return b.Value.Value;
        }
    }
}
