using FhirKhit.SliceGen;
using FhirKhit.Tools;
using Hl7.Fhir.Model;
using System;
using System.IO;
using System.Text;
using Xunit;
using FhirKhit.SliceGen.Share;
using System.Diagnostics;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Specification.Snapshot;
using System.Collections.Generic;


#if FHIR_R2
using FhirKhit.Tools.R2;
#elif FHIR_R3
using FhirKhit.Tools.R3;
#elif FHIR_R4
using FhirKhit.Tools.R4;
#endif

namespace FhirKhit.SliceGen.XUnitTests
{
    public class GenCreateTests
    {
#if FHIR_R2
        public string GenDir => Path.Combine(DirHelper.FindParentDir("SliceGen"), "Share", "FhirKhit.SliceGen.Share.GenTests", "Generated");
        Not Implemented
        const String OutputNameSpace = "FhirKhit.Test.R2";
#elif FHIR_R3
        public string GenDir => Path.Combine(DirHelper.FindParentDir("SliceGen"), "R3", "FhirKhit.SliceGen.GenTests.R3", "Generated");
        String FVersion = "3.0.1";
        const String OutputNameSpace = "FhirKhit.Test.R3";
#elif FHIR_R4
        public static string GenDir => Path.Combine(DirHelper.FindParentDir("SliceGen"), "R4", "FhirKhit.SliceGen.GenTests.R4", "Generated");
        FHIRVersion FVersion = FHIRVersion.N3_0_1;
        const String OutputNameSpace = "FhirKhit.Test.R4";
#endif
        static String TestDir()
        {
            return Path.Combine(DirHelper.FindParentDir("FhirKhit"),
              "Data",
              "US Core");
        }

        String TestFile(String name) => $"{Path.Combine(GenCreateTests.TestDir(), name)}";


        [Fact(DisplayName = "SliceGen.ConstructorTest")]
        [Trait("Test", "test")]
        public void ConstructorTest()
        {
            ProfileGenerator p = new ProfileGenerator(ProfileGenerator.OutputLanguageType.CSharp,
                OutputNameSpace,
                GenDir);
            Assert.True(p.OutputLanguage == ProfileGenerator.OutputLanguageType.CSharp);
            Assert.True(p.NameSpace == OutputNameSpace);
            Assert.True(p.OutputDir == GenDir);
        }

        StructureDefinition CreateObservation(String name)
        {
            StructureDefinition profile = new StructureDefinition
            {
                Url = $"http://xxyyz.com/{name}",
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
                Differential = new StructureDefinition.DifferentialComponent()
            };

            profile.Differential.Element.Add(
                new ElementDefinition
                {
                    Path = "Observation",
                    ElementId = "Observation"
                });

            return profile;
        }

        void Create_NoModObservation(ProfileGenerator p)
        {
            StructureDefinition profile = CreateObservation("NoModObservation");
            SnapshotCreator.Create(profile);
            p.AddProfile(profile);
        }


        void Create_CardinalityModObservation(ProfileGenerator p)
        {
            StructureDefinition profile = CreateObservation("CardinalityModObservation");
            {
                ElementDefinition e = profile.Differential.Element.GetOrCreateElement("Observation.identifier");
                e.Min = 0;
                e.Max = "1";
            };

            SnapshotCreator.Create(profile);
            p.AddProfile(profile);
        }

        void Create_SlicedMultiple(ProfileGenerator p)
        {
            StructureDefinition profile = CreateObservation("SlicedMultiple");
            {
                ElementDefinition e = profile.Differential.Element.GetOrCreateElement("Observation.component");
                e.Slicing = new ElementDefinition.SlicingComponent
                {
                    ElementId = "ObservationComponentSlice",
                    Ordered = false,
                    Rules = ElementDefinition.SlicingRules.Open
                };
                e.Slicing.Discriminator.Add(new ElementDefinition.DiscriminatorComponent
                {
                    Type = ElementDefinition.DiscriminatorType.Value,
                    Path = "code"
                });
            }

            {
                ElementDefinition e = new ElementDefinition
                {
                    ElementId = "Observation.component:Slice1",
                    Path = "Observation.component",
                    SliceName = "Slice1"
                };
                profile.Differential.Element.Add(e);
            }

            {
                ElementDefinition e = new ElementDefinition
                {
                    Path = "Observation.component.code",
                    ElementId = "Observation.component:Slice1.code",
                    Fixed = new CodeableConcept("http://www.test.com/SliceSystem", "Slice1Code")
                };
                profile.Differential.Element.Add(e);
            }

            {
                ElementDefinition e = new ElementDefinition
                {
                    ElementId = "Observation.component:Slice2",
                    Path = "Observation.component",
                    SliceName = "Slice2"
                };
                profile.Differential.Element.Add(e);
            }

            {
                ElementDefinition e = new ElementDefinition
                {
                    Path = "Observation.component.code",
                    ElementId = "Observation.component:Slice2.code",
                    Fixed = new CodeableConcept("http://www.test.com/SliceSystem", "Slice2Code")
                };
                profile.Differential.Element.Add(e);
            }

            SnapshotCreator.Create(profile);
            p.AddProfile(profile);
            profile.SaveJson($@"c:\Temp\SlicedMultiple.json");
        }

