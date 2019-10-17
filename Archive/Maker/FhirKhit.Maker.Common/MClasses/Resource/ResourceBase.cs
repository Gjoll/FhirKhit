using FhirKhit.Tools.R4;
using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.Maker.Common.Resource
{
    public abstract class ResourceBase : BaseType
    {
        public String Name { get; set; }
        public String Uri { get; set; }
        public ResourceBase Parent { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public String Purpose { get; set; }
        public String Publisher { get; set; }
        public Hl7.Fhir.Model.Date Date { get; set; } = new Hl7.Fhir.Model.Date(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

        public ResourceBase()
        {
            DateTime now = DateTime.Now;
            this.Date = new Hl7.Fhir.Model.Date(now.Year, now.Month, now.Day);
        }

        public void Write(String outputPath)
        {
            Hl7.Fhir.Model.StructureDefinition sDef = new Hl7.Fhir.Model.StructureDefinition
            {
                Description = new Hl7.Fhir.Model.Markdown(this.Description),
                Purpose = new Hl7.Fhir.Model.Markdown(this.Purpose),
                Name = this.Name,
                Url = this.Uri,
                Differential = new Hl7.Fhir.Model.StructureDefinition.DifferentialComponent(),
                Publisher = this.Publisher,
                FhirVersion = Hl7.Fhir.Model.FHIRVersion.N0_4_0,
                Kind = Hl7.Fhir.Model.StructureDefinition.StructureDefinitionKind.Resource,
                BaseDefinition = Parent.Uri,
                Abstract = false,
                Derivation = Hl7.Fhir.Model.StructureDefinition.TypeDerivationRule.Constraint,
                Title = this.Title
            };
            this.Write(sDef);
            sDef.SaveJson(outputPath);
        }
    }
}
