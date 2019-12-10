using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FhirKhit.Tools.R4
{
    /// <summary>
    /// Edit implementation guide.
    /// Note: This will try to maintain oprder and other info on currently existing resoruces.
    /// </summary>
    public class ImplementationGuideEditor
    {
        ImplementationGuide implementationGuide;

        public ImplementationGuideEditor(String templatePath)
        {
            String xmlText = File.ReadAllText(templatePath);
            FhirXmlParser parser = new FhirXmlParser();
            this.implementationGuide = (ImplementationGuide)parser.Parse(xmlText, typeof(Resource));
        }

        public void AddGrouping(String groupId, String name, String description)
        {
            ImplementationGuide.GroupingComponent item = new ImplementationGuide.GroupingComponent
            {
                ElementId = groupId,
                Name = name,
                Description = description,
            };
            this.implementationGuide.Definition.Grouping.Add(item);
        }

        public void AddIGResource(String path,
            String name,
            String description,
            String groupId,
            bool example)
        {
            ImplementationGuide.ResourceComponent item = new ImplementationGuide.ResourceComponent
            {
                Name = name,
                Reference = new ResourceReference(path),
                Description = description,
                Example = new FhirBoolean(example),
                GroupingId = groupId
            };
            this.implementationGuide.Definition.Resource.Add(item);
        }

        public void Save(String path)
        {
            implementationGuide.SaveXml(path);
        }
    }
}
