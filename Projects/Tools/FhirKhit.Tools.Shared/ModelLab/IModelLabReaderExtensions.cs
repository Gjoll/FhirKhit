using FhirKhit.Tools;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Xml;
using System.Net;
using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

#if FHIR_R4
namespace FhirKhit.Tools.R4
#elif FHIR_R3
namespace FhirKhit.Tools.R3
#elif FHIR_R2
namespace FhirKhit.Tools.R2
#endif
{
    /// <summary>
    /// Convert model lab files to modeldef files.
    /// 
    /// Todo:
    /// </summary>
    public static class IModelLabReaderExtensions
    {
        public static ModelSectionData PullModelSectionByGuid(this IModelLabReader rdr, Guid sectionGuid)
        {
            ConfigData data = rdr.PullSectionByGuid(sectionGuid);
            return new ModelSectionData(data);
        }

        public static ModelLabProject PullModelLabProjectByName(this IModelLabReader rdr, String projectName, out String projectPath)
        {
            ConfigData data = rdr.PullProjectByName(projectName, out projectPath);
            return ModelLabProject.Load(data);
        }

        public static ModelLabProject PullModelLabProjectByGuid(this IModelLabReader rdr, Guid projectGuid)
        {
            ConfigData data = rdr.PullProjectByGuid(projectGuid);
            return ModelLabProject.Load(data);
        }
    }
}
