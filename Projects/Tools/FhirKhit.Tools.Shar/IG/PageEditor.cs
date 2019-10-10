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
    /// base class for editing .html pages.
    /// </summary>
    public class PageEditor
    {
        String outputDir;
        String page(String s) => Path.Combine(this.outputDir, "pages", s);

        protected CodeEditor codeEditor {get; set; }

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
