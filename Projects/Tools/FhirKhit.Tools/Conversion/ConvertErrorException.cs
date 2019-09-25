using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.Tools
{
    public class ConvertErrorException : Exception
    {
        public String FileName { get; }
        public String MethodName { get; }

        public ConvertErrorException(String fileName, String methodName, String message) : base(message)
        {
            this.FileName = fileName;
            this.MethodName = methodName;
        }

        public ConvertErrorException()
        {
        }

        public ConvertErrorException(string message) : base(message)
        {
        }

        public ConvertErrorException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
