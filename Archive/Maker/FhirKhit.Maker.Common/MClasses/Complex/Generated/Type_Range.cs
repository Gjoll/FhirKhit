using System;                                                                                                                               // MakerGen.cs:490
using System.Diagnostics;                                                                                                                   // MakerGen.cs:491
using System.IO;                                                                                                                            // MakerGen.cs:492
using System.Linq;                                                                                                                          // MakerGen.cs:493
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:494
                                                                                                                                            // MakerGen.cs:495
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:496
{                                                                                                                                           // MakerGen.cs:497
    #region Json                                                                                                                            // MakerGen.cs:498
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
    #endregion                                                                                                                              // MakerGen.cs:502
    /// <summary>
    /// Fhir complex 'Range'
    /// </summary>
    // 0. Range
    public partial class Type_Range : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:381
    {                                                                                                                                       // MakerGen.cs:382
        // 1. Range.low
        public ElementDefinitionInfo Element_Low;                                                                                           // MakerGen.cs:217
        // 2. Range.high
        public ElementDefinitionInfo Element_High;                                                                                          // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:388
        {                                                                                                                                   // MakerGen.cs:389
            base.Write(sDef);                                                                                                               // MakerGen.cs:390
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:391
            {                                                                                                                               // MakerGen.cs:392
                Path = "Range",                                                                                                             // MakerGen.cs:393
                ElementId = "Range"                                                                                                         // MakerGen.cs:394
            });                                                                                                                             // MakerGen.cs:395
            Element_Low.Write(sDef);                                                                                                        // MakerGen.cs:221
            Element_High.Write(sDef);                                                                                                       // MakerGen.cs:221
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
        public Type_Range()                                                                                                                 // MakerGen.cs:400
        {                                                                                                                                   // MakerGen.cs:401
            {                                                                                                                               // MakerGen.cs:232
                // 1. Range.low
                this.Element_Low = new ElementDefinitionInfo                                                                                // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Low",                                                                                                   // MakerGen.cs:236
                    Path= "Range.low",                                                                                                      // MakerGen.cs:237
                    Id = "Range.low",                                                                                                       // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                     // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        }                                                                                                                   // MakerGen.cs:358
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 2. Range.high
                this.Element_High = new ElementDefinitionInfo                                                                               // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_High",                                                                                                  // MakerGen.cs:236
                    Path= "Range.high",                                                                                                     // MakerGen.cs:237
                    Id = "Range.high",                                                                                                      // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                     // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        }                                                                                                                   // MakerGen.cs:358
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
        }                                                                                                                                   // MakerGen.cs:403
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:507
