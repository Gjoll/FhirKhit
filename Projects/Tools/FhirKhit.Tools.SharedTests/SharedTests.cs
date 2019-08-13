using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using Xunit;
using System.Collections.Generic;

#if FHIR_R2
using FhirKhit.Tools.R2;
#elif FHIR_R3
using FhirKhit.Tools.R3;
#elif FHIR_R4
using FhirKhit.Tools.R4;
#endif

namespace FhirKhit.Tools.SharedTests
{
#if FHIR_R2
    public class FhirKhit_R2_Tests
    {
        const String TemplateDir = "IGTemplate.R2";
#elif FHIR_R3
    public class FhirKhit_R3_Tests
    {
        const String TemplateDir = "IGTemplate.R3";
#elif FHIR_R4
    public class FhirKhit_R4_Tests
    {
        const String TemplateDir = "IGTemplate.R4";
#endif

        string DataDir => Path.Combine(DirHelper.FindParentDir("FhirKhit"), "Data");

        StructureDefinition LoadModelDefinition(String path)
        {
            String fhirText = File.ReadAllText(path);
            FhirJsonParser parser = new FhirJsonParser();
            return parser.Parse<StructureDefinition>(fhirText);
        }

        StructureDefinition LoadTestModelDefinition(String name)
        {
            String path = this.TestFile(name);
            String fhirText = File.ReadAllText(path);
            FhirJsonParser parser = new FhirJsonParser();
            return parser.Parse<StructureDefinition>(fhirText);
        }

        String TestFile(String fileName) => Path.Combine("TestFiles", fileName);

        String TestOutputDir => Path.GetFullPath(".\\Output");

        string ModelsDir => Path.Combine(DirHelper.FindParentDir("FhirKhit"),
            "Data",
            "ModelLabWorkingData",
            "Models");

        string IGDir => Path.Combine(DirHelper.FindParentDir("FhirKhit"),
            "Data",
            TemplateDir);

        string ModelDefDir => Path.Combine(DirHelper.FindParentDir("FhirKhit"),
            "Data",
            "ModelLabWorkingData",
            "ModelDefinitions");

        string StructDefDir => Path.Combine(DirHelper.FindParentDir("FhirKhit"),
            "Data",
            "ModelLabWorkingData",
            "StructureDefinitions");

        ElementDefinition CreateElementDefinition(String propertyPath,
            String elementType,
            ElementDefinitionMap map = null)
        {
            List<ElementDefinition.TypeRefComponent> type = new List<ElementDefinition.TypeRefComponent>();
            ElementDefinition.TypeRefComponent typeRef = new ElementDefinition.TypeRefComponent
            {
#if FHIR_R2
                Code = elementType.ToFhirType()
#else
                Code = elementType
#endif
            };
            type.Add(typeRef);

            ElementDefinition retVal = new ElementDefinition
            {
                ElementId = propertyPath,
                Min = 0,
                Max = "1",

#if FHIR_R2
                Definition = "Test Definition",
#elif FHIR_R3
                Definition = "Test Definition",
#elif FHIR_R4
                Definition = new Markdown("Test Definition"),
#endif
                Path = propertyPath,
                Type = type
            };

            if (map != null)
                retVal.SetMap(map);

            return retVal;
        }

