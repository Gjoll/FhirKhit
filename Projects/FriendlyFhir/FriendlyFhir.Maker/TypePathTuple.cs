using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FriendlyFhir
{
    // Keep track of property names assigned to items of a specific type, 
    // defined by the Fhir TypeRef{} array
    public class TypePathTuple
    {
        public List<ElementDefinition.TypeRefComponent> types;
        public List<String> paths = new List<string>();

        public TypePathTuple(ElementDefinition ed)
        {
            this.types = ed.Type;
            paths.Add(ed.Path);
        }

        public TypePathTuple(List<ElementDefinition.TypeRefComponent> types, string path)
        {
            this.types = types;
            paths.Add(path);
        }
    }
}
