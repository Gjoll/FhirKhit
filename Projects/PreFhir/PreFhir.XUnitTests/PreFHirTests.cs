using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using Hl7.Fhir.Specification.Source;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using Xunit;

namespace PreFhir.XUnitTests
{
    public class PreFHirTests
    {
        const String ProfileVersion = "0.0.2";
        const FHIRVersion FhirVersion = FHIRVersion.N4_0_0;
        const String contactUrl = "http://www.hl7.org/Special/committees/cic";
        FhirDateTime date = new FhirDateTime(2019, 11, 1);
        const PublicationStatus ProfileStatus = PublicationStatus.Draft;

        public PreFHirTests()
        {
        }

        PreFhirGenerator CreatePreFhir()
        {
            PreFhirGenerator preFhir = new PreFhirGenerator(Path.Combine(DirHelper.FindParentDir("PreFhir"), "Cache"));
            preFhir.StatusInfo += this.PreFhir_StatusInfo;
            preFhir.StatusWarnings += this.PreFhir_StatusWarnings;
            preFhir.StatusErrors += this.PreFhir_StatusErrors;
            return preFhir;
        }

        private void Message(String import, string className, string method, string msg)
        {
            Trace.WriteLine($"[{import}] {className}.{method}: {msg}");
        }
        private bool PreFhir_StatusWarnings(string className, string method, string msg)
        {
            this.Message("Warn", className, method, msg);
            return true;
        }
        private bool PreFhir_StatusInfo(string className, string method, string msg)
        {
            this.Message("Info", className, method, msg);
            return true;
        }
        private bool PreFhir_StatusErrors(string className, string method, string msg)
        {
            this.Message("Error", className, method, msg);
            return true;
        }

        StructureDefinition CreateFragment(String name, String url)
        {
            StructureDefinition frag = new StructureDefinition
            {
                Abstract = true,
                Kind = StructureDefinition.StructureDefinitionKind.Logical,
                FhirVersion = FhirVersion,
                Name = name,
                Description = new Markdown("Fragment"),
                Url = url,
                Version = ProfileVersion,
                Date = this.date.ToString(),
                Status = ProfileStatus,
                Publisher = "Hl7-Clinical Interoperability Council",
                Contact = this.Contact(),
                Differential = new StructureDefinition.DifferentialComponent(),
                BaseDefinition = "http://hl7.org/fhir/StructureDefinition/Resource",
                Type = "Resource"
            };
            frag.AddDiffElement(new ElementDefinition
            {
                Path = name,
                ElementId = name
            });
            return frag;
        }

        StructureDefinition CreateBaseProfile()
        {
            StructureDefinition pBase = new StructureDefinition
            {
                Abstract = false,
                Kind = StructureDefinition.StructureDefinitionKind.Resource,
                Name = "PreFhirTest",
                Type = "Observation",
                Description = new Markdown("PreFhir Test Base Profile"),
                Url = "http://www.test.com/PreFhirTest",
                BaseDefinition = "http://hl7.org/fhir/StructureDefinition/Observation",
                Differential = new StructureDefinition.DifferentialComponent()
            };
            pBase.AddSnapElement(new ElementDefinition
            {
                Path = "Observation",
                ElementId = "Observation"
            });
            return pBase;
        }

        List<ContactDetail> Contact()
        {
            ContactDetail cd = new ContactDetail();
            cd.Telecom.Add(new ContactPoint
            {
                System = ContactPoint.ContactPointSystem.Url,
                Value = contactUrl
            });

            List<ContactDetail> retVal = new List<ContactDetail>();
            retVal.Add(cd);
            return retVal;
        }

