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
        String bundlePath;
        Bundle fhirSDefsBundle;
        ZipSource source;

        public Bundle FhirSDefs
        {
            get
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
        }

        /// <summary>
        /// To save time, store all structure definitions in a fhir bundle file. This need only be run when we get a new 
        /// FHIR version.
        /// </summary>
        public void StoreFhirElements()
        {
            // const String fcn = "StoreFhirElements";

            Bundle b = new Bundle();
            foreach (string uri in this.source.ListResourceUris())
            {
                StructureDefinition sDef = this.source.ResolveByUri(uri) as StructureDefinition;
                if (sDef != null)
                {
                    // This is to get rid of the http://....//de-... entries.
                    if (sDef.Snapshot.Element[0].Path.Split('.').Length == 1)
                        b.AddResourceEntry(sDef, sDef.Url);
                }
            }
            b.SaveJson(this.bundlePath);
        }

        public FhirStructureDefinitions()
        {
            String specPath = Path.GetFullPath("specification.zip");
            String bundlePath = Path.GetFullPath("StructureDefinitions.json");

            this.bundlePath = bundlePath;
            if (File.Exists(specPath) == false)
                throw new Exception($"Missing {specPath}");
            this.source = new ZipSource(specPath);
        }
    }
}
