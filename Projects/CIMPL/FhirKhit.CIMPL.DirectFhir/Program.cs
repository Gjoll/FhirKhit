using System;

namespace FhirKhit.CIMPL.DirectFhir
{
    class Program
    {
        static DirectFhirGenerator dfg;
        static string outputDir;
        static bool createBundle;

        static String GetArgs(string[] args, ref Int32 i, String errorMsg)
        {
            if (i >= args.Length)
                throw new Exception(errorMsg);
            return args[i++];
        }

        static void ParseArgs(string[] args)
        {
            Int32 i = 0;
            while (i < args.Length)
            {
                String arg = args[i++];
                switch (arg.Trim().ToLower())
                {
                    case "-o":
                        outputDir = GetArgs(args, ref i, "Missing argument to -o parameter");
                        break;

                    case "-b":
                        createBundle = true;
                        break;

                    case "-p":
                    case "-path":
                        dfg.AddPathToProcess(GetArgs(args, ref i, "Missing argument to -path parameter"));
                        break;

                    default:
                        throw new Exception("Unknown command line argument {arg}");
                }
            }

            if (String.IsNullOrEmpty(outputDir))
                throw new Exception($"Missing required -o argument");
        }
        static Int32 Main(string[] args)
        {
            try
            {
                dfg = new DirectFhirGenerator();
                dfg.StatusErrors += Dfg_StatusErrors;
                dfg.StatusInfo += Dfg_StatusInfo;
                dfg.StatusWarnings += Dfg_StatusWarnings;

                ParseArgs(args);
                if (createBundle == true)
                    dfg.CreateBundle();
                return dfg.GenerateBaseClasses(outputDir);
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
