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
    #endregion                                                                                                                              // MakerGen.cs:502
    /// <summary>
    /// Fhir complex 'Money'
    /// </summary>
    // 0. Money
    public partial class Type_Money : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:381
    {                                                                                                                                       // MakerGen.cs:382
        // 1. Money.value
        public ElementDefinitionInfo Element_Value;                                                                                         // MakerGen.cs:217
        // 2. Money.currency
        public ElementDefinitionInfo Element_Currency;                                                                                      // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:388
        {                                                                                                                                   // MakerGen.cs:389
            base.Write(sDef);                                                                                                               // MakerGen.cs:390
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:391
            {                                                                                                                               // MakerGen.cs:392
                Path = "Money",                                                                                                             // MakerGen.cs:393
                ElementId = "Money"                                                                                                         // MakerGen.cs:394
            });                                                                                                                             // MakerGen.cs:395
            Element_Value.Write(sDef);                                                                                                      // MakerGen.cs:221
            Element_Currency.Write(sDef);                                                                                                   // MakerGen.cs:221
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
        public Type_Money()                                                                                                                 // MakerGen.cs:400
        {                                                                                                                                   // MakerGen.cs:401
            {                                                                                                                               // MakerGen.cs:232
                // 1. Money.value
                this.Element_Value = new ElementDefinitionInfo                                                                              // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Value",                                                                                                 // MakerGen.cs:236
                    Path= "Money.value",                                                                                                    // MakerGen.cs:237
                    Id = "Money.value",                                                                                                     // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Decimal                                                               // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 2. Money.currency
                this.Element_Currency = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Currency",                                                                                              // MakerGen.cs:236
                    Path= "Money.currency",                                                                                                 // MakerGen.cs:237
                    Id = "Money.currency",                                                                                                  // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
        }                                                                                                                                   // MakerGen.cs:403
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:507
