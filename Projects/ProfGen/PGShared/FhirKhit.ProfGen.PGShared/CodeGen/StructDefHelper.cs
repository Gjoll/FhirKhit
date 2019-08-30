using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.ProfGen.PGShared
{
    /// <summary>
    /// Class to help manipulate a structure definition instance.
    /// </summary>
    public class StructDefHelper
    {
        /// <summary>
        /// Structure definition instance
        /// </summary>
        public StructureDefinition SDef {get; set; }

        /// <summary>
        /// Dictionary of all snapshot elements.
        /// </summary>
        readonly Dictionary<String, ElementDefinition> snapshotElements = new Dictionary<string, ElementDefinition>();

        /// <summary>
        /// Constructore
        /// </summary>
        /// <param name="sDef"></param>
        public StructDefHelper(StructureDefinition sDef)
        {
            if (sDef is null)
                throw new ArgumentNullException(nameof(sDef));

            this.SDef = sDef;
            this.snapshotElements.Add(sDef.Snapshot.Element);
        }

        /// <summary>
        /// Find a snapshot element by its path.
        /// </summary>
        /// <param name="fullPath">Path of the element we are looking for</param>
        /// <param name="elementDefinition">Element found or null</param>
        /// <returns>True if element found, false otherwise</returns>
        public bool SnapshotElement(String fullPath, out ElementDefinition elementDefinition) => this.snapshotElements.TryGetValue(fullPath, out elementDefinition);
    }
}
