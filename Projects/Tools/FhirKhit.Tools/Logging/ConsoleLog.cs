using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace FhirKhit.Tools
{
    public class ConsoleLog
    {
        private readonly Log.LogLevel logLevel;

        public static void SetLog(Log.LogLevel logLevel)
        {
            ConsoleLog log = new ConsoleLog(logLevel);
            Log.SetLog(log.LogMessage);
        }

        public ConsoleLog(Log.LogLevel logLevel)
        {
            this.logLevel = logLevel;
        }

        public void LogMessage(Log.LogLevel logLevel, String caller, String msg)
        {
            if ((this.logLevel & logLevel) == Log.LogLevel.None)
                return;

            switch (logLevel)
            {
                case Log.LogLevel.Error:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Error: [{caller}] {msg}");
                    break;

                case Log.LogLevel.Warn:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"Warn: [{caller}] {msg}");
                    break;

                case Log.LogLevel.Info:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Info: [{caller}] {msg}");
                    break;

                case Log.LogLevel.Trace:
                    Console.WriteLine($"Console: [{caller}] {msg}");
                    break;

                default:
                    throw new NotImplementedException("Unimplemented log level");
            }

            Console.ResetColor();
        }
    }
}
