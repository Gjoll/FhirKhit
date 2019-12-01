using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.Tools.R4
{
    public static class ElementDefinitionExtensions2
    {
        public static ElementDefinition Path(this ElementDefinition e, String value)
        {
            e.Path = value;
            return e;
        }

        public static ElementDefinition ElementId(this ElementDefinition e, String value)
        {
            e.ElementId = value;
            return e;
        }

        public static ElementDefinition SliceName(this ElementDefinition e, String value)
        {
            e.SliceName = value;
            return e;
        }

        public static ElementDefinition ZeroToOne(this ElementDefinition e)
        {
            return e.Card(0, "1");
        }

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

        public static ElementDefinition Fixed(this ElementDefinition e, Element value)
        {
            e.Fixed = value;
            return e;
        }

        public static ElementDefinition Pattern(this ElementDefinition e, Element value)
        {
            e.Pattern = value;
            return e;
        }

        public static ElementDefinition Definition(this ElementDefinition e, Markdown value)
        {
            e.Definition = value;
            return e;
        }

        public static ElementDefinition Definition(this ElementDefinition e, string value)
        {
            e.Definition = new Markdown(value);
            return e;
        }

        public static ElementDefinition Type(this ElementDefinition e,
            ElementDefinition.TypeRefComponent[] types)
        {
            // Rename Value[x] to ValueCodeableConcept if type is set to one type of codeable concept.
            // Currently commentes out cause it does not appear to be necessary and it screws up the firely code.
            //String RenTyp(String s, String code)
            //{
            //    s = s.Substring(0, s.Length - 3);
            //    s += code;
            //    return s;
            //}

            e.Type.Clear();
            e.Type.AddRange(types);
            //if ((types.Length == 1) && (e.Path.EndsWith("[x]") == true))
            //{
            //    e.Path = RenTyp(e.Path, types[0].Code);
            //    e.ElementId = RenTyp(e.ElementId, types[0].Code);
            //}
            return e;
        }

        public static ElementDefinition TypeReference(this ElementDefinition e, params String[] targetProfiles)
        {
            return e.Type("Reference", null, targetProfiles);
        }

        public static ElementDefinition Binding(this ElementDefinition e,
            String binding,
            BindingStrength? strength)
        {
            e.Binding = new ElementDefinition.ElementDefinitionBindingComponent
            {
                Strength = strength,
                ValueSet = binding
            };
            return e;
        }

        public static ElementDefinition Type(this ElementDefinition e,
            String code,
            String[] profiles = null,
            String[] targetProfiles = null)
        {
            ElementDefinition.TypeRefComponent t = new ElementDefinition.TypeRefComponent
            {
                Code = code,
                Profile = profiles,
                TargetProfile = targetProfiles
            };
            return e.Type(new ElementDefinition.TypeRefComponent[] { t });
        }


    }
}
