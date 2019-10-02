using System;                                                                                                                               // MakerGen.cs:435
using System.Diagnostics;                                                                                                                   // MakerGen.cs:436
using System.IO;                                                                                                                            // MakerGen.cs:437
using System.Linq;                                                                                                                          // MakerGen.cs:438
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:439
                                                                                                                                            // MakerGen.cs:440
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:441
{                                                                                                                                           // MakerGen.cs:442
    #region Json                                                                                                                            // MakerGen.cs:443
    #if NEVER                                                                                                                               // MakerGen.cs:444
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
    #endregion                                                                                                                              // MakerGen.cs:447
    /// <summary>
    /// Fhir resource 'EpisodeOfCare'
    /// </summary>
    // 0. EpisodeOfCare
    public class Resource_EpisodeOfCare : FhirKhit.Maker.Common.Resource.Resource_DomainResource                                            // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        // 3. EpisodeOfCare.statusHistory
        public class Type_StatusHistory : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 4. EpisodeOfCare.statusHistory.status
            public ElementDefinitionInfo Element_Status;                                                                                    // MakerGen.cs:219
            // 5. EpisodeOfCare.statusHistory.period
            public ElementDefinitionInfo Element_Period;                                                                                    // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "EpisodeOfCare.statusHistory",                                                                                   // MakerGen.cs:395
                    ElementId = "EpisodeOfCare.statusHistory"                                                                               // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Status.Write(sDef);                                                                                                 // MakerGen.cs:223
                Element_Period.Write(sDef);                                                                                                 // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_StatusHistory()                                                                                                     // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 4. EpisodeOfCare.statusHistory.status
                    this.Element_Status = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Status",                                                                                            // MakerGen.cs:238
                        Path= "EpisodeOfCare.statusHistory.status",                                                                         // MakerGen.cs:239
                        Id = "EpisodeOfCare.statusHistory.status",                                                                          // MakerGen.cs:240
                        Min = 1,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                              // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 5. EpisodeOfCare.statusHistory.period
                    this.Element_Period = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Period",                                                                                            // MakerGen.cs:238
                        Path= "EpisodeOfCare.statusHistory.period",                                                                         // MakerGen.cs:239
                        Id = "EpisodeOfCare.statusHistory.period",                                                                          // MakerGen.cs:240
                        Min = 1,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Period                                                                   // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 7. EpisodeOfCare.diagnosis
        public class Type_Diagnosis : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 8. EpisodeOfCare.diagnosis.condition
            public ElementDefinitionInfo Element_Condition;                                                                                 // MakerGen.cs:219
            // 9. EpisodeOfCare.diagnosis.role
            public ElementDefinitionInfo Element_Role;                                                                                      // MakerGen.cs:219
            // 10. EpisodeOfCare.diagnosis.rank
            public ElementDefinitionInfo Element_Rank;                                                                                      // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "EpisodeOfCare.diagnosis",                                                                                       // MakerGen.cs:395
                    ElementId = "EpisodeOfCare.diagnosis"                                                                                   // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Condition.Write(sDef);                                                                                              // MakerGen.cs:223
                Element_Role.Write(sDef);                                                                                                   // MakerGen.cs:223
                Element_Rank.Write(sDef);                                                                                                   // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_Diagnosis()                                                                                                         // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 8. EpisodeOfCare.diagnosis.condition
                    this.Element_Condition = new ElementDefinitionInfo                                                                      // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Condition",                                                                                         // MakerGen.cs:238
                        Path= "EpisodeOfCare.diagnosis.condition",                                                                          // MakerGen.cs:239
                        Id = "EpisodeOfCare.diagnosis.condition",                                                                           // MakerGen.cs:240
                        Min = 1,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Condition"                                                     // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 9. EpisodeOfCare.diagnosis.role
                    this.Element_Role = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Role",                                                                                              // MakerGen.cs:238
                        Path= "EpisodeOfCare.diagnosis.role",                                                                               // MakerGen.cs:239
                        Id = "EpisodeOfCare.diagnosis.role",                                                                                // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:318
                            {                                                                                                               // MakerGen.cs:319
                            }                                                                                                               // MakerGen.cs:322
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 10. EpisodeOfCare.diagnosis.rank
                    this.Element_Rank = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Rank",                                                                                              // MakerGen.cs:238
                        Path= "EpisodeOfCare.diagnosis.rank",                                                                               // MakerGen.cs:239
                        Id = "EpisodeOfCare.diagnosis.rank",                                                                                // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_PositiveInt                                                       // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 1. EpisodeOfCare.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:219
        // 2. EpisodeOfCare.status
        public ElementDefinitionInfo Element_Status;                                                                                        // MakerGen.cs:219
        // 3. EpisodeOfCare.statusHistory
        public ElementDefinitionInfo Element_StatusHistory;                                                                                 // MakerGen.cs:219
        // 6. EpisodeOfCare.type
        public ElementDefinitionInfo Element_Type;                                                                                          // MakerGen.cs:219
        // 7. EpisodeOfCare.diagnosis
        public ElementDefinitionInfo Element_Diagnosis;                                                                                     // MakerGen.cs:219
        // 11. EpisodeOfCare.patient
        public ElementDefinitionInfo Element_Patient;                                                                                       // MakerGen.cs:219
        // 12. EpisodeOfCare.managingOrganization
        public ElementDefinitionInfo Element_ManagingOrganization;                                                                          // MakerGen.cs:219
        // 13. EpisodeOfCare.period
        public ElementDefinitionInfo Element_Period;                                                                                        // MakerGen.cs:219
        // 14. EpisodeOfCare.referralRequest
        public ElementDefinitionInfo Element_ReferralRequest;                                                                               // MakerGen.cs:219
        // 15. EpisodeOfCare.careManager
        public ElementDefinitionInfo Element_CareManager;                                                                                   // MakerGen.cs:219
        // 16. EpisodeOfCare.team
        public ElementDefinitionInfo Element_Team;                                                                                          // MakerGen.cs:219
        // 17. EpisodeOfCare.account
        public ElementDefinitionInfo Element_Account;                                                                                       // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:390
        {                                                                                                                                   // MakerGen.cs:391
            base.Write(sDef);                                                                                                               // MakerGen.cs:392
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                Path = "EpisodeOfCare",                                                                                                     // MakerGen.cs:395
                ElementId = "EpisodeOfCare"                                                                                                 // MakerGen.cs:396
            });                                                                                                                             // MakerGen.cs:397
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_Status.Write(sDef);                                                                                                     // MakerGen.cs:223
            Element_StatusHistory.Write(sDef);                                                                                              // MakerGen.cs:223
            Element_Type.Write(sDef);                                                                                                       // MakerGen.cs:223
            Element_Diagnosis.Write(sDef);                                                                                                  // MakerGen.cs:223
            Element_Patient.Write(sDef);                                                                                                    // MakerGen.cs:223
            Element_ManagingOrganization.Write(sDef);                                                                                       // MakerGen.cs:223
            Element_Period.Write(sDef);                                                                                                     // MakerGen.cs:223
            Element_ReferralRequest.Write(sDef);                                                                                            // MakerGen.cs:223
            Element_CareManager.Write(sDef);                                                                                                // MakerGen.cs:223
            Element_Team.Write(sDef);                                                                                                       // MakerGen.cs:223
            Element_Account.Write(sDef);                                                                                                    // MakerGen.cs:223
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
        public Resource_EpisodeOfCare()                                                                                                     // MakerGen.cs:402
        {                                                                                                                                   // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:234
                // 1. EpisodeOfCare.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:238
                    Path= "EpisodeOfCare.identifier",                                                                                       // MakerGen.cs:239
                    Id = "EpisodeOfCare.identifier",                                                                                        // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Identifier                                                                   // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 2. EpisodeOfCare.status
                this.Element_Status = new ElementDefinitionInfo                                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Status",                                                                                                // MakerGen.cs:238
                    Path= "EpisodeOfCare.status",                                                                                           // MakerGen.cs:239
                    Id = "EpisodeOfCare.status",                                                                                            // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
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
                // 3. EpisodeOfCare.statusHistory
                this.Element_StatusHistory = new ElementDefinitionInfo                                                                      // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_StatusHistory",                                                                                         // MakerGen.cs:238
                    Path= "EpisodeOfCare.statusHistory",                                                                                    // MakerGen.cs:239
                    Id = "EpisodeOfCare.statusHistory",                                                                                     // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_StatusHistory                                                                                              // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 6. EpisodeOfCare.type
                this.Element_Type = new ElementDefinitionInfo                                                                               // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Type",                                                                                                  // MakerGen.cs:238
                    Path= "EpisodeOfCare.type",                                                                                             // MakerGen.cs:239
                    Id = "EpisodeOfCare.type",                                                                                              // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:322
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 7. EpisodeOfCare.diagnosis
                this.Element_Diagnosis = new ElementDefinitionInfo                                                                          // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Diagnosis",                                                                                             // MakerGen.cs:238
                    Path= "EpisodeOfCare.diagnosis",                                                                                        // MakerGen.cs:239
                    Id = "EpisodeOfCare.diagnosis",                                                                                         // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_Diagnosis                                                                                                  // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 11. EpisodeOfCare.patient
                this.Element_Patient = new ElementDefinitionInfo                                                                            // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Patient",                                                                                               // MakerGen.cs:238
                    Path= "EpisodeOfCare.patient",                                                                                          // MakerGen.cs:239
                    Id = "EpisodeOfCare.patient",                                                                                           // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Patient"                                                           // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 12. EpisodeOfCare.managingOrganization
                this.Element_ManagingOrganization = new ElementDefinitionInfo                                                               // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_ManagingOrganization",                                                                                  // MakerGen.cs:238
                    Path= "EpisodeOfCare.managingOrganization",                                                                             // MakerGen.cs:239
                    Id = "EpisodeOfCare.managingOrganization",                                                                              // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Organization"                                                      // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 13. EpisodeOfCare.period
                this.Element_Period = new ElementDefinitionInfo                                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Period",                                                                                                // MakerGen.cs:238
                    Path= "EpisodeOfCare.period",                                                                                           // MakerGen.cs:239
                    Id = "EpisodeOfCare.period",                                                                                            // MakerGen.cs:240
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
            {                                                                                                                               // MakerGen.cs:234
                // 14. EpisodeOfCare.referralRequest
                this.Element_ReferralRequest = new ElementDefinitionInfo                                                                    // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_ReferralRequest",                                                                                       // MakerGen.cs:238
                    Path= "EpisodeOfCare.referralRequest",                                                                                  // MakerGen.cs:239
                    Id = "EpisodeOfCare.referralRequest",                                                                                   // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/ServiceRequest"                                                    // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 15. EpisodeOfCare.careManager
                this.Element_CareManager = new ElementDefinitionInfo                                                                        // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_CareManager",                                                                                           // MakerGen.cs:238
                    Path= "EpisodeOfCare.careManager",                                                                                      // MakerGen.cs:239
                    Id = "EpisodeOfCare.careManager",                                                                                       // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                     // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                                                  // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 16. EpisodeOfCare.team
                this.Element_Team = new ElementDefinitionInfo                                                                               // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Team",                                                                                                  // MakerGen.cs:238
                    Path= "EpisodeOfCare.team",                                                                                             // MakerGen.cs:239
                    Id = "EpisodeOfCare.team",                                                                                              // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/CareTeam"                                                          // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 17. EpisodeOfCare.account
                this.Element_Account = new ElementDefinitionInfo                                                                            // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Account",                                                                                               // MakerGen.cs:238
                    Path= "EpisodeOfCare.account",                                                                                          // MakerGen.cs:239
                    Id = "EpisodeOfCare.account",                                                                                           // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Account"                                                           // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            this.Name = "EpisodeOfCare";                                                                                                    // MakerGen.cs:471
            this.Uri = "http://hl7.org/fhir/StructureDefinition/EpisodeOfCare";                                                             // MakerGen.cs:472
        }                                                                                                                                   // MakerGen.cs:405
    }                                                                                                                                       // MakerGen.cs:407
}                                                                                                                                           // MakerGen.cs:452
