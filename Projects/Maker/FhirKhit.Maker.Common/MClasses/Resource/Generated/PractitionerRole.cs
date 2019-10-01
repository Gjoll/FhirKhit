using System;                                                                                                                               // MakerGen.cs:423
using System.Diagnostics;                                                                                                                   // MakerGen.cs:424
using System.IO;                                                                                                                            // MakerGen.cs:425
using System.Linq;                                                                                                                          // MakerGen.cs:426
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:427
                                                                                                                                            // MakerGen.cs:428
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:429
{                                                                                                                                           // MakerGen.cs:430
    #region Json                                                                                                                            // MakerGen.cs:431
    #if NEVER                                                                                                                               // MakerGen.cs:432
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
    #endregion                                                                                                                              // MakerGen.cs:435
    /// <summary>
    /// Fhir resource 'PractitionerRole'
    /// </summary>
    // 0. PractitionerRole
    public class PractitionerRole : FhirKhit.Maker.Common.Resource.ResourceBase                                                             // MakerGen.cs:384
    {                                                                                                                                       // MakerGen.cs:385
        // 11. PractitionerRole.availableTime
        public class Type_AvailableTime : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:384
        {                                                                                                                                   // MakerGen.cs:385
            // 12. PractitionerRole.availableTime.daysOfWeek
            public MakerElementInstance Element_DaysOfWeek;                                                                                 // MakerGen.cs:232
            // 13. PractitionerRole.availableTime.allDay
            public MakerElementInstance Element_AllDay;                                                                                     // MakerGen.cs:232
            // 14. PractitionerRole.availableTime.availableStartTime
            public MakerElementInstance Element_AvailableStartTime;                                                                         // MakerGen.cs:232
            // 15. PractitionerRole.availableTime.availableEndTime
            public MakerElementInstance Element_AvailableEndTime;                                                                           // MakerGen.cs:232
            public Type_AvailableTime()                                                                                                     // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:243
                    // 12. PractitionerRole.availableTime.daysOfWeek
                    this.Element_DaysOfWeek = new MakerElementInstance                                                                      // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_DaysOfWeek",                                                                                        // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:243
                    // 13. PractitionerRole.availableTime.allDay
                    this.Element_AllDay = new MakerElementInstance                                                                          // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_AllDay",                                                                                            // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Boolean                                                                     // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:243
                    // 14. PractitionerRole.availableTime.availableStartTime
                    this.Element_AvailableStartTime = new MakerElementInstance                                                              // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_AvailableStartTime",                                                                                // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Time                                                                        // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:243
                    // 15. PractitionerRole.availableTime.availableEndTime
                    this.Element_AvailableEndTime = new MakerElementInstance                                                                // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_AvailableEndTime",                                                                                  // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Time                                                                        // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:366
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:389
        // 16. PractitionerRole.notAvailable
        public class Type_NotAvailable : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:384
        {                                                                                                                                   // MakerGen.cs:385
            // 17. PractitionerRole.notAvailable.description
            public MakerElementInstance Element_Description;                                                                                // MakerGen.cs:232
            // 18. PractitionerRole.notAvailable.during
            public MakerElementInstance Element_During;                                                                                     // MakerGen.cs:232
            public Type_NotAvailable()                                                                                                      // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:243
                    // 17. PractitionerRole.notAvailable.description
                    this.Element_Description = new MakerElementInstance                                                                     // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Description",                                                                                       // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:243
                    // 18. PractitionerRole.notAvailable.during
                    this.Element_During = new MakerElementInstance                                                                          // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_During",                                                                                            // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.Period                                                                        // MakerGen.cs:343
                            {                                                                                                               // MakerGen.cs:344
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:366
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:389
        // 1. PractitionerRole.identifier
        public MakerElementInstance Element_Identifier;                                                                                     // MakerGen.cs:232
        // 2. PractitionerRole.active
        public MakerElementInstance Element_Active;                                                                                         // MakerGen.cs:232
        // 3. PractitionerRole.period
        public MakerElementInstance Element_Period;                                                                                         // MakerGen.cs:232
        // 4. PractitionerRole.practitioner
        public MakerElementInstance Element_Practitioner;                                                                                   // MakerGen.cs:232
        // 5. PractitionerRole.organization
        public MakerElementInstance Element_Organization;                                                                                   // MakerGen.cs:232
        // 6. PractitionerRole.code
        public MakerElementInstance Element_Code;                                                                                           // MakerGen.cs:232
        // 7. PractitionerRole.specialty
        public MakerElementInstance Element_Specialty;                                                                                      // MakerGen.cs:232
        // 8. PractitionerRole.location
        public MakerElementInstance Element_Location;                                                                                       // MakerGen.cs:232
        // 9. PractitionerRole.healthcareService
        public MakerElementInstance Element_HealthcareService;                                                                              // MakerGen.cs:232
        // 10. PractitionerRole.telecom
        public MakerElementInstance Element_Telecom;                                                                                        // MakerGen.cs:232
        // 19. PractitionerRole.availabilityExceptions
        public MakerElementInstance Element_AvailabilityExceptions;                                                                         // MakerGen.cs:232
        // 20. PractitionerRole.endpoint
        public MakerElementInstance Element_Endpoint;                                                                                       // MakerGen.cs:232
        public PractitionerRole()                                                                                                           // MakerGen.cs:393
        {                                                                                                                                   // MakerGen.cs:394
            {                                                                                                                               // MakerGen.cs:243
                // 1. PractitionerRole.identifier
                this.Element_Identifier = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Identifier                                                                        // MakerGen.cs:343
                        {                                                                                                                   // MakerGen.cs:344
                        }                                                                                                                   // MakerGen.cs:345
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 2. PractitionerRole.active
                this.Element_Active = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Active",                                                                                                // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Boolean                                                                         // MakerGen.cs:287
                        {                                                                                                                   // MakerGen.cs:288
                        }                                                                                                                   // MakerGen.cs:289
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 3. PractitionerRole.period
                this.Element_Period = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Period",                                                                                                // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Period                                                                            // MakerGen.cs:343
                        {                                                                                                                   // MakerGen.cs:344
                        }                                                                                                                   // MakerGen.cs:345
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 4. PractitionerRole.practitioner
                this.Element_Practitioner = new MakerElementInstance                                                                        // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Practitioner",                                                                                          // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Reference                                                                         // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 5. PractitionerRole.organization
                this.Element_Organization = new MakerElementInstance                                                                        // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Organization",                                                                                          // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Reference                                                                         // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 6. PractitionerRole.code
                this.Element_Code = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Code",                                                                                                  // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept                                                                   // MakerGen.cs:297
                        {                                                                                                                   // MakerGen.cs:298
                        }                                                                                                                   // MakerGen.cs:299
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 7. PractitionerRole.specialty
                this.Element_Specialty = new MakerElementInstance                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Specialty",                                                                                             // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept                                                                   // MakerGen.cs:297
                        {                                                                                                                   // MakerGen.cs:298
                        }                                                                                                                   // MakerGen.cs:299
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 8. PractitionerRole.location
                this.Element_Location = new MakerElementInstance                                                                            // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Location",                                                                                              // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Reference                                                                         // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 9. PractitionerRole.healthcareService
                this.Element_HealthcareService = new MakerElementInstance                                                                   // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_HealthcareService",                                                                                     // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Reference                                                                         // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 10. PractitionerRole.telecom
                this.Element_Telecom = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Telecom",                                                                                               // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.ContactPoint                                                                      // MakerGen.cs:343
                        {                                                                                                                   // MakerGen.cs:344
                        }                                                                                                                   // MakerGen.cs:345
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 19. PractitionerRole.availabilityExceptions
                this.Element_AvailabilityExceptions = new MakerElementInstance                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_AvailabilityExceptions",                                                                                // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String                                                                          // MakerGen.cs:287
                        {                                                                                                                   // MakerGen.cs:288
                        }                                                                                                                   // MakerGen.cs:289
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 20. PractitionerRole.endpoint
                this.Element_Endpoint = new MakerElementInstance                                                                            // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Endpoint",                                                                                              // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Reference                                                                         // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
        }                                                                                                                                   // MakerGen.cs:405
    }                                                                                                                                       // MakerGen.cs:389
}                                                                                                                                           // MakerGen.cs:440
