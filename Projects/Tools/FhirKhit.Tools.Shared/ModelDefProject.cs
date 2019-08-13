using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

#if FHIR_R4
namespace FhirKhit.Tools.R4
#elif FHIR_R3
namespace FhirKhit.Tools.R3
#elif FHIR_R2
namespace FhirKhit.Tools.R2
#endif
{
    /// <summary>
    /// Caches Model Definition's.
    /// </summary>
    public class ModelDefProject
    {
        public class ReferenceItem
        {
            public String ReferenceUrl;
            public String Reference;
            public String Description;
        }

        public class AuthorItem
        {
            public String Name;
            public String EMail;
        }

        public class ProjectDataClass
        {
            public String BaseUrl {get; set; }
            public String ImplementationGuideUrl {get; set; }

            public String AbbreviatedProjectName
            {
                get { return this.abbreviatedProjectName; }
                set { this.abbreviatedProjectName = value?.ToMachineName(); }
            }

            private String abbreviatedProjectName {get; set; }
            public String LongProjectName {get; set; }
            public String PublicationStatus {get; set; }
            public String ProjectVersion {get; set; }
            public String NameOfPublishingEntity {get; set; }
            public String ProjectContactUrl {get; set; }
            public String ProjectCopyrightText {get; set; }
            public String IGOverviewMarkdown {get; set; }
            public String NameSpace {get; set; }

            public List<ReferenceItem> ReferenceItems  {get; set; } = new List<ReferenceItem>();
            public List<AuthorItem> AuthorItems  {get; set; } = new List<AuthorItem>();
        }

        public ProjectDataClass ProjectData  {get; set; } = new ProjectDataClass();

        private readonly Dictionary<String, StructureDefinition> modelDefs = new Dictionary<String, StructureDefinition>();
        private readonly Dictionary<String, ValueSet> valueSets = new Dictionary<String, ValueSet>();
        private readonly Dictionary<String, StructureDefinition> extensions = new Dictionary<String, StructureDefinition>();

        public Int32 Models => this.modelDefs.Count;
        public Int32 ValueSets => this.valueSets.Count;
        public Int32 Extensions => this.extensions.Count;

        public ModelDefProject CopyProjectData(ModelDefProject outputProject)
        {
            outputProject.ProjectData = this.ProjectData;
            return this;
        }

        public ModelDefProject CopyExtensions(ModelDefProject outputProject)
        {
            foreach (StructureDefinition extension in this.extensions.Values)
                outputProject.AddExtension(extension);
            return this;
        }

        public ModelDefProject CopyValueSets(ModelDefProject outputProject)
        {
            foreach (ValueSet valueSet in this.valueSets.Values)
                outputProject.AddValueSet(valueSet);
            return this;
        }

        /// <summary>
        /// Create IG Maker and populate it with values form project.
        /// </summary>
        /// <returns></returns>
        public IGMaker CreateIGMaker(String igDir)
        {
            IGMaker igMaker = new IGMaker(igDir,
                        this.ProjectData.BaseUrl,
                        this.ProjectData.AbbreviatedProjectName,
                        this.ProjectData.LongProjectName,
                        this.ProjectData.AbbreviatedProjectName);
            igMaker.AddSourceItems(this);
            igMaker.SetStatus(this.ProjectData.PublicationStatus.ToPublicationStatus());
            igMaker.SetVersion(this.ProjectData.ProjectVersion);
            igMaker.SetPublisher(this.ProjectData.NameOfPublishingEntity);
            igMaker.SetContactUrl(this.ProjectData.ProjectContactUrl);
            igMaker.SetCopyright(this.ProjectData.ProjectCopyrightText);
            igMaker.SetOverview(this.ProjectData.IGOverviewMarkdown);
            igMaker.SetIGVersion(FhirKhitVersion.FhirVersion);
            //.AddReference("www.nowhere.com/b", "Nowhere-a", "There is nothing there")       //$$$$
            //.AddReference("http://www.nowhere.com/a", "Nowhere-b", "Desolated")             //$$$$
            return igMaker;
        }

        static T LoadJson<T>(String path)
            where T : Base
        {
            String fhirText = File.ReadAllText(path);
            FhirJsonParser parser = new FhirJsonParser();
            return parser.Parse<T>(fhirText);
        }

        public Boolean FindExtension(String url, out StructureDefinition modelDef) => this.extensions.TryGetValue(url.ToUpper(), out modelDef);

        public void AddExtension(StructureDefinition modelDef)
        {
            if (this.extensions.ContainsKey(modelDef.Url.ToUpper()) == false)
                this.extensions.Add(modelDef.Url.ToUpper(), modelDef);
        }

        public Boolean RemoveModelDef(String url) => this.modelDefs.Remove(url.ToUpper());

        public void AddModelDef(StructureDefinition modelDef)
        {
            if (this.modelDefs.ContainsKey(modelDef.Url.ToUpper()) == false)
                this.modelDefs.Add(modelDef.Url.ToUpper(), modelDef);
        }

        public void AddValueSet(ValueSet valueSet)
        {
            if (this.valueSets.ContainsKey(valueSet.Url.ToUpper()) == false)
                this.valueSets.Add(valueSet.Url.ToUpper(), valueSet);
        }

        public IEnumerable<StructureDefinition> GetStructureDefinitions()
        {
            foreach (StructureDefinition modelDef in this.modelDefs.Values)
                yield return modelDef;
        }

        public IEnumerable<StructureDefinition> GetModelDefinitions() => this.modelDefs.Values;

        public IEnumerable<ValueSet> GetValueSets()
        {
            foreach (ValueSet valueSet in this.valueSets.Values)
                yield return valueSet;
        }

        public Boolean FindModelByUrl(String url, out StructureDefinition sdef) => this.modelDefs.TryGetValue(url.ToUpper(), out sdef);

        public StructureDefinition FindModelByName(String name)
        {
            foreach (StructureDefinition modelDef in this.modelDefs.Values)
            {
                if (modelDef.Name == name)
                    return modelDef;
            }
            return null;
        }

        public IEnumerable<StructureDefinition> GetExtensions()
        {
            foreach (StructureDefinition extension in this.extensions.Values)
                yield return extension;
        }

        public void Load(String outputBaseDir, String name) => this.Load(Path.Combine(outputBaseDir, name));

        public void Load(String inputDir)
        {
            String text = File.ReadAllText(Path.Combine(inputDir, $"ProjectData.json"));
            this.ProjectData = JsonConvert.DeserializeObject<ProjectDataClass>(text);

            FhirJsonParser parser = new FhirJsonParser();

            {
                FhirJsonParser jsonParser = new FhirJsonParser();

                foreach (String file in Directory.GetFiles(Path.Combine(inputDir, "Resources"), "*.StructureDefinition.json"))
                    this.AddModelDef(jsonParser.Parse<StructureDefinition>(File.ReadAllText(file)));
                foreach (String file in Directory.GetFiles(Path.Combine(inputDir, "Extensions"), "*.StructureDefinition.json"))
                    this.AddExtension(jsonParser.Parse<StructureDefinition>(File.ReadAllText(file)));
                foreach (String file in Directory.GetFiles(Path.Combine(inputDir, "ValueSets"), "*.ValueSet.json"))
                    this.AddValueSet(jsonParser.Parse<ValueSet>(File.ReadAllText(file)));
            }

            {
                FhirXmlParser xmlParser = new FhirXmlParser();

                foreach (String file in Directory.GetFiles(Path.Combine(inputDir, "Resources"), "*.StructureDefinition.xml"))
                    this.AddModelDef(xmlParser.Parse<StructureDefinition>(File.ReadAllText(file)));
                foreach (String file in Directory.GetFiles(Path.Combine(inputDir, "Extensions"), "*.StructureDefinition.xml"))
                    this.AddExtension(xmlParser.Parse<StructureDefinition>(File.ReadAllText(file)));
                foreach (String file in Directory.GetFiles(Path.Combine(inputDir, "ValueSets"), "*.ValueSet.xml"))
                    this.AddValueSet(xmlParser.Parse<ValueSet>(File.ReadAllText(file)));
            }
        }

        public void GenerateSnapshots()
        {
            foreach (StructureDefinition modelDef in this.GetModelDefinitions())
                SnapshotCreator.Create(modelDef);
            foreach (StructureDefinition extension in this.GetExtensions())
                SnapshotCreator.Create(extension);
        }

        public String Save(String outputBaseDir, SaveTypes saveType = SaveTypes.Json)
        {
            String outputDir = Path.Combine(outputBaseDir, this.ProjectData.AbbreviatedProjectName);
            DirHelper.CreateCleanDir(outputDir);

            File.WriteAllText(Path.Combine(outputDir, $"ProjectData.json"),
                JsonConvert.SerializeObject(this.ProjectData, Newtonsoft.Json.Formatting.Indented));
            {
                String sdefDir = Path.Combine(outputDir, "Resources");
                Directory.CreateDirectory(sdefDir);
                foreach (StructureDefinition model in this.modelDefs.Values)
                    model.Save(Path.Combine(sdefDir, $"{model.Id}.StructureDefinition"), saveType);
            }

            {
                String extDir = Path.Combine(outputDir, "Extensions");
                Directory.CreateDirectory(extDir);
                foreach (StructureDefinition extension in this.extensions.Values)
                    extension.Save(Path.Combine(extDir, $"{extension.Id}.StructureDefinition"), saveType);
            }

            {
                String vsDir = Path.Combine(outputDir, "ValueSets");
                Directory.CreateDirectory(vsDir);
                foreach (ValueSet valueSet in this.valueSets.Values)
                    valueSet.Save(Path.Combine(vsDir, $"{valueSet.Id}.ValueSet"), saveType);
            }

            return outputDir;
        }

        public void CreateSnapshots()
        {
            foreach (StructureDefinition modelDef in this.modelDefs.Values)
                SnapshotCreator.Create(modelDef);
            foreach (StructureDefinition extension in this.extensions.Values)
                SnapshotCreator.Create(extension);
        }
    }
}
