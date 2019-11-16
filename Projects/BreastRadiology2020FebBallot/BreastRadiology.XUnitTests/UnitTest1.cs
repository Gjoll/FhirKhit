using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Specification.Source;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using PreFhir;

namespace FhirKhit.BreastRadiology.XUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        const String baseDir = "BreastRadiology2020FebBallot";

        String cacheDir = Path.Combine(
            DirHelper.FindParentDir(baseDir),
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

        String manualDir = Path.Combine(
            DirHelper.FindParentDir(baseDir),
            "IG",
            "ManualResources");

        private void Message(ConsoleColor color, string className, string method, string msg)
        {
            Trace.WriteLine($"{className}.{method}: {msg}");
        }

        private bool Dfg_StatusWarnings(string className, string method, string msg)
        {
            this.Message(ConsoleColor.Yellow, className, method, msg);
            return true;
        }
        private bool Dfg_StatusInfo(string className, string method, string msg)
        {
            this.Message(ConsoleColor.White, className, method, msg);
            return true;
        }
        private bool Dfg_StatusErrors(string className, string method, string msg)
        {
            this.Message(ConsoleColor.Red, className, method, msg);
            return true;
        }

        [TestMethod]
        public void A_BuildFragments()
        {
            foreach (String file in Directory.GetFiles(this.fragmentDir, "*.json"))
                File.Delete(file);
            ResourcesMaker pc = new ResourcesMaker(this.fragmentDir, this.cacheDir);
            pc.StatusErrors += this.Dfg_StatusErrors;
            pc.StatusInfo += this.Dfg_StatusInfo;
            pc.StatusWarnings += this.Dfg_StatusWarnings;
            pc.CreateResources();
        }

        [TestMethod]
        public void B_BuildResources()
        {
            if (Directory.Exists(this.resourcesDir) == false)
                Directory.CreateDirectory(this.resourcesDir);
            else
            {
                foreach (String file in Directory.GetFiles(this.resourcesDir, "*.json"))
                    File.Delete(file);
            }

            PreFhirGenerator preFhir = new PreFhirGenerator
            {
                CacheDir = Path.Combine(DirHelper.FindParentDir("FhirKhit"), "Cache")
            };
            preFhir.StatusErrors += this.Dfg_StatusErrors;
            preFhir.StatusInfo += this.Dfg_StatusInfo;
            preFhir.StatusWarnings += this.Dfg_StatusWarnings;
            preFhir.AddDir(this.fragmentDir, "*.json");
            preFhir.Process();
            preFhir.SaveResources(this.resourcesDir);
        }

        [TestMethod]
        public void ValidateOutputResources()
        {
            String rDir = Path.Combine(this.outputDir,
                "resources");
            FhirValidator fv = new FhirValidator();
            fv.StatusErrors += this.Dfg_StatusErrors;
            fv.StatusInfo += this.Dfg_StatusInfo;
            fv.StatusWarnings += this.Dfg_StatusWarnings;

            bool success = fv.ValidateDir(rDir, "*.json", "4.0.0");
            StringBuilder sb = new StringBuilder();
            fv.FormatMessages(sb);
            Trace.WriteLine(sb.ToString());
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
            IGBuilder p = new IGBuilder(this.outputDir);
            p.StatusErrors += this.Dfg_StatusErrors;
            p.StatusInfo += this.Dfg_StatusInfo;
            p.StatusWarnings += this.Dfg_StatusWarnings;
            p.Start();
            p.AddResources(this.resourcesDir);
            p.AddResources(this.manualDir);
            p.SaveAll();
        }
    }
}
