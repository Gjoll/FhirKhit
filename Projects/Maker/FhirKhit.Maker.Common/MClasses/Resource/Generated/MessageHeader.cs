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
      "id": "MessageHeader",
      "url": "http://hl7.org/fhir/StructureDefinition/MessageHeader",
      "version": "4.0.0",
      "name": "MessageHeader",
      "status": "draft",
      "publisher": "Health Level Seven International (Infrastructure And Messaging)",
      "description": "The header for a message exchange that is either requesting or responding to an action.  The reference(s) that are the subject of the action as well as other information related to the action are typically transmitted in a bundle in which the MessageHeader resource instance is the first resource in the bundle.",
      "purpose": "Many implementations are not prepared to use REST and need a messaging based infrastructure.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "MessageHeader",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "MessageHeader",
            "path": "MessageHeader",
            "short": "A resource that describes a message that is exchanged between systems",
            "definition": "The header for a message exchange that is either requesting or responding to an action.  The reference(s) that are the subject of the action as well as other information related to the action are typically transmitted in a bundle in which the MessageHeader resource instance is the first resource in the bundle.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "MessageHeader.event[x]",
            "path": "MessageHeader.event[x]",
            "short": "Code for the event this message represents or link to event definition",
            "definition": "Code that identifies the event this message represents and connects it with its definition. Events defined as part of the FHIR specification have the system value \"http://terminology.hl7.org/CodeSystem/message-events\".  Alternatively uri to the EventDefinition.",
            "comment": "The time of the event will be found in the focus resource. The time of the message will be found in [Bundle.timestamp](bundle-definitions.html#Bundle.timestamp).",
            "requirements": "Drives the behavior associated with this message.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Coding"
              },
              {
                "code": "uri"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "MessageEvent"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "example",
              "description": "One of the message events defined as part of this version of FHIR.",
              "valueSet": "http://hl7.org/fhir/ValueSet/message-events"
            }
          },
          {
            "id": "MessageHeader.destination",
            "path": "MessageHeader.destination",
            "short": "Message destination application(s)",
            "definition": "The destination application which the message is intended for.",
            "comment": "There SHOULD be at least one destination, but in some circumstances, the source system is unaware of any particular destination system.",
            "requirements": "Indicates where message is to be sent for routing purposes.  Allows verification of \"am I the intended recipient\".",
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
            "id": "MessageHeader.destination.name",
            "path": "MessageHeader.destination.name",
            "short": "Name of system",
            "definition": "Human-readable name for the target system.",
            "requirements": "May be used for routing of response and/or to support audit.",
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
            "id": "MessageHeader.destination.target",
            "path": "MessageHeader.destination.target",
            "short": "Particular delivery destination within the destination",
            "definition": "Identifies the target end system in situations where the initial message transmission is to an intermediary system.",
            "requirements": "Supports multi-hop routing.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Device"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MessageHeader.destination.endpoint",
            "path": "MessageHeader.destination.endpoint",
            "short": "Actual destination address or id",
            "definition": "Indicates where the message should be routed to.",
            "comment": "The id may be a non-resolvable URI for systems that do not use standard network-based addresses.",
            "requirements": "Identifies where to route the message.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "url"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MessageHeader.destination.receiver",
            "path": "MessageHeader.destination.receiver",
            "short": "Intended \"real-world\" recipient for the data",
            "definition": "Allows data conveyed by a message to be addressed to a particular person or department when routing to a specific application isn't sufficient.",
            "requirements": "Allows routing beyond just the application level.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MessageHeader.sender",
            "path": "MessageHeader.sender",
            "short": "Real world sender of the message",
            "definition": "Identifies the sending system to allow the use of a trust relationship.",
            "comment": "Use case is for where a (trusted) sending system is responsible for multiple organizations, and therefore cannot differentiate based on source endpoint / authentication alone.",
            "requirements": "Allows routing beyond just the application level.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MessageHeader.enterer",
            "path": "MessageHeader.enterer",
            "short": "The source of the data entry",
            "definition": "The person or device that performed the data entry leading to this message. When there is more than one candidate, pick the most proximal to the message. Can provide other enterers in extensions.",
            "comment": "Usually only for the request but can be used in a response.",
            "requirements": "Need to know for audit/traceback requirements and possibly for authorization.",
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
            ],
            "isSummary": true
          },
          {
            "id": "MessageHeader.author",
            "path": "MessageHeader.author",
            "short": "The source of the decision",
            "definition": "The logical author of the message - the person or device that decided the described event should happen. When there is more than one candidate, pick the most proximal to the MessageHeader. Can provide other authors in extensions.",
            "comment": "Usually only for the request but can be used in a response.",
            "requirements": "Need to know for audit/traceback requirements and possibly for authorization.",
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
            ],
            "isSummary": true
          },
          {
            "id": "MessageHeader.source",
            "path": "MessageHeader.source",
            "short": "Message source application",
            "definition": "The source application from which this message originated.",
            "requirements": "Allows replies, supports audit.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MessageHeader.source.name",
            "path": "MessageHeader.source.name",
            "short": "Name of system",
            "definition": "Human-readable name for the source system.",
            "requirements": "May be used to support audit.",
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
            "id": "MessageHeader.source.software",
            "path": "MessageHeader.source.software",
            "short": "Name of software running the system",
            "definition": "May include configuration or other information useful in debugging.",
            "requirements": "Supports audit and possibly interface engine behavior.",
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
            "id": "MessageHeader.source.version",
            "path": "MessageHeader.source.version",
            "short": "Version of software running",
            "definition": "Can convey versions of multiple systems in situations where a message passes through multiple hands.",
            "requirements": "Supports audit and possibly interface engine behavior.",
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
            "id": "MessageHeader.source.contact",
            "path": "MessageHeader.source.contact",
            "short": "Human contact for problems",
            "definition": "An e-mail, phone, website or other contact point to use to resolve issues with message communications.",
            "requirements": "Allows escalation of technical issues.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "ContactPoint"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MessageHeader.source.endpoint",
            "path": "MessageHeader.source.endpoint",
            "short": "Actual message source address or id",
            "definition": "Identifies the routing target to send acknowledgements to.",
            "comment": "The id may be a non-resolvable URI for systems that do not use standard network-based addresses.",
            "requirements": "Identifies where to send responses, may influence security permissions.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "url"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MessageHeader.responsible",
            "path": "MessageHeader.responsible",
            "short": "Final responsibility for event",
            "definition": "The person or organization that accepts overall responsibility for the contents of the message. The implication is that the message event happened under the policies of the responsible party.",
            "comment": "Usually only for the request but can be used in a response.",
            "requirements": "Need to know for audit/traceback requirements and possibly for authorization.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MessageHeader.reason",
            "path": "MessageHeader.reason",
            "short": "Cause of event",
            "definition": "Coded indication of the cause for the event - indicates  a reason for the occurrence of the event that is a focus of this message.",
            "requirements": "Need to be able to track why resources are being changed and report in the audit log/history of the resource.  May affect authorization.",
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
                  "valueString": "EventReason"
                }
              ],
              "strength": "example",
              "description": "Reason for event occurrence.",
              "valueSet": "http://hl7.org/fhir/ValueSet/message-reason-encounter"
            }
          },
          {
            "id": "MessageHeader.response",
            "path": "MessageHeader.response",
            "short": "If this is a reply to prior message",
            "definition": "Information about the message that this message is a response to.  Only present if this message is a response.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MessageHeader.response.identifier",
            "path": "MessageHeader.response.identifier",
            "short": "Id of original message",
            "definition": "The MessageHeader.id of the message to which this message is a response.",
            "requirements": "Allows receiver to know what message is being responded to.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "id"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MessageHeader.response.code",
            "path": "MessageHeader.response.code",
            "short": "ok | transient-error | fatal-error",
            "definition": "Code that identifies the type of response to the message - whether it was successful or not, and whether it should be resent or not.",
            "comment": "This is a generic response to the request message. Specific data for the response will be found in MessageHeader.focus.",
            "requirements": "Allows the sender of the acknowledge message to know if the request was successful or if action is needed.",
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
                  "valueString": "ResponseType"
                }
              ],
              "strength": "required",
              "description": "The kind of response to a message.",
              "valueSet": "http://hl7.org/fhir/ValueSet/response-code|4.0.0"
            }
          },
          {
            "id": "MessageHeader.response.details",
            "path": "MessageHeader.response.details",
            "short": "Specific list of hints/warnings/errors",
            "definition": "Full details of any issues found in the message.",
            "comment": "This SHALL be contained in the bundle. If any of the issues are errors, the response code SHALL be an error.",
            "requirements": "Allows the sender of the message to determine what the specific issues are.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/OperationOutcome"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MessageHeader.focus",
            "path": "MessageHeader.focus",
            "short": "The actual content of the message",
            "definition": "The actual data of the message - a reference to the root/focus class of the event.",
            "comment": "The data is defined where the transaction type is defined. The transaction data is always included in the bundle that is the full message.  Only the root resource is specified.  The resources it references should be contained in the bundle but are not also listed here.  Multiple repetitions are allowed to cater for merges and other situations with multiple focal targets.",
            "requirements": "Every message event is about actual data, a single resource, that is identified in the definition of the event, and perhaps some or all linked resources.",
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
            "id": "MessageHeader.definition",
            "path": "MessageHeader.definition",
            "short": "Link to the definition for this message",
            "definition": "Permanent link to the MessageDefinition for this message.",
            "requirements": "Allows sender to define the expected contents of the message.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/MessageDefinition"
                ]
              }
            ],
            "isSummary": true
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:461
    /// <summary>
    /// Fhir resource 'MessageHeader'
    /// </summary>
    // 0. MessageHeader
    public class MessageHeader : FhirKhit.Maker.Common.Resource.ResourceBase                                                                // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        public class MessageHeader_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                   // MakerGen.cs:385
        {                                                                                                                                   // MakerGen.cs:386
            // 2. MessageHeader.destination
            public class Type_Destination : FhirKhit.Maker.Common.Complex.ComplexBase                                                       // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                public class Type_Destination_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                        // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:386
                    // 3. MessageHeader.destination.name
                    public ElementDefinitionInfo Name;                                                                                      // MakerGen.cs:216
                    // 4. MessageHeader.destination.target
                    public ElementDefinitionInfo Target;                                                                                    // MakerGen.cs:216
                    // 5. MessageHeader.destination.endpoint
                    public ElementDefinitionInfo Endpoint;                                                                                  // MakerGen.cs:216
                    // 6. MessageHeader.destination.receiver
                    public ElementDefinitionInfo Receiver;                                                                                  // MakerGen.cs:216
                    public Type_Destination_Elements()                                                                                      // MakerGen.cs:407
                    {                                                                                                                       // MakerGen.cs:408
                        {                                                                                                                   // MakerGen.cs:231
                            // 3. MessageHeader.destination.name
                            this.Name = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Name",                                                                                              // MakerGen.cs:235
                                Path= "MessageHeader.destination.name",                                                                     // MakerGen.cs:236
                                Id = "MessageHeader.destination.name",                                                                      // MakerGen.cs:237
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
                            // 4. MessageHeader.destination.target
                            this.Target = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Target",                                                                                            // MakerGen.cs:235
                                Path= "MessageHeader.destination.target",                                                                   // MakerGen.cs:236
                                Id = "MessageHeader.destination.target",                                                                    // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Device"                                                // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 5. MessageHeader.destination.endpoint
                            this.Endpoint = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Endpoint",                                                                                          // MakerGen.cs:235
                                Path= "MessageHeader.destination.endpoint",                                                                 // MakerGen.cs:236
                                Id = "MessageHeader.destination.endpoint",                                                                  // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Url                                                                 // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 6. MessageHeader.destination.receiver
                            this.Receiver = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Receiver",                                                                                          // MakerGen.cs:235
                                Path= "MessageHeader.destination.receiver",                                                                 // MakerGen.cs:236
                                Id = "MessageHeader.destination.receiver",                                                                  // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Practitioner",                                         // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                     // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/Organization"                                          // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:427
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:412
                    {                                                                                                                       // MakerGen.cs:413
                        base.Write(sDef);                                                                                                   // MakerGen.cs:414
                        Name.Write(sDef);                                                                                                   // MakerGen.cs:220
                        Target.Write(sDef);                                                                                                 // MakerGen.cs:220
                        Endpoint.Write(sDef);                                                                                               // MakerGen.cs:220
                        Receiver.Write(sDef);                                                                                               // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:431
                }                                                                                                                           // MakerGen.cs:391
                public Type_Destination_Elements Elements { get; }                                                                          // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                public Type_Destination()                                                                                                   // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:395
                    this.Elements = new Type_Destination_Elements();                                                                        // MakerGen.cs:396
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:399
                {                                                                                                                           // MakerGen.cs:400
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:401
                }                                                                                                                           // MakerGen.cs:402
            }                                                                                                                               // MakerGen.cs:403
            // 10. MessageHeader.source
            public class Type_Source : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                public class Type_Source_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                             // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:386
                    // 11. MessageHeader.source.name
                    public ElementDefinitionInfo Name;                                                                                      // MakerGen.cs:216
                    // 12. MessageHeader.source.software
                    public ElementDefinitionInfo Software;                                                                                  // MakerGen.cs:216
                    // 13. MessageHeader.source.version
                    public ElementDefinitionInfo Version;                                                                                   // MakerGen.cs:216
                    // 14. MessageHeader.source.contact
                    public ElementDefinitionInfo Contact;                                                                                   // MakerGen.cs:216
                    // 15. MessageHeader.source.endpoint
                    public ElementDefinitionInfo Endpoint;                                                                                  // MakerGen.cs:216
                    public Type_Source_Elements()                                                                                           // MakerGen.cs:407
                    {                                                                                                                       // MakerGen.cs:408
                        {                                                                                                                   // MakerGen.cs:231
                            // 11. MessageHeader.source.name
                            this.Name = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Name",                                                                                              // MakerGen.cs:235
                                Path= "MessageHeader.source.name",                                                                          // MakerGen.cs:236
                                Id = "MessageHeader.source.name",                                                                           // MakerGen.cs:237
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
                            // 12. MessageHeader.source.software
                            this.Software = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Software",                                                                                          // MakerGen.cs:235
                                Path= "MessageHeader.source.software",                                                                      // MakerGen.cs:236
                                Id = "MessageHeader.source.software",                                                                       // MakerGen.cs:237
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
                            // 13. MessageHeader.source.version
                            this.Version = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Version",                                                                                           // MakerGen.cs:235
                                Path= "MessageHeader.source.version",                                                                       // MakerGen.cs:236
                                Id = "MessageHeader.source.version",                                                                        // MakerGen.cs:237
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
                            // 14. MessageHeader.source.contact
                            this.Contact = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Contact",                                                                                           // MakerGen.cs:235
                                Path= "MessageHeader.source.contact",                                                                       // MakerGen.cs:236
                                Id = "MessageHeader.source.contact",                                                                        // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.ContactPoint                                                          // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    }                                                                                                       // MakerGen.cs:360
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 15. MessageHeader.source.endpoint
                            this.Endpoint = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Endpoint",                                                                                          // MakerGen.cs:235
                                Path= "MessageHeader.source.endpoint",                                                                      // MakerGen.cs:236
                                Id = "MessageHeader.source.endpoint",                                                                       // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Url                                                                 // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:427
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:412
                    {                                                                                                                       // MakerGen.cs:413
                        base.Write(sDef);                                                                                                   // MakerGen.cs:414
                        Name.Write(sDef);                                                                                                   // MakerGen.cs:220
                        Software.Write(sDef);                                                                                               // MakerGen.cs:220
                        Version.Write(sDef);                                                                                                // MakerGen.cs:220
                        Contact.Write(sDef);                                                                                                // MakerGen.cs:220
                        Endpoint.Write(sDef);                                                                                               // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:431
                }                                                                                                                           // MakerGen.cs:391
                public Type_Source_Elements Elements { get; }                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                public Type_Source()                                                                                                        // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:395
                    this.Elements = new Type_Source_Elements();                                                                             // MakerGen.cs:396
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:399
                {                                                                                                                           // MakerGen.cs:400
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:401
                }                                                                                                                           // MakerGen.cs:402
            }                                                                                                                               // MakerGen.cs:403
            // 18. MessageHeader.response
            public class Type_Response : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                public class Type_Response_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                           // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:386
                    // 19. MessageHeader.response.identifier
                    public ElementDefinitionInfo Identifier;                                                                                // MakerGen.cs:216
                    // 20. MessageHeader.response.code
                    public ElementDefinitionInfo Code;                                                                                      // MakerGen.cs:216
                    // 21. MessageHeader.response.details
                    public ElementDefinitionInfo Details;                                                                                   // MakerGen.cs:216
                    public Type_Response_Elements()                                                                                         // MakerGen.cs:407
                    {                                                                                                                       // MakerGen.cs:408
                        {                                                                                                                   // MakerGen.cs:231
                            // 19. MessageHeader.response.identifier
                            this.Identifier = new ElementDefinitionInfo                                                                     // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Identifier",                                                                                        // MakerGen.cs:235
                                Path= "MessageHeader.response.identifier",                                                                  // MakerGen.cs:236
                                Id = "MessageHeader.response.identifier",                                                                   // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Id                                                                  // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 20. MessageHeader.response.code
                            this.Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Code",                                                                                              // MakerGen.cs:235
                                Path= "MessageHeader.response.code",                                                                        // MakerGen.cs:236
                                Id = "MessageHeader.response.code",                                                                         // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 21. MessageHeader.response.details
                            this.Details = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Details",                                                                                           // MakerGen.cs:235
                                Path= "MessageHeader.response.details",                                                                     // MakerGen.cs:236
                                Id = "MessageHeader.response.details",                                                                      // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/OperationOutcome"                                      // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:427
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:412
                    {                                                                                                                       // MakerGen.cs:413
                        base.Write(sDef);                                                                                                   // MakerGen.cs:414
                        Identifier.Write(sDef);                                                                                             // MakerGen.cs:220
                        Code.Write(sDef);                                                                                                   // MakerGen.cs:220
                        Details.Write(sDef);                                                                                                // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:431
                }                                                                                                                           // MakerGen.cs:391
                public Type_Response_Elements Elements { get; }                                                                             // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                public Type_Response()                                                                                                      // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:395
                    this.Elements = new Type_Response_Elements();                                                                           // MakerGen.cs:396
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:399
                {                                                                                                                           // MakerGen.cs:400
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:401
                }                                                                                                                           // MakerGen.cs:402
            }                                                                                                                               // MakerGen.cs:403
            // 1. MessageHeader.event[x]
            public ElementDefinitionInfo Event;                                                                                             // MakerGen.cs:216
            // 2. MessageHeader.destination
            public ElementDefinitionInfo Destination;                                                                                       // MakerGen.cs:216
            // 7. MessageHeader.sender
            public ElementDefinitionInfo Sender;                                                                                            // MakerGen.cs:216
            // 8. MessageHeader.enterer
            public ElementDefinitionInfo Enterer;                                                                                           // MakerGen.cs:216
            // 9. MessageHeader.author
            public ElementDefinitionInfo Author;                                                                                            // MakerGen.cs:216
            // 10. MessageHeader.source
            public ElementDefinitionInfo Source;                                                                                            // MakerGen.cs:216
            // 16. MessageHeader.responsible
            public ElementDefinitionInfo Responsible;                                                                                       // MakerGen.cs:216
            // 17. MessageHeader.reason
            public ElementDefinitionInfo Reason;                                                                                            // MakerGen.cs:216
            // 18. MessageHeader.response
            public ElementDefinitionInfo Response;                                                                                          // MakerGen.cs:216
            // 22. MessageHeader.focus
            public ElementDefinitionInfo Focus;                                                                                             // MakerGen.cs:216
            // 23. MessageHeader.definition
            public ElementDefinitionInfo Definition;                                                                                        // MakerGen.cs:216
            public MessageHeader_Elements()                                                                                                 // MakerGen.cs:407
            {                                                                                                                               // MakerGen.cs:408
                {                                                                                                                           // MakerGen.cs:231
                    // 1. MessageHeader.event[x]
                    this.Event = new ElementDefinitionInfo                                                                                  // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Event",                                                                                                     // MakerGen.cs:235
                        Path= "MessageHeader.event[x]",                                                                                     // MakerGen.cs:236
                        Id = "MessageHeader.event[x]",                                                                                      // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Coding                                                                        // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            },                                                                                                              // MakerGen.cs:319
                            new FhirKhit.Maker.Common.Primitive.Uri                                                                         // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 2. MessageHeader.destination
                    this.Destination = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Destination",                                                                                               // MakerGen.cs:235
                        Path= "MessageHeader.destination",                                                                                  // MakerGen.cs:236
                        Id = "MessageHeader.destination",                                                                                   // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Destination                                                                                            // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 7. MessageHeader.sender
                    this.Sender = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Sender",                                                                                                    // MakerGen.cs:235
                        Path= "MessageHeader.sender",                                                                                       // MakerGen.cs:236
                        Id = "MessageHeader.sender",                                                                                        // MakerGen.cs:237
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
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 8. MessageHeader.enterer
                    this.Enterer = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Enterer",                                                                                                   // MakerGen.cs:235
                        Path= "MessageHeader.enterer",                                                                                      // MakerGen.cs:236
                        Id = "MessageHeader.enterer",                                                                                       // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                                              // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 9. MessageHeader.author
                    this.Author = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Author",                                                                                                    // MakerGen.cs:235
                        Path= "MessageHeader.author",                                                                                       // MakerGen.cs:236
                        Id = "MessageHeader.author",                                                                                        // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                                              // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 10. MessageHeader.source
                    this.Source = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Source",                                                                                                    // MakerGen.cs:235
                        Path= "MessageHeader.source",                                                                                       // MakerGen.cs:236
                        Id = "MessageHeader.source",                                                                                        // MakerGen.cs:237
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
                    // 16. MessageHeader.responsible
                    this.Responsible = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Responsible",                                                                                               // MakerGen.cs:235
                        Path= "MessageHeader.responsible",                                                                                  // MakerGen.cs:236
                        Id = "MessageHeader.responsible",                                                                                   // MakerGen.cs:237
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
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 17. MessageHeader.reason
                    this.Reason = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Reason",                                                                                                    // MakerGen.cs:235
                        Path= "MessageHeader.reason",                                                                                       // MakerGen.cs:236
                        Id = "MessageHeader.reason",                                                                                        // MakerGen.cs:237
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
                    // 18. MessageHeader.response
                    this.Response = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Response",                                                                                                  // MakerGen.cs:235
                        Path= "MessageHeader.response",                                                                                     // MakerGen.cs:236
                        Id = "MessageHeader.response",                                                                                      // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Response                                                                                               // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 22. MessageHeader.focus
                    this.Focus = new ElementDefinitionInfo                                                                                  // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Focus",                                                                                                     // MakerGen.cs:235
                        Path= "MessageHeader.focus",                                                                                        // MakerGen.cs:236
                        Id = "MessageHeader.focus",                                                                                         // MakerGen.cs:237
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
                    // 23. MessageHeader.definition
                    this.Definition = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Definition",                                                                                                // MakerGen.cs:235
                        Path= "MessageHeader.definition",                                                                                   // MakerGen.cs:236
                        Id = "MessageHeader.definition",                                                                                    // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Canonical                                                                   // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                                TargetProfile = new String[]                                                                                // MakerGen.cs:303
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/MessageDefinition"                                             // MakerGen.cs:303
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:427
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:412
            {                                                                                                                               // MakerGen.cs:413
                base.Write(sDef);                                                                                                           // MakerGen.cs:414
                Event.Write(sDef);                                                                                                          // MakerGen.cs:220
                Destination.Write(sDef);                                                                                                    // MakerGen.cs:220
                Sender.Write(sDef);                                                                                                         // MakerGen.cs:220
                Enterer.Write(sDef);                                                                                                        // MakerGen.cs:220
                Author.Write(sDef);                                                                                                         // MakerGen.cs:220
                Source.Write(sDef);                                                                                                         // MakerGen.cs:220
                Responsible.Write(sDef);                                                                                                    // MakerGen.cs:220
                Reason.Write(sDef);                                                                                                         // MakerGen.cs:220
                Response.Write(sDef);                                                                                                       // MakerGen.cs:220
                Focus.Write(sDef);                                                                                                          // MakerGen.cs:220
                Definition.Write(sDef);                                                                                                     // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:431
        }                                                                                                                                   // MakerGen.cs:391
        public MessageHeader_Elements Elements { get; }                                                                                     // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
        public MessageHeader()                                                                                                              // MakerGen.cs:394
        {                                                                                                                                   // MakerGen.cs:395
            this.Elements = new MessageHeader_Elements();                                                                                   // MakerGen.cs:396
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:399
        {                                                                                                                                   // MakerGen.cs:400
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:401
        }                                                                                                                                   // MakerGen.cs:402
    }                                                                                                                                       // MakerGen.cs:403
}                                                                                                                                           // MakerGen.cs:466
