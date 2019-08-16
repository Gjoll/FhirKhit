using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.ProfGen.SharedLib
{
    /// <summary>
    /// Implements class to handle slice slice discriminator.
    /// </summary>
    public class Slicing
    {
        public IEnumerable<ISliceDiscriminator> discriminators { get; }

        public Slicing(IEnumerable<ISliceDiscriminator> discriminators)
        {
            this.discriminators = discriminators;
        }
    }
}
