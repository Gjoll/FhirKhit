using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Specification.Source;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using PreFhir;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Model;
using System.Collections.Generic;
using BreastRadiology.XUnitTests;
using System.Drawing;

namespace FhirKhit.BreastRadiology.XUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        const String baseDir = "BreastRadiology2020FebBallot";

        String cacheDir = Path.Combine(
            DirHelper.FindParentDir("FhirKhit"),
            "Cache");

        String outputDir = Path.Combine(
            DirHelper.FindParentDir(baseDir),
            "IG",
            "Guide");

        String fragmentDir = Path.Combine(
            DirHelper.FindParentDir(baseDir),
            "IG",
            "Fragments");

        String resourcesDir = Path.Combine(
            DirHelper.FindParentDir(baseDir),
            "IG",
            "Resources");

        String mergedDir = Path.Combine(
            DirHelper.FindParentDir(baseDir),
            "IG",
            "Merged");

        String manualDir = Path.Combine(
            DirHelper.FindParentDir(baseDir),
            "IG",
            "ManualResources");

        private void Message(String import, string className, string method, string msg)
        {
            Trace.WriteLine($"[{import}] {className}.{method}: {msg}");
        }

        private bool StatusWarnings(string className, string method, string msg)
        {
            this.Message("Warn", className, method, msg);
            return true;
        }
        private bool StatusInfo(string className, string method, string msg)
        {
            this.Message("Info", className, method, msg);
            return true;
        }
        private bool StatusErrors(string className, string method, string msg)
        {
            if (msg.Contains("does not resolve"))
                return true;
            this.Message("Error", className, method, msg);
            return true;
        }

        [TestMethod]
        public void A_BuildFragments()
        {
            try
            {
                if (Directory.Exists(this.fragmentDir))
                {
                    foreach (String file in Directory.GetFiles(this.fragmentDir, "*.json"))
                        File.Delete(file);
                }

                ResourcesMaker pc = new ResourcesMaker(this.fragmentDir, this.cacheDir);
                pc.StatusErrors += this.StatusErrors;
                pc.StatusInfo += this.StatusInfo;
                pc.StatusWarnings += this.StatusWarnings;
                pc.CreateResources();
            }
            catch (Exception err)
            {
                Trace.WriteLine(err.Message);
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void B_BuildResources()
        {
            try
            {
                DateTime start = DateTime.Now;
                if (Directory.Exists(this.resourcesDir) == false)
                    Directory.CreateDirectory(this.resourcesDir);

                if (Directory.Exists(this.mergedDir) == false)
                    Directory.CreateDirectory(this.mergedDir);

                PreFhirGenerator preFhir = new PreFhirGenerator(Path.Combine(DirHelper.FindParentDir("FhirKhit"), "Cache"));
                preFhir.StatusErrors += this.StatusErrors;
                preFhir.StatusInfo += this.StatusInfo;
                preFhir.StatusWarnings += this.StatusWarnings;
                preFhir.AddDir(this.fragmentDir, "*.json");
                preFhir.MergedDir = this.mergedDir;
                preFhir.Process();
                preFhir.SaveResources(this.resourcesDir, true);
                TimeSpan executionTime = DateTime.Now - start;
                Trace.WriteLine($"***** PreFhir execution Time {executionTime.ToString()}");
            }
            catch (Exception err)
            {
                Trace.WriteLine(err.Message);
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void TestBuildResource()
        {
            try
            {
                if (Directory.Exists(this.resourcesDir) == false)
                    Directory.CreateDirectory(this.resourcesDir);

                if (Directory.Exists(this.mergedDir) == false)
                    Directory.CreateDirectory(this.mergedDir);

                PreFhirGenerator preFhir = new PreFhirGenerator(Path.Combine(DirHelper.FindParentDir("FhirKhit"), "Cache"));
                preFhir.StatusErrors += this.StatusErrors;
                preFhir.StatusInfo += this.StatusInfo;
                preFhir.StatusWarnings += this.StatusWarnings;
                preFhir.MergedDir = this.mergedDir;
                preFhir.ProcessOne(this.fragmentDir, "AbnormalityObservation-Fragment", true);
                preFhir.SaveResources(this.resourcesDir, true);
            }
            catch (Exception err)
            {
                Trace.WriteLine(err.Message);
                Assert.IsTrue(false);
            }
        }

        //[TestMethod]
        //public void CheckIdUnique()
        //{
        //    String path = Path.Combine(this.outputDir,
        //        "resources",
        //        "StructureDefinition-BreastRadSectionFindingsLeftBreast.json");

        //    FhirJsonParser parser = new FhirJsonParser();
        //    StructureDefinition sd = parser.Parse<StructureDefinition>(File.ReadAllText(path));
        //    HashSet<String> ids = new HashSet<string>();

        //    String idBase = sd.Differential.Element[0].Path;
        //    foreach (ElementDefinition e in sd.Differential.Element)
        //    {
        //        if (ids.Contains(e.ElementId) == true)
        //            Trace.WriteLine($"duplicate {e.ElementId}");
        //        if (e.ElementId.StartsWith(idBase) == false)
        //            Trace.WriteLine($"Bad id base {e.ElementId}");
        //        if (e.Path.StartsWith(idBase) == false)
        //            Trace.WriteLine($"Bad path base {e.ElementId}");
        //        ids.Add(e.ElementId);
        //    }
        //}

        [TestMethod]
        public void ValidateOutputResources()
        {
            String rDir = Path.Combine(this.outputDir,
                "resources");
            FhirValidator fv = new FhirValidator();
            fv.StatusErrors += this.StatusErrors;
            //fv.StatusInfo += this.StatusInfo;
            //fv.StatusWarnings += this.StatusWarnings;

            bool success = fv.ValidateDir(rDir, "*.json", "4.0.0");
            StringBuilder sb = new StringBuilder();
            //fv.FormatMessages(sb);
            //Trace.WriteLine(sb.ToString());
            Assert.IsTrue(success);
            Assert.IsTrue(fv.HasErrors == false);
            Trace.WriteLine("Validation complete");
        }

        [TestMethod]
        public void ValidateInputResources()
        {
            FhirValidator fv = new FhirValidator(Path.Combine(this.cacheDir, "validation.xml"));
            bool success = fv.ValidateDir(this.resourcesDir, "*.json", "4.0.0");
            StringBuilder sb = new StringBuilder();
            fv.FormatMessages(sb);
            Trace.WriteLine(sb.ToString());
            Assert.IsTrue(success);
            Trace.WriteLine("Validation complete");
        }

        //[TestMethod]
        //public void Clean()
        //{
        //    ProfileCleanUp pc = new ProfileCleanUp();
        //    pc.Clean(resourcesDir);
        //}

        [TestMethod]
        public void FullBuild()
        {
            this.A_BuildFragments();
            this.B_BuildResources();
            this.C_IGBuild();
        }

        [TestMethod]
        public void Svg_BuildOverviewGraphic()
        {
            float nodeWidth = 8;

            SvgEditor e = new SvgEditor();

            SENodeGroup rootGroup = new SENodeGroup("root");
            {
                SENode node = new SENode(nodeWidth, Color.LightGreen)
                    .AddTextLine("Breast")
                    .AddTextLine("Radiology")
                    .AddTextLine("Report")
                    ;
                rootGroup.Nodes.Add(node);
            }

            {
                float sectionNodeWidth = 12;
                {
                    SENodeGroup sectionFindingsGroup = rootGroup.AppendChild("findings");
                    SENode findingsNode = new SENode(sectionNodeWidth, Color.LightBlue)
                        .AddTextLine("Findings")
                        .AddTextLine("Section")
                        ;
                    sectionFindingsGroup.Nodes.Add(findingsNode);
                    {
                        SENodeGroup sectionFindingsRightGroup = sectionFindingsGroup.AppendChild("findings right");
                        {
                            SENode node = new SENode(sectionNodeWidth, Color.LightBlue)
                                .AddTextLine("Findings")
                                .AddTextLine("Right Breast")
                                .AddTextLine("Section")
                                ;
                            sectionFindingsRightGroup.Nodes.Add(node);
                        }
                        {
                            SENodeGroup sectionFindingsLeftGroup = sectionFindingsGroup.AppendChild("findings left");
                            {
                                SENode node = new SENode(sectionNodeWidth, Color.LightBlue)
                                    .AddTextLine("Findings")
                                    .AddTextLine("Left Breast")
                                    .AddTextLine("Section")
                                    ;
                                sectionFindingsRightGroup.Nodes.Add(node);
                            }
                        }
                    }
                }
                {
                    SENodeGroup sectionImpressionsGroup = rootGroup.AppendChild("impressions");
                    SENode node = new SENode(sectionNodeWidth, Color.Coral)
                        .AddTextLine("Impressions")
                        .AddTextLine("Section")
                        ;
                    sectionImpressionsGroup.Nodes.Add(node);
                }

                {
                    SENodeGroup sectionRecommendationsGroup = rootGroup.AppendChild("recommendations");
                    SENode node = new SENode(sectionNodeWidth, Color.Coral)
                        .AddTextLine("Recommendations")
                        .AddTextLine("Section")
                        ;
                    sectionRecommendationsGroup.Nodes.Add(node);
                }

                {
                    SENodeGroup sectionRiskGroup = rootGroup.AppendChild("risk");
                    SENode node = new SENode(sectionNodeWidth, Color.Coral)
                        .AddTextLine("Patient Risk Section")
                        ;
                    sectionRiskGroup.Nodes.Add(node);
                }
                {
                    SENodeGroup sectionPriorGroup = rootGroup.AppendChild("prior");
                    SENode node = new SENode(sectionNodeWidth, Color.Coral)
                        .AddTextLine("Prior Studies")
                        ;
                    sectionPriorGroup.Nodes.Add(node);
                }
            }

            e.Render(rootGroup);
            e.Save(@"c:\Temp\Overview.svg");
        }

        [TestMethod]
        public void SVG()
        {
            float nodeWidth = 8;

            SvgEditor e = new SvgEditor();

            SENodeGroup group1 = new SENodeGroup("test");
            {
                SENode node = new SENode(nodeWidth, Color.LightBlue)
                    .AddTextLine("Node1.1 1", new Uri("http://www.google.com"))
                    .AddTextLine("Node1.1 2")
                    .AddTextLine("Node1.1 3")
                    ;
                group1.Nodes.Add(node);
            }

            {
                SENode node = new SENode(nodeWidth, Color.Coral)
                    .AddTextLine("Node1.2 1")
                    ;
                group1.Nodes.Add(node);
            }

            {
                SENodeGroup group2 = new SENodeGroup("test2");
                {
                    SENode node = new SENode(nodeWidth, Color.LightBlue)
                        .AddTextLine("Node2.1 1", new Uri("http://www.google.com"))
                        .AddTextLine("Node2.1 2")
                        .AddTextLine("Node2.1 3")
                        ;
                    group2.Nodes.Add(node);
                }
                {
                    SENode node = new SENode(nodeWidth, Color.Coral)
                        .AddTextLine("Node2.2 1")
                        ;
                    group2.Nodes.Add(node);
                }

                {
                    SENode node = new SENode(nodeWidth, Color.Coral)
                        .AddTextLine("Node2.3 1")
                        ;
                    group2.Nodes.Add(node);
                }
                group1.Children.Add(group2);
            }

            e.Render(group1);
            e.Save(@"c:\Temp\Shapes.svg");
        }

        [TestMethod]
        public void C_IGBuild()
        {
            try
            {
                IGBuilder p = new IGBuilder(this.outputDir);
                p.StatusErrors += this.StatusErrors;
                p.StatusInfo += this.StatusInfo;
                p.StatusWarnings += this.StatusWarnings;
                p.Start();
                p.AddResources(this.resourcesDir);
                p.AddResources(this.manualDir);
                p.SaveAll();
            }
            catch (Exception err)
            {
                Trace.WriteLine(err.Message);
                Assert.IsTrue(false);
            }
        }
    }
}
