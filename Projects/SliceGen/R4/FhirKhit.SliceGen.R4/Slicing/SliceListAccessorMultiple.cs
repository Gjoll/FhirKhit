using Hl7.Fhir.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FhirKhit.SliceGen.ShareLib
{
    /// <summary>
    /// Base class for slice accessor classes that have a List as the base type and can cardinality > 1.
    /// </summary>
    public abstract class SliceListAccessorMultiple<T> : SliceListAccessor<T>, ISliceAccessorMultiple<T>
        where T : Element
    {
        /// <summary>
        /// Return number of items in Slices.
        /// </summary>
        public Int32 Count => this.Slices.Count();

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

        /// <summary>
        /// Create new element and add it to collection.
        /// </summary>
        /// <returns></returns>
        public T AppendNew()
        {
            T retVal = this.Create();
            this.items.Add(retVal);
            return retVal;
        }

        /// <summary>
        /// Remove indicated element.
        /// </summary>
        /// <returns></returns>
        public bool Remove(T item)
        {
            return this.items.Remove(item);
        }

        /// <summary>
        /// clear all items in collection.
        /// </summary>
        public void Clear()
        {
            this.items.Clear();
        }
    }
}
