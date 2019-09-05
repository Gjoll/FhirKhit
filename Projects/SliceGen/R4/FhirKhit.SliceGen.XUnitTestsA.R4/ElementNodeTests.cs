using FhirKhit.SliceGen;
using FhirKhit.Tools;
using Hl7.Fhir.Model;
using System;
using System.Linq;
using System.IO;
using Xunit;
using System.Text;
using Hl7.Fhir.Serialization;
using FhirKhit.SliceGen.R4;


#if FHIR_R2
using FhirKhit.Tools.R2;
#elif FHIR_R3
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

        [Fact(DisplayName = "ElementNode.SliceTest")]
        [Trait("Test", "test")]
        public void SliceTest()
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
                    Fixed = new FhirUri("http://hl7.org/fhir/us/breast-radiology/CodeSystem/breastrad-BreastAbnormalityCodesCS")
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
            ElementNode head = ElementNode.Create(s);
            Assert.True(head.Slices.Any() == false);
            Assert.True(head.Children.Count() == 1);

            Assert.True(head.TryGetElementNode("Observation.code.coding", out ElementNode coding) == true);
            Assert.True(coding.Slices.Count() == 1);

            Assert.True(head.TryGetElementNode("Observation.code.coding:Slice.code", out coding) == true);
        }

        [Fact(DisplayName = "ElementNode.SliceDiscriminatorTest")]
        [Trait("Test", "test")]
        public void SliceDiscriminatorTest()
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
            ElementNode head = ElementNode.Create(s);
            Assert.True(head.Slices.Any() == false);
            Assert.True(head.Children.Count() == 1);

            Assert.True(head.TryGetElementNode("Observation.component", out ElementNode observationComponent) == true);
            Assert.True(observationComponent.FullPath() == "Observation.component");
            Assert.True(observationComponent.Slices.Any() == false);
            Assert.True(observationComponent.Element.Slicing.ElementId == "5");
            Assert.True(observationComponent.Element.Slicing.Ordered == false);
            Assert.True(observationComponent.Element.Slicing.Rules == ElementDefinition.SlicingRules.Open);
            Assert.True(observationComponent.Element.Slicing.Discriminator.Count == 1);
            Assert.True(observationComponent.Element.Slicing.Discriminator[0].Type == ElementDefinition.DiscriminatorType.Value);
            Assert.True(observationComponent.Element.Slicing.Discriminator[0].Path == "code.coding.code");
        }

        [Fact(DisplayName = "ElementNode.CardinalityTest")]
        [Trait("Test", "test")]
        public void CardinalityTest()
        {
            StructureDefinition s = this.CreateBaseObservation();
            SnapshotCreator.Create(s);
            ElementNode head = ElementNode.Create(s);
            Assert.True(head.Slices.Any() == false);
            Assert.True(head.Children.Count() == 1);

            {
                Assert.True(head.TryGetElementNode("Observation.id", out ElementNode idNode) == true);
                Assert.True(idNode.Element.Min == 0);
                Assert.True(idNode.Element.Max == "1");
                Assert.True(idNode.Element.Base.Min == 0);
                Assert.True(idNode.Element.Base.Max == "1");
            }

            {
                Assert.True(head.TryGetElementNode("Observation.meta", out ElementNode metaNode) == true);
                Assert.True(metaNode.Element.Min == 0);
                Assert.True(metaNode.Element.Max == "1");
                Assert.True(metaNode.Element.Base.Min == 0);
                Assert.True(metaNode.Element.Base.Max == "1");
            }
            {
                Assert.True(head.TryGetElementNode("Observation.status", out ElementNode statusNode) == true);
                Assert.True(statusNode.Element.Min == 1);
                Assert.True(statusNode.Element.Max == "1");
                Assert.True(statusNode.Element.Base.Min == 1);
                Assert.True(statusNode.Element.Base.Max == "1");
            }
        }
        [Fact(DisplayName = "ElementNode.BreastAbnormalityTest")]
        [Trait("Test", "test")]
        public void BreastAbnormalityTest()
        {
            FhirJsonParser fjp = new FhirJsonParser();
            String jsonText = File.ReadAllText(@"TestFiles\breastrad-BreastAbnormality.json");
            StructureDefinition s = fjp.Parse<StructureDefinition>(jsonText);
            ElementNode head = ElementNode.Create(s);
        }
    }
}
