using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;

namespace FhirKhit.Maker.Common
{
    /// <summary>
    /// Fhir primitive 'UsageContext'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "UsageContext",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/UsageContext",
    ///   "version": "4.0.0",
    ///   "name": "UsageContext",
    ///   "status": "draft",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "Base StructureDefinition for UsageContext Type: Specifies clinical/business/etc. metadata that can be used to retrieve, index and/or categorize an artifact. This metadata can either be specific to the applicable population (e.g., age category, DRG) or the specific context of care (e.g., venue, care setting, provider of care).",
    ///   "purpose": "Consumers of the resource must be able to determine the intended applicability for the resource. Ideally, this information would be used programmatically to determine when and how it should be incorporated or exposed.",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "complex-type",
    ///   "abstract": false,
    ///   "type": "UsageContext",
    ///   "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
    ///   "derivation": "specialization",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "UsageContext",
    ///         "extension": [
    ///           {
    ///             "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-standards-status",
    ///             "valueCode": "trial-use"
    ///           }
    ///         ],
    ///         "path": "UsageContext",
    ///         "short": "Describes the context of use for a conformance or knowledge resource",
    ///         "definition": "Specifies clinical/business/etc. metadata that can be used to retrieve, index and/or categorize an artifact. This metadata can either be specific to the applicable population (e.g., age category, DRG) or the specific context of care (e.g., venue, care setting, provider of care).",
    ///         "min": 0,
    ///         "max": "*"
    ///       },
    ///       {
    ///         "id": "UsageContext.code",
    ///         "path": "UsageContext.code",
    ///         "short": "Type of context being specified",
    ///         "definition": "A code that identifies the type of context being specified by this usage context.",
    ///         "min": 1,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "Coding"
    ///           }
    ///         ],
    ///         "isSummary": true,
    ///         "binding": {
    ///           "extension": [
    ///             {
    ///               "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
    ///               "valueString": "UsageContextType"
    ///             }
    ///           ],
    ///           "strength": "extensible",
    ///           "description": "A code that specifies a type of context being specified by a usage context.",
    ///           "valueSet": "http://hl7.org/fhir/ValueSet/usage-context-type"
    ///         }
    ///       },
    ///       {
    ///         "id": "UsageContext.value[x]",
    ///         "path": "UsageContext.value[x]",
    ///         "short": "Value that defines the context",
    ///         "definition": "A value that defines the context specified in this context of use. The interpretation of the value is defined by the code.",
    ///         "min": 1,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "CodeableConcept"
    ///           },
    ///           {
    ///             "code": "Quantity"
    ///           },
    ///           {
    ///             "code": "Range"
    ///           },
    ///           {
    ///             "code": "Reference",
    ///             "targetProfile": [
    ///               "http://hl7.org/fhir/StructureDefinition/PlanDefinition",
    ///               "http://hl7.org/fhir/StructureDefinition/ResearchStudy",
    ///               "http://hl7.org/fhir/StructureDefinition/InsurancePlan",
    ///               "http://hl7.org/fhir/StructureDefinition/HealthcareService",
    ///               "http://hl7.org/fhir/StructureDefinition/Group",
    ///               "http://hl7.org/fhir/StructureDefinition/Location",
    ///               "http://hl7.org/fhir/StructureDefinition/Organization"
    ///             ]
    ///           }
    ///         ],
    ///         "isSummary": true,
    ///         "binding": {
    ///           "extension": [
    ///             {
    ///               "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
    ///               "valueString": "UsageContextValue"
    ///             }
    ///           ],
    ///           "strength": "example",
    ///           "description": "A code that defines the specific value for the context being specified.",
    ///           "valueSet": "http://hl7.org/fhir/ValueSet/use-context"
    ///         }
    ///       }
    ///     ]
    ///   }
    /// }
    /// </summary>
    public class UsageContext_Type : Complex_Type
    {
    }
}
