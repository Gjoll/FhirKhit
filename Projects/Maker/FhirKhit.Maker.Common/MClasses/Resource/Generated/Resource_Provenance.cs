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
      "id": "Provenance",
      "url": "http://hl7.org/fhir/StructureDefinition/Provenance",
      "version": "4.0.0",
      "name": "Provenance",
      "status": "draft",
      "publisher": "Health Level Seven International (Security)",
      "description": "Provenance of a resource is a record that describes entities and processes involved in producing and delivering or otherwise influencing that resource. Provenance provides a critical foundation for assessing authenticity, enabling trust, and allowing reproducibility. Provenance assertions are a form of contextual metadata and can themselves become important records with their own provenance. Provenance statement indicates clinical significance in terms of confidence in authenticity, reliability, and trustworthiness, integrity, and stage in lifecycle (e.g. Document Completion - has the artifact been legally authenticated), all of which may impact security, privacy, and trust policies.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "Provenance",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Provenance",
            "path": "Provenance",
            "short": "Who, What, When for a set of resources",
            "definition": "Provenance of a resource is a record that describes entities and processes involved in producing and delivering or otherwise influencing that resource. Provenance provides a critical foundation for assessing authenticity, enabling trust, and allowing reproducibility. Provenance assertions are a form of contextual metadata and can themselves become important records with their own provenance. Provenance statement indicates clinical significance in terms of confidence in authenticity, reliability, and trustworthiness, integrity, and stage in lifecycle (e.g. Document Completion - has the artifact been legally authenticated), all of which may impact security, privacy, and trust policies.",
            "comment": "Some parties may be duplicated between the target resource and its provenance.  For instance, the prescriber is usually (but not always) the author of the prescription resource. This resource is defined with close consideration for W3C Provenance.",
            "alias": [
              "History",
              "Event",
              "Activity"
            ],
            "min": 0,
            "max": "*"
          },
          {
            "id": "Provenance.target",
            "path": "Provenance.target",
            "short": "Target Reference(s) (usually version specific)",
            "definition": "The Reference(s) that were generated or updated by  the activity described in this resource. A provenance can point to more than one target if multiple resources were created/updated by the same activity.",
            "comment": "Target references are usually version specific, but might not be, if a version has not been assigned or if the provenance information is part of the set of resources being maintained (i.e. a document). When using the RESTful API, the identity of the resource might not be known (especially not the version specific one); the client may either submit the resource first, and then the provenance, or it may submit both using a single transaction. See the notes on transaction for further discussion.",
            "min": 1,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Resource"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Provenance.occurred[x]",
            "path": "Provenance.occurred[x]",
            "short": "When the activity occurred",
            "definition": "The period during which the activity occurred.",
            "comment": "The period can be a little arbitrary; where possible, the time should correspond to human assessment of the activity time.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Period"
              },
              {
                "code": "dateTime"
              }
            ]
          },
          {
            "id": "Provenance.recorded",
            "path": "Provenance.recorded",
            "short": "When the activity was recorded / updated",
            "definition": "The instant of time at which the activity was recorded.",
            "comment": "This can be a little different from the time stamp on the resource if there is a delay between recording the event and updating the provenance and target resource.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "instant"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Provenance.policy",
            "path": "Provenance.policy",
            "short": "Policy or plan the activity was defined by",
            "definition": "Policy or plan the activity was defined by. Typically, a single activity may have multiple applicable policy documents, such as patient consent, guarantor funding, etc.",
            "comment": "For example: Where an OAuth token authorizes, the unique identifier from the OAuth token is placed into the policy element Where a policy engine (e.g. XACML) holds policy logic, the unique policy identifier is placed into the policy element.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "uri"
              }
            ]
          },
          {
            "id": "Provenance.location",
            "path": "Provenance.location",
            "short": "Where the activity occurred, if relevant",
            "definition": "Where the activity occurred, if relevant.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Location"
                ]
              }
            ]
          },
          {
            "id": "Provenance.reason",
            "path": "Provenance.reason",
            "short": "Reason the activity is occurring",
            "definition": "The reason that the activity was taking place.",
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
                  "valueString": "ProvenanceReason"
                }
              ],
              "strength": "extensible",
              "description": "The reason the activity took place.",
              "valueSet": "http://terminology.hl7.org/ValueSet/v3-PurposeOfUse"
            }
          },
          {
            "id": "Provenance.activity",
            "path": "Provenance.activity",
            "short": "Activity that occurred",
            "definition": "An activity is something that occurs over a period of time and acts upon or with entities; it may include consuming, processing, transforming, modifying, relocating, using, or generating entities.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ProvenanceActivity"
                }
              ],
              "strength": "extensible",
              "description": "The activity that took place.",
              "valueSet": "http://hl7.org/fhir/ValueSet/provenance-activity-type"
            }
          },
          {
            "id": "Provenance.agent",
            "path": "Provenance.agent",
            "short": "Actor involved",
            "definition": "An actor taking a role in an activity  for which it can be assigned some degree of responsibility for the activity taking place.",
            "comment": "Several agents may be associated (i.e. has some responsibility for an activity) with an activity and vice-versa.",
            "requirements": "An agent can be a person, an organization, software, device, or other entities that may be ascribed responsibility.",
            "min": 1,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Provenance.agent.type",
            "path": "Provenance.agent.type",
            "short": "How the agent participated",
            "definition": "The participation the agent had with respect to the activity.",
            "comment": "For example: author, performer, enterer, attester, etc.",
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
                  "valueString": "ProvenanceAgentType"
                }
              ],
              "strength": "extensible",
              "description": "The type of participation that a provenance agent played with respect to the activity.",
              "valueSet": "http://hl7.org/fhir/ValueSet/provenance-agent-type"
            }
          },
          {
            "id": "Provenance.agent.role",
            "path": "Provenance.agent.role",
            "short": "What the agents role was",
            "definition": "The function of the agent with respect to the activity. The security role enabling the agent with respect to the activity.",
            "comment": "For example: doctor, nurse, clerk, etc.",
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
                  "valueString": "ProvenanceAgentRole"
                }
              ],
              "strength": "example",
              "description": "The role that a provenance agent played with respect to the activity.",
              "valueSet": "http://hl7.org/fhir/ValueSet/security-role-type"
            }
          },
          {
            "id": "Provenance.agent.who",
            "path": "Provenance.agent.who",
            "short": "Who participated",
            "definition": "The individual, device or organization that participated in the event.",
            "comment": "whoIdentity should be used when the agent is not a Resource type.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Device",
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Provenance.agent.onBehalfOf",
            "path": "Provenance.agent.onBehalfOf",
            "short": "Who the agent is representing",
            "definition": "The individual, device, or organization for whom the change was made.",
            "comment": "onBehalfOfIdentity should be used when the agent is not a Resource type.",
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
                  "http://hl7.org/fhir/StructureDefinition/Device",
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ]
          },
          {
            "id": "Provenance.entity",
            "path": "Provenance.entity",
            "short": "An entity used in this activity",
            "definition": "An entity used in this activity.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Provenance.entity.role",
            "path": "Provenance.entity.role",
            "short": "derivation | revision | quotation | source | removal",
            "definition": "How the entity was used during the activity.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ProvenanceEntityRole"
                }
              ],
              "strength": "required",
              "description": "How an entity was used in an activity.",
              "valueSet": "http://hl7.org/fhir/ValueSet/provenance-entity-role|4.0.0"
            }
          },
          {
            "id": "Provenance.entity.what",
            "path": "Provenance.entity.what",
            "short": "Identity of entity",
            "definition": "Identity of the  Entity used. May be a logical or physical uri and maybe absolute or relative.",
            "comment": "whatIdentity should be used for entities that are not a Resource type.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Resource"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Provenance.entity.agent",
            "path": "Provenance.entity.agent",
            "short": "Entity is attributed to this agent",
            "definition": "The entity is attributed to an agent to express the agent's responsibility for that entity, possibly along with other agents. This description can be understood as shorthand for saying that the agent was responsible for the activity which generated the entity.",
            "comment": "A usecase where one Provenance.entity.agent is used where the Entity that was used in the creation/updating of the Target, is not in the context of the same custodianship as the Target, and thus the meaning of Provenance.entity.agent is to say that the entity referenced is managed elsewhere and that this Agent provided access to it.  This would be similar to where the Entity being referenced is managed outside FHIR, such as through HL7 v2, v3, or XDS. This might be where the Entity being referenced is managed in another FHIR resource server. Thus it explains the Provenance of that Entity's use in the context of this Provenance activity.",
            "min": 0,
            "max": "*",
            "contentReference": "#Provenance.agent"
          },
          {
            "id": "Provenance.signature",
            "path": "Provenance.signature",
            "short": "Signature on target",
            "definition": "A digital signature on the target Reference(s). The signer should match a Provenance.agent. The purpose of the signature is indicated.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Signature"
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion
    /// <summary>
    /// Fhir resource 'Provenance'
    /// </summary>
    // 0. Provenance
    public partial class Resource_Provenance : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 8. Provenance.agent
        public partial class Type_Agent : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 9. Provenance.agent.type
            public ElementDefinitionInfo Element_Type;
            // 10. Provenance.agent.role
            public ElementDefinitionInfo Element_Role;
            // 11. Provenance.agent.who
            public ElementDefinitionInfo Element_Who;
            // 12. Provenance.agent.onBehalfOf
            public ElementDefinitionInfo Element_OnBehalfOf;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Provenance.agent",
                    ElementId = "Provenance.agent"
                });
                Element_Type.Write(sDef);
                Element_Role.Write(sDef);
                Element_Who.Write(sDef);
                Element_OnBehalfOf.Write(sDef);
            }
            
            public Type_Agent()
            {
                {
                    // 9. Provenance.agent.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "Provenance.agent.type",
                        Id = "Provenance.agent.type",
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
                    // 10. Provenance.agent.role
                    this.Element_Role = new ElementDefinitionInfo
                    {
                        Name = "Element_Role",
                        Path= "Provenance.agent.role",
                        Id = "Provenance.agent.role",
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
                    // 11. Provenance.agent.who
                    this.Element_Who = new ElementDefinitionInfo
                    {
                        Name = "Element_Who",
                        Path= "Provenance.agent.who",
                        Id = "Provenance.agent.who",
                        Min = 1,
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
                                    "http://hl7.org/fhir/StructureDefinition/Device",
                                    "http://hl7.org/fhir/StructureDefinition/Organization"
                                }
                            }
                        }
                    };
                }
                {
                    // 12. Provenance.agent.onBehalfOf
                    this.Element_OnBehalfOf = new ElementDefinitionInfo
                    {
                        Name = "Element_OnBehalfOf",
                        Path= "Provenance.agent.onBehalfOf",
                        Id = "Provenance.agent.onBehalfOf",
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
                                    "http://hl7.org/fhir/StructureDefinition/Device",
                                    "http://hl7.org/fhir/StructureDefinition/Organization"
                                }
                            }
                        }
                    };
                }
            }
        }
        // 13. Provenance.entity
        public partial class Type_Entity : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 14. Provenance.entity.role
            public ElementDefinitionInfo Element_Role;
            // 15. Provenance.entity.what
            public ElementDefinitionInfo Element_What;
            // 16. Provenance.entity.agent
            public ElementDefinitionInfo Element_Agent;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Provenance.entity",
                    ElementId = "Provenance.entity"
                });
                Element_Role.Write(sDef);
                Element_What.Write(sDef);
                Element_Agent.Write(sDef);
            }
            
            public Type_Entity()
            {
                {
                    // 14. Provenance.entity.role
                    this.Element_Role = new ElementDefinitionInfo
                    {
                        Name = "Element_Role",
                        Path= "Provenance.entity.role",
                        Id = "Provenance.entity.role",
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
                    // 15. Provenance.entity.what
                    this.Element_What = new ElementDefinitionInfo
                    {
                        Name = "Element_What",
                        Path= "Provenance.entity.what",
                        Id = "Provenance.entity.what",
                        Min = 1,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/Resource"
                                }
                            }
                        }
                    };
                }
                {
                    // 16. Provenance.entity.agent
                    this.Element_Agent = new ElementDefinitionInfo
                    {
                        Name = "Element_Agent",
                        Path= "Provenance.entity.agent",
                        Id = "Provenance.entity.agent",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                        }
                    };
                }
            }
        }
        // 1. Provenance.target
        public ElementDefinitionInfo Element_Target;
        // 2. Provenance.occurred[x]
        public ElementDefinitionInfo Element_Occurred;
        // 3. Provenance.recorded
        public ElementDefinitionInfo Element_Recorded;
        // 4. Provenance.policy
        public ElementDefinitionInfo Element_Policy;
        // 5. Provenance.location
        public ElementDefinitionInfo Element_Location;
        // 6. Provenance.reason
        public ElementDefinitionInfo Element_Reason;
        // 7. Provenance.activity
        public ElementDefinitionInfo Element_Activity;
        // 8. Provenance.agent
        public ElementDefinitionInfo Element_Agent;
        // 13. Provenance.entity
        public ElementDefinitionInfo Element_Entity;
        // 17. Provenance.signature
        public ElementDefinitionInfo Element_Signature;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "Provenance",
                ElementId = "Provenance"
            });
            Element_Target.Write(sDef);
            Element_Occurred.Write(sDef);
            Element_Recorded.Write(sDef);
            Element_Policy.Write(sDef);
            Element_Location.Write(sDef);
            Element_Reason.Write(sDef);
            Element_Activity.Write(sDef);
            Element_Agent.Write(sDef);
            Element_Entity.Write(sDef);
            Element_Signature.Write(sDef);
        }
        
        public Resource_Provenance()
        {
            {
                // 1. Provenance.target
                this.Element_Target = new ElementDefinitionInfo
                {
                    Name = "Element_Target",
                    Path= "Provenance.target",
                    Id = "Provenance.target",
                    Min = 1,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Resource"
                            }
                        }
                    }
                };
            }
            {
                // 2. Provenance.occurred[x]
                this.Element_Occurred = new ElementDefinitionInfo
                {
                    Name = "Element_Occurred",
                    Path= "Provenance.occurred[x]",
                    Id = "Provenance.occurred[x]",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Period
                        {
                        },
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime
                        {
                        }
                    }
                };
            }
            {
                // 3. Provenance.recorded
                this.Element_Recorded = new ElementDefinitionInfo
                {
                    Name = "Element_Recorded",
                    Path= "Provenance.recorded",
                    Id = "Provenance.recorded",
                    Min = 1,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Instant
                        {
                        }
                    }
                };
            }
            {
                // 4. Provenance.policy
                this.Element_Policy = new ElementDefinitionInfo
                {
                    Name = "Element_Policy",
                    Path= "Provenance.policy",
                    Id = "Provenance.policy",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Uri
                        {
                        }
                    }
                };
            }
            {
                // 5. Provenance.location
                this.Element_Location = new ElementDefinitionInfo
                {
                    Name = "Element_Location",
                    Path= "Provenance.location",
                    Id = "Provenance.location",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Location"
                            }
                        }
                    }
                };
            }
            {
                // 6. Provenance.reason
                this.Element_Reason = new ElementDefinitionInfo
                {
                    Name = "Element_Reason",
                    Path= "Provenance.reason",
                    Id = "Provenance.reason",
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
                // 7. Provenance.activity
                this.Element_Activity = new ElementDefinitionInfo
                {
                    Name = "Element_Activity",
                    Path= "Provenance.activity",
                    Id = "Provenance.activity",
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
                // 8. Provenance.agent
                this.Element_Agent = new ElementDefinitionInfo
                {
                    Name = "Element_Agent",
                    Path= "Provenance.agent",
                    Id = "Provenance.agent",
                    Min = 1,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Agent
                        {
                        }
                    }
                };
            }
            {
                // 13. Provenance.entity
                this.Element_Entity = new ElementDefinitionInfo
                {
                    Name = "Element_Entity",
                    Path= "Provenance.entity",
                    Id = "Provenance.entity",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Entity
                        {
                        }
                    }
                };
            }
            {
                // 17. Provenance.signature
                this.Element_Signature = new ElementDefinitionInfo
                {
                    Name = "Element_Signature",
                    Path= "Provenance.signature",
                    Id = "Provenance.signature",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Signature
                        {
                        }
                    }
                };
            }
            this.Name = "Provenance";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Provenance";
        }
    }
}
