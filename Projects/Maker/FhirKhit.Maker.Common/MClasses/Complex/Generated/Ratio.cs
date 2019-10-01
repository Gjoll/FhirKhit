using System;                                                                                                                               // MakerGen.cs:499
using System.Diagnostics;                                                                                                                   // MakerGen.cs:500
using System.IO;                                                                                                                            // MakerGen.cs:501
using System.Linq;                                                                                                                          // MakerGen.cs:502
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:503
                                                                                                                                            // MakerGen.cs:504
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:505
{                                                                                                                                           // MakerGen.cs:506
    #region Json                                                                                                                            // MakerGen.cs:507
    #if NEVER
    {
      "resourceType": "StructureDefinition",
      "id": "Ratio",
      "url": "http://hl7.org/fhir/StructureDefinition/Ratio",
      "version": "4.0.0",
      "name": "Ratio",
      "status": "active",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for Ratio Type: A relationship of two Quantity values - expressed as a numerator and a denominator.",
      "purpose": "Need to able to capture ratios for some measurements (titers) and some rates (costs).",
      "fhirVersion": "4.0.0",
      "kind": "complex-type",
      "abstract": false,
      "type": "Ratio",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Ratio",
            "path": "Ratio",
            "short": "A ratio of two Quantity values - a numerator and a denominator",
            "definition": "A relationship of two Quantity values - expressed as a numerator and a denominator.",
            "comment": "The Ratio datatype should only be used to express a relationship of two numbers if the relationship cannot be suitably expressed using a Quantity and a common unit.  Where the denominator value is known to be fixed to \"1\", Quantity should be used instead of Ratio.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Ratio.numerator",
            "path": "Ratio.numerator",
            "short": "Numerator value",
            "definition": "The value of the numerator.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Quantity"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Ratio.denominator",
            "path": "Ratio.denominator",
            "short": "Denominator value",
            "definition": "The value of the denominator.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Quantity"
              }
            ],
            "isSummary": true
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:511
    /// <summary>
    /// Fhir complex 'Ratio'
    /// </summary>
    // 0. Ratio
    public class Ratio : FhirKhit.Maker.Common.Complex.ComplexBase                                                                          // MakerGen.cs:385
    {                                                                                                                                       // MakerGen.cs:386
        public class Ratio_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                           // MakerGen.cs:387
        {                                                                                                                                   // MakerGen.cs:388
            // 1. Ratio.numerator
            public ElementDefinitionInfo Numerator;                                                                                         // MakerGen.cs:236
            // 2. Ratio.denominator
            public ElementDefinitionInfo Denominator;                                                                                       // MakerGen.cs:236
            public Ratio_Elements()                                                                                                         // MakerGen.cs:409
            {                                                                                                                               // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:251
                    // 1. Ratio.numerator
                    this.Numerator = new ElementDefinitionInfo                                                                              // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Numerator",                                                                                                 // MakerGen.cs:255
                        Path= "Ratio.numerator",                                                                                            // MakerGen.cs:256
                        Id = "Ratio.numerator",                                                                                             // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Quantity                                                                      // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 2. Ratio.denominator
                    this.Denominator = new ElementDefinitionInfo                                                                            // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Denominator",                                                                                               // MakerGen.cs:255
                        Path= "Ratio.denominator",                                                                                          // MakerGen.cs:256
                        Id = "Ratio.denominator",                                                                                           // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Quantity                                                                      // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
            }                                                                                                                               // MakerGen.cs:429
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:414
            {                                                                                                                               // MakerGen.cs:415
                base.Write(sDef);                                                                                                           // MakerGen.cs:416
                Numerator.Write(sDef);                                                                                                      // MakerGen.cs:240
                Denominator.Write(sDef);                                                                                                    // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:433
        }                                                                                                                                   // MakerGen.cs:393
        public Ratio_Elements Elements { get; }                                                                                             // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
        public Ratio()                                                                                                                      // MakerGen.cs:396
        {                                                                                                                                   // MakerGen.cs:397
            this.Elements = new Ratio_Elements();                                                                                           // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:404
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:516
