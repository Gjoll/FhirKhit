using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace FhirKhit.Tools
{
    public class TraceLog
    {
        private readonly Log.LogLevels logLevel;

        public static void SetLog(Log.LogLevels logLevel)
        {
            TraceLog log = new TraceLog(logLevel);
            Log.SetLog(log.LogMessage);
        }

        public TraceLog(Log.LogLevels logLevel)
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
                    Trace.WriteLine($"Error: [{caller}] {msg}");
                    break;

                case Log.LogLevels.Warn:
                    Trace.WriteLine($"Warn: [{caller}] {msg}");
                    break;

                case Log.LogLevels.Info:
                    Trace.WriteLine($"Info: [{caller}] {msg}");
                    break;

                case Log.LogLevels.Trace:
                    Trace.WriteLine($"Trace: [{caller}] {msg}");
                    break;

                default:
                    throw new NotImplementedException("Unimplemented log level");
            }
        }
    }
}
