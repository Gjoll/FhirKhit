using FhirKhit.Tools;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Eir.DevTools;

#if FHIR_R4
namespace FhirKhit.Tools.R4
#elif FHIR_R3
namespace FhirKhit.Tools.R3
#endif
{
    /// <summary>
    /// class for editing Profiles.html.
    /// profiles.html.template is the base template which is modified
    /// and saved as profiles.html.
    /// </summary>
    public class ExamplesEditor : PageEditor
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
            if (text is null)
                throw new ArgumentNullException(nameof(text));

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
