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
    #endregion                                                                                                                              // MakerGen.cs:440
    /// <summary>
    /// Fhir resource 'Provenance'
    /// </summary>
    // 0. Provenance
    public class Resource_Provenance : FhirKhit.Maker.Common.Resource.ResourceBase                                                          // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        // 8. Provenance.agent
        public class Type_Agent : FhirKhit.Maker.Common.Complex.ComplexBase                                                                 // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 9. Provenance.agent.type
            public ElementDefinitionInfo Element_Type;                                                                                      // MakerGen.cs:212
            // 10. Provenance.agent.role
            public ElementDefinitionInfo Element_Role;                                                                                      // MakerGen.cs:212
            // 11. Provenance.agent.who
            public ElementDefinitionInfo Element_Who;                                                                                       // MakerGen.cs:212
            // 12. Provenance.agent.onBehalfOf
            public ElementDefinitionInfo Element_OnBehalfOf;                                                                                // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "Provenance.agent",                                                                                              // MakerGen.cs:388
                    ElementId = "Provenance.agent"                                                                                          // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Type.Write(sDef);                                                                                                   // MakerGen.cs:216
                Element_Role.Write(sDef);                                                                                                   // MakerGen.cs:216
                Element_Who.Write(sDef);                                                                                                    // MakerGen.cs:216
                Element_OnBehalfOf.Write(sDef);                                                                                             // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_Agent()                                                                                                             // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 9. Provenance.agent.type
                    this.Element_Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Type",                                                                                              // MakerGen.cs:231
                        Path= "Provenance.agent.type",                                                                                      // MakerGen.cs:232
                        Id = "Provenance.agent.type",                                                                                       // MakerGen.cs:233
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
                    // 10. Provenance.agent.role
                    this.Element_Role = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Role",                                                                                              // MakerGen.cs:231
                        Path= "Provenance.agent.role",                                                                                      // MakerGen.cs:232
                        Id = "Provenance.agent.role",                                                                                       // MakerGen.cs:233
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
                    // 11. Provenance.agent.who
                    this.Element_Who = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Who",                                                                                               // MakerGen.cs:231
                        Path= "Provenance.agent.who",                                                                                       // MakerGen.cs:232
                        Id = "Provenance.agent.who",                                                                                        // MakerGen.cs:233
                        Min = 1,                                                                                                            // MakerGen.cs:234
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
                                    "http://hl7.org/fhir/StructureDefinition/Device",                                                       // MakerGen.cs:342
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:342
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:343
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 12. Provenance.agent.onBehalfOf
                    this.Element_OnBehalfOf = new ElementDefinitionInfo                                                                     // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_OnBehalfOf",                                                                                        // MakerGen.cs:231
                        Path= "Provenance.agent.onBehalfOf",                                                                                // MakerGen.cs:232
                        Id = "Provenance.agent.onBehalfOf",                                                                                 // MakerGen.cs:233
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
                                    "http://hl7.org/fhir/StructureDefinition/Device",                                                       // MakerGen.cs:342
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:342
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:343
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 13. Provenance.entity
        public class Type_Entity : FhirKhit.Maker.Common.Complex.ComplexBase                                                                // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 14. Provenance.entity.role
            public ElementDefinitionInfo Element_Role;                                                                                      // MakerGen.cs:212
            // 15. Provenance.entity.what
            public ElementDefinitionInfo Element_What;                                                                                      // MakerGen.cs:212
            // 16. Provenance.entity.agent
            public ElementDefinitionInfo Element_Agent;                                                                                     // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "Provenance.entity",                                                                                             // MakerGen.cs:388
                    ElementId = "Provenance.entity"                                                                                         // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Role.Write(sDef);                                                                                                   // MakerGen.cs:216
                Element_What.Write(sDef);                                                                                                   // MakerGen.cs:216
                Element_Agent.Write(sDef);                                                                                                  // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_Entity()                                                                                                            // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 14. Provenance.entity.role
                    this.Element_Role = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Role",                                                                                              // MakerGen.cs:231
                        Path= "Provenance.entity.role",                                                                                     // MakerGen.cs:232
                        Id = "Provenance.entity.role",                                                                                      // MakerGen.cs:233
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
                    // 15. Provenance.entity.what
                    this.Element_What = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_What",                                                                                              // MakerGen.cs:231
                        Path= "Provenance.entity.what",                                                                                     // MakerGen.cs:232
                        Id = "Provenance.entity.what",                                                                                      // MakerGen.cs:233
                        Min = 1,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:339
                            {                                                                                                               // MakerGen.cs:340
                                TargetProfile = new String[]                                                                                // MakerGen.cs:342
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Resource"                                                      // MakerGen.cs:342
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:343
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 16. Provenance.entity.agent
                    this.Element_Agent = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Agent",                                                                                             // MakerGen.cs:231
                        Path= "Provenance.entity.agent",                                                                                    // MakerGen.cs:232
                        Id = "Provenance.entity.agent",                                                                                     // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 1. Provenance.target
        public ElementDefinitionInfo Element_Target;                                                                                        // MakerGen.cs:212
        // 2. Provenance.occurred[x]
        public ElementDefinitionInfo Element_Occurred;                                                                                      // MakerGen.cs:212
        // 3. Provenance.recorded
        public ElementDefinitionInfo Element_Recorded;                                                                                      // MakerGen.cs:212
        // 4. Provenance.policy
        public ElementDefinitionInfo Element_Policy;                                                                                        // MakerGen.cs:212
        // 5. Provenance.location
        public ElementDefinitionInfo Element_Location;                                                                                      // MakerGen.cs:212
        // 6. Provenance.reason
        public ElementDefinitionInfo Element_Reason;                                                                                        // MakerGen.cs:212
        // 7. Provenance.activity
        public ElementDefinitionInfo Element_Activity;                                                                                      // MakerGen.cs:212
        // 8. Provenance.agent
        public ElementDefinitionInfo Element_Agent;                                                                                         // MakerGen.cs:212
        // 13. Provenance.entity
        public ElementDefinitionInfo Element_Entity;                                                                                        // MakerGen.cs:212
        // 17. Provenance.signature
        public ElementDefinitionInfo Element_Signature;                                                                                     // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            base.Write(sDef);                                                                                                               // MakerGen.cs:385
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:386
            {                                                                                                                               // MakerGen.cs:387
                Path = "Provenance",                                                                                                        // MakerGen.cs:388
                ElementId = "Provenance"                                                                                                    // MakerGen.cs:389
            });                                                                                                                             // MakerGen.cs:390
            Element_Target.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_Occurred.Write(sDef);                                                                                                   // MakerGen.cs:216
            Element_Recorded.Write(sDef);                                                                                                   // MakerGen.cs:216
            Element_Policy.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_Location.Write(sDef);                                                                                                   // MakerGen.cs:216
            Element_Reason.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_Activity.Write(sDef);                                                                                                   // MakerGen.cs:216
            Element_Agent.Write(sDef);                                                                                                      // MakerGen.cs:216
            Element_Entity.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_Signature.Write(sDef);                                                                                                  // MakerGen.cs:216
        }                                                                                                                                   // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
        public Resource_Provenance()                                                                                                        // MakerGen.cs:395
        {                                                                                                                                   // MakerGen.cs:396
            {                                                                                                                               // MakerGen.cs:227
                // 1. Provenance.target
                this.Element_Target = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Target",                                                                                                // MakerGen.cs:231
                    Path= "Provenance.target",                                                                                              // MakerGen.cs:232
                    Id = "Provenance.target",                                                                                               // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Resource"                                                          // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 2. Provenance.occurred[x]
                this.Element_Occurred = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Occurred",                                                                                              // MakerGen.cs:231
                    Path= "Provenance.occurred[x]",                                                                                         // MakerGen.cs:232
                    Id = "Provenance.occurred[x]",                                                                                          // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Period                                                                       // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        },                                                                                                                  // MakerGen.cs:353
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                              // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 3. Provenance.recorded
                this.Element_Recorded = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Recorded",                                                                                              // MakerGen.cs:231
                    Path= "Provenance.recorded",                                                                                            // MakerGen.cs:232
                    Id = "Provenance.recorded",                                                                                             // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Instant                                                               // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 4. Provenance.policy
                this.Element_Policy = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Policy",                                                                                                // MakerGen.cs:231
                    Path= "Provenance.policy",                                                                                              // MakerGen.cs:232
                    Id = "Provenance.policy",                                                                                               // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Uri                                                                   // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 5. Provenance.location
                this.Element_Location = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Location",                                                                                              // MakerGen.cs:231
                    Path= "Provenance.location",                                                                                            // MakerGen.cs:232
                    Id = "Provenance.location",                                                                                             // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Location"                                                          // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 6. Provenance.reason
                this.Element_Reason = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Reason",                                                                                                // MakerGen.cs:231
                    Path= "Provenance.reason",                                                                                              // MakerGen.cs:232
                    Id = "Provenance.reason",                                                                                               // MakerGen.cs:233
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
                // 7. Provenance.activity
                this.Element_Activity = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Activity",                                                                                              // MakerGen.cs:231
                    Path= "Provenance.activity",                                                                                            // MakerGen.cs:232
                    Id = "Provenance.activity",                                                                                             // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 8. Provenance.agent
                this.Element_Agent = new ElementDefinitionInfo                                                                              // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Agent",                                                                                                 // MakerGen.cs:231
                    Path= "Provenance.agent",                                                                                               // MakerGen.cs:232
                    Id = "Provenance.agent",                                                                                                // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_Agent                                                                                                      // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 13. Provenance.entity
                this.Element_Entity = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Entity",                                                                                                // MakerGen.cs:231
                    Path= "Provenance.entity",                                                                                              // MakerGen.cs:232
                    Id = "Provenance.entity",                                                                                               // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_Entity                                                                                                     // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 17. Provenance.signature
                this.Element_Signature = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Signature",                                                                                             // MakerGen.cs:231
                    Path= "Provenance.signature",                                                                                           // MakerGen.cs:232
                    Id = "Provenance.signature",                                                                                            // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Signature                                                                    // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            this.Name = "Provenance";                                                                                                       // MakerGen.cs:458
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Provenance";                                                                // MakerGen.cs:459
        }                                                                                                                                   // MakerGen.cs:398
    }                                                                                                                                       // MakerGen.cs:400
}                                                                                                                                           // MakerGen.cs:445
