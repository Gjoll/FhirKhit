using FhirKhit.Tools;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;


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
    public class ProfilesEditor : PageEditor
    {
        CodeBlockNested profileItemBlock;
        CodeBlockNested basedOnItemBlock;

        public ProfilesEditor(String outputDir) : base(outputDir, "profiles.html")
        {
            profileItemBlock = this.codeEditor.Blocks.Find("*ProfileItems");
            basedOnItemBlock = this.codeEditor.Blocks.Find("*BasedOnItems");
        }

        public void AddBasedOn(String profileName,
            String profilePage,
            String parentPage,
            String parentName,
            Markdown text)
        {
            AddItem(this.basedOnItemBlock,
                new Tuple<String, String>[]
                {
                    new Tuple<String, String>(profileName, profilePage),
                    new Tuple<String, String>(parentName, parentPage)
                },
                text);
        }

        public void AddFragment(IEnumerable<Tuple<String, String>> references,
            Markdown text)
        {
            AddItem(this.profileItemBlock, references, text);
        }

        public void AddProfile(String profileName,
            String profilePage,
            String parentPage,
            String parentName,
            Markdown text)
        {
            AddItem(this.profileItemBlock,
                new Tuple<String, String>[]
                {
                    new Tuple<String, String>(profileName, profilePage),
                    new Tuple<String, String>(parentName, parentPage)
                },
                text);
        }

        public void AddItem(CodeBlockNested block,
            IEnumerable<Tuple<String, String>> references,
            Markdown text)
        {
            if ((text is null) && (references.Any() == false))
                return ;

            if (text == null)
            text = new Markdown("");
            block.AppendRaw("<tr>");

            foreach (Tuple<String, String> reference in references)
            {
                String referenceName = reference.Item1;
                String referencePage = reference.Item2;
                block.AppendRaw($"<td><a href=\"{referencePage}\">{referenceName}</a></td>");
            }
            block
            .AppendRaw("<td>{% capture md_text %}")
            .AppendRaw(text.Value)
            .AppendRaw("{% endcapture %}{{ md_text | markdownify }}</td>")
            .AppendRaw("</tr>")
            ;
        }
    }
}
