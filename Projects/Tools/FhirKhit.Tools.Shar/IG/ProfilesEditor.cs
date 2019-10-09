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
                profileName,
                profilePage,
                parentPage,
                parentName,
                text);
        }

        public void AddProfile(String profileName,
            String profilePage,
            String parentPage,
            String parentName,
            Markdown text)
        {
            AddItem(this.profileItemBlock,
                profileName,
                profilePage,
                parentPage,
                parentName,
                text);
        }

        public void AddItem(CodeBlockNested block,
            String profileName,
            String profilePage,
            String parentPage,
            String parentName,
            Markdown text)
        {
            block
                .AppendRaw("<tr>")
                .AppendRaw($"<td><a href=\"{profilePage}\">{profileName}</a></td>")
                .AppendRaw($"<td><a href=\"{parentPage}\">{parentName}</a></td>")
                .AppendRaw("<td>{% capture md_text %}")
                .AppendRaw(text.Value)
                .AppendRaw("{% endcapture %}{{ md_text | markdownify }}</td>")
                .AppendRaw("</tr>")
                ;
        }
    }
}
