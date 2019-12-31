using FhirKhit.Tools;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PreFhir
{
    /// <summary>
    /// Set Base element for every item.
    /// </summary>
    public class ElementTreeSetBase
    {
        IConversionInfo info;
        bool successFlag;

        public ElementTreeSetBase(IConversionInfo info)
        {
            this.info = info;
        }

        public bool Process(ElementTreeNode original,
            ElementTreeNode modified)
        {
            successFlag = true;
            this.ProcessNode(original, modified);
            return successFlag;
        }

        void Info(string className, string method, string msg)
        {
            if (this.info != null)
                this.info.ConversionInfo(className, method, msg);
        }

        void Warn(string className, string method, string msg)
        {
            if (this.info != null)
                this.info.ConversionWarn(className, method, msg);
        }

        void Error(string className, string method, string msg)
        {
            successFlag = false;
            if (this.info != null)
                this.info.ConversionError(className, method, msg);
        }

        void ProcessNode(ElementTreeNode originalNode,
            ElementTreeNode modifiedNode)
        {
            foreach (ElementTreeSlice modifiedSlice in modifiedNode.Slices)
                ProcessSlice(originalNode.DefaultSlice, modifiedSlice);
        }

        void ProcessSlice(ElementTreeSlice originalDefaultSlice,
            ElementTreeSlice modifiedSlice)
        {
            //const String fcn = "ProcessSlice";

            if ((originalDefaultSlice.ElementDefinition != null) && (modifiedSlice.ElementDefinition != null))
            {
                modifiedSlice.ElementDefinition.Base = new ElementDefinition.BaseComponent
                {
                    Path = originalDefaultSlice.ElementDefinition.Path,
                    Min = originalDefaultSlice.ElementDefinition.Min,
                    Max = originalDefaultSlice.ElementDefinition.Max
                };
            }

            foreach (ElementTreeNode modifiedNode in modifiedSlice.Nodes.ToArray())
            {
                if (originalDefaultSlice.Nodes.TryGetItem(modifiedNode.Name, out ElementTreeNode originalNode) == true)
                    ProcessNode(originalNode, modifiedNode);
            }
        }
    }
}
