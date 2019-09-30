using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;

namespace FhirKhit.Maker.Common
{
    /// <summary>
    /// Fhir primitive 'SimpleQuantity'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "SimpleQuantity",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/SimpleQuantity",
    ///   "version": "4.0.0",
    ///   "name": "SimpleQuantity",
    ///   "status": "active",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "A fixed quantity (no comparator)",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "complex-type",
    ///   "abstract": false,
    ///   "type": "Quantity",
    ///   "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Quantity",
    ///   "derivation": "constraint",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "Quantity",
    ///         "path": "Quantity",
    ///         "short": "A fixed quantity (no comparator)",
    ///         "definition": "The comparator is not used on a SimpleQuantity",
    ///         "min": 0,
    ///         "max": "*",
    ///         "constraint": [
    ///           {
    ///             "key": "sqty-1",
    ///             "severity": "error",
    ///             "human": "The comparator is not used on a SimpleQuantity",
    ///             "expression": "comparator.empty()",
    ///             "xpath": "not(exists(f:comparator))"
    ///           }
    ///         ],
    ///         "isModifier": false
    ///       },
    ///       {
    ///         "id": "Quantity.comparator",
    ///         "path": "Quantity.comparator",
    ///         "definition": "Not allowed to be used in this context",
    ///         "max": "0"
    ///       }
    ///     ]
    ///   }
    /// }
    /// </summary>
    public class SimpleQuantity_Item : Complex_Item
    {
    }
}
