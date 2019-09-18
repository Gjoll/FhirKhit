﻿using System;

namespace FhirKhit.CIMPL.DirectFhir
{
    class Program
    {
        static string outputDir;

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
                ParseArgs(args);
                DirectFhirGenerator dfg = new DirectFhirGenerator();
                return dfg.GenerateBaseClasses(outputDir);
            }
            catch(Exception err)
            {
                Console.WriteLine(err.Message);
                return -1;
            }
        }
    }
}
