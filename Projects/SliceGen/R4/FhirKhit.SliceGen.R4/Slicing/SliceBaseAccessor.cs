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
        /// <summary>
        /// Access slicing data
        /// </summary>
        protected Slicing Slicing {get; set; }

        /// <summary>
        /// Initialize fixed values in item to match that of slice.
        /// </summary>
        /// <param name="item"></param>
        //protected abstract void Initialize(T item);
    }
}
