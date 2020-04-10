using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Linq;
using FhirKhit.Tools;
using System.Collections;
using Eir.DevTools;

#if FHIR_R4
namespace FhirKhit.Tools.R4
#elif FHIR_R3
namespace FhirKhit.Tools.R3
#endif
{
    /// <summary>
    /// Tree node for ElementDefinition.
    /// Allows hierarchical ordering of element definitions.
    /// An ElementTreeNode contains one or more ElementTreeSlice.
    /// Slice 0 is the default slice, and contains the base (unsliced) element from the
    /// original ElementDefintion list.
    ///    If you have three ElementDefinitions (identified by their path)
    ///    X.A
    ///    X.A.B
    ///    X.A.B.Z
    ///    X.A.C
    ///    the ElementTree would like like this
    ///    ElementTreeNode
    ///     ElementSlice (contains ElementDefinition 'X')
    ///       ElementTreeNode
    ///         ElementSlice (contains ElementDefinition 'X.A')
    ///           ElementTreeNode
    ///             ElementSlice (contains ElementDefinition 'X.A.B')
    ///               ElementTreeNode
    ///                 ElementSlice (contains ElementDefinition 'X.A.B.Z')
    ///           ElementTreeNode
    ///             ElementSlice (contains ElementDefinition 'X.A.C')
    ///     
    /// </summary>
    [DebuggerDisplay("{this.Path}")]
    public class ElementTreeNode : IElementTreeItem, IEnumerable<ElementTreeSlice>
    {
        public const String DefaultSliceName = "";

        public ElementTreeSlice DefaultSlice => this.Slices[DefaultSliceName];

        public ElementDefinition ElementDefinition => this.DefaultSlice.ElementDefinition;

        /// <summary>
        /// Get list of all element definitions in this item, including nested items.
        /// </summary>
        public IEnumerable<ElementDefinition> ElementDefinitions
        {
            get
            {
                List<ElementDefinition> l = new List<ElementDefinition>();
                this.CopyTo(l);
                return l;
            }
        }
        /// <summary>
        /// Element Definition path.
        /// </summary>
        public String Path { get; private set; }

        /// <summary>
        /// Element Definition name (last part of path).
        /// </summary>
        public String Name { get; private set; }

        public ElementTreeItemList<ElementTreeSlice> Slices { get; } = new ElementTreeItemList<ElementTreeSlice>();

        private ElementTreeNode()
        {
        }

        public override String ToString()
        {
            StringBuilder sb = new StringBuilder();
            this.Dump("", sb);
            return sb.ToString();
        }
        public void Dump(String margin, StringBuilder sb)
        {
            sb.AppendLine($"{margin}Node: {this.ElementDefinition.ElementId}");
            foreach (ElementTreeSlice slice in this.Slices)
                slice.Dump(margin + "  ", sb);
        }

        public ElementTreeNode(String path,
            String pathName,
            ElementDefinition elementDefinition = null)
        {
            this.Path = path;
            this.Name = pathName;
            this.Slices.Add(new ElementTreeSlice(this, DefaultSliceName, elementDefinition));
        }

        public void ReplaceBasePath(String newBase)
        {
            this.Path = this.Path.ReplacePathBase(newBase);
            foreach (ElementTreeSlice slice in this)
                slice.ReplaceBasePath(newBase);
        }

        /// <summary>
        /// Create new slice.
        /// </summary>
        public ElementTreeSlice CreateSlice(String sliceName)
        {
            ElementDefinition baseElement = this.ElementDefinition;
            ElementDefinition elementDefinition = new ElementDefinition
            {
                Path = $"{baseElement.Path}",
                ElementId = $"{baseElement.ElementId}:{sliceName}",
                SliceName = sliceName
            };
            ElementTreeSlice nodeSlice = new ElementTreeSlice(this, sliceName, elementDefinition);
            this.Slices.Add(nodeSlice);
            return nodeSlice;
        }

        public void ApplySlicing(ElementDefinition.SlicingComponent slicingComponent,
            bool overrideExistingSliceDiscriminator)
        {
            this.ElementDefinition.ApplySlicing(slicingComponent, overrideExistingSliceDiscriminator);
        }

        /// <summary>
        /// Create new slice.
        /// </summary>
        public ElementTreeSlice CreateSlice(String sliceName, ElementDefinition elementDefinition)
        {
            ElementTreeSlice nodeSlice = new ElementTreeSlice(this, sliceName, elementDefinition);
            this.Slices.Add(nodeSlice);
            return nodeSlice;
        }

        /// <summary>
        /// Add an element.
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public void AddElement(String path, ElementDefinition elementDefinition)
        {
            ElementTreeNode currentItem = this;
            ElementTreeSlice slice = currentItem.DefaultSlice;

            String[] pathItems = path.Split('.');
            for (Int32 i = 0; i < pathItems.Length; i++)
            {
                String pathItem = pathItems[i];
                String[] pathItemParts = pathItem.Split(':');
                String pathPart;
                String sliceName;

                switch (pathItemParts.Length)
                {
                    case 1:
                        pathPart = pathItemParts[0];
                        sliceName = DefaultSliceName;
                        break;

                    case 2:
                        pathPart = pathItemParts[0];
                        sliceName = pathItemParts[1];
                        break;
                    default:
                        throw new Exception($"Error parsing path item {pathItem}");
                }

                if (i < pathItems.Length - 1)
                {
                    if (slice.Nodes.TryGetItem(pathPart, out currentItem) == false)
                        throw new Exception($"Node {pathPart} in {path} not found");

                    if (currentItem.Slices.TryGetItem(sliceName, out slice) == false)
                        throw new Exception($"Slice {pathPart} in {path} not found");
                }
                else
                {
                    if (slice.Nodes.TryGetItem(pathPart, out currentItem) == true)
                        throw new Exception($"Node {pathPart} of {path} already exists");
                    slice.CreateNode(path, path.LastPathPart(), elementDefinition);
                }
            }
        }


        /// <summary>
        /// Find an element by its path, which can include slice names.
        /// Throw exception if not found.
        /// </summary>
        public ElementTreeNode GetChild(String id)
        {
            if (TryGetChild(id, out ElementTreeNode childItem) == false)
                throw new Exception($"Node {this.ElementDefinition.ElementId} does not contain child node {id}");
            return childItem;
        }

        /// <summary>
        /// Find an element by its path, which can include slice names.
        /// </summary>
        public bool TryGetChild(String id, out ElementTreeNode childItem)
        {
            childItem = this;
            ElementTreeSlice slice = childItem.DefaultSlice;
            String[] pathItems = id.Split('.');
            // Ignore first element (base path name).
            foreach (String pathItem in pathItems)
            {
                String[] pathItemParts = pathItem.Split(':');
                String pathPart;
                String sliceName;

                switch (pathItemParts.Length)
                {
                    case 1:
                        pathPart = pathItemParts[0];
                        sliceName = DefaultSliceName;
                        break;
                    case 2:
                        pathPart = pathItemParts[0];
                        sliceName = pathItemParts[1];
                        break;
                    default:
                        throw new Exception($"Error parsing path item {pathItem}");
                }
                if (slice.Nodes.TryGetItem(pathPart, out childItem) == false)
                    return false;
                if (childItem.Slices.TryGetItem(sliceName, out slice) == false)
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Find an element by its path, which can include slice names.
        /// The first path item must match this items last path item.
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public bool TryGetElementNode(String id, out ElementTreeNode item)
        {
            if (String.Compare(id, this.ElementDefinition.ElementId) == 0)
            {
                item = this;
                return true;
            }

            String thisId = $"{this.ElementDefinition.ElementId}.";
            if (id.StartsWith(thisId) == false)
                throw new Exception($"Id must start with this items current id '{thisId}'");

            return TryGetChild(id.Substring(this.ElementDefinition.ElementId.Length + 1),
                out item);
        }

        /// <summary>
        /// Copy nested element defintions into flat list.
        /// </summary>
        public void CopyTo(List<ElementDefinition> elementDefinitions)
        {
            foreach (ElementTreeSlice slice in this)
                slice.CopyTo(elementDefinitions);
        }

        public void Clear()
        {
            this.Slices.Clear();
        }

        /// <summary>
        /// Returns if node is same as this node, false otherwise.
        /// </summary>
        public bool SameAs(ElementTreeNode other)
        {
            if (this.Slices.Count != other.Slices.Count)
                return false;

            for (Int32 index = 0; index < this.Slices.Count; index++)
            {
                ElementTreeSlice thisSlice = this.Slices.GetItemAt(index);
                ElementTreeSlice otherSlice = other.Slices.GetItemAt(index);
                if (thisSlice.SameAs(otherSlice) == false)
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Clone
        /// </summary>
        public ElementTreeNode Clone()
        {
            ElementTreeNode retVal = new ElementTreeNode
            {
                Name = this.Name,
                Path = this.Path
            };
            foreach (ElementTreeSlice slice in this)
                retVal.Slices.Add(slice.Clone(this));
            return retVal;
        }

        public IEnumerator<ElementTreeSlice> GetEnumerator() => ((IEnumerable<ElementTreeSlice>)this.Slices).GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable<ElementTreeSlice>)this.Slices).GetEnumerator();
    }
}