        void Create_Fixed(ProfileGenerator p)
        {
            StructureDefinition profile = CreateObservation("Fixed");

            {
                ElementDefinition e = profile.Differential.Element.GetOrCreateElement("Observation.identifier");
                e.Min = 0;
                e.Max = "1";
                e.Fixed = new Identifier("fixedIdentifierSystem", "fixedIdentifierValue");
            }
            {
                ElementDefinition e = profile.Differential.Element.GetOrCreateElement("Observation.status");
                e.Fixed = new Code("cancelled");
                e.Min = 1;
                e.Max = "1";
            }
            {
                ElementDefinition e = profile.Differential.Element.GetOrCreateElement("Observation.code");
                e.Min = 0;
                e.Max = "1";
                e.Fixed = new CodeableConcept("codeSystem", "codeCode", "codeDisplay", "codeText");
            }

            SnapshotCreator.Create(profile);
            p.AddProfile(profile);
            profile.SaveJson($@"c:\Temp\{profile.Name}.json");
        }

        void Create_Fixed1(ProfileGenerator p)
        {
            StructureDefinition profile = CreateObservation("Fixed1");

            {
                ElementDefinition e = profile.Differential.Element.GetOrCreateElement("Observation.effective[x]");
                e.Fixed = new FhirDateTime(1002, 1, 2, 3, 4, 5, new TimeSpan(0));
            }

            {
                ElementDefinition e = profile.Differential.Element.GetOrCreateElement("Observation.value[x]");
                e.Fixed = new Quantity(10, "things", "www.things.com");
            }

            SnapshotCreator.Create(profile);
            p.AddProfile(profile);
        }

        void Create_Fixed2(ProfileGenerator p)
        {
            StructureDefinition profile = CreateObservation("Fixed2");

            {
                ElementDefinition e = profile.Differential.Element.GetOrCreateElement("Observation.effective[x]");
                e.Fixed = new Period(new FhirDateTime(1002, 1, 2), new FhirDateTime(1003, 4, 5));
            }

            {
                ElementDefinition e = profile.Differential.Element.GetOrCreateElement("Observation.value[x]");
                e.Fixed = new FhirBoolean(true);
            }

            SnapshotCreator.Create(profile);
            p.AddProfile(profile);
        }

        [Fact(DisplayName = "SliceGen.CreateGenTest")]
        [Trait("Test", "test")]
        public void CreateGenTest()
        {
            ProfileGenerator p = new ProfileGenerator(ProfileGenerator.OutputLanguageType.CSharp,
                OutputNameSpace,
                GenDir);
            //$this.Create_NoModObservation(p);
            //$this.Create_CardinalityModObservation(p);
            //$this.Create_Fixed(p);
            //$this.Create_Fixed1(p);
            //$this.Create_Fixed2(p);
            //$this.Create_Components(p);
            this.Create_SlicedMultiple(p);
            bool success = p.Process();

            StringBuilder sb = new StringBuilder();
            p.FormatMessages(sb);
            Trace.WriteLine(sb.ToString());
            Assert.True(success == true);
        }

        //[Fact(DisplayName = "SliceGen.StatusError")]
        //[Trait("Test", "test")]
        //void StatusError()
        //{
        //    ElementDefinition CreateElement(List<ElementDefinition> elements, String path, String id)
        //    {
        //        ElementDefinition retVal = new ElementDefinition
        //        {
        //            Path = path,
        //            ElementId = id
        //        };
        //        elements.Add(retVal);

        //        return retVal;
        //    }

        //    void OutputDef(String name, bool errorFlag)
        //    {
        //        StructureDefinition profile = new StructureDefinition
        //        {
        //            Url = $"http://xxyyz.com/{name}",
        //            Name = name,
        //            Title = name,
        //            Description = new Markdown("Profile on Observation with fixed values"),
        //            BaseDefinition = "http://hl7.org/fhir/StructureDefinition/Observation",
        //            Derivation = StructureDefinition.TypeDerivationRule.Constraint,
        //            DateElement = new FhirDateTime(2019, 1, 1, 0, 0, 0, new TimeSpan(0)),
        //            Publisher = "Me",
        //            FhirVersion = FVersion,
        //            Type = "Observation",
        //            Kind = StructureDefinition.StructureDefinitionKind.Resource,
        //            Abstract = false,
        //            Differential = new StructureDefinition.DifferentialComponent()
        //        };

        //        profile.Differential.Element.Add(
        //            new ElementDefinition
        //            {
        //                Path = "Observation",
        //                ElementId = "Observation"
        //            });

        //        if (errorFlag)
        //        {
        //            ElementDefinition e = CreateElement(profile.Differential.Element, "Observation.code", "Observation.code");
        //            e.Min = 1;
        //            e.Max = "1";
        //            e.Fixed = new CodeableConcept("codeSystem", "codeCode", "codeDisplay", "codeText");
        //        }

        //        {
        //            ElementDefinition e = CreateElement(profile.Differential.Element, "Observation.status", "Observation.status");
        //            e.Fixed = new Code("cancelled");
        //            e.Min = 1;
        //            e.Max = "1";
        //        }

        //        // Generate StructureDefinition.Snapshot using c# API.
        //        SnapshotGeneratorSettings settings = SnapshotGeneratorSettings.CreateDefault();
        //        SnapshotGenerator generator = new SnapshotGenerator(ZipFhirSource.Source, settings);
        //        generator.Update(profile);
        //        String outputPath = $@"c:\Temp\{name}.json";
        //        profile.SaveJson(outputPath);
        //    }

        //    OutputDef("statusError", true);
        //    OutputDef("statusWorks", false);
        //}

        //[Fact(DisplayName = "SliceGen.CreateSnapshotOfBreastAbnormality")]
        //[Trait("Test", "test")]
        //public void CreateSnapshotOfBreastAbnormality()
        //{
        //    String path = Path.Combine(DirHelper.FindParentDir("FhirKhit"), "BreastAbnormality.json");
        //    String jsonText = File.ReadAllText(path);
        //    FhirJsonParser parser = new FhirJsonParser();
        //    StructureDefinition profile = parser.Parse<StructureDefinition>(jsonText);
        //    SnapshotCreator.Create(profile);
        //}
    }
}
