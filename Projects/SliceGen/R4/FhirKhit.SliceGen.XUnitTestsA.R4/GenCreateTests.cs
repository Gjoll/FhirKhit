using FhirKhit.SliceGen;
using FhirKhit.Tools;
using Hl7.Fhir.Model;
using System;
using System.IO;
using System.Text;
using Xunit;
using System.Diagnostics;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Specification.Snapshot;
using System.Collections.Generic;
using FhirKhit.SliceGen.R4;
using FhirKhit.SliceGen.CodeGen;


#if FHIR_R2
using FhirKhit.Tools.R2;
#elif FHIR_R3
using FhirKhit.Tools.R3;
#elif FHIR_R4
using FhirKhit.Tools.R4;
#endif

namespace FhirKhit.SliceGen.XUnitTestsA
{
    public class GenCreateTests
    {
#if FHIR_R2
        public string GenDir => Path.Combine(DirHelper.FindParentDir("SliceGen"), "Share", "FhirKhit.SliceGen.Share.XUnitTestsA", "Generated");
        Not Implemented
        const String OutputNameSpace = "FhirKhit.Test.R2";
#elif FHIR_R3
        public string GenDir => Path.Combine(DirHelper.FindParentDir("SliceGen"), "R3", "FhirKhit.SliceGen.Share.XUnitTestsB.R3", "Generated");
        String FVersion = "3.0.1";
        const String OutputNameSpace = "FhirKhit.Test.R3";
#elif FHIR_R4
        public static string GenDir => Path.Combine(DirHelper.FindParentDir("SliceGen"), "R4", "FhirKhit.SliceGen.XUnitTestsB.R4", "Generated");
        FHIRVersion FVersion = FHIRVersion.N3_0_1;
        const String OutputNameSpace = "FhirKhit.Test.R4";
#endif
        static String TestDir()
        {
            return Path.Combine(DirHelper.FindParentDir("FhirKhit"),
              "Data",
              "US Core");
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

        void Create_SlicedMultiple(SliceGenerator p)
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


        [Fact(DisplayName = "SliceGen.CreateGenTest")]
        [Trait("Test", "test")]
        public void CreateGenTest()
        {
            SliceGenerator p = new SliceGenerator(SliceGenerator.OutputLanguageType.CSharp,
                OutputNameSpace,
                GenDir);
            this.Create_SlicedMultiple(p);
            bool success = p.Process();

            StringBuilder sb = new StringBuilder();
            p.FormatMessages(sb);
            Trace.WriteLine(sb.ToString());
            Assert.True(success == true);
        }
    }
}
