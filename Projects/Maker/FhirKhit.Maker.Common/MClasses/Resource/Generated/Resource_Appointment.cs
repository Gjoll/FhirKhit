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
      "id": "Appointment",
      "url": "http://hl7.org/fhir/StructureDefinition/Appointment",
      "version": "4.0.0",
      "name": "Appointment",
      "status": "draft",
      "publisher": "Health Level Seven International (Patient Administration)",
      "description": "A booking of a healthcare event among patient(s), practitioner(s), related person(s) and/or device(s) for a specific date/time. This may result in one or more Encounter(s).",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "Appointment",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Appointment",
            "path": "Appointment",
            "short": "A booking of a healthcare event among patient(s), practitioner(s), related person(s) and/or device(s) for a specific date/time. This may result in one or more Encounter(s)",
            "definition": "A booking of a healthcare event among patient(s), practitioner(s), related person(s) and/or device(s) for a specific date/time. This may result in one or more Encounter(s).",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Appointment.identifier",
            "path": "Appointment.identifier",
            "short": "External Ids for this item",
            "definition": "This records identifiers associated with this appointment concern that are defined by business processes and/or used to refer to it when a direct URL reference to the resource itself is not appropriate (e.g. in CDA documents, or in written / printed documentation).",
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
            "id": "Appointment.status",
            "path": "Appointment.status",
            "short": "proposed | pending | booked | arrived | fulfilled | cancelled | noshow | entered-in-error | checked-in | waitlist",
            "definition": "The overall status of the Appointment. Each of the participants has their own participation status which indicates their involvement in the process, however this status indicates the shared status.",
            "comment": "If the Appointment's status is \"cancelled\" then all participants are expected to have their calendars released for the appointment period, and as such any Slots that were marked as BUSY can be re-set to FREE.\n\nThis element is labeled as a modifier because the status contains the code entered-in-error that mark the Appointment as not currently valid.",
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
                  "valueString": "AppointmentStatus"
                }
              ],
              "strength": "required",
              "description": "The free/busy status of an appointment.",
              "valueSet": "http://hl7.org/fhir/ValueSet/appointmentstatus|4.0.0"
            }
          },
          {
            "id": "Appointment.cancelationReason",
            "path": "Appointment.cancelationReason",
            "short": "The coded reason for the appointment being cancelled",
            "definition": "The coded reason for the appointment being cancelled. This is often used in reporting/billing/futher processing to determine if further actions are required, or specific fees apply.",
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
                  "valueString": "cancelation-reason"
                }
              ],
              "strength": "example",
              "valueSet": "http://hl7.org/fhir/ValueSet/appointment-cancellation-reason"
            }
          },
          {
            "id": "Appointment.serviceCategory",
            "path": "Appointment.serviceCategory",
            "short": "A broad categorization of the service that is to be performed during this appointment",
            "definition": "A broad categorization of the service that is to be performed during this appointment.",
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
                  "valueString": "service-category"
                }
              ],
              "strength": "example",
              "valueSet": "http://hl7.org/fhir/ValueSet/service-category"
            }
          },
          {
            "id": "Appointment.serviceType",
            "path": "Appointment.serviceType",
            "short": "The specific service that is to be performed during this appointment",
            "definition": "The specific service that is to be performed during this appointment.",
            "comment": "For a provider to provider appointment the code \"FOLLOWUP\" may be appropriate, as this is expected to be discussing some patient that was seen in the past.",
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
                  "valueString": "service-type"
                }
              ],
              "strength": "example",
              "valueSet": "http://hl7.org/fhir/ValueSet/service-type"
            }
          },
          {
            "id": "Appointment.specialty",
            "path": "Appointment.specialty",
            "short": "The specialty of a practitioner that would be required to perform the service requested in this appointment",
            "definition": "The specialty of a practitioner that would be required to perform the service requested in this appointment.",
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
                  "valueString": "specialty"
                }
              ],
              "strength": "preferred",
              "valueSet": "http://hl7.org/fhir/ValueSet/c80-practice-codes"
            }
          },
          {
            "id": "Appointment.appointmentType",
            "path": "Appointment.appointmentType",
            "short": "The style of appointment or patient that has been booked in the slot (not service type)",
            "definition": "The style of appointment or patient that has been booked in the slot (not service type).",
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
                  "valueString": "appointment-type"
                }
              ],
              "strength": "preferred",
              "valueSet": "http://terminology.hl7.org/ValueSet/v2-0276"
            }
          },
          {
            "id": "Appointment.reasonCode",
            "path": "Appointment.reasonCode",
            "short": "Coded reason this appointment is scheduled",
            "definition": "The coded reason that this appointment is being scheduled. This is more clinical than administrative.",
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
                  "valueString": "ApptReason"
                }
              ],
              "strength": "preferred",
              "description": "The Reason for the appointment to take place.",
              "valueSet": "http://hl7.org/fhir/ValueSet/encounter-reason"
            }
          },
          {
            "id": "Appointment.reasonReference",
            "path": "Appointment.reasonReference",
            "short": "Reason the appointment is to take place (resource)",
            "definition": "Reason the appointment has been scheduled to take place, as specified using information from another resource. When the patient arrives and the encounter begins it may be used as the admission diagnosis. The indication will typically be a Condition (with other resources referenced in the evidence.detail), or a Procedure.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Condition",
                  "http://hl7.org/fhir/StructureDefinition/Procedure",
                  "http://hl7.org/fhir/StructureDefinition/Observation",
                  "http://hl7.org/fhir/StructureDefinition/ImmunizationRecommendation"
                ]
              }
            ]
          },
          {
            "id": "Appointment.priority",
            "path": "Appointment.priority",
            "short": "Used to make informed decisions if needing to re-prioritize",
            "definition": "The priority of the appointment. Can be used to make informed decisions if needing to re-prioritize appointments. (The iCal Standard specifies 0 as undefined, 1 as highest, 9 as lowest priority).",
            "comment": "Seeking implementer feedback on this property and how interoperable it is.\r\rUsing an extension to record a CodeableConcept for named values may be tested at a future connectathon.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "unsignedInt"
              }
            ]
          },
          {
            "id": "Appointment.description",
            "path": "Appointment.description",
            "short": "Shown on a subject line in a meeting request, or appointment list",
            "definition": "The brief description of the appointment as would be shown on a subject line in a meeting request, or appointment list. Detailed or expanded information should be put in the comment field.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "Appointment.supportingInformation",
            "path": "Appointment.supportingInformation",
            "short": "Additional information to support the appointment",
            "definition": "Additional information to support the appointment provided when making the appointment.",
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
            "id": "Appointment.start",
            "path": "Appointment.start",
            "short": "When appointment is to take place",
            "definition": "Date/Time that the appointment is to take place.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "instant"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Appointment.end",
            "path": "Appointment.end",
            "short": "When appointment is to conclude",
            "definition": "Date/Time that the appointment is to conclude.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "instant"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Appointment.minutesDuration",
            "path": "Appointment.minutesDuration",
            "short": "Can be less than start/end (e.g. estimate)",
            "definition": "Number of minutes that the appointment is to take. This can be less than the duration between the start and end times.  For example, where the actual time of appointment is only an estimate or if a 30 minute appointment is being requested, but any time would work.  Also, if there is, for example, a planned 15 minute break in the middle of a long appointment, the duration may be 15 minutes less than the difference between the start and end.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "positiveInt"
              }
            ]
          },
          {
            "id": "Appointment.slot",
            "path": "Appointment.slot",
            "short": "The slots that this appointment is filling",
            "definition": "The slots from the participants' schedules that will be filled by the appointment.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Slot"
                ]
              }
            ]
          },
          {
            "id": "Appointment.created",
            "path": "Appointment.created",
            "short": "The date that this appointment was initially created",
            "definition": "The date that this appointment was initially created. This could be different to the meta.lastModified value on the initial entry, as this could have been before the resource was created on the FHIR server, and should remain unchanged over the lifespan of the appointment.",
            "comment": "This property is required for many use cases where the age of an appointment is considered in processing workflows for scheduling and billing of appointments.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ]
          },
          {
            "id": "Appointment.comment",
            "path": "Appointment.comment",
            "short": "Additional comments",
            "definition": "Additional comments about the appointment.",
            "comment": "Additional text to aid in facilitating the appointment. For instance, a comment might be, \"patient should proceed immediately to infusion room upon arrival\"\r\rWhere this is a planned appointment and the start/end dates are not set then this field can be used to provide additional guidance on the details of the appointment request, including any restrictions on when to book it.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "Appointment.patientInstruction",
            "path": "Appointment.patientInstruction",
            "short": "Detailed information and instructions for the patient",
            "definition": "While Appointment.comment contains information for internal use, Appointment.patientInstructions is used to capture patient facing information about the Appointment (e.g. please bring your referral or fast from 8pm night before).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "Appointment.basedOn",
            "path": "Appointment.basedOn",
            "short": "The service request this appointment is allocated to assess",
            "definition": "The service request this appointment is allocated to assess (e.g. incoming referral or procedure request).",
            "alias": [
              "incomingReferral"
            ],
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
            "id": "Appointment.participant",
            "path": "Appointment.participant",
            "short": "Participants involved in appointment",
            "definition": "List of participants involved in the appointment.",
            "min": 1,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Appointment.participant.type",
            "path": "Appointment.participant.type",
            "short": "Role of participant in the appointment",
            "definition": "Role of participant in the appointment.",
            "comment": "The role of the participant can be used to declare what the actor will be doing in the scope of this appointment.\r\rIf the actor is not specified, then it is expected that the actor will be filled in at a later stage of planning.\r\rThis value SHALL be the same when creating an AppointmentResponse so that they can be matched, and subsequently update the Appointment.",
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
                  "valueString": "ParticipantType"
                }
              ],
              "strength": "extensible",
              "description": "Role of participant in encounter.",
              "valueSet": "http://hl7.org/fhir/ValueSet/encounter-participant-type"
            }
          },
          {
            "id": "Appointment.participant.actor",
            "path": "Appointment.participant.actor",
            "short": "Person, Location/HealthcareService or Device",
            "definition": "A Person, Location/HealthcareService or Device that is participating in the appointment.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                  "http://hl7.org/fhir/StructureDefinition/Device",
                  "http://hl7.org/fhir/StructureDefinition/HealthcareService",
                  "http://hl7.org/fhir/StructureDefinition/Location"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Appointment.participant.required",
            "path": "Appointment.participant.required",
            "short": "required | optional | information-only",
            "definition": "Whether this participant is required to be present at the meeting. This covers a use-case where two doctors need to meet to discuss the results for a specific patient, and the patient is not required to be present.",
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
                  "valueString": "ParticipantRequired"
                }
              ],
              "strength": "required",
              "description": "Is the Participant required to attend the appointment.",
              "valueSet": "http://hl7.org/fhir/ValueSet/participantrequired|4.0.0"
            }
          },
          {
            "id": "Appointment.participant.status",
            "path": "Appointment.participant.status",
            "short": "accepted | declined | tentative | needs-action",
            "definition": "Participation status of the actor.",
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
                  "valueString": "ParticipationStatus"
                }
              ],
              "strength": "required",
              "description": "The Participation status of an appointment.",
              "valueSet": "http://hl7.org/fhir/ValueSet/participationstatus|4.0.0"
            }
          },
          {
            "id": "Appointment.participant.period",
            "path": "Appointment.participant.period",
            "short": "Participation period of the actor",
            "definition": "Participation period of the actor.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Period"
              }
            ]
          },
          {
            "id": "Appointment.requestedPeriod",
            "path": "Appointment.requestedPeriod",
            "short": "Potential date/time interval(s) requested to allocate the appointment within",
            "definition": "A set of date ranges (potentially including times) that the appointment is preferred to be scheduled within.\n\nThe duration (usually in minutes) could also be provided to indicate the length of the appointment to fill and populate the start/end times for the actual allocated time. However, in other situations the duration may be calculated by the scheduling system.",
            "comment": "This does not introduce a capacity for recurring appointments.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Period"
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:440
    /// <summary>
    /// Fhir resource 'Appointment'
    /// </summary>
    // 0. Appointment
    public class Resource_Appointment : FhirKhit.Maker.Common.Resource.ResourceBase                                                         // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        // 21. Appointment.participant
        public class Type_Participant : FhirKhit.Maker.Common.Complex.ComplexBase                                                           // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 22. Appointment.participant.type
            public ElementDefinitionInfo Element_Type;                                                                                      // MakerGen.cs:212
            // 23. Appointment.participant.actor
            public ElementDefinitionInfo Element_Actor;                                                                                     // MakerGen.cs:212
            // 24. Appointment.participant.required
            public ElementDefinitionInfo Element_Required;                                                                                  // MakerGen.cs:212
            // 25. Appointment.participant.status
            public ElementDefinitionInfo Element_Status;                                                                                    // MakerGen.cs:212
            // 26. Appointment.participant.period
            public ElementDefinitionInfo Element_Period;                                                                                    // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "Appointment.participant",                                                                                       // MakerGen.cs:388
                    ElementId = "Appointment.participant"                                                                                   // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Type.Write(sDef);                                                                                                   // MakerGen.cs:216
                Element_Actor.Write(sDef);                                                                                                  // MakerGen.cs:216
                Element_Required.Write(sDef);                                                                                               // MakerGen.cs:216
                Element_Status.Write(sDef);                                                                                                 // MakerGen.cs:216
                Element_Period.Write(sDef);                                                                                                 // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_Participant()                                                                                                       // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 22. Appointment.participant.type
                    this.Element_Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Type",                                                                                              // MakerGen.cs:231
                        Path= "Appointment.participant.type",                                                                               // MakerGen.cs:232
                        Id = "Appointment.participant.type",                                                                                // MakerGen.cs:233
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
                    // 23. Appointment.participant.actor
                    this.Element_Actor = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Actor",                                                                                             // MakerGen.cs:231
                        Path= "Appointment.participant.actor",                                                                              // MakerGen.cs:232
                        Id = "Appointment.participant.actor",                                                                               // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:339
                            {                                                                                                               // MakerGen.cs:340
                                TargetProfile = new String[]                                                                                // MakerGen.cs:342
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:342
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:342
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:342
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson",                                                // MakerGen.cs:342
                                    "http://hl7.org/fhir/StructureDefinition/Device",                                                       // MakerGen.cs:342
                                    "http://hl7.org/fhir/StructureDefinition/HealthcareService",                                            // MakerGen.cs:342
                                    "http://hl7.org/fhir/StructureDefinition/Location"                                                      // MakerGen.cs:342
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:343
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 24. Appointment.participant.required
                    this.Element_Required = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Required",                                                                                          // MakerGen.cs:231
                        Path= "Appointment.participant.required",                                                                           // MakerGen.cs:232
                        Id = "Appointment.participant.required",                                                                            // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
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
                    // 25. Appointment.participant.status
                    this.Element_Status = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Status",                                                                                            // MakerGen.cs:231
                        Path= "Appointment.participant.status",                                                                             // MakerGen.cs:232
                        Id = "Appointment.participant.status",                                                                              // MakerGen.cs:233
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
                    // 26. Appointment.participant.period
                    this.Element_Period = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Period",                                                                                            // MakerGen.cs:231
                        Path= "Appointment.participant.period",                                                                             // MakerGen.cs:232
                        Id = "Appointment.participant.period",                                                                              // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Period                                                                   // MakerGen.cs:351
                            {                                                                                                               // MakerGen.cs:352
                            }                                                                                                               // MakerGen.cs:353
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 1. Appointment.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:212
        // 2. Appointment.status
        public ElementDefinitionInfo Element_Status;                                                                                        // MakerGen.cs:212
        // 3. Appointment.cancelationReason
        public ElementDefinitionInfo Element_CancelationReason;                                                                             // MakerGen.cs:212
        // 4. Appointment.serviceCategory
        public ElementDefinitionInfo Element_ServiceCategory;                                                                               // MakerGen.cs:212
        // 5. Appointment.serviceType
        public ElementDefinitionInfo Element_ServiceType;                                                                                   // MakerGen.cs:212
        // 6. Appointment.specialty
        public ElementDefinitionInfo Element_Specialty;                                                                                     // MakerGen.cs:212
        // 7. Appointment.appointmentType
        public ElementDefinitionInfo Element_AppointmentType;                                                                               // MakerGen.cs:212
        // 8. Appointment.reasonCode
        public ElementDefinitionInfo Element_ReasonCode;                                                                                    // MakerGen.cs:212
        // 9. Appointment.reasonReference
        public ElementDefinitionInfo Element_ReasonReference;                                                                               // MakerGen.cs:212
        // 10. Appointment.priority
        public ElementDefinitionInfo Element_Priority;                                                                                      // MakerGen.cs:212
        // 11. Appointment.description
        public ElementDefinitionInfo Element_Description;                                                                                   // MakerGen.cs:212
        // 12. Appointment.supportingInformation
        public ElementDefinitionInfo Element_SupportingInformation;                                                                         // MakerGen.cs:212
        // 13. Appointment.start
        public ElementDefinitionInfo Element_Start;                                                                                         // MakerGen.cs:212
        // 14. Appointment.end
        public ElementDefinitionInfo Element_End;                                                                                           // MakerGen.cs:212
        // 15. Appointment.minutesDuration
        public ElementDefinitionInfo Element_MinutesDuration;                                                                               // MakerGen.cs:212
        // 16. Appointment.slot
        public ElementDefinitionInfo Element_Slot;                                                                                          // MakerGen.cs:212
        // 17. Appointment.created
        public ElementDefinitionInfo Element_Created;                                                                                       // MakerGen.cs:212
        // 18. Appointment.comment
        public ElementDefinitionInfo Element_Comment;                                                                                       // MakerGen.cs:212
        // 19. Appointment.patientInstruction
        public ElementDefinitionInfo Element_PatientInstruction;                                                                            // MakerGen.cs:212
        // 20. Appointment.basedOn
        public ElementDefinitionInfo Element_BasedOn;                                                                                       // MakerGen.cs:212
        // 21. Appointment.participant
        public ElementDefinitionInfo Element_Participant;                                                                                   // MakerGen.cs:212
        // 27. Appointment.requestedPeriod
        public ElementDefinitionInfo Element_RequestedPeriod;                                                                               // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            base.Write(sDef);                                                                                                               // MakerGen.cs:385
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:386
            {                                                                                                                               // MakerGen.cs:387
                Path = "Appointment",                                                                                                       // MakerGen.cs:388
                ElementId = "Appointment"                                                                                                   // MakerGen.cs:389
            });                                                                                                                             // MakerGen.cs:390
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_Status.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_CancelationReason.Write(sDef);                                                                                          // MakerGen.cs:216
            Element_ServiceCategory.Write(sDef);                                                                                            // MakerGen.cs:216
            Element_ServiceType.Write(sDef);                                                                                                // MakerGen.cs:216
            Element_Specialty.Write(sDef);                                                                                                  // MakerGen.cs:216
            Element_AppointmentType.Write(sDef);                                                                                            // MakerGen.cs:216
            Element_ReasonCode.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_ReasonReference.Write(sDef);                                                                                            // MakerGen.cs:216
            Element_Priority.Write(sDef);                                                                                                   // MakerGen.cs:216
            Element_Description.Write(sDef);                                                                                                // MakerGen.cs:216
            Element_SupportingInformation.Write(sDef);                                                                                      // MakerGen.cs:216
            Element_Start.Write(sDef);                                                                                                      // MakerGen.cs:216
            Element_End.Write(sDef);                                                                                                        // MakerGen.cs:216
            Element_MinutesDuration.Write(sDef);                                                                                            // MakerGen.cs:216
            Element_Slot.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_Created.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_Comment.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_PatientInstruction.Write(sDef);                                                                                         // MakerGen.cs:216
            Element_BasedOn.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_Participant.Write(sDef);                                                                                                // MakerGen.cs:216
            Element_RequestedPeriod.Write(sDef);                                                                                            // MakerGen.cs:216
        }                                                                                                                                   // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
        public Resource_Appointment()                                                                                                       // MakerGen.cs:395
        {                                                                                                                                   // MakerGen.cs:396
            {                                                                                                                               // MakerGen.cs:227
                // 1. Appointment.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:231
                    Path= "Appointment.identifier",                                                                                         // MakerGen.cs:232
                    Id = "Appointment.identifier",                                                                                          // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Identifier                                                                   // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 2. Appointment.status
                this.Element_Status = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Status",                                                                                                // MakerGen.cs:231
                    Path= "Appointment.status",                                                                                             // MakerGen.cs:232
                    Id = "Appointment.status",                                                                                              // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 3. Appointment.cancelationReason
                this.Element_CancelationReason = new ElementDefinitionInfo                                                                  // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_CancelationReason",                                                                                     // MakerGen.cs:231
                    Path= "Appointment.cancelationReason",                                                                                  // MakerGen.cs:232
                    Id = "Appointment.cancelationReason",                                                                                   // MakerGen.cs:233
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
                // 4. Appointment.serviceCategory
                this.Element_ServiceCategory = new ElementDefinitionInfo                                                                    // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_ServiceCategory",                                                                                       // MakerGen.cs:231
                    Path= "Appointment.serviceCategory",                                                                                    // MakerGen.cs:232
                    Id = "Appointment.serviceCategory",                                                                                     // MakerGen.cs:233
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
                // 5. Appointment.serviceType
                this.Element_ServiceType = new ElementDefinitionInfo                                                                        // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_ServiceType",                                                                                           // MakerGen.cs:231
                    Path= "Appointment.serviceType",                                                                                        // MakerGen.cs:232
                    Id = "Appointment.serviceType",                                                                                         // MakerGen.cs:233
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
                // 6. Appointment.specialty
                this.Element_Specialty = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Specialty",                                                                                             // MakerGen.cs:231
                    Path= "Appointment.specialty",                                                                                          // MakerGen.cs:232
                    Id = "Appointment.specialty",                                                                                           // MakerGen.cs:233
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
                // 7. Appointment.appointmentType
                this.Element_AppointmentType = new ElementDefinitionInfo                                                                    // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_AppointmentType",                                                                                       // MakerGen.cs:231
                    Path= "Appointment.appointmentType",                                                                                    // MakerGen.cs:232
                    Id = "Appointment.appointmentType",                                                                                     // MakerGen.cs:233
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
                // 8. Appointment.reasonCode
                this.Element_ReasonCode = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_ReasonCode",                                                                                            // MakerGen.cs:231
                    Path= "Appointment.reasonCode",                                                                                         // MakerGen.cs:232
                    Id = "Appointment.reasonCode",                                                                                          // MakerGen.cs:233
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
                // 9. Appointment.reasonReference
                this.Element_ReasonReference = new ElementDefinitionInfo                                                                    // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_ReasonReference",                                                                                       // MakerGen.cs:231
                    Path= "Appointment.reasonReference",                                                                                    // MakerGen.cs:232
                    Id = "Appointment.reasonReference",                                                                                     // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Condition",                                                        // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Procedure",                                                        // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Observation",                                                      // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/ImmunizationRecommendation"                                        // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 10. Appointment.priority
                this.Element_Priority = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Priority",                                                                                              // MakerGen.cs:231
                    Path= "Appointment.priority",                                                                                           // MakerGen.cs:232
                    Id = "Appointment.priority",                                                                                            // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_UnsignedInt                                                           // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 11. Appointment.description
                this.Element_Description = new ElementDefinitionInfo                                                                        // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Description",                                                                                           // MakerGen.cs:231
                    Path= "Appointment.description",                                                                                        // MakerGen.cs:232
                    Id = "Appointment.description",                                                                                         // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 12. Appointment.supportingInformation
                this.Element_SupportingInformation = new ElementDefinitionInfo                                                              // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_SupportingInformation",                                                                                 // MakerGen.cs:231
                    Path= "Appointment.supportingInformation",                                                                              // MakerGen.cs:232
                    Id = "Appointment.supportingInformation",                                                                               // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
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
                // 13. Appointment.start
                this.Element_Start = new ElementDefinitionInfo                                                                              // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Start",                                                                                                 // MakerGen.cs:231
                    Path= "Appointment.start",                                                                                              // MakerGen.cs:232
                    Id = "Appointment.start",                                                                                               // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
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
                // 14. Appointment.end
                this.Element_End = new ElementDefinitionInfo                                                                                // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_End",                                                                                                   // MakerGen.cs:231
                    Path= "Appointment.end",                                                                                                // MakerGen.cs:232
                    Id = "Appointment.end",                                                                                                 // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
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
                // 15. Appointment.minutesDuration
                this.Element_MinutesDuration = new ElementDefinitionInfo                                                                    // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_MinutesDuration",                                                                                       // MakerGen.cs:231
                    Path= "Appointment.minutesDuration",                                                                                    // MakerGen.cs:232
                    Id = "Appointment.minutesDuration",                                                                                     // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_PositiveInt                                                           // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 16. Appointment.slot
                this.Element_Slot = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Slot",                                                                                                  // MakerGen.cs:231
                    Path= "Appointment.slot",                                                                                               // MakerGen.cs:232
                    Id = "Appointment.slot",                                                                                                // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Slot"                                                              // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 17. Appointment.created
                this.Element_Created = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Created",                                                                                               // MakerGen.cs:231
                    Path= "Appointment.created",                                                                                            // MakerGen.cs:232
                    Id = "Appointment.created",                                                                                             // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                              // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 18. Appointment.comment
                this.Element_Comment = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Comment",                                                                                               // MakerGen.cs:231
                    Path= "Appointment.comment",                                                                                            // MakerGen.cs:232
                    Id = "Appointment.comment",                                                                                             // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 19. Appointment.patientInstruction
                this.Element_PatientInstruction = new ElementDefinitionInfo                                                                 // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_PatientInstruction",                                                                                    // MakerGen.cs:231
                    Path= "Appointment.patientInstruction",                                                                                 // MakerGen.cs:232
                    Id = "Appointment.patientInstruction",                                                                                  // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 20. Appointment.basedOn
                this.Element_BasedOn = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_BasedOn",                                                                                               // MakerGen.cs:231
                    Path= "Appointment.basedOn",                                                                                            // MakerGen.cs:232
                    Id = "Appointment.basedOn",                                                                                             // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/ServiceRequest"                                                    // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 21. Appointment.participant
                this.Element_Participant = new ElementDefinitionInfo                                                                        // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Participant",                                                                                           // MakerGen.cs:231
                    Path= "Appointment.participant",                                                                                        // MakerGen.cs:232
                    Id = "Appointment.participant",                                                                                         // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_Participant                                                                                                // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 27. Appointment.requestedPeriod
                this.Element_RequestedPeriod = new ElementDefinitionInfo                                                                    // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_RequestedPeriod",                                                                                       // MakerGen.cs:231
                    Path= "Appointment.requestedPeriod",                                                                                    // MakerGen.cs:232
                    Id = "Appointment.requestedPeriod",                                                                                     // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Period                                                                       // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            this.Name = "Appointment";                                                                                                      // MakerGen.cs:458
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Appointment";                                                               // MakerGen.cs:459
        }                                                                                                                                   // MakerGen.cs:398
    }                                                                                                                                       // MakerGen.cs:400
}                                                                                                                                           // MakerGen.cs:445
