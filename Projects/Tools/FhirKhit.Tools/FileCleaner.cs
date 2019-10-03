using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace FhirKhit.Tools
{
    /// <summary>
    /// Deletes un-marked files when saving goups of files.
    /// </summary>
    public sealed class FileCleaner : IDisposable
    {
        readonly HashSet<String> existingFiles = new HashSet<String>();

        public FileCleaner()
        {
        }

        public FileCleaner(String outputDir, String fileFilter = "*.*")
        {
            this.Add(outputDir, fileFilter);
        }

        public void Add(String outputDir, String fileFilter = "*.*")
        {
            if (Directory.Exists(outputDir) == true)
            {
                foreach (String existingFile in Directory.GetFiles(outputDir, fileFilter))
                    this.existingFiles.Add(existingFile);
            }
        }

        public void Mark(String filePath) => this.existingFiles.Remove(filePath);

        public void Dispose()
        {
            foreach (String existingFile in this.existingFiles)
            {
                this.TryDeleteFile(existingFile);
            }
        }

        void TryDeleteFile(String fileName)
        {
            for (Int32 i = 0; i < 5; i++)
            {
                try
                {
                    File.Delete(fileName);
                    return;
                }
                catch
                {
                    Thread.Sleep(100);
                }
            }
            throw new Exception($"Cant delete file {fileName}");
        }
    }
}
