using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace FhirKhit.BreastRadiology
{
    class SDefEditor
    {
        public class ElementIndex
        {
            public Int32 Index;
            public ElementDefinition ElementDefinition;
            public List<ElementDefinition> SliceElements = new List<ElementDefinition>();

            public ElementDefinition AppendSlice(String sliceName)
            {
                ElementDefinition retVal = new ElementDefinition
                {
                    Path = this.ElementDefinition.Path,
                    ElementId = $"{this.ElementDefinition.Path}:{sliceName}",
                    SliceName = sliceName
                };
                this.SliceElements.Add(retVal);
                return retVal;
            }
        }

        static FhirStructureDefinitions Defs
        {
            get
            {
                lock (typeof(SDefEditor))
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

        Dictionary<String, ElementIndex> baseElements = new Dictionary<string, ElementIndex>();
        Dictionary<String, ElementIndex> elements = new Dictionary<string, ElementIndex>();

        public SDefEditor(String baseDefinition)
        {
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
                    ElementDefinition ed = new ElementDefinition
                    {
                        Path = e.ElementDefinition.Path,
                        ElementId = e.ElementDefinition.ElementId
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

        public void Write(String outputDir)
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

            String outputName = Path.Combine(outputDir, $"StructureDefinition_{this.sDef.Name}.json");
            this.sDef.SaveJson(outputName);
        }

        /// <summary>
        /// Add the indicated slice by url.
        /// </summary>
        ElementDefinition SliceByUrl(String path,
            String sliceUrl,
            String sliceName)
        {
            ElementIndex extension = this.Find(path);
            ElementDefinition extSlice = extension.AppendSlice(sliceName);
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
            return SliceByUrl("extension", extensionUrl, name);
        }

        public SDefEditor ContactUrl(String value)
        {
            ContactDetail cd = new ContactDetail();
            cd.Telecom.Add(new ContactPoint
            {
                System = ContactPoint.ContactPointSystem.Url,
                Value = value
            });
            this.sDef.Contact.Add(cd);
            return this;
        }

        public SDefEditor Name(String value) { this.sDef.Name = value; return this; }
        public SDefEditor Description(String value) { this.sDef.Description = new Markdown(value); return this; }
        public SDefEditor Url(String value) { this.sDef.Url = value; return this; }
        public SDefEditor Publisher(String value) { this.sDef.Publisher = value; return this; }
        public SDefEditor Title(String value) { this.sDef.Title = value; return this; }
        public SDefEditor Status(PublicationStatus? value) { this.sDef.Status = value; return this; }
        public SDefEditor Date(FhirDateTime value) { this.sDef.Date = value.Value; return this; }
        public SDefEditor Derivation(StructureDefinition.TypeDerivationRule? value) { this.sDef.Derivation = value; return this; }
        public SDefEditor Abstract(bool? value) { this.sDef.Abstract = value; return this; }
        public SDefEditor Kind(StructureDefinition.StructureDefinitionKind? value) { this.sDef.Kind = value; return this; }
    }
}
