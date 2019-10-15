using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FriendlyFhir
{
    public class SDefInfo
    {
        public StructureDefinition SDef { get; }
        public ElementDefinitionNode ElementDefinitionNode { get; }

        public SDefInfo Parent { get; set; }

        public SDefInfo(StructureDefinition sDef)
        {
            this.SDef = sDef;
            ElementDefinitionNode = ElementDefinitionNode.Create(sDef);
        }
    };
}
