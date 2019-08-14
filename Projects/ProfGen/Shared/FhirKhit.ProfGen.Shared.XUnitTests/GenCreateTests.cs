using FhirKhit.ProfGen;
using FhirKhit.Tools;
using Hl7.Fhir.Model;
using System;
using System.IO;
using System.Text;
using Xunit;
using FhirKhit.ProfGen.Shared;
using System.Diagnostics;


#if FHIR_R2
using FhirKhit.Tools.R2;
#elif FHIR_R3
using FhirKhit.Tools.R3;
#elif FHIR_R4
using FhirKhit.Tools.R4;
#endif

namespace FhirKhit.ProfGen.XUnitTests
{
    public class GenCreateTests
    {
#if FHIR_R2
        const String TemplateDir = "IGTemplate.R2";
        public string GenDir => Path.Combine(DirHelper.FindParentDir("ProfGen"), "Shared", "FhirKhit.ProfGen.Shared.GenTests", "Generated");
        Not Implemented
        const String OutputNameSpace = "FhirKhit.Test.R2";
#elif FHIR_R3
        const String TemplateDir = "IGTemplate.R3";
        public string GenDir => Path.Combine(DirHelper.FindParentDir("ProfGen"), "R3", "FhirKhit.ProfGen.GenTests.R3", "Generated");
        String FVersion = "3.0.1";
        const String OutputNameSpace = "FhirKhit.Test.R3";
#elif FHIR_R4
        const String TemplateDir = "IGTemplate.R4";
        public string GenDir => Path.Combine(DirHelper.FindParentDir("ProfGen"), "R4", "FhirKhit.ProfGen.GenTests.R4", "Generated");
        FHIRVersion FVersion = FHIRVersion.N3_0_1;
        const String OutputNameSpace = "FhirKhit.Test.R4";
#endif
        String TestDir()
        {
            return Path.Combine(DirHelper.FindParentDir("FhirKhit"),
              "Data",
              "US Core");
        }

        String TestFile(String name) => $"{Path.Combine(this.TestDir(), name)}";


        [Fact(DisplayName = "ProfGen.ConstructorTest")]
        [Trait("Test", "test")]
        public void ConstructorTest()
        {
            ProfileGenerator p = new ProfileGenerator(ProfileGenerator.OutputLanguages.CSharp,
                OutputNameSpace,
                GenDir);
            Assert.True(p.OutputLanguage == ProfileGenerator.OutputLanguages.CSharp);
            Assert.True(p.NameSpace == OutputNameSpace);
            Assert.True(p.OutputDir == GenDir);
        }

        StructureDefinition CreateObservation(String name)
        {
            StructureDefinition profile = new StructureDefinition
            {
                Url = "http://xxyyz.com/CardinalityModObservation",
                Name = name,
                Title = name,
                Description = new Markdown("Profile on Observation with fixed values"),
                BaseDefinition = "http://hl7.org/fhir/StructureDefinition/Observation",
                Derivation = StructureDefinition.TypeDerivationRule.Constraint,
                DateElement = new FhirDateTime(2019, 1, 1, 0, 0, 0, new TimeSpan(0)),
                Publisher = "Me",
                FhirVersion = FVersion,
                Type = "Observation",
                Kind = StructureDefinition.StructureDefinitionKind.Resource,
                Abstract = false,
            };

            SnapshotCreator.Create(profile);
            return profile;
        }

        void Create_NoModObservation(ProfileGenerator p)
        {
            StructureDefinition profile = CreateObservation("NoModObservation");
            p.AddProfile(profile);
        }


        void Create_CardinalityModObservation(ProfileGenerator p)
        {
            StructureDefinition profile = CreateObservation("CardinalityModObservation");

            {
                ElementDefinition e = profile.Snapshot.Element.GetOrCreateElement("Observation.identifier");
                e.Min = 0;
                e.Max = "1";
            };
        }

        void Create_Fixed(ProfileGenerator p)
        {
            StructureDefinition profile = CreateObservation("FixedObservation");

            {
                ElementDefinition e = profile.Snapshot.Element.GetOrCreateElement("Observation.identifier");
                e.Min = 0;
                e.Max = "1";
                e.Fixed = new Identifier("fixedIdentifierSystem", "fixedIdentifierValue");
            }


            {
                ElementDefinition e = profile.Snapshot.Element.GetOrCreateElement("Observation.code");
                e.Min = 0;
                e.Max = "1";
                e.Fixed = new CodeableConcept("codeSystem", "codeCode", "codeDisplay", "codeText");
            }

            {
                ElementDefinition e = profile.Snapshot.Element.GetOrCreateElement("Observation.status");
                e.Min = 0;
                e.Max = "1";
                e.Fixed = new Code("cancelled");
            }


            p.AddProfile(profile);
        }

        void Create_Fixed1(ProfileGenerator p)
        {
            StructureDefinition profile = CreateObservation("FixedObservation1");

            {
                ElementDefinition e = profile.Snapshot.Element.GetOrCreateElement("Observation.effective[x]");
                e.Fixed = new FhirDateTime(1002, 1, 2, 3, 4, 5, new TimeSpan(0));
            }

            {
                ElementDefinition e = profile.Snapshot.Element.GetOrCreateElement("Observation.value[x]");
                e.Fixed = new Quantity(10, "things", "www.things.com");
            }

            p.AddProfile(profile);
        }

        void Create_Fixed2(ProfileGenerator p)
        {
            StructureDefinition profile = CreateObservation("FixedObservation2");

            {
                ElementDefinition e = profile.Snapshot.Element.GetOrCreateElement("Observation.effective[x]");
                e.Fixed = new Period(new FhirDateTime(1002, 1, 2), new FhirDateTime(1003, 4, 5));
            }

            {
                ElementDefinition e = profile.Snapshot.Element.GetOrCreateElement("Observation.value[x]");
                e.Fixed = new FhirBoolean(true);
            }

            p.AddProfile(profile);
        }

        void Create_Components(ProfileGenerator p)
        {
            //StructureDefinition profile = CreateObservation("ComponentObservation");
            //p.AddProfile(profile);
        }

        [Fact(DisplayName = "ProfGen.CreateGenTest")]
        [Trait("Test", "test")]
        public void CreateGenTest()
        {
            ProfileGenerator p = new ProfileGenerator(ProfileGenerator.OutputLanguages.CSharp,
                OutputNameSpace,
                GenDir);
            Create_NoModObservation(p);
            Create_CardinalityModObservation(p);
            Create_Fixed(p);
            Create_Fixed1(p);
            Create_Fixed2(p);
            Create_Components(p);
            bool success = p.Process();

            StringBuilder sb = new StringBuilder();
            p.FormatMessages(sb);
            Trace.WriteLine(sb.ToString());
            Assert.True(success == true);
        }
    }
}
