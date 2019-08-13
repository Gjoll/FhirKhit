using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace FhirKhit.Tools
{
    public class TraceLog
    {
        private readonly Log.LogLevel logLevel;

        public static void SetLog(Log.LogLevel logLevel)
        {
            TraceLog log = new TraceLog(logLevel);
            Log.SetLog(log.LogMessage);
        }

        public TraceLog(Log.LogLevel logLevel)
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
                    Trace.WriteLine($"Error: [{caller}] {msg}");
                    break;

                case Log.LogLevel.Warn:
                    Trace.WriteLine($"Warn: [{caller}] {msg}");
                    break;

                case Log.LogLevel.Info:
                    Trace.WriteLine($"Info: [{caller}] {msg}");
                    break;

                case Log.LogLevel.Trace:
                    Trace.WriteLine($"Trace: [{caller}] {msg}");
                    break;

                default:
                    throw new NotImplementedException("Unimplemented log level");
            }
        }
    }
}
