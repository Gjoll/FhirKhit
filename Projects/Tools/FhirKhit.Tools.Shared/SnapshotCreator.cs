using System;
using System.Collections.Generic;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Specification.Snapshot;
using Hl7.Fhir.Specification.Source;

#if FHIR_R4
namespace FhirKhit.Tools.R4
#elif FHIR_R3
namespace FhirKhit.Tools.R3
#elif FHIR_R2
namespace FhirKhit.Tools.R2
#endif
{
    /// <summary>
    /// Create the snapshot section in a StructureDefinition.
    /// </summary>
    public static class SnapshotCreator
    {
        public static void Create(StructureDefinition structDef)
        {
            structDef.Snapshot = new StructureDefinition.SnapshotComponent();

            // Generate StructureDefinition.Snapshot using c# API.
            SnapshotGeneratorSettings settings = SnapshotGeneratorSettings.CreateDefault();
            SnapshotGenerator generator = new SnapshotGenerator(ZipFhirSource.Source, settings);
            generator.Update(structDef);
        }
    }
}
