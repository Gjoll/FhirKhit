using FhirKhit.Tools;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Adapter;
using Xunit;
using System.Text;

#if FHIR_R2
using FhirKhit.Tools.R2;
#elif FHIR_R3
using FhirKhit.Tools.R3;
#elif FHIR_R4
using FhirKhit.Tools.R4;
#endif

namespace FhirKhit.Tools.SharedTests
{
    public class ModelLabTests
    {
#if FHIR_R2
        const String VStr = "R2";
#elif FHIR_R3
        const String VStr = "R3";
#elif FHIR_R4
        const String VStr = "R4";
#endif

        readonly String profileSaveDir = Path.GetFullPath(@".\Profiles");

        const SaveTypes SaveType = SaveTypes.Json;

        String TestFile(String fileName) => Path.Combine("TestFiles", fileName);

        String TestOutputDir => Path.GetFullPath(".\\Output");

        ModelLabProject GetPublicProject(String projectName)
        {
            String modelsDir = this.TestOutputDir;
            DirHelper.CreateCleanDir(modelsDir);

            ModelLabApiReader p = new ModelLabApiReader("https://www.modelinglab.org");
            return p.PullModelLabProjectByName(projectName, out String projectPath);
        }

        void TraceErrors(ConverterBase converter)
        {
            StringBuilder sb = new StringBuilder();
            if (converter.FormatMessages(sb))
                Trace.WriteLine(sb);
        }

        ModelLabToModelDefConvertor CreateTestConvertor(IModelLabReader p)
        {
            String outputDir = this.TestOutputDir;
            DirHelper.CleanDir(outputDir);

            ModelLabToModelDefConvertor retVal = new ModelLabToModelDefConvertor(p);
            retVal.Date = new FhirDateTime(new DateTimeOffset(2001, 1, 1, 1, 1, 1, new TimeSpan(0)));
            return retVal;
        }


        string ModelsDir => Path.Combine(DirHelper.FindParentDir("FhirKhit"),
            "Data",
            "ModelLabWorkingData",
            "Models");

        string IGDir => Path.Combine(DirHelper.FindParentDir("FhirKhit"),
            "Data",
            $"IGTemplate.{VStr}");

        string ModelDefDir => Path.Combine(DirHelper.FindParentDir("FhirKhit"),
            "Data",
            "ModelLabWorkingData",
            "ModelDefinitions");

        string StructDefDir => Path.Combine(DirHelper.FindParentDir("FhirKhit"),
            "Data",
            "ModelLabWorkingData",
            "StructureDefinitions");

        String TestPath(String fileName) => Path.Combine(".", "TestData", fileName);
        String TestOutputPath(String name) => Path.Combine(this.TestOutputDir, name);

        StructureDefinition TestOutputModelDef(String name)
        {
            String path = this.TestOutputPath(name);
            String fhirText = File.ReadAllText(path);
            FhirXmlParser parser = new FhirXmlParser();
            return parser.Parse<StructureDefinition>(fhirText);
        }

        /// <summary>
        /// Pull all Public projects and store the json data files.
        /// The Modzilla server must (in the net) be running for this to work.
        /// </summary>
        [Fact(DisplayName = "ModelLab.PullAllPublicProjects")]
        [Trait("Test", "helper")]
        void PullAllPublicProjects() => this.PullAllProjects("https://www.modelinglab.org");

        [Fact(DisplayName = "ModelLab.PullAllLocalProjects")]
        [Trait("Test", "helper")]
        void PullAllLocalProjects() => this.PullAllProjects("http://localhost:5000");

        void PullAllProjects(String url)
        {
            String modelsDir = this.ModelsDir;
            DirHelper.CreateCleanDir(modelsDir);

            ModelLabApiReader p = new ModelLabApiReader(url);
            p.PullAllProjects(modelsDir);
        }

        [Fact(DisplayName = "ModelLab.GetLocalBreastCancer")]
        [Trait("Test", "helper")]
        void GetLocalBreastCancer() => this.GetBreastCancer("http://localhost:5000");

        [Fact(DisplayName = "ModelLab.GetPublicBreastCancer")]
        [Trait("Test", "helper")]
        void GetPublicBreastCancer() => this.GetBreastCancer("https://www.modelinglab.org");

