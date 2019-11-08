using Hl7.Fhir.Specification.Source;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

#if FHIR_R4
namespace FhirKhit.Tools.R4
#elif FHIR_R3
namespace FhirKhit.Tools.R3
#elif FHIR_R2
namespace FhirKhit.Tools.R2
#endif
{
    public static class ZipFhirSource
    {
        public static ZipSource Source
        {
            set
            {
                ZipFhirSource.source = value;
            }
            get
            {
                if (ZipFhirSource.source == null)
                {
                    String specificationPath = Assembly.GetAssembly(typeof(ZipSource)).Location;
                    specificationPath = Path.GetDirectoryName(specificationPath);
                    specificationPath = Path.Combine(specificationPath, "specification.zip");
                    if (File.Exists(specificationPath) == false)
                    {
                        specificationPath = Assembly.GetExecutingAssembly().Location;
                        specificationPath = Path.GetDirectoryName(specificationPath);
                        specificationPath = Path.Combine(specificationPath, "specification.zip");
                    }
                    ZipFhirSource.source = new ZipSource(specificationPath);
                }

                return ZipFhirSource.source;
            }
        }
        static ZipSource source = null;
    }
}
