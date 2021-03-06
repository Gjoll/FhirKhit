using System;                                                                                                                               // MakerGen.cs:432
using System.Diagnostics;                                                                                                                   // MakerGen.cs:433
using System.IO;                                                                                                                            // MakerGen.cs:434
using System.Linq;                                                                                                                          // MakerGen.cs:435
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:436
                                                                                                                                            // MakerGen.cs:437
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:438
{                                                                                                                                           // MakerGen.cs:439
    #region Json                                                                                                                            // MakerGen.cs:440
    #if NEVER                                                                                                                               // MakerGen.cs:441
    {
      "resourceType": "StructureDefinition",
      "id": "AuditEvent",
      "url": "http://hl7.org/fhir/StructureDefinition/AuditEvent",
      "version": "4.0.0",
      "name": "AuditEvent",
      "status": "draft",
      "publisher": "Health Level Seven International (Security)",
      "description": "A record of an event made for purposes of maintaining a security log. Typical uses include detection of intrusion attempts and monitoring for inappropriate usage.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "AuditEvent",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "AuditEvent",
            "path": "AuditEvent",
            "short": "Event record kept for security purposes",
            "definition": "A record of an event made for purposes of maintaining a security log. Typical uses include detection of intrusion attempts and monitoring for inappropriate usage.",
            "comment": "Based on IHE-ATNA.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "AuditEvent.type",
            "path": "AuditEvent.type",
            "short": "Type/identifier of event",
            "definition": "Identifier for a family of the event.  For example, a menu item, program, rule, policy, function code, application name or URL. It identifies the performed function.",
            "requirements": "This identifies the performed function. For \"Execute\" Event Action Code audit records, this identifies the application function performed.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Coding"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "AuditEventType"
                }
              ],
              "strength": "extensible",
              "description": "Type of event.",
              "valueSet": "http://hl7.org/fhir/ValueSet/audit-event-type"
            }
          },
          {
            "id": "AuditEvent.subtype",
            "path": "AuditEvent.subtype",
            "short": "More specific type/id for the event",
            "definition": "Identifier for the category of event.",
            "requirements": "This field enables queries of messages by implementation-defined event categories.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Coding"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "AuditEventSubType"
                }
              ],
              "strength": "extensible",
              "description": "Sub-type of event.",
              "valueSet": "http://hl7.org/fhir/ValueSet/audit-event-sub-type"
            }
          },
          {
            "id": "AuditEvent.action",
            "path": "AuditEvent.action",
            "short": "Type of action performed during the event",
            "definition": "Indicator for type of action performed during the event that generated the audit.",
            "requirements": "This broadly indicates what kind of action was done on the AuditEvent.entity by the AuditEvent.agent.",
            "min": 0,
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
                  "valueString": "AuditEventAction"
                }
              ],
              "strength": "required",
              "description": "Indicator for type of action performed during the event that generated the event.",
              "valueSet": "http://hl7.org/fhir/ValueSet/audit-event-action|4.0.0"
            }
          },
          {
            "id": "AuditEvent.period",
            "path": "AuditEvent.period",
            "short": "When the activity occurred",
            "definition": "The period during which the activity occurred.",
            "comment": "The period can be a little arbitrary; where possible, the time should correspond to human assessment of the activity time.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Period"
              }
            ]
          },
          {
            "id": "AuditEvent.recorded",
            "path": "AuditEvent.recorded",
            "short": "Time when the event was recorded",
            "definition": "The time when the event was recorded.",
            "comment": "In a distributed system, some sort of common time base (e.g. an NTP [RFC1305] server) is a good implementation tactic.",
            "requirements": "This ties an event to a specific date and time. Security audits typically require a consistent time base (e.g. UTC), to eliminate time-zone issues arising from geographical distribution.",
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
            "id": "AuditEvent.outcome",
            "path": "AuditEvent.outcome",
            "short": "Whether the event succeeded or failed",
            "definition": "Indicates whether the event succeeded or failed.",
            "comment": "In some cases a \"success\" may be partial, for example, an incomplete or interrupted transfer of a radiological study. For the purpose of establishing accountability, these distinctions are not relevant.",
            "min": 0,
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
                  "valueString": "AuditEventOutcome"
                }
              ],
              "strength": "required",
              "description": "Indicates whether the event succeeded or failed.",
              "valueSet": "http://hl7.org/fhir/ValueSet/audit-event-outcome|4.0.0"
            }
          },
          {
            "id": "AuditEvent.outcomeDesc",
            "path": "AuditEvent.outcomeDesc",
            "short": "Description of the event outcome",
            "definition": "A free text description of the outcome of the event.",
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
            "id": "AuditEvent.purposeOfEvent",
            "path": "AuditEvent.purposeOfEvent",
            "short": "The purposeOfUse of the event",
            "definition": "The purposeOfUse (reason) that was used during the event being recorded.",
            "comment": "Use AuditEvent.agent.purposeOfUse when you know that it is specific to the agent, otherwise use AuditEvent.purposeOfEvent. For example, during a machine-to-machine transfer it might not be obvious to the audit system who caused the event, but it does know why.",
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
                  "valueString": "AuditPurposeOfUse"
                }
              ],
              "strength": "extensible",
              "description": "The reason the activity took place.",
              "valueSet": "http://terminology.hl7.org/ValueSet/v3-PurposeOfUse"
            }
          },
          {
            "id": "AuditEvent.agent",
            "path": "AuditEvent.agent",
            "short": "Actor involved in the event",
            "definition": "An actor taking an active role in the event or activity that is logged.",
            "comment": "Several agents may be associated (i.e. have some responsibility for an activity) with an event or activity.\n\nFor example, an activity may be initiated by one user for other users or involve more than one user. However, only one user may be the initiator/requestor for the activity.",
            "requirements": "An agent can be a person, an organization, software, device, or other actors that may be ascribed responsibility.",
            "alias": [
              "ActiveParticipant"
            ],
            "min": 1,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "AuditEvent.agent.type",
            "path": "AuditEvent.agent.type",
            "short": "How agent participated",
            "definition": "Specification of the participation type the user plays when performing the event.",
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
                  "valueString": "AuditAgentType"
                }
              ],
              "strength": "extensible",
              "description": "The Participation type of the agent to the event.",
              "valueSet": "http://hl7.org/fhir/ValueSet/participation-role-type"
            }
          },
          {
            "id": "AuditEvent.agent.role",
            "path": "AuditEvent.agent.role",
            "short": "Agent role in the event",
            "definition": "The security role that the user was acting under, that come from local codes defined by the access control security system (e.g. RBAC, ABAC) used in the local context.",
            "comment": "Should be roles relevant to the event. Should  not be an exhaustive list of roles.",
            "requirements": "This value ties an audited event to a user's role(s). It is an optional value that might be used to group events for analysis by user functional role categories.",
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
                  "valueString": "AuditAgentRole"
                }
              ],
              "strength": "example",
              "description": "What security role enabled the agent to participate in the event.",
              "valueSet": "http://hl7.org/fhir/ValueSet/security-role-type"
            }
          },
          {
            "id": "AuditEvent.agent.who",
            "path": "AuditEvent.agent.who",
            "short": "Identifier of who",
            "definition": "Reference to who this agent is that was involved in the event.",
            "comment": "Where a User ID is available it will go into who.identifier.",
            "requirements": "This field ties an audit event to a specific resource or identifier.",
            "alias": [
              "userId"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/Organization",
                  "http://hl7.org/fhir/StructureDefinition/Device",
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "AuditEvent.agent.altId",
            "path": "AuditEvent.agent.altId",
            "short": "Alternative User identity",
            "definition": "Alternative agent Identifier. For a human, this should be a user identifier text string from authentication system. This identifier would be one known to a common authentication system (e.g. single sign-on), if available.",
            "requirements": "In some situations, a human user may authenticate with one identity but, to access a specific application system, may use a synonymous identify. For example, some \"single sign on\" implementations will do this. The alternative identifier would then be the original identify  used for authentication, and the User ID is the one known to and used by the application.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "AuditEvent.agent.name",
            "path": "AuditEvent.agent.name",
            "short": "Human friendly name for the agent",
            "definition": "Human-meaningful name for the agent.",
            "requirements": "The User ID and Authorization User ID may be internal or otherwise obscure values. This field assists the auditor in identifying the actual user.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "AuditEvent.agent.requestor",
            "path": "AuditEvent.agent.requestor",
            "short": "Whether user is initiator",
            "definition": "Indicator that the user is or is not the requestor, or initiator, for the event being audited.",
            "comment": "There can only be one initiator. If the initiator is not clear, then do not choose any one agent as the initiator.",
            "requirements": "This value is used to distinguish between requestor-users and recipient-users. For example, one person may initiate a report-output to be sent to another user.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ],
            "isSummary": true
          },
          {
            "id": "AuditEvent.agent.location",
            "path": "AuditEvent.agent.location",
            "short": "Where",
            "definition": "Where the event occurred.",
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
            "id": "AuditEvent.agent.policy",
            "path": "AuditEvent.agent.policy",
            "short": "Policy that authorized event",
            "definition": "The policy or plan that authorized the activity being recorded. Typically, a single activity may have multiple applicable policies, such as patient consent, guarantor funding, etc. The policy would also indicate the security token used.",
            "comment": "For example: Where an OAuth token authorizes, the unique identifier from the OAuth token is placed into the policy element Where a policy engine (e.g. XACML) holds policy logic, the unique policy identifier is placed into the policy element.",
            "requirements": "This value is used retrospectively to determine the authorization policies.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "uri"
              }
            ]
          },
          {
            "id": "AuditEvent.agent.media",
            "path": "AuditEvent.agent.media",
            "short": "Type of media",
            "definition": "Type of media involved. Used when the event is about exporting/importing onto media.",
            "requirements": "Usually, this is used instead of specifying a network address. This field is not used for Media Id (i.e. the serial number of a CD).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Coding"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "DICOMMediaType"
                }
              ],
              "strength": "extensible",
              "description": "Used when the event is about exporting/importing onto media.",
              "valueSet": "http://hl7.org/fhir/ValueSet/dicm-405-mediatype"
            }
          },
          {
            "id": "AuditEvent.agent.network",
            "path": "AuditEvent.agent.network",
            "short": "Logical network location for application activity",
            "definition": "Logical network location for application activity, if the activity has a network location.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "AuditEvent.agent.network.address",
            "path": "AuditEvent.agent.network.address",
            "short": "Identifier for the network access point of the user device",
            "definition": "An identifier for the network access point of the user device for the audit event.",
            "comment": "This could be a device id, IP address or some other identifier associated with a device.",
            "requirements": "This datum identifies the user's network access point, which may be distinct from the server that performed the action. It is an optional value that may be used to group events recorded on separate servers for analysis of a specific network access point's data access across all servers.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "AuditEvent.agent.network.type",
            "path": "AuditEvent.agent.network.type",
            "short": "The type of network access point",
            "definition": "An identifier for the type of network access point that originated the audit event.",
            "requirements": "This datum identifies the type of network access point identifier of the user device for the audit event. It is an optional value that may be used to group events recorded on separate servers for analysis of access according to a network access point's type.",
            "min": 0,
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
                  "valueString": "AuditEventAgentNetworkType"
                }
              ],
              "strength": "required",
              "description": "The type of network access point of this agent in the audit event.",
              "valueSet": "http://hl7.org/fhir/ValueSet/network-type|4.0.0"
            }
          },
          {
            "id": "AuditEvent.agent.purposeOfUse",
            "path": "AuditEvent.agent.purposeOfUse",
            "short": "Reason given for this user",
            "definition": "The reason (purpose of use), specific to this agent, that was used during the event being recorded.",
            "comment": "Use AuditEvent.agent.purposeOfUse when you know that is specific to the agent, otherwise use AuditEvent.purposeOfEvent. For example, during a machine-to-machine transfer it might not be obvious to the audit system who caused the event, but it does know why.",
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
                  "valueString": "AuditPurposeOfUse"
                }
              ],
              "strength": "extensible",
              "description": "The reason the activity took place.",
              "valueSet": "http://terminology.hl7.org/ValueSet/v3-PurposeOfUse"
            }
          },
          {
            "id": "AuditEvent.source",
            "path": "AuditEvent.source",
            "short": "Audit Event Reporter",
            "definition": "The system that is reporting the event.",
            "comment": "Since multi-tier, distributed, or composite applications make source identification ambiguous, this collection of fields may repeat for each application or process actively involved in the event. For example, multiple value-sets can identify participating web servers, application processes, and database server threads in an n-tier distributed application. Passive event participants (e.g. low-level network transports) need not be identified.",
            "requirements": "The event is reported by one source.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "AuditEvent.source.site",
            "path": "AuditEvent.source.site",
            "short": "Logical source location within the enterprise",
            "definition": "Logical source location within the healthcare enterprise network.  For example, a hospital or other provider location within a multi-entity provider group.",
            "requirements": "This value differentiates among the sites in a multi-site enterprise health information system.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "AuditEvent.source.observer",
            "path": "AuditEvent.source.observer",
            "short": "The identity of source detecting the event",
            "definition": "Identifier of the source where the event was detected.",
            "requirements": "This field ties the event to a specific source system. It may be used to group events for analysis according to where the event was detected.",
            "alias": [
              "SourceId"
            ],
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/Organization",
                  "http://hl7.org/fhir/StructureDefinition/Device",
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "AuditEvent.source.type",
            "path": "AuditEvent.source.type",
            "short": "The type of source where event originated",
            "definition": "Code specifying the type of source where event originated.",
            "requirements": "This field indicates which type of source is identified by the Audit Source ID. It is an optional value that may be used to group events for analysis according to the type of source where the event occurred.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Coding"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "AuditEventSourceType"
                }
              ],
              "strength": "extensible",
              "description": "Code specifying the type of system that detected and recorded the event.",
              "valueSet": "http://hl7.org/fhir/ValueSet/audit-source-type"
            }
          },
          {
            "id": "AuditEvent.entity",
            "path": "AuditEvent.entity",
            "short": "Data or objects used",
            "definition": "Specific instances of data or objects that have been accessed.",
            "comment": "Required unless the values for event identification, agent identification, and audit source identification are sufficient to document the entire auditable event. Because events may have more than one entity, this group can be a repeating set of values.",
            "requirements": "The event may have other entities involved.",
            "alias": [
              "ParticipantObject"
            ],
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "AuditEvent.entity.what",
            "path": "AuditEvent.entity.what",
            "short": "Specific instance of resource",
            "definition": "Identifies a specific instance of the entity. The reference should be version specific.",
            "min": 0,
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
            "id": "AuditEvent.entity.type",
            "path": "AuditEvent.entity.type",
            "short": "Type of entity involved",
            "definition": "The type of the object that was involved in this audit event.",
            "comment": "This value is distinct from the user's role or any user relationship to the entity.",
            "requirements": "To describe the object being acted upon. In addition to queries on the subject of the action in an auditable event, it is also important to be able to query on the object type for the action.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Coding"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "AuditEventEntityType"
                }
              ],
              "strength": "extensible",
              "description": "Code for the entity type involved in the audit event.",
              "valueSet": "http://hl7.org/fhir/ValueSet/audit-entity-type"
            }
          },
          {
            "id": "AuditEvent.entity.role",
            "path": "AuditEvent.entity.role",
            "short": "What role the entity played",
            "definition": "Code representing the role the entity played in the event being audited.",
            "requirements": "For some detailed audit analysis it may be necessary to indicate a more granular type of entity, based on the application role it serves.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Coding"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "AuditEventEntityRole"
                }
              ],
              "strength": "extensible",
              "description": "Code representing the role the entity played in the audit event.",
              "valueSet": "http://hl7.org/fhir/ValueSet/object-role"
            }
          },
          {
            "id": "AuditEvent.entity.lifecycle",
            "path": "AuditEvent.entity.lifecycle",
            "short": "Life-cycle stage for the entity",
            "definition": "Identifier for the data life-cycle stage for the entity.",
            "comment": "This can be used to provide an audit trail for data, over time, as it passes through the system.",
            "requirements": "Institutional policies for privacy and security may optionally fall under different accountability rules based on data life cycle. This provides a differentiating value for those cases.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Coding"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "AuditEventEntityLifecycle"
                }
              ],
              "strength": "extensible",
              "description": "Identifier for the data life-cycle stage for the entity.",
              "valueSet": "http://hl7.org/fhir/ValueSet/object-lifecycle-events"
            }
          },
          {
            "id": "AuditEvent.entity.securityLabel",
            "path": "AuditEvent.entity.securityLabel",
            "short": "Security labels on the entity",
            "definition": "Security labels for the identified entity.",
            "comment": "Copied from entity meta security tags.",
            "requirements": "This field identifies the security labels for a specific instance of an object, such as a patient, to detect/track privacy and security issues.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Coding"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "SecurityLabels"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "extensible",
              "description": "Security Labels from the Healthcare Privacy and Security Classification System.",
              "valueSet": "http://hl7.org/fhir/ValueSet/security-labels"
            }
          },
          {
            "id": "AuditEvent.entity.name",
            "path": "AuditEvent.entity.name",
            "short": "Descriptor for entity",
            "definition": "A name of the entity in the audit event.",
            "comment": "This field may be used in a query/report to identify audit events for a specific person.  For example, where multiple synonymous entity identifiers (patient number, medical record number, encounter number, etc.) have been used.",
            "requirements": "Use only where entity can't be identified with an identifier.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "condition": [
              "sev-1"
            ],
            "isSummary": true
          },
          {
            "id": "AuditEvent.entity.description",
            "path": "AuditEvent.entity.description",
            "short": "Descriptive text",
            "definition": "Text that describes the entity in more detail.",
            "requirements": "Use only where entity can't be identified with an identifier.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "AuditEvent.entity.query",
            "path": "AuditEvent.entity.query",
            "short": "Query parameters",
            "definition": "The query parameters for a query-type entities.",
            "comment": "The meaning and secondary-encoding of the content of base64 encoded blob is specific to the AuditEvent.type, AuditEvent.subtype, AuditEvent.entity.type, and AuditEvent.entity.role.  The base64 is a general-use and safe container for event specific data blobs regardless of the encoding used by the transaction being recorded.  An AuditEvent consuming application must understand the event it is consuming and the formats used by the event. For example, if auditing an Oracle network database access, the Oracle formats must be understood as they will be simply encoded in the base64binary blob.",
            "requirements": "For query events, it may be necessary to capture the actual query input to the query process in order to identify the specific event. Because of differences among query implementations and data encoding for them, this is a base 64 encoded data blob. It may be subsequently decoded or interpreted by downstream audit analysis processing.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "base64Binary"
              }
            ],
            "condition": [
              "sev-1"
            ],
            "isSummary": true
          },
          {
            "id": "AuditEvent.entity.detail",
            "path": "AuditEvent.entity.detail",
            "short": "Additional Information about the entity",
            "definition": "Tagged value pairs for conveying additional information about the entity.",
            "requirements": "Implementation-defined data about specific details of the object accessed or used.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "AuditEvent.entity.detail.type",
            "path": "AuditEvent.entity.detail.type",
            "short": "Name of the property",
            "definition": "The type of extra detail provided in the value.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "AuditEvent.entity.detail.value[x]",
            "path": "AuditEvent.entity.detail.value[x]",
            "short": "Property value",
            "definition": "The  value of the extra detail.",
            "comment": "The value can be string when known to be a string, else base64 encoding should be used to protect binary or undefined content.  The meaning and secondary-encoding of the content of base64 encoded blob is specific to the AuditEvent.type, AuditEvent.subtype, AuditEvent.entity.type, and AuditEvent.entity.role.  The base64 is a general-use and safe container for event specific data blobs regardless of the encoding used by the transaction being recorded.  An AuditEvent consuming application must understand the event it is consuming and the formats used by the event. For example if auditing an Oracle network database access, the Oracle formats must be understood as they will be simply encoded in the base64binary blob.",
            "requirements": "Should not duplicate the entity value unless absolutely necessary.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "string"
              },
              {
                "code": "base64Binary"
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:444
    /// <summary>
    /// Fhir resource 'AuditEvent'
    /// </summary>
    // 0. AuditEvent
    public partial class Resource_AuditEvent : FhirKhit.Maker.Common.Resource.Resource_DomainResource                                       // MakerGen.cs:381
    {                                                                                                                                       // MakerGen.cs:382
        // 9. AuditEvent.agent
        public partial class Type_Agent : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 19. AuditEvent.agent.network
            public partial class Type_Network : FhirKhit.Maker.Common.Complex.ComplexBase                                                   // MakerGen.cs:381
            {                                                                                                                               // MakerGen.cs:382
                // 20. AuditEvent.agent.network.address
                public ElementDefinitionInfo Element_Address;                                                                               // MakerGen.cs:217
                // 21. AuditEvent.agent.network.type
                public ElementDefinitionInfo Element_Type;                                                                                  // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:388
                {                                                                                                                           // MakerGen.cs:389
                    base.Write(sDef);                                                                                                       // MakerGen.cs:390
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:391
                    {                                                                                                                       // MakerGen.cs:392
                        Path = "AuditEvent.agent.network",                                                                                  // MakerGen.cs:393
                        ElementId = "AuditEvent.agent.network"                                                                              // MakerGen.cs:394
                    });                                                                                                                     // MakerGen.cs:395
                    Element_Address.Write(sDef);                                                                                            // MakerGen.cs:221
                    Element_Type.Write(sDef);                                                                                               // MakerGen.cs:221
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
                public Type_Network()                                                                                                       // MakerGen.cs:400
                {                                                                                                                           // MakerGen.cs:401
                    {                                                                                                                       // MakerGen.cs:232
                        // 20. AuditEvent.agent.network.address
                        this.Element_Address = new ElementDefinitionInfo                                                                    // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_Address",                                                                                       // MakerGen.cs:236
                            Path= "AuditEvent.agent.network.address",                                                                       // MakerGen.cs:237
                            Id = "AuditEvent.agent.network.address",                                                                        // MakerGen.cs:238
                            Min = 0,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Primitive.Primitive_String                                                        // MakerGen.cs:301
                                {                                                                                                           // MakerGen.cs:302
                                }                                                                                                           // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                    {                                                                                                                       // MakerGen.cs:232
                        // 21. AuditEvent.agent.network.type
                        this.Element_Type = new ElementDefinitionInfo                                                                       // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_Type",                                                                                          // MakerGen.cs:236
                            Path= "AuditEvent.agent.network.type",                                                                          // MakerGen.cs:237
                            Id = "AuditEvent.agent.network.type",                                                                           // MakerGen.cs:238
                            Min = 0,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                          // MakerGen.cs:301
                                {                                                                                                           // MakerGen.cs:302
                                }                                                                                                           // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                }                                                                                                                           // MakerGen.cs:403
            }                                                                                                                               // MakerGen.cs:405
            // 10. AuditEvent.agent.type
            public ElementDefinitionInfo Element_Type;                                                                                      // MakerGen.cs:217
            // 11. AuditEvent.agent.role
            public ElementDefinitionInfo Element_Role;                                                                                      // MakerGen.cs:217
            // 12. AuditEvent.agent.who
            public ElementDefinitionInfo Element_Who;                                                                                       // MakerGen.cs:217
            // 13. AuditEvent.agent.altId
            public ElementDefinitionInfo Element_AltId;                                                                                     // MakerGen.cs:217
            // 14. AuditEvent.agent.name
            public ElementDefinitionInfo Element_Name;                                                                                      // MakerGen.cs:217
            // 15. AuditEvent.agent.requestor
            public ElementDefinitionInfo Element_Requestor;                                                                                 // MakerGen.cs:217
            // 16. AuditEvent.agent.location
            public ElementDefinitionInfo Element_Location;                                                                                  // MakerGen.cs:217
            // 17. AuditEvent.agent.policy
            public ElementDefinitionInfo Element_Policy;                                                                                    // MakerGen.cs:217
            // 18. AuditEvent.agent.media
            public ElementDefinitionInfo Element_Media;                                                                                     // MakerGen.cs:217
            // 19. AuditEvent.agent.network
            public ElementDefinitionInfo Element_Network;                                                                                   // MakerGen.cs:217
            // 22. AuditEvent.agent.purposeOfUse
            public ElementDefinitionInfo Element_PurposeOfUse;                                                                              // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:388
            {                                                                                                                               // MakerGen.cs:389
                base.Write(sDef);                                                                                                           // MakerGen.cs:390
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:391
                {                                                                                                                           // MakerGen.cs:392
                    Path = "AuditEvent.agent",                                                                                              // MakerGen.cs:393
                    ElementId = "AuditEvent.agent"                                                                                          // MakerGen.cs:394
                });                                                                                                                         // MakerGen.cs:395
                Element_Type.Write(sDef);                                                                                                   // MakerGen.cs:221
                Element_Role.Write(sDef);                                                                                                   // MakerGen.cs:221
                Element_Who.Write(sDef);                                                                                                    // MakerGen.cs:221
                Element_AltId.Write(sDef);                                                                                                  // MakerGen.cs:221
                Element_Name.Write(sDef);                                                                                                   // MakerGen.cs:221
                Element_Requestor.Write(sDef);                                                                                              // MakerGen.cs:221
                Element_Location.Write(sDef);                                                                                               // MakerGen.cs:221
                Element_Policy.Write(sDef);                                                                                                 // MakerGen.cs:221
                Element_Media.Write(sDef);                                                                                                  // MakerGen.cs:221
                Element_Network.Write(sDef);                                                                                                // MakerGen.cs:221
                Element_PurposeOfUse.Write(sDef);                                                                                           // MakerGen.cs:221
            }                                                                                                                               // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
            public Type_Agent()                                                                                                             // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:232
                    // 10. AuditEvent.agent.type
                    this.Element_Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Type",                                                                                              // MakerGen.cs:236
                        Path= "AuditEvent.agent.type",                                                                                      // MakerGen.cs:237
                        Id = "AuditEvent.agent.type",                                                                                       // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:316
                            {                                                                                                               // MakerGen.cs:317
                            }                                                                                                               // MakerGen.cs:320
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 11. AuditEvent.agent.role
                    this.Element_Role = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Role",                                                                                              // MakerGen.cs:236
                        Path= "AuditEvent.agent.role",                                                                                      // MakerGen.cs:237
                        Id = "AuditEvent.agent.role",                                                                                       // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = -1,                                                                                                           // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:316
                            {                                                                                                               // MakerGen.cs:317
                            }                                                                                                               // MakerGen.cs:320
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 12. AuditEvent.agent.who
                    this.Element_Who = new ElementDefinitionInfo                                                                            // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Who",                                                                                               // MakerGen.cs:236
                        Path= "AuditEvent.agent.who",                                                                                       // MakerGen.cs:237
                        Id = "AuditEvent.agent.who",                                                                                        // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:344
                            {                                                                                                               // MakerGen.cs:345
                                TargetProfile = new String[]                                                                                // MakerGen.cs:347
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:347
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:347
                                    "http://hl7.org/fhir/StructureDefinition/Organization",                                                 // MakerGen.cs:347
                                    "http://hl7.org/fhir/StructureDefinition/Device",                                                       // MakerGen.cs:347
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:347
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson"                                                 // MakerGen.cs:347
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:348
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 13. AuditEvent.agent.altId
                    this.Element_AltId = new ElementDefinitionInfo                                                                          // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_AltId",                                                                                             // MakerGen.cs:236
                        Path= "AuditEvent.agent.altId",                                                                                     // MakerGen.cs:237
                        Id = "AuditEvent.agent.altId",                                                                                      // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 14. AuditEvent.agent.name
                    this.Element_Name = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Name",                                                                                              // MakerGen.cs:236
                        Path= "AuditEvent.agent.name",                                                                                      // MakerGen.cs:237
                        Id = "AuditEvent.agent.name",                                                                                       // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 15. AuditEvent.agent.requestor
                    this.Element_Requestor = new ElementDefinitionInfo                                                                      // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Requestor",                                                                                         // MakerGen.cs:236
                        Path= "AuditEvent.agent.requestor",                                                                                 // MakerGen.cs:237
                        Id = "AuditEvent.agent.requestor",                                                                                  // MakerGen.cs:238
                        Min = 1,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                           // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 16. AuditEvent.agent.location
                    this.Element_Location = new ElementDefinitionInfo                                                                       // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Location",                                                                                          // MakerGen.cs:236
                        Path= "AuditEvent.agent.location",                                                                                  // MakerGen.cs:237
                        Id = "AuditEvent.agent.location",                                                                                   // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:344
                            {                                                                                                               // MakerGen.cs:345
                                TargetProfile = new String[]                                                                                // MakerGen.cs:347
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Location"                                                      // MakerGen.cs:347
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:348
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 17. AuditEvent.agent.policy
                    this.Element_Policy = new ElementDefinitionInfo                                                                         // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Policy",                                                                                            // MakerGen.cs:236
                        Path= "AuditEvent.agent.policy",                                                                                    // MakerGen.cs:237
                        Id = "AuditEvent.agent.policy",                                                                                     // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = -1,                                                                                                           // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_Uri                                                               // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 18. AuditEvent.agent.media
                    this.Element_Media = new ElementDefinitionInfo                                                                          // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Media",                                                                                             // MakerGen.cs:236
                        Path= "AuditEvent.agent.media",                                                                                     // MakerGen.cs:237
                        Id = "AuditEvent.agent.media",                                                                                      // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_Coding                                                                   // MakerGen.cs:316
                            {                                                                                                               // MakerGen.cs:317
                            }                                                                                                               // MakerGen.cs:320
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 19. AuditEvent.agent.network
                    this.Element_Network = new ElementDefinitionInfo                                                                        // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Network",                                                                                           // MakerGen.cs:236
                        Path= "AuditEvent.agent.network",                                                                                   // MakerGen.cs:237
                        Id = "AuditEvent.agent.network",                                                                                    // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new Type_Network                                                                                                // MakerGen.cs:260
                            {                                                                                                               // MakerGen.cs:261
                            }                                                                                                               // MakerGen.cs:262
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 22. AuditEvent.agent.purposeOfUse
                    this.Element_PurposeOfUse = new ElementDefinitionInfo                                                                   // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_PurposeOfUse",                                                                                      // MakerGen.cs:236
                        Path= "AuditEvent.agent.purposeOfUse",                                                                              // MakerGen.cs:237
                        Id = "AuditEvent.agent.purposeOfUse",                                                                               // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = -1,                                                                                                           // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:316
                            {                                                                                                               // MakerGen.cs:317
                            }                                                                                                               // MakerGen.cs:320
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
            }                                                                                                                               // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:405
        // 23. AuditEvent.source
        public partial class Type_Source : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 24. AuditEvent.source.site
            public ElementDefinitionInfo Element_Site;                                                                                      // MakerGen.cs:217
            // 25. AuditEvent.source.observer
            public ElementDefinitionInfo Element_Observer;                                                                                  // MakerGen.cs:217
            // 26. AuditEvent.source.type
            public ElementDefinitionInfo Element_Type;                                                                                      // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:388
            {                                                                                                                               // MakerGen.cs:389
                base.Write(sDef);                                                                                                           // MakerGen.cs:390
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:391
                {                                                                                                                           // MakerGen.cs:392
                    Path = "AuditEvent.source",                                                                                             // MakerGen.cs:393
                    ElementId = "AuditEvent.source"                                                                                         // MakerGen.cs:394
                });                                                                                                                         // MakerGen.cs:395
                Element_Site.Write(sDef);                                                                                                   // MakerGen.cs:221
                Element_Observer.Write(sDef);                                                                                               // MakerGen.cs:221
                Element_Type.Write(sDef);                                                                                                   // MakerGen.cs:221
            }                                                                                                                               // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
            public Type_Source()                                                                                                            // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:232
                    // 24. AuditEvent.source.site
                    this.Element_Site = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Site",                                                                                              // MakerGen.cs:236
                        Path= "AuditEvent.source.site",                                                                                     // MakerGen.cs:237
                        Id = "AuditEvent.source.site",                                                                                      // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 25. AuditEvent.source.observer
                    this.Element_Observer = new ElementDefinitionInfo                                                                       // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Observer",                                                                                          // MakerGen.cs:236
                        Path= "AuditEvent.source.observer",                                                                                 // MakerGen.cs:237
                        Id = "AuditEvent.source.observer",                                                                                  // MakerGen.cs:238
                        Min = 1,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:344
                            {                                                                                                               // MakerGen.cs:345
                                TargetProfile = new String[]                                                                                // MakerGen.cs:347
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:347
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:347
                                    "http://hl7.org/fhir/StructureDefinition/Organization",                                                 // MakerGen.cs:347
                                    "http://hl7.org/fhir/StructureDefinition/Device",                                                       // MakerGen.cs:347
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:347
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson"                                                 // MakerGen.cs:347
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:348
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 26. AuditEvent.source.type
                    this.Element_Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Type",                                                                                              // MakerGen.cs:236
                        Path= "AuditEvent.source.type",                                                                                     // MakerGen.cs:237
                        Id = "AuditEvent.source.type",                                                                                      // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = -1,                                                                                                           // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_Coding                                                                   // MakerGen.cs:316
                            {                                                                                                               // MakerGen.cs:317
                            }                                                                                                               // MakerGen.cs:320
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
            }                                                                                                                               // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:405
        // 27. AuditEvent.entity
        public partial class Type_Entity : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 36. AuditEvent.entity.detail
            public partial class Type_Detail : FhirKhit.Maker.Common.Complex.ComplexBase                                                    // MakerGen.cs:381
            {                                                                                                                               // MakerGen.cs:382
                // 37. AuditEvent.entity.detail.type
                public ElementDefinitionInfo Element_Type;                                                                                  // MakerGen.cs:217
                // 38. AuditEvent.entity.detail.value[x]
                public ElementDefinitionInfo Element_Value;                                                                                 // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:388
                {                                                                                                                           // MakerGen.cs:389
                    base.Write(sDef);                                                                                                       // MakerGen.cs:390
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:391
                    {                                                                                                                       // MakerGen.cs:392
                        Path = "AuditEvent.entity.detail",                                                                                  // MakerGen.cs:393
                        ElementId = "AuditEvent.entity.detail"                                                                              // MakerGen.cs:394
                    });                                                                                                                     // MakerGen.cs:395
                    Element_Type.Write(sDef);                                                                                               // MakerGen.cs:221
                    Element_Value.Write(sDef);                                                                                              // MakerGen.cs:221
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
                public Type_Detail()                                                                                                        // MakerGen.cs:400
                {                                                                                                                           // MakerGen.cs:401
                    {                                                                                                                       // MakerGen.cs:232
                        // 37. AuditEvent.entity.detail.type
                        this.Element_Type = new ElementDefinitionInfo                                                                       // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_Type",                                                                                          // MakerGen.cs:236
                            Path= "AuditEvent.entity.detail.type",                                                                          // MakerGen.cs:237
                            Id = "AuditEvent.entity.detail.type",                                                                           // MakerGen.cs:238
                            Min = 1,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Primitive.Primitive_String                                                        // MakerGen.cs:301
                                {                                                                                                           // MakerGen.cs:302
                                }                                                                                                           // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                    {                                                                                                                       // MakerGen.cs:232
                        // 38. AuditEvent.entity.detail.value[x]
                        this.Element_Value = new ElementDefinitionInfo                                                                      // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_Value",                                                                                         // MakerGen.cs:236
                            Path= "AuditEvent.entity.detail.value[x]",                                                                      // MakerGen.cs:237
                            Id = "AuditEvent.entity.detail.value[x]",                                                                       // MakerGen.cs:238
                            Min = 1,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Primitive.Primitive_String                                                        // MakerGen.cs:301
                                {                                                                                                           // MakerGen.cs:302
                                },                                                                                                          // MakerGen.cs:305
                                new FhirKhit.Maker.Common.Primitive.Primitive_Base64Binary                                                  // MakerGen.cs:301
                                {                                                                                                           // MakerGen.cs:302
                                }                                                                                                           // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                }                                                                                                                           // MakerGen.cs:403
            }                                                                                                                               // MakerGen.cs:405
            // 28. AuditEvent.entity.what
            public ElementDefinitionInfo Element_What;                                                                                      // MakerGen.cs:217
            // 29. AuditEvent.entity.type
            public ElementDefinitionInfo Element_Type;                                                                                      // MakerGen.cs:217
            // 30. AuditEvent.entity.role
            public ElementDefinitionInfo Element_Role;                                                                                      // MakerGen.cs:217
            // 31. AuditEvent.entity.lifecycle
            public ElementDefinitionInfo Element_Lifecycle;                                                                                 // MakerGen.cs:217
            // 32. AuditEvent.entity.securityLabel
            public ElementDefinitionInfo Element_SecurityLabel;                                                                             // MakerGen.cs:217
            // 33. AuditEvent.entity.name
            public ElementDefinitionInfo Element_Name;                                                                                      // MakerGen.cs:217
            // 34. AuditEvent.entity.description
            public ElementDefinitionInfo Element_Description;                                                                               // MakerGen.cs:217
            // 35. AuditEvent.entity.query
            public ElementDefinitionInfo Element_Query;                                                                                     // MakerGen.cs:217
            // 36. AuditEvent.entity.detail
            public ElementDefinitionInfo Element_Detail;                                                                                    // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:388
            {                                                                                                                               // MakerGen.cs:389
                base.Write(sDef);                                                                                                           // MakerGen.cs:390
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:391
                {                                                                                                                           // MakerGen.cs:392
                    Path = "AuditEvent.entity",                                                                                             // MakerGen.cs:393
                    ElementId = "AuditEvent.entity"                                                                                         // MakerGen.cs:394
                });                                                                                                                         // MakerGen.cs:395
                Element_What.Write(sDef);                                                                                                   // MakerGen.cs:221
                Element_Type.Write(sDef);                                                                                                   // MakerGen.cs:221
                Element_Role.Write(sDef);                                                                                                   // MakerGen.cs:221
                Element_Lifecycle.Write(sDef);                                                                                              // MakerGen.cs:221
                Element_SecurityLabel.Write(sDef);                                                                                          // MakerGen.cs:221
                Element_Name.Write(sDef);                                                                                                   // MakerGen.cs:221
                Element_Description.Write(sDef);                                                                                            // MakerGen.cs:221
                Element_Query.Write(sDef);                                                                                                  // MakerGen.cs:221
                Element_Detail.Write(sDef);                                                                                                 // MakerGen.cs:221
            }                                                                                                                               // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
            public Type_Entity()                                                                                                            // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:232
                    // 28. AuditEvent.entity.what
                    this.Element_What = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_What",                                                                                              // MakerGen.cs:236
                        Path= "AuditEvent.entity.what",                                                                                     // MakerGen.cs:237
                        Id = "AuditEvent.entity.what",                                                                                      // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:344
                            {                                                                                                               // MakerGen.cs:345
                                TargetProfile = new String[]                                                                                // MakerGen.cs:347
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Resource"                                                      // MakerGen.cs:347
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:348
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 29. AuditEvent.entity.type
                    this.Element_Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Type",                                                                                              // MakerGen.cs:236
                        Path= "AuditEvent.entity.type",                                                                                     // MakerGen.cs:237
                        Id = "AuditEvent.entity.type",                                                                                      // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_Coding                                                                   // MakerGen.cs:316
                            {                                                                                                               // MakerGen.cs:317
                            }                                                                                                               // MakerGen.cs:320
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 30. AuditEvent.entity.role
                    this.Element_Role = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Role",                                                                                              // MakerGen.cs:236
                        Path= "AuditEvent.entity.role",                                                                                     // MakerGen.cs:237
                        Id = "AuditEvent.entity.role",                                                                                      // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_Coding                                                                   // MakerGen.cs:316
                            {                                                                                                               // MakerGen.cs:317
                            }                                                                                                               // MakerGen.cs:320
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 31. AuditEvent.entity.lifecycle
                    this.Element_Lifecycle = new ElementDefinitionInfo                                                                      // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Lifecycle",                                                                                         // MakerGen.cs:236
                        Path= "AuditEvent.entity.lifecycle",                                                                                // MakerGen.cs:237
                        Id = "AuditEvent.entity.lifecycle",                                                                                 // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_Coding                                                                   // MakerGen.cs:316
                            {                                                                                                               // MakerGen.cs:317
                            }                                                                                                               // MakerGen.cs:320
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 32. AuditEvent.entity.securityLabel
                    this.Element_SecurityLabel = new ElementDefinitionInfo                                                                  // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_SecurityLabel",                                                                                     // MakerGen.cs:236
                        Path= "AuditEvent.entity.securityLabel",                                                                            // MakerGen.cs:237
                        Id = "AuditEvent.entity.securityLabel",                                                                             // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = -1,                                                                                                           // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_Coding                                                                   // MakerGen.cs:316
                            {                                                                                                               // MakerGen.cs:317
                            }                                                                                                               // MakerGen.cs:320
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 33. AuditEvent.entity.name
                    this.Element_Name = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Name",                                                                                              // MakerGen.cs:236
                        Path= "AuditEvent.entity.name",                                                                                     // MakerGen.cs:237
                        Id = "AuditEvent.entity.name",                                                                                      // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 34. AuditEvent.entity.description
                    this.Element_Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Description",                                                                                       // MakerGen.cs:236
                        Path= "AuditEvent.entity.description",                                                                              // MakerGen.cs:237
                        Id = "AuditEvent.entity.description",                                                                               // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 35. AuditEvent.entity.query
                    this.Element_Query = new ElementDefinitionInfo                                                                          // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Query",                                                                                             // MakerGen.cs:236
                        Path= "AuditEvent.entity.query",                                                                                    // MakerGen.cs:237
                        Id = "AuditEvent.entity.query",                                                                                     // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_Base64Binary                                                      // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 36. AuditEvent.entity.detail
                    this.Element_Detail = new ElementDefinitionInfo                                                                         // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Detail",                                                                                            // MakerGen.cs:236
                        Path= "AuditEvent.entity.detail",                                                                                   // MakerGen.cs:237
                        Id = "AuditEvent.entity.detail",                                                                                    // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = -1,                                                                                                           // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new Type_Detail                                                                                                 // MakerGen.cs:260
                            {                                                                                                               // MakerGen.cs:261
                            }                                                                                                               // MakerGen.cs:262
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
            }                                                                                                                               // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:405
        // 1. AuditEvent.type
        public ElementDefinitionInfo Element_Type;                                                                                          // MakerGen.cs:217
        // 2. AuditEvent.subtype
        public ElementDefinitionInfo Element_Subtype;                                                                                       // MakerGen.cs:217
        // 3. AuditEvent.action
        public ElementDefinitionInfo Element_Action;                                                                                        // MakerGen.cs:217
        // 4. AuditEvent.period
        public ElementDefinitionInfo Element_Period;                                                                                        // MakerGen.cs:217
        // 5. AuditEvent.recorded
        public ElementDefinitionInfo Element_Recorded;                                                                                      // MakerGen.cs:217
        // 6. AuditEvent.outcome
        public ElementDefinitionInfo Element_Outcome;                                                                                       // MakerGen.cs:217
        // 7. AuditEvent.outcomeDesc
        public ElementDefinitionInfo Element_OutcomeDesc;                                                                                   // MakerGen.cs:217
        // 8. AuditEvent.purposeOfEvent
        public ElementDefinitionInfo Element_PurposeOfEvent;                                                                                // MakerGen.cs:217
        // 9. AuditEvent.agent
        public ElementDefinitionInfo Element_Agent;                                                                                         // MakerGen.cs:217
        // 23. AuditEvent.source
        public ElementDefinitionInfo Element_Source;                                                                                        // MakerGen.cs:217
        // 27. AuditEvent.entity
        public ElementDefinitionInfo Element_Entity;                                                                                        // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:388
        {                                                                                                                                   // MakerGen.cs:389
            base.Write(sDef);                                                                                                               // MakerGen.cs:390
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:391
            {                                                                                                                               // MakerGen.cs:392
                Path = "AuditEvent",                                                                                                        // MakerGen.cs:393
                ElementId = "AuditEvent"                                                                                                    // MakerGen.cs:394
            });                                                                                                                             // MakerGen.cs:395
            Element_Type.Write(sDef);                                                                                                       // MakerGen.cs:221
            Element_Subtype.Write(sDef);                                                                                                    // MakerGen.cs:221
            Element_Action.Write(sDef);                                                                                                     // MakerGen.cs:221
            Element_Period.Write(sDef);                                                                                                     // MakerGen.cs:221
            Element_Recorded.Write(sDef);                                                                                                   // MakerGen.cs:221
            Element_Outcome.Write(sDef);                                                                                                    // MakerGen.cs:221
            Element_OutcomeDesc.Write(sDef);                                                                                                // MakerGen.cs:221
            Element_PurposeOfEvent.Write(sDef);                                                                                             // MakerGen.cs:221
            Element_Agent.Write(sDef);                                                                                                      // MakerGen.cs:221
            Element_Source.Write(sDef);                                                                                                     // MakerGen.cs:221
            Element_Entity.Write(sDef);                                                                                                     // MakerGen.cs:221
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
        public Resource_AuditEvent()                                                                                                        // MakerGen.cs:400
        {                                                                                                                                   // MakerGen.cs:401
            {                                                                                                                               // MakerGen.cs:232
                // 1. AuditEvent.type
                this.Element_Type = new ElementDefinitionInfo                                                                               // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Type",                                                                                                  // MakerGen.cs:236
                    Path= "AuditEvent.type",                                                                                                // MakerGen.cs:237
                    Id = "AuditEvent.type",                                                                                                 // MakerGen.cs:238
                    Min = 1,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Coding                                                                       // MakerGen.cs:316
                        {                                                                                                                   // MakerGen.cs:317
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 2. AuditEvent.subtype
                this.Element_Subtype = new ElementDefinitionInfo                                                                            // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Subtype",                                                                                               // MakerGen.cs:236
                    Path= "AuditEvent.subtype",                                                                                             // MakerGen.cs:237
                    Id = "AuditEvent.subtype",                                                                                              // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Coding                                                                       // MakerGen.cs:316
                        {                                                                                                                   // MakerGen.cs:317
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 3. AuditEvent.action
                this.Element_Action = new ElementDefinitionInfo                                                                             // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Action",                                                                                                // MakerGen.cs:236
                    Path= "AuditEvent.action",                                                                                              // MakerGen.cs:237
                    Id = "AuditEvent.action",                                                                                               // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 4. AuditEvent.period
                this.Element_Period = new ElementDefinitionInfo                                                                             // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Period",                                                                                                // MakerGen.cs:236
                    Path= "AuditEvent.period",                                                                                              // MakerGen.cs:237
                    Id = "AuditEvent.period",                                                                                               // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Period                                                                       // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        }                                                                                                                   // MakerGen.cs:358
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 5. AuditEvent.recorded
                this.Element_Recorded = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Recorded",                                                                                              // MakerGen.cs:236
                    Path= "AuditEvent.recorded",                                                                                            // MakerGen.cs:237
                    Id = "AuditEvent.recorded",                                                                                             // MakerGen.cs:238
                    Min = 1,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Instant                                                               // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 6. AuditEvent.outcome
                this.Element_Outcome = new ElementDefinitionInfo                                                                            // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Outcome",                                                                                               // MakerGen.cs:236
                    Path= "AuditEvent.outcome",                                                                                             // MakerGen.cs:237
                    Id = "AuditEvent.outcome",                                                                                              // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 7. AuditEvent.outcomeDesc
                this.Element_OutcomeDesc = new ElementDefinitionInfo                                                                        // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_OutcomeDesc",                                                                                           // MakerGen.cs:236
                    Path= "AuditEvent.outcomeDesc",                                                                                         // MakerGen.cs:237
                    Id = "AuditEvent.outcomeDesc",                                                                                          // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 8. AuditEvent.purposeOfEvent
                this.Element_PurposeOfEvent = new ElementDefinitionInfo                                                                     // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_PurposeOfEvent",                                                                                        // MakerGen.cs:236
                    Path= "AuditEvent.purposeOfEvent",                                                                                      // MakerGen.cs:237
                    Id = "AuditEvent.purposeOfEvent",                                                                                       // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:316
                        {                                                                                                                   // MakerGen.cs:317
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 9. AuditEvent.agent
                this.Element_Agent = new ElementDefinitionInfo                                                                              // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Agent",                                                                                                 // MakerGen.cs:236
                    Path= "AuditEvent.agent",                                                                                               // MakerGen.cs:237
                    Id = "AuditEvent.agent",                                                                                                // MakerGen.cs:238
                    Min = 1,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new Type_Agent                                                                                                      // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:262
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 23. AuditEvent.source
                this.Element_Source = new ElementDefinitionInfo                                                                             // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Source",                                                                                                // MakerGen.cs:236
                    Path= "AuditEvent.source",                                                                                              // MakerGen.cs:237
                    Id = "AuditEvent.source",                                                                                               // MakerGen.cs:238
                    Min = 1,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new Type_Source                                                                                                     // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:262
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 27. AuditEvent.entity
                this.Element_Entity = new ElementDefinitionInfo                                                                             // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Entity",                                                                                                // MakerGen.cs:236
                    Path= "AuditEvent.entity",                                                                                              // MakerGen.cs:237
                    Id = "AuditEvent.entity",                                                                                               // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new Type_Entity                                                                                                     // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:262
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            this.Name = "AuditEvent";                                                                                                       // MakerGen.cs:468
            this.Uri = "http://hl7.org/fhir/StructureDefinition/AuditEvent";                                                                // MakerGen.cs:469
        }                                                                                                                                   // MakerGen.cs:403
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:449
