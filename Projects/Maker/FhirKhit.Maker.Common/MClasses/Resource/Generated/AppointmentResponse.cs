using System;                                                                                                                               // MakerGen.cs:391
using System.Diagnostics;                                                                                                                   // MakerGen.cs:392
using System.IO;                                                                                                                            // MakerGen.cs:393
using System.Linq;                                                                                                                          // MakerGen.cs:394
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:396
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:397
{                                                                                                                                           // MakerGen.cs:398
    #region Json                                                                                                                            // MakerGen.cs:399
    #if NEVER                                                                                                                               // MakerGen.cs:400
    {
      "resourceType": "StructureDefinition",
      "id": "AppointmentResponse",
      "url": "http://hl7.org/fhir/StructureDefinition/AppointmentResponse",
      "version": "4.0.0",
      "name": "AppointmentResponse",
      "status": "draft",
      "publisher": "Health Level Seven International (Patient Administration)",
      "description": "A reply to an appointment request for a patient and/or practitioner(s), such as a confirmation or rejection.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "AppointmentResponse",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "AppointmentResponse",
            "path": "AppointmentResponse",
            "short": "A reply to an appointment request for a patient and/or practitioner(s), such as a confirmation or rejection",
            "definition": "A reply to an appointment request for a patient and/or practitioner(s), such as a confirmation or rejection.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "AppointmentResponse.identifier",
            "path": "AppointmentResponse.identifier",
            "short": "External Ids for this item",
            "definition": "This records identifiers associated with this appointment response concern that are defined by business processes and/ or used to refer to it when a direct URL reference to the resource itself is not appropriate.",
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
            "id": "AppointmentResponse.appointment",
            "path": "AppointmentResponse.appointment",
            "short": "Appointment this response relates to",
            "definition": "Appointment that this response is replying to.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Appointment"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "AppointmentResponse.start",
            "path": "AppointmentResponse.start",
            "short": "Time from appointment, or requested new start time",
            "definition": "Date/Time that the appointment is to take place, or requested new start time.",
            "comment": "This may be either the same as the appointment request to confirm the details of the appointment, or alternately a new time to request a re-negotiation of the start time.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "instant"
              }
            ]
          },
          {
            "id": "AppointmentResponse.end",
            "path": "AppointmentResponse.end",
            "short": "Time from appointment, or requested new end time",
            "definition": "This may be either the same as the appointment request to confirm the details of the appointment, or alternately a new time to request a re-negotiation of the end time.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "instant"
              }
            ]
          },
          {
            "id": "AppointmentResponse.participantType",
            "path": "AppointmentResponse.participantType",
            "short": "Role of participant in the appointment",
            "definition": "Role of participant in the appointment.",
            "comment": "The role of the participant can be used to declare what the actor will be doing in the scope of the referenced appointment.\r\rIf the actor is not specified, then it is expected that the actor will be filled in at a later stage of planning.\r\rThis value SHALL be the same as specified on the referenced Appointment so that they can be matched, and subsequently updated.",
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
            "id": "AppointmentResponse.actor",
            "path": "AppointmentResponse.actor",
            "short": "Person, Location, HealthcareService, or Device",
            "definition": "A Person, Location, HealthcareService, or Device that is participating in the appointment.",
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
            "id": "AppointmentResponse.participantStatus",
            "path": "AppointmentResponse.participantStatus",
            "short": "accepted | declined | tentative | in-process | completed | needs-action | entered-in-error",
            "definition": "Participation status of the participant. When the status is declined or tentative if the start/end times are different to the appointment, then these times should be interpreted as a requested time change. When the status is accepted, the times can either be the time of the appointment (as a confirmation of the time) or can be empty.",
            "comment": "This element is labeled as a modifier because the status contains the code entered-in-error that marks the participant as not currently valid.",
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
                  "valueString": "ParticipantStatus"
                }
              ],
              "strength": "required",
              "description": "The Participation status of an appointment.",
              "valueSet": "http://hl7.org/fhir/ValueSet/participationstatus|4.0.0"
            }
          },
          {
            "id": "AppointmentResponse.comment",
            "path": "AppointmentResponse.comment",
            "short": "Additional comments",
            "definition": "Additional comments about the appointment.",
            "comment": "This comment is particularly important when the responder is declining, tentatively accepting or requesting another time to indicate the reasons why.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:403
    /// <summary>
    /// Fhir resource 'AppointmentResponse'
    /// </summary>
    // 0. AppointmentResponse
    public class AppointmentResponse : FhirKhit.Maker.Common.Resource.ResourceBase                                                          // MakerGen.cs:352
    {                                                                                                                                       // MakerGen.cs:353
        // 1. AppointmentResponse.identifier
        public MakerElementInstance Element_Identifier;                                                                                     // MakerGen.cs:232
        // 2. AppointmentResponse.appointment
        public MakerElementInstance Element_Appointment;                                                                                    // MakerGen.cs:232
        // 3. AppointmentResponse.start
        public MakerElementInstance Element_Start;                                                                                          // MakerGen.cs:232
        // 4. AppointmentResponse.end
        public MakerElementInstance Element_End;                                                                                            // MakerGen.cs:232
        // 5. AppointmentResponse.participantType
        public MakerElementInstance Element_ParticipantType;                                                                                // MakerGen.cs:232
        // 6. AppointmentResponse.actor
        public MakerElementInstance Element_Actor;                                                                                          // MakerGen.cs:232
        // 7. AppointmentResponse.participantStatus
        public MakerElementInstance Element_ParticipantStatus;                                                                              // MakerGen.cs:232
        // 8. AppointmentResponse.comment
        public MakerElementInstance Element_Comment;                                                                                        // MakerGen.cs:232
        public AppointmentResponse()                                                                                                        // MakerGen.cs:361
        {                                                                                                                                   // MakerGen.cs:362
            {                                                                                                                               // MakerGen.cs:243
                // 1. AppointmentResponse.identifier
                this.Element_Identifier = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 2. AppointmentResponse.appointment
                this.Element_Appointment = new MakerElementInstance                                                                         // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Appointment",                                                                                           // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 3. AppointmentResponse.start
                this.Element_Start = new MakerElementInstance                                                                               // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Start",                                                                                                 // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Instant()                                                                       // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 4. AppointmentResponse.end
                this.Element_End = new MakerElementInstance                                                                                 // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_End",                                                                                                   // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Instant()                                                                       // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 5. AppointmentResponse.participantType
                this.Element_ParticipantType = new MakerElementInstance                                                                     // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_ParticipantType",                                                                                       // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                                 // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 6. AppointmentResponse.actor
                this.Element_Actor = new MakerElementInstance                                                                               // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Actor",                                                                                                 // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 7. AppointmentResponse.participantStatus
                this.Element_ParticipantStatus = new MakerElementInstance                                                                   // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_ParticipantStatus",                                                                                     // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Code()                                                                          // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 8. AppointmentResponse.comment
                this.Element_Comment = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Comment",                                                                                               // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String()                                                                        // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
        }                                                                                                                                   // MakerGen.cs:373
    }                                                                                                                                       // MakerGen.cs:357
}                                                                                                                                           // MakerGen.cs:408
