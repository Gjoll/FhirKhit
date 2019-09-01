using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.SliceGen.ShareLib
{
    /// <summary>
    /// Base class for all slice accessor classes.
    /// </summary>
    public abstract class SliceBaseAccessor<T>
        where T : Element
    {
        protected Slicing Slicing {get; set; }
    }
}
