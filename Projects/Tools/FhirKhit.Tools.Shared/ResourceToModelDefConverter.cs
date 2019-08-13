using System;
using System.Collections.Generic;
using System.Linq;
using Hl7.Fhir.Model;


#if FHIR_R4
namespace FhirKhit.Tools.R4
#elif FHIR_R3
namespace FhirKhit.Tools.R3
#elif FHIR_R2
namespace FhirKhit.Tools.R2
#endif
{
    /// <summary>
    /// Converts a FHIR resource into a model def, performing various transformations along the way.
    /// This is mainly a tool used to create modeldefs at development time.
    /// This does not create a profile of the source resource, but a mock of it with the
    /// commanded field modifications (see ZeroCardinality, etc).
    /// It has map commands to map these fields to the Observation fields and override them.
    /// </summary>
    public class ResourceToModelDefConverter
    {
        public const String BaseUrl = GlobalDefs.BaseModelDefUrl + "/ModelDefinitionBase";
        protected readonly HashSet<String> ignoreFields = new HashSet<String>();

        protected StructureDefinition sourceResource;
        public StructureDefinition ModelDef;

        /// <summary>
        /// Find target element that matches source element. if not found, create one 
        /// </summary>
        /// <param name="sourceELement"></param>
        /// <returns></returns>
        protected ElementDefinition GetTargetElementDef(ElementDefinition sourceElement)
        {
            ElementDefinition targetElement = this.ModelDef.Differential.Element.FindByPath(sourceElement.Path);
            if (targetElement != null)
                return targetElement;

            targetElement = new ElementDefinition
            {
                Path = sourceElement.Path,
                ElementId = sourceElement.ElementId,
            };
            this.ModelDef.Differential.Element.Add(targetElement);
            return targetElement;
        }

        public void ZeroCardinality(string filter)
        {
            ElementDefinitionMatch m = new ElementDefinitionMatch(filter);
            foreach (ElementDefinition e in this.sourceResource.Differential.Element.TopLevelElements())
            {
                if (m.IsAMatch(e, e))
                    this.ZeroCardinality(e);
            }
        }

        public void ZeroCardinalityAll()
        {
            foreach (ElementDefinition e in this.sourceResource.Differential.Element.TopLevelElements())
                this.ZeroCardinality(e);
        }

        void ZeroCardinality(ElementDefinition e)
        {
            String name = e.Path.LastPathPart();
            if (this.ignoreFields.Contains(name))
                return;

            if (e.Min != 0)
                return;
            if (e.Max == "0")
                return;

            ElementDefinition target = this.GetTargetElementDef(e);
            target.Min = 0;
            target.Max = "0";
            target.Short = e.Short;
#if FHIR_R4
            target.Comment = new Markdown("Element is unused");
#elif FHIR_R3
            target.Comment = "Element is unused";
#elif FHIR_R2
            target.Definition = "Element is unused";
#endif
        }

        /// <summary>
        /// Add ModelDef mapping commands to map these fields to the parent Observation fields.
        /// </summary>
        public void Map()
        {
            foreach (ElementDefinition e in this.ModelDef.Differential.Element)
            {
                e.SetMap(new ElementDefinitionMap(
                    new ElementDefinitionMatch("target.path == target.path[0] '.' source.path[1...]"),
                    "Overwrite();", "", "", "")
                );
            }

        }

        public void Ignore(params String[] ignoreFields)
        {
            foreach (String ignoreField in ignoreFields)
                this.ignoreFields.Add(ignoreField);
        }

        /// <summary>
        /// Perform conversion
        /// </summary>
        protected void LoadLocal(String fhirResourceUri)
        {
#if FHIR_R4
            this.ModelDef.BaseDefinition = fhirResourceUri;
#elif FHIR_R3
            this.ModelDef.BaseDefinition = fhirResourceUri;
#elif FHIR_R2
            this.ModelDef.Base = fhirResourceUri;
#endif
        }

        public void SetType(String type)
        {
#if FHIR_R4
            this.ModelDef.Type = type;
#elif FHIR_R3
            this.ModelDef.Type = type;
#elif FHIR_R2
#endif
        }

        /// <summary>
        /// Perform conversion
        /// </summary>
        public void Load(String fhirResourceUri)
        {
            this.sourceResource = (StructureDefinition)ZipFhirSource.Source.ResolveByUri(fhirResourceUri);
            if (this.sourceResource == null)
                throw new Exception($"Fhir Resource {fhirResourceUri} not found");
            //this.sourceResource.SaveJson(@"c:\Temp\Source.json");
            String resourceName = fhirResourceUri.ResourceNameFromUri();
            this.ModelDef = new StructureDefinition
            {
                Id = this.sourceResource.Id,
                Abstract = this.sourceResource.Abstract,
                Description = this.sourceResource.Description,
                Differential = new StructureDefinition.DifferentialComponent(),
                Kind = this.sourceResource.Kind,
                Meta = this.sourceResource.Meta,
                Name = this.sourceResource.Name,
                Status = this.sourceResource.Status,
                //Text = this.sourceResource.Text,
                Url = $"{BaseUrl}/{resourceName}",
                Version = this.sourceResource.Version,
#if FHIR_R4
                BaseDefinition = fhirResourceUri
#elif FHIR_R3
                BaseDefinition = fhirResourceUri
#elif FHIR_R2
                Base = fhirResourceUri
#endif
            };

            this.ModelDef.Differential.Element.Add(this.sourceResource.Differential.Element[0]);
        }

        public void Save(String path) => this.ModelDef.SaveJson(path);
    }
}
