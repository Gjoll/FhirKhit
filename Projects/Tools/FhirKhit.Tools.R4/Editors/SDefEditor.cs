using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace FhirKhit.Tools.R4
{
    public class SDefEditor
    {
        public class ElementIndex
        {
            public Int32 Index;
            public ElementDefinition ElementDefinition;
            public List<ElementDefinition> SliceElements = new List<ElementDefinition>();

            public ElementDefinition AppendSlice(String parentName,
                String sliceName)
            {
                ElementDefinition retVal = new ElementDefinition
                {
                    Path = this.ElementDefinition.Path,
                    ElementId = $"{this.ElementDefinition.Path}:{sliceName}",
                    SliceName = sliceName,
                    Min = 0,
                    Max = "*",
                    Base = new ElementDefinition.BaseComponent
                    {
                        Min = 0,
                        Max = "*",
                        Path = $"{parentName}"
                    }
                };
                this.SliceElements.Add(retVal);
                return retVal;
            }
        }

        static Type sDefType = typeof(SDefEditor);
        static FhirStructureDefinitions Defs
        {
            get
            {
                lock (sDefType)
                {
                    if (defs == null)
                        defs = new FhirStructureDefinitions();
                    return defs;
                }
            }
        }
        static FhirStructureDefinitions defs;

        public StructureDefinition SDef => this.sDef;
        StructureDefinition baseSDef;
        StructureDefinition sDef;
        String basePath;
        String outputDir;

        Dictionary<String, ElementIndex> baseElements = new Dictionary<string, ElementIndex>();
        Dictionary<String, ElementIndex> elements = new Dictionary<string, ElementIndex>();

        public SDefEditor(String baseDefinition, String outputDir)
        {
            this.outputDir = outputDir;
            baseSDef = Defs.GetResource(baseDefinition);
            basePath = $"{this.baseSDef.Snapshot.Element[0].Path}.";

            for (Int32 i = 0; i < baseSDef.Snapshot.Element.Count; i++)
            {
                ElementDefinition elementDefinition = baseSDef.Snapshot.Element[i];
                ElementIndex e = new ElementIndex
                {
                    Index = i,
                    ElementDefinition = elementDefinition
                };
                this.baseElements.Add(elementDefinition.Path, e);
            }

            sDef = new StructureDefinition
            {
                BaseDefinition = baseDefinition,
                Differential = new StructureDefinition.DifferentialComponent()
            };

            sDef.Differential.Element.Add(baseSDef.Differential.Element[0]);
        }

        /// <summary>
        /// Select a element definition from the base sdef by its path name and 
        /// copy it to the differential of the output sdef.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public ElementIndex Find(String path)
        {
            if (path.StartsWith(this.basePath) == false)
                path = $"{basePath}{path}";

            {
                if (this.elements.TryGetValue(path, out ElementIndex e) == true)
                    return e;
            }
            {
                if (this.baseElements.TryGetValue(path, out ElementIndex e) == true)
                {
                    ElementDefinition eBase = e.ElementDefinition;
                    ElementDefinition ed = new ElementDefinition
                    {
                        Path = eBase.Path,
                        ElementId = eBase.ElementId,
                        Base = new ElementDefinition.BaseComponent
                        {
                            Path = eBase.Path,
                            Min = eBase.Min,
                            Max = eBase.Max
                        }
                    };
                    ElementIndex newE = new ElementIndex
                    {
                        Index = e.Index,
                        ElementDefinition = ed
                    };
                    this.elements.Add(ed.Path, newE);
                    return newE;
                }
            }
            throw new Exception($"'{path}' not found");
        }

        /// <summary>
        /// Select a element definition from the base sdef by its path name and 
        /// copy it to the differential of the output sdef.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public ElementDefinition Select(String path)
        {
            return this.Find(path).ElementDefinition;
        }

        public String Write()
        {
            List<ElementIndex> eList = this.elements.Values.ToList();
            eList.Sort((a, b) =>
            {
                return a.Index.CompareTo(b.Index);
            });
            foreach (ElementIndex item in eList)
            {
                this.sDef.Differential.Element.Add(item.ElementDefinition);
                this.sDef.Differential.Element.AddRange(item.SliceElements);
            }

            String outputName = Path.Combine(outputDir, $"StructureDefinition-{this.sDef.Name}.json");
            this.sDef.SaveJson(outputName);
            return outputName;
        }


        /// <summary>
        /// Add the indicated slice by url.
        /// </summary>
        public SDefEditor SliceByCode(String baseName,
            String path,
            String sliceName,
            String system,
            String code)
        {
            sliceName = sliceName.UncapFirstLetter();
            ElementIndex e = this.Find(path);
            e.ElementDefinition.Slicing = new ElementDefinition.SlicingComponent
            {
                Rules = ElementDefinition.SlicingRules.Open
            };

            e.ElementDefinition.Slicing.Discriminator.Add(new ElementDefinition.DiscriminatorComponent
            {
                Type = ElementDefinition.DiscriminatorType.Value,
                Path = "coding"
            });

            ElementDefinition coding = new ElementDefinition
            {
                ElementId = $"{path}.coding",
                Path = $"{path}.coding",
            };
            e.SliceElements.Add(coding);

            ElementDefinition slice = new ElementDefinition
            {
                ElementId = $"{path}.coding",
                Path = $"{path}.coding:{sliceName}",
                SliceName = sliceName,
                Min = 1,
                Max = "1",
                Base = new ElementDefinition.BaseComponent
                {
                    Min = 0,
                    Max = "*",
                    Path = $"{baseName}"
                }
            };
            e.SliceElements.Add(slice);
            return this;
        }

        /// <summary>
        /// Add the indicated slice by url.
        /// </summary>
        ElementDefinition SliceByUrl(String baseName,
            String path,
            String sliceUrl,
            String sliceName)
        {
            sliceName = sliceName.UncapFirstLetter();

            ElementIndex extension = this.Find(path);
            ElementDefinition extSlice = extension.AppendSlice(baseName, sliceName);
            extSlice.IsModifier = false;
            extSlice.Type.Add(new ElementDefinition.TypeRefComponent
            {
                Code = "Extension",
                Profile = new String[] { sliceUrl }
            });
            return extSlice;
        }

        /// <summary>
        /// Configure the extension element to have the corret slicing discriminator. This does not
        /// add the slice, just the discriminator.
        /// </summary>
        void ConfigureExtensionSlice()
        {
            ElementDefinition extDef = this.Select("extension");
            // I assume that if slicing exists, it was added by the code below.
            // If someone else adds slicing differently than below there will be a problem....
            if (extDef.Slicing == null)
            {
                extDef.Slicing = new ElementDefinition.SlicingComponent
                {
                    Ordered = false,
                    Rules = ElementDefinition.SlicingRules.Open
                };
                extDef.Slicing.Discriminator.Add(new ElementDefinition.DiscriminatorComponent
                {
                    Type = ElementDefinition.DiscriminatorType.Value,
                    Path = "url"
                });
            }
        }

        public ElementDefinition SimpleExtension(String name, String extensionUrl)
        {
            ConfigureExtensionSlice();
            return SliceByUrl(this.baseSDef.Name, "extension", extensionUrl, name);
        }

        public SDefEditor ContactUrl(String value) { this.sDef.ContactUrl(value); return this; }
        public SDefEditor Name(String value) { this.sDef.Name(value); return this; }
        public SDefEditor Description(params String[] value) { this.sDef.Description(value.ToMarkup()); return this; }
        public SDefEditor Url(String value) { this.sDef.Url(value); return this; }
        public SDefEditor Publisher(String value) { this.sDef.Publisher(value); return this; }
        public SDefEditor Title(String value) { this.sDef.Title(value); return this; }
        public SDefEditor Status(PublicationStatus? value) { this.sDef.Status(value); return this; }
        public SDefEditor Date(FhirDateTime value) { this.sDef.Date(value); return this; }
        public SDefEditor Derivation(StructureDefinition.TypeDerivationRule? value) { this.sDef.Derivation(value); return this; }
        public SDefEditor Abstract(bool? value) { this.sDef.Abstract(value); return this; }
        public SDefEditor Kind(StructureDefinition.StructureDefinitionKind? value) { this.sDef.Kind(value); return this; }
        public SDefEditor Version(String value) { this.sDef.Version(value); return this; }
        public SDefEditor Type(String value) { this.sDef.Type(value); return this; }
        public SDefEditor Context(StructureDefinition.ExtensionContextType type = StructureDefinition.ExtensionContextType.Element,
            String expression = "*")
        {
            this.sDef.Context(type, expression);
            return this;
        }
    }
}
