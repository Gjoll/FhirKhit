using System;                                                                                                                               // MakerGen.cs:439
using System.Diagnostics;                                                                                                                   // MakerGen.cs:440
using System.IO;                                                                                                                            // MakerGen.cs:441
using System.Linq;                                                                                                                          // MakerGen.cs:442
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:443
                                                                                                                                            // MakerGen.cs:444
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:445
{                                                                                                                                           // MakerGen.cs:446
    #region Json                                                                                                                            // MakerGen.cs:447
    #if NEVER
    {
      "resourceType": "StructureDefinition",
      "id": "Range",
      "url": "http://hl7.org/fhir/StructureDefinition/Range",
      "version": "4.0.0",
      "name": "Range",
      "status": "active",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for Range Type: A set of ordered Quantities defined by a low and high limit.",
      "purpose": "Need to be able to specify ranges of values.",
      "fhirVersion": "4.0.0",
      "kind": "complex-type",
      "abstract": false,
      "type": "Range",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Range",
            "path": "Range",
            "short": "Set of values bounded by low and high",
            "definition": "A set of ordered Quantities defined by a low and high limit.",
            "comment": "The stated low and high value are assumed to have arbitrarily high precision when it comes to determining which values are in the range. I.e. 1.99 is not in the range 2 -> 3.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Range.low",
            "path": "Range.low",
            "short": "Low limit",
            "definition": "The low limit. The boundary is inclusive.",
            "comment": "If the low element is missing, the low boundary is not known.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Quantity",
                "profile": [
                  "http://hl7.org/fhir/StructureDefinition/SimpleQuantity"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Range.high",
            "path": "Range.high",
            "short": "High limit",
            "definition": "The high limit. The boundary is inclusive.",
            "comment": "If the high element is missing, the high boundary is not known.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Quantity",
                "profile": [
                  "http://hl7.org/fhir/StructureDefinition/SimpleQuantity"
                ]
              }
            ],
            "isSummary": true
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:451
    /// <summary>
    /// Fhir complex 'Range'
    /// </summary>
    // 0. Range
    public class Range : FhirKhit.Maker.Common.Complex.ComplexBase                                                                          // MakerGen.cs:352
    {                                                                                                                                       // MakerGen.cs:353
        // 1. Range.low
        public MakerElementInstance Element_Low;                                                                                            // MakerGen.cs:232
        // 2. Range.high
        public MakerElementInstance Element_High;                                                                                           // MakerGen.cs:232
        public Range()                                                                                                                      // MakerGen.cs:361
        {                                                                                                                                   // MakerGen.cs:362
            {                                                                                                                               // MakerGen.cs:243
                // 1. Range.low
                this.Element_Low = new MakerElementInstance                                                                                 // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Low",                                                                                                   // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 2. Range.high
                this.Element_High = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_High",                                                                                                  // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
        }                                                                                                                                   // MakerGen.cs:373
    }                                                                                                                                       // MakerGen.cs:357
}                                                                                                                                           // MakerGen.cs:456
