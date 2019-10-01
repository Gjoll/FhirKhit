using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
                                                                                                                                            // MakerGen.cs:381
namespace FhirKhit.Maker.Common                                                                                                             // MakerGen.cs:382
{                                                                                                                                           // MakerGen.cs:383
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
    public class ContactDetail_Type : MakerComplex_Type                                                                                     // MakerGen.cs:337
    {                                                                                                                                       // MakerGen.cs:338
        // 1. ContactDetail.name
        public MakerElementInstance Name;                                                                                                   // MakerGen.cs:217
        // 2. ContactDetail.telecom
        public MakerElementInstance Telecom;                                                                                                // MakerGen.cs:217
        public ContactDetail_Type()                                                                                                         // MakerGen.cs:346
        {                                                                                                                                   // MakerGen.cs:347
            {                                                                                                                               // MakerGen.cs:228
                // 1. ContactDetail.name
                this.Name = new MakerElementInstance                                                                                        // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Name",                                                                                                          // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new String_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 2. ContactDetail.telecom
                this.Telecom = new MakerElementInstance                                                                                     // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Telecom",                                                                                                       // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = -1,                                                                                                               // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
        }                                                                                                                                   // MakerGen.cs:358
    }                                                                                                                                       // MakerGen.cs:342
}                                                                                                                                           // MakerGen.cs:389
