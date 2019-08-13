using FhirKhit.Tools;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Xml;
using System.Net;
using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FhirKhit.Tools
{
    /// <summary>
    /// Convert model lab files to modeldef files.
    /// 
    /// Todo:
    /// </summary>
    public class ModelLabApiReader : IModelLabReader
    {
        readonly String baseUrl;

        public JArray ModelList
        {
            get
            {
                if (this.modelList == null)
                    this.modelList = this.GetModelList();
                return this.modelList;
            }
        }
        private JArray modelList = null;

        /// <summary>
        /// Constructor.
        /// </summary>
        public ModelLabApiReader(String baseUrl)
        {
            this.baseUrl = baseUrl;
        }

        static ModelLabApiReader()
        {
            ServicePointManager
                .ServerCertificateValidationCallback +=
                (sender, cert, chain, sslPolicyErrors) => true;
        }

        JObject RestCall(String commandPath)
        {
            String url = $"{this.baseUrl}{commandPath}";
            Log.Info("ModelLabReader.RestCall", $"Executing rest command {url}");

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            WebResponse webResponse = request.GetResponse();
            Stream webStream = webResponse.GetResponseStream();
            StreamReader responseReader = new StreamReader(webStream);
            String response = responseReader.ReadToEnd();
            return JsonConvert.DeserializeObject<JObject>(response);
        }

        JArray GetModelList()
        {
            JObject projects = this.RestCall("/api/modelquery/GetModelList");
            return (JArray)projects["projectList"];
        }

        /// <summary>
        /// Pull indicated section.
        /// </summary>
        /// <param name="inputFile"></param>
        public ConfigData PullSectionByGuid(Guid sectionGuid)
        {
            JObject section = this.RestCall($"/api/modelquery/GetSectionContent?guid={sectionGuid.ToString()}");
            if (section == null)
                throw new Exception("Section {sectionGuid.ToString()} not found on server");

            return ConfigData.Load(section);

            //JObject section = this.RestCall($"/api/modelquery/GetSectionContent?guid={sectionGuid.ToString()}");
            //if (section == null)
            //    throw new Exception("Section {sectionGuid.ToString()} not found on server");

            //return new ModelSectionData(ConfigData.Load(section));
        }

        /// <summary>
        /// Pull all the projects from the model lab server (shich must be running)
        /// and store the output json file in the indicated output dir.
        /// </summary>
        /// <param name="inputFile"></param>
        public void PullAllProjects(String outputDir)
        {
            JArray projectList = this.ModelList;
            foreach (JToken item in projectList)
            {
                JValue projectPathValue = (JValue)item["path"];
                String projectPath = (string)projectPathValue.Value;
                JObject project = this.PullProjectJson(item);
                this.SaveProject(outputDir, projectPath, project);
            }
        }

        public ConfigData PullProjectByGuid(Guid projectGuid)
        {
            JObject project = this.RestCall($"/api/modelquery/GetProjectContent?guid={projectGuid}");
            return ConfigData.Load(project);
        }

        public ConfigData PullProjectByName(String projectName, out String projectPath)
        {
            projectPath = null;
            JArray projectList = this.ModelList;
            foreach (JToken item in projectList)
            {
                JValue projectPathValue = (JValue)item["path"];
                projectPath = (string)projectPathValue.Value;

                String title = item["title"].Value<String>();
                if (title == projectName)
                {
                    JObject project = this.PullProjectJson(item);
                    return ConfigData.Load(project);
                }
            }
            return null;
        }

        JObject PullProjectJson(JToken item)
        {
            JValue projectPathValue = (JValue)item["path"];
            JValue projectGuidValue = (JValue)item["guid"];
            String projectPath = (string)projectPathValue.Value;
            Guid projectGuid = Guid.Parse((string)projectGuidValue.Value);
            JObject project = this.RestCall($"/api/modelquery/GetProjectContent?guid={projectGuid}");
            return project;
        }

        public String ProjectJson(JObject project) => JsonConvert.SerializeObject(project, Newtonsoft.Json.Formatting.Indented);

        public void SaveProject(String outputDir, String projectPath, JObject project)
        {
            String jsonText = this.ProjectJson(project);

            String outputPath = Path.Combine(outputDir, $"{projectPath}.project");
            File.WriteAllText(outputPath, jsonText);
            Log.Info("ModelLabReader.SaveProject", $"Saving project '{project["title"]}' to {outputPath}");
        }
    }
}
