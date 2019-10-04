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
    class ProfilesEditor
    {
        String outputDir;
        String page(String s) => Path.Combine(this.outputDir, "pages", s);

        CodeEditor profilesEditor;
        CodeBlockNested profileItemBlock;
        CodeBlockNested basedOnItemBlock;


        public ProfilesEditor(String outputDir)
        {
            this.outputDir = outputDir;
            this.profilesEditor = new CodeEditor();
            this.profilesEditor.Load(page("profiles.html.template"));
            this.profilesEditor.SavePath = page("profiles.html");

            profileItemBlock = this.profilesEditor.Blocks.Find("*ProfileItems");
            basedOnItemBlock = this.profilesEditor.Blocks.Find("*BasedOnItems");
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

        public void Save()
        {
            this.profilesEditor.Save();
        }
    }
}
