using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.SliceGen.ShareLib
{
    public class Slicer<TBase>
        where TBase : Base
    {
        Slicing sliceDiscriminator;

        public Slicer(Slicing sliceDiscriminator)
        {
            this.sliceDiscriminator = sliceDiscriminator;
        }
    }
}
