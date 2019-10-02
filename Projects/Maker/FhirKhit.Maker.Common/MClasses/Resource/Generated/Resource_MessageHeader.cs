using System;                                                                                                                               // MakerGen.cs:435
using System.Diagnostics;                                                                                                                   // MakerGen.cs:436
using System.IO;                                                                                                                            // MakerGen.cs:437
using System.Linq;                                                                                                                          // MakerGen.cs:438
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:439
                                                                                                                                            // MakerGen.cs:440
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:441
{                                                                                                                                           // MakerGen.cs:442
    #region Json                                                                                                                            // MakerGen.cs:443
    #if NEVER                                                                                                                               // MakerGen.cs:444
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
    #endregion                                                                                                                              // MakerGen.cs:447
    /// <summary>
    /// Fhir resource 'MessageHeader'
    /// </summary>
    // 0. MessageHeader
    public class Resource_MessageHeader : FhirKhit.Maker.Common.Resource.Resource_DomainResource                                            // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        // 2. MessageHeader.destination
        public class Type_Destination : FhirKhit.Maker.Common.Complex.ComplexBase                                                           // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 3. MessageHeader.destination.name
            public ElementDefinitionInfo Element_Name;                                                                                      // MakerGen.cs:219
            // 4. MessageHeader.destination.target
            public ElementDefinitionInfo Element_Target;                                                                                    // MakerGen.cs:219
            // 5. MessageHeader.destination.endpoint
            public ElementDefinitionInfo Element_Endpoint;                                                                                  // MakerGen.cs:219
            // 6. MessageHeader.destination.receiver
            public ElementDefinitionInfo Element_Receiver;                                                                                  // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "MessageHeader.destination",                                                                                     // MakerGen.cs:395
                    ElementId = "MessageHeader.destination"                                                                                 // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Name.Write(sDef);                                                                                                   // MakerGen.cs:223
                Element_Target.Write(sDef);                                                                                                 // MakerGen.cs:223
                Element_Endpoint.Write(sDef);                                                                                               // MakerGen.cs:223
                Element_Receiver.Write(sDef);                                                                                               // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_Destination()                                                                                                       // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 3. MessageHeader.destination.name
                    this.Element_Name = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Name",                                                                                              // MakerGen.cs:238
                        Path= "MessageHeader.destination.name",                                                                             // MakerGen.cs:239
                        Id = "MessageHeader.destination.name",                                                                              // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 4. MessageHeader.destination.target
                    this.Element_Target = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Target",                                                                                            // MakerGen.cs:238
                        Path= "MessageHeader.destination.target",                                                                           // MakerGen.cs:239
                        Id = "MessageHeader.destination.target",                                                                            // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Device"                                                        // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 5. MessageHeader.destination.endpoint
                    this.Element_Endpoint = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Endpoint",                                                                                          // MakerGen.cs:238
                        Path= "MessageHeader.destination.endpoint",                                                                         // MakerGen.cs:239
                        Id = "MessageHeader.destination.endpoint",                                                                          // MakerGen.cs:240
                        Min = 1,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Url                                                               // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 6. MessageHeader.destination.receiver
                    this.Element_Receiver = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Receiver",                                                                                          // MakerGen.cs:238
                        Path= "MessageHeader.destination.receiver",                                                                         // MakerGen.cs:239
                        Id = "MessageHeader.destination.receiver",                                                                          // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 10. MessageHeader.source
        public class Type_Source : FhirKhit.Maker.Common.Complex.ComplexBase                                                                // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 11. MessageHeader.source.name
            public ElementDefinitionInfo Element_Name;                                                                                      // MakerGen.cs:219
            // 12. MessageHeader.source.software
            public ElementDefinitionInfo Element_Software;                                                                                  // MakerGen.cs:219
            // 13. MessageHeader.source.version
            public ElementDefinitionInfo Element_Version;                                                                                   // MakerGen.cs:219
            // 14. MessageHeader.source.contact
            public ElementDefinitionInfo Element_Contact;                                                                                   // MakerGen.cs:219
            // 15. MessageHeader.source.endpoint
            public ElementDefinitionInfo Element_Endpoint;                                                                                  // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "MessageHeader.source",                                                                                          // MakerGen.cs:395
                    ElementId = "MessageHeader.source"                                                                                      // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Name.Write(sDef);                                                                                                   // MakerGen.cs:223
                Element_Software.Write(sDef);                                                                                               // MakerGen.cs:223
                Element_Version.Write(sDef);                                                                                                // MakerGen.cs:223
                Element_Contact.Write(sDef);                                                                                                // MakerGen.cs:223
                Element_Endpoint.Write(sDef);                                                                                               // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_Source()                                                                                                            // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 11. MessageHeader.source.name
                    this.Element_Name = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Name",                                                                                              // MakerGen.cs:238
                        Path= "MessageHeader.source.name",                                                                                  // MakerGen.cs:239
                        Id = "MessageHeader.source.name",                                                                                   // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 12. MessageHeader.source.software
                    this.Element_Software = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Software",                                                                                          // MakerGen.cs:238
                        Path= "MessageHeader.source.software",                                                                              // MakerGen.cs:239
                        Id = "MessageHeader.source.software",                                                                               // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 13. MessageHeader.source.version
                    this.Element_Version = new ElementDefinitionInfo                                                                        // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Version",                                                                                           // MakerGen.cs:238
                        Path= "MessageHeader.source.version",                                                                               // MakerGen.cs:239
                        Id = "MessageHeader.source.version",                                                                                // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 14. MessageHeader.source.contact
                    this.Element_Contact = new ElementDefinitionInfo                                                                        // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Contact",                                                                                           // MakerGen.cs:238
                        Path= "MessageHeader.source.contact",                                                                               // MakerGen.cs:239
                        Id = "MessageHeader.source.contact",                                                                                // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_ContactPoint                                                             // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 15. MessageHeader.source.endpoint
                    this.Element_Endpoint = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Endpoint",                                                                                          // MakerGen.cs:238
                        Path= "MessageHeader.source.endpoint",                                                                              // MakerGen.cs:239
                        Id = "MessageHeader.source.endpoint",                                                                               // MakerGen.cs:240
                        Min = 1,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Url                                                               // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 18. MessageHeader.response
        public class Type_Response : FhirKhit.Maker.Common.Complex.ComplexBase                                                              // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 19. MessageHeader.response.identifier
            public ElementDefinitionInfo Element_Identifier;                                                                                // MakerGen.cs:219
            // 20. MessageHeader.response.code
            public ElementDefinitionInfo Element_Code;                                                                                      // MakerGen.cs:219
            // 21. MessageHeader.response.details
            public ElementDefinitionInfo Element_Details;                                                                                   // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "MessageHeader.response",                                                                                        // MakerGen.cs:395
                    ElementId = "MessageHeader.response"                                                                                    // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Identifier.Write(sDef);                                                                                             // MakerGen.cs:223
                Element_Code.Write(sDef);                                                                                                   // MakerGen.cs:223
                Element_Details.Write(sDef);                                                                                                // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_Response()                                                                                                          // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 19. MessageHeader.response.identifier
                    this.Element_Identifier = new ElementDefinitionInfo                                                                     // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Identifier",                                                                                        // MakerGen.cs:238
                        Path= "MessageHeader.response.identifier",                                                                          // MakerGen.cs:239
                        Id = "MessageHeader.response.identifier",                                                                           // MakerGen.cs:240
                        Min = 1,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Id                                                                // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 20. MessageHeader.response.code
                    this.Element_Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Code",                                                                                              // MakerGen.cs:238
                        Path= "MessageHeader.response.code",                                                                                // MakerGen.cs:239
                        Id = "MessageHeader.response.code",                                                                                 // MakerGen.cs:240
                        Min = 1,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                              // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 21. MessageHeader.response.details
                    this.Element_Details = new ElementDefinitionInfo                                                                        // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Details",                                                                                           // MakerGen.cs:238
                        Path= "MessageHeader.response.details",                                                                             // MakerGen.cs:239
                        Id = "MessageHeader.response.details",                                                                              // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/OperationOutcome"                                              // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 1. MessageHeader.event[x]
        public ElementDefinitionInfo Element_Event;                                                                                         // MakerGen.cs:219
        // 2. MessageHeader.destination
        public ElementDefinitionInfo Element_Destination;                                                                                   // MakerGen.cs:219
        // 7. MessageHeader.sender
        public ElementDefinitionInfo Element_Sender;                                                                                        // MakerGen.cs:219
        // 8. MessageHeader.enterer
        public ElementDefinitionInfo Element_Enterer;                                                                                       // MakerGen.cs:219
        // 9. MessageHeader.author
        public ElementDefinitionInfo Element_Author;                                                                                        // MakerGen.cs:219
        // 10. MessageHeader.source
        public ElementDefinitionInfo Element_Source;                                                                                        // MakerGen.cs:219
        // 16. MessageHeader.responsible
        public ElementDefinitionInfo Element_Responsible;                                                                                   // MakerGen.cs:219
        // 17. MessageHeader.reason
        public ElementDefinitionInfo Element_Reason;                                                                                        // MakerGen.cs:219
        // 18. MessageHeader.response
        public ElementDefinitionInfo Element_Response;                                                                                      // MakerGen.cs:219
        // 22. MessageHeader.focus
        public ElementDefinitionInfo Element_Focus;                                                                                         // MakerGen.cs:219
        // 23. MessageHeader.definition
        public ElementDefinitionInfo Element_Definition;                                                                                    // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:390
        {                                                                                                                                   // MakerGen.cs:391
            base.Write(sDef);                                                                                                               // MakerGen.cs:392
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                Path = "MessageHeader",                                                                                                     // MakerGen.cs:395
                ElementId = "MessageHeader"                                                                                                 // MakerGen.cs:396
            });                                                                                                                             // MakerGen.cs:397
            Element_Event.Write(sDef);                                                                                                      // MakerGen.cs:223
            Element_Destination.Write(sDef);                                                                                                // MakerGen.cs:223
            Element_Sender.Write(sDef);                                                                                                     // MakerGen.cs:223
            Element_Enterer.Write(sDef);                                                                                                    // MakerGen.cs:223
            Element_Author.Write(sDef);                                                                                                     // MakerGen.cs:223
            Element_Source.Write(sDef);                                                                                                     // MakerGen.cs:223
            Element_Responsible.Write(sDef);                                                                                                // MakerGen.cs:223
            Element_Reason.Write(sDef);                                                                                                     // MakerGen.cs:223
            Element_Response.Write(sDef);                                                                                                   // MakerGen.cs:223
            Element_Focus.Write(sDef);                                                                                                      // MakerGen.cs:223
            Element_Definition.Write(sDef);                                                                                                 // MakerGen.cs:223
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
        public Resource_MessageHeader()                                                                                                     // MakerGen.cs:402
        {                                                                                                                                   // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:234
                // 1. MessageHeader.event[x]
                this.Element_Event = new ElementDefinitionInfo                                                                              // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Event",                                                                                                 // MakerGen.cs:238
                    Path= "MessageHeader.event[x]",                                                                                         // MakerGen.cs:239
                    Id = "MessageHeader.event[x]",                                                                                          // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Coding                                                                       // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        },                                                                                                                  // MakerGen.cs:322
                        new FhirKhit.Maker.Common.Primitive.Primitive_Uri                                                                   // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 2. MessageHeader.destination
                this.Element_Destination = new ElementDefinitionInfo                                                                        // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Destination",                                                                                           // MakerGen.cs:238
                    Path= "MessageHeader.destination",                                                                                      // MakerGen.cs:239
                    Id = "MessageHeader.destination",                                                                                       // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_Destination                                                                                                // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 7. MessageHeader.sender
                this.Element_Sender = new ElementDefinitionInfo                                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Sender",                                                                                                // MakerGen.cs:238
                    Path= "MessageHeader.sender",                                                                                           // MakerGen.cs:239
                    Id = "MessageHeader.sender",                                                                                            // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                     // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                                 // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/Organization"                                                      // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 8. MessageHeader.enterer
                this.Element_Enterer = new ElementDefinitionInfo                                                                            // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Enterer",                                                                                               // MakerGen.cs:238
                    Path= "MessageHeader.enterer",                                                                                          // MakerGen.cs:239
                    Id = "MessageHeader.enterer",                                                                                           // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                     // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                                                  // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 9. MessageHeader.author
                this.Element_Author = new ElementDefinitionInfo                                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Author",                                                                                                // MakerGen.cs:238
                    Path= "MessageHeader.author",                                                                                           // MakerGen.cs:239
                    Id = "MessageHeader.author",                                                                                            // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                     // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                                                  // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 10. MessageHeader.source
                this.Element_Source = new ElementDefinitionInfo                                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Source",                                                                                                // MakerGen.cs:238
                    Path= "MessageHeader.source",                                                                                           // MakerGen.cs:239
                    Id = "MessageHeader.source",                                                                                            // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_Source                                                                                                     // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 16. MessageHeader.responsible
                this.Element_Responsible = new ElementDefinitionInfo                                                                        // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Responsible",                                                                                           // MakerGen.cs:238
                    Path= "MessageHeader.responsible",                                                                                      // MakerGen.cs:239
                    Id = "MessageHeader.responsible",                                                                                       // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                     // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                                 // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/Organization"                                                      // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 17. MessageHeader.reason
                this.Element_Reason = new ElementDefinitionInfo                                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Reason",                                                                                                // MakerGen.cs:238
                    Path= "MessageHeader.reason",                                                                                           // MakerGen.cs:239
                    Id = "MessageHeader.reason",                                                                                            // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:322
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 18. MessageHeader.response
                this.Element_Response = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Response",                                                                                              // MakerGen.cs:238
                    Path= "MessageHeader.response",                                                                                         // MakerGen.cs:239
                    Id = "MessageHeader.response",                                                                                          // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_Response                                                                                                   // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 22. MessageHeader.focus
                this.Element_Focus = new ElementDefinitionInfo                                                                              // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Focus",                                                                                                 // MakerGen.cs:238
                    Path= "MessageHeader.focus",                                                                                            // MakerGen.cs:239
                    Id = "MessageHeader.focus",                                                                                             // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Resource"                                                          // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 23. MessageHeader.definition
                this.Element_Definition = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Definition",                                                                                            // MakerGen.cs:238
                    Path= "MessageHeader.definition",                                                                                       // MakerGen.cs:239
                    Id = "MessageHeader.definition",                                                                                        // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Canonical                                                             // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:306
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/MessageDefinition"                                                 // MakerGen.cs:306
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            this.Name = "MessageHeader";                                                                                                    // MakerGen.cs:471
            this.Uri = "http://hl7.org/fhir/StructureDefinition/MessageHeader";                                                             // MakerGen.cs:472
        }                                                                                                                                   // MakerGen.cs:405
    }                                                                                                                                       // MakerGen.cs:407
}                                                                                                                                           // MakerGen.cs:452
