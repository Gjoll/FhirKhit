using Hl7.Fhir.ElementModel;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FhirKhit.SliceGen.R4;

namespace FhirKhit.ElementDefinitionViewer
{
    class TreeNodeElementNode : TreeNode
    {
        ElementDefinitionNode elementDefinitionNode;

        public TreeNodeElementNode(ElementDefinitionNode elementDefinitionNode)
        {
            this.elementDefinitionNode = elementDefinitionNode;
        }

        public override string ToString()
        {
            return $"{elementDefinitionNode} ";
        }
    }
}
