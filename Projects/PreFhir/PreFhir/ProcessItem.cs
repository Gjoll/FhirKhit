using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PreFhir
{
    /// <summary>
    /// Contains info on one resource to process.
    /// </summary>
    class ProcessItem
    {
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
        /// Snapshot (if not a fragment) or the Differential (if a fragment).
        /// </summary>
        public ElementTreeNode TreeNode { get; set; }

        /// <summary>
        /// Unmodified version of TreeNode.
        /// </summary>
        public ElementTreeNode TreeNodeOriginal { get; set; }

        public ProcessItem()
        {
        }

        public bool Load(IConversionInfo info, DomainResource resource)
        {
            const string fcn = "Load";

            this.Resource = resource;
            StructureDefinition sDef = this.SDef;
            if (sDef != null)
            {
                this.FragmentFlag = sDef.IsFragment();
                List<ElementDefinition> elements;
                if (this.FragmentFlag)
                    elements = sDef.Differential.Element;
                else
                {
                    if (sDef.Snapshot == null)
                        SnapshotCreator.Create(sDef);
                    elements = sDef.Snapshot.Element;
                }

                this.BasePath = elements[0].Path;
                ElementTreeLoader l = new ElementTreeLoader(info);
                this.TreeNode = l.Create(elements);
                this.TreeNodeOriginal = this.TreeNode.Clone();
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
            }
            return true;
        }
    }
}
