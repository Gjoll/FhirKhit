using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.SliceGen.ShareLib
{
    /// <summary>
    /// Base class for slice accessor classes that have a List as the base type and can cardinality > 1.
    /// </summary>
    public class SliceListMultipleAccessor<T> : SliceListAccessor<T>, ISliceMultipleAccessor<T>
        where T : Element
    {
        /// <summary>
        /// Return all items that are member of this slice.
        /// </summary>
        public IEnumerable<T> Slices
        {
            get
            {
                foreach (T item in this.items)
                {
                    if (this.Slicing.IsSlice(item))
                        yield return item;
                }
            }
        }
    }
}
