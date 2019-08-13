using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.ProfGen.SharedLib
{
    public abstract class ProfileBase<T>
        where T : Base
    {
        public T Ptr => this.ptr;
        protected T ptr;

        protected ProfileBase(T ptr)
        {
            this.ptr = ptr;
        }
    }
}
