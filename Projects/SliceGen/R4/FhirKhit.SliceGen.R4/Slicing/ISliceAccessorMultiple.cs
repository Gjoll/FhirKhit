using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.SliceGen.ShareLib
{
    /// <summary>
    /// Interface that all slice accessors with cardinality > 1 must implememnt.
    /// </summary>
    public interface ISliceAccessorMultiple<T>
        where T : Element
    {
        /// <summary>
        /// Return number of items in Slices.
        /// </summary>
        Int32 Count { get; }

        /// <summary>
        /// Return all items that are member of this slice.
        /// </summary>
        IEnumerable<T> Slices { get; }

        /// <summary>
        /// Create new element and add it to collection.
        /// </summary>
        /// <returns></returns>
        T AppendNew();

        /// <summary>
        /// Remove indicated element.
        /// </summary>
        /// <returns></returns>
        bool Remove(T item);

        /// <summary>
        /// clear all elements.
        /// </summary>
        /// <returns></returns>
        void Clear();
    }
}
