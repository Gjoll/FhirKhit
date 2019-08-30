using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace FhirKhit.Tools
{
    public static class Log
    {
        [Flags]
        public enum LogLevels
        {
            None = 0,
            Error = 1,
            Warn = 2,
            Info = 4,
            Trace = 8,

            ErrorAndAbove = LogLevels.Error,
            WarnAndAbove = LogLevels.Error | LogLevels.Warn,
            InfoAndAbove = LogLevels.Error | LogLevels.Warn | LogLevels.Info,
            TraceAndAbove = LogLevels.Error | LogLevels.Warn | LogLevels.Info | LogLevels.Trace
        }
        public delegate void LogMessageDelegate(LogLevels logLevel, String caller, String message);

        public static event LogMessageDelegate LogEvent;

        public static void SetLog(LogMessageDelegate logger) => Log.LogEvent += logger;

        public static void Error(String caller, String msg)
        {
            if (Log.LogEvent == null)
                return;
            Log.LogEvent(LogLevels.Error, caller, msg);
        }

        public static void Warn(String caller, String msg)
        {
            if (Log.LogEvent == null)
                return;
            Log.LogEvent(LogLevels.Warn, caller, msg);
        }

        public static void Info(String caller, String msg)
        {
            if (Log.LogEvent == null)
                return;
            Log.LogEvent(LogLevels.Info, caller, msg);
        }

        public static void Trace(String caller, String msg)
        {
            if (Log.LogEvent == null)
                return;
            Log.LogEvent(LogLevels.Trace, caller, msg);
        }

    }
}
