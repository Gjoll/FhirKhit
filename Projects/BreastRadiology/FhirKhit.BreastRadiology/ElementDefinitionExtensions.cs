using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.BreastRadiology
{
    public static class ElementDefinitionExtensions
    {
        public static ElementDefinition Unused(this ElementDefinition e)
        {
            return e.Card(0, "0");
        }

        public static ElementDefinition CardOneToOne(this ElementDefinition e)
        {
            return e.Card(1, "1");
        }

        public static ElementDefinition Card(this ElementDefinition e, Int32 min, Int32 max)
        {
            e.Min = min;
            e.Max = max.ToString();
            return e;
        }

        public static ElementDefinition Card(this ElementDefinition e, Int32 min, String max)
        {
            e.Min = min;
            e.Max = max;
            return e;
        }
    }
}
