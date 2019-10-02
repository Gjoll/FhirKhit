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
    #endregion
    /// <summary>
    /// Fhir resource 'AuditEvent'
    /// </summary>
    // 0. AuditEvent
    public class Resource_AuditEvent : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 9. AuditEvent.agent
        public class Type_Agent : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 19. AuditEvent.agent.network
            public class Type_Network : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 20. AuditEvent.agent.network.address
                public ElementDefinitionInfo Element_Address;
                // 21. AuditEvent.agent.network.type
                public ElementDefinitionInfo Element_Type;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "AuditEvent.agent.network",
                        ElementId = "AuditEvent.agent.network"
                    });
                    Element_Address.Write(sDef);
                    Element_Type.Write(sDef);
                }
                
                public Type_Network()
                {
                    {
                        // 20. AuditEvent.agent.network.address
                        this.Element_Address = new ElementDefinitionInfo
                        {
                            Name = "Element_Address",
                            Path= "AuditEvent.agent.network.address",
                            Id = "AuditEvent.agent.network.address",
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
                        // 21. AuditEvent.agent.network.type
                        this.Element_Type = new ElementDefinitionInfo
                        {
                            Name = "Element_Type",
                            Path= "AuditEvent.agent.network.type",
                            Id = "AuditEvent.agent.network.type",
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
                }
            }
            // 10. AuditEvent.agent.type
            public ElementDefinitionInfo Element_Type;
            // 11. AuditEvent.agent.role
            public ElementDefinitionInfo Element_Role;
            // 12. AuditEvent.agent.who
            public ElementDefinitionInfo Element_Who;
            // 13. AuditEvent.agent.altId
            public ElementDefinitionInfo Element_AltId;
            // 14. AuditEvent.agent.name
            public ElementDefinitionInfo Element_Name;
            // 15. AuditEvent.agent.requestor
            public ElementDefinitionInfo Element_Requestor;
            // 16. AuditEvent.agent.location
            public ElementDefinitionInfo Element_Location;
            // 17. AuditEvent.agent.policy
            public ElementDefinitionInfo Element_Policy;
            // 18. AuditEvent.agent.media
            public ElementDefinitionInfo Element_Media;
            // 19. AuditEvent.agent.network
            public ElementDefinitionInfo Element_Network;
            // 22. AuditEvent.agent.purposeOfUse
            public ElementDefinitionInfo Element_PurposeOfUse;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "AuditEvent.agent",
                    ElementId = "AuditEvent.agent"
                });
                Element_Type.Write(sDef);
                Element_Role.Write(sDef);
                Element_Who.Write(sDef);
                Element_AltId.Write(sDef);
                Element_Name.Write(sDef);
                Element_Requestor.Write(sDef);
                Element_Location.Write(sDef);
                Element_Policy.Write(sDef);
                Element_Media.Write(sDef);
                Element_Network.Write(sDef);
                Element_PurposeOfUse.Write(sDef);
            }
            
            public Type_Agent()
            {
                {
                    // 10. AuditEvent.agent.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "AuditEvent.agent.type",
                        Id = "AuditEvent.agent.type",
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
                    // 11. AuditEvent.agent.role
                    this.Element_Role = new ElementDefinitionInfo
                    {
                        Name = "Element_Role",
                        Path= "AuditEvent.agent.role",
                        Id = "AuditEvent.agent.role",
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
                    // 12. AuditEvent.agent.who
                    this.Element_Who = new ElementDefinitionInfo
                    {
                        Name = "Element_Who",
                        Path= "AuditEvent.agent.who",
                        Id = "AuditEvent.agent.who",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                    "http://hl7.org/fhir/StructureDefinition/Organization",
                                    "http://hl7.org/fhir/StructureDefinition/Device",
                                    "http://hl7.org/fhir/StructureDefinition/Patient",
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson"
                                }
                            }
                        }
                    };
                }
                {
                    // 13. AuditEvent.agent.altId
                    this.Element_AltId = new ElementDefinitionInfo
                    {
                        Name = "Element_AltId",
                        Path= "AuditEvent.agent.altId",
                        Id = "AuditEvent.agent.altId",
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
                    // 14. AuditEvent.agent.name
                    this.Element_Name = new ElementDefinitionInfo
                    {
                        Name = "Element_Name",
                        Path= "AuditEvent.agent.name",
                        Id = "AuditEvent.agent.name",
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
                    // 15. AuditEvent.agent.requestor
                    this.Element_Requestor = new ElementDefinitionInfo
                    {
                        Name = "Element_Requestor",
                        Path= "AuditEvent.agent.requestor",
                        Id = "AuditEvent.agent.requestor",
                        Min = 1,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Boolean
                            {
                            }
                        }
                    };
                }
                {
                    // 16. AuditEvent.agent.location
                    this.Element_Location = new ElementDefinitionInfo
                    {
                        Name = "Element_Location",
                        Path= "AuditEvent.agent.location",
                        Id = "AuditEvent.agent.location",
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
                    // 17. AuditEvent.agent.policy
                    this.Element_Policy = new ElementDefinitionInfo
                    {
                        Name = "Element_Policy",
                        Path= "AuditEvent.agent.policy",
                        Id = "AuditEvent.agent.policy",
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
                    // 18. AuditEvent.agent.media
                    this.Element_Media = new ElementDefinitionInfo
                    {
                        Name = "Element_Media",
                        Path= "AuditEvent.agent.media",
                        Id = "AuditEvent.agent.media",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Coding
                            {
                            }
                        }
                    };
                }
                {
                    // 19. AuditEvent.agent.network
                    this.Element_Network = new ElementDefinitionInfo
                    {
                        Name = "Element_Network",
                        Path= "AuditEvent.agent.network",
                        Id = "AuditEvent.agent.network",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new Type_Network
                            {
                            }
                        }
                    };
                }
                {
                    // 22. AuditEvent.agent.purposeOfUse
                    this.Element_PurposeOfUse = new ElementDefinitionInfo
                    {
                        Name = "Element_PurposeOfUse",
                        Path= "AuditEvent.agent.purposeOfUse",
                        Id = "AuditEvent.agent.purposeOfUse",
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
            }
        }
        // 23. AuditEvent.source
        public class Type_Source : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 24. AuditEvent.source.site
            public ElementDefinitionInfo Element_Site;
            // 25. AuditEvent.source.observer
            public ElementDefinitionInfo Element_Observer;
            // 26. AuditEvent.source.type
            public ElementDefinitionInfo Element_Type;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "AuditEvent.source",
                    ElementId = "AuditEvent.source"
                });
                Element_Site.Write(sDef);
                Element_Observer.Write(sDef);
                Element_Type.Write(sDef);
            }
            
            public Type_Source()
            {
                {
                    // 24. AuditEvent.source.site
                    this.Element_Site = new ElementDefinitionInfo
                    {
                        Name = "Element_Site",
                        Path= "AuditEvent.source.site",
                        Id = "AuditEvent.source.site",
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
                    // 25. AuditEvent.source.observer
                    this.Element_Observer = new ElementDefinitionInfo
                    {
                        Name = "Element_Observer",
                        Path= "AuditEvent.source.observer",
                        Id = "AuditEvent.source.observer",
                        Min = 1,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                    "http://hl7.org/fhir/StructureDefinition/Organization",
                                    "http://hl7.org/fhir/StructureDefinition/Device",
                                    "http://hl7.org/fhir/StructureDefinition/Patient",
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson"
                                }
                            }
                        }
                    };
                }
                {
                    // 26. AuditEvent.source.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "AuditEvent.source.type",
                        Id = "AuditEvent.source.type",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Coding
                            {
                            }
                        }
                    };
                }
            }
        }
        // 27. AuditEvent.entity
        public class Type_Entity : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 36. AuditEvent.entity.detail
            public class Type_Detail : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 37. AuditEvent.entity.detail.type
                public ElementDefinitionInfo Element_Type;
                // 38. AuditEvent.entity.detail.value[x]
                public ElementDefinitionInfo Element_Value;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "AuditEvent.entity.detail",
                        ElementId = "AuditEvent.entity.detail"
                    });
                    Element_Type.Write(sDef);
                    Element_Value.Write(sDef);
                }
                
                public Type_Detail()
                {
                    {
                        // 37. AuditEvent.entity.detail.type
                        this.Element_Type = new ElementDefinitionInfo
                        {
                            Name = "Element_Type",
                            Path= "AuditEvent.entity.detail.type",
                            Id = "AuditEvent.entity.detail.type",
                            Min = 1,
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
                        // 38. AuditEvent.entity.detail.value[x]
                        this.Element_Value = new ElementDefinitionInfo
                        {
                            Name = "Element_Value",
                            Path= "AuditEvent.entity.detail.value[x]",
                            Id = "AuditEvent.entity.detail.value[x]",
                            Min = 1,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_String
                                {
                                },
                                new FhirKhit.Maker.Common.Primitive.Primitive_Base64Binary
                                {
                                }
                            }
                        };
                    }
                }
            }
            // 28. AuditEvent.entity.what
            public ElementDefinitionInfo Element_What;
            // 29. AuditEvent.entity.type
            public ElementDefinitionInfo Element_Type;
            // 30. AuditEvent.entity.role
            public ElementDefinitionInfo Element_Role;
            // 31. AuditEvent.entity.lifecycle
            public ElementDefinitionInfo Element_Lifecycle;
            // 32. AuditEvent.entity.securityLabel
            public ElementDefinitionInfo Element_SecurityLabel;
            // 33. AuditEvent.entity.name
            public ElementDefinitionInfo Element_Name;
            // 34. AuditEvent.entity.description
            public ElementDefinitionInfo Element_Description;
            // 35. AuditEvent.entity.query
            public ElementDefinitionInfo Element_Query;
            // 36. AuditEvent.entity.detail
            public ElementDefinitionInfo Element_Detail;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "AuditEvent.entity",
                    ElementId = "AuditEvent.entity"
                });
                Element_What.Write(sDef);
                Element_Type.Write(sDef);
                Element_Role.Write(sDef);
                Element_Lifecycle.Write(sDef);
                Element_SecurityLabel.Write(sDef);
                Element_Name.Write(sDef);
                Element_Description.Write(sDef);
                Element_Query.Write(sDef);
                Element_Detail.Write(sDef);
            }
            
            public Type_Entity()
            {
                {
                    // 28. AuditEvent.entity.what
                    this.Element_What = new ElementDefinitionInfo
                    {
                        Name = "Element_What",
                        Path= "AuditEvent.entity.what",
                        Id = "AuditEvent.entity.what",
                        Min = 0,
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
                    // 29. AuditEvent.entity.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "AuditEvent.entity.type",
                        Id = "AuditEvent.entity.type",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Coding
                            {
                            }
                        }
                    };
                }
                {
                    // 30. AuditEvent.entity.role
                    this.Element_Role = new ElementDefinitionInfo
                    {
                        Name = "Element_Role",
                        Path= "AuditEvent.entity.role",
                        Id = "AuditEvent.entity.role",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Coding
                            {
                            }
                        }
                    };
                }
                {
                    // 31. AuditEvent.entity.lifecycle
                    this.Element_Lifecycle = new ElementDefinitionInfo
                    {
                        Name = "Element_Lifecycle",
                        Path= "AuditEvent.entity.lifecycle",
                        Id = "AuditEvent.entity.lifecycle",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Coding
                            {
                            }
                        }
                    };
                }
                {
                    // 32. AuditEvent.entity.securityLabel
                    this.Element_SecurityLabel = new ElementDefinitionInfo
                    {
                        Name = "Element_SecurityLabel",
                        Path= "AuditEvent.entity.securityLabel",
                        Id = "AuditEvent.entity.securityLabel",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Coding
                            {
                            }
                        }
                    };
                }
                {
                    // 33. AuditEvent.entity.name
                    this.Element_Name = new ElementDefinitionInfo
                    {
                        Name = "Element_Name",
                        Path= "AuditEvent.entity.name",
                        Id = "AuditEvent.entity.name",
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
                    // 34. AuditEvent.entity.description
                    this.Element_Description = new ElementDefinitionInfo
                    {
                        Name = "Element_Description",
                        Path= "AuditEvent.entity.description",
                        Id = "AuditEvent.entity.description",
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
                    // 35. AuditEvent.entity.query
                    this.Element_Query = new ElementDefinitionInfo
                    {
                        Name = "Element_Query",
                        Path= "AuditEvent.entity.query",
                        Id = "AuditEvent.entity.query",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Base64Binary
                            {
                            }
                        }
                    };
                }
                {
                    // 36. AuditEvent.entity.detail
                    this.Element_Detail = new ElementDefinitionInfo
                    {
                        Name = "Element_Detail",
                        Path= "AuditEvent.entity.detail",
                        Id = "AuditEvent.entity.detail",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Detail
                            {
                            }
                        }
                    };
                }
            }
        }
        // 1. AuditEvent.type
        public ElementDefinitionInfo Element_Type;
        // 2. AuditEvent.subtype
        public ElementDefinitionInfo Element_Subtype;
        // 3. AuditEvent.action
        public ElementDefinitionInfo Element_Action;
        // 4. AuditEvent.period
        public ElementDefinitionInfo Element_Period;
        // 5. AuditEvent.recorded
        public ElementDefinitionInfo Element_Recorded;
        // 6. AuditEvent.outcome
        public ElementDefinitionInfo Element_Outcome;
        // 7. AuditEvent.outcomeDesc
        public ElementDefinitionInfo Element_OutcomeDesc;
        // 8. AuditEvent.purposeOfEvent
        public ElementDefinitionInfo Element_PurposeOfEvent;
        // 9. AuditEvent.agent
        public ElementDefinitionInfo Element_Agent;
        // 23. AuditEvent.source
        public ElementDefinitionInfo Element_Source;
        // 27. AuditEvent.entity
        public ElementDefinitionInfo Element_Entity;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "AuditEvent",
                ElementId = "AuditEvent"
            });
            Element_Type.Write(sDef);
            Element_Subtype.Write(sDef);
            Element_Action.Write(sDef);
            Element_Period.Write(sDef);
            Element_Recorded.Write(sDef);
            Element_Outcome.Write(sDef);
            Element_OutcomeDesc.Write(sDef);
            Element_PurposeOfEvent.Write(sDef);
            Element_Agent.Write(sDef);
            Element_Source.Write(sDef);
            Element_Entity.Write(sDef);
        }
        
        public Resource_AuditEvent()
        {
            {
                // 1. AuditEvent.type
                this.Element_Type = new ElementDefinitionInfo
                {
                    Name = "Element_Type",
                    Path= "AuditEvent.type",
                    Id = "AuditEvent.type",
                    Min = 1,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Coding
                        {
                        }
                    }
                };
            }
            {
                // 2. AuditEvent.subtype
                this.Element_Subtype = new ElementDefinitionInfo
                {
                    Name = "Element_Subtype",
                    Path= "AuditEvent.subtype",
                    Id = "AuditEvent.subtype",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Coding
                        {
                        }
                    }
                };
            }
            {
                // 3. AuditEvent.action
                this.Element_Action = new ElementDefinitionInfo
                {
                    Name = "Element_Action",
                    Path= "AuditEvent.action",
                    Id = "AuditEvent.action",
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
                // 4. AuditEvent.period
                this.Element_Period = new ElementDefinitionInfo
                {
                    Name = "Element_Period",
                    Path= "AuditEvent.period",
                    Id = "AuditEvent.period",
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
                // 5. AuditEvent.recorded
                this.Element_Recorded = new ElementDefinitionInfo
                {
                    Name = "Element_Recorded",
                    Path= "AuditEvent.recorded",
                    Id = "AuditEvent.recorded",
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
                // 6. AuditEvent.outcome
                this.Element_Outcome = new ElementDefinitionInfo
                {
                    Name = "Element_Outcome",
                    Path= "AuditEvent.outcome",
                    Id = "AuditEvent.outcome",
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
                // 7. AuditEvent.outcomeDesc
                this.Element_OutcomeDesc = new ElementDefinitionInfo
                {
                    Name = "Element_OutcomeDesc",
                    Path= "AuditEvent.outcomeDesc",
                    Id = "AuditEvent.outcomeDesc",
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
                // 8. AuditEvent.purposeOfEvent
                this.Element_PurposeOfEvent = new ElementDefinitionInfo
                {
                    Name = "Element_PurposeOfEvent",
                    Path= "AuditEvent.purposeOfEvent",
                    Id = "AuditEvent.purposeOfEvent",
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
                // 9. AuditEvent.agent
                this.Element_Agent = new ElementDefinitionInfo
                {
                    Name = "Element_Agent",
                    Path= "AuditEvent.agent",
                    Id = "AuditEvent.agent",
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
                // 23. AuditEvent.source
                this.Element_Source = new ElementDefinitionInfo
                {
                    Name = "Element_Source",
                    Path= "AuditEvent.source",
                    Id = "AuditEvent.source",
                    Min = 1,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new Type_Source
                        {
                        }
                    }
                };
            }
            {
                // 27. AuditEvent.entity
                this.Element_Entity = new ElementDefinitionInfo
                {
                    Name = "Element_Entity",
                    Path= "AuditEvent.entity",
                    Id = "AuditEvent.entity",
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
            this.Name = "AuditEvent";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/AuditEvent";
        }
    }
}
