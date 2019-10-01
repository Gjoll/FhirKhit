using System;                                                                                                                               // MakerGen.cs:428
using System.Diagnostics;                                                                                                                   // MakerGen.cs:429
using System.IO;                                                                                                                            // MakerGen.cs:430
using System.Linq;                                                                                                                          // MakerGen.cs:431
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:432
                                                                                                                                            // MakerGen.cs:433
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:434
{                                                                                                                                           // MakerGen.cs:435
    #region Json                                                                                                                            // MakerGen.cs:436
    #if NEVER                                                                                                                               // MakerGen.cs:437
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
    #endregion                                                                                                                              // MakerGen.cs:440
    /// <summary>
    /// Fhir resource 'EpisodeOfCare'
    /// </summary>
    // 0. EpisodeOfCare
    public class Resource_EpisodeOfCare : FhirKhit.Maker.Common.Resource.ResourceBase                                                       // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        // 3. EpisodeOfCare.statusHistory
        public class Type_StatusHistory : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 4. EpisodeOfCare.statusHistory.status
            public ElementDefinitionInfo Element_Status;                                                                                    // MakerGen.cs:212
            // 5. EpisodeOfCare.statusHistory.period
            public ElementDefinitionInfo Element_Period;                                                                                    // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "EpisodeOfCare.statusHistory",                                                                                   // MakerGen.cs:388
                    ElementId = "EpisodeOfCare.statusHistory"                                                                               // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Status.Write(sDef);                                                                                                 // MakerGen.cs:216
                Element_Period.Write(sDef);                                                                                                 // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_StatusHistory()                                                                                                     // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 4. EpisodeOfCare.statusHistory.status
                    this.Element_Status = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Status",                                                                                            // MakerGen.cs:231
                        Path= "EpisodeOfCare.statusHistory.status",                                                                         // MakerGen.cs:232
                        Id = "EpisodeOfCare.statusHistory.status",                                                                          // MakerGen.cs:233
                        Min = 1,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                              // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 5. EpisodeOfCare.statusHistory.period
                    this.Element_Period = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Period",                                                                                            // MakerGen.cs:231
                        Path= "EpisodeOfCare.statusHistory.period",                                                                         // MakerGen.cs:232
                        Id = "EpisodeOfCare.statusHistory.period",                                                                          // MakerGen.cs:233
                        Min = 1,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Period                                                                   // MakerGen.cs:351
                            {                                                                                                               // MakerGen.cs:352
                            }                                                                                                               // MakerGen.cs:353
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 7. EpisodeOfCare.diagnosis
        public class Type_Diagnosis : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 8. EpisodeOfCare.diagnosis.condition
            public ElementDefinitionInfo Element_Condition;                                                                                 // MakerGen.cs:212
            // 9. EpisodeOfCare.diagnosis.role
            public ElementDefinitionInfo Element_Role;                                                                                      // MakerGen.cs:212
            // 10. EpisodeOfCare.diagnosis.rank
            public ElementDefinitionInfo Element_Rank;                                                                                      // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "EpisodeOfCare.diagnosis",                                                                                       // MakerGen.cs:388
                    ElementId = "EpisodeOfCare.diagnosis"                                                                                   // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Condition.Write(sDef);                                                                                              // MakerGen.cs:216
                Element_Role.Write(sDef);                                                                                                   // MakerGen.cs:216
                Element_Rank.Write(sDef);                                                                                                   // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_Diagnosis()                                                                                                         // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 8. EpisodeOfCare.diagnosis.condition
                    this.Element_Condition = new ElementDefinitionInfo                                                                      // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Condition",                                                                                         // MakerGen.cs:231
                        Path= "EpisodeOfCare.diagnosis.condition",                                                                          // MakerGen.cs:232
                        Id = "EpisodeOfCare.diagnosis.condition",                                                                           // MakerGen.cs:233
                        Min = 1,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:339
                            {                                                                                                               // MakerGen.cs:340
                                TargetProfile = new String[]                                                                                // MakerGen.cs:342
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Condition"                                                     // MakerGen.cs:342
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:343
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 9. EpisodeOfCare.diagnosis.role
                    this.Element_Role = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Role",                                                                                              // MakerGen.cs:231
                        Path= "EpisodeOfCare.diagnosis.role",                                                                               // MakerGen.cs:232
                        Id = "EpisodeOfCare.diagnosis.role",                                                                                // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 10. EpisodeOfCare.diagnosis.rank
                    this.Element_Rank = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Rank",                                                                                              // MakerGen.cs:231
                        Path= "EpisodeOfCare.diagnosis.rank",                                                                               // MakerGen.cs:232
                        Id = "EpisodeOfCare.diagnosis.rank",                                                                                // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_PositiveInt                                                       // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 1. EpisodeOfCare.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:212
        // 2. EpisodeOfCare.status
        public ElementDefinitionInfo Element_Status;                                                                                        // MakerGen.cs:212
        // 3. EpisodeOfCare.statusHistory
        public ElementDefinitionInfo Element_StatusHistory;                                                                                 // MakerGen.cs:212
        // 6. EpisodeOfCare.type
        public ElementDefinitionInfo Element_Type;                                                                                          // MakerGen.cs:212
        // 7. EpisodeOfCare.diagnosis
        public ElementDefinitionInfo Element_Diagnosis;                                                                                     // MakerGen.cs:212
        // 11. EpisodeOfCare.patient
        public ElementDefinitionInfo Element_Patient;                                                                                       // MakerGen.cs:212
        // 12. EpisodeOfCare.managingOrganization
        public ElementDefinitionInfo Element_ManagingOrganization;                                                                          // MakerGen.cs:212
        // 13. EpisodeOfCare.period
        public ElementDefinitionInfo Element_Period;                                                                                        // MakerGen.cs:212
        // 14. EpisodeOfCare.referralRequest
        public ElementDefinitionInfo Element_ReferralRequest;                                                                               // MakerGen.cs:212
        // 15. EpisodeOfCare.careManager
        public ElementDefinitionInfo Element_CareManager;                                                                                   // MakerGen.cs:212
        // 16. EpisodeOfCare.team
        public ElementDefinitionInfo Element_Team;                                                                                          // MakerGen.cs:212
        // 17. EpisodeOfCare.account
        public ElementDefinitionInfo Element_Account;                                                                                       // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            base.Write(sDef);                                                                                                               // MakerGen.cs:385
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:386
            {                                                                                                                               // MakerGen.cs:387
                Path = "EpisodeOfCare",                                                                                                     // MakerGen.cs:388
                ElementId = "EpisodeOfCare"                                                                                                 // MakerGen.cs:389
            });                                                                                                                             // MakerGen.cs:390
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_Status.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_StatusHistory.Write(sDef);                                                                                              // MakerGen.cs:216
            Element_Type.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_Diagnosis.Write(sDef);                                                                                                  // MakerGen.cs:216
            Element_Patient.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_ManagingOrganization.Write(sDef);                                                                                       // MakerGen.cs:216
            Element_Period.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_ReferralRequest.Write(sDef);                                                                                            // MakerGen.cs:216
            Element_CareManager.Write(sDef);                                                                                                // MakerGen.cs:216
            Element_Team.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_Account.Write(sDef);                                                                                                    // MakerGen.cs:216
        }                                                                                                                                   // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
        public Resource_EpisodeOfCare()                                                                                                     // MakerGen.cs:395
        {                                                                                                                                   // MakerGen.cs:396
            {                                                                                                                               // MakerGen.cs:227
                // 1. EpisodeOfCare.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:231
                    Path= "EpisodeOfCare.identifier",                                                                                       // MakerGen.cs:232
                    Id = "EpisodeOfCare.identifier",                                                                                        // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Identifier                                                                   // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 2. EpisodeOfCare.status
                this.Element_Status = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Status",                                                                                                // MakerGen.cs:231
                    Path= "EpisodeOfCare.status",                                                                                           // MakerGen.cs:232
                    Id = "EpisodeOfCare.status",                                                                                            // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
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
                // 3. EpisodeOfCare.statusHistory
                this.Element_StatusHistory = new ElementDefinitionInfo                                                                      // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_StatusHistory",                                                                                         // MakerGen.cs:231
                    Path= "EpisodeOfCare.statusHistory",                                                                                    // MakerGen.cs:232
                    Id = "EpisodeOfCare.statusHistory",                                                                                     // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_StatusHistory                                                                                              // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 6. EpisodeOfCare.type
                this.Element_Type = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Type",                                                                                                  // MakerGen.cs:231
                    Path= "EpisodeOfCare.type",                                                                                             // MakerGen.cs:232
                    Id = "EpisodeOfCare.type",                                                                                              // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 7. EpisodeOfCare.diagnosis
                this.Element_Diagnosis = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Diagnosis",                                                                                             // MakerGen.cs:231
                    Path= "EpisodeOfCare.diagnosis",                                                                                        // MakerGen.cs:232
                    Id = "EpisodeOfCare.diagnosis",                                                                                         // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_Diagnosis                                                                                                  // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 11. EpisodeOfCare.patient
                this.Element_Patient = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Patient",                                                                                               // MakerGen.cs:231
                    Path= "EpisodeOfCare.patient",                                                                                          // MakerGen.cs:232
                    Id = "EpisodeOfCare.patient",                                                                                           // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Patient"                                                           // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 12. EpisodeOfCare.managingOrganization
                this.Element_ManagingOrganization = new ElementDefinitionInfo                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_ManagingOrganization",                                                                                  // MakerGen.cs:231
                    Path= "EpisodeOfCare.managingOrganization",                                                                             // MakerGen.cs:232
                    Id = "EpisodeOfCare.managingOrganization",                                                                              // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Organization"                                                      // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 13. EpisodeOfCare.period
                this.Element_Period = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Period",                                                                                                // MakerGen.cs:231
                    Path= "EpisodeOfCare.period",                                                                                           // MakerGen.cs:232
                    Id = "EpisodeOfCare.period",                                                                                            // MakerGen.cs:233
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
            {                                                                                                                               // MakerGen.cs:227
                // 14. EpisodeOfCare.referralRequest
                this.Element_ReferralRequest = new ElementDefinitionInfo                                                                    // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_ReferralRequest",                                                                                       // MakerGen.cs:231
                    Path= "EpisodeOfCare.referralRequest",                                                                                  // MakerGen.cs:232
                    Id = "EpisodeOfCare.referralRequest",                                                                                   // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/ServiceRequest"                                                    // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 15. EpisodeOfCare.careManager
                this.Element_CareManager = new ElementDefinitionInfo                                                                        // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_CareManager",                                                                                           // MakerGen.cs:231
                    Path= "EpisodeOfCare.careManager",                                                                                      // MakerGen.cs:232
                    Id = "EpisodeOfCare.careManager",                                                                                       // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                     // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                                                  // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 16. EpisodeOfCare.team
                this.Element_Team = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Team",                                                                                                  // MakerGen.cs:231
                    Path= "EpisodeOfCare.team",                                                                                             // MakerGen.cs:232
                    Id = "EpisodeOfCare.team",                                                                                              // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/CareTeam"                                                          // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 17. EpisodeOfCare.account
                this.Element_Account = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Account",                                                                                               // MakerGen.cs:231
                    Path= "EpisodeOfCare.account",                                                                                          // MakerGen.cs:232
                    Id = "EpisodeOfCare.account",                                                                                           // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Account"                                                           // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            this.Name = "EpisodeOfCare";                                                                                                    // MakerGen.cs:458
            this.Uri = "http://hl7.org/fhir/StructureDefinition/EpisodeOfCare";                                                             // MakerGen.cs:459
        }                                                                                                                                   // MakerGen.cs:398
    }                                                                                                                                       // MakerGen.cs:400
}                                                                                                                                           // MakerGen.cs:445
