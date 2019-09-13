﻿using FhirKhit.Tools;
using Hl7.Fhir.ElementModel;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Model;
using Hl7.Fhir.Specification;
using Hl7.Fhir.Utility;
using Hl7.FhirPath;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;

namespace FhirKhit.SliceGen.R4
{
    [DebuggerDisplay("{Path} ")]
    public partial class ElementNode : ITypedElement
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

            bool GetFhirType(Type parent, String fhirName, out Type type, out String propertyName)
            {
                Debug.Assert(fhirName.EndsWith("[x]") == false);

                foreach (PropertyInfo pi in parent.GetProperties())
                {
                    FhirElementAttribute fhirElement = pi.GetCustomAttribute<FhirElementAttribute>();
                    if (fhirElement != null)
                    {
                        if (fhirElement.Name == fhirName)
                        {
                            propertyName = pi.Name;
                            type = pi.PropertyType;
                            return true;
                        }
                    }
                }
                parent = parent.BaseType;
                if (parent == typeof(Object))
                {
                    type = null;
                    propertyName = null;
                    return false;
                }
                return GetFhirType(parent, fhirName, out type, out propertyName);
            }
            void NormalizePathItem(ElementDefinition loadItem, ref String pathItem, out Type actualType)
            {
                actualType = null;

                const string multiType = "[x]";
                if (pathItem.EndsWith(multiType))
                {
                    pathItem = pathItem.Substring(0, pathItem.Length - multiType.Length);
                    return;
                }

                if (loadItem.Base.Path.EndsWith(multiType) == false)
                    return;
                String lcPathItem = pathItem.ToLower();
                foreach (ElementDefinition.TypeRefComponent typeRef in loadItem.Type)
                {
                    if (lcPathItem.EndsWith(typeRef.Code.ToLower()))
                    {
                        // change things like effectiveDateTime to effective.
                        if (pathItem.Length > typeRef.Code.Length)
                            pathItem = pathItem.Substring(0, pathItem.Length - typeRef.Code.Length);
                        if (ModelInfo.FhirTypeToCsType.TryGetValue(typeRef.Code, out actualType) == false)
                            throw new Exception($"Unknown fhor type '{typeRef.Code}'");
                        return;
                    }
                }
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
                        (tree.Child.Element.Name != pathItem)
                        )
                    {
                        tree.Child = null;
                        break;
                    }
                    tree = tree.Child;
                    nodeElement = tree.Element;
                    index += 1;
                }

                if (index < pathItems.Length - 1)
                    throw new Exception($"Invalid element tree {loadItem.Path}");

                pathItem = pathItems[index];
                ElementNode leafNode;
                if (index == 0)
                {
                    // This is the first element of the path (i.e. Observation...)
                    if (ModelInfo.FhirTypeToCsType.TryGetValue(pathItem, out Type fhirType) == false)
                        throw new Exception($"Unknown resource '{pathItem}'");
                    leafNode = new ElementNode(nodeElement, loadItem, fhirType, String.Empty);
                    nodeElement.childNodeDictionary.Add(pathItem, leafNode);
                }
                else if (String.IsNullOrEmpty(loadItem.SliceName))
                {
                    NormalizePathItem(loadItem, ref pathItem, out Type actualType);
                    if (nodeElement.TryGetDirectChild(pathItem, out ElementNode dummy) == true)
                        throw new Exception($"Error element node {pathItem} already exists in {loadItem.Path}");
                    if (GetFhirType(nodeElement.FhirItemType, pathItem, out Type fhirType, out String propertyName) == false)
                        throw new Exception($"Cant find '{loadItem.Path}' in {nodeElement.FhirItemType.FriendlyName()}");
                    leafNode = new ElementNode(nodeElement, loadItem, fhirType, actualType, propertyName);
                    nodeElement.childNodeDictionary.Add(pathItem, leafNode);
                }
                else
                {
                    //Debug.Assert(loadItem.SliceName != "breastrad-AbnormalityDensity");
                    NormalizePathItem(loadItem, ref pathItem, out Type actualType);
                    if (nodeElement.TryGetAnyChild(pathItem, out ElementNode sliceNode) == false)
                        throw new Exception($"Error element node {pathItem} not found {loadItem.Path}");
                    if (sliceNode.TryGetSlice(loadItem.SliceName, out ElementNode dummySlice) == true)
                        throw new Exception($"Error element node slice {nodeElement.Element.SliceName} already exists in {loadItem.Path}");
                    if (GetFhirType(nodeElement.FhirItemType, pathItem, out Type fhirType, out String propertyName) == false)
                        throw new Exception($"Cant find '{pathItem}' in {nodeElement.FhirItemType.FriendlyName()}");
                    leafNode = new ElementNode(nodeElement, loadItem, fhirType, actualType, propertyName);
                    sliceNode.slices.Add(loadItem.SliceName, leafNode);
                }

                tree.Child = new TreeItem
                {
                    Element = leafNode,
                    Child = null
                };
            }
        }

        public const int MAX_FP_EXPRESSION_CACHE_SIZE = 500;
        private static readonly Cache<string, CompiledExpression> _cache = new Cache<string, CompiledExpression>(expr => Compile(expr), new CacheSettings() { MaxCacheSize = MAX_FP_EXPRESSION_CACHE_SIZE });

        /// <summary>
        /// True if this is generated from a common data element child (i.e. CodeableCocept.Coding)
        /// </summary>
        public bool AutoGeneratedFlag { get; set; } = false;

        public const String BaseSlice = "";

        public String Path => this.Element.Path;

        /// <summary>
        /// Node that this node is a child of.
        /// </summary>
        public ElementNode Parent { get; set; }

        /// <summary>
        /// Return true if element definition, or one or more of its children are have a fixed value.
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
        /// Return true if one or more of elements slice's have a fixed value.
        /// </summary>
        public bool HasFixedSlice
        {
            get
            {
                foreach (ElementNode slice in this.Slices)
                {
                    if ((slice.IsFixed) || (slice.HasFixedChild))
                        return true;
                }
                return false;
            }
        }

        /// <summary>
        /// Return true if one or more of elements children have a fixed value.
        /// </summary>
        public bool HasFixedChild
        {
            get
            {
                foreach (ElementNode child in this.ChildNodes)
                {
                    if ((child.IsFixed) || (child.HasFixedChild) || (child.HasFixedSlice))
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

        public bool IsListType => FhirType.IsList();

        /// <summary>
        /// c# type for this element
        /// </summary>
        public Type FhirItemType { get; set; }

        /// <summary>
        /// Element Definition path, including slice names.
        /// </summaryElementNode
        public String[] SlicePath()
        {
            if (this.slicePath == null)
            {
                List<String> path = new List<string>();
                ElementNode node = this;
                while (node.Element != null)
                {
                    if (node.Element.SliceName != null)
                        path.Insert(0, node.Element.SliceName);
                    path.Insert(0, node.Name);
                    node = node.Parent;
                }
                this.slicePath = path.ToArray();
            }
            return this.slicePath;
        }
        String[] slicePath = null;

        public String FullPath()
        {
            if (fullPath == null)
            {
                StringBuilder sb = new StringBuilder();
                foreach (String s in this.SlicePath())
                {
                    if (sb.Length > 0)
                        sb.Append(".");
                    sb.Append(s);
                }
                this.fullPath = sb.ToString();
            }
            return fullPath;
        }
        String fullPath = null;

        /// <summary>
        /// Element name.
        /// </summary>
        public String Name
        {
            get
            {
                if (this.Element == null)
                    return "";
                String retVal = this.Element.Path.LastPathPart();
                return retVal;
            }
        }

        /// <summary>
        /// c# class PropertyName.
        /// </summary>
        public String PropertyName { get; set; }

        public IEnumerable<ElementNode> Slices => this.slices.Values;
        public IEnumerable<ElementNode> ChildNodes => this.childNodeDictionary.Values;

        /// <summary>
        /// Implementation of ITypedElement.InstanceType
        /// </summary>
        public string InstanceType => this.Name;

        /// <summary>
        /// Implementation of ITypedElement.Value
        /// </summary>
        public object Value => this.Element;

        /// <summary>
        /// Implementation of ITypedElement.Location
        /// </summary>
        public string Location => this.Name;

        /// <summary>
        /// Implementation of ITypedElement.Definition
        /// </summary>
        public IElementDefinitionSummary Definition => this.Element.GetElementDefinitionSummary();

        Dictionary<String, ElementNode> slices = new Dictionary<String, ElementNode>();
        Dictionary<String, ElementNode> childNodeDictionary = new Dictionary<String, ElementNode>();

        public ElementNode()
        {
        }

        public ElementNode(ElementNode parent,
            ElementDefinition element,
            Type fhirType,
            Type fhirItemType,
            String propertyName)
        {
            this.Parent = parent;
            this.Element = element;
            this.PropertyName = propertyName;
            SetTypes(fhirType, fhirItemType);
        }

        public ElementNode(ElementNode parent,
            ElementDefinition element,
            Type fhirType,
            String propertyName)
        {
            this.Parent = parent;
            this.Element = element;
            this.PropertyName = propertyName;
            SetTypes(fhirType, null);
        }

        public static ElementNode Create(StructureDefinition sDef)
        {
            if (sDef is null)
                throw new ArgumentNullException(nameof(sDef));

            String resourceName = sDef.Snapshot.Element[0].Path;

            Loader loader = new Loader();
            return loader.Create(sDef.Snapshot.Element);
        }

        void SetTypes(Type fhirType, Type fhirItemType)
        {
            if (fhirType == null)
                return;

            if (fhirItemType == null)
            {
                switch (fhirType.GenericTypeArguments?.Length)
                {
                    case null:
                    case 0:
                        fhirItemType = fhirType;
                        break;
                    case 1:
                        fhirItemType = fhirType.GenericTypeArguments[0];
                        break;

                    default:
                        throw new Exception($"Unexpected number of generic type arguments {fhirType.GenericTypeArguments.Length} in {fhirType.FriendlyName()}");
                }
            }
            this.FhirType = fhirType;
            this.FhirItemType = fhirItemType;
        }

        public bool TryGetAnyChild(String path, out ElementNode node)
        {
            if (path is null)
                throw new ArgumentNullException(nameof(path));

            node = this;
            String partialPath = "";
            foreach (String name in path.Split('.'))
            {
                if (node.childNodeDictionary.TryGetValue(name, out ElementNode newNode) == false)
                {
                    newNode = node.FindCommonChild(partialPath, name);
                    if (newNode == null)
                        return false;
                }
                node = newNode;
                path = $"{partialPath}.{name}";
            };
            return true;
        }

        //$$ delete
        public bool TryGetDirectChild(String path, out ElementNode node)
        {
            if (path is null)
                throw new ArgumentNullException(nameof(path));

            node = this;
            foreach (String name in path.Split('.'))
            {
                if (node.childNodeDictionary.TryGetValue(name, out node) == false)
                    return false;
            }
            return true;
        }

        public bool TryGetCommonChild(String name, out ElementNode node)
        {
            node = this.FindCommonChild(this.Path, name);
            return (node != null);
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
                if (currentItem.TryGetAnyChild(pathPart, out currentItem) == false)
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

        /// <summary>
        /// Implementation of ITypedElement.Children
        /// </summary>
        public IEnumerable<ITypedElement> Children(string name)
        {
            foreach (ElementNode childNode in this.ChildNodes)
            {
                if ((name == null) || (childNode.Name == name))
                    yield return childNode;
            }

            foreach (ElementNode slice in this.slices.Values)
            {
                foreach (ElementNode childNode in this.ChildNodes)
                {
                    if ((name == null) || (childNode.Name == name))
                        yield return childNode;
                }
            }
        }

        private CompiledExpression getCompiledExpression(string expression)
        {
            return _cache.GetValue(expression);
        }

        private static CompiledExpression Compile(string expression)
        {
            var compiler = new FhirPathCompiler();
            return compiler.Compile(expression);
        }

        public IEnumerable<ElementNode> Select(string expression, EvaluationContext ctx = null)
        {
            CompiledExpression evaluator = getCompiledExpression(expression);
            IEnumerable<ITypedElement> items = evaluator(this, ctx ?? EvaluationContext.CreateDefault());
            foreach (ITypedElement item in items)
                yield return (ElementNode)item;
        }

    }
}
