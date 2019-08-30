using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;
using FhirKhit.SliceGen.Share.CodeGen.CSApi.Extensions;
using System.Diagnostics;
using FhirKhit.Tools;

namespace FhirKhit.SliceGen.Share
{
    [DebuggerDisplay("{Path} ")]
    public class ElementNode
    {
        class Loader
        {
            class TreeItem
            {
                public ElementNode Element;
                public TreeItem Child;
            };

            TreeItem treeHead = new TreeItem();

            public ElementNode Create(IEnumerable<ElementDefinition> items)
            {
                ElementNode head = new ElementNode(null);

                foreach (ElementDefinition item in items)
                    this.Load(head, item);

                return head;
            }

            public void Load(ElementNode head, ElementDefinition loadItem)
            {
                ElementNode nodeElement = head;

                String[] pathItems = loadItem.Path.Split('.');
                Int32 index = 0;
                String pathItem;

                TreeItem tree = this.treeHead;
                /*
                 * Search down tree as far as elements are the same. This insures that we go
                 * down the correct slices.
                 */
                while (index < pathItems.Length - 1)
                {
                    pathItem = pathItems[index];
                    if (
                        (tree.Child == null) ||
                        (tree.Child.Element.Name != pathItems[index])
                        )
                    {
                        tree.Child = null;
                        break;
                    }
                    tree = tree.Child;
                    nodeElement = tree.Element;
                    index += 1;
                }

                while (index < pathItems.Length - 1)
                {
                    pathItem = pathItems[index];
                    if (nodeElement.TryGetChild(pathItem, out ElementNode next) == false)
                        throw new Exception($"Error element node {pathItem} in {loadItem.Path}");
                    tree.Child = new TreeItem
                    {
                        Element = next,
                        Child = null
                    };
                    nodeElement = next;
                    index += 1;
                }

                {
                    pathItem = pathItems[index];
                    ElementNode leafNode = null;
                    if (String.IsNullOrEmpty(loadItem.SliceName))
                    {
                        if (nodeElement.TryGetChild(pathItem, out ElementNode dummy) == true)
                            throw new Exception($"Error element node {pathItem} already exists in {loadItem.Path}");
                        leafNode = new ElementNode(loadItem);
                        nodeElement.children.Add(pathItem, leafNode);
                    }
                    else
                    {
                        if (nodeElement.TryGetChild(pathItem, out ElementNode sliceNode) == false)
                            throw new Exception($"Error element node {pathItem} already exists in {loadItem.Path}");
                        if (sliceNode.TryGetSlice(loadItem.SliceName, out ElementNode dummySlice) == true)
                            throw new Exception($"Error element node slice {nodeElement.Element.SliceName} already exists in {loadItem.Path}");

                        leafNode = new ElementNode(loadItem);
                        sliceNode.slices.Add(loadItem.SliceName, leafNode);
                    }

                    tree.Child = new TreeItem
                    {
                        Element = leafNode,
                        Child = null
                    };
                }

                //nodeElement.Load(loadItem);
                //ElementTreeSlice nodeSlice = nodeElement.GetSlice(sliceName);
                //nodeSlice.Load(loadItem);
            }
        }

        public const String BaseSlice = "";

        /// <summary>
        /// Return true if element defgintion, ro one or more of its children are have a fixed value.
        /// </summary>
        public bool IsFixed
        {
            get
            {
                if (this.Element.Fixed != null)
                    return true;

                foreach (ElementNode child in this.Children)
                {
                    if (child.Element.Fixed != null)
                        return true;
                }
                return false;
            }
        }

        public ElementDefinition Element { get; set; }

        /// <summary>
        /// Element Definition path.
        /// </summary>
        public String Path => Element.Path;

        /// <summary>
        /// Element name.
        /// </summary>
        public String Name => this.Element.Path.LastPathPart();

        public IEnumerable<ElementNode> Slices => this.slices.Values;
        public IEnumerable<ElementNode> Children => this.children.Values;


        Dictionary<String, ElementNode> slices = new Dictionary<String, ElementNode>();
        Dictionary<String, ElementNode> children = new Dictionary<String, ElementNode>();


        public ElementNode(ElementDefinition element)
        {
            this.Element = element;
        }

        public static ElementNode Create(IEnumerable<ElementDefinition> items)
        {
            if (items is null)
                throw new ArgumentNullException(nameof(items));

            Loader loader = new Loader();
            return loader.Create(items);
        }

        public bool TryGetChild(String name, out ElementNode node)
        {
            return this.children.TryGetValue(name, out node);
        }

        public bool TryGetSlice(String name, out ElementNode node)
        {
            return this.slices.TryGetValue(name, out node);
        }

        /// <summary>
        /// Find an element by its id path, which can include slice names.
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public bool TryGetElementNode(String id, out ElementNode currentItem)
        {
            if (id is null)
                throw new ArgumentNullException(nameof(id));

            currentItem = this;

            String[] pathItems = id.Split('.');
            foreach (String pathItem in pathItems)
            {
                String[] pathItemParts = pathItem.Split(':');
                String pathPart;
                String sliceName;

                pathPart = pathItemParts[0];
                if (currentItem.TryGetChild(pathPart, out currentItem) == false)
                    return false;

                if (pathItemParts.Length == 2)
                {
                    sliceName = pathItemParts[1];
                    if (currentItem.slices.TryGetValue(sliceName, out currentItem) == false)
                        return false;
                }
            }

            return true;
        }
    }
}
