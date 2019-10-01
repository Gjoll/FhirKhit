using System;                                                                                                                               // MakerGen.cs:482
using System.Diagnostics;                                                                                                                   // MakerGen.cs:483
using System.IO;                                                                                                                            // MakerGen.cs:484
using System.Linq;                                                                                                                          // MakerGen.cs:485
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:486
                                                                                                                                            // MakerGen.cs:487
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:488
{                                                                                                                                           // MakerGen.cs:489
    #region Json                                                                                                                            // MakerGen.cs:490
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
    #endregion                                                                                                                              // MakerGen.cs:494
    /// <summary>
    /// Fhir complex 'Money'
    /// </summary>
    // 0. Money
    public class Type_Money : FhirKhit.Maker.Common.Complex.ComplexBase                                                                     // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        // 1. Money.value
        public ElementDefinitionInfo Element_Value;                                                                                         // MakerGen.cs:212
        // 2. Money.currency
        public ElementDefinitionInfo Element_Currency;                                                                                      // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            base.Write(sDef);                                                                                                               // MakerGen.cs:385
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:386
            {                                                                                                                               // MakerGen.cs:387
                Path = "Money",                                                                                                             // MakerGen.cs:388
                ElementId = "Money"                                                                                                         // MakerGen.cs:389
            });                                                                                                                             // MakerGen.cs:390
            Element_Value.Write(sDef);                                                                                                      // MakerGen.cs:216
            Element_Currency.Write(sDef);                                                                                                   // MakerGen.cs:216
        }                                                                                                                                   // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
        public Type_Money()                                                                                                                 // MakerGen.cs:395
        {                                                                                                                                   // MakerGen.cs:396
            {                                                                                                                               // MakerGen.cs:227
                // 1. Money.value
                this.Element_Value = new ElementDefinitionInfo                                                                              // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Value",                                                                                                 // MakerGen.cs:231
                    Path= "Money.value",                                                                                                    // MakerGen.cs:232
                    Id = "Money.value",                                                                                                     // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Decimal                                                               // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 2. Money.currency
                this.Element_Currency = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Currency",                                                                                              // MakerGen.cs:231
                    Path= "Money.currency",                                                                                                 // MakerGen.cs:232
                    Id = "Money.currency",                                                                                                  // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
        }                                                                                                                                   // MakerGen.cs:398
    }                                                                                                                                       // MakerGen.cs:400
}                                                                                                                                           // MakerGen.cs:499
