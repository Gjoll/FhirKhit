using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace FhirKhit.Tools
{
    public static class Log
    {
        [Flags]
        public enum LogLevel
        {
            None = 0,
            Error = 1,
            Warn = 2,
            Info = 4,
            Trace = 8,

            ErrorAndAbove = LogLevel.Error,
            WarnAndAbove = LogLevel.Error | LogLevel.Warn,
            InfoAndAbove = LogLevel.Error | LogLevel.Warn | LogLevel.Info,
            TraceAndAbove = LogLevel.Error | LogLevel.Warn | LogLevel.Info | LogLevel.Trace
        }
        public delegate void LogMessageDelegate(LogLevel logLevel, String caller, String message);

        public static event LogMessageDelegate LogEvent;

        public static void SetLog(LogMessageDelegate logger) => Log.LogEvent += logger;

        public static void Error(String caller, String msg)
        {
            if (Log.LogEvent == null)
                return;
            Log.LogEvent(LogLevel.Error, caller, msg);
        }

        public static void Warn(String caller, String msg)
        {
            if (Log.LogEvent == null)
                return;
            Log.LogEvent(LogLevel.Warn, caller, msg);
        }

        public static void Info(String caller, String msg)
        {
            if (Log.LogEvent == null)
                return;
            Log.LogEvent(LogLevel.Info, caller, msg);
        }

        public static void Trace(String caller, String msg)
        {
            if (Log.LogEvent == null)
                return;
            Log.LogEvent(LogLevel.Trace, caller, msg);
        }

    }
}
