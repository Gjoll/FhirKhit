using FhirKhit.Tools;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

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

        [TestMethod]
        public void Clean()
        {
            ProfileCleanUp pc = new ProfileCleanUp();
            pc.Clean(resourcesDir);
        }

        [TestMethod]
        public void Profile()
        {
            ProfileMaker p = new ProfileMaker(outputDir);
            p.Start();
            p.CreateProfiles();
            p.AddResources(resourcesDir);
            p.SaveAll();
        }
    }
}
