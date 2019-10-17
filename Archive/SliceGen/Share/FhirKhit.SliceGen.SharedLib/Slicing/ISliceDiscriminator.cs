using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.SliceGen.SharedLib
{
    public interface ISliceDiscriminator<T>
        where T : Element
    {
        bool IsSlice(T item);
    }
}
