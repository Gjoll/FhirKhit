using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace FhirKhit.BreastRadiology
{
    class SDefEditor
    {
        class ElementIndex
        {
            public Int32 Index;
            public ElementDefinition ElementDefinition;
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
        public ElementDefinition Select(String path)
        {
            if (path.StartsWith(this.basePath) == false)
                path = $"{basePath}{path}";

            {
                if (this.elements.TryGetValue(path, out ElementIndex e) == true)
                    return e.ElementDefinition;
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
                    return ed;
                }
            }
            throw new Exception($"'{path}' not found");
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
            }

            String outputName = $"StructureDefinition_{this.sDef.Name}";
            this.sDef.SaveJson(outputName);
        }

        public SDefEditor Name(String value)
        {
            this.sDef.Name = value;
            return this;
        }

        public SDefEditor Description(String value)
        {
            this.sDef.Description = new Markdown(value);
            return this;
        }

        public SDefEditor Url(String value)
        {
            this.sDef.Url = value;
            return this;
        }
    }
}
