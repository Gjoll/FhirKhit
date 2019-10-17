using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.Tools
{
    public interface IConversionInfo
    {
        void ConversionError(String className, String method, String msg);
        void ConversionWarn(String className, String method, String msg);
        void ConversionInfo(String className, String method, String msg);
    }
}
