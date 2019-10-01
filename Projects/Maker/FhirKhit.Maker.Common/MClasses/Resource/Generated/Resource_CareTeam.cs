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
      "id": "CareTeam",
      "url": "http://hl7.org/fhir/StructureDefinition/CareTeam",
      "version": "4.0.0",
      "name": "CareTeam",
      "status": "draft",
      "publisher": "Health Level Seven International (Patient Care)",
      "description": "The Care Team includes all the people and organizations who plan to participate in the coordination and delivery of care for a patient.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "CareTeam",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "CareTeam",
            "path": "CareTeam",
            "short": "Planned participants in the coordination and delivery of care for a patient or group",
            "definition": "The Care Team includes all the people and organizations who plan to participate in the coordination and delivery of care for a patient.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "CareTeam.identifier",
            "path": "CareTeam.identifier",
            "short": "External Ids for this team",
            "definition": "Business identifiers assigned to this care team by the performer or other systems which remain constant as the resource is updated and propagates from server to server.",
            "comment": "This is a business identifier, not a resource identifier (see [discussion](resource.html#identifiers)).  It is best practice for the identifier to only appear on a single resource instance, however business practices may occasionally dictate that multiple resource instances with the same identifier can exist - possibly even with different resource types.  For example, multiple Patient and a Person resource instance might share the same social insurance number.",
            "requirements": "Allows identification of the care team as it is known by various participating systems and in a way that remains consistent across servers.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Identifier"
              }
            ],
            "isSummary": true
          },
          {
            "id": "CareTeam.status",
            "path": "CareTeam.status",
            "short": "proposed | active | suspended | inactive | entered-in-error",
            "definition": "Indicates the current state of the care team.",
            "comment": "This element is labeled as a modifier because the status contains the code entered-in-error that marks the care team as not currently valid.",
            "min": 0,
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
                  "valueString": "CareTeamStatus"
                }
              ],
              "strength": "required",
              "description": "Indicates the status of the care team.",
              "valueSet": "http://hl7.org/fhir/ValueSet/care-team-status|4.0.0"
            }
          },
          {
            "id": "CareTeam.category",
            "path": "CareTeam.category",
            "short": "Type of team",
            "definition": "Identifies what kind of team.  This is to support differentiation between multiple co-existing teams, such as care plan team, episode of care team, longitudinal care team.",
            "comment": "There may be multiple axis of categorization and one team may serve multiple purposes.",
            "requirements": "Used for filtering what teams(s) are retrieved and displayed to different types of users.",
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
                  "valueString": "CareTeamCategory"
                }
              ],
              "strength": "example",
              "description": "Indicates the type of care team.",
              "valueSet": "http://hl7.org/fhir/ValueSet/care-team-category"
            }
          },
          {
            "id": "CareTeam.name",
            "path": "CareTeam.name",
            "short": "Name of the team, such as crisis assessment team",
            "definition": "A label for human use intended to distinguish like teams.  E.g. the \"red\" vs. \"green\" trauma teams.",
            "comment": "The meaning/purpose of the team is conveyed in CareTeam.category.  This element may also convey semantics of the team (e.g. \"Red trauma team\"), but its primary purpose is to distinguish between identical teams in a human-friendly way.  (\"Team 18735\" isn't as friendly.).",
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
            "id": "CareTeam.subject",
            "path": "CareTeam.subject",
            "short": "Who care team is for",
            "definition": "Identifies the patient or group whose intended care is handled by the team.",
            "requirements": "Allows the team to care for a group (e.g. marriage) therapy. \nAllows for an organization to designate a team such as the PICC line team.",
            "alias": [
              "patient"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Group"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "CareTeam.encounter",
            "path": "CareTeam.encounter",
            "short": "Encounter created as part of",
            "definition": "The Encounter during which this CareTeam was created or to which the creation of this record is tightly associated.",
            "comment": "This will typically be the encounter the event occurred within, but some activities may be initiated prior to or after the official completion of an encounter but still be tied to the context of the encounter.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Encounter"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "CareTeam.period",
            "path": "CareTeam.period",
            "short": "Time period team covers",
            "definition": "Indicates when the team did (or is intended to) come into effect and end.",
            "requirements": "Allows tracking what team(s) are in effect at a particular time.",
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
            "id": "CareTeam.participant",
            "path": "CareTeam.participant",
            "short": "Members of the team",
            "definition": "Identifies all people and organizations who are expected to be involved in the care team.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "condition": [
              "ctm-1"
            ]
          },
          {
            "id": "CareTeam.participant.role",
            "path": "CareTeam.participant.role",
            "short": "Type of involvement",
            "definition": "Indicates specific responsibility of an individual within the care team, such as \"Primary care physician\", \"Trained social worker counselor\", \"Caregiver\", etc.",
            "comment": "Roles may sometimes be inferred by type of Practitioner.  These are relationships that hold only within the context of the care team.  General relationships should be handled as properties of the Patient resource directly.",
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
                  "valueString": "CareTeamParticipantRole"
                }
              ],
              "strength": "example",
              "description": "Indicates specific responsibility of an individual within the care team, such as \"Primary physician\", \"Team coordinator\", \"Caregiver\", etc.",
              "valueSet": "http://hl7.org/fhir/ValueSet/participant-role"
            }
          },
          {
            "id": "CareTeam.participant.member",
            "path": "CareTeam.participant.member",
            "short": "Who is involved",
            "definition": "The specific person or organization who is participating/expected to participate in the care team.",
            "comment": "Patient only needs to be listed if they have a role other than \"subject of care\".\n\nMember is optional because some participants may be known only by their role, particularly in draft plans.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Organization",
                  "http://hl7.org/fhir/StructureDefinition/CareTeam"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "CareTeam.participant.onBehalfOf",
            "path": "CareTeam.participant.onBehalfOf",
            "short": "Organization of the practitioner",
            "definition": "The organization of the practitioner.",
            "requirements": "Practitioners can be associated with multiple organizations.  This element indicates which organization they were acting on behalf of.",
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
            "id": "CareTeam.participant.period",
            "path": "CareTeam.participant.period",
            "short": "Time period of participant",
            "definition": "Indicates when the specific member or organization did (or is intended to) come into effect and end.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Period"
              }
            ]
          },
          {
            "id": "CareTeam.reasonCode",
            "path": "CareTeam.reasonCode",
            "short": "Why the care team exists",
            "definition": "Describes why the care team exists.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "CareTeamReason"
                }
              ],
              "strength": "example",
              "description": "Indicates the reason for the care team.",
              "valueSet": "http://hl7.org/fhir/ValueSet/clinical-findings"
            }
          },
          {
            "id": "CareTeam.reasonReference",
            "path": "CareTeam.reasonReference",
            "short": "Why the care team exists",
            "definition": "Condition(s) that this care team addresses.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Condition"
                ]
              }
            ]
          },
          {
            "id": "CareTeam.managingOrganization",
            "path": "CareTeam.managingOrganization",
            "short": "Organization responsible for the care team",
            "definition": "The organization responsible for the care team.",
            "requirements": "Allows for multiple organizations to collaboratively manage cross-organizational, longitudinal care plan.",
            "min": 0,
            "max": "*",
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
            "id": "CareTeam.telecom",
            "path": "CareTeam.telecom",
            "short": "A contact detail for the care team (that applies to all members)",
            "definition": "A central contact detail for the care team (that applies to all members).",
            "comment": "The ContactPoint.use code of home is not appropriate to use. These contacts are not the contact details of individual care team members.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "ContactPoint"
              }
            ]
          },
          {
            "id": "CareTeam.note",
            "path": "CareTeam.note",
            "short": "Comments made about the CareTeam",
            "definition": "Comments made about the CareTeam.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Annotation"
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:440
    /// <summary>
    /// Fhir resource 'CareTeam'
    /// </summary>
    // 0. CareTeam
    public class Resource_CareTeam : FhirKhit.Maker.Common.Resource.ResourceBase                                                            // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        // 8. CareTeam.participant
        public class Type_Participant : FhirKhit.Maker.Common.Complex.ComplexBase                                                           // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 9. CareTeam.participant.role
            public ElementDefinitionInfo Element_Role;                                                                                      // MakerGen.cs:212
            // 10. CareTeam.participant.member
            public ElementDefinitionInfo Element_Member;                                                                                    // MakerGen.cs:212
            // 11. CareTeam.participant.onBehalfOf
            public ElementDefinitionInfo Element_OnBehalfOf;                                                                                // MakerGen.cs:212
            // 12. CareTeam.participant.period
            public ElementDefinitionInfo Element_Period;                                                                                    // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "CareTeam.participant",                                                                                          // MakerGen.cs:388
                    ElementId = "CareTeam.participant"                                                                                      // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Role.Write(sDef);                                                                                                   // MakerGen.cs:216
                Element_Member.Write(sDef);                                                                                                 // MakerGen.cs:216
                Element_OnBehalfOf.Write(sDef);                                                                                             // MakerGen.cs:216
                Element_Period.Write(sDef);                                                                                                 // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_Participant()                                                                                                       // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 9. CareTeam.participant.role
                    this.Element_Role = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Role",                                                                                              // MakerGen.cs:231
                        Path= "CareTeam.participant.role",                                                                                  // MakerGen.cs:232
                        Id = "CareTeam.participant.role",                                                                                   // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 10. CareTeam.participant.member
                    this.Element_Member = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Member",                                                                                            // MakerGen.cs:231
                        Path= "CareTeam.participant.member",                                                                                // MakerGen.cs:232
                        Id = "CareTeam.participant.member",                                                                                 // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:339
                            {                                                                                                               // MakerGen.cs:340
                                TargetProfile = new String[]                                                                                // MakerGen.cs:342
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:342
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:342
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson",                                                // MakerGen.cs:342
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:342
                                    "http://hl7.org/fhir/StructureDefinition/Organization",                                                 // MakerGen.cs:342
                                    "http://hl7.org/fhir/StructureDefinition/CareTeam"                                                      // MakerGen.cs:342
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:343
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 11. CareTeam.participant.onBehalfOf
                    this.Element_OnBehalfOf = new ElementDefinitionInfo                                                                     // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_OnBehalfOf",                                                                                        // MakerGen.cs:231
                        Path= "CareTeam.participant.onBehalfOf",                                                                            // MakerGen.cs:232
                        Id = "CareTeam.participant.onBehalfOf",                                                                             // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:339
                            {                                                                                                               // MakerGen.cs:340
                                TargetProfile = new String[]                                                                                // MakerGen.cs:342
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:342
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:343
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 12. CareTeam.participant.period
                    this.Element_Period = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Period",                                                                                            // MakerGen.cs:231
                        Path= "CareTeam.participant.period",                                                                                // MakerGen.cs:232
                        Id = "CareTeam.participant.period",                                                                                 // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
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
        // 1. CareTeam.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:212
        // 2. CareTeam.status
        public ElementDefinitionInfo Element_Status;                                                                                        // MakerGen.cs:212
        // 3. CareTeam.category
        public ElementDefinitionInfo Element_Category;                                                                                      // MakerGen.cs:212
        // 4. CareTeam.name
        public ElementDefinitionInfo Element_Name;                                                                                          // MakerGen.cs:212
        // 5. CareTeam.subject
        public ElementDefinitionInfo Element_Subject;                                                                                       // MakerGen.cs:212
        // 6. CareTeam.encounter
        public ElementDefinitionInfo Element_Encounter;                                                                                     // MakerGen.cs:212
        // 7. CareTeam.period
        public ElementDefinitionInfo Element_Period;                                                                                        // MakerGen.cs:212
        // 8. CareTeam.participant
        public ElementDefinitionInfo Element_Participant;                                                                                   // MakerGen.cs:212
        // 13. CareTeam.reasonCode
        public ElementDefinitionInfo Element_ReasonCode;                                                                                    // MakerGen.cs:212
        // 14. CareTeam.reasonReference
        public ElementDefinitionInfo Element_ReasonReference;                                                                               // MakerGen.cs:212
        // 15. CareTeam.managingOrganization
        public ElementDefinitionInfo Element_ManagingOrganization;                                                                          // MakerGen.cs:212
        // 16. CareTeam.telecom
        public ElementDefinitionInfo Element_Telecom;                                                                                       // MakerGen.cs:212
        // 17. CareTeam.note
        public ElementDefinitionInfo Element_Note;                                                                                          // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            base.Write(sDef);                                                                                                               // MakerGen.cs:385
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:386
            {                                                                                                                               // MakerGen.cs:387
                Path = "CareTeam",                                                                                                          // MakerGen.cs:388
                ElementId = "CareTeam"                                                                                                      // MakerGen.cs:389
            });                                                                                                                             // MakerGen.cs:390
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_Status.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_Category.Write(sDef);                                                                                                   // MakerGen.cs:216
            Element_Name.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_Subject.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_Encounter.Write(sDef);                                                                                                  // MakerGen.cs:216
            Element_Period.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_Participant.Write(sDef);                                                                                                // MakerGen.cs:216
            Element_ReasonCode.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_ReasonReference.Write(sDef);                                                                                            // MakerGen.cs:216
            Element_ManagingOrganization.Write(sDef);                                                                                       // MakerGen.cs:216
            Element_Telecom.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_Note.Write(sDef);                                                                                                       // MakerGen.cs:216
        }                                                                                                                                   // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
        public Resource_CareTeam()                                                                                                          // MakerGen.cs:395
        {                                                                                                                                   // MakerGen.cs:396
            {                                                                                                                               // MakerGen.cs:227
                // 1. CareTeam.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:231
                    Path= "CareTeam.identifier",                                                                                            // MakerGen.cs:232
                    Id = "CareTeam.identifier",                                                                                             // MakerGen.cs:233
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
                // 2. CareTeam.status
                this.Element_Status = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Status",                                                                                                // MakerGen.cs:231
                    Path= "CareTeam.status",                                                                                                // MakerGen.cs:232
                    Id = "CareTeam.status",                                                                                                 // MakerGen.cs:233
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
                // 3. CareTeam.category
                this.Element_Category = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Category",                                                                                              // MakerGen.cs:231
                    Path= "CareTeam.category",                                                                                              // MakerGen.cs:232
                    Id = "CareTeam.category",                                                                                               // MakerGen.cs:233
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
                // 4. CareTeam.name
                this.Element_Name = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Name",                                                                                                  // MakerGen.cs:231
                    Path= "CareTeam.name",                                                                                                  // MakerGen.cs:232
                    Id = "CareTeam.name",                                                                                                   // MakerGen.cs:233
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
                // 5. CareTeam.subject
                this.Element_Subject = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Subject",                                                                                               // MakerGen.cs:231
                    Path= "CareTeam.subject",                                                                                               // MakerGen.cs:232
                    Id = "CareTeam.subject",                                                                                                // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Patient",                                                          // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Group"                                                             // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 6. CareTeam.encounter
                this.Element_Encounter = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Encounter",                                                                                             // MakerGen.cs:231
                    Path= "CareTeam.encounter",                                                                                             // MakerGen.cs:232
                    Id = "CareTeam.encounter",                                                                                              // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Encounter"                                                         // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 7. CareTeam.period
                this.Element_Period = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Period",                                                                                                // MakerGen.cs:231
                    Path= "CareTeam.period",                                                                                                // MakerGen.cs:232
                    Id = "CareTeam.period",                                                                                                 // MakerGen.cs:233
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
                // 8. CareTeam.participant
                this.Element_Participant = new ElementDefinitionInfo                                                                        // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Participant",                                                                                           // MakerGen.cs:231
                    Path= "CareTeam.participant",                                                                                           // MakerGen.cs:232
                    Id = "CareTeam.participant",                                                                                            // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_Participant                                                                                                // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 13. CareTeam.reasonCode
                this.Element_ReasonCode = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_ReasonCode",                                                                                            // MakerGen.cs:231
                    Path= "CareTeam.reasonCode",                                                                                            // MakerGen.cs:232
                    Id = "CareTeam.reasonCode",                                                                                             // MakerGen.cs:233
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
                // 14. CareTeam.reasonReference
                this.Element_ReasonReference = new ElementDefinitionInfo                                                                    // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_ReasonReference",                                                                                       // MakerGen.cs:231
                    Path= "CareTeam.reasonReference",                                                                                       // MakerGen.cs:232
                    Id = "CareTeam.reasonReference",                                                                                        // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Condition"                                                         // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 15. CareTeam.managingOrganization
                this.Element_ManagingOrganization = new ElementDefinitionInfo                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_ManagingOrganization",                                                                                  // MakerGen.cs:231
                    Path= "CareTeam.managingOrganization",                                                                                  // MakerGen.cs:232
                    Id = "CareTeam.managingOrganization",                                                                                   // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
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
                // 16. CareTeam.telecom
                this.Element_Telecom = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Telecom",                                                                                               // MakerGen.cs:231
                    Path= "CareTeam.telecom",                                                                                               // MakerGen.cs:232
                    Id = "CareTeam.telecom",                                                                                                // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_ContactPoint                                                                 // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 17. CareTeam.note
                this.Element_Note = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Note",                                                                                                  // MakerGen.cs:231
                    Path= "CareTeam.note",                                                                                                  // MakerGen.cs:232
                    Id = "CareTeam.note",                                                                                                   // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Annotation                                                                   // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            this.Name = "CareTeam";                                                                                                         // MakerGen.cs:458
            this.Uri = "http://hl7.org/fhir/StructureDefinition/CareTeam";                                                                  // MakerGen.cs:459
        }                                                                                                                                   // MakerGen.cs:398
    }                                                                                                                                       // MakerGen.cs:400
}                                                                                                                                           // MakerGen.cs:445
