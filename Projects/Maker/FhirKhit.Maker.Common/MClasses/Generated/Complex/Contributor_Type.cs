using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
                                                                                                                                            // MakerGen.cs:267
namespace FhirKhit.Maker.Common                                                                                                             // MakerGen.cs:268
{                                                                                                                                           // MakerGen.cs:269
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
    // 0. Contributor
    public class Contributor_Type : Complex_Type                                                                                            // MakerGen.cs:220
    {                                                                                                                                       // MakerGen.cs:221
        // 1. Contributor.type
        public ElementInstance Type;                                                                                                        // MakerGen.cs:203
        // 2. Contributor.name
        public ElementInstance Name;                                                                                                        // MakerGen.cs:203
        // 3. Contributor.contact
        public ElementInstance Contact;                                                                                                     // MakerGen.cs:203
        public Contributor_Type()                                                                                                           // MakerGen.cs:229
        {                                                                                                                                   // MakerGen.cs:230
        }                                                                                                                                   // MakerGen.cs:244
    }                                                                                                                                       // MakerGen.cs:225
}                                                                                                                                           // MakerGen.cs:275
