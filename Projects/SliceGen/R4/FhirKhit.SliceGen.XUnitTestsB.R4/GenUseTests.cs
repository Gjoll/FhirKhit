using FhirKhit.SliceGen;
using FhirKhit.Tools;
using Hl7.Fhir.Model;
using System;
using System.IO;
using System.Text;
using Xunit;
using System.Diagnostics;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Specification.Snapshot;
using System.Collections.Generic;
using FhirKhit.SliceGen.R4;
using FhirKhit.SliceGen.CodeGen;
using FhirKhit.Test.R4;


#if FHIR_R2
using FhirKhit.Tools.R2;
#elif FHIR_R3
using FhirKhit.Tools.R3;
#elif FHIR_R4
using FhirKhit.Tools.R4;
#endif

namespace FhirKhit.SliceGen.XUnitTestsB
{
    public class GenUseTests
    {
        /// <summary>
        /// Test functionality of generated file 'SlicedMultipleTests'.
        /// </summary>
        [Fact(DisplayName = "SliceGen.SlicedMultipleTests")]
        [Trait("Test", "test")]
        public void SlicedMultipleTests1()
        {
            Observation o = new Observation
            {
                Id = "SlicedMultipleTests"
            };

            SlicedMultipleExtensions.Slice1Impl slice1 = o.Component.Slice1();
            SlicedMultipleExtensions.Slice2Impl slice2 = o.Component.Slice2();
            Debug.Assert(slice1.Count == 0);
            Debug.Assert(slice2.Count == 0);

            Observation.ComponentComponent item1a = slice1.AppendNew();
            Observation.ComponentComponent item2a = slice2.AppendNew();
            Debug.Assert(slice1.Count == 1);
            Debug.Assert(slice2.Count == 1);

            Debug.Assert(item1a.Code.Coding.Count == 1);
            Debug.Assert(item1a.Code.Coding[0].System == "http://www.test.com/SliceSystem");
            Debug.Assert(item1a.Code.Coding[0].Code == "Slice1Code");

            Debug.Assert(item2a.Code.Coding.Count == 1);
            Debug.Assert(item2a.Code.Coding[0].System == "http://www.test.com/SliceSystem");
            Debug.Assert(item2a.Code.Coding[0].Code == "Slice2Code");

        }
    }
}
