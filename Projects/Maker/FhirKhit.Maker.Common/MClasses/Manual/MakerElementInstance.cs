using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.Maker.Common
{
    public class MakerElementInstance
    {
        public String Name {get; set;}
        HashSet<MakerBase_Type> types = new HashSet<MakerBase_Type>();
        public Int32 Min {get; set; }
        public Int32 Max {get; set; }

        public MakerBase_Type[] Types {get; set; }

        public void AddType(MakerBase_Type type)
        {
            types.Add(type);
        }
    }
}