        [Fact(DisplayName = "ModelLab.ElementDefinitionMap")]
        [Trait("Test", "test")]
        void ElementDefinitionMap()
        {
            List<ElementDefinition> elementDefinitions = new List<ElementDefinition>();
            elementDefinitions.Add(this.CreateElementDefinition("alpha.one", "string"));
            elementDefinitions.Add(this.CreateElementDefinition("alpha.two", "integer"));
            elementDefinitions.Add(this.CreateElementDefinition("alpha.three", "code"));
            elementDefinitions.Add(this.CreateElementDefinition("alpha.four", "datetime"));
            elementDefinitions[0].Max = "*";
            ModelDefProject modelDefCache = new ModelDefProject();
            {
                StructureDefinition sd = new StructureDefinition();
                ElementDefinitionMap map = new ElementDefinitionMap(new ElementDefinitionMatch("target.type in ['string']"),
                    "Update();", "SNOMED", "1000000", "");
                ElementDefinition sourceDef = this.CreateElementDefinition("beta.one", "string");
                ElementDefinition targetDef = map.MapElement(modelDefCache, null, null, sd, sourceDef, elementDefinitions);
                Assert.True(targetDef.Path == "alpha.one");
                ElementDefinition copiedDef = sd.Differential.Element.FindByPath("beta.one");
                Assert.True(copiedDef != null);
                Assert.True(copiedDef.Max == "1");
            }
            {
                StructureDefinition sd = new StructureDefinition();
                ElementDefinitionMap map = new ElementDefinitionMap(new ElementDefinitionMatch("target.type in ['string']"),
                    "Overwrite();", "SNOMED", "1000000", "");
                ElementDefinition sourceDef = this.CreateElementDefinition("beta.one", "string");
                ElementDefinition targetDef = map.MapElement(modelDefCache, null, null, sd, sourceDef, elementDefinitions);
                Assert.True(targetDef.Path == "alpha.one");
                ElementDefinition copiedDef = sd.Differential.Element.FindByPath("beta.one");
                Assert.True(copiedDef != null);
            }

            {
                StructureDefinition sd = new StructureDefinition();
                ElementDefinitionMap map = new ElementDefinitionMap(new ElementDefinitionMatch("target.type in [... 'Time' ...]"),
                    "Message('Message');", "SNOMED", "1000000", "");
                ElementDefinition sourceDef = this.CreateElementDefinition("alpha.one", "string");
                ElementDefinition targetDef = map.MapElement(modelDefCache, null, null, sd, sourceDef, elementDefinitions);
                Assert.True(targetDef != null);
            }
            {
                StructureDefinition sd = new StructureDefinition();
                ElementDefinitionMap map = new ElementDefinitionMap(new ElementDefinitionMatch("target.type in [... 'Timx' ...]"),
                    "Abort('Message');", "SNOMED", "1000000", "");
                ElementDefinition sourceDef = this.CreateElementDefinition("alpha.one", "string");
                ElementDefinition targetDef = map.MapElement(modelDefCache, null, null, sd, sourceDef, elementDefinitions);
                Assert.True(targetDef == null);
            }
            {
                StructureDefinition sd = new StructureDefinition();
                ElementDefinitionMap map = new ElementDefinitionMap(new ElementDefinitionMatch("target.type in [... 'Time' ...]"),
                    "Abort('Abort Message');", "SNOMED", "1000000", "");
                ElementDefinition sourceDef = this.CreateElementDefinition("alpha.one", "string");
                Assert.ThrowsAny<Exception>(() =>
                {
                    map.MapElement(modelDefCache, null, null, sd, sourceDef, elementDefinitions);
                });
            }
            {
                StructureDefinition sd = new StructureDefinition();
                ElementDefinitionMap map = new ElementDefinitionMap(new ElementDefinitionMatch("target.type in [... 'Time' ...]"),
                    "Ignore();", "SNOMED", "1000000", "");
                ElementDefinition sourceDef = this.CreateElementDefinition("alpha.one", "string");
                ElementDefinition targetDef = map.MapElement(modelDefCache, null, null, sd, sourceDef, elementDefinitions);
                Assert.True(targetDef.Path == "alpha.four");
            }
        }

