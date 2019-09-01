using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.SliceGen.ShareLib
{
    /// <summary>
    /// Implements class to handle slice slice discriminator.
    /// </summary>
    public class Slicing
    {
        public IEnumerable<ISliceDiscriminator> Discriminators { get; set; }

        public bool IsSlice(Element item)
        {
            foreach (ISliceDiscriminator discriminator in Discriminators)
            {
                if (discriminator.IsSlice(item) == false)
                    return false;
            }
            return true;
        }
    }
}
