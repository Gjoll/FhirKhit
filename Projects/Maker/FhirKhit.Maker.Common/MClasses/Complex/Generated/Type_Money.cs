using System;                                                                                                                               // MakerGen.cs:508
using System.Diagnostics;                                                                                                                   // MakerGen.cs:509
using System.IO;                                                                                                                            // MakerGen.cs:510
using System.Linq;                                                                                                                          // MakerGen.cs:511
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:512
                                                                                                                                            // MakerGen.cs:513
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:514
{                                                                                                                                           // MakerGen.cs:515
    #region Json                                                                                                                            // MakerGen.cs:516
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
    #endregion                                                                                                                              // MakerGen.cs:520
    /// <summary>
    /// Fhir complex 'Money'
    /// </summary>
    // 0. Money
    public class Type_Money : FhirKhit.Maker.Common.Complex.ComplexBase                                                                     // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        public class Type_Money_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                      // MakerGen.cs:378
        {                                                                                                                                   // MakerGen.cs:379
            // 1. Money.value
            public ElementDefinitionInfo Element_Value;                                                                                     // MakerGen.cs:211
            // 2. Money.currency
            public ElementDefinitionInfo Element_Currency;                                                                                  // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
            public Type_Money_Elements()                                                                                                    // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:226
                    // 1. Money.value
                    this.Element_Value = new ElementDefinitionInfo                                                                          // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Value",                                                                                             // MakerGen.cs:230
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
                    this.Element_Currency = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Currency",                                                                                          // MakerGen.cs:230
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
            }                                                                                                                               // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                Element_Value.Write(sDef);                                                                                                  // MakerGen.cs:215
                Element_Currency.Write(sDef);                                                                                               // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:394
        }                                                                                                                                   // MakerGen.cs:396
        public Type_Money_Elements Elements                                                                                                 // MakerGen.cs:398
        {                                                                                                                                   // MakerGen.cs:399
            get                                                                                                                             // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                if (this.elements == null)                                                                                                  // MakerGen.cs:402
                    this.elements = new Type_Money_Elements();                                                                              // MakerGen.cs:403
                return this.elements;                                                                                                       // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:406
        Type_Money_Elements elements;                                                                                                       // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
        public Type_Money()                                                                                                                 // MakerGen.cs:410
        {                                                                                                                                   // MakerGen.cs:411
        }                                                                                                                                   // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:416
        {                                                                                                                                   // MakerGen.cs:417
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:418
            {                                                                                                                               // MakerGen.cs:419
                Path = "Money",                                                                                                             // MakerGen.cs:420
                ElementId = "Money"                                                                                                         // MakerGen.cs:421
            });                                                                                                                             // MakerGen.cs:422
            if (this.elements != null)                                                                                                      // MakerGen.cs:423
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:424
        }                                                                                                                                   // MakerGen.cs:425
    }                                                                                                                                       // MakerGen.cs:426
}                                                                                                                                           // MakerGen.cs:525
