using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
                                                                                                                                            // MakerGen.cs:269
namespace FhirKhit.Maker.Common                                                                                                             // MakerGen.cs:270
{                                                                                                                                           // MakerGen.cs:271
    /// <summary>
    /// Fhir primitive 'Ratio'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "Ratio",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/Ratio",
    ///   "version": "4.0.0",
    ///   "name": "Ratio",
    ///   "status": "active",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "Base StructureDefinition for Ratio Type: A relationship of two Quantity values - expressed as a numerator and a denominator.",
    ///   "purpose": "Need to able to capture ratios for some measurements (titers) and some rates (costs).",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "complex-type",
    ///   "abstract": false,
    ///   "type": "Ratio",
    ///   "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
    ///   "derivation": "specialization",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "Ratio",
    ///         "path": "Ratio",
    ///         "short": "A ratio of two Quantity values - a numerator and a denominator",
    ///         "definition": "A relationship of two Quantity values - expressed as a numerator and a denominator.",
    ///         "comment": "The Ratio datatype should only be used to express a relationship of two numbers if the relationship cannot be suitably expressed using a Quantity and a common unit.  Where the denominator value is known to be fixed to \"1\", Quantity should be used instead of Ratio.",
    ///         "min": 0,
    ///         "max": "*"
    ///       },
    ///       {
    ///         "id": "Ratio.numerator",
    ///         "path": "Ratio.numerator",
    ///         "short": "Numerator value",
    ///         "definition": "The value of the numerator.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "Quantity"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "Ratio.denominator",
    ///         "path": "Ratio.denominator",
    ///         "short": "Denominator value",
    ///         "definition": "The value of the denominator.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "Quantity"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       }
    ///     ]
    ///   }
    /// }
    /// </summary>
    // 0. Ratio
    public class Ratio_Type : Complex_Type                                                                                                  // MakerGen.cs:225
    {                                                                                                                                       // MakerGen.cs:226
        // 1. Ratio.numerator
        public ElementInstance Numerator;                                                                                                   // MakerGen.cs:208
        // 2. Ratio.denominator
        public ElementInstance Denominator;                                                                                                 // MakerGen.cs:208
        public Ratio_Type()                                                                                                                 // MakerGen.cs:234
        {                                                                                                                                   // MakerGen.cs:235
        }                                                                                                                                   // MakerGen.cs:246
    }                                                                                                                                       // MakerGen.cs:230
}                                                                                                                                           // MakerGen.cs:277