        [Fact(DisplayName = "ModelLab.ElementDefinitionMatch")]
        [Trait("Test", "test")]
        void ElementDefinitionMatch()
        {
            List<ElementDefinition> elementDefinitions = new List<ElementDefinition>();
            ElementDefinition source = this.CreateElementDefinition("alpha.one", "string");

            elementDefinitions.Add(this.CreateElementDefinition("alpha.one", "string"));
            elementDefinitions.Add(this.CreateElementDefinition("alpha.two", "integer"));
            elementDefinitions.Add(this.CreateElementDefinition("alpha.three", "code"));
            elementDefinitions.Add(this.CreateElementDefinition("alpha.four", "datetime"));

            {
                ElementDefinitionMatch m = new ElementDefinitionMatch("(true) && (false)");
                ElementDefinition[] results = m.Process(null, elementDefinitions).ToArray();
                Assert.True(results.Length == 0);
            }

            {
                ElementDefinitionMatch m = new ElementDefinitionMatch("source.type in ['string', 'integer', 'xxyya']");
                ElementDefinition[] results = m.Process(source, elementDefinitions).ToArray();
                Assert.True(results.Length == 4);
            }

            {
                ElementDefinitionMatch m = new ElementDefinitionMatch("source.type in ['integer', 'xxyya']");
                ElementDefinition[] results = m.Process(source, elementDefinitions).ToArray();
                Assert.True(results.Length == 0);
            }

            {
                ElementDefinitionMatch m = new ElementDefinitionMatch("source.path == 'alpha.one'");
                ElementDefinition[] results = m.Process(source, elementDefinitions).ToArray();
                Assert.True(results.Length == 4);
            }

            {
                ElementDefinitionMatch m = new ElementDefinitionMatch("source.path == 'alpha.on'");
                ElementDefinition[] results = m.Process(source, elementDefinitions).ToArray();
                Assert.True(results.Length == 0);
            }

            {
                ElementDefinitionMatch m = new ElementDefinitionMatch("true");
                ElementDefinition[] results = m.Process(null, elementDefinitions).ToArray();
                Assert.True(results.Length == 4);
            }

            {
                ElementDefinitionMatch m = new ElementDefinitionMatch("false");
                ElementDefinition[] results = m.Process(null, elementDefinitions).ToArray();
                Assert.True(results.Length == 0);
            }

            {
                ElementDefinitionMatch m = new ElementDefinitionMatch("'on' == target.path[1...]");
                ElementDefinition[] results = m.Process(null, elementDefinitions).ToArray();
                Assert.True(results.Length == 0);
            }

            {
                ElementDefinitionMatch m = new ElementDefinitionMatch("'one' == target.path[1...]");
                ElementDefinition[] results = m.Process(null, elementDefinitions).ToArray();
                Assert.True(results.Length == 1);
            }

            {
                ElementDefinitionMatch m = new ElementDefinitionMatch("target.path[0] in [... 'alphax' ...]");
                ElementDefinition[] results = m.Process(null, elementDefinitions).ToArray();
                Assert.True(results.Length == 0);
            }

            {
                ElementDefinitionMatch m = new ElementDefinitionMatch("target.path[0] in [... 'alpha' ...]");
                ElementDefinition[] results = m.Process(null, elementDefinitions).ToArray();
                Assert.True(results.Length == 4);
            }

            {
                ElementDefinitionMatch m = new ElementDefinitionMatch("target.type in [... 'Timx' ...]");
                ElementDefinition[] results = m.Process(null, elementDefinitions).ToArray();
                Assert.True(results.Length == 0);
            }
            {
                ElementDefinitionMatch m = new ElementDefinitionMatch("target.type in [... 'Tim' ...]");
                ElementDefinition[] results = m.Process(null, elementDefinitions).ToArray();
                Assert.True(results.Length == 1);
                Assert.True(results[0].Path == "alpha.four");
            }
            {
                ElementDefinitionMatch m = new ElementDefinitionMatch("target.type in [... 'Timex']");
                ElementDefinition[] results = m.Process(null, elementDefinitions).ToArray();
                Assert.True(results.Length == 0);
            }
            {
                ElementDefinitionMatch m = new ElementDefinitionMatch("target.type in [... 'Time']");
                ElementDefinition[] results = m.Process(null, elementDefinitions).ToArray();
                Assert.True(results.Length == 1);
                Assert.True(results[0].Path == "alpha.four");
            }
            {
                ElementDefinitionMatch m = new ElementDefinitionMatch("target.type in ['datex' ...]");
                ElementDefinition[] results = m.Process(null, elementDefinitions).ToArray();
                Assert.True(results.Length == 0);
            }
            {
                ElementDefinitionMatch m = new ElementDefinitionMatch("target.type in ['date' ...]");
                ElementDefinition[] results = m.Process(null, elementDefinitions).ToArray();
                Assert.True(results.Length == 1);
                Assert.True(results[0].Path == "alpha.four");
            }
            {
                ElementDefinitionMatch m = new ElementDefinitionMatch("target.type in ['date']");
                ElementDefinition[] results = m.Process(null, elementDefinitions).ToArray();
                Assert.True(results.Length == 0);
            }
            {
                ElementDefinitionMatch m = new ElementDefinitionMatch("target.type in ['dateTime']");
                ElementDefinition[] results = m.Process(null, elementDefinitions).ToArray();
                Assert.True(results.Length == 1);
                Assert.True(results[0].Path == "alpha.four");
            }
            {
                ElementDefinitionMatch m = new ElementDefinitionMatch(@"target.type matches '^dateTime$'");
                ElementDefinition[] results = m.Process(null, elementDefinitions).ToArray();
                Assert.True(results.Length == 1);
                Assert.True(results[0].Path == "alpha.four");
            }
            {
                ElementDefinitionMatch m = new ElementDefinitionMatch(@"target.type matches '^dateTim$'");
                ElementDefinition[] results = m.Process(null, elementDefinitions).ToArray();
                Assert.True(results.Length == 0);
            }
            {
                ElementDefinitionMatch m = new ElementDefinitionMatch(@"target.type matches '^dateTime$'");
                ElementDefinition[] results = m.Process(null, elementDefinitions).ToArray();
                Assert.True(results.Length == 1);
                Assert.True(results[0].Path == "alpha.four");
            }
            {
                ElementDefinitionMatch m = new ElementDefinitionMatch("target.path == ... '.one'");
                ElementDefinition[] results = m.Process(null, elementDefinitions).ToArray();
                Assert.True(results.Length == 1);
                Assert.True(results[0].Path == "alpha.one");
            }
            {
                ElementDefinitionMatch m = new ElementDefinitionMatch("target.path == ... '.o'");
                ElementDefinition[] results = m.Process(null, elementDefinitions).ToArray();
                Assert.True(results.Length == 0);
            }

            {
                ElementDefinitionMatch m = new ElementDefinitionMatch("(target.path == ... '.one') || (target.path == ... 'two')");
                ElementDefinition[] results = m.Process(null, elementDefinitions).ToArray();
                Assert.True(results.Length == 2);
            }

            {
                ElementDefinitionMatch m = new ElementDefinitionMatch("(target.path == ... '.one') && (target.path == ... 'on' ...)");
                ElementDefinition[] results = m.Process(null, elementDefinitions).ToArray();
                Assert.True(results.Length == 1);
            }
        }

