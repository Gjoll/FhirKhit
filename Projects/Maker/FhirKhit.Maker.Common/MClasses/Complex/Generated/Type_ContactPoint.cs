using System;                                                                                                                               // MakerGen.cs:508
using System.Diagnostics;                                                                                                                   // MakerGen.cs:509
using System.IO;                                                                                                                            // MakerGen.cs:510
using System.Linq;                                                                                                                          // MakerGen.cs:511
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:512
                                                                                                                                            // MakerGen.cs:513
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:514
{                                                                                                                                           // MakerGen.cs:515
    #region Json                                                                                                                            // MakerGen.cs:516
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
    #endregion                                                                                                                              // MakerGen.cs:520
    /// <summary>
    /// Fhir complex 'ContactPoint'
    /// </summary>
    // 0. ContactPoint
    public class Type_ContactPoint : FhirKhit.Maker.Common.Complex.ComplexBase                                                              // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        public class Type_ContactPoint_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                               // MakerGen.cs:378
        {                                                                                                                                   // MakerGen.cs:379
            // 1. ContactPoint.system
            public ElementDefinitionInfo Element_System;                                                                                    // MakerGen.cs:211
            // 2. ContactPoint.value
            public ElementDefinitionInfo Element_Value;                                                                                     // MakerGen.cs:211
            // 3. ContactPoint.use
            public ElementDefinitionInfo Element_Use;                                                                                       // MakerGen.cs:211
            // 4. ContactPoint.rank
            public ElementDefinitionInfo Element_Rank;                                                                                      // MakerGen.cs:211
            // 5. ContactPoint.period
            public ElementDefinitionInfo Element_Period;                                                                                    // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
            public Type_ContactPoint_Elements()                                                                                             // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:226
                    // 1. ContactPoint.system
                    this.Element_System = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_System",                                                                                            // MakerGen.cs:230
                        Path= "ContactPoint.system",                                                                                        // MakerGen.cs:231
                        Id = "ContactPoint.system",                                                                                         // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 2. ContactPoint.value
                    this.Element_Value = new ElementDefinitionInfo                                                                          // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Value",                                                                                             // MakerGen.cs:230
                        Path= "ContactPoint.value",                                                                                         // MakerGen.cs:231
                        Id = "ContactPoint.value",                                                                                          // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 3. ContactPoint.use
                    this.Element_Use = new ElementDefinitionInfo                                                                            // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Use",                                                                                               // MakerGen.cs:230
                        Path= "ContactPoint.use",                                                                                           // MakerGen.cs:231
                        Id = "ContactPoint.use",                                                                                            // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 4. ContactPoint.rank
                    this.Element_Rank = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Rank",                                                                                              // MakerGen.cs:230
                        Path= "ContactPoint.rank",                                                                                          // MakerGen.cs:231
                        Id = "ContactPoint.rank",                                                                                           // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.PositiveInt                                                                 // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 5. ContactPoint.period
                    this.Element_Period = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Period",                                                                                            // MakerGen.cs:230
                        Path= "ContactPoint.period",                                                                                        // MakerGen.cs:231
                        Id = "ContactPoint.period",                                                                                         // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Period                                                                   // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            }                                                                                                               // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                Element_System.Write(sDef);                                                                                                 // MakerGen.cs:215
                Element_Value.Write(sDef);                                                                                                  // MakerGen.cs:215
                Element_Use.Write(sDef);                                                                                                    // MakerGen.cs:215
                Element_Rank.Write(sDef);                                                                                                   // MakerGen.cs:215
                Element_Period.Write(sDef);                                                                                                 // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:394
        }                                                                                                                                   // MakerGen.cs:396
        public Type_ContactPoint_Elements Elements                                                                                          // MakerGen.cs:398
        {                                                                                                                                   // MakerGen.cs:399
            get                                                                                                                             // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                if (this.elements == null)                                                                                                  // MakerGen.cs:402
                    this.elements = new Type_ContactPoint_Elements();                                                                       // MakerGen.cs:403
                return this.elements;                                                                                                       // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:406
        Type_ContactPoint_Elements elements;                                                                                                // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
        public Type_ContactPoint()                                                                                                          // MakerGen.cs:410
        {                                                                                                                                   // MakerGen.cs:411
        }                                                                                                                                   // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:416
        {                                                                                                                                   // MakerGen.cs:417
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:418
            {                                                                                                                               // MakerGen.cs:419
                Path = "ContactPoint",                                                                                                      // MakerGen.cs:420
                ElementId = "ContactPoint"                                                                                                  // MakerGen.cs:421
            });                                                                                                                             // MakerGen.cs:422
            if (this.elements != null)                                                                                                      // MakerGen.cs:423
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:424
        }                                                                                                                                   // MakerGen.cs:425
    }                                                                                                                                       // MakerGen.cs:426
}                                                                                                                                           // MakerGen.cs:525
