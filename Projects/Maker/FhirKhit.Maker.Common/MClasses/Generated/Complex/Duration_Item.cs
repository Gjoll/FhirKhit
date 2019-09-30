using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;

namespace FhirKhit.Maker.Common
{
    /// <summary>
    /// Fhir primitive 'Duration'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "Duration",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/Duration",
    ///   "version": "4.0.0",
    ///   "name": "Duration",
    ///   "status": "active",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "Base StructureDefinition for Duration Type: A length of time.",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "complex-type",
    ///   "abstract": false,
    ///   "type": "Duration",
    ///   "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Quantity",
    ///   "derivation": "specialization",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "Duration",
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
    ///         "path": "Duration",
    ///         "short": "A length of time",
    ///         "definition": "A length of time.",
    ///         "min": 0,
    ///         "max": "*",
    ///         "constraint": [
    ///           {
    ///             "key": "drt-1",
    ///             "severity": "error",
    ///             "human": "There SHALL be a code if there is a value and it SHALL be an expression of time.  If system is present, it SHALL be UCUM.",
    ///             "expression": "code.exists() implies ((system = %ucum) and value.exists())",
    ///             "xpath": "(f:code or not(f:value)) and (not(exists(f:system)) or f:system/@value='http://unitsofmeasure.org')"
    ///           }
    ///         ],
    ///         "binding": {
    ///           "extension": [
    ///             {
    ///               "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-maxValueSet",
    ///               "valueCanonical": "http://hl7.org/fhir/ValueSet/all-time-units"
    ///             },
    ///             {
    ///               "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
    ///               "valueString": "DurationUnits"
    ///             }
    ///           ],
    ///           "strength": "extensible",
    ///           "description": "Appropriate units for Duration.",
    ///           "valueSet": "http://hl7.org/fhir/ValueSet/duration-units"
    ///         }
    ///       }
    ///     ]
    ///   }
    /// }
    /// </summary>
    public class Duration_Item : Complex_Item
    {
    }
}
