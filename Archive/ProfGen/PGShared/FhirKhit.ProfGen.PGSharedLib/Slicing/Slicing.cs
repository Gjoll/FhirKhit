using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.ProfGen.PGSharedLib
{
    /// <summary>
    /// Implements class to handle slice slice discriminator.
    /// </summary>
    public class Slicing
    {
        public IEnumerable<ISliceDiscriminator> Discriminators { get; }

        public Slicing(IEnumerable<ISliceDiscriminator> discriminators)
        {
            this.Discriminators = discriminators;
        }
    }
}
