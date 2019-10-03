using FhirKhit.Tools;
using System;
using System.IO;

namespace FhirKhit.Maker
{
    class Program
    {
        static Int32 Main(string[] args)
        {
            try
            {
                CodeEditor.DebugFlag = true;

                String outputDir = Path.Combine(DirHelper.FindParentDir("Maker"), "FhirKhit.Maker.Common", "MClasses");

                using (MakerGen dfg = new MakerGen(outputDir))
                {
                    dfg.StatusErrors += Dfg_StatusErrors;
                    dfg.StatusInfo += Dfg_StatusInfo;
                    dfg.StatusWarnings += Dfg_StatusWarnings;

                    Int32 retVal = dfg.GenerateBaseClasses(outputDir);
                    return retVal;
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return -1;
            }
        }

        private static void Message(ConsoleColor color, string className, string method, string msg)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"{className}.{method}: {msg}");
            Console.ForegroundColor = ConsoleColor.Black;
        }
        private static bool Dfg_StatusWarnings(string className, string method, string msg)
        {
            Message(ConsoleColor.Yellow, className, method, msg);
            return true;
        }
        private static bool Dfg_StatusInfo(string className, string method, string msg)
        {
            Message(ConsoleColor.White, className, method, msg);
            return true;
        }
        private static bool Dfg_StatusErrors(string className, string method, string msg)
        {
            Message(ConsoleColor.Red, className, method, msg);
            return true;
        }
    }
}
