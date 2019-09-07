using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.SliceGen.SharedLib
{
    /// <summary>
    /// Implements class to handle slice slice discriminator.
    /// </summary>
    public class Slicing<T>
        where T : Element
    {
        public IEnumerable<ISliceDiscriminator<T>> Discriminators { get; set; }

        public bool IsSlice(T item)
        {
            foreach (ISliceDiscriminator<T> discriminator in Discriminators)
            {
                if (discriminator.IsSlice(item) == false)
                    return false;
            }
            return true;
        }
    }
}
