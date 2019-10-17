using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// <summary>
    /// Edit ig.json file.
    /// </summary>
    public class IGEditor
    {
        private readonly JObject ig;

        private JObject resourcesJson => (JObject)this.ig["resources"];
        public JArray dependencyListJson => (JArray)this.ig["dependencyList"];

        public static IGEditor Load(String path)
        {
            if (File.Exists(path) == false)
                throw new Exception($"Missing JSON file {path}");
            String jsonText = File.ReadAllText(path);

            using (JsonReader reader = new JsonTextReader(new StringReader(jsonText)))
            {
                IGEditor retVal = new IGEditor(JObject.Load(reader));
                retVal.resourcesJson.RemoveAll();
                return retVal;
            };
        }

        public IGEditor(JObject ig)
        {
            this.ig = ig;
        }

        public void Save(String path) => File.WriteAllText(path, this.ig.ToString());

        public IGEditor ReplaceProperty(String propertyPath, String propertyName, String propertyValue)
        {
            JObject parent = (JObject)this.ig.SelectToken(propertyPath);
            JProperty p = parent.Property(propertyName);
            if (p != null)
                p.Value = propertyValue;
            else
                this.ig.Add(new JProperty(propertyName, propertyValue));
            return this;
        }

        public IGEditor ReplaceProperty(String propertyName, String propertyValue)
        {
            JProperty p = this.ig.Property(propertyName);
            if (p != null)
                p.Value = propertyValue;
            else
                this.ig.Add(new JProperty(propertyName, propertyValue));
            return this;
        }

        public IGEditor FullLogging()
        {
            JProperty p = this.ig.Property("logging");
            JArray value = new JArray("init", "progress", "context", "html", "tx");
            if (p != null)
                p.Value = value;
            else
                this.ig.Add(new JProperty("logging", value));
            return this;
        }

        public IGEditor AddResource(String resourcePath, String href)
        {
            JObject item = new JObject();
            item.Add("base", href);

            this.resourcesJson.Add(resourcePath, item);
            return this;
        }
    }
}
