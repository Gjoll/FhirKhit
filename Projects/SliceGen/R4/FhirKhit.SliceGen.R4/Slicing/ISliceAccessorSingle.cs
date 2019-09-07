using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.SliceGen.ShareLib
{
    /// <summary>
    /// Interface that all slice accessors with cardinality == 1 must implememnt.
    /// </summary>
    public interface ISliceAccessorSingle<T>
        where T : Element
    {
        /// <summary>
        /// Return all items that are member of this slice.
        /// </summary>
        T Slice { get; }
    }
}
