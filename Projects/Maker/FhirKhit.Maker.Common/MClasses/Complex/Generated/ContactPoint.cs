using System;                                                                                                                               // MakerGen.cs:499
using System.Diagnostics;                                                                                                                   // MakerGen.cs:500
using System.IO;                                                                                                                            // MakerGen.cs:501
using System.Linq;                                                                                                                          // MakerGen.cs:502
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:503
                                                                                                                                            // MakerGen.cs:504
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:505
{                                                                                                                                           // MakerGen.cs:506
    #region Json                                                                                                                            // MakerGen.cs:507
    #if NEVER
    {
      "resourceType": "StructureDefinition",
      "id": "ContactPoint",
      "url": "http://hl7.org/fhir/StructureDefinition/ContactPoint",
      "version": "4.0.0",
      "name": "ContactPoint",
      "status": "active",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for ContactPoint Type: Details for all kinds of technology mediated contact points for a person or organization, including telephone, email, etc.",
      "purpose": "Need to track phone, fax, mobile, sms numbers, email addresses, twitter tags, etc.",
      "fhirVersion": "4.0.0",
      "kind": "complex-type",
      "abstract": false,
      "type": "ContactPoint",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "ContactPoint",
            "path": "ContactPoint",
            "short": "Details of a Technology mediated contact point (phone, fax, email, etc.)",
            "definition": "Details for all kinds of technology mediated contact points for a person or organization, including telephone, email, etc.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "ContactPoint.system",
            "path": "ContactPoint.system",
            "short": "phone | fax | email | pager | url | sms | other",
            "definition": "Telecommunications form for contact point - what communications system is required to make use of the contact.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "condition": [
              "cpt-2"
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ContactPointSystem"
                }
              ],
              "strength": "required",
              "description": "Telecommunications form for contact point.",
              "valueSet": "http://hl7.org/fhir/ValueSet/contact-point-system|4.0.0"
            }
          },
          {
            "id": "ContactPoint.value",
            "path": "ContactPoint.value",
            "short": "The actual contact point details",
            "definition": "The actual contact point details, in a form that is meaningful to the designated communication system (i.e. phone number or email address).",
            "comment": "Additional text data such as phone extension numbers, or notes about use of the contact are sometimes included in the value.",
            "requirements": "Need to support legacy numbers that are not in a tightly controlled format.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ContactPoint.use",
            "path": "ContactPoint.use",
            "short": "home | work | temp | old | mobile - purpose of this contact point",
            "definition": "Identifies the purpose for the contact point.",
            "comment": "Applications can assume that a contact is current unless it explicitly says that it is temporary or old.",
            "requirements": "Need to track the way a person uses this contact, so a user can choose which is appropriate for their purpose.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isModifier": true,
            "isModifierReason": "This is labeled as \"Is Modifier\" because applications should not mistake a temporary or old contact etc.for a current/permanent one",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ContactPointUse"
                }
              ],
              "strength": "required",
              "description": "Use of contact point.",
              "valueSet": "http://hl7.org/fhir/ValueSet/contact-point-use|4.0.0"
            }
          },
          {
            "id": "ContactPoint.rank",
            "path": "ContactPoint.rank",
            "short": "Specify preferred order of use (1 = highest)",
            "definition": "Specifies a preferred order in which to use a set of contacts. ContactPoints with lower rank values are more preferred than those with higher rank values.",
            "comment": "Note that rank does not necessarily follow the order in which the contacts are represented in the instance.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "positiveInt"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ContactPoint.period",
            "path": "ContactPoint.period",
            "short": "Time period when the contact point was/is in use",
            "definition": "Time period when the contact point was/is in use.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Period"
              }
            ],
            "isSummary": true
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:511
    /// <summary>
    /// Fhir complex 'ContactPoint'
    /// </summary>
    // 0. ContactPoint
    public class ContactPoint : FhirKhit.Maker.Common.Complex.ComplexBase                                                                   // MakerGen.cs:385
    {                                                                                                                                       // MakerGen.cs:386
        public class ContactPoint_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                    // MakerGen.cs:387
        {                                                                                                                                   // MakerGen.cs:388
            // 1. ContactPoint.system
            public ElementDefinitionInfo System;                                                                                            // MakerGen.cs:236
            // 2. ContactPoint.value
            public ElementDefinitionInfo Value;                                                                                             // MakerGen.cs:236
            // 3. ContactPoint.use
            public ElementDefinitionInfo Use;                                                                                               // MakerGen.cs:236
            // 4. ContactPoint.rank
            public ElementDefinitionInfo Rank;                                                                                              // MakerGen.cs:236
            // 5. ContactPoint.period
            public ElementDefinitionInfo Period;                                                                                            // MakerGen.cs:236
            public ContactPoint_Elements()                                                                                                  // MakerGen.cs:409
            {                                                                                                                               // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:251
                    // 1. ContactPoint.system
                    this.System = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "System",                                                                                                    // MakerGen.cs:255
                        Path= "ContactPoint.system",                                                                                        // MakerGen.cs:256
                        Id = "ContactPoint.system",                                                                                         // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 2. ContactPoint.value
                    this.Value = new ElementDefinitionInfo                                                                                  // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Value",                                                                                                     // MakerGen.cs:255
                        Path= "ContactPoint.value",                                                                                         // MakerGen.cs:256
                        Id = "ContactPoint.value",                                                                                          // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 3. ContactPoint.use
                    this.Use = new ElementDefinitionInfo                                                                                    // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Use",                                                                                                       // MakerGen.cs:255
                        Path= "ContactPoint.use",                                                                                           // MakerGen.cs:256
                        Id = "ContactPoint.use",                                                                                            // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 4. ContactPoint.rank
                    this.Rank = new ElementDefinitionInfo                                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Rank",                                                                                                      // MakerGen.cs:255
                        Path= "ContactPoint.rank",                                                                                          // MakerGen.cs:256
                        Id = "ContactPoint.rank",                                                                                           // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.PositiveInt                                                                 // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 5. ContactPoint.period
                    this.Period = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Period",                                                                                                    // MakerGen.cs:255
                        Path= "ContactPoint.period",                                                                                        // MakerGen.cs:256
                        Id = "ContactPoint.period",                                                                                         // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Period                                                                        // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
            }                                                                                                                               // MakerGen.cs:429
            public void override Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:414
            {                                                                                                                               // MakerGen.cs:415
                base.Write(sDef);                                                                                                           // MakerGen.cs:416
                System.Write(sDef);                                                                                                         // MakerGen.cs:240
                Value.Write(sDef);                                                                                                          // MakerGen.cs:240
                Use.Write(sDef);                                                                                                            // MakerGen.cs:240
                Rank.Write(sDef);                                                                                                           // MakerGen.cs:240
                Period.Write(sDef);                                                                                                         // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:433
        }                                                                                                                                   // MakerGen.cs:393
        public ContactPoint_Elements Elements { get; }                                                                                      // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
        public ContactPoint()                                                                                                               // MakerGen.cs:396
        {                                                                                                                                   // MakerGen.cs:397
            this.Elements = new ContactPoint_Elements();                                                                                    // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:404
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:516
