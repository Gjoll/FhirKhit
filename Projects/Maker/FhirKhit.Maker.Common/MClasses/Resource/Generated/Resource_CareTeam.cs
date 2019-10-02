using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;

namespace FhirKhit.Maker.Common.Resource
{
    #region Json
    #if NEVER
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
    #endregion
    /// <summary>
    /// Fhir resource 'CareTeam'
    /// </summary>
    // 0. CareTeam
    public class Resource_CareTeam : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 8. CareTeam.participant
        public class Type_Participant : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 9. CareTeam.participant.role
            public ElementDefinitionInfo Element_Role;
            // 10. CareTeam.participant.member
            public ElementDefinitionInfo Element_Member;
            // 11. CareTeam.participant.onBehalfOf
            public ElementDefinitionInfo Element_OnBehalfOf;
            // 12. CareTeam.participant.period
            public ElementDefinitionInfo Element_Period;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "CareTeam.participant",
                    ElementId = "CareTeam.participant"
                });
                Element_Role.Write(sDef);
                Element_Member.Write(sDef);
                Element_OnBehalfOf.Write(sDef);
                Element_Period.Write(sDef);
            }
            
            public Type_Participant()
            {
                {
                    // 9. CareTeam.participant.role
                    this.Element_Role = new ElementDefinitionInfo
                    {
                        Name = "Element_Role",
                        Path= "CareTeam.participant.role",
                        Id = "CareTeam.participant.role",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                            {
                            }
                        }
                    };
                }
                {
                    // 10. CareTeam.participant.member
                    this.Element_Member = new ElementDefinitionInfo
                    {
                        Name = "Element_Member",
                        Path= "CareTeam.participant.member",
                        Id = "CareTeam.participant.member",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                                    "http://hl7.org/fhir/StructureDefinition/Patient",
                                    "http://hl7.org/fhir/StructureDefinition/Organization",
                                    "http://hl7.org/fhir/StructureDefinition/CareTeam"
                                }
                            }
                        }
                    };
                }
                {
                    // 11. CareTeam.participant.onBehalfOf
                    this.Element_OnBehalfOf = new ElementDefinitionInfo
                    {
                        Name = "Element_OnBehalfOf",
                        Path= "CareTeam.participant.onBehalfOf",
                        Id = "CareTeam.participant.onBehalfOf",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/Organization"
                                }
                            }
                        }
                    };
                }
                {
                    // 12. CareTeam.participant.period
                    this.Element_Period = new ElementDefinitionInfo
                    {
                        Name = "Element_Period",
                        Path= "CareTeam.participant.period",
                        Id = "CareTeam.participant.period",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Period
                            {
                            }
                        }
                    };
                }
            }
        }
        // 1. CareTeam.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. CareTeam.status
        public ElementDefinitionInfo Element_Status;
        // 3. CareTeam.category
        public ElementDefinitionInfo Element_Category;
        // 4. CareTeam.name
        public ElementDefinitionInfo Element_Name;
        // 5. CareTeam.subject
        public ElementDefinitionInfo Element_Subject;
        // 6. CareTeam.encounter
        public ElementDefinitionInfo Element_Encounter;
        // 7. CareTeam.period
        public ElementDefinitionInfo Element_Period;
        // 8. CareTeam.participant
        public ElementDefinitionInfo Element_Participant;
        // 13. CareTeam.reasonCode
        public ElementDefinitionInfo Element_ReasonCode;
        // 14. CareTeam.reasonReference
        public ElementDefinitionInfo Element_ReasonReference;
        // 15. CareTeam.managingOrganization
        public ElementDefinitionInfo Element_ManagingOrganization;
        // 16. CareTeam.telecom
        public ElementDefinitionInfo Element_Telecom;
        // 17. CareTeam.note
        public ElementDefinitionInfo Element_Note;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "CareTeam",
                ElementId = "CareTeam"
            });
            Element_Identifier.Write(sDef);
            Element_Status.Write(sDef);
            Element_Category.Write(sDef);
            Element_Name.Write(sDef);
            Element_Subject.Write(sDef);
            Element_Encounter.Write(sDef);
            Element_Period.Write(sDef);
            Element_Participant.Write(sDef);
            Element_ReasonCode.Write(sDef);
            Element_ReasonReference.Write(sDef);
            Element_ManagingOrganization.Write(sDef);
            Element_Telecom.Write(sDef);
            Element_Note.Write(sDef);
        }
        
        public Resource_CareTeam()
        {
            {
                // 1. CareTeam.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "CareTeam.identifier",
                    Id = "CareTeam.identifier",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Identifier
                        {
                        }
                    }
                };
            }
            {
                // 2. CareTeam.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "CareTeam.status",
                    Id = "CareTeam.status",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code
                        {
                        }
                    }
                };
            }
            {
                // 3. CareTeam.category
                this.Element_Category = new ElementDefinitionInfo
                {
                    Name = "Element_Category",
                    Path= "CareTeam.category",
                    Id = "CareTeam.category",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                        {
                        }
                    }
                };
            }
            {
                // 4. CareTeam.name
                this.Element_Name = new ElementDefinitionInfo
                {
                    Name = "Element_Name",
                    Path= "CareTeam.name",
                    Id = "CareTeam.name",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_String
                        {
                        }
                    }
                };
            }
            {
                // 5. CareTeam.subject
                this.Element_Subject = new ElementDefinitionInfo
                {
                    Name = "Element_Subject",
                    Path= "CareTeam.subject",
                    Id = "CareTeam.subject",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Patient",
                                "http://hl7.org/fhir/StructureDefinition/Group"
                            }
                        }
                    }
                };
            }
            {
                // 6. CareTeam.encounter
                this.Element_Encounter = new ElementDefinitionInfo
                {
                    Name = "Element_Encounter",
                    Path= "CareTeam.encounter",
                    Id = "CareTeam.encounter",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Encounter"
                            }
                        }
                    }
                };
            }
            {
                // 7. CareTeam.period
                this.Element_Period = new ElementDefinitionInfo
                {
                    Name = "Element_Period",
                    Path= "CareTeam.period",
                    Id = "CareTeam.period",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Period
                        {
                        }
                    }
                };
            }
            {
                // 8. CareTeam.participant
                this.Element_Participant = new ElementDefinitionInfo
                {
                    Name = "Element_Participant",
                    Path= "CareTeam.participant",
                    Id = "CareTeam.participant",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Participant
                        {
                        }
                    }
                };
            }
            {
                // 13. CareTeam.reasonCode
                this.Element_ReasonCode = new ElementDefinitionInfo
                {
                    Name = "Element_ReasonCode",
                    Path= "CareTeam.reasonCode",
                    Id = "CareTeam.reasonCode",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                        {
                        }
                    }
                };
            }
            {
                // 14. CareTeam.reasonReference
                this.Element_ReasonReference = new ElementDefinitionInfo
                {
                    Name = "Element_ReasonReference",
                    Path= "CareTeam.reasonReference",
                    Id = "CareTeam.reasonReference",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Condition"
                            }
                        }
                    }
                };
            }
            {
                // 15. CareTeam.managingOrganization
                this.Element_ManagingOrganization = new ElementDefinitionInfo
                {
                    Name = "Element_ManagingOrganization",
                    Path= "CareTeam.managingOrganization",
                    Id = "CareTeam.managingOrganization",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Organization"
                            }
                        }
                    }
                };
            }
            {
                // 16. CareTeam.telecom
                this.Element_Telecom = new ElementDefinitionInfo
                {
                    Name = "Element_Telecom",
                    Path= "CareTeam.telecom",
                    Id = "CareTeam.telecom",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_ContactPoint
                        {
                        }
                    }
                };
            }
            {
                // 17. CareTeam.note
                this.Element_Note = new ElementDefinitionInfo
                {
                    Name = "Element_Note",
                    Path= "CareTeam.note",
                    Id = "CareTeam.note",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Annotation
                        {
                        }
                    }
                };
            }
            this.Name = "CareTeam";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/CareTeam";
        }
    }
}
