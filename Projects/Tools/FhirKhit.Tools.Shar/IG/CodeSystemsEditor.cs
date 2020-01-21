using FhirKhit.Tools;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

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
    public class CodeSystemsEditor : PageEditor
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
            if (text is null)
                throw new ArgumentNullException(nameof(text));

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
