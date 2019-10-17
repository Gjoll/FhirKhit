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
#elif FHIR_R2
namespace FhirKhit.Tools.R2
#endif
{
    /// <summary>
    /// class for editing Profiles.html.
    /// profiles.html.template is the base template which is modified
    /// and saved as profiles.html.
    /// </summary>
    public class ValueSetsEditor : PageEditor
    {
        CodeBlockNested itemBlock;
        CodeBlockNested externalItemBlock;

        public ValueSetsEditor(String outputDir) : base(outputDir, "valuesets.html")
        {
            itemBlock = this.codeEditor.Blocks.Find("*Items");
            externalItemBlock = this.codeEditor.Blocks.Find("*ExternalItems");
        }

        public void AddExternalValueSet(String valueSetName,
            String valueSetPage,
            Markdown text)
        {
            if (text is null)
                throw new ArgumentNullException(nameof(text));
            this.externalItemBlock
                .AppendRaw("<tr>")
                .AppendRaw($"<td><a href=\"{valueSetPage}\">{valueSetName}</a></td>")
                .AppendRaw("<td>{% capture md_text %}")
                .AppendRaw(text.Value)
                .AppendRaw("{% endcapture %}{{ md_text | markdownify }}</td>")
                .AppendRaw("</tr>")
                ;
        }

        public void AddValueSet(String valueSetName,
            String valueSetPage,
            Markdown text)
        {
            if (text is null)
                throw new ArgumentNullException(nameof(text));
            this.itemBlock
                .AppendRaw("<tr>")
                .AppendRaw($"<td><a href=\"{valueSetPage}\">{valueSetName}</a></td>")
                .AppendRaw("<td>{% capture md_text %}")
                .AppendRaw(text.Value)
                .AppendRaw("{% endcapture %}{{ md_text | markdownify }}</td>")
                .AppendRaw("</tr>")
                ;
        }
    }
}
