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
        CodeEditorXml implementationGuide;
        CodeBlockNested groups;
        CodeBlockNested resources;

        public ImplementationGuideEditor(String templatePath)
        {
            this.implementationGuide = new CodeEditorXml();
            this.implementationGuide.Load(templatePath);
            this.groups = this.implementationGuide.Blocks.Find("*Groups");
            this.resources = this.implementationGuide.Blocks.Find("*Resources");
        }

        public void AddGrouping(String groupId, String name, String description)
        {
            this.groups
                .AppendLine($"<grouping id=\"{groupId}\">")
                .AppendLine($"  <name value=\"{name}\" />")
                .AppendLine($"  <description value=\"{description}\" />")
                .AppendLine($"</grouping>")
                ;
        }

        public void AddIGResource(String path,
            String name,
            String description,
            String groupId,
            bool example)
        {
            this.resources
                .AppendLine($"<resource>")
                .AppendLine($"  <reference>")
                .AppendLine($"    <reference value=\"{path}\" />")
                .AppendLine($"  </reference>")
                .AppendLine($"  <name value=\"{name}\" />")
                .AppendLine($"  <description value=\"{description}\" />")
                .AppendLine($"  <exampleBoolean value=\"{example}\" />")
                .AppendLine($"  <groupingId value=\"{groupId}\" />")
                .AppendLine($"</resource>")
                ;
        }

        public void Save(String path)
        {
            implementationGuide.Save(path);
        }
    }
}
