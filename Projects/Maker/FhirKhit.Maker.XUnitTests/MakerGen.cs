using FhirKhit.Tools;
using Hl7.Fhir.Model;
using System;
using System.Diagnostics;
using System.Linq;
using Xunit;

namespace FhirKhit.Maker.XUnitTests
{
    public class MakerGen
    {
        [Fact(DisplayName = "MakerGen.CreateBaseClasses")]
        [Trait("MakerGen", "MakerGen")]
        void CreateBaseClasses()
        {
            foreach (FHIRAllTypes fhirType in Enum.GetValues(typeof(FHIRAllTypes)).OfType<FHIRAllTypes>())
            {
                if (ModelInfo.IsPrimitive(fhirType))
                {
                    String fhirTypeName = ModelInfo.FhirTypeToFhirTypeName(fhirType);
                    if (ModelInfo.FhirTypeToCsType.TryGetValue(fhirTypeName, out Type csType) == false)
                        throw new Exception("");
                    Trace.WriteLine($"FHIRAllTypes.{fhirType}  FhirType {fhirTypeName} CSType {csType.FriendlyName()}");
                }
            }
        }
    }
}
