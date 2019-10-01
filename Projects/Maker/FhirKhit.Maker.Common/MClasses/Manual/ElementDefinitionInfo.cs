using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.Maker.Common
{
    public class ElementDefinitionInfo
    {
        public String Name { get; set; }
        public String Path{ get; set; }
        public String Id { get; set; }

        HashSet<BaseType> types = new HashSet<BaseType>();
        public Int32 Min { get; set; }
        public Int32 Max { get; set; }

        public BaseType[] Types { get; set; }

        Hl7.Fhir.Model.ElementDefinition constraints = null;

        public void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            if (this.constraints == null)
                return;
            sDef.Differential.Element.Add(this.constraints);
        }

        Hl7.Fhir.Model.ElementDefinition CreateConstraint()
        {
            if (this.constraints == null)
                this.constraints = new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = this.Path,
                    ElementId = this.Id
                };
            return this.constraints;
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
            Hl7.Fhir.Model.ElementDefinition c = CreateConstraint();
            c.Min = min;
            if (max == -1)
                c.Max = "*";
            else
                c.Max = max.ToString();

            return this;
        }

        public ElementDefinitionInfo Pattern(Hl7.Fhir.Model.Element value)
        {
            Hl7.Fhir.Model.ElementDefinition c = CreateConstraint();
            c.Pattern = value;
            return this;
        }

        public ElementDefinitionInfo Fixed(Hl7.Fhir.Model.Element value)
        {
            Hl7.Fhir.Model.ElementDefinition c = CreateConstraint();
            c.Fixed = value;
            return this;
        }
    }
}
