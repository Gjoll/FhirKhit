using System;                                                                                                                               // MakerGen.cs:462
using System.Diagnostics;                                                                                                                   // MakerGen.cs:463
using System.IO;                                                                                                                            // MakerGen.cs:464
using System.Linq;                                                                                                                          // MakerGen.cs:465
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:466
                                                                                                                                            // MakerGen.cs:467
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:468
{                                                                                                                                           // MakerGen.cs:469
    #region Json                                                                                                                            // MakerGen.cs:470
    #if NEVER                                                                                                                               // MakerGen.cs:471
    {
      "resourceType": "StructureDefinition",
      "id": "EpisodeOfCare",
      "url": "http://hl7.org/fhir/StructureDefinition/EpisodeOfCare",
      "version": "4.0.0",
      "name": "EpisodeOfCare",
      "status": "draft",
      "publisher": "Health Level Seven International (Patient Administration)",
      "description": "An association between a patient and an organization / healthcare provider(s) during which time encounters may occur. The managing organization assumes a level of responsibility for the patient during this time.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "EpisodeOfCare",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "EpisodeOfCare",
            "path": "EpisodeOfCare",
            "short": "An association of a Patient with an Organization and  Healthcare Provider(s) for a period of time that the Organization assumes some level of responsibility",
            "definition": "An association between a patient and an organization / healthcare provider(s) during which time encounters may occur. The managing organization assumes a level of responsibility for the patient during this time.",
            "alias": [
              "Case Program Problem"
            ],
            "min": 0,
            "max": "*"
          },
          {
            "id": "EpisodeOfCare.identifier",
            "path": "EpisodeOfCare.identifier",
            "short": "Business Identifier(s) relevant for this EpisodeOfCare",
            "definition": "The EpisodeOfCare may be known by different identifiers for different contexts of use, such as when an external agency is tracking the Episode for funding purposes.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Identifier"
              }
            ]
          },
          {
            "id": "EpisodeOfCare.status",
            "path": "EpisodeOfCare.status",
            "short": "planned | waitlist | active | onhold | finished | cancelled | entered-in-error",
            "definition": "planned | waitlist | active | onhold | finished | cancelled.",
            "comment": "This element is labeled as a modifier because the status contains codes that mark the episode as not currently valid.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isModifier": true,
            "isModifierReason": "This element is labelled as a modifier because it is a status element that contains status entered-in-error which means that the resource should not be treated as valid",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "EpisodeOfCareStatus"
                }
              ],
              "strength": "required",
              "description": "The status of the episode of care.",
              "valueSet": "http://hl7.org/fhir/ValueSet/episode-of-care-status|4.0.0"
            }
          },
          {
            "id": "EpisodeOfCare.statusHistory",
            "path": "EpisodeOfCare.statusHistory",
            "short": "Past list of status codes (the current status may be included to cover the start date of the status)",
            "definition": "The history of statuses that the EpisodeOfCare has been through (without requiring processing the history of the resource).",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "EpisodeOfCare.statusHistory.status",
            "path": "EpisodeOfCare.statusHistory.status",
            "short": "planned | waitlist | active | onhold | finished | cancelled | entered-in-error",
            "definition": "planned | waitlist | active | onhold | finished | cancelled.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "EpisodeOfCareStatus"
                }
              ],
              "strength": "required",
              "description": "The status of the episode of care.",
              "valueSet": "http://hl7.org/fhir/ValueSet/episode-of-care-status|4.0.0"
            }
          },
          {
            "id": "EpisodeOfCare.statusHistory.period",
            "path": "EpisodeOfCare.statusHistory.period",
            "short": "Duration the EpisodeOfCare was in the specified status",
            "definition": "The period during this EpisodeOfCare that the specific status applied.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Period"
              }
            ]
          },
          {
            "id": "EpisodeOfCare.type",
            "path": "EpisodeOfCare.type",
            "short": "Type/class  - e.g. specialist referral, disease management",
            "definition": "A classification of the type of episode of care; e.g. specialist referral, disease management, type of funded care.",
            "comment": "The type can be very important in processing as this could be used in determining if the EpisodeOfCare is relevant to specific government reporting, or other types of classifications.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "EpisodeOfCareType"
                }
              ],
              "strength": "example",
              "description": "The type of the episode of care.",
              "valueSet": "http://hl7.org/fhir/ValueSet/episodeofcare-type"
            }
          },
          {
            "id": "EpisodeOfCare.diagnosis",
            "path": "EpisodeOfCare.diagnosis",
            "short": "The list of diagnosis relevant to this episode of care",
            "definition": "The list of diagnosis relevant to this episode of care.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "EpisodeOfCare.diagnosis.condition",
            "path": "EpisodeOfCare.diagnosis.condition",
            "short": "Conditions/problems/diagnoses this episode of care is for",
            "definition": "A list of conditions/problems/diagnoses that this episode of care is intended to be providing care for.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Condition"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "EpisodeOfCare.diagnosis.role",
            "path": "EpisodeOfCare.diagnosis.role",
            "short": "Role that this diagnosis has within the episode of care (e.g. admission, billing, discharge …)",
            "definition": "Role that this diagnosis has within the episode of care (e.g. admission, billing, discharge …).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "DiagnosisRole"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "preferred",
              "description": "The type of diagnosis this condition represents.",
              "valueSet": "http://hl7.org/fhir/ValueSet/diagnosis-role"
            }
          },
          {
            "id": "EpisodeOfCare.diagnosis.rank",
            "path": "EpisodeOfCare.diagnosis.rank",
            "short": "Ranking of the diagnosis (for each role type)",
            "definition": "Ranking of the diagnosis (for each role type).",
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
            "id": "EpisodeOfCare.patient",
            "path": "EpisodeOfCare.patient",
            "short": "The patient who is the focus of this episode of care",
            "definition": "The patient who is the focus of this episode of care.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "EpisodeOfCare.managingOrganization",
            "path": "EpisodeOfCare.managingOrganization",
            "short": "Organization that assumes care",
            "definition": "The organization that has assumed the specific responsibilities for the specified duration.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "EpisodeOfCare.period",
            "path": "EpisodeOfCare.period",
            "short": "Interval during responsibility is assumed",
            "definition": "The interval during which the managing organization assumes the defined responsibility.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Period"
              }
            ],
            "isSummary": true
          },
          {
            "id": "EpisodeOfCare.referralRequest",
            "path": "EpisodeOfCare.referralRequest",
            "short": "Originating Referral Request(s)",
            "definition": "Referral Request(s) that are fulfilled by this EpisodeOfCare, incoming referrals.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/ServiceRequest"
                ]
              }
            ]
          },
          {
            "id": "EpisodeOfCare.careManager",
            "path": "EpisodeOfCare.careManager",
            "short": "Care manager/care coordinator for the patient",
            "definition": "The practitioner that is the care manager/care coordinator for this patient.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole"
                ]
              }
            ]
          },
          {
            "id": "EpisodeOfCare.team",
            "path": "EpisodeOfCare.team",
            "short": "Other practitioners facilitating this episode of care",
            "definition": "The list of practitioners that may be facilitating this episode of care for specific purposes.",
            "alias": [
              "CareTeam"
            ],
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/CareTeam"
                ]
              }
            ]
          },
          {
            "id": "EpisodeOfCare.account",
            "path": "EpisodeOfCare.account",
            "short": "The set of accounts that may be used for billing for this EpisodeOfCare",
            "definition": "The set of accounts that may be used for billing for this EpisodeOfCare.",
            "comment": "The billing system may choose to allocate billable items associated with the EpisodeOfCare to different referenced Accounts based on internal business rules.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Account"
                ]
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:474
    /// <summary>
    /// Fhir resource 'EpisodeOfCare'
    /// </summary>
    // 0. EpisodeOfCare
    public class EpisodeOfCare : FhirKhit.Maker.Common.Resource.ResourceBase                                                                // MakerGen.cs:384
    {                                                                                                                                       // MakerGen.cs:385
        public class EpisodeOfCare_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                   // MakerGen.cs:386
        {                                                                                                                                   // MakerGen.cs:387
            // 3. EpisodeOfCare.statusHistory
            public class Type_StatusHistory : FhirKhit.Maker.Common.Complex.ComplexBase                                                     // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                public class Type_StatusHistory_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                      // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    // 4. EpisodeOfCare.statusHistory.status
                    public ElementDefinitionInfo Status;                                                                                    // MakerGen.cs:216
                    // 5. EpisodeOfCare.statusHistory.period
                    public ElementDefinitionInfo Period;                                                                                    // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                    public Type_StatusHistory_Elements()                                                                                    // MakerGen.cs:392
                    {                                                                                                                       // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:231
                            // 4. EpisodeOfCare.statusHistory.status
                            this.Status = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Status",                                                                                            // MakerGen.cs:235
                                Path= "EpisodeOfCare.statusHistory.status",                                                                 // MakerGen.cs:236
                                Id = "EpisodeOfCare.statusHistory.status",                                                                  // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 5. EpisodeOfCare.statusHistory.period
                            this.Period = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Period",                                                                                            // MakerGen.cs:235
                                Path= "EpisodeOfCare.statusHistory.period",                                                                 // MakerGen.cs:236
                                Id = "EpisodeOfCare.statusHistory.period",                                                                  // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Period                                                                // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    }                                                                                                       // MakerGen.cs:360
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:398
                    {                                                                                                                       // MakerGen.cs:399
                        base.Write(sDef);                                                                                                   // MakerGen.cs:400
                        Status.Write(sDef);                                                                                                 // MakerGen.cs:220
                        Period.Write(sDef);                                                                                                 // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:402
                }                                                                                                                           // MakerGen.cs:404
                public Type_StatusHistory_Elements Elements                                                                                 // MakerGen.cs:406
                {                                                                                                                           // MakerGen.cs:407
                    get                                                                                                                     // MakerGen.cs:408
                    {                                                                                                                       // MakerGen.cs:409
                        if (this.elements == null)                                                                                          // MakerGen.cs:410
                            this.elements = new Type_StatusHistory_Elements();                                                              // MakerGen.cs:411
                        return this.elements;                                                                                               // MakerGen.cs:412
                    }                                                                                                                       // MakerGen.cs:413
                }                                                                                                                           // MakerGen.cs:414
                Type_StatusHistory_Elements elements;                                                                                       // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                public Type_StatusHistory()                                                                                                 // MakerGen.cs:418
                {                                                                                                                           // MakerGen.cs:419
                }                                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:424
                {                                                                                                                           // MakerGen.cs:425
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:426
                    {                                                                                                                       // MakerGen.cs:427
                        Path = "EpisodeOfCare.statusHistory",                                                                               // MakerGen.cs:428
                        ElementId = "EpisodeOfCare.statusHistory"                                                                           // MakerGen.cs:429
                    });                                                                                                                     // MakerGen.cs:430
                    if (this.elements != null)                                                                                              // MakerGen.cs:431
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:432
                }                                                                                                                           // MakerGen.cs:433
            }                                                                                                                               // MakerGen.cs:434
            // 7. EpisodeOfCare.diagnosis
            public class Type_Diagnosis : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                public class Type_Diagnosis_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    // 8. EpisodeOfCare.diagnosis.condition
                    public ElementDefinitionInfo Condition;                                                                                 // MakerGen.cs:216
                    // 9. EpisodeOfCare.diagnosis.role
                    public ElementDefinitionInfo Role;                                                                                      // MakerGen.cs:216
                    // 10. EpisodeOfCare.diagnosis.rank
                    public ElementDefinitionInfo Rank;                                                                                      // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                    public Type_Diagnosis_Elements()                                                                                        // MakerGen.cs:392
                    {                                                                                                                       // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:231
                            // 8. EpisodeOfCare.diagnosis.condition
                            this.Condition = new ElementDefinitionInfo                                                                      // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Condition",                                                                                         // MakerGen.cs:235
                                Path= "EpisodeOfCare.diagnosis.condition",                                                                  // MakerGen.cs:236
                                Id = "EpisodeOfCare.diagnosis.condition",                                                                   // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Condition"                                             // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 9. EpisodeOfCare.diagnosis.role
                            this.Role = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Role",                                                                                              // MakerGen.cs:235
                                Path= "EpisodeOfCare.diagnosis.role",                                                                       // MakerGen.cs:236
                                Id = "EpisodeOfCare.diagnosis.role",                                                                        // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 10. EpisodeOfCare.diagnosis.rank
                            this.Rank = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Rank",                                                                                              // MakerGen.cs:235
                                Path= "EpisodeOfCare.diagnosis.rank",                                                                       // MakerGen.cs:236
                                Id = "EpisodeOfCare.diagnosis.rank",                                                                        // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                                         // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:398
                    {                                                                                                                       // MakerGen.cs:399
                        base.Write(sDef);                                                                                                   // MakerGen.cs:400
                        Condition.Write(sDef);                                                                                              // MakerGen.cs:220
                        Role.Write(sDef);                                                                                                   // MakerGen.cs:220
                        Rank.Write(sDef);                                                                                                   // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:402
                }                                                                                                                           // MakerGen.cs:404
                public Type_Diagnosis_Elements Elements                                                                                     // MakerGen.cs:406
                {                                                                                                                           // MakerGen.cs:407
                    get                                                                                                                     // MakerGen.cs:408
                    {                                                                                                                       // MakerGen.cs:409
                        if (this.elements == null)                                                                                          // MakerGen.cs:410
                            this.elements = new Type_Diagnosis_Elements();                                                                  // MakerGen.cs:411
                        return this.elements;                                                                                               // MakerGen.cs:412
                    }                                                                                                                       // MakerGen.cs:413
                }                                                                                                                           // MakerGen.cs:414
                Type_Diagnosis_Elements elements;                                                                                           // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                public Type_Diagnosis()                                                                                                     // MakerGen.cs:418
                {                                                                                                                           // MakerGen.cs:419
                }                                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:424
                {                                                                                                                           // MakerGen.cs:425
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:426
                    {                                                                                                                       // MakerGen.cs:427
                        Path = "EpisodeOfCare.diagnosis",                                                                                   // MakerGen.cs:428
                        ElementId = "EpisodeOfCare.diagnosis"                                                                               // MakerGen.cs:429
                    });                                                                                                                     // MakerGen.cs:430
                    if (this.elements != null)                                                                                              // MakerGen.cs:431
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:432
                }                                                                                                                           // MakerGen.cs:433
            }                                                                                                                               // MakerGen.cs:434
            // 1. EpisodeOfCare.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:216
            // 2. EpisodeOfCare.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:216
            // 3. EpisodeOfCare.statusHistory
            public ElementDefinitionInfo StatusHistory;                                                                                     // MakerGen.cs:216
            // 6. EpisodeOfCare.type
            public ElementDefinitionInfo Type;                                                                                              // MakerGen.cs:216
            // 7. EpisodeOfCare.diagnosis
            public ElementDefinitionInfo Diagnosis;                                                                                         // MakerGen.cs:216
            // 11. EpisodeOfCare.patient
            public ElementDefinitionInfo Patient;                                                                                           // MakerGen.cs:216
            // 12. EpisodeOfCare.managingOrganization
            public ElementDefinitionInfo ManagingOrganization;                                                                              // MakerGen.cs:216
            // 13. EpisodeOfCare.period
            public ElementDefinitionInfo Period;                                                                                            // MakerGen.cs:216
            // 14. EpisodeOfCare.referralRequest
            public ElementDefinitionInfo ReferralRequest;                                                                                   // MakerGen.cs:216
            // 15. EpisodeOfCare.careManager
            public ElementDefinitionInfo CareManager;                                                                                       // MakerGen.cs:216
            // 16. EpisodeOfCare.team
            public ElementDefinitionInfo Team;                                                                                              // MakerGen.cs:216
            // 17. EpisodeOfCare.account
            public ElementDefinitionInfo Account;                                                                                           // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
            public EpisodeOfCare_Elements()                                                                                                 // MakerGen.cs:392
            {                                                                                                                               // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:231
                    // 1. EpisodeOfCare.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Identifier",                                                                                                // MakerGen.cs:235
                        Path= "EpisodeOfCare.identifier",                                                                                   // MakerGen.cs:236
                        Id = "EpisodeOfCare.identifier",                                                                                    // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 2. EpisodeOfCare.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Status",                                                                                                    // MakerGen.cs:235
                        Path= "EpisodeOfCare.status",                                                                                       // MakerGen.cs:236
                        Id = "EpisodeOfCare.status",                                                                                        // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 3. EpisodeOfCare.statusHistory
                    this.StatusHistory = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "StatusHistory",                                                                                             // MakerGen.cs:235
                        Path= "EpisodeOfCare.statusHistory",                                                                                // MakerGen.cs:236
                        Id = "EpisodeOfCare.statusHistory",                                                                                 // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_StatusHistory                                                                                          // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 6. EpisodeOfCare.type
                    this.Type = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Type",                                                                                                      // MakerGen.cs:235
                        Path= "EpisodeOfCare.type",                                                                                         // MakerGen.cs:236
                        Id = "EpisodeOfCare.type",                                                                                          // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 7. EpisodeOfCare.diagnosis
                    this.Diagnosis = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Diagnosis",                                                                                                 // MakerGen.cs:235
                        Path= "EpisodeOfCare.diagnosis",                                                                                    // MakerGen.cs:236
                        Id = "EpisodeOfCare.diagnosis",                                                                                     // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Diagnosis                                                                                              // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 11. EpisodeOfCare.patient
                    this.Patient = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Patient",                                                                                                   // MakerGen.cs:235
                        Path= "EpisodeOfCare.patient",                                                                                      // MakerGen.cs:236
                        Id = "EpisodeOfCare.patient",                                                                                       // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient"                                                       // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 12. EpisodeOfCare.managingOrganization
                    this.ManagingOrganization = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "ManagingOrganization",                                                                                      // MakerGen.cs:235
                        Path= "EpisodeOfCare.managingOrganization",                                                                         // MakerGen.cs:236
                        Id = "EpisodeOfCare.managingOrganization",                                                                          // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 13. EpisodeOfCare.period
                    this.Period = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Period",                                                                                                    // MakerGen.cs:235
                        Path= "EpisodeOfCare.period",                                                                                       // MakerGen.cs:236
                        Id = "EpisodeOfCare.period",                                                                                        // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Period                                                                        // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 14. EpisodeOfCare.referralRequest
                    this.ReferralRequest = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "ReferralRequest",                                                                                           // MakerGen.cs:235
                        Path= "EpisodeOfCare.referralRequest",                                                                              // MakerGen.cs:236
                        Id = "EpisodeOfCare.referralRequest",                                                                               // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/ServiceRequest"                                                // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 15. EpisodeOfCare.careManager
                    this.CareManager = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "CareManager",                                                                                               // MakerGen.cs:235
                        Path= "EpisodeOfCare.careManager",                                                                                  // MakerGen.cs:236
                        Id = "EpisodeOfCare.careManager",                                                                                   // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                                              // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 16. EpisodeOfCare.team
                    this.Team = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Team",                                                                                                      // MakerGen.cs:235
                        Path= "EpisodeOfCare.team",                                                                                         // MakerGen.cs:236
                        Id = "EpisodeOfCare.team",                                                                                          // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/CareTeam"                                                      // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 17. EpisodeOfCare.account
                    this.Account = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Account",                                                                                                   // MakerGen.cs:235
                        Path= "EpisodeOfCare.account",                                                                                      // MakerGen.cs:236
                        Id = "EpisodeOfCare.account",                                                                                       // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Account"                                                       // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:398
            {                                                                                                                               // MakerGen.cs:399
                base.Write(sDef);                                                                                                           // MakerGen.cs:400
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:220
                Status.Write(sDef);                                                                                                         // MakerGen.cs:220
                StatusHistory.Write(sDef);                                                                                                  // MakerGen.cs:220
                Type.Write(sDef);                                                                                                           // MakerGen.cs:220
                Diagnosis.Write(sDef);                                                                                                      // MakerGen.cs:220
                Patient.Write(sDef);                                                                                                        // MakerGen.cs:220
                ManagingOrganization.Write(sDef);                                                                                           // MakerGen.cs:220
                Period.Write(sDef);                                                                                                         // MakerGen.cs:220
                ReferralRequest.Write(sDef);                                                                                                // MakerGen.cs:220
                CareManager.Write(sDef);                                                                                                    // MakerGen.cs:220
                Team.Write(sDef);                                                                                                           // MakerGen.cs:220
                Account.Write(sDef);                                                                                                        // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:402
        }                                                                                                                                   // MakerGen.cs:404
        public EpisodeOfCare_Elements Elements                                                                                              // MakerGen.cs:406
        {                                                                                                                                   // MakerGen.cs:407
            get                                                                                                                             // MakerGen.cs:408
            {                                                                                                                               // MakerGen.cs:409
                if (this.elements == null)                                                                                                  // MakerGen.cs:410
                    this.elements = new EpisodeOfCare_Elements();                                                                           // MakerGen.cs:411
                return this.elements;                                                                                                       // MakerGen.cs:412
            }                                                                                                                               // MakerGen.cs:413
        }                                                                                                                                   // MakerGen.cs:414
        EpisodeOfCare_Elements elements;                                                                                                    // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
        public EpisodeOfCare()                                                                                                              // MakerGen.cs:418
        {                                                                                                                                   // MakerGen.cs:419
            this.Name = "EpisodeOfCare";                                                                                                    // MakerGen.cs:492
            this.Uri = "http://hl7.org/fhir/StructureDefinition/EpisodeOfCare";                                                             // MakerGen.cs:493
        }                                                                                                                                   // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:424
        {                                                                                                                                   // MakerGen.cs:425
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:426
            {                                                                                                                               // MakerGen.cs:427
                Path = "EpisodeOfCare",                                                                                                     // MakerGen.cs:428
                ElementId = "EpisodeOfCare"                                                                                                 // MakerGen.cs:429
            });                                                                                                                             // MakerGen.cs:430
            if (this.elements != null)                                                                                                      // MakerGen.cs:431
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:432
        }                                                                                                                                   // MakerGen.cs:433
    }                                                                                                                                       // MakerGen.cs:434
}                                                                                                                                           // MakerGen.cs:479
