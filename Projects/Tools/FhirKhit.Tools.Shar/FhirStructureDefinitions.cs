using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Specification.Source;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

#if FHIR_R4
namespace FhirKhit.Tools.R4
#elif FHIR_R3
namespace FhirKhit.Tools.R3
#elif FHIR_R2
namespace FhirKhit.Tools.R2
#endif
{
    public class FhirStructureDefinitions
    {
        public static FhirStructureDefinitions Self { get; set; }

        public static void Create(String bundleDir) => Self = new FhirStructureDefinitions(bundleDir);

        Bundle fhirSDefsBundle;
        ZipSource source;

        String bundleDir;
        String bundlePath => Path.Combine(bundleDir, "StructureDefinitions.json");

        public Bundle FhirSDefs => GetBundle();

        Bundle GetBundle()
        {
            if (this.fhirSDefsBundle == null)
            {
                if (File.Exists(this.bundlePath) == false)
                    StoreFhirElements();
                FhirJsonParser parser = new FhirJsonParser();
                this.fhirSDefsBundle = parser.Parse<Bundle>(File.ReadAllText(this.bundlePath));
            }
            return this.fhirSDefsBundle;
        }

#pragma warning disable CA1054 // Uri parameters should not be strings
        public StructureDefinition GetResource(String uri)
#pragma warning restore CA1054 // Uri parameters should not be strings
        {
            if (uri is null)
                throw new ArgumentNullException(nameof(uri));

            return this.source.ResolveByUri(uri) as StructureDefinition;
        }

        /// <summary>
        /// To save time, store all structure definitions in a fhir bundle file. This need only be run when we get a new 
        /// FHIR version.
        /// </summary>
        public void StoreFhirElements()
        {
            const String fcn = "StoreFhirElements";

            // const String fcn = "StoreFhirElements";
            foreach (String f in Directory.GetFiles(this.bundleDir))
                File.Delete(f);

            foreach (String d in Directory.GetDirectories(this.bundleDir))
                Directory.Delete(d, true);

            {
                String rDir = Path.Combine(this.bundleDir, "StructDefs");
                if (Directory.Exists(rDir))
                    Directory.Delete(rDir, true);
            }
            String primitiveDir = Path.Combine(this.bundleDir, "StructDefs", "Primitive");
            Directory.CreateDirectory(primitiveDir);

            String logicalDir = Path.Combine(this.bundleDir, "StructDefs", "Logical");
            Directory.CreateDirectory(logicalDir);

            String complexDir = Path.Combine(this.bundleDir, "StructDefs", "Complex");
            Directory.CreateDirectory(complexDir);

            String resourceDir = Path.Combine(this.bundleDir, "StructDefs", "Resources");
            Directory.CreateDirectory(resourceDir);

            Bundle b = new Bundle();
            foreach (string uri in this.source.ListResourceUris())
            {
                StructureDefinition sDef = this.source.ResolveByUri(uri) as StructureDefinition;
                if (sDef != null)
                {
                    // This is to get rid of the http://....//de-... entries.
                    if (sDef.Snapshot.Element[0].Path.Split('.').Length == 1)
                    {
                        b.AddResourceEntry(sDef, sDef.Url);

                        switch (sDef.Kind)
                        {
#if FHIR_R4 || FHIR_R3
                            case StructureDefinition.StructureDefinitionKind.PrimitiveType:
                                sDef.SaveJson(Path.Combine(primitiveDir, $"{sDef.Name}.json"));
                                break;

                            case StructureDefinition.StructureDefinitionKind.ComplexType:
                                sDef.SaveJson(Path.Combine(complexDir, $"{sDef.Name}.json"));
                                break;
#endif
                            case StructureDefinition.StructureDefinitionKind.Logical:
                                sDef.SaveJson(Path.Combine(logicalDir, $"{sDef.Name}.json"));
                                break;

                            case StructureDefinition.StructureDefinitionKind.Resource:
                                sDef.SaveJson(Path.Combine(resourceDir, $"{sDef.Name}.json"));
                                break;

                            default:
                                throw new ConvertErrorException(this.GetType().Name, fcn, $"Invalid kind {sDef.Kind}. Item {sDef.Name}");
                        }
                    }
                }
            }
            b.SaveJson(this.bundlePath);
        }

        private FhirStructureDefinitions(String bundleDir)
        {
            this.bundleDir = bundleDir;
            if (Directory.Exists(bundleDir) == false)
                Directory.CreateDirectory(bundleDir);

            String specPath = Path.GetFullPath("specification.zip");
            if (File.Exists(specPath) == false)
                throw new Exception($"Missing {specPath}");
            this.source = new ZipSource(specPath);
            FhirStructureDefinitions.Self = this;
        }
    }
}
