using FhirKhit.Tools;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FriendlyFhir.Maker
{
    class MakerProject
    {
        List<CodeEditor> codeEditors = new List<CodeEditor>();
        FileCleaner fileCleaner = new FileCleaner();

        public CodeEditor CreateEditor(String path)
        {
            CodeEditor retVal = new CodeEditor();
            retVal.SavePath = path;
            this.codeEditors.Add(retVal);
            return retVal;
        }

        public void CreateFileCleaner(String path)
        {
            if (Directory.Exists(path) == false)
                Directory.CreateDirectory(path);
            fileCleaner.Add(path);
        }

        public void Save()
        {
            foreach (CodeEditor c in this.codeEditors)
            {
                c.Save();
                this.fileCleaner.Mark(c.SavePath);
            }
            codeEditors.Clear();

            this.fileCleaner.Dispose();
        }
    }
}