        void GetBreastCancer(String url)
        {
            ModelLabProject project;
            {
                String modelsDir = this.TestOutputDir;
                DirHelper.CreateCleanDir(modelsDir);

                ModelLabApiReader p = new ModelLabApiReader(url);
                project = p.PullModelLabProjectByName("Breast Radiology Reporting", out String projectPath);
            }
            {
                ModelLabToModelDefConvertor converter = this.CreateTestConvertor(project);
                converter.Project.ConfigData.Save(@"c:\Temp\Breast Radiology Reporting.json");
            }
        }

        [Fact(DisplayName = "ModelLab.PublicBreastCancer_Validate")]
        [Trait("Test", "test")]
        void PublicBreastCancer_Validate()
        {
            this.PublicBreastCancer_Convert();
            this.profiles.Save(this.profileSaveDir, SaveType);

            FhirValidator v = new FhirValidator
            {
                FailOnWarnings = false
            };

            bool success = v.ValidateDir(this.profileSaveDir, "*.StructureDefinition.json", FhirKhitVersion.FhirVersion);
            this.TraceErrors(v);
            Assert.True(success);
        }

        [Fact(DisplayName = "ModelLab.PublicBreastCancer_ManualPublish")]
        [Trait("Test", "test")]
        void PublicBreastCancer_ManualPublish()
        {
            String templateDir = @"C:\Development\Modzilla2\Solutions\FhirKhit\Data\IGTemplate.R4";
            IGPublisher igPublisher = new IGPublisher(templateDir);
            bool success = igPublisher.Publish();
            this.TraceErrors(igPublisher);
            Assert.True(success);
        }

        [Fact(DisplayName = "ModelLab.PublicBreastCancer_Publish")]
        [Trait("Test", "test")]
        void PublicBreastCancer_Publish()
        {
            this.PublicBreastCancer_Convert();

            //{
            //    IGPublisher igMaker = new IGPublisher(IGDir);
            //    igMaker.GetPublisherJar();
            //}
            {
                this.profiles.GenerateSnapshots();
                this.logicalModelDefs.GenerateSnapshots();
                IGMaker igMaker = this.profiles.CreateIGMaker(this.IGDir);
                igMaker.AddLogicalModels(this.logicalModelDefs);
                igMaker.Save();
                bool success = igMaker.Publish();
                this.TraceErrors(igMaker);
                Assert.True(success);
            }
        }

        ModelDefProject logicalModelDefs;
        ModelDefProject profiles;
        ModelDefProject flattened;

        [Fact(DisplayName = "ModelLab.PublicBreastCancer_Convert")]
        [Trait("Test", "test")]
        void PublicBreastCancer_Convert()
        {
            bool useLocal = false;

            this.logicalModelDefs = new ModelDefProject();
            {
                IModelLabReader modelLabReader;
                {
                    String modelsDir = this.TestOutputDir;
                    DirHelper.CreateCleanDir(modelsDir);
                    if (useLocal)
                    {
                        modelLabReader = ModelLabProject.LoadFromFile(Path.Combine(this.ModelsDir, "cfg.projects.cancer.breastcancer.breastRadiologyReporting.project"));
                    }
                    else
                    {
                        modelLabReader = new ModelLabApiReader("https://www.modelinglab.org");
                    }
                }

                ModelLabToModelDefConvertor converter = this.CreateTestConvertor(modelLabReader);
                converter.LoadProjectByName("Breast Radiology Reporting");

                bool success = converter.Convert();
                this.TraceErrors(converter);
                Assert.True(success);
                this.logicalModelDefs = converter.OutputCache;
                this.logicalModelDefs.Save(@"c:\Temp\Tests\LogicalModelDefs");
            }

            {
                this.flattened = new ModelDefProject();
                ModelDefFlattener flattener = new ModelDefFlattener(this.logicalModelDefs, this.flattened);
                bool success = flattener.Flatten();
                this.TraceErrors(flattener);
                Assert.True(success);
                this.logicalModelDefs
                    .CopyProjectData(this.flattened)
                    .CopyValueSets(this.flattened)
                    .CopyExtensions(this.flattened)
                    ;
                this.flattened.Save(@"c:\Temp\Tests\Flattened");
            }

            this.profiles = new ModelDefProject();
            {
                ModelDefToProfileConverter profiler = new ModelDefToProfileConverter(this.flattened, this.profiles);
                bool success = profiler.MapAll();

                this.TraceErrors(profiler);
                Assert.True(success);
                String profileSaveDir = Path.GetFullPath(@".\Profiles");
                this.profiles.Save(@"c:\Temp\Tests\Profiles");
            }
        }
    }
}
