using FhirKhit.ProfGen;
using FhirKhit.Tools;
using Hl7.Fhir.Model;
using System;
using System.Linq;
using System.IO;
using Xunit;
using System.Text;
using FhirKhit.ProfGen.Shared;


#if FHIR_R2
using FhirKhit.Tools.R2;
#elif FHIR_R3
using FhirKhit.Tools.R3;
#elif FHIR_R4
using FhirKhit.Tools.R4;
#endif

namespace FhirKhit.ProfGen.XUnitTests
{
    /// <summary>
    /// Test the output test files generated in FhirKhit.ProfGen.XUnitTests.
    /// XUnitTests generated files in this project which are compiled and then
    /// tests are executed on the compiled output classes.
    /// </summary>
    public class ElementTreeNodeTests
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

        [Fact(DisplayName = "ElementTreeNode.SliceTest")]
        [Trait("Test", "test")]
        public void SliceTest()
        {
            StructureDefinition s = this.CreateBaseObservation();
            {
                ElementDefinition e = new ElementDefinition
                {
                    ElementId = "Observation.code.coding",
                    Path = "Observation.code.coding",
                    Min = 0, Max = "*",
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
                    ElementId = "Observation.code.coding:Fixed_BreastAbnormalityObservationCode",
                    SliceName = "Fixed_BreastAbnormalityObservationCode",
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
                    ElementId = "Observation.code.coding:Fixed_BreastAbnormalityObservationCode.system",
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
                    ElementId = "Observation.code.coding:Fixed_BreastAbnormalityObservationCode.code",
                    Path = "Observation.code.coding.code",
                    Min = 0,
                    Max = "1",
                    Fixed = new Code("BreastAbnormalityObservationCode")
                };
                e.Type.Add(new ElementDefinition.TypeRefComponent { Code = "code" });
                s.Differential.Element.Add(e);
            }

            SnapshotCreator.Create(s);
            ElementTreeNode head = ElementTreeNode.Create(null, s.Snapshot.Element);
            Assert.True(head.Slices.Count() == 1);
            Assert.True(head.ChildItems(ElementTreeNode.BaseSlice).Count() == 1);

            Assert.True(head.TryGetElementNode("Observation.code.coding", out ElementTreeNode coding) == true);
            Assert.True(coding.Slices.Count() == 2);

            Assert.True(head.TryGetElementNode("Observation.code.coding:Fixed_BreastAbnormalityObservationCode.code", out coding) == true);
        }


        [Fact(DisplayName = "ElementTreeNode.SlicingTest")]
        [Trait("Test", "test")]
        public void SlicingTest()
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
            ElementTreeNode head = ElementTreeNode.Create(null, s.Snapshot.Element);
            Assert.True(head.Slices.Count() == 1);
            Assert.True(head.ChildItems(ElementTreeNode.BaseSlice).Count() == 1);

            Assert.True(head.TryGetElementNode("Observation.component", out ElementTreeNode observationComponent) == true);
            Assert.True(observationComponent.Path == "Observation.component");
            Assert.True(observationComponent.PathName == "component");
            Assert.True(observationComponent.Slices.Count() == 1);
            Assert.True(observationComponent.Slices.First().Slicing.ElementId == "5");
            Assert.True(observationComponent.Slices.First().Slicing.Ordered == false);
            Assert.True(observationComponent.Slices.First().Slicing.Rules == ElementDefinition.SlicingRules.Open);
            Assert.True(observationComponent.Slices.First().Slicing.Discriminator.Count == 1);
            Assert.True(observationComponent.Slices.First().Slicing.Discriminator[0].Type == ElementDefinition.DiscriminatorType.Value);
            Assert.True(observationComponent.Slices.First().Slicing.Discriminator[0].Path == "code.coding.code");
        }

        [Fact(DisplayName = "ElementTreeNode.CardinalityTest")]
        [Trait("Test", "test")]
        public void CardinalityTest()
        {
            StructureDefinition s = this.CreateBaseObservation();
            SnapshotCreator.Create(s);
            ElementTreeNode head = ElementTreeNode.Create(null, s.Snapshot.Element);
            Assert.True(head.Slices.Count() == 1);
            Assert.True(head.ChildItems(ElementTreeNode.BaseSlice).Count() == 1);

            head = head.ChildItems(ElementTreeNode.BaseSlice).First();
            {
                Assert.True(head.TryGetItem("Observation.id", out ElementTreeNode idNode) == true);
                Assert.True(idNode.Slices.First().Min == 0);
                Assert.True(idNode.Slices.First().Max == 1);
                Assert.True(idNode.Slices.First().BaseInfo.Min == 0);
                Assert.True(idNode.Slices.First().BaseInfo.Max == 1);
            }

            {
                Assert.True(head.TryGetItem("Observation.meta", out ElementTreeNode metaNode) == true);
                Assert.True(metaNode.Slices.First().Min == 0);
                Assert.True(metaNode.Slices.First().Max == 1);
                Assert.True(metaNode.Slices.First().BaseInfo.Min == 0);
                Assert.True(metaNode.Slices.First().BaseInfo.Max == 1);
            }
            {
                Assert.True(head.TryGetItem("Observation.status", out ElementTreeNode statusNode) == true);
                Assert.True(statusNode.Slices.First().Min == 1);
                Assert.True(statusNode.Slices.First().Max == 1);
                Assert.True(statusNode.Slices.First().BaseInfo.Min == 1);
                Assert.True(statusNode.Slices.First().BaseInfo.Max == 1);
            }
        }
    }
}
