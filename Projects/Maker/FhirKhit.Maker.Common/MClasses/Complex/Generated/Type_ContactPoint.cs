using System;                                                                                                                               // MakerGen.cs:482
using System.Diagnostics;                                                                                                                   // MakerGen.cs:483
using System.IO;                                                                                                                            // MakerGen.cs:484
using System.Linq;                                                                                                                          // MakerGen.cs:485
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:486
                                                                                                                                            // MakerGen.cs:487
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:488
{                                                                                                                                           // MakerGen.cs:489
    #region Json                                                                                                                            // MakerGen.cs:490
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
    #endregion                                                                                                                              // MakerGen.cs:494
    /// <summary>
    /// Fhir complex 'ContactPoint'
    /// </summary>
    // 0. ContactPoint
    public class Type_ContactPoint : FhirKhit.Maker.Common.Complex.ComplexBase                                                              // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        // 1. ContactPoint.system
        public ElementDefinitionInfo Element_System;                                                                                        // MakerGen.cs:212
        // 2. ContactPoint.value
        public ElementDefinitionInfo Element_Value;                                                                                         // MakerGen.cs:212
        // 3. ContactPoint.use
        public ElementDefinitionInfo Element_Use;                                                                                           // MakerGen.cs:212
        // 4. ContactPoint.rank
        public ElementDefinitionInfo Element_Rank;                                                                                          // MakerGen.cs:212
        // 5. ContactPoint.period
        public ElementDefinitionInfo Element_Period;                                                                                        // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            base.Write(sDef);                                                                                                               // MakerGen.cs:385
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:386
            {                                                                                                                               // MakerGen.cs:387
                Path = "ContactPoint",                                                                                                      // MakerGen.cs:388
                ElementId = "ContactPoint"                                                                                                  // MakerGen.cs:389
            });                                                                                                                             // MakerGen.cs:390
            Element_System.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_Value.Write(sDef);                                                                                                      // MakerGen.cs:216
            Element_Use.Write(sDef);                                                                                                        // MakerGen.cs:216
            Element_Rank.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_Period.Write(sDef);                                                                                                     // MakerGen.cs:216
        }                                                                                                                                   // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
        public Type_ContactPoint()                                                                                                          // MakerGen.cs:395
        {                                                                                                                                   // MakerGen.cs:396
            {                                                                                                                               // MakerGen.cs:227
                // 1. ContactPoint.system
                this.Element_System = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_System",                                                                                                // MakerGen.cs:231
                    Path= "ContactPoint.system",                                                                                            // MakerGen.cs:232
                    Id = "ContactPoint.system",                                                                                             // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 2. ContactPoint.value
                this.Element_Value = new ElementDefinitionInfo                                                                              // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Value",                                                                                                 // MakerGen.cs:231
                    Path= "ContactPoint.value",                                                                                             // MakerGen.cs:232
                    Id = "ContactPoint.value",                                                                                              // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 3. ContactPoint.use
                this.Element_Use = new ElementDefinitionInfo                                                                                // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Use",                                                                                                   // MakerGen.cs:231
                    Path= "ContactPoint.use",                                                                                               // MakerGen.cs:232
                    Id = "ContactPoint.use",                                                                                                // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 4. ContactPoint.rank
                this.Element_Rank = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Rank",                                                                                                  // MakerGen.cs:231
                    Path= "ContactPoint.rank",                                                                                              // MakerGen.cs:232
                    Id = "ContactPoint.rank",                                                                                               // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_PositiveInt                                                           // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 5. ContactPoint.period
                this.Element_Period = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Period",                                                                                                // MakerGen.cs:231
                    Path= "ContactPoint.period",                                                                                            // MakerGen.cs:232
                    Id = "ContactPoint.period",                                                                                             // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Period                                                                       // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
        }                                                                                                                                   // MakerGen.cs:398
    }                                                                                                                                       // MakerGen.cs:400
}                                                                                                                                           // MakerGen.cs:499
