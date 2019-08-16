using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;
using FhirKhit.ProfGen.Shared.CodeGen.CSApi.Extensions;
using System.Diagnostics;

namespace FhirKhit.ProfGen.Shared
{
    public class ElementTreeSlice
    {
        public const String DefaultSlice = "@default";

        public class ElementTreeNodeDictionary : Dictionary<String, ElementTreeNode>
        {
        }

        ElementTreeNodeDictionary childNodeDictionary = new ElementTreeNodeDictionary();
        public IEnumerable<ElementTreeNode> ChildNodes=> this.childNodeDictionary.Values;

        public class BaseInfoData
        {
            public Int32 Min = Int32.MinValue;
            public Int32 Max = Int32.MaxValue;
        }

        ProfileGenerator gen;

        /// <summary>
        /// Name of this slice.
        /// </summary>
        public String SliceName { get; }

        /// <summary>
        /// Element Definition path item (this levels name).
        /// </summary>
        public String PathName { get; }

        public Int32 Min = Int32.MinValue;
        public Int32 Max = Int32.MaxValue;

        public BaseInfoData BaseInfo { get; set; }
        public List<ElementDefinition.TypeRefComponent> Types = new List<ElementDefinition.TypeRefComponent>();
        public Element Fixed = null;
        public ElementDefinition.ElementDefinitionBindingComponent Binding = null;

        public ElementTreeSlice(ProfileGenerator gen,
            String sliceName)
        {
            this.gen = gen;
            this.SliceName = sliceName;
        }

        /// <summary>
        /// Get child item with indicated slice and path names.
        /// Create chidl item id it does not exist.
        /// </summary>
        public bool TryGetValue(String pathName,
            out ElementTreeNode node)
        {

            return this.childNodeDictionary.TryGetValue(pathName, out node);
        }

        /// <summary>
        /// Get child item with indicated slice and path names.
        /// Create chidl item id it does not exist.
        /// </summary>
        public ElementTreeNode GetChildItem(String path,
            String pathName)
        {

            if (this.TryGetValue(pathName, out ElementTreeNode treeNode) == false)
            {
                treeNode = new ElementTreeNode(this.gen, path, pathName);
                this.childNodeDictionary.Add(pathName, treeNode);
            }

            return treeNode;
        }

        /// <summary>
        /// Copy data from ElementDefinition to ElementTreeNode.
        /// </summary>
        /// <param name="values"></param>
        public void Load(ElementDefinition loadItem)
        {
            //const String fcn = "Load";

            if (loadItem.Min.HasValue)
                this.Min = loadItem.Min.Value;
            this.Max = loadItem.Max.MaxValue(this.Max);

            if (loadItem.Fixed != null)
            {
                if (this.Fixed != null)
                    throw new Exception($"Fixed element already set.");
                this.Fixed = loadItem.Fixed;
            }

            if (loadItem.Binding != null)
            {
                if (this.Binding != null)
                    throw new Exception($"Binding element already set.");
                this.Binding = loadItem.Binding;
            }

            if (loadItem.Type.Count > 0)
            {
                if (this.Types.Count > 0)
                    throw new Exception($"Type list already set.");
                this.Types.AddRange(loadItem.Type);
            }

            if (loadItem.Base != null)
            {
                if (this.BaseInfo != null)
                    throw new Exception($"Base element already set.");
                this.BaseInfo = new BaseInfoData();
                if (loadItem.Base.Min.HasValue)
                    this.BaseInfo.Min = loadItem.Base.Min.Value;
                this.BaseInfo.Max = loadItem.Base.Max.MaxValue(this.BaseInfo.Max);
            }
        }
    }
}
