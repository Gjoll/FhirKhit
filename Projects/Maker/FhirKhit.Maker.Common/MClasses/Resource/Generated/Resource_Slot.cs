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
    #endregion
    /// <summary>
    /// Fhir resource 'Slot'
    /// </summary>
    // 0. Slot
    public class Resource_Slot : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 1. Slot.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. Slot.serviceCategory
        public ElementDefinitionInfo Element_ServiceCategory;
        // 3. Slot.serviceType
        public ElementDefinitionInfo Element_ServiceType;
        // 4. Slot.specialty
        public ElementDefinitionInfo Element_Specialty;
        // 5. Slot.appointmentType
        public ElementDefinitionInfo Element_AppointmentType;
        // 6. Slot.schedule
        public ElementDefinitionInfo Element_Schedule;
        // 7. Slot.status
        public ElementDefinitionInfo Element_Status;
        // 8. Slot.start
        public ElementDefinitionInfo Element_Start;
        // 9. Slot.end
        public ElementDefinitionInfo Element_End;
        // 10. Slot.overbooked
        public ElementDefinitionInfo Element_Overbooked;
        // 11. Slot.comment
        public ElementDefinitionInfo Element_Comment;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "Slot",
                ElementId = "Slot"
            });
            Element_Identifier.Write(sDef);
            Element_ServiceCategory.Write(sDef);
            Element_ServiceType.Write(sDef);
            Element_Specialty.Write(sDef);
            Element_AppointmentType.Write(sDef);
            Element_Schedule.Write(sDef);
            Element_Status.Write(sDef);
            Element_Start.Write(sDef);
            Element_End.Write(sDef);
            Element_Overbooked.Write(sDef);
            Element_Comment.Write(sDef);
        }
        
        public Resource_Slot()
        {
            {
                // 1. Slot.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "Slot.identifier",
                    Id = "Slot.identifier",
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
                // 2. Slot.serviceCategory
                this.Element_ServiceCategory = new ElementDefinitionInfo
                {
                    Name = "Element_ServiceCategory",
                    Path= "Slot.serviceCategory",
                    Id = "Slot.serviceCategory",
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
                // 3. Slot.serviceType
                this.Element_ServiceType = new ElementDefinitionInfo
                {
                    Name = "Element_ServiceType",
                    Path= "Slot.serviceType",
                    Id = "Slot.serviceType",
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
                // 4. Slot.specialty
                this.Element_Specialty = new ElementDefinitionInfo
                {
                    Name = "Element_Specialty",
                    Path= "Slot.specialty",
                    Id = "Slot.specialty",
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
                // 5. Slot.appointmentType
                this.Element_AppointmentType = new ElementDefinitionInfo
                {
                    Name = "Element_AppointmentType",
                    Path= "Slot.appointmentType",
                    Id = "Slot.appointmentType",
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
                // 6. Slot.schedule
                this.Element_Schedule = new ElementDefinitionInfo
                {
                    Name = "Element_Schedule",
                    Path= "Slot.schedule",
                    Id = "Slot.schedule",
                    Min = 1,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Schedule"
                            }
                        }
                    }
                };
            }
            {
                // 7. Slot.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "Slot.status",
                    Id = "Slot.status",
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
                // 8. Slot.start
                this.Element_Start = new ElementDefinitionInfo
                {
                    Name = "Element_Start",
                    Path= "Slot.start",
                    Id = "Slot.start",
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
                // 9. Slot.end
                this.Element_End = new ElementDefinitionInfo
                {
                    Name = "Element_End",
                    Path= "Slot.end",
                    Id = "Slot.end",
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
                // 10. Slot.overbooked
                this.Element_Overbooked = new ElementDefinitionInfo
                {
                    Name = "Element_Overbooked",
                    Path= "Slot.overbooked",
                    Id = "Slot.overbooked",
                    Min = 0,
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
                // 11. Slot.comment
                this.Element_Comment = new ElementDefinitionInfo
                {
                    Name = "Element_Comment",
                    Path= "Slot.comment",
                    Id = "Slot.comment",
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
            this.Name = "Slot";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Slot";
        }
    }
}
