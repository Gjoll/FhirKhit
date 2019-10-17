using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.ProfGen.PGSharedLib
{
    public interface ISliceDiscriminator
    {
        bool IsSlice(Element discriminator, Element item);
    }
}
