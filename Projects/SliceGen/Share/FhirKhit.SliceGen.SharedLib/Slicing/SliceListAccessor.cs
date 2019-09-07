using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.SliceGen.SharedLib
{
    /// <summary>
    /// Base class for all slice accessor classes that have List<T> as the base type.
    /// </summary>
    public abstract class SliceListAccessor<T> : SliceBaseAccessor<T>
        where T : Element
    {
        protected List<T> Items { get; set; }
    }
}
