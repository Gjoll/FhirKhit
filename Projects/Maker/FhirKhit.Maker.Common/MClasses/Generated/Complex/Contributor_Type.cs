using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
                                                                                                                                            // MakerGen.cs:381
namespace FhirKhit.Maker.Common                                                                                                             // MakerGen.cs:382
{                                                                                                                                           // MakerGen.cs:383
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
    public class Contributor_Type : MakerComplex_Type                                                                                       // MakerGen.cs:337
    {                                                                                                                                       // MakerGen.cs:338
        // 1. Contributor.type
        public MakerElementInstance Type;                                                                                                   // MakerGen.cs:217
        // 2. Contributor.name
        public MakerElementInstance Name;                                                                                                   // MakerGen.cs:217
        // 3. Contributor.contact
        public MakerElementInstance Contact;                                                                                                // MakerGen.cs:217
        public Contributor_Type()                                                                                                           // MakerGen.cs:346
        {                                                                                                                                   // MakerGen.cs:347
            {                                                                                                                               // MakerGen.cs:228
                // 1. Contributor.type
                this.Type = new MakerElementInstance                                                                                        // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Type",                                                                                                          // MakerGen.cs:232
                    Min = 1,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new Code_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 2. Contributor.name
                this.Name = new MakerElementInstance                                                                                        // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Name",                                                                                                          // MakerGen.cs:232
                    Min = 1,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new String_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 3. Contributor.contact
                this.Contact = new MakerElementInstance                                                                                     // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Contact",                                                                                                       // MakerGen.cs:232
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
