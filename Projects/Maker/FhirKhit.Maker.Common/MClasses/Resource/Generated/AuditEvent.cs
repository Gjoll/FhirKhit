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
    #endregion                                                                                                                              // MakerGen.cs:474
    /// <summary>
    /// Fhir resource 'AuditEvent'
    /// </summary>
    // 0. AuditEvent
    public class AuditEvent : FhirKhit.Maker.Common.Resource.ResourceBase                                                                   // MakerGen.cs:384
    {                                                                                                                                       // MakerGen.cs:385
        public class AuditEvent_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                      // MakerGen.cs:386
        {                                                                                                                                   // MakerGen.cs:387
            // 9. AuditEvent.agent
            public class Type_Agent : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                public class Type_Agent_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                              // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    // 19. AuditEvent.agent.network
                    public class Type_Network : FhirKhit.Maker.Common.Complex.ComplexBase                                                   // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        public class Type_Network_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                    // MakerGen.cs:386
                        {                                                                                                                   // MakerGen.cs:387
                            // 20. AuditEvent.agent.network.address
                            public ElementDefinitionInfo Address;                                                                           // MakerGen.cs:216
                            // 21. AuditEvent.agent.network.type
                            public ElementDefinitionInfo Type;                                                                              // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                            public Type_Network_Elements()                                                                                  // MakerGen.cs:392
                            {                                                                                                               // MakerGen.cs:393
                                {                                                                                                           // MakerGen.cs:231
                                    // 20. AuditEvent.agent.network.address
                                    this.Address = new ElementDefinitionInfo                                                                // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Address",                                                                                   // MakerGen.cs:235
                                        Path= "AuditEvent.agent.network.address",                                                           // MakerGen.cs:236
                                        Id = "AuditEvent.agent.network.address",                                                            // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 21. AuditEvent.agent.network.type
                                    this.Type = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Type",                                                                                      // MakerGen.cs:235
                                        Path= "AuditEvent.agent.network.type",                                                              // MakerGen.cs:236
                                        Id = "AuditEvent.agent.network.type",                                                               // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.Code                                                        // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                            }                                                                                                               // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:398
                            {                                                                                                               // MakerGen.cs:399
                                base.Write(sDef);                                                                                           // MakerGen.cs:400
                                Address.Write(sDef);                                                                                        // MakerGen.cs:220
                                Type.Write(sDef);                                                                                           // MakerGen.cs:220
                            }                                                                                                               // MakerGen.cs:402
                        }                                                                                                                   // MakerGen.cs:404
                        public Type_Network_Elements Elements                                                                               // MakerGen.cs:406
                        {                                                                                                                   // MakerGen.cs:407
                            get                                                                                                             // MakerGen.cs:408
                            {                                                                                                               // MakerGen.cs:409
                                if (this.elements == null)                                                                                  // MakerGen.cs:410
                                    this.elements = new Type_Network_Elements();                                                            // MakerGen.cs:411
                                return this.elements;                                                                                       // MakerGen.cs:412
                            }                                                                                                               // MakerGen.cs:413
                        }                                                                                                                   // MakerGen.cs:414
                        Type_Network_Elements elements;                                                                                     // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                        public Type_Network()                                                                                               // MakerGen.cs:418
                        {                                                                                                                   // MakerGen.cs:419
                        }                                                                                                                   // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:424
                        {                                                                                                                   // MakerGen.cs:425
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:426
                            {                                                                                                               // MakerGen.cs:427
                                Path = "AuditEvent.agent.network",                                                                          // MakerGen.cs:428
                                ElementId = "AuditEvent.agent.network"                                                                      // MakerGen.cs:429
                            });                                                                                                             // MakerGen.cs:430
                            if (this.elements != null)                                                                                      // MakerGen.cs:431
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:432
                        }                                                                                                                   // MakerGen.cs:433
                    }                                                                                                                       // MakerGen.cs:434
                    // 10. AuditEvent.agent.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:216
                    // 11. AuditEvent.agent.role
                    public ElementDefinitionInfo Role;                                                                                      // MakerGen.cs:216
                    // 12. AuditEvent.agent.who
                    public ElementDefinitionInfo Who;                                                                                       // MakerGen.cs:216
                    // 13. AuditEvent.agent.altId
                    public ElementDefinitionInfo AltId;                                                                                     // MakerGen.cs:216
                    // 14. AuditEvent.agent.name
                    public ElementDefinitionInfo Name;                                                                                      // MakerGen.cs:216
                    // 15. AuditEvent.agent.requestor
                    public ElementDefinitionInfo Requestor;                                                                                 // MakerGen.cs:216
                    // 16. AuditEvent.agent.location
                    public ElementDefinitionInfo Location;                                                                                  // MakerGen.cs:216
                    // 17. AuditEvent.agent.policy
                    public ElementDefinitionInfo Policy;                                                                                    // MakerGen.cs:216
                    // 18. AuditEvent.agent.media
                    public ElementDefinitionInfo Media;                                                                                     // MakerGen.cs:216
                    // 19. AuditEvent.agent.network
                    public ElementDefinitionInfo Network;                                                                                   // MakerGen.cs:216
                    // 22. AuditEvent.agent.purposeOfUse
                    public ElementDefinitionInfo PurposeOfUse;                                                                              // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                    public Type_Agent_Elements()                                                                                            // MakerGen.cs:392
                    {                                                                                                                       // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:231
                            // 10. AuditEvent.agent.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Type",                                                                                              // MakerGen.cs:235
                                Path= "AuditEvent.agent.type",                                                                              // MakerGen.cs:236
                                Id = "AuditEvent.agent.type",                                                                               // MakerGen.cs:237
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
                            // 11. AuditEvent.agent.role
                            this.Role = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Role",                                                                                              // MakerGen.cs:235
                                Path= "AuditEvent.agent.role",                                                                              // MakerGen.cs:236
                                Id = "AuditEvent.agent.role",                                                                               // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 12. AuditEvent.agent.who
                            this.Who = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Who",                                                                                               // MakerGen.cs:235
                                Path= "AuditEvent.agent.who",                                                                               // MakerGen.cs:236
                                Id = "AuditEvent.agent.who",                                                                                // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                     // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/Practitioner",                                         // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/Organization",                                         // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/Device",                                               // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/Patient",                                              // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/RelatedPerson"                                         // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 13. AuditEvent.agent.altId
                            this.AltId = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "AltId",                                                                                             // MakerGen.cs:235
                                Path= "AuditEvent.agent.altId",                                                                             // MakerGen.cs:236
                                Id = "AuditEvent.agent.altId",                                                                              // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 14. AuditEvent.agent.name
                            this.Name = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Name",                                                                                              // MakerGen.cs:235
                                Path= "AuditEvent.agent.name",                                                                              // MakerGen.cs:236
                                Id = "AuditEvent.agent.name",                                                                               // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 15. AuditEvent.agent.requestor
                            this.Requestor = new ElementDefinitionInfo                                                                      // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Requestor",                                                                                         // MakerGen.cs:235
                                Path= "AuditEvent.agent.requestor",                                                                         // MakerGen.cs:236
                                Id = "AuditEvent.agent.requestor",                                                                          // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Boolean                                                             // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 16. AuditEvent.agent.location
                            this.Location = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Location",                                                                                          // MakerGen.cs:235
                                Path= "AuditEvent.agent.location",                                                                          // MakerGen.cs:236
                                Id = "AuditEvent.agent.location",                                                                           // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Location"                                              // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 17. AuditEvent.agent.policy
                            this.Policy = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Policy",                                                                                            // MakerGen.cs:235
                                Path= "AuditEvent.agent.policy",                                                                            // MakerGen.cs:236
                                Id = "AuditEvent.agent.policy",                                                                             // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Uri                                                                 // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 18. AuditEvent.agent.media
                            this.Media = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Media",                                                                                             // MakerGen.cs:235
                                Path= "AuditEvent.agent.media",                                                                             // MakerGen.cs:236
                                Id = "AuditEvent.agent.media",                                                                              // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Coding                                                                // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 19. AuditEvent.agent.network
                            this.Network = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Network",                                                                                           // MakerGen.cs:235
                                Path= "AuditEvent.agent.network",                                                                           // MakerGen.cs:236
                                Id = "AuditEvent.agent.network",                                                                            // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new Type_Network                                                                                        // MakerGen.cs:259
                                    {                                                                                                       // MakerGen.cs:260
                                    }                                                                                                       // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 22. AuditEvent.agent.purposeOfUse
                            this.PurposeOfUse = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "PurposeOfUse",                                                                                      // MakerGen.cs:235
                                Path= "AuditEvent.agent.purposeOfUse",                                                                      // MakerGen.cs:236
                                Id = "AuditEvent.agent.purposeOfUse",                                                                       // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:398
                    {                                                                                                                       // MakerGen.cs:399
                        base.Write(sDef);                                                                                                   // MakerGen.cs:400
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:220
                        Role.Write(sDef);                                                                                                   // MakerGen.cs:220
                        Who.Write(sDef);                                                                                                    // MakerGen.cs:220
                        AltId.Write(sDef);                                                                                                  // MakerGen.cs:220
                        Name.Write(sDef);                                                                                                   // MakerGen.cs:220
                        Requestor.Write(sDef);                                                                                              // MakerGen.cs:220
                        Location.Write(sDef);                                                                                               // MakerGen.cs:220
                        Policy.Write(sDef);                                                                                                 // MakerGen.cs:220
                        Media.Write(sDef);                                                                                                  // MakerGen.cs:220
                        Network.Write(sDef);                                                                                                // MakerGen.cs:220
                        PurposeOfUse.Write(sDef);                                                                                           // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:402
                }                                                                                                                           // MakerGen.cs:404
                public Type_Agent_Elements Elements                                                                                         // MakerGen.cs:406
                {                                                                                                                           // MakerGen.cs:407
                    get                                                                                                                     // MakerGen.cs:408
                    {                                                                                                                       // MakerGen.cs:409
                        if (this.elements == null)                                                                                          // MakerGen.cs:410
                            this.elements = new Type_Agent_Elements();                                                                      // MakerGen.cs:411
                        return this.elements;                                                                                               // MakerGen.cs:412
                    }                                                                                                                       // MakerGen.cs:413
                }                                                                                                                           // MakerGen.cs:414
                Type_Agent_Elements elements;                                                                                               // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                public Type_Agent()                                                                                                         // MakerGen.cs:418
                {                                                                                                                           // MakerGen.cs:419
                }                                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:424
                {                                                                                                                           // MakerGen.cs:425
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:426
                    {                                                                                                                       // MakerGen.cs:427
                        Path = "AuditEvent.agent",                                                                                          // MakerGen.cs:428
                        ElementId = "AuditEvent.agent"                                                                                      // MakerGen.cs:429
                    });                                                                                                                     // MakerGen.cs:430
                    if (this.elements != null)                                                                                              // MakerGen.cs:431
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:432
                }                                                                                                                           // MakerGen.cs:433
            }                                                                                                                               // MakerGen.cs:434
            // 23. AuditEvent.source
            public class Type_Source : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                public class Type_Source_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                             // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    // 24. AuditEvent.source.site
                    public ElementDefinitionInfo Site;                                                                                      // MakerGen.cs:216
                    // 25. AuditEvent.source.observer
                    public ElementDefinitionInfo Observer;                                                                                  // MakerGen.cs:216
                    // 26. AuditEvent.source.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                    public Type_Source_Elements()                                                                                           // MakerGen.cs:392
                    {                                                                                                                       // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:231
                            // 24. AuditEvent.source.site
                            this.Site = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Site",                                                                                              // MakerGen.cs:235
                                Path= "AuditEvent.source.site",                                                                             // MakerGen.cs:236
                                Id = "AuditEvent.source.site",                                                                              // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 25. AuditEvent.source.observer
                            this.Observer = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Observer",                                                                                          // MakerGen.cs:235
                                Path= "AuditEvent.source.observer",                                                                         // MakerGen.cs:236
                                Id = "AuditEvent.source.observer",                                                                          // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                     // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/Practitioner",                                         // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/Organization",                                         // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/Device",                                               // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/Patient",                                              // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/RelatedPerson"                                         // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 26. AuditEvent.source.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Type",                                                                                              // MakerGen.cs:235
                                Path= "AuditEvent.source.type",                                                                             // MakerGen.cs:236
                                Id = "AuditEvent.source.type",                                                                              // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Coding                                                                // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:398
                    {                                                                                                                       // MakerGen.cs:399
                        base.Write(sDef);                                                                                                   // MakerGen.cs:400
                        Site.Write(sDef);                                                                                                   // MakerGen.cs:220
                        Observer.Write(sDef);                                                                                               // MakerGen.cs:220
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:402
                }                                                                                                                           // MakerGen.cs:404
                public Type_Source_Elements Elements                                                                                        // MakerGen.cs:406
                {                                                                                                                           // MakerGen.cs:407
                    get                                                                                                                     // MakerGen.cs:408
                    {                                                                                                                       // MakerGen.cs:409
                        if (this.elements == null)                                                                                          // MakerGen.cs:410
                            this.elements = new Type_Source_Elements();                                                                     // MakerGen.cs:411
                        return this.elements;                                                                                               // MakerGen.cs:412
                    }                                                                                                                       // MakerGen.cs:413
                }                                                                                                                           // MakerGen.cs:414
                Type_Source_Elements elements;                                                                                              // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                public Type_Source()                                                                                                        // MakerGen.cs:418
                {                                                                                                                           // MakerGen.cs:419
                }                                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:424
                {                                                                                                                           // MakerGen.cs:425
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:426
                    {                                                                                                                       // MakerGen.cs:427
                        Path = "AuditEvent.source",                                                                                         // MakerGen.cs:428
                        ElementId = "AuditEvent.source"                                                                                     // MakerGen.cs:429
                    });                                                                                                                     // MakerGen.cs:430
                    if (this.elements != null)                                                                                              // MakerGen.cs:431
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:432
                }                                                                                                                           // MakerGen.cs:433
            }                                                                                                                               // MakerGen.cs:434
            // 27. AuditEvent.entity
            public class Type_Entity : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                public class Type_Entity_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                             // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    // 36. AuditEvent.entity.detail
                    public class Type_Detail : FhirKhit.Maker.Common.Complex.ComplexBase                                                    // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        public class Type_Detail_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                     // MakerGen.cs:386
                        {                                                                                                                   // MakerGen.cs:387
                            // 37. AuditEvent.entity.detail.type
                            public ElementDefinitionInfo Type;                                                                              // MakerGen.cs:216
                            // 38. AuditEvent.entity.detail.value[x]
                            public ElementDefinitionInfo Value;                                                                             // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                            public Type_Detail_Elements()                                                                                   // MakerGen.cs:392
                            {                                                                                                               // MakerGen.cs:393
                                {                                                                                                           // MakerGen.cs:231
                                    // 37. AuditEvent.entity.detail.type
                                    this.Type = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Type",                                                                                      // MakerGen.cs:235
                                        Path= "AuditEvent.entity.detail.type",                                                              // MakerGen.cs:236
                                        Id = "AuditEvent.entity.detail.type",                                                               // MakerGen.cs:237
                                        Min = 1,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 38. AuditEvent.entity.detail.value[x]
                                    this.Value = new ElementDefinitionInfo                                                                  // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Value",                                                                                     // MakerGen.cs:235
                                        Path= "AuditEvent.entity.detail.value[x]",                                                          // MakerGen.cs:236
                                        Id = "AuditEvent.entity.detail.value[x]",                                                           // MakerGen.cs:237
                                        Min = 1,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            },                                                                                              // MakerGen.cs:304
                                            new FhirKhit.Maker.Common.Primitive.Base64Binary                                                // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                            }                                                                                                               // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:398
                            {                                                                                                               // MakerGen.cs:399
                                base.Write(sDef);                                                                                           // MakerGen.cs:400
                                Type.Write(sDef);                                                                                           // MakerGen.cs:220
                                Value.Write(sDef);                                                                                          // MakerGen.cs:220
                            }                                                                                                               // MakerGen.cs:402
                        }                                                                                                                   // MakerGen.cs:404
                        public Type_Detail_Elements Elements                                                                                // MakerGen.cs:406
                        {                                                                                                                   // MakerGen.cs:407
                            get                                                                                                             // MakerGen.cs:408
                            {                                                                                                               // MakerGen.cs:409
                                if (this.elements == null)                                                                                  // MakerGen.cs:410
                                    this.elements = new Type_Detail_Elements();                                                             // MakerGen.cs:411
                                return this.elements;                                                                                       // MakerGen.cs:412
                            }                                                                                                               // MakerGen.cs:413
                        }                                                                                                                   // MakerGen.cs:414
                        Type_Detail_Elements elements;                                                                                      // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                        public Type_Detail()                                                                                                // MakerGen.cs:418
                        {                                                                                                                   // MakerGen.cs:419
                        }                                                                                                                   // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:424
                        {                                                                                                                   // MakerGen.cs:425
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:426
                            {                                                                                                               // MakerGen.cs:427
                                Path = "AuditEvent.entity.detail",                                                                          // MakerGen.cs:428
                                ElementId = "AuditEvent.entity.detail"                                                                      // MakerGen.cs:429
                            });                                                                                                             // MakerGen.cs:430
                            if (this.elements != null)                                                                                      // MakerGen.cs:431
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:432
                        }                                                                                                                   // MakerGen.cs:433
                    }                                                                                                                       // MakerGen.cs:434
                    // 28. AuditEvent.entity.what
                    public ElementDefinitionInfo What;                                                                                      // MakerGen.cs:216
                    // 29. AuditEvent.entity.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:216
                    // 30. AuditEvent.entity.role
                    public ElementDefinitionInfo Role;                                                                                      // MakerGen.cs:216
                    // 31. AuditEvent.entity.lifecycle
                    public ElementDefinitionInfo Lifecycle;                                                                                 // MakerGen.cs:216
                    // 32. AuditEvent.entity.securityLabel
                    public ElementDefinitionInfo SecurityLabel;                                                                             // MakerGen.cs:216
                    // 33. AuditEvent.entity.name
                    public ElementDefinitionInfo Name;                                                                                      // MakerGen.cs:216
                    // 34. AuditEvent.entity.description
                    public ElementDefinitionInfo Description;                                                                               // MakerGen.cs:216
                    // 35. AuditEvent.entity.query
                    public ElementDefinitionInfo Query;                                                                                     // MakerGen.cs:216
                    // 36. AuditEvent.entity.detail
                    public ElementDefinitionInfo Detail;                                                                                    // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                    public Type_Entity_Elements()                                                                                           // MakerGen.cs:392
                    {                                                                                                                       // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:231
                            // 28. AuditEvent.entity.what
                            this.What = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "What",                                                                                              // MakerGen.cs:235
                                Path= "AuditEvent.entity.what",                                                                             // MakerGen.cs:236
                                Id = "AuditEvent.entity.what",                                                                              // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Resource"                                              // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 29. AuditEvent.entity.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Type",                                                                                              // MakerGen.cs:235
                                Path= "AuditEvent.entity.type",                                                                             // MakerGen.cs:236
                                Id = "AuditEvent.entity.type",                                                                              // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Coding                                                                // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 30. AuditEvent.entity.role
                            this.Role = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Role",                                                                                              // MakerGen.cs:235
                                Path= "AuditEvent.entity.role",                                                                             // MakerGen.cs:236
                                Id = "AuditEvent.entity.role",                                                                              // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Coding                                                                // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 31. AuditEvent.entity.lifecycle
                            this.Lifecycle = new ElementDefinitionInfo                                                                      // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Lifecycle",                                                                                         // MakerGen.cs:235
                                Path= "AuditEvent.entity.lifecycle",                                                                        // MakerGen.cs:236
                                Id = "AuditEvent.entity.lifecycle",                                                                         // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Coding                                                                // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 32. AuditEvent.entity.securityLabel
                            this.SecurityLabel = new ElementDefinitionInfo                                                                  // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "SecurityLabel",                                                                                     // MakerGen.cs:235
                                Path= "AuditEvent.entity.securityLabel",                                                                    // MakerGen.cs:236
                                Id = "AuditEvent.entity.securityLabel",                                                                     // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Coding                                                                // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 33. AuditEvent.entity.name
                            this.Name = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Name",                                                                                              // MakerGen.cs:235
                                Path= "AuditEvent.entity.name",                                                                             // MakerGen.cs:236
                                Id = "AuditEvent.entity.name",                                                                              // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 34. AuditEvent.entity.description
                            this.Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Description",                                                                                       // MakerGen.cs:235
                                Path= "AuditEvent.entity.description",                                                                      // MakerGen.cs:236
                                Id = "AuditEvent.entity.description",                                                                       // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 35. AuditEvent.entity.query
                            this.Query = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Query",                                                                                             // MakerGen.cs:235
                                Path= "AuditEvent.entity.query",                                                                            // MakerGen.cs:236
                                Id = "AuditEvent.entity.query",                                                                             // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Base64Binary                                                        // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 36. AuditEvent.entity.detail
                            this.Detail = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Detail",                                                                                            // MakerGen.cs:235
                                Path= "AuditEvent.entity.detail",                                                                           // MakerGen.cs:236
                                Id = "AuditEvent.entity.detail",                                                                            // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new Type_Detail                                                                                         // MakerGen.cs:259
                                    {                                                                                                       // MakerGen.cs:260
                                    }                                                                                                       // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:398
                    {                                                                                                                       // MakerGen.cs:399
                        base.Write(sDef);                                                                                                   // MakerGen.cs:400
                        What.Write(sDef);                                                                                                   // MakerGen.cs:220
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:220
                        Role.Write(sDef);                                                                                                   // MakerGen.cs:220
                        Lifecycle.Write(sDef);                                                                                              // MakerGen.cs:220
                        SecurityLabel.Write(sDef);                                                                                          // MakerGen.cs:220
                        Name.Write(sDef);                                                                                                   // MakerGen.cs:220
                        Description.Write(sDef);                                                                                            // MakerGen.cs:220
                        Query.Write(sDef);                                                                                                  // MakerGen.cs:220
                        Detail.Write(sDef);                                                                                                 // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:402
                }                                                                                                                           // MakerGen.cs:404
                public Type_Entity_Elements Elements                                                                                        // MakerGen.cs:406
                {                                                                                                                           // MakerGen.cs:407
                    get                                                                                                                     // MakerGen.cs:408
                    {                                                                                                                       // MakerGen.cs:409
                        if (this.elements == null)                                                                                          // MakerGen.cs:410
                            this.elements = new Type_Entity_Elements();                                                                     // MakerGen.cs:411
                        return this.elements;                                                                                               // MakerGen.cs:412
                    }                                                                                                                       // MakerGen.cs:413
                }                                                                                                                           // MakerGen.cs:414
                Type_Entity_Elements elements;                                                                                              // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                public Type_Entity()                                                                                                        // MakerGen.cs:418
                {                                                                                                                           // MakerGen.cs:419
                }                                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:424
                {                                                                                                                           // MakerGen.cs:425
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:426
                    {                                                                                                                       // MakerGen.cs:427
                        Path = "AuditEvent.entity",                                                                                         // MakerGen.cs:428
                        ElementId = "AuditEvent.entity"                                                                                     // MakerGen.cs:429
                    });                                                                                                                     // MakerGen.cs:430
                    if (this.elements != null)                                                                                              // MakerGen.cs:431
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:432
                }                                                                                                                           // MakerGen.cs:433
            }                                                                                                                               // MakerGen.cs:434
            // 1. AuditEvent.type
            public ElementDefinitionInfo Type;                                                                                              // MakerGen.cs:216
            // 2. AuditEvent.subtype
            public ElementDefinitionInfo Subtype;                                                                                           // MakerGen.cs:216
            // 3. AuditEvent.action
            public ElementDefinitionInfo Action;                                                                                            // MakerGen.cs:216
            // 4. AuditEvent.period
            public ElementDefinitionInfo Period;                                                                                            // MakerGen.cs:216
            // 5. AuditEvent.recorded
            public ElementDefinitionInfo Recorded;                                                                                          // MakerGen.cs:216
            // 6. AuditEvent.outcome
            public ElementDefinitionInfo Outcome;                                                                                           // MakerGen.cs:216
            // 7. AuditEvent.outcomeDesc
            public ElementDefinitionInfo OutcomeDesc;                                                                                       // MakerGen.cs:216
            // 8. AuditEvent.purposeOfEvent
            public ElementDefinitionInfo PurposeOfEvent;                                                                                    // MakerGen.cs:216
            // 9. AuditEvent.agent
            public ElementDefinitionInfo Agent;                                                                                             // MakerGen.cs:216
            // 23. AuditEvent.source
            public ElementDefinitionInfo Source;                                                                                            // MakerGen.cs:216
            // 27. AuditEvent.entity
            public ElementDefinitionInfo Entity;                                                                                            // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
            public AuditEvent_Elements()                                                                                                    // MakerGen.cs:392
            {                                                                                                                               // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:231
                    // 1. AuditEvent.type
                    this.Type = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Type",                                                                                                      // MakerGen.cs:235
                        Path= "AuditEvent.type",                                                                                            // MakerGen.cs:236
                        Id = "AuditEvent.type",                                                                                             // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Coding                                                                        // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 2. AuditEvent.subtype
                    this.Subtype = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Subtype",                                                                                                   // MakerGen.cs:235
                        Path= "AuditEvent.subtype",                                                                                         // MakerGen.cs:236
                        Id = "AuditEvent.subtype",                                                                                          // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Coding                                                                        // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 3. AuditEvent.action
                    this.Action = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Action",                                                                                                    // MakerGen.cs:235
                        Path= "AuditEvent.action",                                                                                          // MakerGen.cs:236
                        Id = "AuditEvent.action",                                                                                           // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
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
                    // 4. AuditEvent.period
                    this.Period = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Period",                                                                                                    // MakerGen.cs:235
                        Path= "AuditEvent.period",                                                                                          // MakerGen.cs:236
                        Id = "AuditEvent.period",                                                                                           // MakerGen.cs:237
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
                    // 5. AuditEvent.recorded
                    this.Recorded = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Recorded",                                                                                                  // MakerGen.cs:235
                        Path= "AuditEvent.recorded",                                                                                        // MakerGen.cs:236
                        Id = "AuditEvent.recorded",                                                                                         // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Instant                                                                     // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 6. AuditEvent.outcome
                    this.Outcome = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Outcome",                                                                                                   // MakerGen.cs:235
                        Path= "AuditEvent.outcome",                                                                                         // MakerGen.cs:236
                        Id = "AuditEvent.outcome",                                                                                          // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
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
                    // 7. AuditEvent.outcomeDesc
                    this.OutcomeDesc = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "OutcomeDesc",                                                                                               // MakerGen.cs:235
                        Path= "AuditEvent.outcomeDesc",                                                                                     // MakerGen.cs:236
                        Id = "AuditEvent.outcomeDesc",                                                                                      // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 8. AuditEvent.purposeOfEvent
                    this.PurposeOfEvent = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "PurposeOfEvent",                                                                                            // MakerGen.cs:235
                        Path= "AuditEvent.purposeOfEvent",                                                                                  // MakerGen.cs:236
                        Id = "AuditEvent.purposeOfEvent",                                                                                   // MakerGen.cs:237
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
                    // 9. AuditEvent.agent
                    this.Agent = new ElementDefinitionInfo                                                                                  // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Agent",                                                                                                     // MakerGen.cs:235
                        Path= "AuditEvent.agent",                                                                                           // MakerGen.cs:236
                        Id = "AuditEvent.agent",                                                                                            // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Agent                                                                                                  // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 23. AuditEvent.source
                    this.Source = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Source",                                                                                                    // MakerGen.cs:235
                        Path= "AuditEvent.source",                                                                                          // MakerGen.cs:236
                        Id = "AuditEvent.source",                                                                                           // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Source                                                                                                 // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 27. AuditEvent.entity
                    this.Entity = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Entity",                                                                                                    // MakerGen.cs:235
                        Path= "AuditEvent.entity",                                                                                          // MakerGen.cs:236
                        Id = "AuditEvent.entity",                                                                                           // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Entity                                                                                                 // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:398
            {                                                                                                                               // MakerGen.cs:399
                base.Write(sDef);                                                                                                           // MakerGen.cs:400
                Type.Write(sDef);                                                                                                           // MakerGen.cs:220
                Subtype.Write(sDef);                                                                                                        // MakerGen.cs:220
                Action.Write(sDef);                                                                                                         // MakerGen.cs:220
                Period.Write(sDef);                                                                                                         // MakerGen.cs:220
                Recorded.Write(sDef);                                                                                                       // MakerGen.cs:220
                Outcome.Write(sDef);                                                                                                        // MakerGen.cs:220
                OutcomeDesc.Write(sDef);                                                                                                    // MakerGen.cs:220
                PurposeOfEvent.Write(sDef);                                                                                                 // MakerGen.cs:220
                Agent.Write(sDef);                                                                                                          // MakerGen.cs:220
                Source.Write(sDef);                                                                                                         // MakerGen.cs:220
                Entity.Write(sDef);                                                                                                         // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:402
        }                                                                                                                                   // MakerGen.cs:404
        public AuditEvent_Elements Elements                                                                                                 // MakerGen.cs:406
        {                                                                                                                                   // MakerGen.cs:407
            get                                                                                                                             // MakerGen.cs:408
            {                                                                                                                               // MakerGen.cs:409
                if (this.elements == null)                                                                                                  // MakerGen.cs:410
                    this.elements = new AuditEvent_Elements();                                                                              // MakerGen.cs:411
                return this.elements;                                                                                                       // MakerGen.cs:412
            }                                                                                                                               // MakerGen.cs:413
        }                                                                                                                                   // MakerGen.cs:414
        AuditEvent_Elements elements;                                                                                                       // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
        public AuditEvent()                                                                                                                 // MakerGen.cs:418
        {                                                                                                                                   // MakerGen.cs:419
            this.Name = "AuditEvent";                                                                                                       // MakerGen.cs:492
            this.Uri = "http://hl7.org/fhir/StructureDefinition/AuditEvent";                                                                // MakerGen.cs:493
        }                                                                                                                                   // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:424
        {                                                                                                                                   // MakerGen.cs:425
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:426
            {                                                                                                                               // MakerGen.cs:427
                Path = "AuditEvent",                                                                                                        // MakerGen.cs:428
                ElementId = "AuditEvent"                                                                                                    // MakerGen.cs:429
            });                                                                                                                             // MakerGen.cs:430
            if (this.elements != null)                                                                                                      // MakerGen.cs:431
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:432
        }                                                                                                                                   // MakerGen.cs:433
    }                                                                                                                                       // MakerGen.cs:434
}                                                                                                                                           // MakerGen.cs:479
