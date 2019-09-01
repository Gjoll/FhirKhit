using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.SliceGen.R4.Slicing
{
    /// <summary>
    /// Interface that all slice accessors with cardinality == 1 must implememnt.
    /// </summary>
    public interface ISliceSingleAccessor<T>
        where T : Element
    {
        /// <summary>
        /// Return all items that are member of this slice.
        /// </summary>
        T Slice { get; }
    }
}
