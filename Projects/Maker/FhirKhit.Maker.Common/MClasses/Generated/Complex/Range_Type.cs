using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;

namespace FhirKhit.Maker.Common
{
    /// <summary>
    /// Fhir primitive 'Range'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "Range",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/Range",
    ///   "version": "4.0.0",
    ///   "name": "Range",
    ///   "status": "active",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "Base StructureDefinition for Range Type: A set of ordered Quantities defined by a low and high limit.",
    ///   "purpose": "Need to be able to specify ranges of values.",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "complex-type",
    ///   "abstract": false,
    ///   "type": "Range",
    ///   "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
    ///   "derivation": "specialization",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "Range",
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
    ///         "path": "Range",
    ///         "short": "Set of values bounded by low and high",
    ///         "definition": "A set of ordered Quantities defined by a low and high limit.",
    ///         "comment": "The stated low and high value are assumed to have arbitrarily high precision when it comes to determining which values are in the range. I.e. 1.99 is not in the range 2 -> 3.",
    ///         "min": 0,
    ///         "max": "*",
    ///         "constraint": [
    ///           {
    ///             "key": "rng-2",
    ///             "severity": "error",
    ///             "human": "If present, low SHALL have a lower value than high",
    ///             "expression": "low.empty() or high.empty() or (low <= high)",
    ///             "xpath": "not(exists(f:low/f:value/@value)) or not(exists(f:high/f:value/@value)) or (number(f:low/f:value/@value) <= number(f:high/f:value/@value))"
    ///           }
    ///         ]
    ///       },
    ///       {
    ///         "id": "Range.low",
    ///         "path": "Range.low",
    ///         "short": "Low limit",
    ///         "definition": "The low limit. The boundary is inclusive.",
    ///         "comment": "If the low element is missing, the low boundary is not known.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "Quantity",
    ///             "profile": [
    ///               "http://hl7.org/fhir/StructureDefinition/SimpleQuantity"
    ///             ]
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "Range.high",
    ///         "path": "Range.high",
    ///         "short": "High limit",
    ///         "definition": "The high limit. The boundary is inclusive.",
    ///         "comment": "If the high element is missing, the high boundary is not known.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "Quantity",
    ///             "profile": [
    ///               "http://hl7.org/fhir/StructureDefinition/SimpleQuantity"
    ///             ]
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       }
    ///     ]
    ///   }
    /// }
    /// </summary>
    public class Range_Type : Complex_Type
    {
    }
}
