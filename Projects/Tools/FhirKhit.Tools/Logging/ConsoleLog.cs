using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace FhirKhit.Tools
{
    public class ConsoleLog
    {
        private readonly Log.LogLevels logLevel;

        public static void SetLog(Log.LogLevels logLevel)
        {
            ConsoleLog log = new ConsoleLog(logLevel);
            Log.SetLog(log.LogMessage);
        }

        public ConsoleLog(Log.LogLevels logLevel)
        {
            this.logLevel = logLevel;
        }

        public void LogMessage(Log.LogLevels logLevel, String caller, String msg)
        {
            if ((this.logLevel & logLevel) == Log.LogLevels.None)
                return;

            switch (logLevel)
            {
                case Log.LogLevels.Error:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Error: [{caller}] {msg}");
                    break;

                case Log.LogLevels.Warn:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"Warn: [{caller}] {msg}");
                    break;

                case Log.LogLevels.Info:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Info: [{caller}] {msg}");
                    break;

                case Log.LogLevels.Trace:
                    Console.WriteLine($"Console: [{caller}] {msg}");
                    break;

                default:
                    throw new NotImplementedException("Unimplemented log level");
            }

            Console.ResetColor();
        }
    }
}
