using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
                                                                                                                                            // MakerGen.cs:269
namespace FhirKhit.Maker.Common                                                                                                             // MakerGen.cs:270
{                                                                                                                                           // MakerGen.cs:271
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
    public class Range_Type : Complex_Type                                                                                                  // MakerGen.cs:225
    {                                                                                                                                       // MakerGen.cs:226
        // 1. Range.low
        public ElementInstance Low;                                                                                                         // MakerGen.cs:208
        // 2. Range.high
        public ElementInstance High;                                                                                                        // MakerGen.cs:208
        public Range_Type()                                                                                                                 // MakerGen.cs:234
        {                                                                                                                                   // MakerGen.cs:235
        }                                                                                                                                   // MakerGen.cs:246
    }                                                                                                                                       // MakerGen.cs:230
}                                                                                                                                           // MakerGen.cs:277
