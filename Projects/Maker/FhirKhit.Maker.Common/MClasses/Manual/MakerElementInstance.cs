using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.Maker.Common
{
    public class MakerElementInstance
    {
        public String Name {get; set;}
        HashSet<MakerBaseType> types = new HashSet<MakerBaseType>();
        public Int32 Min {get; set; }
        public Int32 Max {get; set; }

        public MakerBaseType[] Types {get; set; }

        public void AddType(MakerBaseType type)
        {
            types.Add(type);
        }
    }
}
