using FhirKhit.ProfGen;
using FhirKhit.Tools;
using Hl7.Fhir.Model;
using System;
using System.Linq;
using System.IO;
using Xunit;


#if FHIR_R2
using FhirKhit.Test.R2;
#elif FHIR_R3
using FhirKhit.Test.R3;
#elif FHIR_R4
using FhirKhit.Test.R4;
#endif

namespace FhirKhit.ProfGen.GenTests
{
    /// <summary>
    /// Test the output test files generated in FhirKhit.ProfGen.XUnitTests.
    /// XUnitTests generated files in this project which are compiled and then
    /// tests are executed on the compiled output classes.
    /// </summary>
    public class GenUseTests
    {
        [Fact(DisplayName = "Gen.CardinalityModObservationTest")]
        [Trait("Test", "test")]
        public void CardinalityModObservationTest()
        {
            Observation o = new Observation();
            o.Identifier.Add(new Identifier("a", "b"));
            o.Status = ObservationStatus.Cancelled;
            o.Code = new CodeableConcept("codeSystem", "codeCode", "codeDisplay", "codeText");

            CardinalityModObservation n = CardinalityModObservation.Create(o);

            Assert.True(n.Identifier.Get().System == "a");
            n.Identifier.Set(new Identifier("c", "d"));
            Assert.True(n.Identifier.Get().System == "c");
        }

        [Fact(DisplayName = "Gen.FixedTest")]
        [Trait("Test", "test")]
        public void FixedTest()
        {
            Observation o = new Observation();

            {
                Fixed n = Fixed.Create(o);
                {
                    Assert.True(n.Identifier.Get(out Identifier value) == true);
                    Assert.True(value.System == "fixedIdentifierSystem");
                    Assert.True(value.Value == "fixedIdentifierValue");
                }
                {
                    Assert.True(n.Code.Get(out CodeableConcept value) == true);
                    Assert.True(value.Coding.Count() == 1);
                    Assert.True(value.Coding.First().System == "codeSystem");
                    Assert.True(value.Coding.First().Code == "codeCode");
                    Assert.True(value.Coding.First().Display == "codeDisplay");
                    Assert.True(value.Text == "codeText");
                }
                {
                    Assert.True(n.Status.Get(out Code<ObservationStatus> status) == true);
                    Assert.True(status.Value == ObservationStatus.Cancelled);
                }
            }

            {
                Fixed1 n = Fixed1.Create(o);
                {
                    Assert.True(n.Effective.Get(out FhirDateTime value) == true);
                    DateTimeOffset v = value.ToDateTimeOffset(new TimeSpan(0));
                    Assert.True(v.Year == 1002);
                    Assert.True(v.Month == 1);
                    Assert.True(v.Day == 2);
                    Assert.True(v.Hour == 3);
                    Assert.True(v.Minute == 4);
                    Assert.True(v.Second == 5);
                }
                {
                    Assert.True(n.Value.Get(out Quantity value) == true);
                    Assert.True(value.Value == 10);
                    Assert.True(value.System == "www.things.com");
                    Assert.True(value.Code == "things");
                }
            }

            {
                Fixed2 n = Fixed2.Create(o);
                {
                    Assert.True(n.Effective.Get(out Period value) == true);
                    Assert.True(value.Start == "1002-01-02");
                    Assert.True(value.End == "1003-04-05");
                }
                {
                    Assert.True(n.Value.Get(out FhirBoolean value) == true);
                    Assert.True(value.Value == true);
                }
            }
        }

        [Fact(DisplayName = "Gen.NoModObservationTest")]
        [Trait("Test", "test")]
        public void NoModObservationTest()
        {
            Observation o = new Observation();
            o.Identifier.Add(new Identifier("a", "b"));
            o.Status = ObservationStatus.Cancelled;
            o.Code = new CodeableConcept("codeSystem", "codeCode", "codeDisplay", "codeText");

            NoModObservation n = NoModObservation.Create(o);
            {
                Assert.True(n.Status.Get(out Code<ObservationStatus> status) == true);
                Assert.True(status.Value == ObservationStatus.Cancelled);
                n.Status.Set(new Code<ObservationStatus>(ObservationStatus.Final));

                Assert.True(n.Status.Get(out status) == true);
                Assert.True(status.Value == ObservationStatus.Final);
            }
            {
                Assert.True(n.Identifier.Count == 1);
                Assert.True(n.Identifier.Get(0, out Identifier value) == true);
                Assert.True(value.System == "a");
                n.Identifier.Add(new Identifier("c", "d"));
                Assert.True(n.Identifier.Count == 2);
                Assert.True(n.Identifier.Get(1, out value) == true);
                Assert.True(value.System == "c");
                Assert.True(value.Value == "d");
            }

            {
                Assert.True(n.Code.Get(out CodeableConcept coding) == true);

                Assert.True(coding.Coding.Count == 1);
                Assert.True(coding.Coding[0].System == "codeSystem");
                Assert.True(coding.Coding[0].Code == "codeCode");
                Assert.True(coding.Coding[0].Display == "codeDisplay");
            }
        }
    }
}
