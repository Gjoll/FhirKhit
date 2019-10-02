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
      "id": "Slot",
      "url": "http://hl7.org/fhir/StructureDefinition/Slot",
      "version": "4.0.0",
      "name": "Slot",
      "status": "draft",
      "publisher": "Health Level Seven International (Patient Administration)",
      "description": "A slot of time on a schedule that may be available for booking appointments.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "Slot",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Slot",
            "path": "Slot",
            "short": "A slot of time on a schedule that may be available for booking appointments",
            "definition": "A slot of time on a schedule that may be available for booking appointments.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Slot.identifier",
            "path": "Slot.identifier",
            "short": "External Ids for this item",
            "definition": "External Ids for this item.",
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
            "id": "Slot.serviceCategory",
            "path": "Slot.serviceCategory",
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
            "id": "Slot.serviceType",
            "path": "Slot.serviceType",
            "short": "The type of appointments that can be booked into this slot (ideally this would be an identifiable service - which is at a location, rather than the location itself). If provided then this overrides the value provided on the availability resource",
            "definition": "The type of appointments that can be booked into this slot (ideally this would be an identifiable service - which is at a location, rather than the location itself). If provided then this overrides the value provided on the availability resource.",
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
            "id": "Slot.specialty",
            "path": "Slot.specialty",
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
              "description": "Additional details about where the content was created (e.g. clinical specialty).",
              "valueSet": "http://hl7.org/fhir/ValueSet/c80-practice-codes"
            }
          },
          {
            "id": "Slot.appointmentType",
            "path": "Slot.appointmentType",
            "short": "The style of appointment or patient that may be booked in the slot (not service type)",
            "definition": "The style of appointment or patient that may be booked in the slot (not service type).",
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
            "id": "Slot.schedule",
            "path": "Slot.schedule",
            "short": "The schedule resource that this slot defines an interval of status information",
            "definition": "The schedule resource that this slot defines an interval of status information.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Schedule"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Slot.status",
            "path": "Slot.status",
            "short": "busy | free | busy-unavailable | busy-tentative | entered-in-error",
            "definition": "busy | free | busy-unavailable | busy-tentative | entered-in-error.",
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
                  "valueString": "SlotStatus"
                }
              ],
              "strength": "required",
              "description": "The free/busy status of the slot.",
              "valueSet": "http://hl7.org/fhir/ValueSet/slotstatus|4.0.0"
            }
          },
          {
            "id": "Slot.start",
            "path": "Slot.start",
            "short": "Date/Time that the slot is to begin",
            "definition": "Date/Time that the slot is to begin.",
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
            "id": "Slot.end",
            "path": "Slot.end",
            "short": "Date/Time that the slot is to conclude",
            "definition": "Date/Time that the slot is to conclude.",
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
            "id": "Slot.overbooked",
            "path": "Slot.overbooked",
            "short": "This slot has already been overbooked, appointments are unlikely to be accepted for this time",
            "definition": "This slot has already been overbooked, appointments are unlikely to be accepted for this time.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ],
            "meaningWhenMissing": "If overbooked is missing, systems may assume that there are still appointments available"
          },
          {
            "id": "Slot.comment",
            "path": "Slot.comment",
            "short": "Comments on the slot to describe any extended information. Such as custom constraints on the slot",
            "definition": "Comments on the slot to describe any extended information. Such as custom constraints on the slot.",
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
    /// Fhir resource 'Slot'
    /// </summary>
    // 0. Slot
    public class Resource_Slot : FhirKhit.Maker.Common.Resource.Resource_DomainResource                                                     // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        // 1. Slot.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:219
        // 2. Slot.serviceCategory
        public ElementDefinitionInfo Element_ServiceCategory;                                                                               // MakerGen.cs:219
        // 3. Slot.serviceType
        public ElementDefinitionInfo Element_ServiceType;                                                                                   // MakerGen.cs:219
        // 4. Slot.specialty
        public ElementDefinitionInfo Element_Specialty;                                                                                     // MakerGen.cs:219
        // 5. Slot.appointmentType
        public ElementDefinitionInfo Element_AppointmentType;                                                                               // MakerGen.cs:219
        // 6. Slot.schedule
        public ElementDefinitionInfo Element_Schedule;                                                                                      // MakerGen.cs:219
        // 7. Slot.status
        public ElementDefinitionInfo Element_Status;                                                                                        // MakerGen.cs:219
        // 8. Slot.start
        public ElementDefinitionInfo Element_Start;                                                                                         // MakerGen.cs:219
        // 9. Slot.end
        public ElementDefinitionInfo Element_End;                                                                                           // MakerGen.cs:219
        // 10. Slot.overbooked
        public ElementDefinitionInfo Element_Overbooked;                                                                                    // MakerGen.cs:219
        // 11. Slot.comment
        public ElementDefinitionInfo Element_Comment;                                                                                       // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:390
        {                                                                                                                                   // MakerGen.cs:391
            base.Write(sDef);                                                                                                               // MakerGen.cs:392
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                Path = "Slot",                                                                                                              // MakerGen.cs:395
                ElementId = "Slot"                                                                                                          // MakerGen.cs:396
            });                                                                                                                             // MakerGen.cs:397
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_ServiceCategory.Write(sDef);                                                                                            // MakerGen.cs:223
            Element_ServiceType.Write(sDef);                                                                                                // MakerGen.cs:223
            Element_Specialty.Write(sDef);                                                                                                  // MakerGen.cs:223
            Element_AppointmentType.Write(sDef);                                                                                            // MakerGen.cs:223
            Element_Schedule.Write(sDef);                                                                                                   // MakerGen.cs:223
            Element_Status.Write(sDef);                                                                                                     // MakerGen.cs:223
            Element_Start.Write(sDef);                                                                                                      // MakerGen.cs:223
            Element_End.Write(sDef);                                                                                                        // MakerGen.cs:223
            Element_Overbooked.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_Comment.Write(sDef);                                                                                                    // MakerGen.cs:223
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
        public Resource_Slot()                                                                                                              // MakerGen.cs:402
        {                                                                                                                                   // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:234
                // 1. Slot.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:238
                    Path= "Slot.identifier",                                                                                                // MakerGen.cs:239
                    Id = "Slot.identifier",                                                                                                 // MakerGen.cs:240
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
                // 2. Slot.serviceCategory
                this.Element_ServiceCategory = new ElementDefinitionInfo                                                                    // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_ServiceCategory",                                                                                       // MakerGen.cs:238
                    Path= "Slot.serviceCategory",                                                                                           // MakerGen.cs:239
                    Id = "Slot.serviceCategory",                                                                                            // MakerGen.cs:240
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
                // 3. Slot.serviceType
                this.Element_ServiceType = new ElementDefinitionInfo                                                                        // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_ServiceType",                                                                                           // MakerGen.cs:238
                    Path= "Slot.serviceType",                                                                                               // MakerGen.cs:239
                    Id = "Slot.serviceType",                                                                                                // MakerGen.cs:240
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
                // 4. Slot.specialty
                this.Element_Specialty = new ElementDefinitionInfo                                                                          // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Specialty",                                                                                             // MakerGen.cs:238
                    Path= "Slot.specialty",                                                                                                 // MakerGen.cs:239
                    Id = "Slot.specialty",                                                                                                  // MakerGen.cs:240
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
                // 5. Slot.appointmentType
                this.Element_AppointmentType = new ElementDefinitionInfo                                                                    // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_AppointmentType",                                                                                       // MakerGen.cs:238
                    Path= "Slot.appointmentType",                                                                                           // MakerGen.cs:239
                    Id = "Slot.appointmentType",                                                                                            // MakerGen.cs:240
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
                // 6. Slot.schedule
                this.Element_Schedule = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Schedule",                                                                                              // MakerGen.cs:238
                    Path= "Slot.schedule",                                                                                                  // MakerGen.cs:239
                    Id = "Slot.schedule",                                                                                                   // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Schedule"                                                          // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 7. Slot.status
                this.Element_Status = new ElementDefinitionInfo                                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Status",                                                                                                // MakerGen.cs:238
                    Path= "Slot.status",                                                                                                    // MakerGen.cs:239
                    Id = "Slot.status",                                                                                                     // MakerGen.cs:240
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
                // 8. Slot.start
                this.Element_Start = new ElementDefinitionInfo                                                                              // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Start",                                                                                                 // MakerGen.cs:238
                    Path= "Slot.start",                                                                                                     // MakerGen.cs:239
                    Id = "Slot.start",                                                                                                      // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
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
                // 9. Slot.end
                this.Element_End = new ElementDefinitionInfo                                                                                // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_End",                                                                                                   // MakerGen.cs:238
                    Path= "Slot.end",                                                                                                       // MakerGen.cs:239
                    Id = "Slot.end",                                                                                                        // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
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
                // 10. Slot.overbooked
                this.Element_Overbooked = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Overbooked",                                                                                            // MakerGen.cs:238
                    Path= "Slot.overbooked",                                                                                                // MakerGen.cs:239
                    Id = "Slot.overbooked",                                                                                                 // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                               // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 11. Slot.comment
                this.Element_Comment = new ElementDefinitionInfo                                                                            // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Comment",                                                                                               // MakerGen.cs:238
                    Path= "Slot.comment",                                                                                                   // MakerGen.cs:239
                    Id = "Slot.comment",                                                                                                    // MakerGen.cs:240
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
            this.Name = "Slot";                                                                                                             // MakerGen.cs:471
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Slot";                                                                      // MakerGen.cs:472
        }                                                                                                                                   // MakerGen.cs:405
    }                                                                                                                                       // MakerGen.cs:407
}                                                                                                                                           // MakerGen.cs:452
