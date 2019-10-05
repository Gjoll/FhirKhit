using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.BreastRadiology
{
    public static class StructureDefinitionExtensions
    {
        public static StructureDefinition ContactUrl(this StructureDefinition sDef, String value)
        {
            ContactDetail cd = new ContactDetail();
            cd.Telecom.Add(new ContactPoint
            {
                System = ContactPoint.ContactPointSystem.Url,
                Value = value
            });
            sDef.Contact.Add(cd);
            return sDef;
        }

        public static StructureDefinition Name(this StructureDefinition sDef, String value) { sDef.Name = value; return sDef; }
        public static StructureDefinition Description(this StructureDefinition sDef, String value) { sDef.Description = new Markdown(value); return sDef; }
        public static StructureDefinition Url(this StructureDefinition sDef, String value) { sDef.Url = value; return sDef; }
        public static StructureDefinition Publisher(this StructureDefinition sDef, String value) { sDef.Publisher = value; return sDef; }
        public static StructureDefinition Title(this StructureDefinition sDef, String value) { sDef.Title = value; return sDef; }
        public static StructureDefinition Status(this StructureDefinition sDef, PublicationStatus? value) { sDef.Status = value; return sDef; }
        public static StructureDefinition Date(this StructureDefinition sDef, FhirDateTime value) { sDef.Date = value.Value; return sDef; }
        public static StructureDefinition Derivation(this StructureDefinition sDef, StructureDefinition.TypeDerivationRule? value) { sDef.Derivation = value; return sDef; }
        public static StructureDefinition Abstract(this StructureDefinition sDef, bool? value) { sDef.Abstract = value; return sDef; }
        public static StructureDefinition Kind(this StructureDefinition sDef, StructureDefinition.StructureDefinitionKind? value) { sDef.Kind = value; return sDef; }
        public static StructureDefinition Version(this StructureDefinition sDef, String value) { sDef.Version = value; return sDef; }
        public static StructureDefinition Type(this StructureDefinition sDef, String value) { sDef.Type = value; return sDef; }
        public static StructureDefinition Context(this StructureDefinition sDef, StructureDefinition.ExtensionContextType type = StructureDefinition.ExtensionContextType.Element,
            String expression = "*")
        {
            sDef.Context.Clear();
            sDef.Context.Add(new StructureDefinition.ContextComponent
            {
                Type = type,
                Expression = expression
            });
            return sDef;
        }
    }
}
