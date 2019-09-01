using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.SliceGen.ShareLib
{
    /// <summary>
    /// Base class for all slice accessor classes.
    /// </summary>
    public class SliceAccessor<T>
        where T : Element
    {
        protected T fhirElement;
        protected Slicing Slicing {get; set; }
    }
}
