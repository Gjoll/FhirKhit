using System;

namespace FhirKhit.CIMPL.DirectFhir
{
    class Program
    {
        static DirectFhirGenerator dfg;

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
                        dfg.OutputDir = GetArgs(args, ref i, "Missing argument to -o parameter");
                        break;

                    case "-b":
                        dfg.CreateBundle();
                        break;

                    case "-s":
                    case "-spliceable":
                        dfg.AddSpliceField(GetArgs(args, ref i, "Missing argument to -s parameter"));
                        break;

                    case "-r":
                    case "-resource":
                        dfg.AddResourcePathToProcess(GetArgs(args, ref i, "Missing argument to -resource parameter"), false);
                        break;

                    default:
                        throw new Exception("Unknown command line argument {arg}");
                }
            }
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
                if (String.IsNullOrEmpty(dfg.OutputDir))
                    throw new Exception($"Missing required -o command line argument");
                return dfg.GenerateBaseClasses();
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
