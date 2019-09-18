using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.Tools
{
    public class ConvertErrorException : Exception
    {
        public String FileName;
        public String MethodName;

        public ConvertErrorException(String fileName, String methodName, String message) : base(message)
        {
            this.FileName = fileName;
            this.MethodName = methodName;
        }
    }
}
