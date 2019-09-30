using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;

namespace FhirKhit.Maker.Common
{
    /// <summary>
    /// Fhir primitive 'Quantity'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "Quantity",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/Quantity",
    ///   "version": "4.0.0",
    ///   "name": "Quantity",
    ///   "status": "active",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "Base StructureDefinition for Quantity Type: A measured amount (or an amount that can potentially be measured). Note that measured amounts include amounts that are not precisely quantified, including amounts involving arbitrary units and floating currencies.",
    ///   "purpose": "Need to able to capture all sorts of measured values, even if the measured value are not precisely quantified. Values include exact measures such as 3.51g, customary units such as 3 tablets, and currencies such as $100.32USD.",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "complex-type",
    ///   "abstract": false,
    ///   "type": "Quantity",
    ///   "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
    ///   "derivation": "specialization",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "Quantity",
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
    ///         "path": "Quantity",
    ///         "short": "A measured or measurable amount",
    ///         "definition": "A measured amount (or an amount that can potentially be measured). Note that measured amounts include amounts that are not precisely quantified, including amounts involving arbitrary units and floating currencies.",
    ///         "comment": "The context of use may frequently define what kind of quantity this is and therefore what kind of units can be used. The context of use may also restrict the values for the comparator.",
    ///         "min": 0,
    ///         "max": "*",
    ///         "constraint": [
    ///           {
    ///             "key": "qty-3",
    ///             "severity": "error",
    ///             "human": "If a code for the unit is present, the system SHALL also be present",
    ///             "expression": "code.empty() or system.exists()",
    ///             "xpath": "not(exists(f:code)) or exists(f:system)"
    ///           }
    ///         ]
    ///       },
    ///       {
    ///         "id": "Quantity.value",
    ///         "path": "Quantity.value",
    ///         "short": "Numerical value (with implicit precision)",
    ///         "definition": "The value of the measured amount. The value includes an implicit precision in the presentation of the value.",
    ///         "comment": "The implicit precision in the value should always be honored. Monetary values have their own rules for handling precision (refer to standard accounting text books).",
    ///         "requirements": "Precision is handled implicitly in almost all cases of measurement.",
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
    ///         "id": "Quantity.comparator",
    ///         "path": "Quantity.comparator",
    ///         "short": "< | <= | >= | > - how to understand the value",
    ///         "definition": "How the value should be understood and represented - whether the actual value is greater or less than the stated value due to measurement issues; e.g. if the comparator is \"<\" , then the real value is < stated value.",
    ///         "requirements": "Need a framework for handling measures where the value is <5ug/L or >400mg/L due to the limitations of measuring methodology.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "code"
    ///           }
    ///         ],
    ///         "meaningWhenMissing": "If there is no comparator, then there is no modification of the value",
    ///         "isModifier": true,
    ///         "isModifierReason": "This is labeled as \"Is Modifier\" because the comparator modifies the interpretation of the value significantly. If there is no comparator, then there is no modification of the value",
    ///         "isSummary": true,
    ///         "binding": {
    ///           "extension": [
    ///             {
    ///               "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
    ///               "valueString": "QuantityComparator"
    ///             }
    ///           ],
    ///           "strength": "required",
    ///           "description": "How the Quantity should be understood and represented.",
    ///           "valueSet": "http://hl7.org/fhir/ValueSet/quantity-comparator|4.0.0"
    ///         }
    ///       },
    ///       {
    ///         "id": "Quantity.unit",
    ///         "extension": [
    ///           {
    ///             "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-translatable",
    ///             "valueBoolean": true
    ///           }
    ///         ],
    ///         "path": "Quantity.unit",
    ///         "short": "Unit representation",
    ///         "definition": "A human-readable form of the unit.",
    ///         "requirements": "There are many representations for units of measure and in many contexts, particular representations are fixed and required. I.e. mcg for micrograms.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "string"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "Quantity.system",
    ///         "path": "Quantity.system",
    ///         "short": "System that defines coded unit form",
    ///         "definition": "The identification of the system that provides the coded form of the unit.",
    ///         "requirements": "Need to know the system that defines the coded form of the unit.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "uri"
    ///           }
    ///         ],
    ///         "condition": [
    ///           "qty-3"
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "Quantity.code",
    ///         "path": "Quantity.code",
    ///         "short": "Coded form of the unit",
    ///         "definition": "A computer processable form of the unit in some unit representation system.",
    ///         "comment": "The preferred system is UCUM, but SNOMED CT can also be used (for customary units) or ISO 4217 for currency.  The context of use may additionally require a code from a particular system.",
    ///         "requirements": "Need a computable form of the unit that is fixed across all forms. UCUM provides this for quantities, but SNOMED CT provides many units of interest.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "code"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       }
    ///     ]
    ///   }
    /// }
    /// </summary>
    public class Quantity_Item : Complex_Item
    {
    }
}