        [Fact(DisplayName = "Merge.Create")]
        public void Create()
        {
            try
            {
                StructureDefinition pBase = this.CreateBaseProfile();
                Assert.True(pBase.BaseDefinition == "http://hl7.org/fhir/StructureDefinition/Observation");
                Assert.True(pBase.Type == "Observation");
                Assert.True(pBase.Kind == StructureDefinition.StructureDefinitionKind.Resource);
                Assert.True(pBase.Abstract == false);
                SnapshotCreator.Create(pBase);

                StructureDefinition frag = this.CreateFragment("Fragment", "http://www.test.com/frag1");
                Assert.True(frag.FhirVersion == FhirVersion);
                Assert.True(frag.Kind == StructureDefinition.StructureDefinitionKind.Logical);
                Assert.True(frag.Abstract == true);

                PreFhirGenerator p = this.CreatePreFhir();
                frag.FhirVersion = FHIRVersion.N0_01;
                frag.Version = ProfileVersion;
                frag.Date = this.date.ToString();
                frag.Status = ProfileStatus;
                frag.Publisher = "Hl7-Clinical Interoperability Council";
                frag.Contact = this.Contact();

                pBase.AddFragRef(frag);
                p.AddFragment(pBase);
                p.AddFragment(frag);
                p.Process();
                StringBuilder sb = new StringBuilder();
                p.FormatMessages(sb);
                Trace.WriteLine(sb.ToString());
                Assert.True(p.HasErrors == false);

                Assert.True(pBase.FhirVersion == FHIRVersion.N0_01);
                Assert.True(pBase.Version == ProfileVersion);
                Assert.True(pBase.Date == this.date.ToString());
                Assert.True(pBase.Status == ProfileStatus);
                Assert.True(pBase.Publisher == "Hl7-Clinical Interoperability Council");
                Assert.True(pBase.Contact.Matches(this.Contact()));
            }
            catch
            {
                Assert.False(true);
            }
        }

        /// <summary>
        /// Check for base definition rules.
        /// todo: This does not test if fragment is derived from a child of base profile.
        /// </summary>
        [Fact(DisplayName = "Merge.CheckBaseCompatability")]
        public void CheckBaseCompatability()
        {
            try
            {
                // Verify merge failes if different fhir versions.
                PreFhirGenerator p = this.CreatePreFhir();
                StructureDefinition pBase = this.CreateBaseProfile();
                StructureDefinition frag = this.CreateFragment("Fragment", "http://www.test.com/frag1");
                frag.FhirVersion = FHIRVersion.N0_01;
                pBase.AddFragRef(frag);
                p.AddFragment(pBase);
                p.AddFragment(frag);
                p.Process();
                StringBuilder sb = new StringBuilder();
                p.FormatMessages(sb);
                Trace.WriteLine(sb.ToString());
                Assert.True(p.HasErrors == false);
            }
            catch
            {
                Assert.False(true);
            }
        }

        /// <summary>
        /// Merge Cardinalities of existing elements.
        /// </summary>
        [Fact(DisplayName = "Merge.MergeCardinalities1")]
        public void MergeCardinalities1()
        {
            try
            {
                // should work.
                PreFhirGenerator p = this.CreatePreFhir();
                StructureDefinition pBase = this.CreateBaseProfile();
                StructureDefinition frag = this.CreateFragment("Fragment", "http://www.test.com/frag1");

                String pathRoot = frag.Differential.Element[0].Path;
                // use snapshot min and max in base check.
                pBase.AddSnapElement(new ElementDefinition
                {
                    Path = "Observation.partOf",
                    ElementId = "Observation.partOf"
                });

                String fragRoot = frag.Differential.Element[0].Path;
                frag.AddDiffElement(new ElementDefinition
                {
                    Path = $"{fragRoot}.partOf",
                    ElementId = $"{fragRoot}.partOf",
                    Min = 1
                });

                pBase.AddFragRef(frag);
                p.AddFragment(pBase);
                p.AddFragment(frag);
                p.Process();
                StringBuilder sb = new StringBuilder();
                p.FormatMessages(sb);
                Trace.WriteLine(sb.ToString());
                Assert.True(p.HasErrors == false);
                Assert.True(pBase.Differential.Element.Count == 2);
            }
            catch
            {
                Assert.False(true);
            }
        }

        /// <summary>
        /// Merge Cardinalities of existing elements.
        /// </summary>
        [Fact(DisplayName = "Merge.MergeCardinalities2")]
        public void MergeCardinalities2()
        {
            try
            {
                // should work.
                PreFhirGenerator p = this.CreatePreFhir();
                StructureDefinition pBase = this.CreateBaseProfile();
                StructureDefinition frag = this.CreateFragment("Fragment", "http://www.test.com/frag1");

                // use snapshot min and max in base check.
                pBase.AddSnapElement(new ElementDefinition
                {
                    Path = "Observation.partOf",
                    ElementId = "Observation.partOf"
                });

                String fragRoot = frag.Differential.Element[0].Path;
                frag.AddDiffElement(new ElementDefinition
                {
                    Path = $"{fragRoot}.partOf",
                    ElementId = $"{fragRoot}.partOf",
                    Min = 1,
                    Max = "10"
                });

                pBase.AddFragRef(frag);
                p.AddFragment(pBase);
                p.AddFragment(frag);
                p.Process();
                StringBuilder sb = new StringBuilder();
                p.FormatMessages(sb);
                Trace.WriteLine(sb.ToString());
                Assert.True(p.HasErrors == false);
                Assert.True(pBase.Differential.Element.Count == 2);
                Assert.True(pBase.Differential.Element[1].Min == 1);
                Assert.True(pBase.Differential.Element[1].Max == "10");
            }
            catch
            {
                Assert.False(true);
            }
        }


