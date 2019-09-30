using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;

namespace FhirKhit.Maker.Common
{
    /// <summary>
    /// Fhir primitive 'Distance'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "Distance",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/Distance",
    ///   "version": "4.0.0",
    ///   "name": "Distance",
    ///   "status": "draft",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "Base StructureDefinition for Distance Type: A length - a value with a unit that is a physical distance.",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "complex-type",
    ///   "abstract": false,
    ///   "type": "Distance",
    ///   "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Quantity",
    ///   "derivation": "specialization",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "Distance",
    ///         "extension": [
    ///           {
    ///             "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-standards-status",
    ///             "valueCode": "trial-use"
    ///           }
    ///         ],
    ///         "path": "Distance",
    ///         "short": "A length - a value with a unit that is a physical distance",
    ///         "definition": "A length - a value with a unit that is a physical distance.",
    ///         "min": 0,
    ///         "max": "*",
    ///         "constraint": [
    ///           {
    ///             "key": "dis-1",
    ///             "severity": "error",
    ///             "human": "There SHALL be a code if there is a value and it SHALL be an expression of length.  If system is present, it SHALL be UCUM.",
    ///             "expression": "(code.exists() or value.empty()) and (system.empty() or system = %ucum)",
    ///             "xpath": "(f:code or not(f:value)) and (not(exists(f:system)) or f:system/@value='http://unitsofmeasure.org')"
    ///           }
    ///         ],
    ///         "binding": {
    ///           "extension": [
    ///             {
    ///               "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-maxValueSet",
    ///               "valueCanonical": "http://hl7.org/fhir/ValueSet/all-distance-units"
    ///             },
    ///             {
    ///               "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
    ///               "valueString": "DistanceUnits"
    ///             }
    ///           ],
    ///           "strength": "extensible",
    ///           "description": "Appropriate units for Distance.",
    ///           "valueSet": "http://hl7.org/fhir/ValueSet/distance-units"
    ///         }
    ///       }
    ///     ]
    ///   }
    /// }
    /// </summary>
    public class Distance_Item : Complex_Item
    {
    }
}
