using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.Maker
{
    public class SDefInfo
    {
        public enum TypeFlag
        {
            Unknown,
            Resource,
            Element
        }
        public TypeFlag TFlag = TypeFlag.Unknown;
        public StructureDefinition SDef;
        public ElementDefinitionNode Nodes;
        public SDefInfo Parent;

        public bool DefinedInSelf(String elementPath)
        {
            if (this.Nodes.TryGetDirectChild(elementPath, out ElementDefinitionNode node) == true)
                return true;
            return false;
        }

        public bool DefinedInParent(String elementPath)
        {
            if (this.Parent == null)
                return false;
            if (this.Parent.DefinedInSelf(elementPath))
                return true;
            return this.Parent.DefinedInParent(elementPath);
        }
    };
}
