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
    }
}