        //[Fact(DisplayName = "ModelLab.GetObservationResource")]
        //[Trait("Test", "helper")]
        //void GetObservationResource()
        //{
        //    ZipSource source = new ZipSource("specification.zip");
        //    IEnumerable<string> y = source.ListArtifactNames();
        //    Resource x = source.ResolveByUri("http://hl7.org/fhir/StructureDefinition/Observation");
        //    String root = DirHelper.FindParentDir("Tools");
        //    x.SaveJson(Path.Combine(root, "Observation.json"));
        //}


        [Fact(DisplayName = "ModelLab.TestResourceToModelDefConverter")]
        [Trait("Test", "test")]
        void TestResourceToModelDefConverter()
        {
            String savePath = Path.GetFullPath(@"c:\Temp\ModelDef.Observation.json");
            ResourceToModelDefConverter converter = new ResourceToModelDefConverter();
            converter.Load("http://hl7.org/fhir/StructureDefinition/Observation");
            converter.ZeroCardinality("target.path[1...] == 'value[x]'");
            converter.Map();
            converter.Save(savePath);
            StructureDefinition modelDef = converter.ModelDef;
            Assert.True(modelDef.Snapshot == null);
            List<ElementDefinition> elements = modelDef.Differential.Element;
            Assert.True(elements.FindByPath("Observation.partOf") == null);
            Assert.True(elements.FindByPath("Observation.status") == null);
            Assert.True(elements.FindByPath("Observation.value[x]").Max == "0");
            FhirValidator v = new FhirValidator
            {
                FailOnWarnings = false
            };

            //bool valid = v.Validate(new String[] { savePath }, FhirKhitVersion.FhirVersion);
            //if (valid == false)
            //{
            //    foreach (String s in v.Errors)
            //        Trace.WriteLine(s);
            //    Assert.True(false);
            //}
        }

        [Fact(DisplayName = "ModelLab.GetPublisherJar")]
        [Trait("Test", "helper")]
        void GetPublisherJar()
        {
            IGPublisher igPublisher = new IGPublisher(this.IGDir);
            igPublisher.GetPublisherJar();
        }
    }
}
