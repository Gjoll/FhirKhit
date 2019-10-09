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
        public void BuildResources()
        {
            ResourcesMaker pc = new ResourcesMaker(resourcesDir);
            pc.CreateResources();
        }

        [TestMethod]
        public void Clean()
        {
            ProfileCleanUp pc = new ProfileCleanUp();
            pc.Clean(resourcesDir);
        }

        [TestMethod]
        public void IGBuild()
        {
            IGBuilder p = new IGBuilder(outputDir);
            p.Start();
            p.AddResources(resourcesDir);
            p.SaveAll();
        }
    }
}
