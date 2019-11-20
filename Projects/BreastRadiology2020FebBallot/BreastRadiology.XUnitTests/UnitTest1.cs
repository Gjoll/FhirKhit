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
                preFhir.ProcessOne(this.fragmentDir, "BreastRadSectionFindingsLeftBreast", true);
            }
            catch (Exception err)
            {
                Trace.WriteLine(err.Message);
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void CheckIdUnique()
        {
            String path = Path.Combine(this.outputDir,
                "resources",
                "StructureDefinition-BreastRadSectionFindingsLeftBreast.json");

            FhirJsonParser parser = new FhirJsonParser();
            StructureDefinition sd = parser.Parse<StructureDefinition>(File.ReadAllText(path));
            HashSet<String> ids = new HashSet<string>();

            String idBase = sd.Differential.Element[0].Path;
            foreach (ElementDefinition e in sd.Differential.Element)
            {
                if (ids.Contains(e.ElementId) == true)
                    Trace.WriteLine($"duplicate {e.ElementId}");
                if (e.ElementId.StartsWith(idBase) == false)
                    Trace.WriteLine($"Bad id base {e.ElementId}");
                if (e.Path.StartsWith(idBase) == false)
                    Trace.WriteLine($"Bad path base {e.ElementId}");
                ids.Add(e.ElementId);
            }
        }

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
