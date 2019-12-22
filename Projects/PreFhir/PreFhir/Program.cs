using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using System;
using System.IO;
using System.Linq;

namespace PreFhir
{
    class Program
    {
        PreFhirGenerator preFhir;
        String output;
        void Usage()
        {
            Console.WriteLine("usage: -o 'outputdir' [-i inputfile]*");
            throw new Exception("Usage error");
        }

        String GetArg(String arg,
            String[] args,
            ref Int32 i)
        {
            i += 1;
            if (i >= args.Length)
                this.Usage();
            String retVal = args[i];
            if (retVal[0] == '"')
                retVal = retVal.Substring(1);
            if (retVal[retVal.Length - 1] == '"')
                retVal = retVal.Substring(0, retVal.Length - 1);
            return retVal;
        }

        void ParseArgs(string[] args)
        {
            Int32 i = 0;
            while (i < args.Length)
            {
                String arg = args[i].Trim().ToLower();
                switch (arg)
                {
                    case "":
                        break;

                    case "-d":
                        this.preFhir.DebugFlag = true;
                        break;

                    case "-o":
                        this.output = this.GetArg(arg, args, ref i);
                        break;

                    case "-i":
                        this.preFhir.AddFragment(this.GetArg(arg, args, ref i));
                        break;

                    default:
                        this.Usage();
                        break;
                }
                i += 1;
            }
        }

        Int32 Execute(string[] args)
        {
            try
            {
                if (String.IsNullOrEmpty(this.output) == true)
                    throw new Exception($"Output not set");

                this.preFhir = new PreFhirGenerator(null, ".");
                this.ParseArgs(args);
                String optionsFile = Path.Combine(DirHelper.FindParentDir("PreFhir"), "Options.txt");
                if (File.Exists(optionsFile))
                {
                    String optionsTxt = File.ReadAllText(optionsFile);
                    String[] optionsArr = optionsTxt.ToArgs();
                    this.ParseArgs(optionsArr);
                }
                this.preFhir.StatusErrors += this.Dfg_StatusErrors;
                this.preFhir.StatusInfo += this.Dfg_StatusInfo;
                this.preFhir.StatusWarnings += this.Dfg_StatusWarnings;

                if (this.preFhir.HasErrors == false)
                    this.preFhir.Process();

                if (this.preFhir.HasErrors)
                    throw new Exception($"Program failesd with {this.preFhir.Errors.Count()} errors");

                return 0;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return -1;
            }
        }
        private void Message(ConsoleColor color, string className, string method, string msg)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"{className}.{method}: {msg}");
            Console.ForegroundColor = ConsoleColor.Black;
        }
        private bool Dfg_StatusWarnings(string className, string method, string msg)
        {
            this.Message(ConsoleColor.Yellow, className, method, msg);
            return true;
        }
        private bool Dfg_StatusInfo(string className, string method, string msg)
        {
            this.Message(ConsoleColor.White, className, method, msg);
            return true;
        }
        private bool Dfg_StatusErrors(string className, string method, string msg)
        {
            this.Message(ConsoleColor.Red, className, method, msg);
            return true;
        }

        static Int32 Main(string[] args)
        {
            Program p = new Program();
            return p.Execute(args);
        }
    }
}
