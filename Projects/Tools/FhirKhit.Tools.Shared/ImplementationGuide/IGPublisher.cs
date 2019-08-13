using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using FhirKhit.Tools;

#if FHIR_R4
namespace FhirKhit.Tools.R4
#elif FHIR_R3
namespace FhirKhit.Tools.R3
#elif FHIR_R2
namespace FhirKhit.Tools.R2
#endif
{
    /// <summary>
    /// Class to automate Implementation Guide Creation.
    /// This uses the FHIR IG java tools directly.
    /// </summary>
    public class IGPublisher : ConverterProcess
    {
        /// <summary>
        /// Get latest publisher jar file. Make sure we are using the latest and greatest.
        /// </summary>
        public String PublisherJarPath => Path.Combine(this.TemplateDir, "org.hl7.fhir.igpublisher.jar");

        /// <summary>
        /// Get latest publisher jar file. Make sure we are using the latest and greatest.
        /// </summary>
        public Boolean PublisherJarExists => File.Exists(this.PublisherJarPath);

        public String TemplateDir;

        /// <summary>
        /// Constructor
        /// </summary>
        public IGPublisher(String templateDir)
        {
            this.TemplateDir = templateDir;
        }

        public Boolean Publish()
        {
            bool retVal = base.Execute(this.TemplateDir,
                "java",
                $"-d64 -Xms2g -Xms2g -jar org.hl7.fhir.igpublisher.jar -ig ig.json");
            if (this.HasErrors)
                retVal = false;
            return retVal;
        }

        /// <summary>
        /// Get latest publisher jar file. Make sure we are using the latest and greatest.
        /// </summary>
        public void GetPublisherJar()
        {
            String url = $"http://build.fhir.org/org.hl7.fhir.igpublisher.jar";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.Headers.Add("Accept", "application/zip");

            WebResponse webResponse = request.GetResponse();
            Stream responseStream = webResponse.GetResponseStream();
            if (responseStream == null)
                throw new Exception("Null response stream getting new igpublisher.jar");
            String jarPath = Path.Combine(this.TemplateDir, "org.hl7.fhir.igpublisher.jar");

            using (Stream output = File.Create(jarPath))
            {
                responseStream.CopyTo(output);
            }
        }
    }
}
