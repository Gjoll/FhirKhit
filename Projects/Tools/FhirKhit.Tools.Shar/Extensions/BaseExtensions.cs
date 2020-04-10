using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using System.Threading;
using Eir.DevTools;

#if FHIR_R4
namespace FhirKhit.Tools.R4
#elif FHIR_R3
namespace FhirKhit.Tools.R3
#endif
{
    public static class BaseExtensions
    {
        /// <summary>
        /// Save Fhir item
        /// </summary>
        public static void Save(this Base fhirBase, String path, SaveType saveType)
        {
            switch (saveType)
            {
                case SaveType.Json: fhirBase.SaveJson(path + ".json"); break;
                case SaveType.Xml: fhirBase.SaveXml(path + ".xml"); break;
                default: throw new NotImplementedException();
            }
        }

        /// <summary>
        /// SaveXml file
        /// </summary>
        /// <param name="outputDir"></param>
        public static void SaveXml(this Base fhirBase, String path)
        {
            FhirXmlSerializer fxs = new FhirXmlSerializer();
            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true,
                IndentChars = "  ",
                NewLineOnAttributes = false
            };

            using (StreamWriter sw = File.CreateText(path))
            using (XmlWriter xmlWriter = XmlWriter.Create(sw, settings))
            {
                fxs.Serialize(fhirBase, xmlWriter);
                xmlWriter.Flush();
                xmlWriter.Close();
            }
        }

        /// <summary>
        /// Save Fhir item as JSON file
        /// </summary>
        public static void SaveJson(this Base fhirBase, String path)
        {
            String outputDir = Path.GetDirectoryName(path);
            if (Directory.Exists(outputDir) == false)
                Directory.CreateDirectory(outputDir);
            FileTools.WriteAllText(path, fhirBase.ToFormatedJson());
        }

        /// <summary>
        /// Save Fhir item as JSON file
        /// </summary>
        public static String ToFormatedJson(this Base fhirBase)
        {
            FhirJsonSerializer fjs = new FhirJsonSerializer();
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);
            using (JsonWriter jsonWriter = new JsonTextWriter(sw))
            {
                jsonWriter.Formatting = Newtonsoft.Json.Formatting.Indented;
                fjs.Serialize(fhirBase, jsonWriter);
                jsonWriter.Flush();
                jsonWriter.Close();
            }
            return sb.ToString();
        }
    }
}