        /// <summary>
        /// Merge Cardinalities of existing elements.
        /// </summary>
        [Fact(DisplayName = "Merge.MergeCardinalities3")]
        public void MergeCardinalities3()
        {
            try
            {
                // should work.
                PreFhirGenerator p = this.CreatePreFhir();
                StructureDefinition pBase = this.CreateBaseProfile();
                StructureDefinition frag = this.CreateFragment("Fragment", "http://www.test.com/frag1");

                pBase.AddSnapElement(new ElementDefinition
                {
                    Path = "Observation.partOf",
                    ElementId = "Observation.partOf",
                    Min = 0,
                    Max = "*",
                });

                String fragRoot = frag.Differential.Element[0].Path;
                frag.AddDiffElement(new ElementDefinition
                {
                    Path = $"{fragRoot}.partOf",
                    ElementId = $"{fragRoot}.partOf",
                    Max = "5"
                });

                pBase.AddFragRef(frag);
                p.AddFragment(pBase);
                p.AddFragment(frag);
                p.Process();
                StringBuilder sb = new StringBuilder();
                p.FormatMessages(sb);
                Trace.WriteLine(sb.ToString());
                Assert.True(p.HasErrors == false);
                Assert.True(pBase.Differential.Element.Count == 2);
                Assert.True(pBase.Differential.Element[1].Min == 0);
                Assert.True(pBase.Differential.Element[1].Max == "5");
            }
            catch
            {
                Assert.False(true);
            }
        }

        /// <summary>
        /// Merge Cardinalities of existing elements.
        /// </summary>
        [Fact(DisplayName = "Merge.MergeCardinalities4")]
        public void MergeCardinalities4()
        {
            try
            {
                // should work.
                PreFhirGenerator p = this.CreatePreFhir();
                StructureDefinition pBase = this.CreateBaseProfile();
                StructureDefinition frag = this.CreateFragment("Fragment", "http://www.test.com/frag1");

                pBase.AddSnapElement(new ElementDefinition
                {
                    Path = "Observation.partOf",
                    ElementId = "Observation.partOf",
                    Min = 0,
                    Max = "*",
                });

                String fragRoot = frag.Differential.Element[0].Path;
                frag.AddDiffElement(new ElementDefinition
                {
                    Path = $"{fragRoot}.partOf",
                    ElementId = $"{fragRoot}.partOf",
                    Min = 1,
                    Max = "2",
                });

                pBase.AddFragRef(frag);
                p.AddFragment(pBase);
                p.AddFragment(frag);
                p.Process();
                StringBuilder sb = new StringBuilder();
                p.FormatMessages(sb);
                Trace.WriteLine(sb.ToString());
                Assert.True(p.HasErrors == false);
                Assert.True(pBase.Differential.Element.Count == 2);
                Assert.True(pBase.Differential.Element[1].Min == 1);
                Assert.True(pBase.Differential.Element[1].Max == "2");
            }
            catch
            {
                Assert.False(true);
            }
        }

        /// <summary>
        /// Merge Cardinalities of existing elements.
        /// </summary>
        [Fact(DisplayName = "Merge.MergeCardinalities5")]
        public void MergeCardinalities5()
        {
            try
            {
                // should fail.
                PreFhirGenerator p = this.CreatePreFhir();
                StructureDefinition pBase = this.CreateBaseProfile();
                StructureDefinition frag = this.CreateFragment("Fragment", "http://www.test.com/frag1");

                pBase.AddSnapElement(new ElementDefinition
                {
                    Path = "Observation.partOf",
                    ElementId = "Observation.partOf",
                    Min = 1,
                    Max = "10",
                });

                String fragRoot = frag.Differential.Element[0].Path;
                frag.AddDiffElement(new ElementDefinition
                {
                    Path = $"{fragRoot}.partOf",
                    ElementId = $"{fragRoot}.partOf",
                    Min = 0,
                });

                pBase.AddFragRef(frag);
                p.AddFragment(pBase);
                p.AddFragment(frag);
                p.Process();
                StringBuilder sb = new StringBuilder();
                p.FormatMessages(sb);
                Trace.WriteLine(sb.ToString());
                Assert.True(p.HasErrors == true);
            }
            catch
            {
                Assert.False(true);
            }
        }

