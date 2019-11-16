using FhirKhit.Tools;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace PreFhir.XUnitTests
{
    class Info : IConversionInfo
    {
        void Msg(String import, string className, string method, string msg)
        {
            Trace.WriteLine($"{import} [{className}.{method}] '{msg}'");
        }

        public void ConversionError(string className, string method, string msg) => Msg("Err", className, method, msg);

        public void ConversionInfo(string className, string method, string msg) => Msg("Info", className, method, msg);

        public void ConversionWarn(string className, string method, string msg) => Msg("Warn", className, method, msg);
    }
}
