using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.Maker.Common
{
    public abstract class BaseType
    {
        public String[] TargetProfile {get; set; }
        public String[] Profile {get; set; }

        public virtual void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
        }
    }
}
