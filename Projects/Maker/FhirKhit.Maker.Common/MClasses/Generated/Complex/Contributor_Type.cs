using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;

namespace FhirKhit.Maker.Common
{
    /// <summary>
    /// Fhir primitive 'Contributor'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "Contributor",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/Contributor",
    ///   "version": "4.0.0",
    ///   "name": "Contributor",
    ///   "status": "draft",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "Base StructureDefinition for Contributor Type: A contributor to the content of a knowledge asset, including authors, editors, reviewers, and endorsers.",
    ///   "purpose": "Need to track contributor information in the same way across multiple resources.",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "complex-type",
    ///   "abstract": false,
    ///   "type": "Contributor",
    ///   "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
    ///   "derivation": "specialization",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "Contributor",
    ///         "extension": [
    ///           {
    ///             "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-standards-status",
    ///             "valueCode": "trial-use"
    ///           }
    ///         ],
    ///         "path": "Contributor",
    ///         "short": "Contributor information",
    ///         "definition": "A contributor to the content of a knowledge asset, including authors, editors, reviewers, and endorsers.",
    ///         "min": 0,
    ///         "max": "*"
    ///       },
    ///       {
    ///         "id": "Contributor.type",
    ///         "path": "Contributor.type",
    ///         "short": "author | editor | reviewer | endorser",
    ///         "definition": "The type of contributor.",
    ///         "min": 1,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "code"
    ///           }
    ///         ],
    ///         "isSummary": true,
    ///         "binding": {
    ///           "extension": [
    ///             {
    ///               "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
    ///               "valueString": "ContributorType"
    ///             }
    ///           ],
    ///           "strength": "required",
    ///           "description": "The type of contributor.",
    ///           "valueSet": "http://hl7.org/fhir/ValueSet/contributor-type|4.0.0"
    ///         }
    ///       },
    ///       {
    ///         "id": "Contributor.name",
    ///         "path": "Contributor.name",
    ///         "short": "Who contributed the content",
    ///         "definition": "The name of the individual or organization responsible for the contribution.",
    ///         "min": 1,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "string"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "Contributor.contact",
    ///         "path": "Contributor.contact",
    ///         "short": "Contact details of the contributor",
    ///         "definition": "Contact details to assist a user in finding and communicating with the contributor.",
    ///         "min": 0,
    ///         "max": "*",
    ///         "type": [
    ///           {
    ///             "code": "ContactDetail"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       }
    ///     ]
    ///   }
    /// }
    /// </summary>
    public class Contributor_Type : Complex_Type
    {
    }
}
