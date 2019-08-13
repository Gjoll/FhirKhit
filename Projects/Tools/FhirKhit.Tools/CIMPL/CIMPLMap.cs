using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace FhirKhit.Tools
{
    /// <summary>
    /// Mapping ElementDefinition from ModelDef to Fhir Profile
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, IsReference = false)]
    public class CIMPLMap
    {
        public class Arg
        {
            [JsonProperty("Name")] public String Name { get; set; }
            [JsonProperty("Values")] public String[] Values { get; set; }
        }

        CIMPLMapProcessor MapProcessor = new CIMPLMapProcessor();
        [JsonProperty("Target")] public String Target { get; set; }
        [JsonProperty("Arguments")] public Arg[] Arguments { get; set; }
        [JsonProperty("Commands")] public Arg[] Commands { get; set; }

        public CIMPLMap(String target,
            IEnumerable<Arg> arguments,
            IEnumerable<Arg> commands)
        {
            this.Target = target;
            this.Arguments = arguments.ToArray();
            this.Commands = commands.ToArray();
        }

        public CIMPLMap()
        {
        }

        public bool TryFindArgument(String name, out String[] values)
        {
            foreach (var arg in this.Arguments)
            {
                if (arg.Name == name)
                {
                    values = arg.Values;
                    return true;
                }
            }

            values = null;
            return false;
        }
    }
}
