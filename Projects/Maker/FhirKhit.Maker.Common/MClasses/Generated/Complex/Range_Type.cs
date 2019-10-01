using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
                                                                                                                                            // MakerGen.cs:381
namespace FhirKhit.Maker.Common                                                                                                             // MakerGen.cs:382
{                                                                                                                                           // MakerGen.cs:383
    /// <summary>
    /// Fhir primitive 'Range'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "Range",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/Range",
    ///   "version": "4.0.0",
    ///   "name": "Range",
    ///   "status": "active",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "Base StructureDefinition for Range Type: A set of ordered Quantities defined by a low and high limit.",
    ///   "purpose": "Need to be able to specify ranges of values.",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "complex-type",
    ///   "abstract": false,
    ///   "type": "Range",
    ///   "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
    ///   "derivation": "specialization",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "Range",
    ///         "path": "Range",
    ///         "short": "Set of values bounded by low and high",
    ///         "definition": "A set of ordered Quantities defined by a low and high limit.",
    ///         "comment": "The stated low and high value are assumed to have arbitrarily high precision when it comes to determining which values are in the range. I.e. 1.99 is not in the range 2 -> 3.",
    ///         "min": 0,
    ///         "max": "*"
    ///       },
    ///       {
    ///         "id": "Range.low",
    ///         "path": "Range.low",
    ///         "short": "Low limit",
    ///         "definition": "The low limit. The boundary is inclusive.",
    ///         "comment": "If the low element is missing, the low boundary is not known.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "Quantity",
    ///             "profile": [
    ///               "http://hl7.org/fhir/StructureDefinition/SimpleQuantity"
    ///             ]
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "Range.high",
    ///         "path": "Range.high",
    ///         "short": "High limit",
    ///         "definition": "The high limit. The boundary is inclusive.",
    ///         "comment": "If the high element is missing, the high boundary is not known.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "Quantity",
    ///             "profile": [
    ///               "http://hl7.org/fhir/StructureDefinition/SimpleQuantity"
    ///             ]
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       }
    ///     ]
    ///   }
    /// }
    /// </summary>
    // 0. Range
    public class Range_Type : MakerComplex_Type                                                                                             // MakerGen.cs:337
    {                                                                                                                                       // MakerGen.cs:338
        // 1. Range.low
        public MakerElementInstance Low;                                                                                                    // MakerGen.cs:217
        // 2. Range.high
        public MakerElementInstance High;                                                                                                   // MakerGen.cs:217
        public Range_Type()                                                                                                                 // MakerGen.cs:346
        {                                                                                                                                   // MakerGen.cs:347
            {                                                                                                                               // MakerGen.cs:228
                // 1. Range.low
                this.Low = new MakerElementInstance                                                                                         // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Low",                                                                                                           // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 2. Range.high
                this.High = new MakerElementInstance                                                                                        // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "High",                                                                                                          // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
        }                                                                                                                                   // MakerGen.cs:358
    }                                                                                                                                       // MakerGen.cs:342
}                                                                                                                                           // MakerGen.cs:389
