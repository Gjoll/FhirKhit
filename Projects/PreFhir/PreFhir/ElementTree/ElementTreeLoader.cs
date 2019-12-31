using FhirKhit.Tools;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace PreFhir
{
    /// <summary>
    /// Loads a list of ElementDefinitions into the ElementTreeNode hierarchical 
    /// structure.
    /// This is complicated and utilizes a lot of recursion.
    /// The list of items must be well defined, including
    ///    
    /// a) All sliced sub lists must start with a single item with a slice name. All the items in that
    ///    slice must immediately follow.
    ///    The id slice name construct xxx:yyy is not used. Only the path and slice names.
    ///    
    /// b) All items that start with a previous items path must be adjacent.
    ///    ie.
    ///    
    ///    Path = "a.b"
    ///    Path = "a.b.c"
    ///    Path = "a.b.c.d"
    ///    would work.
    ///    
    ///    Path = "a.b"
    ///    Path = "b"
    ///    Path = "a.b.c"
    ///    Path = "a.b.c.d"
    ///    will fail.
    ///    
    ///    Path = "a.b"
    ///    Path = "a.b.c.d"
    ///    Path = "a.b.c"
    ///    will fail.
    /// </summary>
    public class ElementTreeLoader
    {
        IConversionInfo info;

        public ElementTreeLoader(IConversionInfo info = null)
        {
            this.info = info;
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
            if (this.info != null)
                this.info.ConversionError(className, method, msg);
        }

        public ElementTreeNode Create(IEnumerable<ElementDefinition> items)
        {
            const String fcn = "Create";

            Int32 itemIndex = 0;
            ElementTreeNode head = new ElementTreeNode("", "", null);
            if (items != null)
            {
                Load("", head.DefaultSlice, items.ToArray(), ref itemIndex);
                if (itemIndex != items.Count())
                {
                    this.Error(this.GetType().Name, fcn, $"Loader error. Unconsumed elements leftover....");
                    return null;
                }
            }
            if (head.DefaultSlice.Nodes.Count != 1)
                throw new Exception($"Internal error. Invalid node count/invalid element list");
            return head.DefaultSlice.Nodes.First();
        }

        public bool Add(ElementTreeNode head,
            ElementDefinition item)
        {
            return Add(head, new ElementDefinition[] { item });
        }

        public bool Add(ElementTreeNode head,
            IEnumerable<ElementDefinition> items)
        {
            const String fcn = "Add";

            Int32 itemIndex = 0;
            Load("", head.DefaultSlice, items.ToArray(), ref itemIndex);
            if (itemIndex != items.Count())
            {
                this.Error(this.GetType().Name, fcn, $"Loader error. Unconsumed elements leftover....");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Wildly recursive. Be carefull!
        /// </summary>
        void Load(String path,
            ElementTreeSlice headSlice,
            ElementDefinition[] loadItems,
            ref Int32 itemIndex)
        {
            const String fcn = "Load";

            while (itemIndex < loadItems.Length)
            {
                ElementDefinition loadItem = loadItems[itemIndex];

                if (loadItem.Path.Length <= path.Length)
                    return;
                if (loadItem.Path.StartsWith(path) == false)
                    return;
                if ((path.Length > 0) && (loadItem.Path[path.Length] != '.'))
                    return;

                String newPath = path;
                if (newPath.Length > 0)
                    newPath += ".";
                String loadPath = loadItem.Path.Substring(newPath.Length);
                String[] parts = loadPath.Split('.');
                newPath += parts[0];
                if (parts.Length > 1)
                {
                    if (headSlice.Nodes.TryGetItem(parts[0], out ElementTreeNode childNode) == false)
                    {
                        this.Info(this.GetType().Name, fcn, $"Creating undefined node {newPath}");
                        childNode = headSlice.CreateNode(newPath, parts[0], null);
                    }
                    Load(newPath, childNode.DefaultSlice, loadItems, ref itemIndex);
                }
                else if (parts.Length == 1)
                {
                    if (headSlice.Nodes.TryGetItem(parts[0], out ElementTreeNode childNode) == false)
                    {
                        if (String.IsNullOrEmpty(loadItem.SliceName))
                        {
                            childNode = headSlice.CreateNode(newPath, parts[0], loadItem);
                            headSlice.AddAliases(childNode, loadItem);
                        }
                        else
                        {
                            childNode = headSlice.CreateNode(newPath, parts[0], null);
                            headSlice.AddAliases(childNode, loadItem);
                        }
                    }

                    ElementTreeSlice childSlice;
                    if (String.IsNullOrEmpty(loadItem.SliceName))
                        childSlice = childNode.DefaultSlice;
                    else
                        childSlice = childNode.CreateSlice(loadItem.SliceName, loadItem);

                    itemIndex += 1;
                    Load(newPath, childSlice, loadItems, ref itemIndex);
                }
            }
        }
    }
}
