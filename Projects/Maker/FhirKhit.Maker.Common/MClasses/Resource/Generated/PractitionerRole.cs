using System;                                                                                                                               // MakerGen.cs:457
using System.Diagnostics;                                                                                                                   // MakerGen.cs:458
using System.IO;                                                                                                                            // MakerGen.cs:459
using System.Linq;                                                                                                                          // MakerGen.cs:460
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:461
                                                                                                                                            // MakerGen.cs:462
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:463
{                                                                                                                                           // MakerGen.cs:464
    #region Json                                                                                                                            // MakerGen.cs:465
    #if NEVER                                                                                                                               // MakerGen.cs:466
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
    #endregion                                                                                                                              // MakerGen.cs:469
    /// <summary>
    /// Fhir resource 'PractitionerRole'
    /// </summary>
    // 0. PractitionerRole
    public class PractitionerRole : FhirKhit.Maker.Common.Resource.ResourceBase                                                             // MakerGen.cs:379
    {                                                                                                                                       // MakerGen.cs:380
        public class PractitionerRole_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 11. PractitionerRole.availableTime
            public class Type_AvailableTime : FhirKhit.Maker.Common.Complex.ComplexBase                                                     // MakerGen.cs:379
            {                                                                                                                               // MakerGen.cs:380
                public class Type_AvailableTime_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                      // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 12. PractitionerRole.availableTime.daysOfWeek
                    public ElementDefinitionInfo DaysOfWeek;                                                                                // MakerGen.cs:211
                    // 13. PractitionerRole.availableTime.allDay
                    public ElementDefinitionInfo AllDay;                                                                                    // MakerGen.cs:211
                    // 14. PractitionerRole.availableTime.availableStartTime
                    public ElementDefinitionInfo AvailableStartTime;                                                                        // MakerGen.cs:211
                    // 15. PractitionerRole.availableTime.availableEndTime
                    public ElementDefinitionInfo AvailableEndTime;                                                                          // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                    public Type_AvailableTime_Elements()                                                                                    // MakerGen.cs:387
                    {                                                                                                                       // MakerGen.cs:388
                        {                                                                                                                   // MakerGen.cs:226
                            // 12. PractitionerRole.availableTime.daysOfWeek
                            this.DaysOfWeek = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "DaysOfWeek",                                                                                        // MakerGen.cs:230
                                Path= "PractitionerRole.availableTime.daysOfWeek",                                                          // MakerGen.cs:231
                                Id = "PractitionerRole.availableTime.daysOfWeek",                                                           // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 13. PractitionerRole.availableTime.allDay
                            this.AllDay = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "AllDay",                                                                                            // MakerGen.cs:230
                                Path= "PractitionerRole.availableTime.allDay",                                                              // MakerGen.cs:231
                                Id = "PractitionerRole.availableTime.allDay",                                                               // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Boolean                                                             // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 14. PractitionerRole.availableTime.availableStartTime
                            this.AvailableStartTime = new ElementDefinitionInfo                                                             // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "AvailableStartTime",                                                                                // MakerGen.cs:230
                                Path= "PractitionerRole.availableTime.availableStartTime",                                                  // MakerGen.cs:231
                                Id = "PractitionerRole.availableTime.availableStartTime",                                                   // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Time                                                                // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 15. PractitionerRole.availableTime.availableEndTime
                            this.AvailableEndTime = new ElementDefinitionInfo                                                               // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "AvailableEndTime",                                                                                  // MakerGen.cs:230
                                Path= "PractitionerRole.availableTime.availableEndTime",                                                    // MakerGen.cs:231
                                Id = "PractitionerRole.availableTime.availableEndTime",                                                     // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Time                                                                // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        base.Write(sDef);                                                                                                   // MakerGen.cs:395
                        DaysOfWeek.Write(sDef);                                                                                             // MakerGen.cs:215
                        AllDay.Write(sDef);                                                                                                 // MakerGen.cs:215
                        AvailableStartTime.Write(sDef);                                                                                     // MakerGen.cs:215
                        AvailableEndTime.Write(sDef);                                                                                       // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:397
                }                                                                                                                           // MakerGen.cs:399
                public Type_AvailableTime_Elements Elements                                                                                 // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    get                                                                                                                     // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:404
                        if (this.elements == null)                                                                                          // MakerGen.cs:405
                            this.elements = new Type_AvailableTime_Elements();                                                              // MakerGen.cs:406
                        return this.elements;                                                                                               // MakerGen.cs:407
                    }                                                                                                                       // MakerGen.cs:408
                }                                                                                                                           // MakerGen.cs:409
                Type_AvailableTime_Elements elements;                                                                                       // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                public Type_AvailableTime()                                                                                                 // MakerGen.cs:413
                {                                                                                                                           // MakerGen.cs:414
                }                                                                                                                           // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:419
                {                                                                                                                           // MakerGen.cs:420
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:421
                    {                                                                                                                       // MakerGen.cs:422
                        Path = "PractitionerRole.availableTime",                                                                            // MakerGen.cs:423
                        ElementId = "PractitionerRole.availableTime"                                                                        // MakerGen.cs:424
                    });                                                                                                                     // MakerGen.cs:425
                    if (this.elements != null)                                                                                              // MakerGen.cs:426
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:427
                }                                                                                                                           // MakerGen.cs:428
            }                                                                                                                               // MakerGen.cs:429
            // 16. PractitionerRole.notAvailable
            public class Type_NotAvailable : FhirKhit.Maker.Common.Complex.ComplexBase                                                      // MakerGen.cs:379
            {                                                                                                                               // MakerGen.cs:380
                public class Type_NotAvailable_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                       // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 17. PractitionerRole.notAvailable.description
                    public ElementDefinitionInfo Description;                                                                               // MakerGen.cs:211
                    // 18. PractitionerRole.notAvailable.during
                    public ElementDefinitionInfo During;                                                                                    // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                    public Type_NotAvailable_Elements()                                                                                     // MakerGen.cs:387
                    {                                                                                                                       // MakerGen.cs:388
                        {                                                                                                                   // MakerGen.cs:226
                            // 17. PractitionerRole.notAvailable.description
                            this.Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Description",                                                                                       // MakerGen.cs:230
                                Path= "PractitionerRole.notAvailable.description",                                                          // MakerGen.cs:231
                                Id = "PractitionerRole.notAvailable.description",                                                           // MakerGen.cs:232
                                Min = 1,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 18. PractitionerRole.notAvailable.during
                            this.During = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "During",                                                                                            // MakerGen.cs:230
                                Path= "PractitionerRole.notAvailable.during",                                                               // MakerGen.cs:231
                                Id = "PractitionerRole.notAvailable.during",                                                                // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Period                                                                // MakerGen.cs:353
                                    {                                                                                                       // MakerGen.cs:354
                                    }                                                                                                       // MakerGen.cs:355
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        base.Write(sDef);                                                                                                   // MakerGen.cs:395
                        Description.Write(sDef);                                                                                            // MakerGen.cs:215
                        During.Write(sDef);                                                                                                 // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:397
                }                                                                                                                           // MakerGen.cs:399
                public Type_NotAvailable_Elements Elements                                                                                  // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    get                                                                                                                     // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:404
                        if (this.elements == null)                                                                                          // MakerGen.cs:405
                            this.elements = new Type_NotAvailable_Elements();                                                               // MakerGen.cs:406
                        return this.elements;                                                                                               // MakerGen.cs:407
                    }                                                                                                                       // MakerGen.cs:408
                }                                                                                                                           // MakerGen.cs:409
                Type_NotAvailable_Elements elements;                                                                                        // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                public Type_NotAvailable()                                                                                                  // MakerGen.cs:413
                {                                                                                                                           // MakerGen.cs:414
                }                                                                                                                           // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:419
                {                                                                                                                           // MakerGen.cs:420
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:421
                    {                                                                                                                       // MakerGen.cs:422
                        Path = "PractitionerRole.notAvailable",                                                                             // MakerGen.cs:423
                        ElementId = "PractitionerRole.notAvailable"                                                                         // MakerGen.cs:424
                    });                                                                                                                     // MakerGen.cs:425
                    if (this.elements != null)                                                                                              // MakerGen.cs:426
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:427
                }                                                                                                                           // MakerGen.cs:428
            }                                                                                                                               // MakerGen.cs:429
            // 1. PractitionerRole.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:211
            // 2. PractitionerRole.active
            public ElementDefinitionInfo Active;                                                                                            // MakerGen.cs:211
            // 3. PractitionerRole.period
            public ElementDefinitionInfo Period;                                                                                            // MakerGen.cs:211
            // 4. PractitionerRole.practitioner
            public ElementDefinitionInfo Practitioner;                                                                                      // MakerGen.cs:211
            // 5. PractitionerRole.organization
            public ElementDefinitionInfo Organization;                                                                                      // MakerGen.cs:211
            // 6. PractitionerRole.code
            public ElementDefinitionInfo Code;                                                                                              // MakerGen.cs:211
            // 7. PractitionerRole.specialty
            public ElementDefinitionInfo Specialty;                                                                                         // MakerGen.cs:211
            // 8. PractitionerRole.location
            public ElementDefinitionInfo Location;                                                                                          // MakerGen.cs:211
            // 9. PractitionerRole.healthcareService
            public ElementDefinitionInfo HealthcareService;                                                                                 // MakerGen.cs:211
            // 10. PractitionerRole.telecom
            public ElementDefinitionInfo Telecom;                                                                                           // MakerGen.cs:211
            // 11. PractitionerRole.availableTime
            public ElementDefinitionInfo AvailableTime;                                                                                     // MakerGen.cs:211
            // 16. PractitionerRole.notAvailable
            public ElementDefinitionInfo NotAvailable;                                                                                      // MakerGen.cs:211
            // 19. PractitionerRole.availabilityExceptions
            public ElementDefinitionInfo AvailabilityExceptions;                                                                            // MakerGen.cs:211
            // 20. PractitionerRole.endpoint
            public ElementDefinitionInfo Endpoint;                                                                                          // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
            public PractitionerRole_Elements()                                                                                              // MakerGen.cs:387
            {                                                                                                                               // MakerGen.cs:388
                {                                                                                                                           // MakerGen.cs:226
                    // 1. PractitionerRole.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Identifier",                                                                                                // MakerGen.cs:230
                        Path= "PractitionerRole.identifier",                                                                                // MakerGen.cs:231
                        Id = "PractitionerRole.identifier",                                                                                 // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:353
                            {                                                                                                               // MakerGen.cs:354
                            }                                                                                                               // MakerGen.cs:355
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 2. PractitionerRole.active
                    this.Active = new ElementDefinitionInfo                                                                                 // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Active",                                                                                                    // MakerGen.cs:230
                        Path= "PractitionerRole.active",                                                                                    // MakerGen.cs:231
                        Id = "PractitionerRole.active",                                                                                     // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Boolean                                                                     // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 3. PractitionerRole.period
                    this.Period = new ElementDefinitionInfo                                                                                 // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Period",                                                                                                    // MakerGen.cs:230
                        Path= "PractitionerRole.period",                                                                                    // MakerGen.cs:231
                        Id = "PractitionerRole.period",                                                                                     // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Period                                                                        // MakerGen.cs:353
                            {                                                                                                               // MakerGen.cs:354
                            }                                                                                                               // MakerGen.cs:355
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 4. PractitionerRole.practitioner
                    this.Practitioner = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Practitioner",                                                                                              // MakerGen.cs:230
                        Path= "PractitionerRole.practitioner",                                                                              // MakerGen.cs:231
                        Id = "PractitionerRole.practitioner",                                                                               // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner"                                                  // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 5. PractitionerRole.organization
                    this.Organization = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Organization",                                                                                              // MakerGen.cs:230
                        Path= "PractitionerRole.organization",                                                                              // MakerGen.cs:231
                        Id = "PractitionerRole.organization",                                                                               // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 6. PractitionerRole.code
                    this.Code = new ElementDefinitionInfo                                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Code",                                                                                                      // MakerGen.cs:230
                        Path= "PractitionerRole.code",                                                                                      // MakerGen.cs:231
                        Id = "PractitionerRole.code",                                                                                       // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 7. PractitionerRole.specialty
                    this.Specialty = new ElementDefinitionInfo                                                                              // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Specialty",                                                                                                 // MakerGen.cs:230
                        Path= "PractitionerRole.specialty",                                                                                 // MakerGen.cs:231
                        Id = "PractitionerRole.specialty",                                                                                  // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 8. PractitionerRole.location
                    this.Location = new ElementDefinitionInfo                                                                               // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Location",                                                                                                  // MakerGen.cs:230
                        Path= "PractitionerRole.location",                                                                                  // MakerGen.cs:231
                        Id = "PractitionerRole.location",                                                                                   // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Location"                                                      // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 9. PractitionerRole.healthcareService
                    this.HealthcareService = new ElementDefinitionInfo                                                                      // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "HealthcareService",                                                                                         // MakerGen.cs:230
                        Path= "PractitionerRole.healthcareService",                                                                         // MakerGen.cs:231
                        Id = "PractitionerRole.healthcareService",                                                                          // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/HealthcareService"                                             // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 10. PractitionerRole.telecom
                    this.Telecom = new ElementDefinitionInfo                                                                                // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Telecom",                                                                                                   // MakerGen.cs:230
                        Path= "PractitionerRole.telecom",                                                                                   // MakerGen.cs:231
                        Id = "PractitionerRole.telecom",                                                                                    // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.ContactPoint                                                                  // MakerGen.cs:353
                            {                                                                                                               // MakerGen.cs:354
                            }                                                                                                               // MakerGen.cs:355
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 11. PractitionerRole.availableTime
                    this.AvailableTime = new ElementDefinitionInfo                                                                          // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "AvailableTime",                                                                                             // MakerGen.cs:230
                        Path= "PractitionerRole.availableTime",                                                                             // MakerGen.cs:231
                        Id = "PractitionerRole.availableTime",                                                                              // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_AvailableTime                                                                                          // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 16. PractitionerRole.notAvailable
                    this.NotAvailable = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "NotAvailable",                                                                                              // MakerGen.cs:230
                        Path= "PractitionerRole.notAvailable",                                                                              // MakerGen.cs:231
                        Id = "PractitionerRole.notAvailable",                                                                               // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_NotAvailable                                                                                           // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 19. PractitionerRole.availabilityExceptions
                    this.AvailabilityExceptions = new ElementDefinitionInfo                                                                 // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "AvailabilityExceptions",                                                                                    // MakerGen.cs:230
                        Path= "PractitionerRole.availabilityExceptions",                                                                    // MakerGen.cs:231
                        Id = "PractitionerRole.availabilityExceptions",                                                                     // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 20. PractitionerRole.endpoint
                    this.Endpoint = new ElementDefinitionInfo                                                                               // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Endpoint",                                                                                                  // MakerGen.cs:230
                        Path= "PractitionerRole.endpoint",                                                                                  // MakerGen.cs:231
                        Id = "PractitionerRole.endpoint",                                                                                   // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Endpoint"                                                      // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                base.Write(sDef);                                                                                                           // MakerGen.cs:395
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:215
                Active.Write(sDef);                                                                                                         // MakerGen.cs:215
                Period.Write(sDef);                                                                                                         // MakerGen.cs:215
                Practitioner.Write(sDef);                                                                                                   // MakerGen.cs:215
                Organization.Write(sDef);                                                                                                   // MakerGen.cs:215
                Code.Write(sDef);                                                                                                           // MakerGen.cs:215
                Specialty.Write(sDef);                                                                                                      // MakerGen.cs:215
                Location.Write(sDef);                                                                                                       // MakerGen.cs:215
                HealthcareService.Write(sDef);                                                                                              // MakerGen.cs:215
                Telecom.Write(sDef);                                                                                                        // MakerGen.cs:215
                AvailableTime.Write(sDef);                                                                                                  // MakerGen.cs:215
                NotAvailable.Write(sDef);                                                                                                   // MakerGen.cs:215
                AvailabilityExceptions.Write(sDef);                                                                                         // MakerGen.cs:215
                Endpoint.Write(sDef);                                                                                                       // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:397
        }                                                                                                                                   // MakerGen.cs:399
        public PractitionerRole_Elements Elements                                                                                           // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            get                                                                                                                             // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:404
                if (this.elements == null)                                                                                                  // MakerGen.cs:405
                    this.elements = new PractitionerRole_Elements();                                                                        // MakerGen.cs:406
                return this.elements;                                                                                                       // MakerGen.cs:407
            }                                                                                                                               // MakerGen.cs:408
        }                                                                                                                                   // MakerGen.cs:409
        PractitionerRole_Elements elements;                                                                                                 // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
        public PractitionerRole()                                                                                                           // MakerGen.cs:413
        {                                                                                                                                   // MakerGen.cs:414
            this.Name = "PractitionerRole";                                                                                                 // MakerGen.cs:487
            this.Uri = "http://hl7.org/fhir/StructureDefinition/PractitionerRole";                                                          // MakerGen.cs:488
        }                                                                                                                                   // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:419
        {                                                                                                                                   // MakerGen.cs:420
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:421
            {                                                                                                                               // MakerGen.cs:422
                Path = "PractitionerRole",                                                                                                  // MakerGen.cs:423
                ElementId = "PractitionerRole"                                                                                              // MakerGen.cs:424
            });                                                                                                                             // MakerGen.cs:425
            if (this.elements != null)                                                                                                      // MakerGen.cs:426
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:427
        }                                                                                                                                   // MakerGen.cs:428
    }                                                                                                                                       // MakerGen.cs:429
}                                                                                                                                           // MakerGen.cs:474
