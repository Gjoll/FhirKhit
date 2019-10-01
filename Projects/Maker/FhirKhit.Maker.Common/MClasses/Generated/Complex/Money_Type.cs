using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
                                                                                                                                            // MakerGen.cs:269
namespace FhirKhit.Maker.Common                                                                                                             // MakerGen.cs:270
{                                                                                                                                           // MakerGen.cs:271
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
    public class Money_Type : Complex_Type                                                                                                  // MakerGen.cs:225
    {                                                                                                                                       // MakerGen.cs:226
        // 1. Money.value
        public ElementInstance Value;                                                                                                       // MakerGen.cs:208
        // 2. Money.currency
        public ElementInstance Currency;                                                                                                    // MakerGen.cs:208
        public Money_Type()                                                                                                                 // MakerGen.cs:234
        {                                                                                                                                   // MakerGen.cs:235
        }                                                                                                                                   // MakerGen.cs:246
    }                                                                                                                                       // MakerGen.cs:230
}                                                                                                                                           // MakerGen.cs:277
