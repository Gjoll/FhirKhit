using FhirKhit.SliceGen;
using System;
using System.IO;

namespace FhirKhit.SliceGen.Share
{
    class Program
    {
        /// <summary>
        /// Output namespace
        /// </summary>
        String nameSpace = "Fhir.Profile.Generator";
        String outputDir = ".";
        SliceGenerator.OutputLanguageType outputLanguage = SliceGenerator.OutputLanguageType.CSharp;
        String inputFile = null;
        String inputDir = null;
        String inputMask = null;

        void Usage()
        {
            Console.WriteLine("usage: SliceGen [-n 'namespace'] [-o 'outputdir'] [-l 'outputLanguage'] [-i 'inputFile'] [-d 'inputDir' 'inputMask']");
            Console.WriteLine("where:");
            Console.WriteLine("    'namespace' is the namespace used in the generated class. Defaults to 'Fhir.Profile.Generator'");
            Console.WriteLine("    'outputdir' is the output director. Defaults to '.'");
            Console.WriteLine("    'outputLanguage' is the generated language. Currently only 'csharp'");
            Console.WriteLine("    'inputFile' is the name of the input profile");
            Console.WriteLine("    'inputDir' is the name of the diretory to operate on (all files in this dir matching inputMask are used as input");
            Console.WriteLine("    'inputMask' file mask to use for searching for files. i.e. '*.txt'");
        }

        String GetArg(String arg,
            String[] args,
            ref Int32 i)
        {
            i += 1;
            if (i >= args.Length)
            {
                this.Usage();
                throw new Exception($"Missing parameter to argument '{arg}'");
            }
            return args[i];
        }

        void ParseArgs(string[] args)
        {
            Int32 i = 0;
            while (i < args.Length)
            {
                String arg = args[i].Trim().ToLower();
                switch (arg)
                {
                    case "-n":
                        this.nameSpace = this.GetArg(arg, args, ref i);
                        break;

                    case "-o":
                        this.outputDir = this.GetArg(arg, args, ref i);
                        break;

                    case "-l":
                        this.outputLanguage = this.GetArg(arg, args, ref i).ToOutputLang();
                        break;

                    case "-i":
                        this.inputFile = this.GetArg(arg, args, ref i);
                        break;

                    case "-d":
                        this.inputDir = this.GetArg(arg, args, ref i);
                        this.inputMask = this.GetArg(arg, args, ref i);
                        break;

                    default:
                        this.Usage();
                        throw new Exception($"Unknown command line argument '{arg}'");
                }
                i += 1;
            }
        }

        void ProcessFile(String filePath)
        {
            if (File.Exists(filePath) == false)
                throw new Exception($"File {this.inputFile} does not exist");
            SliceGenerator p = new SliceGenerator(this.outputLanguage, this.nameSpace, this.outputDir);
            p.AddProfile(filePath);
            bool success = p.Process();
            if (success == false)
                throw new Exception($"SliceGenerator returned failure");
        }

        void RunInputFile()
        {
            if (String.IsNullOrEmpty(this.inputFile) == true)
                return;
            this.ProcessFile(this.inputFile);
        }

        void ProcessDir(String inputDir)
        {
            foreach (String inputFile in Directory.GetFiles(inputDir, this.inputMask))
                this.ProcessFile(inputFile);
            foreach (String subDir in Directory.GetDirectories(inputDir))
                this.ProcessFile(subDir);
        }

        void RunInputDir()
        {
            if (String.IsNullOrEmpty(this.inputDir) == true)
                return;
            if (String.IsNullOrEmpty(this.inputMask) == true)
                return;
            this.ProcessDir(this.inputDir);
        }

        public void Run()
        {
            this.RunInputFile();
            this.RunInputDir();
        }

        void Execute(string[] args)
        {
            this.ParseArgs(args);
            this.Run();
        }

        static Int32 Main(string[] args)
        {
            try
            {
                Program p = new Program();
                p.Execute(args);
                return 0;
            }
            catch (Exception err)
            {
                Console.WriteLine($"Error: {err.Message}");
                if (String.IsNullOrEmpty(err.StackTrace) == false)
                    Console.WriteLine($"{err.StackTrace}");
                return -1;
            }
        }
    }
}
