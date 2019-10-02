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
      "id": "Communication",
      "url": "http://hl7.org/fhir/StructureDefinition/Communication",
      "version": "4.0.0",
      "name": "Communication",
      "status": "draft",
      "publisher": "Health Level Seven International (Patient Care)",
      "description": "An occurrence of information being transmitted; e.g. an alert that was sent to a responsible provider, a public health agency that was notified about a reportable condition.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "Communication",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Communication",
            "path": "Communication",
            "short": "A record of information transmitted from a sender to a receiver",
            "definition": "An occurrence of information being transmitted; e.g. an alert that was sent to a responsible provider, a public health agency that was notified about a reportable condition.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Communication.identifier",
            "path": "Communication.identifier",
            "short": "Unique identifier",
            "definition": "Business identifiers assigned to this communication by the performer or other systems which remain constant as the resource is updated and propagates from server to server.",
            "comment": "This is a business identifier, not a resource identifier (see [discussion](resource.html#identifiers)).  It is best practice for the identifier to only appear on a single resource instance, however business practices may occasionally dictate that multiple resource instances with the same identifier can exist - possibly even with different resource types.  For example, multiple Patient and a Person resource instance might share the same social insurance number.",
            "requirements": "Allows identification of the communication as it is known by various participating systems and in a way that remains consistent across servers.",
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
            "id": "Communication.instantiatesCanonical",
            "path": "Communication.instantiatesCanonical",
            "short": "Instantiates FHIR protocol or definition",
            "definition": "The URL pointing to a FHIR-defined protocol, guideline, orderset or other definition that is adhered to in whole or in part by this Communication.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/PlanDefinition",
                  "http://hl7.org/fhir/StructureDefinition/ActivityDefinition",
                  "http://hl7.org/fhir/StructureDefinition/Measure",
                  "http://hl7.org/fhir/StructureDefinition/OperationDefinition",
                  "http://hl7.org/fhir/StructureDefinition/Questionnaire"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Communication.instantiatesUri",
            "path": "Communication.instantiatesUri",
            "short": "Instantiates external protocol or definition",
            "definition": "The URL pointing to an externally maintained protocol, guideline, orderset or other definition that is adhered to in whole or in part by this Communication.",
            "comment": "This might be an HTML page, PDF, etc. or could just be a non-resolvable URI identifier.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "uri"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Communication.basedOn",
            "path": "Communication.basedOn",
            "short": "Request fulfilled by this communication",
            "definition": "An order, proposal or plan fulfilled in whole or in part by this Communication.",
            "comment": "This must point to some sort of a 'Request' resource, such as CarePlan, CommunicationRequest, ServiceRequest, MedicationRequest, etc.",
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
            "id": "Communication.partOf",
            "path": "Communication.partOf",
            "short": "Part of this action",
            "definition": "Part of this action.",
            "alias": [
              "container"
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
            "id": "Communication.inResponseTo",
            "path": "Communication.inResponseTo",
            "short": "Reply to",
            "definition": "Prior communication that this communication is in response to.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Communication"
                ]
              }
            ]
          },
          {
            "id": "Communication.status",
            "path": "Communication.status",
            "short": "preparation | in-progress | not-done | suspended | aborted | completed | entered-in-error",
            "definition": "The status of the transmission.",
            "comment": "This element is labeled as a modifier because the status contains the codes aborted and entered-in-error that mark the communication as not currently valid.",
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
                  "valueString": "CommunicationStatus"
                }
              ],
              "strength": "required",
              "description": "The status of the communication.",
              "valueSet": "http://hl7.org/fhir/ValueSet/event-status|4.0.0"
            }
          },
          {
            "id": "Communication.statusReason",
            "path": "Communication.statusReason",
            "short": "Reason for current status",
            "definition": "Captures the reason for the current state of the Communication.",
            "comment": "This is generally only used for \"exception\" statuses such as \"not-done\", \"suspended\" or \"aborted\". The reason for performing the event at all is captured in reasonCode, not here.",
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
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "CommunicationNotDoneReason"
                }
              ],
              "strength": "example",
              "description": "Codes for the reason why a communication did not happen.",
              "valueSet": "http://hl7.org/fhir/ValueSet/communication-not-done-reason"
            }
          },
          {
            "id": "Communication.category",
            "path": "Communication.category",
            "short": "Message category",
            "definition": "The type of message conveyed such as alert, notification, reminder, instruction, etc.",
            "comment": "There may be multiple axes of categorization and one communication may serve multiple purposes.",
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
              "description": "Codes for general categories of communications such as alerts, instructions, etc.",
              "valueSet": "http://hl7.org/fhir/ValueSet/communication-category"
            }
          },
          {
            "id": "Communication.priority",
            "path": "Communication.priority",
            "short": "Message urgency",
            "definition": "Characterizes how quickly the planned or in progress communication must be addressed. Includes concepts such as stat, urgent, routine.",
            "comment": "Used to prioritize workflow (such as which communication to read first) when the communication is planned or in progress.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "meaningWhenMissing": "If missing, this communication should be treated with normal priority",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "CommunicationPriority"
                }
              ],
              "strength": "required",
              "description": "Codes indicating the relative importance of a communication.",
              "valueSet": "http://hl7.org/fhir/ValueSet/request-priority|4.0.0"
            }
          },
          {
            "id": "Communication.medium",
            "path": "Communication.medium",
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
            "id": "Communication.subject",
            "path": "Communication.subject",
            "short": "Focus of message",
            "definition": "The patient or group that was the focus of this communication.",
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
            "id": "Communication.topic",
            "path": "Communication.topic",
            "short": "Description of the purpose/content",
            "definition": "Description of the purpose/content, similar to a subject line in an email.",
            "comment": "Communication.topic.text can be used without any codings.",
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
                  "valueString": "CommunicationTopic"
                }
              ],
              "strength": "example",
              "description": "Codes describing the purpose or content of the communication.",
              "valueSet": "http://hl7.org/fhir/ValueSet/communication-topic"
            }
          },
          {
            "id": "Communication.about",
            "path": "Communication.about",
            "short": "Resources that pertain to this communication",
            "definition": "Other resources that pertain to this communication and to which this communication should be associated.",
            "comment": "Don't use Communication.about element when a more specific element exists, such as basedOn or reasonReference.",
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
            "id": "Communication.encounter",
            "path": "Communication.encounter",
            "short": "Encounter created as part of",
            "definition": "The Encounter during which this Communication was created or to which the creation of this record is tightly associated.",
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
            "id": "Communication.sent",
            "path": "Communication.sent",
            "short": "When sent",
            "definition": "The time when this communication was sent.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ]
          },
          {
            "id": "Communication.received",
            "path": "Communication.received",
            "short": "When received",
            "definition": "The time when this communication arrived at the destination.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ]
          },
          {
            "id": "Communication.recipient",
            "path": "Communication.recipient",
            "short": "Message recipient",
            "definition": "The entity (e.g. person, organization, clinical information system, care team or device) which was the target of the communication. If receipts need to be tracked by an individual, a separate resource instance will need to be created for each recipient.  Multiple recipient communications are intended where either receipts are not tracked (e.g. a mass mail-out) or a receipt is captured in aggregate (all emails confirmed received by a particular time).",
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
            "id": "Communication.sender",
            "path": "Communication.sender",
            "short": "Message sender",
            "definition": "The entity (e.g. person, organization, clinical information system, or device) which was the source of the communication.",
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
            ]
          },
          {
            "id": "Communication.reasonCode",
            "path": "Communication.reasonCode",
            "short": "Indication for message",
            "definition": "The reason or justification for the communication.",
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
              "valueSet": "http://hl7.org/fhir/ValueSet/clinical-findings"
            }
          },
          {
            "id": "Communication.reasonReference",
            "path": "Communication.reasonReference",
            "short": "Why was communication done?",
            "definition": "Indicates another resource whose existence justifies this communication.",
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
            "id": "Communication.payload",
            "path": "Communication.payload",
            "short": "Message payload",
            "definition": "Text, attachment(s), or resource(s) that was communicated to the recipient.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Communication.payload.content[x]",
            "path": "Communication.payload.content[x]",
            "short": "Message part content",
            "definition": "A communicated content (or for multi-part communications, one portion of the communication).",
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
            "id": "Communication.note",
            "path": "Communication.note",
            "short": "Comments made about the communication",
            "definition": "Additional notes or commentary about the communication by the sender, receiver or other interested parties.",
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
    /// Fhir resource 'Communication'
    /// </summary>
    // 0. Communication
    public partial class Resource_Communication : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 22. Communication.payload
        public partial class Type_Payload : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 23. Communication.payload.content[x]
            public ElementDefinitionInfo Element_Content;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Communication.payload",
                    ElementId = "Communication.payload"
                });
                Element_Content.Write(sDef);
            }
            
            public Type_Payload()
            {
                {
                    // 23. Communication.payload.content[x]
                    this.Element_Content = new ElementDefinitionInfo
                    {
                        Name = "Element_Content",
                        Path= "Communication.payload.content[x]",
                        Id = "Communication.payload.content[x]",
                        Min = 1,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_String
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Attachment
                            {
                            },
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
            }
        }
        // 1. Communication.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. Communication.instantiatesCanonical
        public ElementDefinitionInfo Element_InstantiatesCanonical;
        // 3. Communication.instantiatesUri
        public ElementDefinitionInfo Element_InstantiatesUri;
        // 4. Communication.basedOn
        public ElementDefinitionInfo Element_BasedOn;
        // 5. Communication.partOf
        public ElementDefinitionInfo Element_PartOf;
        // 6. Communication.inResponseTo
        public ElementDefinitionInfo Element_InResponseTo;
        // 7. Communication.status
        public ElementDefinitionInfo Element_Status;
        // 8. Communication.statusReason
        public ElementDefinitionInfo Element_StatusReason;
        // 9. Communication.category
        public ElementDefinitionInfo Element_Category;
        // 10. Communication.priority
        public ElementDefinitionInfo Element_Priority;
        // 11. Communication.medium
        public ElementDefinitionInfo Element_Medium;
        // 12. Communication.subject
        public ElementDefinitionInfo Element_Subject;
        // 13. Communication.topic
        public ElementDefinitionInfo Element_Topic;
        // 14. Communication.about
        public ElementDefinitionInfo Element_About;
        // 15. Communication.encounter
        public ElementDefinitionInfo Element_Encounter;
        // 16. Communication.sent
        public ElementDefinitionInfo Element_Sent;
        // 17. Communication.received
        public ElementDefinitionInfo Element_Received;
        // 18. Communication.recipient
        public ElementDefinitionInfo Element_Recipient;
        // 19. Communication.sender
        public ElementDefinitionInfo Element_Sender;
        // 20. Communication.reasonCode
        public ElementDefinitionInfo Element_ReasonCode;
        // 21. Communication.reasonReference
        public ElementDefinitionInfo Element_ReasonReference;
        // 22. Communication.payload
        public ElementDefinitionInfo Element_Payload;
        // 24. Communication.note
        public ElementDefinitionInfo Element_Note;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "Communication",
                ElementId = "Communication"
            });
            Element_Identifier.Write(sDef);
            Element_InstantiatesCanonical.Write(sDef);
            Element_InstantiatesUri.Write(sDef);
            Element_BasedOn.Write(sDef);
            Element_PartOf.Write(sDef);
            Element_InResponseTo.Write(sDef);
            Element_Status.Write(sDef);
            Element_StatusReason.Write(sDef);
            Element_Category.Write(sDef);
            Element_Priority.Write(sDef);
            Element_Medium.Write(sDef);
            Element_Subject.Write(sDef);
            Element_Topic.Write(sDef);
            Element_About.Write(sDef);
            Element_Encounter.Write(sDef);
            Element_Sent.Write(sDef);
            Element_Received.Write(sDef);
            Element_Recipient.Write(sDef);
            Element_Sender.Write(sDef);
            Element_ReasonCode.Write(sDef);
            Element_ReasonReference.Write(sDef);
            Element_Payload.Write(sDef);
            Element_Note.Write(sDef);
        }
        
        public Resource_Communication()
        {
            {
                // 1. Communication.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "Communication.identifier",
                    Id = "Communication.identifier",
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
                // 2. Communication.instantiatesCanonical
                this.Element_InstantiatesCanonical = new ElementDefinitionInfo
                {
                    Name = "Element_InstantiatesCanonical",
                    Path= "Communication.instantiatesCanonical",
                    Id = "Communication.instantiatesCanonical",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Canonical
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/PlanDefinition",
                                "http://hl7.org/fhir/StructureDefinition/ActivityDefinition",
                                "http://hl7.org/fhir/StructureDefinition/Measure",
                                "http://hl7.org/fhir/StructureDefinition/OperationDefinition",
                                "http://hl7.org/fhir/StructureDefinition/Questionnaire"
                            }
                        }
                    }
                };
            }
            {
                // 3. Communication.instantiatesUri
                this.Element_InstantiatesUri = new ElementDefinitionInfo
                {
                    Name = "Element_InstantiatesUri",
                    Path= "Communication.instantiatesUri",
                    Id = "Communication.instantiatesUri",
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
                // 4. Communication.basedOn
                this.Element_BasedOn = new ElementDefinitionInfo
                {
                    Name = "Element_BasedOn",
                    Path= "Communication.basedOn",
                    Id = "Communication.basedOn",
                    Min = 0,
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
                // 5. Communication.partOf
                this.Element_PartOf = new ElementDefinitionInfo
                {
                    Name = "Element_PartOf",
                    Path= "Communication.partOf",
                    Id = "Communication.partOf",
                    Min = 0,
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
                // 6. Communication.inResponseTo
                this.Element_InResponseTo = new ElementDefinitionInfo
                {
                    Name = "Element_InResponseTo",
                    Path= "Communication.inResponseTo",
                    Id = "Communication.inResponseTo",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Communication"
                            }
                        }
                    }
                };
            }
            {
                // 7. Communication.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "Communication.status",
                    Id = "Communication.status",
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
                // 8. Communication.statusReason
                this.Element_StatusReason = new ElementDefinitionInfo
                {
                    Name = "Element_StatusReason",
                    Path= "Communication.statusReason",
                    Id = "Communication.statusReason",
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
                // 9. Communication.category
                this.Element_Category = new ElementDefinitionInfo
                {
                    Name = "Element_Category",
                    Path= "Communication.category",
                    Id = "Communication.category",
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
                // 10. Communication.priority
                this.Element_Priority = new ElementDefinitionInfo
                {
                    Name = "Element_Priority",
                    Path= "Communication.priority",
                    Id = "Communication.priority",
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
                // 11. Communication.medium
                this.Element_Medium = new ElementDefinitionInfo
                {
                    Name = "Element_Medium",
                    Path= "Communication.medium",
                    Id = "Communication.medium",
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
                // 12. Communication.subject
                this.Element_Subject = new ElementDefinitionInfo
                {
                    Name = "Element_Subject",
                    Path= "Communication.subject",
                    Id = "Communication.subject",
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
                // 13. Communication.topic
                this.Element_Topic = new ElementDefinitionInfo
                {
                    Name = "Element_Topic",
                    Path= "Communication.topic",
                    Id = "Communication.topic",
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
                // 14. Communication.about
                this.Element_About = new ElementDefinitionInfo
                {
                    Name = "Element_About",
                    Path= "Communication.about",
                    Id = "Communication.about",
                    Min = 0,
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
                // 15. Communication.encounter
                this.Element_Encounter = new ElementDefinitionInfo
                {
                    Name = "Element_Encounter",
                    Path= "Communication.encounter",
                    Id = "Communication.encounter",
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
                // 16. Communication.sent
                this.Element_Sent = new ElementDefinitionInfo
                {
                    Name = "Element_Sent",
                    Path= "Communication.sent",
                    Id = "Communication.sent",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime
                        {
                        }
                    }
                };
            }
            {
                // 17. Communication.received
                this.Element_Received = new ElementDefinitionInfo
                {
                    Name = "Element_Received",
                    Path= "Communication.received",
                    Id = "Communication.received",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime
                        {
                        }
                    }
                };
            }
            {
                // 18. Communication.recipient
                this.Element_Recipient = new ElementDefinitionInfo
                {
                    Name = "Element_Recipient",
                    Path= "Communication.recipient",
                    Id = "Communication.recipient",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Device",
                                "http://hl7.org/fhir/StructureDefinition/Organization",
                                "http://hl7.org/fhir/StructureDefinition/Patient",
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                                "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                                "http://hl7.org/fhir/StructureDefinition/Group",
                                "http://hl7.org/fhir/StructureDefinition/CareTeam",
                                "http://hl7.org/fhir/StructureDefinition/HealthcareService"
                            }
                        }
                    }
                };
            }
            {
                // 19. Communication.sender
                this.Element_Sender = new ElementDefinitionInfo
                {
                    Name = "Element_Sender",
                    Path= "Communication.sender",
                    Id = "Communication.sender",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Device",
                                "http://hl7.org/fhir/StructureDefinition/Organization",
                                "http://hl7.org/fhir/StructureDefinition/Patient",
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                                "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                                "http://hl7.org/fhir/StructureDefinition/HealthcareService"
                            }
                        }
                    }
                };
            }
            {
                // 20. Communication.reasonCode
                this.Element_ReasonCode = new ElementDefinitionInfo
                {
                    Name = "Element_ReasonCode",
                    Path= "Communication.reasonCode",
                    Id = "Communication.reasonCode",
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
                // 21. Communication.reasonReference
                this.Element_ReasonReference = new ElementDefinitionInfo
                {
                    Name = "Element_ReasonReference",
                    Path= "Communication.reasonReference",
                    Id = "Communication.reasonReference",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Condition",
                                "http://hl7.org/fhir/StructureDefinition/Observation",
                                "http://hl7.org/fhir/StructureDefinition/DiagnosticReport",
                                "http://hl7.org/fhir/StructureDefinition/DocumentReference"
                            }
                        }
                    }
                };
            }
            {
                // 22. Communication.payload
                this.Element_Payload = new ElementDefinitionInfo
                {
                    Name = "Element_Payload",
                    Path= "Communication.payload",
                    Id = "Communication.payload",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Payload
                        {
                        }
                    }
                };
            }
            {
                // 24. Communication.note
                this.Element_Note = new ElementDefinitionInfo
                {
                    Name = "Element_Note",
                    Path= "Communication.note",
                    Id = "Communication.note",
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
            this.Name = "Communication";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Communication";
        }
    }
}
