using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
                                                                                                                                            // MakerGen.cs:381
namespace FhirKhit.Maker.Common                                                                                                             // MakerGen.cs:382
{                                                                                                                                           // MakerGen.cs:383
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
    public class Ratio_Type : MakerComplex_Type                                                                                             // MakerGen.cs:337
    {                                                                                                                                       // MakerGen.cs:338
        // 1. Ratio.numerator
        public MakerElementInstance Numerator;                                                                                              // MakerGen.cs:217
        // 2. Ratio.denominator
        public MakerElementInstance Denominator;                                                                                            // MakerGen.cs:217
        public Ratio_Type()                                                                                                                 // MakerGen.cs:346
        {                                                                                                                                   // MakerGen.cs:347
            {                                                                                                                               // MakerGen.cs:228
                // 1. Ratio.numerator
                this.Numerator = new MakerElementInstance                                                                                   // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Numerator",                                                                                                     // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 2. Ratio.denominator
                this.Denominator = new MakerElementInstance                                                                                 // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Denominator",                                                                                                   // MakerGen.cs:232
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
