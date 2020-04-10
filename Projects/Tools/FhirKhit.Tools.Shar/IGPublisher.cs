using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Eir.DevTools;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

#if FHIR_R4
namespace FhirKhit.Tools.R4
#elif FHIR_R3
namespace FhirKhit.Tools.R3
#endif
{
    public class IGPublisher : ConverterProcess
    {
        public bool Publish(String executingDir, String jarPath, String igPath)
        {
            executingDir = Path.GetDirectoryName(executingDir);
            executingDir = Path.GetFullPath(executingDir);
            StringBuilder args = new StringBuilder();
            args.Append($"-jar  \"{jarPath}\" ");
            args.Append($"-ig \"{igPath}\"");
            base.Execute(executingDir, "java", args.ToString());
            return this.HasErrors;
        }
    }
}
