using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.Tools
{
    public class CIMPLCompiler : ConverterProcess
    {
        String NodePath => "node";

        void Msg(String msg)
        {
            if (msg.StartsWith("mappingRule"))
            {
                this.ConversionInfo(this.GetType().Name, "", msg);
                return;
            }

            Int32 i = msg.IndexOf(']');
            if (i < 0)
            {
                this.ConversionInfo(this.GetType().Name, "INFO", msg);
                return;
            }

            String m = msg.Substring(i+1).Trim();
            if (m.StartsWith("ERR"))
            {
                this.ConversionError(this.GetType().Name, "", msg);
                return;
            }

            if (m.StartsWith("WARN"))
            {
                this.ConversionWarn(this.GetType().Name, "", msg);
                return;
            }

            if (m.StartsWith("INFO"))
            {
                this.ConversionInfo(this.GetType().Name, "", msg);
                return;
            }

            this.ConversionInfo(this.GetType().Name, "INFO", msg);
        }

        override protected void AddInfo(String msg)
        {
            Msg(msg);
        }

        override protected void AddError(String msg)
        {
            Msg(msg);
        }

        public bool Compile(String outputDir, String cimpleDir, String shrCliDir, String nodeDir = null)
        {
            bool retVal = base.Execute(outputDir,
                NodePath,
                $"{shrCliDir} {cimpleDir}");
            if (this.HasErrors)
                retVal = false;
            return retVal;
        }
    }
}
