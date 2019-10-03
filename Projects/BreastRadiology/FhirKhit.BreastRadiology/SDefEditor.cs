using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.BreastRadiology
{
    class SDefEditor
    {
        Int32 selectionIndex = 0;

        StructureDefinition baseSDef;
        StructureDefinition sDef;
        String basePath;

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

        public SDefEditor(String baseDefinition)
        {
            baseSDef = Defs.GetResource(baseDefinition);
            basePath = $"{this.baseSDef.Snapshot.Element[0].Path}.";

            sDef = new StructureDefinition
            {
                BaseDefinition = baseDefinition,
                Differential = new StructureDefinition.DifferentialComponent()
            };

            sDef.Differential.Element.Add(baseSDef.Differential.Element[0]);
        }

        public ElementDefinition Find(String path)
        {
            if (path.StartsWith(this.basePath) == false)
                path = $"{basePath}{path}";

            while (this.selectionIndex < this.baseSDef.Snapshot.Element.Count)
            {
                ElementDefinition e = this.baseSDef.Snapshot.Element[this.selectionIndex];
                if (e.Path == path)
                    return e;
                this.selectionIndex += 1;
            }
            throw new Exception($"'{path}' not found");
        }

        /// <summary>
        /// Select a element definition from the base sdef by its path name and 
        /// copy it to the differential of the output sdef.
        /// Selections must be called in order, meaning that is item # has been selected,
        /// attempts to select item #y (y < x) will fail.
        /// This is because the element definitions in the output diofferential must be ordered
        /// as they are in the base definition. Items can be missing, but can not be reordered.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public ElementDefinition Select(String path)
        {
            ElementDefinition e = this.Find(path);
            this.sDef.Differential.Element.Add(e);
            return e;
        }

        public void Write(String outputDir)
        {
            String outputName = $"StructureDefinition_{this.sDef.Name}";
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
