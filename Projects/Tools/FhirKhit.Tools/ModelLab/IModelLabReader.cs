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

namespace FhirKhit.Tools
{
    /// <summary>
    /// Convert model lab files to modeldef files.
    /// 
    /// Todo:
    /// </summary>
    public interface IModelLabReader
    {
        /// <summary>
        /// Pull indicated section.
        /// </summary>
        /// <param name="inputFile"></param>
        ConfigData PullSectionByGuid(Guid sectionGuid);

        ConfigData PullProjectByName(String projectName, out String projectPath);
        ConfigData PullProjectByGuid(Guid projectGuid);
    }
}
