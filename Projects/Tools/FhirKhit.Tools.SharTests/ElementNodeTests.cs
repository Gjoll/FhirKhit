using FhirKhit.SliceGen;
using FhirKhit.Tools;
using Hl7.Fhir.Model;
using System;
using System.Linq;
using System.IO;
using Xunit;
using System.Text;
using Hl7.Fhir.Serialization;
using System.IO.Compression;

#if FHIR_R3
using FhirKhit.Tools.R3;
#elif FHIR_R4
using FhirKhit.Tools.R4;
#endif

namespace FhirKhit.SliceGen.XUnitTestsA
{
    /// <summary>
    /// Test the output test files generated in FhirKhit.SliceGen.XUnitTests.
    /// XUnitTests generated files in this project which are compiled and then
    /// tests are executed on the compiled output classes.
    /// </summary>
    public class ElementNodeTests
    {
#if FHIR_R4 || FHIR_R3
        StructureDefinition CreateBaseObservation()
        {
            StructureDefinition s = new StructureDefinition
            {
                Id = "SimpleTest",
                Url = "www.test.com/xxyyz",
                Name = "SimpleTest",
                Status = PublicationStatus.Draft,
                Kind = StructureDefinition.StructureDefinitionKind.Resource,
                Abstract = false,
                Type = "Observation",
                BaseDefinition = "http://hl7.org/fhir/StructureDefinition/Observation",
                Derivation = StructureDefinition.TypeDerivationRule.Constraint,
                Differential = new StructureDefinition.DifferentialComponent()
            };
            return s;
        }

        [Fact(DisplayName = "ElementNode.Select")]
        [Trait("Test", "test")]
        public void Select()
        {
            StructureDefinition s = this.CreateBaseObservation();

            SnapshotCreator.Create(s);
            ElementDefinitionNode head = ElementDefinitionNode.Create(s);
            {
                ElementDefinitionNode[] nodes = head.ChildNodes.First().Select("code.coding").ToArray();
                Assert.True(nodes.Length == 1);
                Assert.True(nodes[0].Name == "coding");
            }
            {
                ElementDefinitionNode[] nodes = head.ChildNodes.First().Select("code.coding.code").ToArray();
                Assert.True(nodes.Length == 1);
                Assert.True(nodes[0].Name == "code");
            }
        }


        [Fact(DisplayName = "ElementNode.Slice")]
        [Trait("Test", "test")]
        public void Slice()
        {
            StructureDefinition s = this.CreateBaseObservation();
            {
                ElementDefinition e = new ElementDefinition
                {
                    ElementId = "Observation.code.coding",
                    Path = "Observation.code.coding",
                    Min = 0,
                    Max = "*",
                    Slicing = new ElementDefinition.SlicingComponent
                    {
                        ElementId = "4",
                        Ordered = false,
                        Rules = ElementDefinition.SlicingRules.Open
                    }
                };
                e.Slicing.Discriminator.Add(new ElementDefinition.DiscriminatorComponent
                {
                    Type = ElementDefinition.DiscriminatorType.Value,
                    Path = "code"
                });
                s.Differential.Element.Add(e);
            }

            {
                ElementDefinition e = new ElementDefinition
                {
                    ElementId = "Observation.code.coding:Slice",
                    SliceName = "Slice",
                    Path = "Observation.code.coding",
                    Min = 1,
                    Max = "1"
                };
                e.Type.Add(new ElementDefinition.TypeRefComponent { Code = "Coding" });
                s.Differential.Element.Add(e);
            }


            {
                ElementDefinition e = new ElementDefinition
                {
                    ElementId = "Observation.code.coding:Slice.system",
                    Path = "Observation.code.coding.system",
                    Min = 0,
                    Max = "1",
                    Fixed = new FhirUri("http://hl7.org/fhir/us/breast-radiology/CodeSystem/BreastAbnormalityCodesCS")
                };
                e.Type.Add(new ElementDefinition.TypeRefComponent { Code = "code" });
                s.Differential.Element.Add(e);
            }

            {
                ElementDefinition e = new ElementDefinition
                {
                    ElementId = "Observation.code.coding:Slice.code",
                    Path = "Observation.code.coding.code",
                    Min = 0,
                    Max = "1",
                    Fixed = new Code("BreastAbnormalityObservationCode")
                };
                e.Type.Add(new ElementDefinition.TypeRefComponent { Code = "code" });
                s.Differential.Element.Add(e);
            }

            SnapshotCreator.Create(s);
            ElementDefinitionNode head = ElementDefinitionNode.Create(s);
            Assert.True(head.Slices.Any() == false);
            Assert.True(head.ChildNodes.Count() == 1);

            Assert.True(head.TryGetElementNode("Observation.code.coding", out ElementDefinitionNode coding) == true);
            Assert.True(coding.Slices.Count() == 1);

            Assert.True(head.TryGetElementNode("Observation.code.coding:Slice.code", out coding) == true);
        }

