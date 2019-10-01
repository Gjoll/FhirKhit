using System;                                                                                                                               // MakerGen.cs:449
using System.Diagnostics;                                                                                                                   // MakerGen.cs:450
using System.IO;                                                                                                                            // MakerGen.cs:451
using System.Linq;                                                                                                                          // MakerGen.cs:452
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:453
                                                                                                                                            // MakerGen.cs:454
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:455
{                                                                                                                                           // MakerGen.cs:456
    #region Json                                                                                                                            // MakerGen.cs:457
    #if NEVER                                                                                                                               // MakerGen.cs:458
    {
      "resourceType": "StructureDefinition",
      "id": "CommunicationRequest",
      "url": "http://hl7.org/fhir/StructureDefinition/CommunicationRequest",
      "version": "4.0.0",
      "name": "CommunicationRequest",
      "status": "draft",
      "publisher": "Health Level Seven International (Patient Care)",
      "description": "A request to convey information; e.g. the CDS system proposes that an alert be sent to a responsible provider, the CDS system proposes that the public health agency be notified about a reportable condition.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "CommunicationRequest",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "CommunicationRequest",
            "path": "CommunicationRequest",
            "short": "A request for information to be sent to a receiver",
            "definition": "A request to convey information; e.g. the CDS system proposes that an alert be sent to a responsible provider, the CDS system proposes that the public health agency be notified about a reportable condition.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "CommunicationRequest.identifier",
            "path": "CommunicationRequest.identifier",
            "short": "Unique identifier",
            "definition": "Business identifiers assigned to this communication request by the performer or other systems which remain constant as the resource is updated and propagates from server to server.",
            "comment": "This is a business identifier, not a resource identifier (see [discussion](resource.html#identifiers)).  It is best practice for the identifier to only appear on a single resource instance, however business practices may occasionally dictate that multiple resource instances with the same identifier can exist - possibly even with different resource types.  For example, multiple Patient and a Person resource instance might share the same social insurance number.",
            "requirements": "Allows identification of the communication request as it is known by various participating systems and in a way that remains consistent across servers.",
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
            "id": "CommunicationRequest.basedOn",
            "path": "CommunicationRequest.basedOn",
            "short": "Fulfills plan or proposal",
            "definition": "A plan or proposal that is fulfilled in whole or in part by this request.",
            "requirements": "Allows tracing of authorization for the request and tracking whether proposals/recommendations were acted upon.",
            "alias": [
              "fulfills"
            ],
            "min": 0,
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
            "id": "CommunicationRequest.replaces",
            "path": "CommunicationRequest.replaces",
            "short": "Request(s) replaced by this request",
            "definition": "Completed or terminated request(s) whose function is taken by this new request.",
            "comment": "The replacement could be because the initial request was immediately rejected (due to an issue) or because the previous request was completed, but the need for the action described by the request remains ongoing.",
            "requirements": "Allows tracing the continuation of a therapy or administrative process instantiated through multiple requests.",
            "alias": [
              "supersedes",
              "prior"
            ],
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/CommunicationRequest"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "CommunicationRequest.groupIdentifier",
            "path": "CommunicationRequest.groupIdentifier",
            "short": "Composite request this is part of",
            "definition": "A shared identifier common to all requests that were authorized more or less simultaneously by a single author, representing the identifier of the requisition, prescription or similar form.",
            "comment": "Requests are linked either by a \"basedOn\" relationship (i.e. one request is fulfilling another) or by having a common requisition.  Requests that are part of the same requisition are generally treated independently from the perspective of changing their state or maintaining them after initial creation.",
            "alias": [
              "grouperId"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Identifier"
              }
            ],
            "isSummary": true
          },
          {
            "id": "CommunicationRequest.status",
            "path": "CommunicationRequest.status",
            "short": "draft | active | suspended | cancelled | completed | entered-in-error | unknown",
            "definition": "The status of the proposal or order.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isModifier": true,
            "isModifierReason": "This element is labelled as a modifier because it is a status element that contains status entered-in-error which means that the resource should not be treated as valid.",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "CommunicationRequestStatus"
                }
              ],
              "strength": "required",
              "description": "The status of the communication request.",
              "valueSet": "http://hl7.org/fhir/ValueSet/request-status|4.0.0"
            }
          },
          {
            "id": "CommunicationRequest.statusReason",
            "path": "CommunicationRequest.statusReason",
            "short": "Reason for current status",
            "definition": "Captures the reason for the current state of the CommunicationRequest.",
            "comment": "This is generally only used for \"exception\" statuses such as \"suspended\" or \"cancelled\".  The reason why the CommunicationRequest was created at all is captured in reasonCode, not here.  [distinct reason codes for different statuses can be enforced using invariants if they are universal bindings].",
            "alias": [
              "Suspended Reason",
              "Cancelled Reason"
            ],
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
                  "valueString": "CommunicationRequestStatusReason"
                }
              ],
              "strength": "example",
              "description": "Codes identifying the reason for the current state of a request."
            }
          },
          {
            "id": "CommunicationRequest.category",
            "path": "CommunicationRequest.category",
            "short": "Message category",
            "definition": "The type of message to be sent such as alert, notification, reminder, instruction, etc.",
            "comment": "There may be multiple axes of categorization and one communication request may serve multiple purposes.",
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
                  "valueString": "CommunicationCategory"
                }
              ],
              "strength": "example",
              "description": "Codes for general categories of communications such as alerts, instruction, etc.",
              "valueSet": "http://hl7.org/fhir/ValueSet/communication-category"
            }
          },
          {
            "id": "CommunicationRequest.priority",
            "path": "CommunicationRequest.priority",
            "short": "Message urgency",
            "definition": "Characterizes how quickly the proposed act must be initiated. Includes concepts such as stat, urgent, routine.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "meaningWhenMissing": "If missing, this task should be performed with normal priority",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "CommunicationPriority"
                }
              ],
              "strength": "required",
              "description": "Codes indicating the relative importance of a communication request.",
              "valueSet": "http://hl7.org/fhir/ValueSet/request-priority|4.0.0"
            }
          },
          {
            "id": "CommunicationRequest.doNotPerform",
            "path": "CommunicationRequest.doNotPerform",
            "short": "True if request is prohibiting action",
            "definition": "If true indicates that the CommunicationRequest is asking for the specified action to *not* occur.",
            "comment": "The attributes provided with the request qualify what is not to be done.",
            "alias": [
              "prohibited"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ],
            "meaningWhenMissing": "If do not perform is not specified, the request is a positive request e.g. \"do perform\"",
            "isModifier": true,
            "isModifierReason": "If true this element negates the specified action. For Example,  instead of a request for a communication, it is a request for the communication to not occur.",
            "isSummary": true
          },
          {
            "id": "CommunicationRequest.medium",
            "path": "CommunicationRequest.medium",
            "short": "A channel of communication",
            "definition": "A channel that was used for this communication (e.g. email, fax).",
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
                  "valueString": "CommunicationMedium"
                }
              ],
              "strength": "example",
              "description": "Codes for communication mediums such as phone, fax, email, in person, etc.",
              "valueSet": "http://terminology.hl7.org/ValueSet/v3-ParticipationMode"
            }
          },
          {
            "id": "CommunicationRequest.subject",
            "path": "CommunicationRequest.subject",
            "short": "Focus of message",
            "definition": "The patient or group that is the focus of this communication request.",
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
            ]
          },
          {
            "id": "CommunicationRequest.about",
            "path": "CommunicationRequest.about",
            "short": "Resources that pertain to this communication request",
            "definition": "Other resources that pertain to this communication request and to which this communication request should be associated.",
            "comment": "Don't use CommunicationRequest.about element when a more specific element exists, such as basedOn, reasonReference, or replaces.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Resource"
                ]
              }
            ]
          },
          {
            "id": "CommunicationRequest.encounter",
            "path": "CommunicationRequest.encounter",
            "short": "Encounter created as part of",
            "definition": "The Encounter during which this CommunicationRequest was created or to which the creation of this record is tightly associated.",
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
            "id": "CommunicationRequest.payload",
            "path": "CommunicationRequest.payload",
            "short": "Message payload",
            "definition": "Text, attachment(s), or resource(s) to be communicated to the recipient.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "CommunicationRequest.payload.content[x]",
            "path": "CommunicationRequest.payload.content[x]",
            "short": "Message part content",
            "definition": "The communicated content (or for multi-part communications, one portion of the communication).",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "string"
              },
              {
                "code": "Attachment"
              },
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Resource"
                ]
              }
            ]
          },
          {
            "id": "CommunicationRequest.occurrence[x]",
            "path": "CommunicationRequest.occurrence[x]",
            "short": "When scheduled",
            "definition": "The time when this communication is to occur.",
            "alias": [
              "timing"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              },
              {
                "code": "Period"
              }
            ],
            "isSummary": true
          },
          {
            "id": "CommunicationRequest.authoredOn",
            "path": "CommunicationRequest.authoredOn",
            "short": "When request transitioned to being actionable",
            "definition": "For draft requests, indicates the date of initial creation.  For requests with other statuses, indicates the date of activation.",
            "alias": [
              "createdOn"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ],
            "isSummary": true
          },
          {
            "id": "CommunicationRequest.requester",
            "path": "CommunicationRequest.requester",
            "short": "Who/what is requesting service",
            "definition": "The device, individual, or organization who initiated the request and has responsibility for its activation.",
            "alias": [
              "author"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/Organization",
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                  "http://hl7.org/fhir/StructureDefinition/Device"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "CommunicationRequest.recipient",
            "path": "CommunicationRequest.recipient",
            "short": "Message recipient",
            "definition": "The entity (e.g. person, organization, clinical information system, device, group, or care team) which is the intended target of the communication.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Device",
                  "http://hl7.org/fhir/StructureDefinition/Organization",
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                  "http://hl7.org/fhir/StructureDefinition/Group",
                  "http://hl7.org/fhir/StructureDefinition/CareTeam",
                  "http://hl7.org/fhir/StructureDefinition/HealthcareService"
                ]
              }
            ]
          },
          {
            "id": "CommunicationRequest.sender",
            "path": "CommunicationRequest.sender",
            "short": "Message sender",
            "definition": "The entity (e.g. person, organization, clinical information system, or device) which is to be the source of the communication.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Device",
                  "http://hl7.org/fhir/StructureDefinition/Organization",
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                  "http://hl7.org/fhir/StructureDefinition/HealthcareService"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "CommunicationRequest.reasonCode",
            "path": "CommunicationRequest.reasonCode",
            "short": "Why is communication needed?",
            "definition": "Describes why the request is being made in coded or textual form.",
            "comment": "Textual reasons can be captured using reasonCode.text.",
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
                  "valueString": "CommunicationReason"
                }
              ],
              "strength": "example",
              "description": "Codes for describing reasons for the occurrence of a communication.",
              "valueSet": "http://terminology.hl7.org/ValueSet/v3-ActReason"
            }
          },
          {
            "id": "CommunicationRequest.reasonReference",
            "path": "CommunicationRequest.reasonReference",
            "short": "Why is communication needed?",
            "definition": "Indicates another resource whose existence justifies this request.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Condition",
                  "http://hl7.org/fhir/StructureDefinition/Observation",
                  "http://hl7.org/fhir/StructureDefinition/DiagnosticReport",
                  "http://hl7.org/fhir/StructureDefinition/DocumentReference"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "CommunicationRequest.note",
            "path": "CommunicationRequest.note",
            "short": "Comments made about communication request",
            "definition": "Comments made about the request by the requester, sender, recipient, subject or other participants.",
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
    #endregion                                                                                                                              // MakerGen.cs:461
    /// <summary>
    /// Fhir resource 'CommunicationRequest'
    /// </summary>
    // 0. CommunicationRequest
    public class CommunicationRequest : FhirKhit.Maker.Common.Resource.ResourceBase                                                         // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        public class CommunicationRequest_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                            // MakerGen.cs:385
        {                                                                                                                                   // MakerGen.cs:386
            // 14. CommunicationRequest.payload
            public class Type_Payload : FhirKhit.Maker.Common.Complex.ComplexBase                                                           // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                public class Type_Payload_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                            // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:386
                    // 15. CommunicationRequest.payload.content[x]
                    public ElementDefinitionInfo Content;                                                                                   // MakerGen.cs:216
                    public Type_Payload_Elements()                                                                                          // MakerGen.cs:407
                    {                                                                                                                       // MakerGen.cs:408
                        {                                                                                                                   // MakerGen.cs:231
                            // 15. CommunicationRequest.payload.content[x]
                            this.Content = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Content",                                                                                           // MakerGen.cs:235
                                Path= "CommunicationRequest.payload.content[x]",                                                            // MakerGen.cs:236
                                Id = "CommunicationRequest.payload.content[x]",                                                             // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    },                                                                                                      // MakerGen.cs:304
                                    new FhirKhit.Maker.Common.Complex.Attachment                                                            // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    },                                                                                                      // MakerGen.cs:360
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
                    }                                                                                                                       // MakerGen.cs:427
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:412
                    {                                                                                                                       // MakerGen.cs:413
                        base.Write(sDef);                                                                                                   // MakerGen.cs:414
                        Content.Write(sDef);                                                                                                // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:431
                }                                                                                                                           // MakerGen.cs:391
                public Type_Payload_Elements Elements { get; }                                                                              // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                public Type_Payload()                                                                                                       // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:395
                    this.Elements = new Type_Payload_Elements();                                                                            // MakerGen.cs:396
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:399
                {                                                                                                                           // MakerGen.cs:400
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:401
                }                                                                                                                           // MakerGen.cs:402
            }                                                                                                                               // MakerGen.cs:403
            // 1. CommunicationRequest.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:216
            // 2. CommunicationRequest.basedOn
            public ElementDefinitionInfo BasedOn;                                                                                           // MakerGen.cs:216
            // 3. CommunicationRequest.replaces
            public ElementDefinitionInfo Replaces;                                                                                          // MakerGen.cs:216
            // 4. CommunicationRequest.groupIdentifier
            public ElementDefinitionInfo GroupIdentifier;                                                                                   // MakerGen.cs:216
            // 5. CommunicationRequest.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:216
            // 6. CommunicationRequest.statusReason
            public ElementDefinitionInfo StatusReason;                                                                                      // MakerGen.cs:216
            // 7. CommunicationRequest.category
            public ElementDefinitionInfo Category;                                                                                          // MakerGen.cs:216
            // 8. CommunicationRequest.priority
            public ElementDefinitionInfo Priority;                                                                                          // MakerGen.cs:216
            // 9. CommunicationRequest.doNotPerform
            public ElementDefinitionInfo DoNotPerform;                                                                                      // MakerGen.cs:216
            // 10. CommunicationRequest.medium
            public ElementDefinitionInfo Medium;                                                                                            // MakerGen.cs:216
            // 11. CommunicationRequest.subject
            public ElementDefinitionInfo Subject;                                                                                           // MakerGen.cs:216
            // 12. CommunicationRequest.about
            public ElementDefinitionInfo About;                                                                                             // MakerGen.cs:216
            // 13. CommunicationRequest.encounter
            public ElementDefinitionInfo Encounter;                                                                                         // MakerGen.cs:216
            // 14. CommunicationRequest.payload
            public ElementDefinitionInfo Payload;                                                                                           // MakerGen.cs:216
            // 16. CommunicationRequest.occurrence[x]
            public ElementDefinitionInfo Occurrence;                                                                                        // MakerGen.cs:216
            // 17. CommunicationRequest.authoredOn
            public ElementDefinitionInfo AuthoredOn;                                                                                        // MakerGen.cs:216
            // 18. CommunicationRequest.requester
            public ElementDefinitionInfo Requester;                                                                                         // MakerGen.cs:216
            // 19. CommunicationRequest.recipient
            public ElementDefinitionInfo Recipient;                                                                                         // MakerGen.cs:216
            // 20. CommunicationRequest.sender
            public ElementDefinitionInfo Sender;                                                                                            // MakerGen.cs:216
            // 21. CommunicationRequest.reasonCode
            public ElementDefinitionInfo ReasonCode;                                                                                        // MakerGen.cs:216
            // 22. CommunicationRequest.reasonReference
            public ElementDefinitionInfo ReasonReference;                                                                                   // MakerGen.cs:216
            // 23. CommunicationRequest.note
            public ElementDefinitionInfo Note;                                                                                              // MakerGen.cs:216
            public CommunicationRequest_Elements()                                                                                          // MakerGen.cs:407
            {                                                                                                                               // MakerGen.cs:408
                {                                                                                                                           // MakerGen.cs:231
                    // 1. CommunicationRequest.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Identifier",                                                                                                // MakerGen.cs:235
                        Path= "CommunicationRequest.identifier",                                                                            // MakerGen.cs:236
                        Id = "CommunicationRequest.identifier",                                                                             // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 2. CommunicationRequest.basedOn
                    this.BasedOn = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "BasedOn",                                                                                                   // MakerGen.cs:235
                        Path= "CommunicationRequest.basedOn",                                                                               // MakerGen.cs:236
                        Id = "CommunicationRequest.basedOn",                                                                                // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Resource"                                                      // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 3. CommunicationRequest.replaces
                    this.Replaces = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Replaces",                                                                                                  // MakerGen.cs:235
                        Path= "CommunicationRequest.replaces",                                                                              // MakerGen.cs:236
                        Id = "CommunicationRequest.replaces",                                                                               // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/CommunicationRequest"                                          // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 4. CommunicationRequest.groupIdentifier
                    this.GroupIdentifier = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "GroupIdentifier",                                                                                           // MakerGen.cs:235
                        Path= "CommunicationRequest.groupIdentifier",                                                                       // MakerGen.cs:236
                        Id = "CommunicationRequest.groupIdentifier",                                                                        // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 5. CommunicationRequest.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Status",                                                                                                    // MakerGen.cs:235
                        Path= "CommunicationRequest.status",                                                                                // MakerGen.cs:236
                        Id = "CommunicationRequest.status",                                                                                 // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
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
                    // 6. CommunicationRequest.statusReason
                    this.StatusReason = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "StatusReason",                                                                                              // MakerGen.cs:235
                        Path= "CommunicationRequest.statusReason",                                                                          // MakerGen.cs:236
                        Id = "CommunicationRequest.statusReason",                                                                           // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 7. CommunicationRequest.category
                    this.Category = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Category",                                                                                                  // MakerGen.cs:235
                        Path= "CommunicationRequest.category",                                                                              // MakerGen.cs:236
                        Id = "CommunicationRequest.category",                                                                               // MakerGen.cs:237
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
                    // 8. CommunicationRequest.priority
                    this.Priority = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Priority",                                                                                                  // MakerGen.cs:235
                        Path= "CommunicationRequest.priority",                                                                              // MakerGen.cs:236
                        Id = "CommunicationRequest.priority",                                                                               // MakerGen.cs:237
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
                    // 9. CommunicationRequest.doNotPerform
                    this.DoNotPerform = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "DoNotPerform",                                                                                              // MakerGen.cs:235
                        Path= "CommunicationRequest.doNotPerform",                                                                          // MakerGen.cs:236
                        Id = "CommunicationRequest.doNotPerform",                                                                           // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Boolean                                                                     // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 10. CommunicationRequest.medium
                    this.Medium = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Medium",                                                                                                    // MakerGen.cs:235
                        Path= "CommunicationRequest.medium",                                                                                // MakerGen.cs:236
                        Id = "CommunicationRequest.medium",                                                                                 // MakerGen.cs:237
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
                    // 11. CommunicationRequest.subject
                    this.Subject = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Subject",                                                                                                   // MakerGen.cs:235
                        Path= "CommunicationRequest.subject",                                                                               // MakerGen.cs:236
                        Id = "CommunicationRequest.subject",                                                                                // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Group"                                                         // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 12. CommunicationRequest.about
                    this.About = new ElementDefinitionInfo                                                                                  // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "About",                                                                                                     // MakerGen.cs:235
                        Path= "CommunicationRequest.about",                                                                                 // MakerGen.cs:236
                        Id = "CommunicationRequest.about",                                                                                  // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Resource"                                                      // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 13. CommunicationRequest.encounter
                    this.Encounter = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Encounter",                                                                                                 // MakerGen.cs:235
                        Path= "CommunicationRequest.encounter",                                                                             // MakerGen.cs:236
                        Id = "CommunicationRequest.encounter",                                                                              // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Encounter"                                                     // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 14. CommunicationRequest.payload
                    this.Payload = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Payload",                                                                                                   // MakerGen.cs:235
                        Path= "CommunicationRequest.payload",                                                                               // MakerGen.cs:236
                        Id = "CommunicationRequest.payload",                                                                                // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Payload                                                                                                // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 16. CommunicationRequest.occurrence[x]
                    this.Occurrence = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Occurrence",                                                                                                // MakerGen.cs:235
                        Path= "CommunicationRequest.occurrence[x]",                                                                         // MakerGen.cs:236
                        Id = "CommunicationRequest.occurrence[x]",                                                                          // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            },                                                                                                              // MakerGen.cs:304
                            new FhirKhit.Maker.Common.Complex.Period                                                                        // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 17. CommunicationRequest.authoredOn
                    this.AuthoredOn = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "AuthoredOn",                                                                                                // MakerGen.cs:235
                        Path= "CommunicationRequest.authoredOn",                                                                            // MakerGen.cs:236
                        Id = "CommunicationRequest.authoredOn",                                                                             // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 18. CommunicationRequest.requester
                    this.Requester = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Requester",                                                                                                 // MakerGen.cs:235
                        Path= "CommunicationRequest.requester",                                                                             // MakerGen.cs:236
                        Id = "CommunicationRequest.requester",                                                                              // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Organization",                                                 // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson",                                                // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Device"                                                        // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 19. CommunicationRequest.recipient
                    this.Recipient = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Recipient",                                                                                                 // MakerGen.cs:235
                        Path= "CommunicationRequest.recipient",                                                                             // MakerGen.cs:236
                        Id = "CommunicationRequest.recipient",                                                                              // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Device",                                                       // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Organization",                                                 // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson",                                                // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Group",                                                        // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/CareTeam",                                                     // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/HealthcareService"                                             // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 20. CommunicationRequest.sender
                    this.Sender = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Sender",                                                                                                    // MakerGen.cs:235
                        Path= "CommunicationRequest.sender",                                                                                // MakerGen.cs:236
                        Id = "CommunicationRequest.sender",                                                                                 // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Device",                                                       // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Organization",                                                 // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson",                                                // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/HealthcareService"                                             // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 21. CommunicationRequest.reasonCode
                    this.ReasonCode = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "ReasonCode",                                                                                                // MakerGen.cs:235
                        Path= "CommunicationRequest.reasonCode",                                                                            // MakerGen.cs:236
                        Id = "CommunicationRequest.reasonCode",                                                                             // MakerGen.cs:237
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
                    // 22. CommunicationRequest.reasonReference
                    this.ReasonReference = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "ReasonReference",                                                                                           // MakerGen.cs:235
                        Path= "CommunicationRequest.reasonReference",                                                                       // MakerGen.cs:236
                        Id = "CommunicationRequest.reasonReference",                                                                        // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Condition",                                                    // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Observation",                                                  // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/DiagnosticReport",                                             // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/DocumentReference"                                             // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 23. CommunicationRequest.note
                    this.Note = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Note",                                                                                                      // MakerGen.cs:235
                        Path= "CommunicationRequest.note",                                                                                  // MakerGen.cs:236
                        Id = "CommunicationRequest.note",                                                                                   // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Annotation                                                                    // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:427
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:412
            {                                                                                                                               // MakerGen.cs:413
                base.Write(sDef);                                                                                                           // MakerGen.cs:414
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:220
                BasedOn.Write(sDef);                                                                                                        // MakerGen.cs:220
                Replaces.Write(sDef);                                                                                                       // MakerGen.cs:220
                GroupIdentifier.Write(sDef);                                                                                                // MakerGen.cs:220
                Status.Write(sDef);                                                                                                         // MakerGen.cs:220
                StatusReason.Write(sDef);                                                                                                   // MakerGen.cs:220
                Category.Write(sDef);                                                                                                       // MakerGen.cs:220
                Priority.Write(sDef);                                                                                                       // MakerGen.cs:220
                DoNotPerform.Write(sDef);                                                                                                   // MakerGen.cs:220
                Medium.Write(sDef);                                                                                                         // MakerGen.cs:220
                Subject.Write(sDef);                                                                                                        // MakerGen.cs:220
                About.Write(sDef);                                                                                                          // MakerGen.cs:220
                Encounter.Write(sDef);                                                                                                      // MakerGen.cs:220
                Payload.Write(sDef);                                                                                                        // MakerGen.cs:220
                Occurrence.Write(sDef);                                                                                                     // MakerGen.cs:220
                AuthoredOn.Write(sDef);                                                                                                     // MakerGen.cs:220
                Requester.Write(sDef);                                                                                                      // MakerGen.cs:220
                Recipient.Write(sDef);                                                                                                      // MakerGen.cs:220
                Sender.Write(sDef);                                                                                                         // MakerGen.cs:220
                ReasonCode.Write(sDef);                                                                                                     // MakerGen.cs:220
                ReasonReference.Write(sDef);                                                                                                // MakerGen.cs:220
                Note.Write(sDef);                                                                                                           // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:431
        }                                                                                                                                   // MakerGen.cs:391
        public CommunicationRequest_Elements Elements { get; }                                                                              // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
        public CommunicationRequest()                                                                                                       // MakerGen.cs:394
        {                                                                                                                                   // MakerGen.cs:395
            this.Elements = new CommunicationRequest_Elements();                                                                            // MakerGen.cs:396
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:399
        {                                                                                                                                   // MakerGen.cs:400
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:401
        }                                                                                                                                   // MakerGen.cs:402
    }                                                                                                                                       // MakerGen.cs:403
}                                                                                                                                           // MakerGen.cs:466
