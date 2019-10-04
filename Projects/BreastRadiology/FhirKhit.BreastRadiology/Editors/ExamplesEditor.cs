﻿using FhirKhit.Tools;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FhirKhit.BreastRadiology
{
    /// <summary>
    /// class for editing Profiles.html.
    /// profiles.html.template is the base template which is modified
    /// and saved as profiles.html.
    /// </summary>
    class ExamplesEditor : PageEditor
    {
        CodeBlockNested itemBlock;

        public ExamplesEditor(String outputDir) : base(outputDir, "examples.html")
        {
            itemBlock = this.codeEditor.Blocks.Find("*Items");
        }

        public void AddExample(String exampleName,
            String examplePage,
            String resourcePage,
            String resourceName,
            Markdown text)
        {
            itemBlock
                .AppendRaw("<tr>")
                .AppendRaw($"<td><a href=\"{examplePage}\">{exampleName}</a></td>")
                .AppendRaw($"<td><a href=\"{resourcePage}\">{resourceName}</a></td>")
                .AppendRaw("<td>{% capture md_text %}")
                .AppendRaw(text.Value)
                .AppendRaw("{% endcapture %}{{ md_text | markdownify }}</td>")
                .AppendRaw("</tr>")
                ;
        }
    }
}
