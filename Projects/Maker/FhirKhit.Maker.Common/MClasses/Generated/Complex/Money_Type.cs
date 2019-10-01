using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
                                                                                                                                            // MakerGen.cs:381
namespace FhirKhit.Maker.Common                                                                                                             // MakerGen.cs:382
{                                                                                                                                           // MakerGen.cs:383
    /// <summary>
    /// Fhir primitive 'Money'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "Money",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/Money",
    ///   "version": "4.0.0",
    ///   "name": "Money",
    ///   "status": "active",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "Base StructureDefinition for Money Type: An amount of economic utility in some recognized currency.",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "complex-type",
    ///   "abstract": false,
    ///   "type": "Money",
    ///   "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
    ///   "derivation": "specialization",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "Money",
    ///         "path": "Money",
    ///         "short": "An amount of economic utility in some recognized currency",
    ///         "definition": "An amount of economic utility in some recognized currency.",
    ///         "min": 0,
    ///         "max": "*"
    ///       },
    ///       {
    ///         "id": "Money.value",
    ///         "path": "Money.value",
    ///         "short": "Numerical value (with implicit precision)",
    ///         "definition": "Numerical value (with implicit precision).",
    ///         "comment": "Monetary values have their own rules for handling precision (refer to standard accounting text books).",
    ///         "requirements": "The amount of the currency. The value includes an implicit precision in the presentation of the value.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "decimal"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "Money.currency",
    ///         "path": "Money.currency",
    ///         "short": "ISO 4217 Currency Code",
    ///         "definition": "ISO 4217 Currency Code.",
    ///         "requirements": "A code indicating the currency, taken from ISO 4217.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "code"
    ///           }
    ///         ],
    ///         "isSummary": true,
    ///         "binding": {
    ///           "extension": [
    ///             {
    ///               "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
    ///               "valueString": "CurrencyCode"
    ///             },
    ///             {
    ///               "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
    ///               "valueBoolean": true
    ///             }
    ///           ],
    ///           "strength": "required",
    ///           "description": "A code indicating the currency, taken from ISO 4217.",
    ///           "valueSet": "http://hl7.org/fhir/ValueSet/currencies|4.0.0"
    ///         }
    ///       }
    ///     ]
    ///   }
    /// }
    /// </summary>
    // 0. Money
    public class Money_Type : MakerComplex_Type                                                                                             // MakerGen.cs:337
    {                                                                                                                                       // MakerGen.cs:338
        // 1. Money.value
        public MakerElementInstance Value;                                                                                                  // MakerGen.cs:217
        // 2. Money.currency
        public MakerElementInstance Currency;                                                                                               // MakerGen.cs:217
        public Money_Type()                                                                                                                 // MakerGen.cs:346
        {                                                                                                                                   // MakerGen.cs:347
            {                                                                                                                               // MakerGen.cs:228
                // 1. Money.value
                this.Value = new MakerElementInstance                                                                                       // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Value",                                                                                                         // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new Decimal_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 2. Money.currency
                this.Currency = new MakerElementInstance                                                                                    // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Currency",                                                                                                      // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new Code_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
        }                                                                                                                                   // MakerGen.cs:358
    }                                                                                                                                       // MakerGen.cs:342
}                                                                                                                                           // MakerGen.cs:389
