using System;                                                                                                                               // MakerGen.cs:498
using System.Diagnostics;                                                                                                                   // MakerGen.cs:499
using System.IO;                                                                                                                            // MakerGen.cs:500
using System.Linq;                                                                                                                          // MakerGen.cs:501
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:502
                                                                                                                                            // MakerGen.cs:503
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:504
{                                                                                                                                           // MakerGen.cs:505
    #region Json                                                                                                                            // MakerGen.cs:506
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
    #endregion                                                                                                                              // MakerGen.cs:510
    /// <summary>
    /// Fhir complex 'ContactPoint'
    /// </summary>
    // 0. ContactPoint
    public class Type_ContactPoint : FhirKhit.Maker.Common.Complex.ComplexBase                                                              // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        // 1. ContactPoint.system
        public ElementDefinitionInfo Element_System;                                                                                        // MakerGen.cs:219
        // 2. ContactPoint.value
        public ElementDefinitionInfo Element_Value;                                                                                         // MakerGen.cs:219
        // 3. ContactPoint.use
        public ElementDefinitionInfo Element_Use;                                                                                           // MakerGen.cs:219
        // 4. ContactPoint.rank
        public ElementDefinitionInfo Element_Rank;                                                                                          // MakerGen.cs:219
        // 5. ContactPoint.period
        public ElementDefinitionInfo Element_Period;                                                                                        // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:390
        {                                                                                                                                   // MakerGen.cs:391
            base.Write(sDef);                                                                                                               // MakerGen.cs:392
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                Path = "ContactPoint",                                                                                                      // MakerGen.cs:395
                ElementId = "ContactPoint"                                                                                                  // MakerGen.cs:396
            });                                                                                                                             // MakerGen.cs:397
            Element_System.Write(sDef);                                                                                                     // MakerGen.cs:223
            Element_Value.Write(sDef);                                                                                                      // MakerGen.cs:223
            Element_Use.Write(sDef);                                                                                                        // MakerGen.cs:223
            Element_Rank.Write(sDef);                                                                                                       // MakerGen.cs:223
            Element_Period.Write(sDef);                                                                                                     // MakerGen.cs:223
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
        public Type_ContactPoint()                                                                                                          // MakerGen.cs:402
        {                                                                                                                                   // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:234
                // 1. ContactPoint.system
                this.Element_System = new ElementDefinitionInfo                                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_System",                                                                                                // MakerGen.cs:238
                    Path= "ContactPoint.system",                                                                                            // MakerGen.cs:239
                    Id = "ContactPoint.system",                                                                                             // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 2. ContactPoint.value
                this.Element_Value = new ElementDefinitionInfo                                                                              // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Value",                                                                                                 // MakerGen.cs:238
                    Path= "ContactPoint.value",                                                                                             // MakerGen.cs:239
                    Id = "ContactPoint.value",                                                                                              // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 3. ContactPoint.use
                this.Element_Use = new ElementDefinitionInfo                                                                                // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Use",                                                                                                   // MakerGen.cs:238
                    Path= "ContactPoint.use",                                                                                               // MakerGen.cs:239
                    Id = "ContactPoint.use",                                                                                                // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 4. ContactPoint.rank
                this.Element_Rank = new ElementDefinitionInfo                                                                               // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Rank",                                                                                                  // MakerGen.cs:238
                    Path= "ContactPoint.rank",                                                                                              // MakerGen.cs:239
                    Id = "ContactPoint.rank",                                                                                               // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_PositiveInt                                                           // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 5. ContactPoint.period
                this.Element_Period = new ElementDefinitionInfo                                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Period",                                                                                                // MakerGen.cs:238
                    Path= "ContactPoint.period",                                                                                            // MakerGen.cs:239
                    Id = "ContactPoint.period",                                                                                             // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Period                                                                       // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
        }                                                                                                                                   // MakerGen.cs:405
    }                                                                                                                                       // MakerGen.cs:407
}                                                                                                                                           // MakerGen.cs:515
