using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.SliceGen.SharedLib
{
    /// <summary>
    /// Base class for slice accessor classes that have a List as the base type and can cardinality == 1.
    /// </summary>
    public abstract class SliceListAccessorSingle<T> : SliceListAccessor<T>
        where T : Element
    {
        /// <summary>
        /// Return member that is this slice.
        /// </summary>
        public T Slice
        {
            get
            {
                foreach (T item in this.Items)
                {
                    if (this.Slicing.IsSlice(item))
                        return item;
                }
                return null;
            }
        }
    }
}
