using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace PreFhir
{
    /// <summary>
    /// Contains info on one resource to process.
    /// </summary>
    [DebuggerDisplay("{Title}")]
    class ProcessItem
    {
        public String Title => Resource.GetUrl().LastUriPart();

        public bool FragmentFlag { get; private set; }

        public DomainResource Resource { get; set; }

        public StructureDefinition SDef => this.Resource as StructureDefinition;

        /// <summary>
        /// If resoure is a structired definition, this is the base definition.
        /// </summary>
        public StructureDefinition SBaseDef { get; set; } = null;

        /// <summary>
        /// Path value of the first element definition.
        /// </summary>
        public String BasePath { get; private set; }

        /// <summary>
        /// If Resource is a structure def, then this is created from the
        /// Differential
        /// </summary>
        public ElementTreeNode DiffNode { get; set; }

        /// <summary>
        /// If Resource is a structure def, then this is created from the
        /// Snapshot.
        /// </summary>
        public ElementTreeNode SnapNode { get; set; }

        /// <summary>
        /// Unmodified version of TreeNode.
        /// </summary>
        public ElementTreeNode SnapNodeOriginal { get; private set; }

        IConversionInfo info;

        public ProcessItem(IConversionInfo info, DomainResource resource)
        {
            this.info = info;
            this.Resource = resource;
        }

        public bool LoadMerge()
        {
            if (this.DiffNode != null)
                return true;

            this.FragmentFlag = this.SDef.IsFragment();
            ElementTreeLoader l = new ElementTreeLoader(this.info);
            this.DiffNode = l.Create(this.SDef.Differential.Element);
            return true;
        }

        public bool LoadBase()
        {
            const String fcn = "LoadBase";

            if (this.SnapNode != null)
                return true;

            this.FragmentFlag = this.SDef.IsFragment();
            StructureDefinition sDef = this.SDef;
            if (sDef == null)
                throw new Exception("Internal error. ProcessItem is not a structured definition.");
            if (sDef.Snapshot == null)
                SnapshotCreator.Create(sDef);
            List<ElementDefinition> elements = sDef.Snapshot.Element;
            this.BasePath = elements[0].Path;
            ElementTreeLoader l = new ElementTreeLoader(this.info);
            this.SnapNode = l.Create(elements);
            if (String.IsNullOrEmpty(sDef.BaseDefinition) == true)
            {
                info.ConversionError(this.GetType().Name,
                    fcn,
                    $"Error loading StructureDef '{sDef.Name}'. Empty BaseDefinition ");
                return false;
            }
            this.SBaseDef = FhirStructureDefinitions.Self.GetResource(sDef.BaseDefinition);
            if (this.SBaseDef == null)
            {
                info.ConversionError(this.GetType().Name,
                    fcn,
                    $"Error loading StructureDef '{sDef.Name}'. BaseDefinition {sDef.BaseDefinition} not found ");
                return false;
            }

            if (this.SBaseDef.Snapshot == null)
                SnapshotCreator.Create(this.SBaseDef);
            this.SnapNodeOriginal = l.Create(this.SBaseDef.Snapshot.Element);
            return true;
        }
    }
}
