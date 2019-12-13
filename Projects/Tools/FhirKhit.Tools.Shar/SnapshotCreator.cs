using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
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
        public static async System.Threading.Tasks.Task CreateAsync(StructureDefinition structDef)
        {
            using (var tokenSource = new CancellationTokenSource())
            {
                var token = tokenSource.Token;
                var t = System.Threading.Tasks.Task.Run(() =>
               {
                   Create(structDef);
               }, token);
                await t.ConfigureAwait(false);
            }
        }

        public static void Create(StructureDefinition structDef)
        {
            if (structDef is null)
                throw new ArgumentNullException(nameof(structDef));

            structDef.Snapshot = new StructureDefinition.SnapshotComponent();

            // Generate StructureDefinition.Snapshot using c# API.
            SnapshotGeneratorSettings settings = SnapshotGeneratorSettings.CreateDefault();
            SnapshotGenerator generator = new SnapshotGenerator(ZipFhirSource.Source, settings);
            generator.Update(structDef);
        }
    }
}
