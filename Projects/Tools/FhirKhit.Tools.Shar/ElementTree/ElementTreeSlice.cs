using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using FhirKhit.Tools;
using System.Linq;
using System.Collections;
using Eir.DevTools;

#if FHIR_R4
namespace FhirKhit.Tools.R4
#elif FHIR_R3
namespace FhirKhit.Tools.R3
#endif
{
    /// <summary>
    /// Slice node for ElementDefinition.
    /// Allows hierarchical ordering of element definitions.
    /// Each instance contains
    /// a) A ElementDefinition instance
    /// b) zero or more child ElementTreeNode instances, containing
    ///    children ElementDefinition.
    /// All elements in an instance are derived from the same base fhir element slice.
    /// i.e.
    /// Observation.thingy
    ///     Observation.thingy.a
    ///     Observation.thingy.b
    /// Elements of a different slice would be contained in a different instance.
    /// </summary>
    [DebuggerDisplay("{this.parent.Path}[{this.Name}]")]
    public class ElementTreeSlice : IElementTreeItem, IEnumerable<ElementTreeNode>
    {
        public const String DefaultSlice = "";

        public ElementTreeItemList<ElementTreeNode> Nodes { get; } = new ElementTreeItemList<ElementTreeNode>();
        public ElementDefinition ElementDefinition { get; set; }

        ElementTreeNode parent;
        /// <summary>
        /// Name of this slice.
        /// </summary>
        public String Name { get; }

        public ElementTreeSlice(ElementTreeNode parent,
            String sliceName,
            ElementDefinition elementDefinition)
        {
            this.parent = parent;
            this.Name = sliceName;
            this.ElementDefinition = elementDefinition;
        }

        public override String ToString()
        {
            StringBuilder sb = new StringBuilder();
            this.Dump("", sb);
            return sb.ToString();
        }
        public void Dump(String margin, StringBuilder sb)
        {
            sb.AppendLine($"{margin}Slice: {this.Name}");
            foreach (ElementTreeNode node in this.Nodes)
                node.Dump(margin + "  ", sb);
        }

        public void ReplaceBasePath(String newBase)
        {
            if (this.ElementDefinition != null)
            {
                this.ElementDefinition.Path = this.ElementDefinition.Path.ReplacePathBase(newBase);
                this.ElementDefinition.ElementId = this.ElementDefinition.ElementId.ReplacePathBase(newBase);
            }

            foreach (ElementTreeNode childNode in this.Nodes)
                childNode.ReplaceBasePath(newBase);
        }

        /// <summary>
        /// </summary>
        public ElementTreeNode CreateNode(String nodePath,
            String nodeName,
            ElementDefinition elementDefinition)
        {
            ElementTreeNode node = new ElementTreeNode(nodePath, nodeName, elementDefinition);
            this.Nodes.Add(node);
            return node;
        }

        public ElementTreeNode CreateNode(ElementDefinition elementDefinition)
        {
            ElementTreeNode node = new ElementTreeNode(elementDefinition.Path, 
                elementDefinition.Path.LastPathPart(), 
                elementDefinition);
            this.Nodes.Add(node);
            return node;
        }

        /// <summary>
        /// value[x] can also be references as valueCode or valueString. 
        /// register alias' for these names as well.
        /// </summary>
        public void AddAliases(ElementTreeNode node,
            ElementDefinition loadItem)
        {
            if (node.Name.EndsWith("[x]") == false)
                return;

            String nameBase = node.Name.Substring(0, node.Name.Length - 3);
            foreach (ElementDefinition.TypeRefComponent type in loadItem.Type)
            {
                String xPath = $"{nameBase}{type.Code.CapFirstLetter()}";
                this.Nodes.AddAlias(xPath, node);
            }
        }

        Int32 MaxValue(string value, Int32 defaultValue)
        {
            switch (value)
            {
                case null:
                case "":
                    return defaultValue;

                case "*":
                    return Int32.MaxValue;

                default:
                    return Int32.Parse(value);
            }
        }

        /// <summary>
        /// Sort the node list using the indicated comparison.
        /// </summary>
        /// <param name="comparison"></param>
        public void SortNodes(Comparison<ElementTreeNode> comparison)
        {
            this.Nodes.SortList(comparison);
        }

        public void CopyTo(List<ElementDefinition> elementDefinitions)
        {
            if (this.ElementDefinition != null)
                elementDefinitions.Add(this.ElementDefinition);

            foreach (ElementTreeNode node in this)
                node.CopyTo(elementDefinitions);
        }

        /// <summary>
        /// Clone
        /// </summary>
        public ElementTreeSlice Clone(ElementTreeNode parent)
        {
            ElementDefinition e = (ElementDefinition)this.ElementDefinition?.DeepCopy();
            ElementTreeSlice retVal = new ElementTreeSlice(parent, this.Name, e);
            foreach (ElementTreeNode node in this)
                retVal.Nodes.Add(node.Clone());
            return retVal;
        }

        /// <summary>
        /// Returns if Slice is same as this slice, false otherwise.
        /// </summary>
        public bool SameAs(ElementTreeSlice other)
        {
            if ((this.ElementDefinition != null) || (other.ElementDefinition != null))
            {
                if ((this.ElementDefinition == null) || (other.ElementDefinition == null))
                    return false;
                if (this.ElementDefinition.IsExactly(other.ElementDefinition) == false)
                    return false;
            }

            if (this.Nodes.Count != other.Nodes.Count)
                return false;

            for (Int32 index = 0; index < this.Nodes.Count; index++)
            {
                ElementTreeNode thisNode = this.Nodes.GetItemAt(index);
                ElementTreeNode otherNode = other.Nodes.GetItemAt(index);
                if (thisNode.SameAs(otherNode) == false)
                    return false;
            }

            return true;
        }

        public void Clear()
        {
            this.ElementDefinition = null;
            this.Nodes.Clear();
        }

        public IEnumerator<ElementTreeNode> GetEnumerator() => ((IEnumerable<ElementTreeNode>)this.Nodes).GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable<ElementTreeNode>)this.Nodes).GetEnumerator();
    }
}
