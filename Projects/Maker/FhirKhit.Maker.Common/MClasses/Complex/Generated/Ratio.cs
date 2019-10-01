using System;                                                                                                                               // MakerGen.cs:497
using System.Diagnostics;                                                                                                                   // MakerGen.cs:498
using System.IO;                                                                                                                            // MakerGen.cs:499
using System.Linq;                                                                                                                          // MakerGen.cs:500
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:501
                                                                                                                                            // MakerGen.cs:502
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:503
{                                                                                                                                           // MakerGen.cs:504
    #region Json                                                                                                                            // MakerGen.cs:505
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
    #endregion                                                                                                                              // MakerGen.cs:509
    /// <summary>
    /// Fhir complex 'Ratio'
    /// </summary>
    // 0. Ratio
    public class Ratio : FhirKhit.Maker.Common.Complex.ComplexBase                                                                          // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        public class Ratio_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                           // MakerGen.cs:385
        {                                                                                                                                   // MakerGen.cs:386
            // 1. Ratio.numerator
            public ElementDefinitionInfo Numerator;                                                                                         // MakerGen.cs:216
            // 2. Ratio.denominator
            public ElementDefinitionInfo Denominator;                                                                                       // MakerGen.cs:216
            public Ratio_Elements()                                                                                                         // MakerGen.cs:407
            {                                                                                                                               // MakerGen.cs:408
                {                                                                                                                           // MakerGen.cs:231
                    // 1. Ratio.numerator
                    this.Numerator = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Numerator",                                                                                                 // MakerGen.cs:235
                        Path= "Ratio.numerator",                                                                                            // MakerGen.cs:236
                        Id = "Ratio.numerator",                                                                                             // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Quantity                                                                      // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 2. Ratio.denominator
                    this.Denominator = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Denominator",                                                                                               // MakerGen.cs:235
                        Path= "Ratio.denominator",                                                                                          // MakerGen.cs:236
                        Id = "Ratio.denominator",                                                                                           // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Quantity                                                                      // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:427
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:412
            {                                                                                                                               // MakerGen.cs:413
                base.Write(sDef);                                                                                                           // MakerGen.cs:414
                Numerator.Write(sDef);                                                                                                      // MakerGen.cs:220
                Denominator.Write(sDef);                                                                                                    // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:431
        }                                                                                                                                   // MakerGen.cs:391
        public Ratio_Elements Elements { get; }                                                                                             // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
        public Ratio()                                                                                                                      // MakerGen.cs:394
        {                                                                                                                                   // MakerGen.cs:395
            this.Elements = new Ratio_Elements();                                                                                           // MakerGen.cs:396
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:399
        {                                                                                                                                   // MakerGen.cs:400
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:401
        }                                                                                                                                   // MakerGen.cs:402
    }                                                                                                                                       // MakerGen.cs:403
}                                                                                                                                           // MakerGen.cs:514
