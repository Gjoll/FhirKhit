using FhirKhit.Tools;
using Hl7.Fhir.Model;
using System;
using System.Linq;
using System.IO;
using Xunit;
using System.Text;
using FhirKhit.Tools.R4;
using System.Diagnostics;
using System.Collections.Generic;

namespace PreFhir.XUnitTests
{
    /// <summary>
    /// Test the output test files generated in FhirKhit.ProfGen.XUnitTests.
    /// XUnitTests generated files in this project which are compiled and then
    /// tests are executed on the compiled output classes.
    /// </summary>
    public class ElementTreeDiffTests
    {
        Info info = new Info();
        public ElementTreeDiffTests()
        {
            String cacheDir = Path.Combine(DirHelper.FindParentDir("PreFhir"), "Cache");
            if (FhirStructureDefinitions.Self == null)
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

        [Fact(DisplayName = "ElementTreeDiff.NoMod")]
        public void NoMod()
        {
            StructureDefinition original = this.CreateBaseObservation();
            StructureDefinition modified = this.CreateBaseObservation();

            SnapshotCreator.Create(original);
            SnapshotCreator.Create(modified);
            ElementTreeLoader loader = new ElementTreeLoader(info);
            ElementTreeNode originalNode = loader.Create(original.Snapshot.Element);
            ElementTreeNode modifiedNode = loader.Create(modified.Snapshot.Element);

            ElementTreeDiffer differ = new ElementTreeDiffer(info);
            differ.Process(originalNode, modifiedNode);

            List<ElementDefinition> elementDefinitions = new List<ElementDefinition>();
            modifiedNode.CopyTo(elementDefinitions);
            Assert.True(elementDefinitions.Count == 0);
        }

        [Fact(DisplayName = "ElementTreeDiff.SimpleMod")]
        public void SimpleMod()
        {
            StructureDefinition original = this.CreateBaseObservation();
            StructureDefinition modified = this.CreateBaseObservation();

            SnapshotCreator.Create(original);
            SnapshotCreator.Create(modified);
            ElementTreeLoader loader = new ElementTreeLoader(info);

            ElementTreeNode originalNode = loader.Create(original.Snapshot.Element);
            ElementTreeNode modifiedNode = loader.Create(modified.Snapshot.Element);
            Assert.True(modifiedNode.TryGetElementNode("Observation.value[x]", out ElementTreeNode n));
            n.ElementDefinition.Max = "0";

            ElementTreeDiffer differ = new ElementTreeDiffer(info);
            differ.Process(originalNode, modifiedNode);

            List<ElementDefinition> elementDefinitions = new List<ElementDefinition>();
            modifiedNode.CopyTo(elementDefinitions);
            Assert.True(elementDefinitions.Count == 2);
            Assert.True(elementDefinitions[1].Path == "Observation.value[x]");
            Assert.True(elementDefinitions[1].Max == "0");
        }
    }
}
