using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;

namespace FhirKhit.Maker.Common
{
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
    ///         "extension": [
    ///           {
    ///             "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-standards-status",
    ///             "valueCode": "normative"
    ///           },
    ///           {
    ///             "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-normative-version",
    ///             "valueCode": "4.0.0"
    ///           }
    ///         ],
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
    public class Money_Item : Complex_Item
    {
    }
}
