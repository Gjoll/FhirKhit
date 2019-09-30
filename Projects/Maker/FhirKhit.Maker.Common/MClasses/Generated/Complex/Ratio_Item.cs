using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;

namespace FhirKhit.Maker.Common
{
    /// <summary>
    /// Fhir primitive 'Ratio'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "Ratio",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/Ratio",
    ///   "version": "4.0.0",
    ///   "name": "Ratio",
    ///   "status": "active",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "Base StructureDefinition for Ratio Type: A relationship of two Quantity values - expressed as a numerator and a denominator.",
    ///   "purpose": "Need to able to capture ratios for some measurements (titers) and some rates (costs).",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "complex-type",
    ///   "abstract": false,
    ///   "type": "Ratio",
    ///   "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
    ///   "derivation": "specialization",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "Ratio",
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
    ///         "path": "Ratio",
    ///         "short": "A ratio of two Quantity values - a numerator and a denominator",
    ///         "definition": "A relationship of two Quantity values - expressed as a numerator and a denominator.",
    ///         "comment": "The Ratio datatype should only be used to express a relationship of two numbers if the relationship cannot be suitably expressed using a Quantity and a common unit.  Where the denominator value is known to be fixed to \"1\", Quantity should be used instead of Ratio.",
    ///         "min": 0,
    ///         "max": "*",
    ///         "constraint": [
    ///           {
    ///             "key": "rat-1",
    ///             "severity": "error",
    ///             "human": "Numerator and denominator SHALL both be present, or both are absent. If both are absent, there SHALL be some extension present",
    ///             "expression": "(numerator.empty() xor denominator.exists()) and (numerator.exists() or extension.exists())",
    ///             "xpath": "(count(f:numerator) = count(f:denominator)) and ((count(f:numerator) > 0) or (count(f:extension) > 0))"
    ///           }
    ///         ]
    ///       },
    ///       {
    ///         "id": "Ratio.numerator",
    ///         "path": "Ratio.numerator",
    ///         "short": "Numerator value",
    ///         "definition": "The value of the numerator.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "Quantity"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "Ratio.denominator",
    ///         "path": "Ratio.denominator",
    ///         "short": "Denominator value",
    ///         "definition": "The value of the denominator.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "Quantity"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       }
    ///     ]
    ///   }
    /// }
    /// </summary>
    public class Ratio_Item : Complex_Item
    {
    }
}
