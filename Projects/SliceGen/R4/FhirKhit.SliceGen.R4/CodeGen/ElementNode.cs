using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using FhirKhit.Tools;
using System.Reflection;
using Hl7.Fhir.Introspection;

namespace FhirKhit.SliceGen.R4
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
                ElementNode head = new ElementNode(null, null, null, String.Empty);
                foreach (ElementDefinition item in items)
                    this.Load(head, item);
                return head;
            }

            Type GetFhirType(Type parent, String fhirName, out String propertyName)
            {
                if (fhirName.EndsWith("[x]"))
                    fhirName = fhirName.Substring(0, fhirName.Length - 3);
                foreach (PropertyInfo pi in parent.GetProperties())
                {
                    FhirElementAttribute fhirElement = pi.GetCustomAttribute<FhirElementAttribute>();
                    if (fhirElement != null)
                    {
                        if (fhirElement.Name == fhirName)
                        {
                            propertyName = pi.Name;
                            return pi.PropertyType;
                        }
                    }
                }
                parent = parent.BaseType;
                if (parent == typeof(Object))
                    throw new Exception($"{parent.FriendlyName()}.{fhirName} not found");
                return GetFhirType(parent, fhirName, out propertyName);
            }

            public void Load(ElementNode head,
                ElementDefinition loadItem)
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
                        String propertyName;
                        Type fhirType;
                        if (index == 0)
                        {
                            propertyName = String.Empty;
                            if (ModelInfo.FhirTypeToCsType.TryGetValue(pathItem, out fhirType) == false)
                                throw new Exception($"Unknown resource '{pathItem}'");
                        }
                        else
                        {
                            fhirType = GetFhirType(nodeElement.FhirItemType, pathItem, out propertyName);
                        }

                        leafNode = new ElementNode(nodeElement, loadItem, fhirType, propertyName);
                        nodeElement.children.Add(pathItem, leafNode);
                    }
                    else
                    {
                        if (nodeElement.TryGetChild(pathItem, out ElementNode sliceNode) == false)
                            throw new Exception($"Error element node {pathItem} already exists in {loadItem.Path}");
                        if (sliceNode.TryGetSlice(loadItem.SliceName, out ElementNode dummySlice) == true)
                            throw new Exception($"Error element node slice {nodeElement.Element.SliceName} already exists in {loadItem.Path}");

                        Type fhirType = GetFhirType(nodeElement.FhirItemType, pathItem, out String propertyName);
                        leafNode = new ElementNode(nodeElement, loadItem, fhirType, propertyName);
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
        /// Node that this node is a child of.
        /// </summary>
        public ElementNode Parent { get; set; }

        /// <summary>
        /// Return true if element defgintion, ro one or more of its children are have a fixed value.
        /// </summary>
        public bool IsFixed
        {
            get
            {
                if (this.Element.Fixed != null)
                    return true;
                return false;
            }
        }

        /// <summary>
        /// Return true if element defgintion, ro one or more of its children are have a fixed value.
        /// </summary>
        public bool HasFixedChild
        {
            get
            {
                foreach (ElementNode child in this.Children)
                {
                    if (child.IsFixed)
                        return true;
                }
                return false;
            }
        }

        /// <summary>
        /// fhir element definition
        /// </summary>
        public ElementDefinition Element { get; set; }

        /// <summary>
        /// c# type for this element
        /// </summary>
        public Type FhirType { get; set; }

        /// <summary>
        /// c# type for this element
        /// </summary>
        public Type FhirItemType
        {
            get
            {
                switch (this.FhirType.GenericTypeArguments?.Length)
                {
                    case null:
                    case 0:
                        return this.FhirType;
                    case 1:
                        return this.FhirType.GenericTypeArguments[0];
                    default:
                        throw new Exception($"Unexpected number of generic type arguments {this.FhirType.GenericTypeArguments.Length} in {this.Element.Path}");
                }
            }
        }

        /// <summary>
        /// Element Definition path.
        /// </summary>
        public String Path => Element.Path;

        /// <summary>
        /// Element name.
        /// </summary>
        public String Name => this.Element.Path.LastPathPart();

        /// <summary>
        /// c# class PropertyName.
        /// </summary>
        public String PropertyName { get; set; }

        public IEnumerable<ElementNode> Slices => this.slices.Values;
        public IEnumerable<ElementNode> Children => this.children.Values;


        Dictionary<String, ElementNode> slices = new Dictionary<String, ElementNode>();
        Dictionary<String, ElementNode> children = new Dictionary<String, ElementNode>();


        public ElementNode(ElementNode parent,
            ElementDefinition element,
            Type fhirType,
            String propertyName)
        {
            this.Parent = parent;
            this.Element = element;
            this.FhirType = fhirType;
            this.PropertyName = propertyName;
        }

        public static ElementNode Create(StructureDefinition sDef)
        {
            if (sDef is null)
                throw new ArgumentNullException(nameof(sDef));

            String resourceName = sDef.Snapshot.Element[0].Path;

            Loader loader = new Loader();
            return loader.Create(sDef.Snapshot.Element);
        }

        public bool TryGetChild(String name, out ElementNode node)
        {
            return this.children.TryGetValue(name, out node);
        }

        public bool TryGetSlice(String name, out ElementNode node)
        {
            return this.slices.TryGetValue(name, out node);
        }

        public String PropertyPath()
        {
            ElementNode node = this;

            List<String> propertyNames = new List<string>();
            while (String.IsNullOrEmpty(node.PropertyName) == false)
            {
                propertyNames.Insert(0, node.PropertyName);
                node = node.Parent;
            }

            StringBuilder sb = new StringBuilder();
            foreach (String propertyName in propertyNames)
            {
                if (sb.Length > 0)
                    sb.Append(".");
                sb.Append(propertyName);
            }

            return sb.ToString();
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
