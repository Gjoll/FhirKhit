using FhirKhit.Tools;
using Hl7.Fhir.Model;
using System;
using System.Linq;
using System.IO;
using Xunit;
using System.Text;
using FhirKhit.Tools.R4;
using System.Diagnostics;

namespace PreFhir.XUnitTests
{
    /// <summary>
    /// Test the output test files generated in FhirKhit.ProfGen.XUnitTests.
    /// XUnitTests generated files in this project which are compiled and then
    /// tests are executed on the compiled output classes.
    /// </summary>
    public class ElementTreeNodeTests
    {
        Info info = new Info();
        public ElementTreeNodeTests()
        {
            String cacheDir = Path.Combine(DirHelper.FindParentDir("PreFhir"), "Cache");
            FhirStructureDefinitions.Create(Path.Combine(cacheDir, "DefinitionCache"));
        }

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
                    ElementId = "Observation.code.coding:SliceName",
                    SliceName = "SliceName",
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
                    ElementId = "Observation.code.coding:SliceName.system",
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
                    ElementId = "Observation.code.coding:SliceName.code",
                    Path = "Observation.code.coding.code",
                    Min = 0,
                    Max = "1",
                    Fixed = new Code("BreastAbnormalityObservationCode")
                };
                e.Type.Add(new ElementDefinition.TypeRefComponent { Code = "code" });
                s.Differential.Element.Add(e);
            }

            ElementTreeLoader loader = new ElementTreeLoader(info);
            ElementTreeNode head = loader.Create(s.Differential.Element);
            Assert.True(head.Slices.Count == 1);
            Assert.True(head.DefaultSlice.Nodes.Count == 1);

            Assert.True(head.TryGetElementNode("Observation.code.coding", out ElementTreeNode coding) == true);
            Assert.True(coding.Slices.Count == 2);

            Assert.True(head.TryGetElementNode("Observation.code.coding:SliceName.code", out coding) == true);
        }


        [Fact(DisplayName = "ElementTreeNode.SlicingTest")]
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

            ElementTreeLoader loader = new ElementTreeLoader(info);
            ElementTreeNode head = loader.Create(s.Differential.Element);
            Assert.True(head.Slices.Count == 1);
            Assert.True(head.DefaultSlice.Nodes.Count == 1);

            Assert.True(head.TryGetElementNode("Observation.component", out ElementTreeNode observationComponent) == true);
            Assert.True(observationComponent.Path == "Observation.component");
            Assert.True(observationComponent.Name == "component");
            Assert.True(observationComponent.Slices.Count == 1);
            Assert.True(observationComponent.Slices.GetItemAt(0).ElementDefinition.Slicing.ElementId == "5");
            Assert.True(observationComponent.Slices.GetItemAt(0).ElementDefinition.Slicing.Ordered == false);
            Assert.True(observationComponent.Slices.GetItemAt(0).ElementDefinition.Slicing.Rules == ElementDefinition.SlicingRules.Open);
            Assert.True(observationComponent.Slices.GetItemAt(0).ElementDefinition.Slicing.Discriminator.Count == 1);
            Assert.True(observationComponent.Slices.GetItemAt(0).ElementDefinition.Slicing.Discriminator[0].Type == ElementDefinition.DiscriminatorType.Value);
            Assert.True(observationComponent.Slices.GetItemAt(0).ElementDefinition.Slicing.Discriminator[0].Path == "code.coding.code");
        }

        class ItemClass : IElementTreeItem
        {
            public string Name { get; set; }

            public ItemClass(String name)
            {
                this.Name = name;
            }
        }
    }
}
