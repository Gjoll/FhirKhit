using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;

namespace FhirKhit.Maker.Common
{
    /// <summary>
    /// Fhir primitive 'Count'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "Count",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/Count",
    ///   "version": "4.0.0",
    ///   "name": "Count",
    ///   "status": "draft",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "Base StructureDefinition for Count Type: A measured amount (or an amount that can potentially be measured). Note that measured amounts include amounts that are not precisely quantified, including amounts involving arbitrary units and floating currencies.",
    ///   "purpose": "Need to able to capture all sorts of measured values, even if the measured value are not precisely quantified. Values include exact measures such as 3.51g, customary units such as 3 tablets, and currencies such as $100.32USD.",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "complex-type",
    ///   "abstract": false,
    ///   "type": "Count",
    ///   "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Quantity",
    ///   "derivation": "specialization",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "Count",
    ///         "extension": [
    ///           {
    ///             "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-standards-status",
    ///             "valueCode": "trial-use"
    ///           }
    ///         ],
    ///         "path": "Count",
    ///         "short": "A measured or measurable amount",
    ///         "definition": "A measured amount (or an amount that can potentially be measured). Note that measured amounts include amounts that are not precisely quantified, including amounts involving arbitrary units and floating currencies.",
    ///         "comment": "The context of use may frequently define what kind of quantity this is and therefore what kind of units can be used. The context of use may also restrict the values for the comparator.",
    ///         "min": 0,
    ///         "max": "*",
    ///         "constraint": [
    ///           {
    ///             "key": "cnt-3",
    ///             "severity": "error",
    ///             "human": "There SHALL be a code with a value of \"1\" if there is a value. If system is present, it SHALL be UCUM.  If present, the value SHALL be a whole number.",
    ///             "expression": "(code.exists() or value.empty()) and (system.empty() or system = %ucum) and (code.empty() or code = '1') and (value.empty() or value.hasValue().not() or value.toString().contains('.').not())",
    ///             "xpath": "(f:code or not(f:value)) and (not(exists(f:system)) or (f:system/@value='http://unitsofmeasure.org' and f:code/@value='1')) and not(contains(f:value/@value, '.'))"
    ///           }
    ///         ]
    ///       }
    ///     ]
    ///   }
    /// }
    /// </summary>
    public class Count_Type : Complex_Type
    {
    }
}
