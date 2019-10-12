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

        Dictionary<String, ElementDefGroup> baseElements = new Dictionary<string, ElementDefGroup>();
        Dictionary<String, ElementDefGroup> elements = new Dictionary<string, ElementDefGroup>();
        List<ElementDefGroup> elementOrder = new List<ElementDefGroup>();

        public SDefEditor(String baseDefinition, String outputDir)
        {
            this.outputDir = outputDir;
            baseSDef = Defs.GetResource(baseDefinition);
            basePath = $"{this.baseSDef.Snapshot.Element[0].Path}.";

            for (Int32 i = 0; i < baseSDef.Snapshot.Element.Count; i++)
            {
                ElementDefinition elementDefinition = baseSDef.Snapshot.Element[i];
                ElementDefGroup e = new ElementDefGroup(i, elementDefinition, null);
                this.baseElements.Add(elementDefinition.ElementId, e);
            }

            sDef = new StructureDefinition
            {
                BaseDefinition = baseDefinition,
                Differential = new StructureDefinition.DifferentialComponent()
            };

            sDef.Differential.Element.Add(baseSDef.Differential.Element[0]);
        }

        public ElementDefGroup InsertAfter(ElementDefGroup at,
            ElementDefinition e)
        {
            return AddElementDefinition(at.Index, e, null);
        }

        /// <summary>
        /// Select a element definition from the base sdef by its path name and 
        /// copy it to the differential of the output sdef.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public ElementDefGroup Find(String path)
        {
            if (path.StartsWith(this.basePath) == false)
                path = $"{basePath}{path}";

            {
                if (this.elements.TryGetValue(path, out ElementDefGroup e) == true)
                    return e;
            }
            {
                if (this.baseElements.TryGetValue(path, out ElementDefGroup e) == true)
                {
                    ElementDefinition eBase = e.ElementDefinition;
                    ElementDefinition ed = new ElementDefinition
                    {
                        Path = eBase.Path,
                        ElementId = eBase.ElementId,
                        Min = eBase.Min,
                        Max = eBase.Max
                    };
                    return AddElementDefinition(e.Index, ed, e.ElementDefinition);
                }
            }
            throw new Exception($"'{path}' not found");
        }

        /// <summary>
        /// Insert element ordered by the index. If other items are already
        /// inserted witht his index, the new element will be inserted after them.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="elementDefinition"></param>
        /// <param name="baseDefinition"></param>
        ElementDefGroup AddElementDefinition(Int32 index,
            ElementDefinition elementDefinition,
            ElementDefinition baseDefinition)
        {
            ElementDefGroup newE = new ElementDefGroup(index, elementDefinition, baseDefinition);
            this.elements.Add(elementDefinition.ElementId, newE);
            Int32 i = this.elementOrder.Count;
            while ((i > 0) && (this.elementOrder[i-1].Index > index))
                i -= 1;
            this.elementOrder.Insert(i, newE);
            return newE;
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

        public ElementDefinition Clone(String path)
        {
            if (path.StartsWith(this.basePath) == false)
                path = $"{basePath}{path}";

            if (this.baseElements.TryGetValue(path, out ElementDefGroup e) == false)
                throw new Exception($"{path} not found");
            ElementDefinition eBase = e.ElementDefinition;
            ElementDefinition ed = new ElementDefinition
            {
                Path = eBase.Path,
                ElementId = eBase.ElementId,
            };
            return ed;
        }

        public String Write()
        {
            foreach (ElementDefGroup item in elementOrder)
            {
                this.sDef.Differential.Element.Add(item.ElementDefinition);
                this.sDef.Differential.Element.AddRange(item.RelatedElements);
            }

            String outputName = Path.Combine(outputDir, $"StructureDefinition-{this.sDef.Name}.json");
            this.sDef.SaveJson(outputName);
            return outputName;
        }

        /// <summary>
        /// Set up a slice on the indicated url's
        /// </summary>
        /// <param name="path"></param>
        /// <param name="targets"></param>
        /// <returns></returns>
        public SDefEditor SliceByUrl(String path,
            IEnumerable<ObservationTarget> targets)
        {
            ElementDefGroup e = this.Find(path);
            return this.SliceByUrl(e, targets);
        }

        public SDefEditor SliceByUrl(ElementDefGroup eGroup,
            IEnumerable<ObservationTarget> targets)
        {
            this.SliceByUrl(eGroup);
            //if (restrictFlag == true)
            //{
            //    List<String> targetProfiles = new List<String>();
            //    foreach (ObservationTarget target in targets)
            //        targetProfiles.Add(target.Profile);
            //    List<ElementDefinition.TypeRefComponent> types = new List<ElementDefinition.TypeRefComponent>();
            //    types.Add(new ElementDefinition.TypeRefComponent
            //    {
            //        Code = "Reference",
            //        TargetProfile = targetProfiles
            //    });
            //    e.ElementDefinition.Type = types;
            //}
            foreach (ObservationTarget target in targets)
            {
                String sliceName = target.Profile.LastUriPart().UncapFirstLetter();
                ElementDefinition sliceElement = eGroup.AppendSlice(sliceName, target.Min, target.Max);
                sliceElement.Type.Clear();
                sliceElement.Type.Add(new ElementDefinition.TypeRefComponent
                {
                    Code = "Reference",
                    TargetProfile = new String[] { target.Profile }
                });
            }
            return this;
        }

        public SDefEditor SliceByUrl(ElementDefGroup eGroup)
        {
            return SliceByUrl(eGroup.ElementDefinition);
        }

        public SDefEditor SliceByUrl(ElementDefinition eDef)
        {
            if (eDef.Slicing == null)
            {
                eDef.Slicing = new ElementDefinition.SlicingComponent
                {
                    Ordered = true,
                    Rules = ElementDefinition.SlicingRules.OpenAtEnd
                };
            }
            eDef.Slicing.Discriminator.Add(new ElementDefinition.DiscriminatorComponent
            {
                Type = ElementDefinition.DiscriminatorType.Value,
                Path = "url"
            });
            return this;
        }


        /// <summary>
        /// Add the indicated slice by url.
        /// </summary>
        public SDefEditor FixedCodeSlice(String path,
            String sliceName,
            String system,
            String code)
        {
            ElementDefGroup e = this.Find(path);
            return FixedCodeSlice(e, sliceName, system, code);
        }

        /// <summary>
        /// Add the indicated slice by url.
        /// </summary>
        public SDefEditor FixedCodeSlice(ElementDefGroup e,
            String sliceName,
            String system,
            String code)
        {
            e.FixedCodeSlice(sliceName, system, code);
            return this;
        }

        /// <summary>
        /// Add the indicated slice by url.
        /// </summary>
        ElementDefinition SliceByUrl(String path,
            String sliceUrl,
            String sliceName)
        {
            sliceName = sliceName.UncapFirstLetter();

            ElementDefGroup extension = this.Find(path);
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
                SliceByUrl(extDef);
        }

        public ElementDefinition ApplyExtension(String name, String extensionUrl)
        {
            ConfigureExtensionSlice();
            return SliceByUrl("extension", extensionUrl, name);
        }

        public SDefEditor ContactUrl(String value) { this.sDef.ContactUrl(value); return this; }
        public SDefEditor Name(String value) { this.sDef.Name(value); return this; }
        public SDefEditor Description(Markdown value) { this.sDef.Description(value); return this; }
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

        public SDefEditor ApplyBreastBodyLocation(String breastBodyLocationUrl)
        {
            if (this.sDef.Type != "Observation")
                throw new Exception("BreastBodyLocation can only be applied to Observations");
            this.Select("bodySite")
                .Single()
                ;
            this.ApplyExtension("breastBodyLocation", breastBodyLocationUrl);
            return this;
        }
    }
}