        [Fact(DisplayName = "ElementNode.SliceDiscriminator")]
        [Trait("Test", "test")]
        public void SliceDiscriminator()
        {
            StructureDefinition s = this.CreateBaseObservation();
            ElementDefinition e = new ElementDefinition
            {
                ElementId = "Observation.component",
                Path = "Observation.component",
                Slicing = new ElementDefinition.SlicingComponent
                {
                    ElementId = "5",
                    Ordered = false,
                    Rules = ElementDefinition.SlicingRules.Open
                }
            };
            e.Slicing.Discriminator.Add(new ElementDefinition.DiscriminatorComponent
            {
                Type = ElementDefinition.DiscriminatorType.Value,
                Path = "code.coding.code"
            });
            s.Differential.Element.Add(e);

            SnapshotCreator.Create(s);
            ElementDefinitionNode head = ElementDefinitionNode.Create(s);
            Assert.True(head.Slices.Any() == false);
            Assert.True(head.ChildNodes.Count() == 1);

            Assert.True(head.TryGetElementNode("Observation.component", out ElementDefinitionNode observationComponent) == true);
            Assert.True(observationComponent.FullPath() == "Observation.component");
            Assert.True(observationComponent.Slices.Any() == false);
            Assert.True(observationComponent.Element.Slicing.ElementId == "5");
            Assert.True(observationComponent.Element.Slicing.Ordered == false);
            Assert.True(observationComponent.Element.Slicing.Rules == ElementDefinition.SlicingRules.Open);
            Assert.True(observationComponent.Element.Slicing.Discriminator.Count == 1);
            Assert.True(observationComponent.Element.Slicing.Discriminator[0].Type == ElementDefinition.DiscriminatorType.Value);
            Assert.True(observationComponent.Element.Slicing.Discriminator[0].Path == "code.coding.code");
        }

        [Fact(DisplayName = "ElementNode.Cardinality")]
        [Trait("Test", "test")]
        public void Cardinality()
        {
            StructureDefinition s = this.CreateBaseObservation();
            SnapshotCreator.Create(s);
            ElementDefinitionNode head = ElementDefinitionNode.Create(s);
            Assert.True(head.Slices.Any() == false);
            Assert.True(head.ChildNodes.Count() == 1);

            {
                Assert.True(head.TryGetElementNode("Observation.id", out ElementDefinitionNode idNode) == true);
                Assert.True(idNode.Element.Min == 0);
                Assert.True(idNode.Element.Max == "1");
                Assert.True(idNode.Element.Base.Min == 0);
                Assert.True(idNode.Element.Base.Max == "1");
            }

            {
                Assert.True(head.TryGetElementNode("Observation.meta", out ElementDefinitionNode metaNode) == true);
                Assert.True(metaNode.Element.Min == 0);
                Assert.True(metaNode.Element.Max == "1");
                Assert.True(metaNode.Element.Base.Min == 0);
                Assert.True(metaNode.Element.Base.Max == "1");
            }
            {
                Assert.True(head.TryGetElementNode("Observation.status", out ElementDefinitionNode statusNode) == true);
                Assert.True(statusNode.Element.Min == 1);
                Assert.True(statusNode.Element.Max == "1");
                Assert.True(statusNode.Element.Base.Min == 1);
                Assert.True(statusNode.Element.Base.Max == "1");
            }
        }

        [Fact(DisplayName = "ElementNode.LoadElementsInBreastAbnormality")]
        [Trait("Test", "test")]
        public void LoadElementsInBreastAbnormality()
        {
            String zipPath = Path.Combine("TestFiles", "BreastRadiology.zip");
            using (ZipArchive archive = ZipFile.OpenRead(zipPath))
            {
                FhirJsonParser fjp = new FhirJsonParser();
                foreach (ZipArchiveEntry entry in archive.Entries)
                {
                    if (entry.FullName.EndsWith(".json", StringComparison.OrdinalIgnoreCase))
                    {
                        using (StreamReader streamReader = new StreamReader(entry.Open()))
                        {
                            String jsonText = streamReader.ReadToEndAsync().WaitResult();
                            StructureDefinition s = fjp.Parse<StructureDefinition>(jsonText);
                            ElementDefinitionNode head = ElementDefinitionNode.Create(s);
                        }
                    }
                }
            }
        }
#endif
    }
}
