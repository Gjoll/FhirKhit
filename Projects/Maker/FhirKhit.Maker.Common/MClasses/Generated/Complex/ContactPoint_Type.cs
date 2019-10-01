using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
                                                                                                                                            // MakerGen.cs:381
namespace FhirKhit.Maker.Common                                                                                                             // MakerGen.cs:382
{                                                                                                                                           // MakerGen.cs:383
    /// <summary>
    /// Fhir primitive 'ContactPoint'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "ContactPoint",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/ContactPoint",
    ///   "version": "4.0.0",
    ///   "name": "ContactPoint",
    ///   "status": "active",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "Base StructureDefinition for ContactPoint Type: Details for all kinds of technology mediated contact points for a person or organization, including telephone, email, etc.",
    ///   "purpose": "Need to track phone, fax, mobile, sms numbers, email addresses, twitter tags, etc.",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "complex-type",
    ///   "abstract": false,
    ///   "type": "ContactPoint",
    ///   "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
    ///   "derivation": "specialization",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "ContactPoint",
    ///         "path": "ContactPoint",
    ///         "short": "Details of a Technology mediated contact point (phone, fax, email, etc.)",
    ///         "definition": "Details for all kinds of technology mediated contact points for a person or organization, including telephone, email, etc.",
    ///         "min": 0,
    ///         "max": "*"
    ///       },
    ///       {
    ///         "id": "ContactPoint.system",
    ///         "path": "ContactPoint.system",
    ///         "short": "phone | fax | email | pager | url | sms | other",
    ///         "definition": "Telecommunications form for contact point - what communications system is required to make use of the contact.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "code"
    ///           }
    ///         ],
    ///         "condition": [
    ///           "cpt-2"
    ///         ],
    ///         "isSummary": true,
    ///         "binding": {
    ///           "extension": [
    ///             {
    ///               "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
    ///               "valueString": "ContactPointSystem"
    ///             }
    ///           ],
    ///           "strength": "required",
    ///           "description": "Telecommunications form for contact point.",
    ///           "valueSet": "http://hl7.org/fhir/ValueSet/contact-point-system|4.0.0"
    ///         }
    ///       },
    ///       {
    ///         "id": "ContactPoint.value",
    ///         "path": "ContactPoint.value",
    ///         "short": "The actual contact point details",
    ///         "definition": "The actual contact point details, in a form that is meaningful to the designated communication system (i.e. phone number or email address).",
    ///         "comment": "Additional text data such as phone extension numbers, or notes about use of the contact are sometimes included in the value.",
    ///         "requirements": "Need to support legacy numbers that are not in a tightly controlled format.",
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
    ///         "id": "ContactPoint.use",
    ///         "path": "ContactPoint.use",
    ///         "short": "home | work | temp | old | mobile - purpose of this contact point",
    ///         "definition": "Identifies the purpose for the contact point.",
    ///         "comment": "Applications can assume that a contact is current unless it explicitly says that it is temporary or old.",
    ///         "requirements": "Need to track the way a person uses this contact, so a user can choose which is appropriate for their purpose.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "code"
    ///           }
    ///         ],
    ///         "isModifier": true,
    ///         "isModifierReason": "This is labeled as \"Is Modifier\" because applications should not mistake a temporary or old contact etc.for a current/permanent one",
    ///         "isSummary": true,
    ///         "binding": {
    ///           "extension": [
    ///             {
    ///               "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
    ///               "valueString": "ContactPointUse"
    ///             }
    ///           ],
    ///           "strength": "required",
    ///           "description": "Use of contact point.",
    ///           "valueSet": "http://hl7.org/fhir/ValueSet/contact-point-use|4.0.0"
    ///         }
    ///       },
    ///       {
    ///         "id": "ContactPoint.rank",
    ///         "path": "ContactPoint.rank",
    ///         "short": "Specify preferred order of use (1 = highest)",
    ///         "definition": "Specifies a preferred order in which to use a set of contacts. ContactPoints with lower rank values are more preferred than those with higher rank values.",
    ///         "comment": "Note that rank does not necessarily follow the order in which the contacts are represented in the instance.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "positiveInt"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "ContactPoint.period",
    ///         "path": "ContactPoint.period",
    ///         "short": "Time period when the contact point was/is in use",
    ///         "definition": "Time period when the contact point was/is in use.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "Period"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       }
    ///     ]
    ///   }
    /// }
    /// </summary>
    // 0. ContactPoint
    public class ContactPoint_Type : MakerComplex_Type                                                                                      // MakerGen.cs:337
    {                                                                                                                                       // MakerGen.cs:338
        // 1. ContactPoint.system
        public MakerElementInstance System;                                                                                                 // MakerGen.cs:217
        // 2. ContactPoint.value
        public MakerElementInstance Value;                                                                                                  // MakerGen.cs:217
        // 3. ContactPoint.use
        public MakerElementInstance Use;                                                                                                    // MakerGen.cs:217
        // 4. ContactPoint.rank
        public MakerElementInstance Rank;                                                                                                   // MakerGen.cs:217
        // 5. ContactPoint.period
        public MakerElementInstance Period;                                                                                                 // MakerGen.cs:217
        public ContactPoint_Type()                                                                                                          // MakerGen.cs:346
        {                                                                                                                                   // MakerGen.cs:347
            {                                                                                                                               // MakerGen.cs:228
                // 1. ContactPoint.system
                this.System = new MakerElementInstance                                                                                      // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "System",                                                                                                        // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new Code_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 2. ContactPoint.value
                this.Value = new MakerElementInstance                                                                                       // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Value",                                                                                                         // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new String_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 3. ContactPoint.use
                this.Use = new MakerElementInstance                                                                                         // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Use",                                                                                                           // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new Code_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 4. ContactPoint.rank
                this.Rank = new MakerElementInstance                                                                                        // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Rank",                                                                                                          // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new PositiveInt_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 5. ContactPoint.period
                this.Period = new MakerElementInstance                                                                                      // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Period",                                                                                                        // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
        }                                                                                                                                   // MakerGen.cs:358
    }                                                                                                                                       // MakerGen.cs:342
}                                                                                                                                           // MakerGen.cs:389