        /// <summary>
        /// Merge Cardinalities of existing elements.
        /// </summary>
        [Fact(DisplayName = "Merge.MergeCardinalities6")]
        public void MergeCardinalities6()
        {
            try
            {
                // should fail.
                PreFhirGenerator p = this.CreatePreFhir();
                StructureDefinition pBase = this.CreateBaseProfile();
                StructureDefinition frag = this.CreateFragment("Fragment", "http://www.test.com/frag1");

                pBase.AddSnapElement(new ElementDefinition
                {
                    Path = "Observation.partOf",
                    ElementId = "Observation.partOf",
                    Min = 1,
                    Max = "10",
                });

                String fragRoot = frag.Differential.Element[0].Path;
                frag.AddDiffElement(new ElementDefinition
                {
                    Path = $"{fragRoot}.partOf",
                    ElementId = $"{fragRoot}.partOf",
                    Max = "11",
                });

                pBase.AddFragRef(frag);
                p.AddFragment(pBase);
                p.AddFragment(frag);
                p.Process();
                StringBuilder sb = new StringBuilder();
                p.FormatMessages(sb);
                Trace.WriteLine(sb.ToString());
                Assert.True(p.HasErrors == true);
            }
            catch
            {
                Assert.False(true);
            }
        }

        /// <summary>
        /// Merge Cardinalities of existing elements.
        /// </summary>
        [Fact(DisplayName = "Merge.MergeTypes1")]
        public void MergeTypes1()
        {
            try
            {
                // should work.
                PreFhirGenerator p = this.CreatePreFhir();
                StructureDefinition pBase = this.CreateBaseProfile();
                SnapshotCreator.Create(pBase);

                StructureDefinition frag = this.CreateFragment("Fragment", "http://www.test.com/frag1");
                String fragRoot = frag.Differential.Element[0].Path;
                {
                    ElementDefinition e = new ElementDefinition
                    {
                        Path = $"{fragRoot}.value[x]",
                        ElementId = $"{fragRoot}.value[x]",
                        Min = 1,
                        Max = "1"
                    };
                    e.Type.Add(new ElementDefinition.TypeRefComponent { Code = "string" });
                    frag.AddDiffElement(e);
                }
                pBase.AddFragRef(frag);
                p.AddFragment(pBase);
                p.AddFragment(frag);
                p.Process();
                StringBuilder sb = new StringBuilder();
                p.FormatMessages(sb);
                Trace.WriteLine(sb.ToString());
                Assert.True(p.HasErrors == false);
                Assert.True(pBase.Differential.Element.Count == 2);
                Assert.True(pBase.Differential.Element[1].Min == 1);
                Assert.True(pBase.Differential.Element[1].Max == "1");
                Assert.True(pBase.Differential.Element[1].Type.Count == 1);
                Assert.True(pBase.Differential.Element[1].Type[0].Code == "string");
            }
            catch
            {
                Assert.False(true);
            }
        }

        /// <summary>
        /// Merge Cardinalities of existing elements.
        /// </summary>
        [Fact(DisplayName = "Merge.MergeTypes2")]
        public void MergeTypes2()
        {
            try
            {
                PreFhirGenerator p = this.CreatePreFhir();
                StructureDefinition pBase = this.CreateBaseProfile();
                StructureDefinition frag = this.CreateFragment("Fragment", "http://www.test.com/frag1");
                String fragRoot = frag.Differential.Element[0].Path;
                {
                    ElementDefinition e = new ElementDefinition
                    {
                        Path = "Observation.value[x]",
                        ElementId = "Observation.value[x]"
                    };
                    e.Type.Add(new ElementDefinition.TypeRefComponent { Code = "integer" });
                    e.Type.Add(new ElementDefinition.TypeRefComponent { Code = "decimal" });
                    pBase.AddSnapElement(e);
                }

                {
                    ElementDefinition e = new ElementDefinition
                    {
                        Path = $"{fragRoot}.value[x]",
                        ElementId = $"{fragRoot}.value[x]",
                    };
                    e.Type.Add(new ElementDefinition.TypeRefComponent { Code = "string" });
                    frag.AddDiffElement(e);
                }
                pBase.AddFragRef(frag);
                p.AddFragment(pBase);
                p.AddFragment(frag);
                Debug.Assert(p.Process() == false);
            }
            catch
            {
                Assert.False(true);
            }
        }

