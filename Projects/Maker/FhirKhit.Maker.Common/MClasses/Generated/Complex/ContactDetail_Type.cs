using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
                                                                                                                                            // MakerGen.cs:269
namespace FhirKhit.Maker.Common                                                                                                             // MakerGen.cs:270
{                                                                                                                                           // MakerGen.cs:271
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
    // 0. ContactDetail
    public class ContactDetail_Type : Complex_Type                                                                                          // MakerGen.cs:225
    {                                                                                                                                       // MakerGen.cs:226
        // 1. ContactDetail.name
        public ElementInstance Name;                                                                                                        // MakerGen.cs:208
        // 2. ContactDetail.telecom
        public ElementInstance Telecom;                                                                                                     // MakerGen.cs:208
        public ContactDetail_Type()                                                                                                         // MakerGen.cs:234
        {                                                                                                                                   // MakerGen.cs:235
        }                                                                                                                                   // MakerGen.cs:246
    }                                                                                                                                       // MakerGen.cs:230
}                                                                                                                                           // MakerGen.cs:277
