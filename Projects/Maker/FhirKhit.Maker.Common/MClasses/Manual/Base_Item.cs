using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.Maker.Common
{
    public class Base_Item
    {
        public String Name {get;}
        HashSet<Base_Type> types = new HashSet<Base_Type>();

        public Base_Item(String name)
        {
            this.Name = name;
        }

        public void AddType(Base_Type type)
        {
            types.Add(type);
        }
    }
}
