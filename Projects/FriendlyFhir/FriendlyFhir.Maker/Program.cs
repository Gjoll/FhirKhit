using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using System;
using System.IO;

namespace FriendlyFhir.Maker
{
    class Program
    {
        static Int32 Main(string[] args)
        {
            try
            {
                CodeEditor.DebugFlag = true;

                String outputDir = Path.Combine(DirHelper.FindParentDir("FriendlyFhir"), "FriendlyFhir.Maker.Generated");

                using (MakerGen maker = new MakerGen(outputDir))
                {
                    maker.StatusErrors += Dfg_StatusErrors;
                    maker.StatusInfo += Dfg_StatusInfo;
                    maker.StatusWarnings += Dfg_StatusWarnings;

                    Int32 retVal = maker.GenerateBaseClasses();
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
