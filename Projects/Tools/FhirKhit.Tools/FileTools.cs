using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace FhirKhit.Tools
{
    public static class FileTools
    {
        public static void WriteAllText(String path, String text)
        {
            for (Int32 i = 0; i < 5; i++)
            {
                try
                {
                    File.WriteAllText(path, text);
                    return;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Thread.Sleep(100);
                }
            }
            throw new Exception("File write failed");
        }
    }
}
