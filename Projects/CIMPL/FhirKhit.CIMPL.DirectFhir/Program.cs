using FhirKhit.Tools;
using System;
using System.IO;

namespace FhirKhit.CIMPL.DirectFhir
{
    class Program
    {
        static DirectFhirGenerator dfg;

        static void ParseArgs(string args)
        {
            String GetArg(String s)
            {
                s = s.Trim();
                if (s.StartsWith("\""))
                    s = s.Substring(1);
                if (s.EndsWith("\""))
                    s = s.Substring(0, s.Length - 1);
                return s;
            }
 
            while (args.Contains("  "))
                args = args.Replace("  ", " ");

            CodeEditor.DebugFlag = false;

            String[] argLines = args.ToLines();

            foreach (String line in argLines)
            {
                if (String.IsNullOrWhiteSpace(line) == false)
                {
                    String[] lineParts = line.Split(' ');
                    switch (lineParts[0].ToLower())
                    {
                        case "-o":
                            if (lineParts.Length != 2)
                                throw new Exception($"Invalid arg '{line}'");
                            dfg.OutputDir = GetArg(lineParts[1]);
                            break;

                        case "-d":
                            CodeEditor.DebugFlag = true;
                            break;

                        case "-b":
                            dfg.CreateBundle();
                            break;

                        case "-i":
                            if (lineParts.Length != 2)
                                throw new Exception($"Invalid arg '{line}'");
                            dfg.AddResourcePathToIgnore(GetArg(lineParts[1]));
                            break;

                        case "-m":
                        case "-map":
                            if (lineParts.Length != 3)
                                throw new Exception($"Invalid arg '{line}'");
                            dfg.AddFieldMap(GetArg(lineParts[1]), GetArg(lineParts[2]));
                            break;

                        case "-s":
                        case "-spliceable":
                            if (lineParts.Length != 2)
                                throw new Exception($"Invalid arg '{line}'");
                            dfg.AddSpliceField(GetArg(lineParts[1]));
                            break;

                        case "-a":
                        case "-abbreviated":
                            if (lineParts.Length != 2)
                                throw new Exception($"Invalid arg '{line}'");
                            dfg.AddAbbreviatedResource(GetArg(lineParts[1]));
                            break;

                        case "-r":
                        case "-resource":
                            if (lineParts.Length != 2)
                                throw new Exception($"Invalid arg '{line}'");
                            dfg.AddResource(GetArg(lineParts[1]));
                            break;

                        default:
                            throw new Exception("Unknown command line argument {arg}");
                    }
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

                if (args.Length != 1)
                    throw new Exception($"Expected single command line arg");
                ParseArgs(File.ReadAllText(args[0]));
                if (String.IsNullOrEmpty(dfg.OutputDir))
                    throw new Exception($"Missing required -o command line argument");
                Int32 retVal = dfg.GenerateBaseClasses();
                return retVal;
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
