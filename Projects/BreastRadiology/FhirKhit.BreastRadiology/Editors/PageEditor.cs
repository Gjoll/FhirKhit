using FhirKhit.Tools;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FhirKhit.BreastRadiology
{
    /// <summary>
    /// base class for editing .html pages.
    /// </summary>
    class PageEditor
    {
        String outputDir;
        String page(String s) => Path.Combine(this.outputDir, "pages", s);

        protected CodeEditor codeEditor;

        public PageEditor(String outputDir, string baseName)
        {
            this.outputDir = outputDir;
            this.codeEditor = new CodeEditor();
            this.codeEditor.Load(page($"{baseName}.template"));
            this.codeEditor.SavePath = page($"{baseName}");
        }

        public void Save()
        {
            this.codeEditor.Save();
        }
    }
}
