using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FhirKhit.BreastRadiology
{
    /// <summary>
    /// Edit implementation guide.
    /// Note: This will try to maintain oprder and other info on currently existing resoruces.
    /// </summary>
    class ImplementationGuideEditor
    {
        ImplementationGuide implementationGuide;
        Dictionary<String, Modified<ImplementationGuide.ResourceComponent>> resources = new Dictionary<String, Modified<ImplementationGuide.ResourceComponent>>();

        public ImplementationGuideEditor(String templatePath)
        {
            String xmlText = File.ReadAllText(templatePath);
            FhirXmlParser parser = new FhirXmlParser();
            this.implementationGuide = (ImplementationGuide)parser.Parse(xmlText, typeof(Resource));
            foreach (ImplementationGuide.ResourceComponent item in this.implementationGuide.Definition.Resource)
                this.resources.Add(item.Name, new Modified<ImplementationGuide.ResourceComponent>(item));
        }

        public void AddIGResource(String path,
            String name,
            bool example)
        {
            if (this.resources.TryGetValue(name, out Modified<ImplementationGuide.ResourceComponent> modified) == false)
            {
                ImplementationGuide.ResourceComponent item = new ImplementationGuide.ResourceComponent
                {
                    Name = name
                };
                modified = new Modified<ImplementationGuide.ResourceComponent>(item);
                this.resources.Add(item.Name, modified);
                this.implementationGuide.Definition.Resource.Add(item);
            }

            modified.Item.Reference = new ResourceReference(path);
            modified.Item.Name = name;
            modified.Item.Example = new FhirBoolean(example);
            modified.ModifiedFlag = true;
        }

        public void Save(String path)
        {
            // Remove those resource that have not been modified.
            foreach (Modified<ImplementationGuide.ResourceComponent> modified in resources.Values)
            {
                if (modified.ModifiedFlag == false)
                    this.implementationGuide.Definition.Resource.Remove(modified.Item);

            }
            implementationGuide.SaveXml(path);
        }
    }
}
