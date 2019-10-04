using FhirKhit.Tools;
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
    class CodeSystemsEditor : PageEditor
    {
        CodeBlockNested itemBlock;


        public CodeSystemsEditor(String outputDir) : base(outputDir, "codesystems.html")
        {
            itemBlock = this.codeEditor.Blocks.Find("*Items");
        }

        public void AddCodeSystem(String codeSystemName,
            String codeSystemPage,
            Markdown text)
        {
            this.itemBlock
                .AppendRaw("<tr>")
                .AppendRaw($"<td><a href=\"{codeSystemPage}\">{codeSystemName}</a></td>")
                .AppendRaw("<td>{% capture md_text %}")
                .AppendRaw(text.Value)
                .AppendRaw("{% endcapture %}{{ md_text | markdownify }}</td>")
                .AppendRaw("</tr>")
                ;
        }
    }
}
