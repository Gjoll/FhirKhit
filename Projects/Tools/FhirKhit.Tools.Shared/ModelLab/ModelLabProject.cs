using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json.Linq;
using FhirKhit.Tools;

#if FHIR_R4
namespace FhirKhit.Tools.R4
#elif FHIR_R3
namespace FhirKhit.Tools.R3
#elif FHIR_R2
namespace FhirKhit.Tools.R2
#endif
{
    public class ModelLabProject : IModelLabReader
    {
        public String BaseUrl => this.ConfigData.Project_BaseUrl.ValueOrError();

        public String Title => this.ConfigData.Title;
        public String Id => this.ConfigData.Id;
        public Guid Guid => this.ConfigData.Guid;

        public readonly Dictionary<Guid, ModelSectionData> ModelSections = new Dictionary<Guid, ModelSectionData>();
        public readonly Dictionary<Guid, ValueSetData> ValueSets = new Dictionary<Guid, ValueSetData>();
        public ConfigData ConfigData { get; set; }

        private ModelLabProject()
        {

        }

        private ModelLabProject(ConfigData configData)
        {
            this.ConfigData = configData;
            foreach (ConfigData sectionData in this.ConfigData.Children)
            {
                ModelSectionData model = new ModelSectionData(sectionData);
                this.ModelSections.Add(model.Guid, model);
            }
        }

        public static ModelLabProject LoadFromFile(String projectFile)
        {
            String modelText = File.ReadAllText(projectFile);
            return LoadFromJsonString(modelText);
        }

        public static ModelLabProject LoadFromJOBject(JObject section)
        {
            return Load(ConfigData.Load(section));
        }

        public static ModelLabProject Load(ConfigData data)
        {
            return new ModelLabProject(data);
        }

        public static ModelLabProject LoadFromJsonString(String modelText)
        {
            ModelLabProject retVal = new ModelLabProject();
            retVal.ConfigData = ConfigData.Load(modelText);
            foreach (ConfigData sectionData in retVal.ConfigData.Children)
            {
                ModelSectionData model = new ModelSectionData(sectionData);
                retVal.ModelSections.Add(model.Guid, model);
            }

            return retVal;
        }

        public ConfigData PullSectionByGuid(Guid sectionGuid)
        {
            if (this.ModelSections.TryGetValue(sectionGuid, out ModelSectionData retVal) == true)
                return retVal.ConfigData;

            throw new Exception("Section not found/loaded");
        }

        public ConfigData PullProjectByGuid(Guid projectGuid)
        {
            throw new NotImplementedException();
        }

        public ConfigData PullProjectByName(string projectName, out string projectPath)
        {
            throw new NotImplementedException();
        }
    }
}
