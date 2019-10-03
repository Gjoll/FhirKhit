using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.BreastRadiology
{
    public static class ElementDefinitionExtensions
    {
        public static ElementDefinition ZeroToMany(this ElementDefinition e)
        {
            return e.Card(0, "*");
        }

        public static ElementDefinition OneToMany(this ElementDefinition e)
        {
            return e.Card(1, "*");
        }

        public static ElementDefinition Zero(this ElementDefinition e)
        {
            return e.Card(0, "0");
        }

        public static ElementDefinition Single(this ElementDefinition e)
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

        public static ElementDefinition Short(this ElementDefinition e, string value)
        {
            e.Short = value;
            return e;
        }

        public static ElementDefinition Definition(this ElementDefinition e, string value)
        {
            e.Definition = new Markdown(value);
            return e;
        }
    }
}
