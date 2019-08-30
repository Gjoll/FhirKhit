using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.SliceGen.ShareLib
{
    public abstract class ItemBase<T>
        where T : Base
    {
        public T Ptr { get; set; }

        public ItemBase()
        {
        }

        public virtual void Init(T ptr)
        {
            this.Ptr = ptr;
        }
    }
}
