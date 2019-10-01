using System;                                                                                                                               // MakerGen.cs:439
using System.Diagnostics;                                                                                                                   // MakerGen.cs:440
using System.IO;                                                                                                                            // MakerGen.cs:441
using System.Linq;                                                                                                                          // MakerGen.cs:442
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:443
                                                                                                                                            // MakerGen.cs:444
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:445
{                                                                                                                                           // MakerGen.cs:446
    #region Json                                                                                                                            // MakerGen.cs:447
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
    #endregion                                                                                                                              // MakerGen.cs:451
    /// <summary>
    /// Fhir complex 'ContactPoint'
    /// </summary>
    // 0. ContactPoint
    public class ContactPoint : FhirKhit.Maker.Common.Complex.ComplexBase                                                                   // MakerGen.cs:352
    {                                                                                                                                       // MakerGen.cs:353
        // 1. ContactPoint.system
        public MakerElementInstance Element_System;                                                                                         // MakerGen.cs:232
        // 2. ContactPoint.value
        public MakerElementInstance Element_Value;                                                                                          // MakerGen.cs:232
        // 3. ContactPoint.use
        public MakerElementInstance Element_Use;                                                                                            // MakerGen.cs:232
        // 4. ContactPoint.rank
        public MakerElementInstance Element_Rank;                                                                                           // MakerGen.cs:232
        // 5. ContactPoint.period
        public MakerElementInstance Element_Period;                                                                                         // MakerGen.cs:232
        public ContactPoint()                                                                                                               // MakerGen.cs:361
        {                                                                                                                                   // MakerGen.cs:362
            {                                                                                                                               // MakerGen.cs:243
                // 1. ContactPoint.system
                this.Element_System = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_System",                                                                                                // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Code()                                                                          // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 2. ContactPoint.value
                this.Element_Value = new MakerElementInstance                                                                               // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Value",                                                                                                 // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String()                                                                        // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 3. ContactPoint.use
                this.Element_Use = new MakerElementInstance                                                                                 // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Use",                                                                                                   // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Code()                                                                          // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 4. ContactPoint.rank
                this.Element_Rank = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Rank",                                                                                                  // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.PositiveInt()                                                                   // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 5. ContactPoint.period
                this.Element_Period = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Period",                                                                                                // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
        }                                                                                                                                   // MakerGen.cs:373
    }                                                                                                                                       // MakerGen.cs:357
}                                                                                                                                           // MakerGen.cs:456
