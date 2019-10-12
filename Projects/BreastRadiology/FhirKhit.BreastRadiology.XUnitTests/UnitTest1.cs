using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace FhirKhit.BreastRadiology.XUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        String outputDir = Path.Combine(
            DirHelper.FindParentDir("BreastRadiology"),
            "IG",
            "Guide");
        String resourcesDir = Path.Combine(
            DirHelper.FindParentDir("BreastRadiology"),
            "IG",
            "Resources");

        String manualDir = Path.Combine(
            DirHelper.FindParentDir("BreastRadiology"),
            "IG",
            "ManualResources");

        [TestMethod]
        public void BuildResources()
        {
            ResourcesMaker pc = new ResourcesMaker(resourcesDir);
            pc.CreateResources();
        }

        [TestMethod]
        public void Validate()
        {
            FhirValidator fv = new FhirValidator();
            fv.ValidateDir(resourcesDir, "*.json", "4.0.0");
            StringBuilder sb = new StringBuilder();
            bool success = fv.FormatMessages(sb);
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
            BuildResources();
            IGBuild();
        }

        [TestMethod]
        public void IGBuild()
        {
            IGBuilder p = new IGBuilder(outputDir);
            p.Start();
            p.AddResources(resourcesDir);
            p.AddResources(manualDir);
            p.SaveAll();
        }
    }
}
