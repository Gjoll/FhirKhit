using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.Maker.Common.Resource
{
    public class ResourceBase : MakerBaseType
    {
        public String Name {get; set; }
        public ResourceBase Parent {get; set; }
        public String Description {get; set; }
    }
}
