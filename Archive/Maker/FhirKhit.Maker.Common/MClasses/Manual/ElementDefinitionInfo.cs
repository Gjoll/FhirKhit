using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.Maker.Common
{
    public class ElementDefinitionInfo
    {
        public String Name { get; set; }
        public String Path { get; set; }
        public String Id { get; set; }

        HashSet<BaseType> types = new HashSet<BaseType>();
        public Int32 Min { get; set; }
        public Int32 Max { get; set; }

        public BaseType[] Types { get; set; }

        List<ElementDefinition> elements = null;

        public void Write(StructureDefinition sDef)
        {
            if (this.elements == null)
                return;
            sDef.Differential.Element.AddRange(this.elements);
        }

        public ElementDefinition AppendElement()
        {
            if (this.elements == null)
                this.elements = new List<ElementDefinition>();
            ElementDefinition retVal = new ElementDefinition
            {
                Path = this.Path,
                ElementId = this.Id
            };
            this.elements.Add(retVal);
            return retVal;
        }

        public ElementDefinition CreateConstraint()
        {
            if (this.elements == null)
                AppendElement();
            return this.elements[0];
        }

        public void AddType(BaseType type)
        {
            types.Add(type);
        }


        public ElementDefinitionInfo Unused()
        {
            return this.Card(0, 0);
        }

        public ElementDefinitionInfo Card(Int32 min, Int32 max)
        {
            if ((min == this.Min) && (max == this.Max))
                return this;
            ElementDefinition c = CreateConstraint();
            c.Min = min;
            if (max == -1)
                c.Max = "*";
            else
                c.Max = max.ToString();

            return this;
        }

        public ElementDefinitionInfo Pattern(Element value)
        {
            ElementDefinition c = CreateConstraint();
            c.Pattern = value;
            return this;
        }

        public ElementDefinitionInfo Fixed(Element value)
        {
            ElementDefinition c = CreateConstraint();
            c.Fixed = value;
            return this;
        }
    }
}
