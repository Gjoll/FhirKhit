using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;

namespace FhirKhit.Maker.Common
{
    /// <summary>
    /// Fhir primitive 'ContactDetail'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "ContactDetail",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/ContactDetail",
    ///   "version": "4.0.0",
    ///   "name": "ContactDetail",
    ///   "status": "active",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "Base StructureDefinition for ContactDetail Type: Specifies contact information for a person or organization.",
    ///   "purpose": "Need to track contact information in the same way across multiple resources.",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "complex-type",
    ///   "abstract": false,
    ///   "type": "ContactDetail",
    ///   "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
    ///   "derivation": "specialization",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "ContactDetail",
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
    ///         "path": "ContactDetail",
    ///         "short": "Contact information",
    ///         "definition": "Specifies contact information for a person or organization.",
    ///         "min": 0,
    ///         "max": "*"
    ///       },
    ///       {
    ///         "id": "ContactDetail.name",
    ///         "path": "ContactDetail.name",
    ///         "short": "Name of an individual to contact",
    ///         "definition": "The name of an individual to contact.",
    ///         "comment": "If there is no named individual, the telecom information is for the organization as a whole.",
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
    ///         "id": "ContactDetail.telecom",
    ///         "path": "ContactDetail.telecom",
    ///         "short": "Contact details for individual or organization",
    ///         "definition": "The contact details for the individual (if a name was provided) or the organization.",
    ///         "min": 0,
    ///         "max": "*",
    ///         "type": [
    ///           {
    ///             "code": "ContactPoint"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       }
    ///     ]
    ///   }
    /// }
    /// </summary>
    public class ContactDetail_Item : Complex_Item
    {
    }
}