        /// <summary>
        /// Merge Cardinalities of existing elements.
        /// </summary>
        [Fact(DisplayName = "Merge.MergeFrag1")]
        public void MergeFrag1()
        {
            try
            {
                // should work.
                PreFhirGenerator p = this.CreatePreFhir();
                StructureDefinition pBase = this.CreateBaseProfile();

                {
                    ElementDefinition e = new ElementDefinition
                    {
                        Path = $"Observation.category",
                        ElementId = $"Observation.category",
                        Min = 0,
                        Max = "*"
                    };
                    pBase.AddSnapElement(e);
                }

                {
                    ElementDefinition e = new ElementDefinition
                    {
                        Path = $"Observation.effective[x]",
                        ElementId = $"Observation.effective[x]",
                        Min = 0,
                        Max = "*"
                    };
                    e.Type.Add(new ElementDefinition.TypeRefComponent { Code = "integer" });
                    e.Type.Add(new ElementDefinition.TypeRefComponent { Code = "dateTime" });
                    pBase.AddSnapElement(e);
                }

                {
                    ElementDefinition e = new ElementDefinition
                    {
                        Path = "Observation.value[x]",
                        ElementId = "Observation.value[x]"
                    };
                    pBase.AddSnapElement(e);
                    e.Type.Add(new ElementDefinition.TypeRefComponent { Code = "string" });
                    e.Type.Add(new ElementDefinition.TypeRefComponent { Code = "decimal" });
                    e.Type.Add(new ElementDefinition.TypeRefComponent { Code = "coding" });
                }

                StructureDefinition frag1 = this.CreateFragment("Frag1", "http://www.test.com/frag1");
                StructureDefinition frag2 = this.CreateFragment("Frag2", "http://www.test.com/frag2");
                StructureDefinition frag3 = this.CreateFragment("Frag3", "http://www.test.com/frag3");
                {
                    ElementDefinition e = new ElementDefinition
                    {
                        Path = $"Frag1.value[x]",
                        ElementId = $"Frag1.value[x]",
                    };
                    e.Type.Add(new ElementDefinition.TypeRefComponent { Code = "string" });
                    frag1.AddDiffElement(e);
                }
                {
                    ElementDefinition e = new ElementDefinition
                    {
                        Path = $"Frag2.effective[x]",
                        ElementId = $"Frag2.effective[x]",
                        Min = 1
                    };
                    e.Type.Add(new ElementDefinition.TypeRefComponent { Code = "dateTime" });
                    frag2.AddDiffElement(e);
                }

                {
                    ElementDefinition e = new ElementDefinition
                    {
                        Path = $"Frag3.category",
                        ElementId = $"Frag3.category",
                        Min = 1,
                        Max = "1"
                    };

                    frag3.AddDiffElement(e);
                }

                pBase.AddFragRef(frag1);
                frag1.AddFragRef(frag2);
                frag2.AddFragRef(frag3);
                p.AddFragment(pBase);
                p.AddFragment(frag1);
                p.AddFragment(frag2);
                p.AddFragment(frag3);
                p.Process();
                StringBuilder sb = new StringBuilder();
                p.FormatMessages(sb);
                Trace.WriteLine(sb.ToString());
                Assert.True(p.HasErrors == false);
                Assert.True(frag2.Differential.Element.Count == 3);
                Assert.True(frag1.Differential.Element.Count == 4);
                Assert.True(pBase.Differential.Element.Count == 4);

                Assert.True(pBase.Differential.Element[1].Path == "Observation.category");

                Assert.True(pBase.Differential.Element[2].Path == "Observation.effective[x]");
                Assert.True(pBase.Differential.Element[2].Type.Count == 1);
                Assert.True(pBase.Differential.Element[2].Type[0].Code == "dateTime");

                Assert.True(pBase.Differential.Element[3].Path == "Observation.value[x]");
                Assert.True(pBase.Differential.Element[3].Type.Count == 1);
                Assert.True(pBase.Differential.Element[3].Type[0].Code == "string");
            }
            catch
            {
                Assert.False(true);
            }
        }
    }
}
