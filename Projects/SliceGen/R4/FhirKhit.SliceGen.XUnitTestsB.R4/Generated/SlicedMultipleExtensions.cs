/*                                                                                                                                          // CSCodeFormatter.cs:54
 * Code in this class was auto generated by SliceGen                                                                                        // CSCodeFormatter.cs:55
*/                                                                                                                                          // CSCodeFormatter.cs:56
using System;                                                                                                                               // CSCodeFormatter.cs:57
using System.Linq;                                                                                                                          // CSCodeFormatter.cs:58
using System.Collections.Generic;                                                                                                           // CSCodeFormatter.cs:59
using System.Reflection;                                                                                                                    // CSCodeFormatter.cs:60
using System.Text;                                                                                                                          // CSCodeFormatter.cs:61
using Hl7.Fhir.Model;                                                                                                                       // CSCodeFormatter.cs:62
using FhirKhit.SliceGen.ShareLib;                                                                                                           // CSCodeFormatter.cs:63
                                                                                                                                            // CSCodeFormatter.cs:64
namespace FhirKhit.Test.R4                                                                                                                  // CSCodeFormatter.cs:65
{                                                                                                                                           // CSCodeFormatter.cs:66
                                                                                                                                            // CSCodeFormatter.cs:94
    /// <summary>
    /// Extension class to add slicing helper methods to Observation
    /// </summary>
    public static class SlicedMultipleExtensions
    {                                                                                                                                       // CSCodeFormatter.cs:97
        #region SlicedMultipleExtensions sub classes
                                                                                                                                            // CSCodeFormatter.cs:369
        /// <summary>
        /// public interface that implements the functionality of slice Slice1Impl
        /// </summary>
        public interface ISlice1 : ISliceAccessorMultiple<Observation.ComponentComponent>                                                   // CSCodeFormatter.cs:371
        {                                                                                                                                   // CSCodeFormatter.cs:372
        }                                                                                                                                   // CSCodeFormatter.cs:373
                                                                                                                                            // CSCodeFormatter.cs:374
        /// <summary>
        /// private class that implements the functionality of slice Slice1Impl
        /// </summary>
        class Slice1Impl : SliceListAccessorMultiple<Observation.ComponentComponent>, ISlice1                                               // CSCodeFormatter.cs:376
        {                                                                                                                                   // CSCodeFormatter.cs:377
            #region SlicedMultipleExtensions.Slice1Impl fields
                                                                                                                                            // CSCodeFormatter.cs:400
            /// <summary>
            /// slicing discriminator for Observation.component slice Slice1
            /// </summary>
            static Slicing<Observation.ComponentComponent> slicing = new Slicing<Observation.ComponentComponent>                            // CSCodeFormatter.cs:402
            {                                                                                                                               // CSCodeFormatter.cs:403
                Discriminators = new ISliceDiscriminator<Observation.ComponentComponent>[]                                                  // CSCodeFormatter.cs:404
                {                                                                                                                           // CSCodeFormatter.cs:405
                    new SliceOnValueDiscriminator<Observation.ComponentComponent, CodeableConcept>                                          // CSCodeFormatter.cs:216
                    {                                                                                                                       // CSCodeFormatter.cs:217
                        Path = "code",                                                                                                      // CSCodeFormatter.cs:218
                        Pattern = FixComponentSlice1Code(),                                                                                 // CSCodeFormatter.cs:219
                        ValueFilter = ValueFilterComponentSlice1Code                                                                        // CSCodeFormatter.cs:220
                    }                                                                                                                       // CSCodeFormatter.cs:221
                }                                                                                                                           // CSCodeFormatter.cs:417
            };                                                                                                                              // CSCodeFormatter.cs:418
            #endregion  // SlicedMultipleExtensions.Slice1Impl  fields
            #region SlicedMultipleExtensions.Slice1Impl methods
                                                                                                                                            // CSCodeFormatter.cs:206
            /// <summary>
            /// Return all elements at discriminator path 'code'
            /// </summary>
            static IEnumerable<CodeableConcept> ValueFilterComponentSlice1Code(IEnumerable<Observation.ComponentComponent> head)            // CSCodeFormatter.cs:658
            {                                                                                                                               // CSCodeFormatter.cs:591
                                                                                                                                            // CSCodeFormatter.cs:592
                IEnumerable<CodeableConcept> GetChild_1(IEnumerable<Observation.ComponentComponent> inputElements)                          // CSCodeFormatter.cs:542
                {                                                                                                                           // CSCodeFormatter.cs:543
                    if (inputElements != null)                                                                                              // CSCodeFormatter.cs:544
                    {                                                                                                                       // CSCodeFormatter.cs:545
                        foreach (Observation.ComponentComponent inputElement in inputElements)                                              // CSCodeFormatter.cs:546
                        {                                                                                                                   // CSCodeFormatter.cs:547
                            yield return inputElement.Code;                                                                                 // CSCodeFormatter.cs:562
                        }                                                                                                                   // CSCodeFormatter.cs:567
                    }                                                                                                                       // CSCodeFormatter.cs:568
                }                                                                                                                           // CSCodeFormatter.cs:569
                IEnumerable<CodeableConcept> result1 = GetChild_1(head);                                                                    // CSCodeFormatter.cs:644
                return result1;                                                                                                             // CSCodeFormatter.cs:648
            }                                                                                                                               // CSCodeFormatter.cs:652
                                                                                                                                            // CSCodeFormatter.cs:330
            /// <summary>
            /// Slice1Impl constructor
            /// </summary>
            public Slice1Impl(List<Observation.ComponentComponent> items)                                                                   // CSCodeFormatter.cs:332
            {                                                                                                                               // CSCodeFormatter.cs:333
                this.Items = items;                                                                                                         // CSCodeFormatter.cs:334
                this.Slicing = slicing;                                                                                                     // CSCodeFormatter.cs:335
            }                                                                                                                               // CSCodeFormatter.cs:336
            static CodeableConcept FixComponentSlice1Code()                                                                                 // FhirConstruct.cs:771
            {                                                                                                                               // FhirConstruct.cs:772
                CodeableConcept retVal = new CodeableConcept();                                                                             // FhirConstruct.cs:773
                retVal.Coding = new List<Coding>();                                                                                         // FhirConstruct.cs:779
                {                                                                                                                           // FhirConstruct.cs:782
                    var temp2 = new Coding();                                                                                               // FhirConstruct.cs:783
                    temp2.SystemElement = new FhirUri();                                                                                    // FhirConstruct.cs:786
                    temp2.SystemElement.Value = "http://www.test.com/SliceSystem";                                                          // FhirConstruct.cs:788
                    temp2.CodeElement = new Code();                                                                                         // FhirConstruct.cs:802
                    temp2.CodeElement.Value = "Slice1Code";                                                                                 // FhirConstruct.cs:804
                    retVal.Coding.Add(temp2);                                                                                               // FhirConstruct.cs:831
                }                                                                                                                           // FhirConstruct.cs:832
                return retVal;                                                                                                              // FhirConstruct.cs:847
            }                                                                                                                               // FhirConstruct.cs:848
                                                                                                                                            // CSCodeFormatter.cs:460
            /// <summary>
            /// Create and initialize a new item
            /// </summary>
            protected override Observation.ComponentComponent Create()                                                                      // CSCodeFormatter.cs:462
            {                                                                                                                               // CSCodeFormatter.cs:463
                Observation.ComponentComponent retVal = new Observation.ComponentComponent();                                               // CSCodeFormatter.cs:464
                retVal.Code = FixComponentSlice1Code();                                                                                     // CSCodeFormatter.cs:438
                return retVal;                                                                                                              // CSCodeFormatter.cs:468
            }                                                                                                                               // CSCodeFormatter.cs:469
            #endregion // SlicedMultipleExtensions.Slice1Impl  methods
        }                                                                                                                                   // CSCodeFormatter.cs:387
                                                                                                                                            // CSCodeFormatter.cs:369
        /// <summary>
        /// public interface that implements the functionality of slice Slice2Impl
        /// </summary>
        public interface ISlice2 : ISliceAccessorMultiple<Observation.ComponentComponent>                                                   // CSCodeFormatter.cs:371
        {                                                                                                                                   // CSCodeFormatter.cs:372
        }                                                                                                                                   // CSCodeFormatter.cs:373
                                                                                                                                            // CSCodeFormatter.cs:374
        /// <summary>
        /// private class that implements the functionality of slice Slice2Impl
        /// </summary>
        class Slice2Impl : SliceListAccessorMultiple<Observation.ComponentComponent>, ISlice2                                               // CSCodeFormatter.cs:376
        {                                                                                                                                   // CSCodeFormatter.cs:377
            #region SlicedMultipleExtensions.Slice2Impl fields
                                                                                                                                            // CSCodeFormatter.cs:400
            /// <summary>
            /// slicing discriminator for Observation.component slice Slice2
            /// </summary>
            static Slicing<Observation.ComponentComponent> slicing = new Slicing<Observation.ComponentComponent>                            // CSCodeFormatter.cs:402
            {                                                                                                                               // CSCodeFormatter.cs:403
                Discriminators = new ISliceDiscriminator<Observation.ComponentComponent>[]                                                  // CSCodeFormatter.cs:404
                {                                                                                                                           // CSCodeFormatter.cs:405
                    new SliceOnValueDiscriminator<Observation.ComponentComponent, CodeableConcept>                                          // CSCodeFormatter.cs:216
                    {                                                                                                                       // CSCodeFormatter.cs:217
                        Path = "code",                                                                                                      // CSCodeFormatter.cs:218
                        Pattern = FixComponentSlice2Code(),                                                                                 // CSCodeFormatter.cs:219
                        ValueFilter = ValueFilterComponentSlice2Code                                                                        // CSCodeFormatter.cs:220
                    }                                                                                                                       // CSCodeFormatter.cs:221
                }                                                                                                                           // CSCodeFormatter.cs:417
            };                                                                                                                              // CSCodeFormatter.cs:418
            #endregion  // SlicedMultipleExtensions.Slice2Impl  fields
            #region SlicedMultipleExtensions.Slice2Impl methods
                                                                                                                                            // CSCodeFormatter.cs:206
            /// <summary>
            /// Return all elements at discriminator path 'code'
            /// </summary>
            static IEnumerable<CodeableConcept> ValueFilterComponentSlice2Code(IEnumerable<Observation.ComponentComponent> head)            // CSCodeFormatter.cs:658
            {                                                                                                                               // CSCodeFormatter.cs:591
                                                                                                                                            // CSCodeFormatter.cs:592
                IEnumerable<CodeableConcept> GetChild_1(IEnumerable<Observation.ComponentComponent> inputElements)                          // CSCodeFormatter.cs:542
                {                                                                                                                           // CSCodeFormatter.cs:543
                    if (inputElements != null)                                                                                              // CSCodeFormatter.cs:544
                    {                                                                                                                       // CSCodeFormatter.cs:545
                        foreach (Observation.ComponentComponent inputElement in inputElements)                                              // CSCodeFormatter.cs:546
                        {                                                                                                                   // CSCodeFormatter.cs:547
                            yield return inputElement.Code;                                                                                 // CSCodeFormatter.cs:562
                        }                                                                                                                   // CSCodeFormatter.cs:567
                    }                                                                                                                       // CSCodeFormatter.cs:568
                }                                                                                                                           // CSCodeFormatter.cs:569
                IEnumerable<CodeableConcept> result1 = GetChild_1(head);                                                                    // CSCodeFormatter.cs:644
                return result1;                                                                                                             // CSCodeFormatter.cs:648
            }                                                                                                                               // CSCodeFormatter.cs:652
                                                                                                                                            // CSCodeFormatter.cs:330
            /// <summary>
            /// Slice2Impl constructor
            /// </summary>
            public Slice2Impl(List<Observation.ComponentComponent> items)                                                                   // CSCodeFormatter.cs:332
            {                                                                                                                               // CSCodeFormatter.cs:333
                this.Items = items;                                                                                                         // CSCodeFormatter.cs:334
                this.Slicing = slicing;                                                                                                     // CSCodeFormatter.cs:335
            }                                                                                                                               // CSCodeFormatter.cs:336
            static CodeableConcept FixComponentSlice2Code()                                                                                 // FhirConstruct.cs:771
            {                                                                                                                               // FhirConstruct.cs:772
                CodeableConcept retVal = new CodeableConcept();                                                                             // FhirConstruct.cs:773
                retVal.Coding = new List<Coding>();                                                                                         // FhirConstruct.cs:779
                {                                                                                                                           // FhirConstruct.cs:782
                    var temp2 = new Coding();                                                                                               // FhirConstruct.cs:783
                    temp2.SystemElement = new FhirUri();                                                                                    // FhirConstruct.cs:786
                    temp2.SystemElement.Value = "http://www.test.com/SliceSystem";                                                          // FhirConstruct.cs:788
                    temp2.CodeElement = new Code();                                                                                         // FhirConstruct.cs:802
                    temp2.CodeElement.Value = "Slice2Code";                                                                                 // FhirConstruct.cs:804
                    retVal.Coding.Add(temp2);                                                                                               // FhirConstruct.cs:831
                }                                                                                                                           // FhirConstruct.cs:832
                return retVal;                                                                                                              // FhirConstruct.cs:847
            }                                                                                                                               // FhirConstruct.cs:848
                                                                                                                                            // CSCodeFormatter.cs:460
            /// <summary>
            /// Create and initialize a new item
            /// </summary>
            protected override Observation.ComponentComponent Create()                                                                      // CSCodeFormatter.cs:462
            {                                                                                                                               // CSCodeFormatter.cs:463
                Observation.ComponentComponent retVal = new Observation.ComponentComponent();                                               // CSCodeFormatter.cs:464
                retVal.Code = FixComponentSlice2Code();                                                                                     // CSCodeFormatter.cs:438
                return retVal;                                                                                                              // CSCodeFormatter.cs:468
            }                                                                                                                               // CSCodeFormatter.cs:469
            #endregion // SlicedMultipleExtensions.Slice2Impl  methods
        }                                                                                                                                   // CSCodeFormatter.cs:387
        #endregion
        #region fields SlicedMultipleExtensions fields
        #endregion
        #region methods SlicedMultipleExtensions methods
                                                                                                                                            // CSCodeFormatter.cs:267
        /// <summary>
        /// Extension method to return slice Slice1 on component
        /// </summary>
        /// <example>
        /// Observation resource = new Observation();
        /// SlicedMultipleExtensions.ISlice1 sliceAccessor = resource.Component.Slice1();
        /// </example>
        public static ISlice1 Slice1(this List<Observation.ComponentComponent> item)                                                        // CSCodeFormatter.cs:273
        {                                                                                                                                   // CSCodeFormatter.cs:274
            Slice1Impl retVal = new Slice1Impl(item);                                                                                       // CSCodeFormatter.cs:275
            return retVal;                                                                                                                  // CSCodeFormatter.cs:276
        }                                                                                                                                   // CSCodeFormatter.cs:277
                                                                                                                                            // CSCodeFormatter.cs:267
        /// <summary>
        /// Extension method to return slice Slice2 on component
        /// </summary>
        /// <example>
        /// Observation resource = new Observation();
        /// SlicedMultipleExtensions.ISlice2 sliceAccessor = resource.Component.Slice2();
        /// </example>
        public static ISlice2 Slice2(this List<Observation.ComponentComponent> item)                                                        // CSCodeFormatter.cs:273
        {                                                                                                                                   // CSCodeFormatter.cs:274
            Slice2Impl retVal = new Slice2Impl(item);                                                                                       // CSCodeFormatter.cs:275
            return retVal;                                                                                                                  // CSCodeFormatter.cs:276
        }                                                                                                                                   // CSCodeFormatter.cs:277
        #endregion
    }                                                                                                                                       // CSCodeFormatter.cs:118
}                                                                                                                                           // CSCodeFormatter.cs:77
