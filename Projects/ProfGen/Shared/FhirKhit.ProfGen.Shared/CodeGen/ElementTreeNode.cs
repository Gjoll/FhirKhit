using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;
using FhirKhit.ProfGen.Shared.CodeGen.CSApi.Extensions;
using System.Diagnostics;

namespace FhirKhit.ProfGen.Shared
{
    public class ElementTreeNode
    {
        public const String BaseSlice = "";

        public class SliceDictionary : Dictionary<String, ElementTreeSlice> {}

        public ElementDefinition.SlicingComponent Slicing { get; set; }

        ProfileGenerator gen;

        /// <summary>
        /// Element Definition path.
        /// </summary>
        public String Path { get; set; }

        /// <summary>
        /// Element Definition path item (this levels name).
        /// </summary>
        public String PathName { get; }

        public IEnumerable<ElementTreeSlice> Slices => this.slices.Values;

        public IEnumerable<ElementTreeNode> ChildItems()
        {
            foreach (ElementTreeSlice slice in this.Slices)
                foreach (ElementTreeNode node in slice.ChildNodes)
                    yield return node;
        }

        public IEnumerable<ElementTreeNode> ChildItems(String sliceName)
        {
            if (slices.TryGetValue(sliceName, out ElementTreeSlice slice) == false)
                yield break;
            foreach (ElementTreeNode node in slice.ChildNodes)
                yield return node;
        }

        SliceDictionary slices { get; } = new SliceDictionary();

        public ElementTreeNode(ProfileGenerator gen,
            String path,
            String pathName)
        {
            this.gen = gen;
            this.Path = path;
            this.PathName = pathName;
        }

        /// <summary>
        /// Get child item with indicated slice and path names.
        /// Create chidl item id it does not exist.
        /// </summary>
        public ElementTreeSlice GetSlice(String sliceName)
        {
            if (this.slices.TryGetValue(sliceName, out ElementTreeSlice nodeSlice) == false)
            {
                nodeSlice = new ElementTreeSlice(gen, sliceName);
                this.slices.Add(sliceName, nodeSlice);
            }

            return nodeSlice;
        }

        /// <summary>
        /// Get child item with indicated slice and path names.
        /// Create chidl item id it does not exist.
        /// </summary>
        public ElementTreeNode GetChildItem(String path,
            String pathName,
            String sliceName)
        {
            if (this.slices.TryGetValue(sliceName, out ElementTreeSlice nodeSlice) == false)
            {
                nodeSlice = new ElementTreeSlice(gen, sliceName);
                this.slices.Add(sliceName, nodeSlice);
            }

            return nodeSlice.GetChildItem(path, pathName);
        }

        public bool TryGetItem(String path, out ElementTreeNode item)
        {
            String[] pathItems = path.Split('.');
            Int32 pathIndex = 0;

            item = this;
            if (item.PathName != pathItems[pathIndex++])
                return false;
            while (pathIndex < pathItems.Length)
            {
                item = this.GetChildItem(path, pathItems[pathIndex++], BaseSlice);
                if (item == null)
                    return false;
            }
            return true;
        }

        public static ElementTreeNode Create(ProfileGenerator gen, IEnumerable<ElementDefinition> items)
        {
            ElementTreeNode head = new ElementTreeNode(gen, String.Empty, String.Empty);

            foreach (ElementDefinition item in items)
            {
                //Debug.Assert(item.Path.StartsWith("Observation.code.coding") == false);
                Load(head, item);
            }
            return head;
        }

        static void Load(ElementTreeNode head, ElementDefinition loadItem)
        {
            ElementTreeNode nodeElement = head;

            String[] pathItems = loadItem.Path.Split('.');
            StringBuilder path = new StringBuilder();

            Int32 i = 0;
            String sliceName = BaseSlice;
            StringBuilder pathItem = new StringBuilder();
            char c;
            do
            {
                do
                {
                    c = loadItem.ElementId[i++];
                    path.Append(c);
                    if ((c == ':') || (c == '.'))
                        break;
                    pathItem.Append(c);
                }
                while (i < loadItem.ElementId.Length);

                nodeElement = nodeElement.GetChildItem(path.ToString(), pathItem.ToString(), sliceName);
                sliceName = BaseSlice;
                pathItem.Clear();

                if (c == ':')
                {
                    StringBuilder sliceBuilder = new StringBuilder();
                    do
                    {
                        c = loadItem.ElementId[i++];
                        path.Append(pathItem);
                        if (c == '.')
                            break;
                        sliceBuilder.Append(c);
                    }
                    while (i < loadItem.ElementId.Length);

                    sliceName = sliceBuilder.ToString();
                }
            } while (i < loadItem.ElementId.Length);

            nodeElement.Load(loadItem);
            ElementTreeSlice nodeSlice = nodeElement.GetSlice(sliceName);
            nodeSlice.Load(loadItem);
        }

        /// <summary>
        /// Copy data from ElementDefinition to ElementTreeNode.
        /// </summary>
        /// <param name="values"></param>
        public void Load(ElementDefinition loadItem)
        {
            const String fcn = "Load";

            if (loadItem.Slicing != null)
            {
                if (this.Slicing != null)
                    throw new Exception($"Slicing element already set.");
                this.Slicing = loadItem.Slicing;
                if (this.Slicing.Discriminator.Count > 1)
                    if (this.gen != null)
                        this.gen.ConversionError(this.GetType().Name, fcn, $"Todo: Currrently only 1 discriminator allowed.");
            }
        }

        /// <summary>
        /// Find an element by its id path, which can include slice names.
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public bool TryGetElementNode(String id, out ElementTreeNode currentItem)
        {
            currentItem = this;

            String[] pathItems = id.Split('.');
            foreach (String pathItem in pathItems)
            {
                String[] pathItemParts = pathItem.Split(':');
                String pathPart;
                String sliceName;

                switch (pathItemParts.Length)
                {
                    case 1:
                        pathPart = pathItemParts[0];
                        sliceName = BaseSlice;
                        break;
                    case 2:
                        pathPart = pathItemParts[0];
                        sliceName = pathItemParts[1];
                        break;
                    default:
                        throw new Exception($"Error parsing path item {pathItem}");
                }

                if (currentItem.slices.TryGetValue(sliceName, out ElementTreeSlice slice) == false)
                    return false;

                if (slice.TryGetValue(pathPart, out currentItem) == false)
                    return false;
            }

            return true;
        }

    }
}
