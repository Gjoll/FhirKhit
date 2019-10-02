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
    #endregion
    /// <summary>
    /// Fhir resource 'EpisodeOfCare'
    /// </summary>
    // 0. EpisodeOfCare
    public partial class Resource_EpisodeOfCare : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 3. EpisodeOfCare.statusHistory
        public partial class Type_StatusHistory : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 4. EpisodeOfCare.statusHistory.status
            public ElementDefinitionInfo Element_Status;
            // 5. EpisodeOfCare.statusHistory.period
            public ElementDefinitionInfo Element_Period;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "EpisodeOfCare.statusHistory",
                    ElementId = "EpisodeOfCare.statusHistory"
                });
                Element_Status.Write(sDef);
                Element_Period.Write(sDef);
            }
            
            public Type_StatusHistory()
            {
                {
                    // 4. EpisodeOfCare.statusHistory.status
                    this.Element_Status = new ElementDefinitionInfo
                    {
                        Name = "Element_Status",
                        Path= "EpisodeOfCare.statusHistory.status",
                        Id = "EpisodeOfCare.statusHistory.status",
                        Min = 1,
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
                    // 5. EpisodeOfCare.statusHistory.period
                    this.Element_Period = new ElementDefinitionInfo
                    {
                        Name = "Element_Period",
                        Path= "EpisodeOfCare.statusHistory.period",
                        Id = "EpisodeOfCare.statusHistory.period",
                        Min = 1,
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
        // 7. EpisodeOfCare.diagnosis
        public partial class Type_Diagnosis : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 8. EpisodeOfCare.diagnosis.condition
            public ElementDefinitionInfo Element_Condition;
            // 9. EpisodeOfCare.diagnosis.role
            public ElementDefinitionInfo Element_Role;
            // 10. EpisodeOfCare.diagnosis.rank
            public ElementDefinitionInfo Element_Rank;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "EpisodeOfCare.diagnosis",
                    ElementId = "EpisodeOfCare.diagnosis"
                });
                Element_Condition.Write(sDef);
                Element_Role.Write(sDef);
                Element_Rank.Write(sDef);
            }
            
            public Type_Diagnosis()
            {
                {
                    // 8. EpisodeOfCare.diagnosis.condition
                    this.Element_Condition = new ElementDefinitionInfo
                    {
                        Name = "Element_Condition",
                        Path= "EpisodeOfCare.diagnosis.condition",
                        Id = "EpisodeOfCare.diagnosis.condition",
                        Min = 1,
                        Max = 1,
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
                    // 9. EpisodeOfCare.diagnosis.role
                    this.Element_Role = new ElementDefinitionInfo
                    {
                        Name = "Element_Role",
                        Path= "EpisodeOfCare.diagnosis.role",
                        Id = "EpisodeOfCare.diagnosis.role",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                            {
                            }
                        }
                    };
                }
                {
                    // 10. EpisodeOfCare.diagnosis.rank
                    this.Element_Rank = new ElementDefinitionInfo
                    {
                        Name = "Element_Rank",
                        Path= "EpisodeOfCare.diagnosis.rank",
                        Id = "EpisodeOfCare.diagnosis.rank",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_PositiveInt
                            {
                            }
                        }
                    };
                }
            }
        }
        // 1. EpisodeOfCare.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. EpisodeOfCare.status
        public ElementDefinitionInfo Element_Status;
        // 3. EpisodeOfCare.statusHistory
        public ElementDefinitionInfo Element_StatusHistory;
        // 6. EpisodeOfCare.type
        public ElementDefinitionInfo Element_Type;
        // 7. EpisodeOfCare.diagnosis
        public ElementDefinitionInfo Element_Diagnosis;
        // 11. EpisodeOfCare.patient
        public ElementDefinitionInfo Element_Patient;
        // 12. EpisodeOfCare.managingOrganization
        public ElementDefinitionInfo Element_ManagingOrganization;
        // 13. EpisodeOfCare.period
        public ElementDefinitionInfo Element_Period;
        // 14. EpisodeOfCare.referralRequest
        public ElementDefinitionInfo Element_ReferralRequest;
        // 15. EpisodeOfCare.careManager
        public ElementDefinitionInfo Element_CareManager;
        // 16. EpisodeOfCare.team
        public ElementDefinitionInfo Element_Team;
        // 17. EpisodeOfCare.account
        public ElementDefinitionInfo Element_Account;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "EpisodeOfCare",
                ElementId = "EpisodeOfCare"
            });
            Element_Identifier.Write(sDef);
            Element_Status.Write(sDef);
            Element_StatusHistory.Write(sDef);
            Element_Type.Write(sDef);
            Element_Diagnosis.Write(sDef);
            Element_Patient.Write(sDef);
            Element_ManagingOrganization.Write(sDef);
            Element_Period.Write(sDef);
            Element_ReferralRequest.Write(sDef);
            Element_CareManager.Write(sDef);
            Element_Team.Write(sDef);
            Element_Account.Write(sDef);
        }
        
        public Resource_EpisodeOfCare()
        {
            {
                // 1. EpisodeOfCare.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "EpisodeOfCare.identifier",
                    Id = "EpisodeOfCare.identifier",
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
                // 2. EpisodeOfCare.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "EpisodeOfCare.status",
                    Id = "EpisodeOfCare.status",
                    Min = 1,
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
                // 3. EpisodeOfCare.statusHistory
                this.Element_StatusHistory = new ElementDefinitionInfo
                {
                    Name = "Element_StatusHistory",
                    Path= "EpisodeOfCare.statusHistory",
                    Id = "EpisodeOfCare.statusHistory",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_StatusHistory
                        {
                        }
                    }
                };
            }
            {
                // 6. EpisodeOfCare.type
                this.Element_Type = new ElementDefinitionInfo
                {
                    Name = "Element_Type",
                    Path= "EpisodeOfCare.type",
                    Id = "EpisodeOfCare.type",
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
                // 7. EpisodeOfCare.diagnosis
                this.Element_Diagnosis = new ElementDefinitionInfo
                {
                    Name = "Element_Diagnosis",
                    Path= "EpisodeOfCare.diagnosis",
                    Id = "EpisodeOfCare.diagnosis",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Diagnosis
                        {
                        }
                    }
                };
            }
            {
                // 11. EpisodeOfCare.patient
                this.Element_Patient = new ElementDefinitionInfo
                {
                    Name = "Element_Patient",
                    Path= "EpisodeOfCare.patient",
                    Id = "EpisodeOfCare.patient",
                    Min = 1,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Patient"
                            }
                        }
                    }
                };
            }
            {
                // 12. EpisodeOfCare.managingOrganization
                this.Element_ManagingOrganization = new ElementDefinitionInfo
                {
                    Name = "Element_ManagingOrganization",
                    Path= "EpisodeOfCare.managingOrganization",
                    Id = "EpisodeOfCare.managingOrganization",
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
                // 13. EpisodeOfCare.period
                this.Element_Period = new ElementDefinitionInfo
                {
                    Name = "Element_Period",
                    Path= "EpisodeOfCare.period",
                    Id = "EpisodeOfCare.period",
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
                // 14. EpisodeOfCare.referralRequest
                this.Element_ReferralRequest = new ElementDefinitionInfo
                {
                    Name = "Element_ReferralRequest",
                    Path= "EpisodeOfCare.referralRequest",
                    Id = "EpisodeOfCare.referralRequest",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/ServiceRequest"
                            }
                        }
                    }
                };
            }
            {
                // 15. EpisodeOfCare.careManager
                this.Element_CareManager = new ElementDefinitionInfo
                {
                    Name = "Element_CareManager",
                    Path= "EpisodeOfCare.careManager",
                    Id = "EpisodeOfCare.careManager",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole"
                            }
                        }
                    }
                };
            }
            {
                // 16. EpisodeOfCare.team
                this.Element_Team = new ElementDefinitionInfo
                {
                    Name = "Element_Team",
                    Path= "EpisodeOfCare.team",
                    Id = "EpisodeOfCare.team",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/CareTeam"
                            }
                        }
                    }
                };
            }
            {
                // 17. EpisodeOfCare.account
                this.Element_Account = new ElementDefinitionInfo
                {
                    Name = "Element_Account",
                    Path= "EpisodeOfCare.account",
                    Id = "EpisodeOfCare.account",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Account"
                            }
                        }
                    }
                };
            }
            this.Name = "EpisodeOfCare";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/EpisodeOfCare";
        }
    }
}
