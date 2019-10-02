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
      "id": "PractitionerRole",
      "url": "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
      "version": "4.0.0",
      "name": "PractitionerRole",
      "status": "draft",
      "publisher": "Health Level Seven International (Patient Administration)",
      "description": "A specific set of Roles/Locations/specialties/services that a practitioner may perform at an organization for a period of time.",
      "purpose": "Need to track services that a healthcare provider is able to provide at an organization's location, and the services that they can perform there.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "PractitionerRole",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "PractitionerRole",
            "path": "PractitionerRole",
            "short": "Roles/organizations the practitioner is associated with",
            "definition": "A specific set of Roles/Locations/specialties/services that a practitioner may perform at an organization for a period of time.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "PractitionerRole.identifier",
            "path": "PractitionerRole.identifier",
            "short": "Business Identifiers that are specific to a role/location",
            "definition": "Business Identifiers that are specific to a role/location.",
            "requirements": "Often, specific identities are assigned for the agent.",
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
            "id": "PractitionerRole.active",
            "path": "PractitionerRole.active",
            "short": "Whether this practitioner role record is in active use",
            "definition": "Whether this practitioner role record is in active use.",
            "comment": "If this value is false, you may refer to the period to see when the role was in active use. If there is no period specified, no inference can be made about when it was active.",
            "requirements": "Need to be able to mark a practitioner role record as not to be used because it was created in error, or otherwise no longer in active use.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ],
            "meaningWhenMissing": "This resource is generally assumed to be active if no value is provided for the active element",
            "isSummary": true
          },
          {
            "id": "PractitionerRole.period",
            "path": "PractitionerRole.period",
            "short": "The period during which the practitioner is authorized to perform in these role(s)",
            "definition": "The period during which the person is authorized to act as a practitioner in these role(s) for the organization.",
            "requirements": "Even after the agencies is revoked, the fact that it existed must still be recorded.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Period"
              }
            ],
            "isSummary": true
          },
          {
            "id": "PractitionerRole.practitioner",
            "path": "PractitionerRole.practitioner",
            "short": "Practitioner that is able to provide the defined services for the organization",
            "definition": "Practitioner that is able to provide the defined services for the organization.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "PractitionerRole.organization",
            "path": "PractitionerRole.organization",
            "short": "Organization where the roles are available",
            "definition": "The organization where the Practitioner performs the roles associated.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "PractitionerRole.code",
            "path": "PractitionerRole.code",
            "short": "Roles which this practitioner may perform",
            "definition": "Roles which this practitioner is authorized to perform for the organization.",
            "comment": "A person may have more than one role.",
            "requirements": "Need to know what authority the practitioner has - what can they do?",
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
                  "valueString": "PractitionerRole"
                }
              ],
              "strength": "example",
              "description": "The role a person plays representing an organization.",
              "valueSet": "http://hl7.org/fhir/ValueSet/practitioner-role"
            }
          },
          {
            "id": "PractitionerRole.specialty",
            "path": "PractitionerRole.specialty",
            "short": "Specific specialty of the practitioner",
            "definition": "Specific specialty of the practitioner.",
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
                  "valueString": "PractitionerSpecialty"
                }
              ],
              "strength": "preferred",
              "description": "Specific specialty associated with the agency.",
              "valueSet": "http://hl7.org/fhir/ValueSet/c80-practice-codes"
            }
          },
          {
            "id": "PractitionerRole.location",
            "path": "PractitionerRole.location",
            "short": "The location(s) at which this practitioner provides care",
            "definition": "The location(s) at which this practitioner provides care.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Location"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "PractitionerRole.healthcareService",
            "path": "PractitionerRole.healthcareService",
            "short": "The list of healthcare services that this worker provides for this role's Organization/Location(s)",
            "definition": "The list of healthcare services that this worker provides for this role's Organization/Location(s).",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/HealthcareService"
                ]
              }
            ]
          },
          {
            "id": "PractitionerRole.telecom",
            "path": "PractitionerRole.telecom",
            "short": "Contact details that are specific to the role/location/service",
            "definition": "Contact details that are specific to the role/location/service.",
            "requirements": "Often practitioners have a dedicated line for each location (or service) that they work at, and need to be able to define separate contact details for each of these.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "ContactPoint"
              }
            ],
            "isSummary": true
          },
          {
            "id": "PractitionerRole.availableTime",
            "path": "PractitionerRole.availableTime",
            "short": "Times the Service Site is available",
            "definition": "A collection of times the practitioner is available or performing this role at the location and/or healthcareservice.",
            "comment": "More detailed availability information may be provided in associated Schedule/Slot resources.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "PractitionerRole.availableTime.daysOfWeek",
            "path": "PractitionerRole.availableTime.daysOfWeek",
            "short": "mon | tue | wed | thu | fri | sat | sun",
            "definition": "Indicates which days of the week are available between the start and end Times.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "code"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "DaysOfWeek"
                }
              ],
              "strength": "required",
              "description": "The days of the week.",
              "valueSet": "http://hl7.org/fhir/ValueSet/days-of-week|4.0.0"
            }
          },
          {
            "id": "PractitionerRole.availableTime.allDay",
            "path": "PractitionerRole.availableTime.allDay",
            "short": "Always available? e.g. 24 hour service",
            "definition": "Is this always available? (hence times are irrelevant) e.g. 24 hour service.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ]
          },
          {
            "id": "PractitionerRole.availableTime.availableStartTime",
            "path": "PractitionerRole.availableTime.availableStartTime",
            "short": "Opening time of day (ignored if allDay = true)",
            "definition": "The opening time of day. Note: If the AllDay flag is set, then this time is ignored.",
            "comment": "The timezone is expected to be for where this HealthcareService is provided at.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "time"
              }
            ]
          },
          {
            "id": "PractitionerRole.availableTime.availableEndTime",
            "path": "PractitionerRole.availableTime.availableEndTime",
            "short": "Closing time of day (ignored if allDay = true)",
            "definition": "The closing time of day. Note: If the AllDay flag is set, then this time is ignored.",
            "comment": "The timezone is expected to be for where this HealthcareService is provided at.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "time"
              }
            ]
          },
          {
            "id": "PractitionerRole.notAvailable",
            "path": "PractitionerRole.notAvailable",
            "short": "Not available during this time due to provided reason",
            "definition": "The practitioner is not available or performing this role during this period of time due to the provided reason.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "PractitionerRole.notAvailable.description",
            "path": "PractitionerRole.notAvailable.description",
            "short": "Reason presented to the user explaining why time not available",
            "definition": "The reason that can be presented to the user as to why this time is not available.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "PractitionerRole.notAvailable.during",
            "path": "PractitionerRole.notAvailable.during",
            "short": "Service not available from this date",
            "definition": "Service is not available (seasonally or for a public holiday) from this date.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Period"
              }
            ]
          },
          {
            "id": "PractitionerRole.availabilityExceptions",
            "path": "PractitionerRole.availabilityExceptions",
            "short": "Description of availability exceptions",
            "definition": "A description of site availability exceptions, e.g. public holiday availability. Succinctly describing all possible exceptions to normal site availability as details in the available Times and not available Times.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "PractitionerRole.endpoint",
            "path": "PractitionerRole.endpoint",
            "short": "Technical endpoints providing access to services operated for the practitioner with this role",
            "definition": "Technical endpoints providing access to services operated for the practitioner with this role.",
            "requirements": "Organizations have multiple systems that provide various services and ,ay also be different for practitioners too.\r\rSo the endpoint satisfies the need to be able to define the technical connection details for how to connect to them, and for what purpose.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Endpoint"
                ]
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion
    /// <summary>
    /// Fhir resource 'PractitionerRole'
    /// </summary>
    // 0. PractitionerRole
    public partial class Resource_PractitionerRole : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 11. PractitionerRole.availableTime
        public partial class Type_AvailableTime : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 12. PractitionerRole.availableTime.daysOfWeek
            public ElementDefinitionInfo Element_DaysOfWeek;
            // 13. PractitionerRole.availableTime.allDay
            public ElementDefinitionInfo Element_AllDay;
            // 14. PractitionerRole.availableTime.availableStartTime
            public ElementDefinitionInfo Element_AvailableStartTime;
            // 15. PractitionerRole.availableTime.availableEndTime
            public ElementDefinitionInfo Element_AvailableEndTime;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "PractitionerRole.availableTime",
                    ElementId = "PractitionerRole.availableTime"
                });
                Element_DaysOfWeek.Write(sDef);
                Element_AllDay.Write(sDef);
                Element_AvailableStartTime.Write(sDef);
                Element_AvailableEndTime.Write(sDef);
            }
            
            public Type_AvailableTime()
            {
                {
                    // 12. PractitionerRole.availableTime.daysOfWeek
                    this.Element_DaysOfWeek = new ElementDefinitionInfo
                    {
                        Name = "Element_DaysOfWeek",
                        Path= "PractitionerRole.availableTime.daysOfWeek",
                        Id = "PractitionerRole.availableTime.daysOfWeek",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Code
                            {
                            }
                        }
                    };
                }
                {
                    // 13. PractitionerRole.availableTime.allDay
                    this.Element_AllDay = new ElementDefinitionInfo
                    {
                        Name = "Element_AllDay",
                        Path= "PractitionerRole.availableTime.allDay",
                        Id = "PractitionerRole.availableTime.allDay",
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
                    // 14. PractitionerRole.availableTime.availableStartTime
                    this.Element_AvailableStartTime = new ElementDefinitionInfo
                    {
                        Name = "Element_AvailableStartTime",
                        Path= "PractitionerRole.availableTime.availableStartTime",
                        Id = "PractitionerRole.availableTime.availableStartTime",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Time
                            {
                            }
                        }
                    };
                }
                {
                    // 15. PractitionerRole.availableTime.availableEndTime
                    this.Element_AvailableEndTime = new ElementDefinitionInfo
                    {
                        Name = "Element_AvailableEndTime",
                        Path= "PractitionerRole.availableTime.availableEndTime",
                        Id = "PractitionerRole.availableTime.availableEndTime",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Time
                            {
                            }
                        }
                    };
                }
            }
        }
        // 16. PractitionerRole.notAvailable
        public partial class Type_NotAvailable : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 17. PractitionerRole.notAvailable.description
            public ElementDefinitionInfo Element_Description;
            // 18. PractitionerRole.notAvailable.during
            public ElementDefinitionInfo Element_During;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "PractitionerRole.notAvailable",
                    ElementId = "PractitionerRole.notAvailable"
                });
                Element_Description.Write(sDef);
                Element_During.Write(sDef);
            }
            
            public Type_NotAvailable()
            {
                {
                    // 17. PractitionerRole.notAvailable.description
                    this.Element_Description = new ElementDefinitionInfo
                    {
                        Name = "Element_Description",
                        Path= "PractitionerRole.notAvailable.description",
                        Id = "PractitionerRole.notAvailable.description",
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
                    // 18. PractitionerRole.notAvailable.during
                    this.Element_During = new ElementDefinitionInfo
                    {
                        Name = "Element_During",
                        Path= "PractitionerRole.notAvailable.during",
                        Id = "PractitionerRole.notAvailable.during",
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
            }
        }
        // 1. PractitionerRole.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. PractitionerRole.active
        public ElementDefinitionInfo Element_Active;
        // 3. PractitionerRole.period
        public ElementDefinitionInfo Element_Period;
        // 4. PractitionerRole.practitioner
        public ElementDefinitionInfo Element_Practitioner;
        // 5. PractitionerRole.organization
        public ElementDefinitionInfo Element_Organization;
        // 6. PractitionerRole.code
        public ElementDefinitionInfo Element_Code;
        // 7. PractitionerRole.specialty
        public ElementDefinitionInfo Element_Specialty;
        // 8. PractitionerRole.location
        public ElementDefinitionInfo Element_Location;
        // 9. PractitionerRole.healthcareService
        public ElementDefinitionInfo Element_HealthcareService;
        // 10. PractitionerRole.telecom
        public ElementDefinitionInfo Element_Telecom;
        // 11. PractitionerRole.availableTime
        public ElementDefinitionInfo Element_AvailableTime;
        // 16. PractitionerRole.notAvailable
        public ElementDefinitionInfo Element_NotAvailable;
        // 19. PractitionerRole.availabilityExceptions
        public ElementDefinitionInfo Element_AvailabilityExceptions;
        // 20. PractitionerRole.endpoint
        public ElementDefinitionInfo Element_Endpoint;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "PractitionerRole",
                ElementId = "PractitionerRole"
            });
            Element_Identifier.Write(sDef);
            Element_Active.Write(sDef);
            Element_Period.Write(sDef);
            Element_Practitioner.Write(sDef);
            Element_Organization.Write(sDef);
            Element_Code.Write(sDef);
            Element_Specialty.Write(sDef);
            Element_Location.Write(sDef);
            Element_HealthcareService.Write(sDef);
            Element_Telecom.Write(sDef);
            Element_AvailableTime.Write(sDef);
            Element_NotAvailable.Write(sDef);
            Element_AvailabilityExceptions.Write(sDef);
            Element_Endpoint.Write(sDef);
        }
        
        public Resource_PractitionerRole()
        {
            {
                // 1. PractitionerRole.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "PractitionerRole.identifier",
                    Id = "PractitionerRole.identifier",
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
                // 2. PractitionerRole.active
                this.Element_Active = new ElementDefinitionInfo
                {
                    Name = "Element_Active",
                    Path= "PractitionerRole.active",
                    Id = "PractitionerRole.active",
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
                // 3. PractitionerRole.period
                this.Element_Period = new ElementDefinitionInfo
                {
                    Name = "Element_Period",
                    Path= "PractitionerRole.period",
                    Id = "PractitionerRole.period",
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
                // 4. PractitionerRole.practitioner
                this.Element_Practitioner = new ElementDefinitionInfo
                {
                    Name = "Element_Practitioner",
                    Path= "PractitionerRole.practitioner",
                    Id = "PractitionerRole.practitioner",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Practitioner"
                            }
                        }
                    }
                };
            }
            {
                // 5. PractitionerRole.organization
                this.Element_Organization = new ElementDefinitionInfo
                {
                    Name = "Element_Organization",
                    Path= "PractitionerRole.organization",
                    Id = "PractitionerRole.organization",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Organization"
                            }
                        }
                    }
                };
            }
            {
                // 6. PractitionerRole.code
                this.Element_Code = new ElementDefinitionInfo
                {
                    Name = "Element_Code",
                    Path= "PractitionerRole.code",
                    Id = "PractitionerRole.code",
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
                // 7. PractitionerRole.specialty
                this.Element_Specialty = new ElementDefinitionInfo
                {
                    Name = "Element_Specialty",
                    Path= "PractitionerRole.specialty",
                    Id = "PractitionerRole.specialty",
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
                // 8. PractitionerRole.location
                this.Element_Location = new ElementDefinitionInfo
                {
                    Name = "Element_Location",
                    Path= "PractitionerRole.location",
                    Id = "PractitionerRole.location",
                    Min = 0,
                    Max = -1,
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
                // 9. PractitionerRole.healthcareService
                this.Element_HealthcareService = new ElementDefinitionInfo
                {
                    Name = "Element_HealthcareService",
                    Path= "PractitionerRole.healthcareService",
                    Id = "PractitionerRole.healthcareService",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/HealthcareService"
                            }
                        }
                    }
                };
            }
            {
                // 10. PractitionerRole.telecom
                this.Element_Telecom = new ElementDefinitionInfo
                {
                    Name = "Element_Telecom",
                    Path= "PractitionerRole.telecom",
                    Id = "PractitionerRole.telecom",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_ContactPoint
                        {
                        }
                    }
                };
            }
            {
                // 11. PractitionerRole.availableTime
                this.Element_AvailableTime = new ElementDefinitionInfo
                {
                    Name = "Element_AvailableTime",
                    Path= "PractitionerRole.availableTime",
                    Id = "PractitionerRole.availableTime",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_AvailableTime
                        {
                        }
                    }
                };
            }
            {
                // 16. PractitionerRole.notAvailable
                this.Element_NotAvailable = new ElementDefinitionInfo
                {
                    Name = "Element_NotAvailable",
                    Path= "PractitionerRole.notAvailable",
                    Id = "PractitionerRole.notAvailable",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_NotAvailable
                        {
                        }
                    }
                };
            }
            {
                // 19. PractitionerRole.availabilityExceptions
                this.Element_AvailabilityExceptions = new ElementDefinitionInfo
                {
                    Name = "Element_AvailabilityExceptions",
                    Path= "PractitionerRole.availabilityExceptions",
                    Id = "PractitionerRole.availabilityExceptions",
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
                // 20. PractitionerRole.endpoint
                this.Element_Endpoint = new ElementDefinitionInfo
                {
                    Name = "Element_Endpoint",
                    Path= "PractitionerRole.endpoint",
                    Id = "PractitionerRole.endpoint",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Endpoint"
                            }
                        }
                    }
                };
            }
            this.Name = "PractitionerRole";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/PractitionerRole";
        }
    }
}
