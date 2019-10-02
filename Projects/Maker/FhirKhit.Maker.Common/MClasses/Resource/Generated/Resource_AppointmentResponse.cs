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
    #endregion                                                                                                                              // MakerGen.cs:447
    /// <summary>
    /// Fhir resource 'AppointmentResponse'
    /// </summary>
    // 0. AppointmentResponse
    public class Resource_AppointmentResponse : FhirKhit.Maker.Common.Resource.Resource_DomainResource                                      // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        // 1. AppointmentResponse.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:219
        // 2. AppointmentResponse.appointment
        public ElementDefinitionInfo Element_Appointment;                                                                                   // MakerGen.cs:219
        // 3. AppointmentResponse.start
        public ElementDefinitionInfo Element_Start;                                                                                         // MakerGen.cs:219
        // 4. AppointmentResponse.end
        public ElementDefinitionInfo Element_End;                                                                                           // MakerGen.cs:219
        // 5. AppointmentResponse.participantType
        public ElementDefinitionInfo Element_ParticipantType;                                                                               // MakerGen.cs:219
        // 6. AppointmentResponse.actor
        public ElementDefinitionInfo Element_Actor;                                                                                         // MakerGen.cs:219
        // 7. AppointmentResponse.participantStatus
        public ElementDefinitionInfo Element_ParticipantStatus;                                                                             // MakerGen.cs:219
        // 8. AppointmentResponse.comment
        public ElementDefinitionInfo Element_Comment;                                                                                       // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:390
        {                                                                                                                                   // MakerGen.cs:391
            base.Write(sDef);                                                                                                               // MakerGen.cs:392
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                Path = "AppointmentResponse",                                                                                               // MakerGen.cs:395
                ElementId = "AppointmentResponse"                                                                                           // MakerGen.cs:396
            });                                                                                                                             // MakerGen.cs:397
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_Appointment.Write(sDef);                                                                                                // MakerGen.cs:223
            Element_Start.Write(sDef);                                                                                                      // MakerGen.cs:223
            Element_End.Write(sDef);                                                                                                        // MakerGen.cs:223
            Element_ParticipantType.Write(sDef);                                                                                            // MakerGen.cs:223
            Element_Actor.Write(sDef);                                                                                                      // MakerGen.cs:223
            Element_ParticipantStatus.Write(sDef);                                                                                          // MakerGen.cs:223
            Element_Comment.Write(sDef);                                                                                                    // MakerGen.cs:223
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
        public Resource_AppointmentResponse()                                                                                               // MakerGen.cs:402
        {                                                                                                                                   // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:234
                // 1. AppointmentResponse.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:238
                    Path= "AppointmentResponse.identifier",                                                                                 // MakerGen.cs:239
                    Id = "AppointmentResponse.identifier",                                                                                  // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Identifier                                                                   // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 2. AppointmentResponse.appointment
                this.Element_Appointment = new ElementDefinitionInfo                                                                        // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Appointment",                                                                                           // MakerGen.cs:238
                    Path= "AppointmentResponse.appointment",                                                                                // MakerGen.cs:239
                    Id = "AppointmentResponse.appointment",                                                                                 // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Appointment"                                                       // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 3. AppointmentResponse.start
                this.Element_Start = new ElementDefinitionInfo                                                                              // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Start",                                                                                                 // MakerGen.cs:238
                    Path= "AppointmentResponse.start",                                                                                      // MakerGen.cs:239
                    Id = "AppointmentResponse.start",                                                                                       // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Instant                                                               // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 4. AppointmentResponse.end
                this.Element_End = new ElementDefinitionInfo                                                                                // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_End",                                                                                                   // MakerGen.cs:238
                    Path= "AppointmentResponse.end",                                                                                        // MakerGen.cs:239
                    Id = "AppointmentResponse.end",                                                                                         // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Instant                                                               // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 5. AppointmentResponse.participantType
                this.Element_ParticipantType = new ElementDefinitionInfo                                                                    // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_ParticipantType",                                                                                       // MakerGen.cs:238
                    Path= "AppointmentResponse.participantType",                                                                            // MakerGen.cs:239
                    Id = "AppointmentResponse.participantType",                                                                             // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:322
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 6. AppointmentResponse.actor
                this.Element_Actor = new ElementDefinitionInfo                                                                              // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Actor",                                                                                                 // MakerGen.cs:238
                    Path= "AppointmentResponse.actor",                                                                                      // MakerGen.cs:239
                    Id = "AppointmentResponse.actor",                                                                                       // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Patient",                                                          // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                     // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                                 // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/RelatedPerson",                                                    // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/Device",                                                           // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/HealthcareService",                                                // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/Location"                                                          // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 7. AppointmentResponse.participantStatus
                this.Element_ParticipantStatus = new ElementDefinitionInfo                                                                  // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_ParticipantStatus",                                                                                     // MakerGen.cs:238
                    Path= "AppointmentResponse.participantStatus",                                                                          // MakerGen.cs:239
                    Id = "AppointmentResponse.participantStatus",                                                                           // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 8. AppointmentResponse.comment
                this.Element_Comment = new ElementDefinitionInfo                                                                            // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Comment",                                                                                               // MakerGen.cs:238
                    Path= "AppointmentResponse.comment",                                                                                    // MakerGen.cs:239
                    Id = "AppointmentResponse.comment",                                                                                     // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            this.Name = "AppointmentResponse";                                                                                              // MakerGen.cs:471
            this.Uri = "http://hl7.org/fhir/StructureDefinition/AppointmentResponse";                                                       // MakerGen.cs:472
        }                                                                                                                                   // MakerGen.cs:405
    }                                                                                                                                       // MakerGen.cs:407
}                                                                                                                                           // MakerGen.cs:452
