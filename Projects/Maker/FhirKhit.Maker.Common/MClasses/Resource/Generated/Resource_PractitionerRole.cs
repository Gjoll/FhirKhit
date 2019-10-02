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
    #endregion                                                                                                                              // MakerGen.cs:447
    /// <summary>
    /// Fhir resource 'PractitionerRole'
    /// </summary>
    // 0. PractitionerRole
    public class Resource_PractitionerRole : FhirKhit.Maker.Common.Resource.Resource_DomainResource                                         // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        // 11. PractitionerRole.availableTime
        public class Type_AvailableTime : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 12. PractitionerRole.availableTime.daysOfWeek
            public ElementDefinitionInfo Element_DaysOfWeek;                                                                                // MakerGen.cs:219
            // 13. PractitionerRole.availableTime.allDay
            public ElementDefinitionInfo Element_AllDay;                                                                                    // MakerGen.cs:219
            // 14. PractitionerRole.availableTime.availableStartTime
            public ElementDefinitionInfo Element_AvailableStartTime;                                                                        // MakerGen.cs:219
            // 15. PractitionerRole.availableTime.availableEndTime
            public ElementDefinitionInfo Element_AvailableEndTime;                                                                          // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "PractitionerRole.availableTime",                                                                                // MakerGen.cs:395
                    ElementId = "PractitionerRole.availableTime"                                                                            // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_DaysOfWeek.Write(sDef);                                                                                             // MakerGen.cs:223
                Element_AllDay.Write(sDef);                                                                                                 // MakerGen.cs:223
                Element_AvailableStartTime.Write(sDef);                                                                                     // MakerGen.cs:223
                Element_AvailableEndTime.Write(sDef);                                                                                       // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_AvailableTime()                                                                                                     // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 12. PractitionerRole.availableTime.daysOfWeek
                    this.Element_DaysOfWeek = new ElementDefinitionInfo                                                                     // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_DaysOfWeek",                                                                                        // MakerGen.cs:238
                        Path= "PractitionerRole.availableTime.daysOfWeek",                                                                  // MakerGen.cs:239
                        Id = "PractitionerRole.availableTime.daysOfWeek",                                                                   // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = -1,                                                                                                           // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                              // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 13. PractitionerRole.availableTime.allDay
                    this.Element_AllDay = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_AllDay",                                                                                            // MakerGen.cs:238
                        Path= "PractitionerRole.availableTime.allDay",                                                                      // MakerGen.cs:239
                        Id = "PractitionerRole.availableTime.allDay",                                                                       // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                           // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 14. PractitionerRole.availableTime.availableStartTime
                    this.Element_AvailableStartTime = new ElementDefinitionInfo                                                             // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_AvailableStartTime",                                                                                // MakerGen.cs:238
                        Path= "PractitionerRole.availableTime.availableStartTime",                                                          // MakerGen.cs:239
                        Id = "PractitionerRole.availableTime.availableStartTime",                                                           // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Time                                                              // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 15. PractitionerRole.availableTime.availableEndTime
                    this.Element_AvailableEndTime = new ElementDefinitionInfo                                                               // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_AvailableEndTime",                                                                                  // MakerGen.cs:238
                        Path= "PractitionerRole.availableTime.availableEndTime",                                                            // MakerGen.cs:239
                        Id = "PractitionerRole.availableTime.availableEndTime",                                                             // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Time                                                              // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 16. PractitionerRole.notAvailable
        public class Type_NotAvailable : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 17. PractitionerRole.notAvailable.description
            public ElementDefinitionInfo Element_Description;                                                                               // MakerGen.cs:219
            // 18. PractitionerRole.notAvailable.during
            public ElementDefinitionInfo Element_During;                                                                                    // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "PractitionerRole.notAvailable",                                                                                 // MakerGen.cs:395
                    ElementId = "PractitionerRole.notAvailable"                                                                             // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Description.Write(sDef);                                                                                            // MakerGen.cs:223
                Element_During.Write(sDef);                                                                                                 // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_NotAvailable()                                                                                                      // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 17. PractitionerRole.notAvailable.description
                    this.Element_Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Description",                                                                                       // MakerGen.cs:238
                        Path= "PractitionerRole.notAvailable.description",                                                                  // MakerGen.cs:239
                        Id = "PractitionerRole.notAvailable.description",                                                                   // MakerGen.cs:240
                        Min = 1,                                                                                                            // MakerGen.cs:241
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
                    // 18. PractitionerRole.notAvailable.during
                    this.Element_During = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_During",                                                                                            // MakerGen.cs:238
                        Path= "PractitionerRole.notAvailable.during",                                                                       // MakerGen.cs:239
                        Id = "PractitionerRole.notAvailable.during",                                                                        // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Period                                                                   // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 1. PractitionerRole.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:219
        // 2. PractitionerRole.active
        public ElementDefinitionInfo Element_Active;                                                                                        // MakerGen.cs:219
        // 3. PractitionerRole.period
        public ElementDefinitionInfo Element_Period;                                                                                        // MakerGen.cs:219
        // 4. PractitionerRole.practitioner
        public ElementDefinitionInfo Element_Practitioner;                                                                                  // MakerGen.cs:219
        // 5. PractitionerRole.organization
        public ElementDefinitionInfo Element_Organization;                                                                                  // MakerGen.cs:219
        // 6. PractitionerRole.code
        public ElementDefinitionInfo Element_Code;                                                                                          // MakerGen.cs:219
        // 7. PractitionerRole.specialty
        public ElementDefinitionInfo Element_Specialty;                                                                                     // MakerGen.cs:219
        // 8. PractitionerRole.location
        public ElementDefinitionInfo Element_Location;                                                                                      // MakerGen.cs:219
        // 9. PractitionerRole.healthcareService
        public ElementDefinitionInfo Element_HealthcareService;                                                                             // MakerGen.cs:219
        // 10. PractitionerRole.telecom
        public ElementDefinitionInfo Element_Telecom;                                                                                       // MakerGen.cs:219
        // 11. PractitionerRole.availableTime
        public ElementDefinitionInfo Element_AvailableTime;                                                                                 // MakerGen.cs:219
        // 16. PractitionerRole.notAvailable
        public ElementDefinitionInfo Element_NotAvailable;                                                                                  // MakerGen.cs:219
        // 19. PractitionerRole.availabilityExceptions
        public ElementDefinitionInfo Element_AvailabilityExceptions;                                                                        // MakerGen.cs:219
        // 20. PractitionerRole.endpoint
        public ElementDefinitionInfo Element_Endpoint;                                                                                      // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:390
        {                                                                                                                                   // MakerGen.cs:391
            base.Write(sDef);                                                                                                               // MakerGen.cs:392
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                Path = "PractitionerRole",                                                                                                  // MakerGen.cs:395
                ElementId = "PractitionerRole"                                                                                              // MakerGen.cs:396
            });                                                                                                                             // MakerGen.cs:397
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_Active.Write(sDef);                                                                                                     // MakerGen.cs:223
            Element_Period.Write(sDef);                                                                                                     // MakerGen.cs:223
            Element_Practitioner.Write(sDef);                                                                                               // MakerGen.cs:223
            Element_Organization.Write(sDef);                                                                                               // MakerGen.cs:223
            Element_Code.Write(sDef);                                                                                                       // MakerGen.cs:223
            Element_Specialty.Write(sDef);                                                                                                  // MakerGen.cs:223
            Element_Location.Write(sDef);                                                                                                   // MakerGen.cs:223
            Element_HealthcareService.Write(sDef);                                                                                          // MakerGen.cs:223
            Element_Telecom.Write(sDef);                                                                                                    // MakerGen.cs:223
            Element_AvailableTime.Write(sDef);                                                                                              // MakerGen.cs:223
            Element_NotAvailable.Write(sDef);                                                                                               // MakerGen.cs:223
            Element_AvailabilityExceptions.Write(sDef);                                                                                     // MakerGen.cs:223
            Element_Endpoint.Write(sDef);                                                                                                   // MakerGen.cs:223
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
        public Resource_PractitionerRole()                                                                                                  // MakerGen.cs:402
        {                                                                                                                                   // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:234
                // 1. PractitionerRole.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:238
                    Path= "PractitionerRole.identifier",                                                                                    // MakerGen.cs:239
                    Id = "PractitionerRole.identifier",                                                                                     // MakerGen.cs:240
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
                // 2. PractitionerRole.active
                this.Element_Active = new ElementDefinitionInfo                                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Active",                                                                                                // MakerGen.cs:238
                    Path= "PractitionerRole.active",                                                                                        // MakerGen.cs:239
                    Id = "PractitionerRole.active",                                                                                         // MakerGen.cs:240
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
                // 3. PractitionerRole.period
                this.Element_Period = new ElementDefinitionInfo                                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Period",                                                                                                // MakerGen.cs:238
                    Path= "PractitionerRole.period",                                                                                        // MakerGen.cs:239
                    Id = "PractitionerRole.period",                                                                                         // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Period                                                                       // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 4. PractitionerRole.practitioner
                this.Element_Practitioner = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Practitioner",                                                                                          // MakerGen.cs:238
                    Path= "PractitionerRole.practitioner",                                                                                  // MakerGen.cs:239
                    Id = "PractitionerRole.practitioner",                                                                                   // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Practitioner"                                                      // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 5. PractitionerRole.organization
                this.Element_Organization = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Organization",                                                                                          // MakerGen.cs:238
                    Path= "PractitionerRole.organization",                                                                                  // MakerGen.cs:239
                    Id = "PractitionerRole.organization",                                                                                   // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Organization"                                                      // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 6. PractitionerRole.code
                this.Element_Code = new ElementDefinitionInfo                                                                               // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Code",                                                                                                  // MakerGen.cs:238
                    Path= "PractitionerRole.code",                                                                                          // MakerGen.cs:239
                    Id = "PractitionerRole.code",                                                                                           // MakerGen.cs:240
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
                // 7. PractitionerRole.specialty
                this.Element_Specialty = new ElementDefinitionInfo                                                                          // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Specialty",                                                                                             // MakerGen.cs:238
                    Path= "PractitionerRole.specialty",                                                                                     // MakerGen.cs:239
                    Id = "PractitionerRole.specialty",                                                                                      // MakerGen.cs:240
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
                // 8. PractitionerRole.location
                this.Element_Location = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Location",                                                                                              // MakerGen.cs:238
                    Path= "PractitionerRole.location",                                                                                      // MakerGen.cs:239
                    Id = "PractitionerRole.location",                                                                                       // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Location"                                                          // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 9. PractitionerRole.healthcareService
                this.Element_HealthcareService = new ElementDefinitionInfo                                                                  // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_HealthcareService",                                                                                     // MakerGen.cs:238
                    Path= "PractitionerRole.healthcareService",                                                                             // MakerGen.cs:239
                    Id = "PractitionerRole.healthcareService",                                                                              // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/HealthcareService"                                                 // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 10. PractitionerRole.telecom
                this.Element_Telecom = new ElementDefinitionInfo                                                                            // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Telecom",                                                                                               // MakerGen.cs:238
                    Path= "PractitionerRole.telecom",                                                                                       // MakerGen.cs:239
                    Id = "PractitionerRole.telecom",                                                                                        // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_ContactPoint                                                                 // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 11. PractitionerRole.availableTime
                this.Element_AvailableTime = new ElementDefinitionInfo                                                                      // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_AvailableTime",                                                                                         // MakerGen.cs:238
                    Path= "PractitionerRole.availableTime",                                                                                 // MakerGen.cs:239
                    Id = "PractitionerRole.availableTime",                                                                                  // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_AvailableTime                                                                                              // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 16. PractitionerRole.notAvailable
                this.Element_NotAvailable = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_NotAvailable",                                                                                          // MakerGen.cs:238
                    Path= "PractitionerRole.notAvailable",                                                                                  // MakerGen.cs:239
                    Id = "PractitionerRole.notAvailable",                                                                                   // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_NotAvailable                                                                                               // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 19. PractitionerRole.availabilityExceptions
                this.Element_AvailabilityExceptions = new ElementDefinitionInfo                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_AvailabilityExceptions",                                                                                // MakerGen.cs:238
                    Path= "PractitionerRole.availabilityExceptions",                                                                        // MakerGen.cs:239
                    Id = "PractitionerRole.availabilityExceptions",                                                                         // MakerGen.cs:240
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
            {                                                                                                                               // MakerGen.cs:234
                // 20. PractitionerRole.endpoint
                this.Element_Endpoint = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Endpoint",                                                                                              // MakerGen.cs:238
                    Path= "PractitionerRole.endpoint",                                                                                      // MakerGen.cs:239
                    Id = "PractitionerRole.endpoint",                                                                                       // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Endpoint"                                                          // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            this.Name = "PractitionerRole";                                                                                                 // MakerGen.cs:471
            this.Uri = "http://hl7.org/fhir/StructureDefinition/PractitionerRole";                                                          // MakerGen.cs:472
        }                                                                                                                                   // MakerGen.cs:405
    }                                                                                                                                       // MakerGen.cs:407
}                                                                                                                                           // MakerGen.cs:452
