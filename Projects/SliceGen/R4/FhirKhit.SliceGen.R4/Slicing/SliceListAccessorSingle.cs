using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.SliceGen.ShareLib
{
    /// <summary>
    /// Base class for slice accessor classes that have a List as the base type and can cardinality == 1.
    /// </summary>
    public class SliceListAccessorSingle<T> : SliceListAccessor<T>
        where T : Element
    {
    }
}
