using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;

namespace FhirKhit.Maker.Common
{
    /// <summary>
    /// Fhir primitive 'MoneyQuantity'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "MoneyQuantity",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/MoneyQuantity",
    ///   "version": "4.0.0",
    ///   "name": "MoneyQuantity",
    ///   "status": "active",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "An amount of money. With regard to precision, see [Decimal Precision](datatypes.html#precision)",
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
    ///         "short": "An amount of money. With regard to precision, see [Decimal Precision](datatypes.html#precision)",
    ///         "definition": "There SHALL be a code if there is a value and it SHALL be an expression of currency.  If system is present, it SHALL be ISO 4217 (system = \"urn:iso:std:iso:4217\" - currency).",
    ///         "min": 0,
    ///         "max": "*",
    ///         "constraint": [
    ///           {
    ///             "key": "mtqy-1",
    ///             "severity": "error",
    ///             "human": "There SHALL be a code if there is a value and it SHALL be an expression of currency.  If system is present, it SHALL be ISO 4217 (system = \"urn:iso:std:iso:4217\" - currency).",
    ///             "expression": "(code.exists() or value.empty()) and (system.empty() or system = 'urn:iso:std:iso:4217')",
    ///             "xpath": "(f:code or not(f:value)) and (not(exists(f:system)) or f:system/@value='urn:iso:std:iso:4217')"
    ///           }
    ///         ],
    ///         "isModifier": false
    ///       }
    ///     ]
    ///   }
    /// }
    /// </summary>
    public class MoneyQuantity_Type : Complex_Type
    {
    }
}
