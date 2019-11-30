using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using PreFhir;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    class SDefEditor
    {
        static Type sDefType = typeof(SDefEditor);

        public MapNode MapNode {get; }
        public String[] MapName {get; set; }

        public StructureDefinition SDef => this.sDef;
        StructureDefinition baseSDef;
        StructureDefinition sDef;
        String basePath;
        String outputDir;

        Dictionary<String, ElementDefGroup> baseElements = new Dictionary<string, ElementDefGroup>();
        Dictionary<String, ElementDefGroup> elements = new Dictionary<string, ElementDefGroup>();
        List<ElementDefGroup> elementOrder = new List<ElementDefGroup>();

        /// <summary>
        /// Create structure definition editor
        /// </summary>
        public SDefEditor(String name,
            String url,
            String baseDefinition,
            String[] mapName,
            String outputDir)
        {
            this.outputDir = outputDir;
            this.baseSDef = FhirStructureDefinitions.Self.GetResource(baseDefinition);
            if (this.baseSDef == null)
                throw new Exception($"'Base definition resource {baseDefinition}' not found");

            this.MapName = mapName;
            this.basePath = baseDefinition.LastUriPart();

            for (Int32 i = 0; i < this.baseSDef.Snapshot.Element.Count; i++)
            {
                ElementDefinition elementDefinition = this.baseSDef.Snapshot.Element[i];
                ElementDefGroup e = new ElementDefGroup(i, elementDefinition, null);
                this.baseElements.Add(elementDefinition.ElementId.SkipFirstPathPart(), e);
            }

            this.sDef = new StructureDefinition
            {
                Name = name, 
                Url = url,
                BaseDefinition = baseDefinition,
                Differential = new StructureDefinition.DifferentialComponent()
            };

            this.MapNode = ResourceMap.Self.GetMapNode(url);

            this.sDef.Differential.Element.Add(new ElementDefinition
            {
                Path = basePath,
                ElementId = basePath,
                Min = 0,
                Max = "*"
            });
            //mapNode = ResourceMap.Self.GetMapNode(retVal.SDef.Url);
        }

        public ElementDefGroup InsertAfter(ElementDefGroup at,
            ElementDefinition e)
        {
            return this.AddElementDefinition(at.Index, e, null);
        }

        /// <summary>
        /// Select a element definition from the base sdef by its path name and 
        /// copy it to the differential of the output sdef.
        /// Note: Path is fhir path without the first element.
        /// ie. 'Observation.value[x]' is just 'value[x]'
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public ElementDefGroup Find(String path)
        {
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
                    return this.AddElementDefinition(e.Index, ed, e.ElementDefinition);
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
            this.elements.Add(elementDefinition.ElementId.SkipFirstPathPart(), newE);
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
            foreach (ElementDefGroup item in this.elementOrder)
            {
                this.sDef.Differential.Element.Add(item.ElementDefinition);
                this.sDef.Differential.Element.AddRange(item.RelatedElements);
            }

            // Patch Path and Id's with correct basePath.
            foreach (ElementDefinition e in this.sDef.Differential.Element)
            {
                e.Path = e.Path.ReplacePathBase(this.basePath);
                e.ElementId= e.ElementId.ReplacePathBase(this.basePath);
            }

            String outputName = Path.Combine(this.outputDir, $"StructureDefinition-{this.sDef.Name}.json");
            this.sDef.SaveJson(outputName);
            return outputName;
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
                extDef.ConfigureSliceByUrlDiscriminator();
        }

        public ElementDefinition ApplyExtension(String name, String extensionUrl, bool showChildren = true)
        {
            this.MapNode.AddLink("target", extensionUrl, showChildren);
            this.ConfigureExtensionSlice();
            return this.Find("extension").SliceByUrl(extensionUrl, name);
        }

        public SDefEditor ContactUrl(String value) { this.sDef.ContactUrl(value); return this; }
        public SDefEditor Description(Markdown value) { this.sDef.Description(value); return this; }
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

        public SDefEditor AddFragRef(StructureDefinition fragRef)
        {
            this.AddFragRef(fragRef.Url);
            return this;
        }

        public SDefEditor SetIsFrag()
        {
            this.SDef.Extension.Add(new Extension
            {
                Url = PreFhirGenerator.IsFragmentUrl,
                Value = new FhirBoolean(true)
            });
            return this;
        }

        public SDefEditor AddFragRef(String fragRef)
        {
            if (String.IsNullOrWhiteSpace(fragRef))
                throw new Exception($"Fragment Url must not be empty");
            this.SDef.Extension.Add(new Extension
            {
                Url = PreFhirGenerator.FragmentUrl,
                Value = new FhirUrl(fragRef)
            });
            this.MapNode.AddFragmentLink(fragRef);
            return this;
        }
    }
}
