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

namespace BreastRadiology.XUnitTests
{
    [TestClass]
    public class BuildFrgments
    {
        const String baseDir = "BreastRadiology2020FebBallot";

        String cacheDir = Path.Combine(
            DirHelper.FindParentDir("FhirKhit"),
            "Cache");

        String graphicsDir = Path.Combine(
            DirHelper.FindParentDir(baseDir),
            "IG",
            "Content",
            "Graphics");

        String guideDir = Path.Combine(
            DirHelper.FindParentDir(baseDir),
            "IG",
            "Guide");

        String fragmentDir = Path.Combine(
            DirHelper.FindParentDir(baseDir),
            "IG",
            "Content",
            "Fragments");

        String resourcesDir = Path.Combine(
            DirHelper.FindParentDir(baseDir),
            "IG",
            "Content",
            "Resources");

        String pageDir = Path.Combine(
            DirHelper.FindParentDir(baseDir),
            "IG",
            "Content",
            "Page");

        String mergedDir = Path.Combine(
            DirHelper.FindParentDir(baseDir),
            "IG",
            "Content",
            "Merged");

        String manualDir = Path.Combine(
            DirHelper.FindParentDir(baseDir),
            "IG",
            "Content",
            "ManualResources");

        private void Message(String import, string className, string method, string msg)
        {
            Trace.WriteLine($"[{import}] {className}.{method}: {msg}");
        }

        private bool StatusWarnings(string className, string method, string msg)
        {
            if (msg.Contains(" does not resolve"))
                return true;

            this.Message("Warn", className, method, msg);
            return true;
        }
        private bool StatusInfo(string className, string method, string msg)
        {
            if (msg.Contains(" does not resolve"))
                return true;

            this.Message("Info", className, method, msg);
            return true;
        }
        private bool StatusErrors(string className, string method, string msg)
        {
            if (msg.Contains(" does not resolve"))
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
                pc.CreateFocusMaps(this.graphicsDir, this.pageDir);
                pc.CreateResourceMap(graphicsDir);
                if (pc.HasErrors)
                {
                    StringBuilder sb = new StringBuilder();
                    pc.FormatErrorMessages(sb);
                    Trace.WriteLine(sb.ToString());
                    Debug.Assert(false);
                }
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
            const bool saveMergedFiles = false;

            try
            {
                DateTime start = DateTime.Now;
                if (Directory.Exists(this.resourcesDir) == false)
                    Directory.CreateDirectory(this.resourcesDir);

                if (saveMergedFiles)
                {
                    if (Directory.Exists(this.mergedDir) == false)
                        Directory.CreateDirectory(this.mergedDir);
                }
                else
                {
                    if (Directory.Exists(this.mergedDir) == true)
                        Directory.Delete(this.mergedDir, true);
                }

                PreFhirGenerator preFhir = new PreFhirGenerator(Path.Combine(DirHelper.FindParentDir("FhirKhit"), "Cache"));
                preFhir.StatusErrors += this.StatusErrors;
                preFhir.StatusInfo += this.StatusInfo;
                preFhir.StatusWarnings += this.StatusWarnings;
                preFhir.AddDir(this.fragmentDir, "*.json");
                if (saveMergedFiles)
                    preFhir.MergedDir = this.mergedDir;
                preFhir.Process();
                preFhir.SaveResources(this.resourcesDir, true);

                if (preFhir.HasErrors)
                {
                    StringBuilder sb = new StringBuilder();
                    preFhir.FormatErrorMessages(sb);
                    Trace.WriteLine(sb.ToString());
                    Debug.Assert(false);
                }

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
                preFhir.ProcessOne(this.fragmentDir, "BreastRadUSMassMargin", true);
                preFhir.SaveResources(this.resourcesDir, true);
            }
            catch (Exception err)
            {
                Trace.WriteLine(err.Message);
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void ValidateOutputResources()
        {
            String rDir = Path.Combine(this.guideDir,
                "input",
                "resources");
            FhirValidator fv = new FhirValidator();
            fv.StatusErrors += this.StatusErrors;
            fv.StatusInfo += this.StatusInfo;
            fv.StatusWarnings += this.StatusWarnings;

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
            fv.StatusErrors += this.StatusErrors;
            fv.StatusInfo += this.StatusInfo;
            fv.StatusWarnings += this.StatusWarnings;
            bool success = fv.ValidateDir(this.resourcesDir, "*.json", "4.0.0");
            //StringBuilder sb = new StringBuilder();
            //fv.FormatMessages(sb);
            //Trace.WriteLine(sb.ToString());
            //Assert.IsTrue(success);
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
                //IGBuilder p = new IGBuilder(Path.Combine(this.guideDir, "input"));
                //p.StatusErrors += this.StatusErrors;
                //p.StatusInfo += this.StatusInfo;
                //p.StatusWarnings += this.StatusWarnings;
                //p.Start();
                //p.AddResources(this.resourcesDir);
                //p.AddResources(this.manualDir);
                //p.SaveAll();

                //if (p.HasErrors)
                //{
                //    StringBuilder sb = new StringBuilder();
                //    p.FormatErrorMessages(sb);
                //    Trace.WriteLine(sb.ToString());
                //    Debug.Assert(false);
                //}
            }
            catch (Exception err)
            {
                Trace.WriteLine(err.Message);
                Assert.IsTrue(false);
            }
        }
    }
}
