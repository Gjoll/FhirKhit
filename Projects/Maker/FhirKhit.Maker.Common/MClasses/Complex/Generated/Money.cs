using System;                                                                                                                               // MakerGen.cs:511
using System.Diagnostics;                                                                                                                   // MakerGen.cs:512
using System.IO;                                                                                                                            // MakerGen.cs:513
using System.Linq;                                                                                                                          // MakerGen.cs:514
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:515
                                                                                                                                            // MakerGen.cs:516
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:517
{                                                                                                                                           // MakerGen.cs:518
    #region Json                                                                                                                            // MakerGen.cs:519
    #if NEVER
    {
      "resourceType": "StructureDefinition",
      "id": "Money",
      "url": "http://hl7.org/fhir/StructureDefinition/Money",
      "version": "4.0.0",
      "name": "Money",
      "status": "active",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for Money Type: An amount of economic utility in some recognized currency.",
      "fhirVersion": "4.0.0",
      "kind": "complex-type",
      "abstract": false,
      "type": "Money",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Money",
            "path": "Money",
            "short": "An amount of economic utility in some recognized currency",
            "definition": "An amount of economic utility in some recognized currency.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Money.value",
            "path": "Money.value",
            "short": "Numerical value (with implicit precision)",
            "definition": "Numerical value (with implicit precision).",
            "comment": "Monetary values have their own rules for handling precision (refer to standard accounting text books).",
            "requirements": "The amount of the currency. The value includes an implicit precision in the presentation of the value.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "decimal"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Money.currency",
            "path": "Money.currency",
            "short": "ISO 4217 Currency Code",
            "definition": "ISO 4217 Currency Code.",
            "requirements": "A code indicating the currency, taken from ISO 4217.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "CurrencyCode"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "required",
              "description": "A code indicating the currency, taken from ISO 4217.",
              "valueSet": "http://hl7.org/fhir/ValueSet/currencies|4.0.0"
            }
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:523
    /// <summary>
    /// Fhir complex 'Money'
    /// </summary>
    // 0. Money
    public class Money : FhirKhit.Maker.Common.Complex.ComplexBase                                                                          // MakerGen.cs:379
    {                                                                                                                                       // MakerGen.cs:380
        public class Money_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                           // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 1. Money.value
            public ElementDefinitionInfo Value;                                                                                             // MakerGen.cs:211
            // 2. Money.currency
            public ElementDefinitionInfo Currency;                                                                                          // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
            public Money_Elements()                                                                                                         // MakerGen.cs:387
            {                                                                                                                               // MakerGen.cs:388
                {                                                                                                                           // MakerGen.cs:226
                    // 1. Money.value
                    this.Value = new ElementDefinitionInfo                                                                                  // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Value",                                                                                                     // MakerGen.cs:230
                        Path= "Money.value",                                                                                                // MakerGen.cs:231
                        Id = "Money.value",                                                                                                 // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Decimal                                                                     // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 2. Money.currency
                    this.Currency = new ElementDefinitionInfo                                                                               // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Currency",                                                                                                  // MakerGen.cs:230
                        Path= "Money.currency",                                                                                             // MakerGen.cs:231
                        Id = "Money.currency",                                                                                              // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                base.Write(sDef);                                                                                                           // MakerGen.cs:395
                Value.Write(sDef);                                                                                                          // MakerGen.cs:215
                Currency.Write(sDef);                                                                                                       // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:397
        }                                                                                                                                   // MakerGen.cs:399
        public Money_Elements Elements                                                                                                      // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            get                                                                                                                             // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:404
                if (this.elements == null)                                                                                                  // MakerGen.cs:405
                    this.elements = new Money_Elements();                                                                                   // MakerGen.cs:406
                return this.elements;                                                                                                       // MakerGen.cs:407
            }                                                                                                                               // MakerGen.cs:408
        }                                                                                                                                   // MakerGen.cs:409
        Money_Elements elements;                                                                                                            // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
        public Money()                                                                                                                      // MakerGen.cs:413
        {                                                                                                                                   // MakerGen.cs:414
        }                                                                                                                                   // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:419
        {                                                                                                                                   // MakerGen.cs:420
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:421
            {                                                                                                                               // MakerGen.cs:422
                Path = "Money",                                                                                                             // MakerGen.cs:423
                ElementId = "Money"                                                                                                         // MakerGen.cs:424
            });                                                                                                                             // MakerGen.cs:425
            if (this.elements != null)                                                                                                      // MakerGen.cs:426
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:427
        }                                                                                                                                   // MakerGen.cs:428
    }                                                                                                                                       // MakerGen.cs:429
}                                                                                                                                           // MakerGen.cs:528
