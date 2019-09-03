using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.SliceGen.ShareLib
{
    public class Slicer<T>
        where T : Element
    {
        Slicing<T> sliceDiscriminator;

        public Slicer(Slicing<T> sliceDiscriminator)
        {
            this.sliceDiscriminator = sliceDiscriminator;
        }
    }
}
