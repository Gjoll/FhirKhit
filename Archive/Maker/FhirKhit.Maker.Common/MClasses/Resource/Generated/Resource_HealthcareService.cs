using System;                                                                                                                               // MakerGen.cs:432
using System.Diagnostics;                                                                                                                   // MakerGen.cs:433
using System.IO;                                                                                                                            // MakerGen.cs:434
using System.Linq;                                                                                                                          // MakerGen.cs:435
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:436
                                                                                                                                            // MakerGen.cs:437
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:438
{                                                                                                                                           // MakerGen.cs:439
    #region Json                                                                                                                            // MakerGen.cs:440
    #if NEVER                                                                                                                               // MakerGen.cs:441
    {
      "resourceType": "StructureDefinition",
      "id": "HealthcareService",
      "url": "http://hl7.org/fhir/StructureDefinition/HealthcareService",
      "version": "4.0.0",
      "name": "HealthcareService",
      "status": "draft",
      "publisher": "Health Level Seven International (Patient Administration)",
      "description": "The details of a healthcare service available at a location.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "HealthcareService",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "HealthcareService",
            "path": "HealthcareService",
            "short": "The details of a healthcare service available at a location",
            "definition": "The details of a healthcare service available at a location.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "HealthcareService.identifier",
            "path": "HealthcareService.identifier",
            "short": "External identifiers for this item",
            "definition": "External identifiers for this item.",
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
            "id": "HealthcareService.active",
            "path": "HealthcareService.active",
            "short": "Whether this HealthcareService record is in active use",
            "definition": "This flag is used to mark the record to not be used. This is not used when a center is closed for maintenance, or for holidays, the notAvailable period is to be used for this.",
            "comment": "This element is labeled as a modifier because it may be used to mark that the resource was created in error.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ],
            "meaningWhenMissing": "This resource is generally assumed to be active if no value is provided for the active element",
            "isModifier": true,
            "isModifierReason": "This element is labelled as a modifier because it is a status element that can indicate that a record should not be treated as valid",
            "isSummary": true
          },
          {
            "id": "HealthcareService.providedBy",
            "path": "HealthcareService.providedBy",
            "short": "Organization that provides this service",
            "definition": "The organization that provides this healthcare service.",
            "comment": "This property is recommended to be the same as the Location's managingOrganization, and if not provided should be interpreted as such. If the Location does not have a managing Organization, then this property should be populated.",
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
            "id": "HealthcareService.category",
            "path": "HealthcareService.category",
            "short": "Broad category of service being performed or delivered",
            "definition": "Identifies the broad category of service being performed or delivered.",
            "comment": "Selecting a Service Category then determines the list of relevant service types that can be selected in the primary service type.",
            "alias": [
              "service category"
            ],
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
              "description": "A category of the service(s) that could be provided.",
              "valueSet": "http://hl7.org/fhir/ValueSet/service-category"
            }
          },
          {
            "id": "HealthcareService.type",
            "path": "HealthcareService.type",
            "short": "Type of service that may be delivered or performed",
            "definition": "The specific type of service that may be delivered or performed.",
            "alias": [
              "service type"
            ],
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
              "description": "Additional details about where the content was created (e.g. clinical specialty).",
              "valueSet": "http://hl7.org/fhir/ValueSet/service-type"
            }
          },
          {
            "id": "HealthcareService.specialty",
            "path": "HealthcareService.specialty",
            "short": "Specialties handled by the HealthcareService",
            "definition": "Collection of specialties handled by the service site. This is more of a medical term.",
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
                  "valueString": "service-specialty"
                }
              ],
              "strength": "preferred",
              "description": "A specialty that a healthcare service may provide.",
              "valueSet": "http://hl7.org/fhir/ValueSet/c80-practice-codes"
            }
          },
          {
            "id": "HealthcareService.location",
            "path": "HealthcareService.location",
            "short": "Location(s) where service may be provided",
            "definition": "The location(s) where this healthcare service may be provided.",
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
            "id": "HealthcareService.name",
            "path": "HealthcareService.name",
            "short": "Description of service as presented to a consumer while searching",
            "definition": "Further description of the service as it would be presented to a consumer while searching.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "isSummary": true
          },
          {
            "id": "HealthcareService.comment",
            "path": "HealthcareService.comment",
            "short": "Additional description and/or any specific issues not covered elsewhere",
            "definition": "Any additional description of the service and/or any specific issues not covered by the other attributes, which can be displayed as further detail under the serviceName.",
            "comment": "Would expect that a user would not see this information on a search results, and it would only be available when viewing the complete details of the service.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "isSummary": true
          },
          {
            "id": "HealthcareService.extraDetails",
            "path": "HealthcareService.extraDetails",
            "short": "Extra details about the service that can't be placed in the other fields",
            "definition": "Extra details about the service that can't be placed in the other fields.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "HealthcareService.photo",
            "path": "HealthcareService.photo",
            "short": "Facilitates quick identification of the service",
            "definition": "If there is a photo/symbol associated with this HealthcareService, it may be included here to facilitate quick identification of the service in a list.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Attachment"
              }
            ],
            "isSummary": true
          },
          {
            "id": "HealthcareService.telecom",
            "path": "HealthcareService.telecom",
            "short": "Contacts related to the healthcare service",
            "definition": "List of contacts related to this specific healthcare service.",
            "comment": "If this is empty, then refer to the location's contacts.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "ContactPoint"
              }
            ]
          },
          {
            "id": "HealthcareService.coverageArea",
            "path": "HealthcareService.coverageArea",
            "short": "Location(s) service is intended for/available to",
            "definition": "The location(s) that this service is available to (not where the service is provided).",
            "comment": "The locations referenced by the coverage area can include both specific locations, including areas, and also conceptual domains too (mode = kind), such as a physical area (tri-state area) and some other attribute (covered by Example Care Organization). These types of Locations are often not managed by any specific organization. This could also include generic locations such as \"in-home\".",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Location"
                ]
              }
            ]
          },
          {
            "id": "HealthcareService.serviceProvisionCode",
            "path": "HealthcareService.serviceProvisionCode",
            "short": "Conditions under which service is available/offered",
            "definition": "The code(s) that detail the conditions under which the healthcare service is available/offered.",
            "comment": "The provision means being commissioned by, contractually obliged or financially sourced. Types of costings that may apply to this healthcare service, such if the service may be available for free, some discounts available, or fees apply.",
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
                  "valueString": "ServiceProvisionConditions"
                }
              ],
              "strength": "example",
              "description": "The code(s) that detail the conditions under which the healthcare service is available/offered.",
              "valueSet": "http://hl7.org/fhir/ValueSet/service-provision-conditions"
            }
          },
          {
            "id": "HealthcareService.eligibility",
            "path": "HealthcareService.eligibility",
            "short": "Specific eligibility requirements required to use the service",
            "definition": "Does this service have specific eligibility requirements that need to be met in order to use the service?",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "HealthcareService.eligibility.code",
            "path": "HealthcareService.eligibility.code",
            "short": "Coded value for the eligibility",
            "definition": "Coded value for the eligibility.",
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
                  "valueString": "ServiceEligibility"
                }
              ],
              "strength": "example",
              "description": "Coded values underwhich a specific service is made available."
            }
          },
          {
            "id": "HealthcareService.eligibility.comment",
            "path": "HealthcareService.eligibility.comment",
            "short": "Describes the eligibility conditions for the service",
            "definition": "Describes the eligibility conditions for the service.",
            "comment": "The description of service eligibility should, in general, not exceed one or two paragraphs. It should be sufficient for a prospective consumer to determine if they are likely to be eligible or not. Where eligibility requirements and conditions are complex, it may simply be noted that an eligibility assessment is required. Where eligibility is determined by an outside source, such as an Act of Parliament, this should be noted, preferably with a reference to a commonly available copy of the source document such as a web page.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "HealthcareService.program",
            "path": "HealthcareService.program",
            "short": "Programs that this service is applicable to",
            "definition": "Programs that this service is applicable to.",
            "comment": "Programs are often defined externally to an Organization, commonly by governments; e.g. Home and Community Care Programs, Homeless Program, ….",
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
                  "valueString": "Program"
                }
              ],
              "strength": "example",
              "description": "Government or local programs that this service applies to.",
              "valueSet": "http://hl7.org/fhir/ValueSet/program"
            }
          },
          {
            "id": "HealthcareService.characteristic",
            "path": "HealthcareService.characteristic",
            "short": "Collection of characteristics (attributes)",
            "definition": "Collection of characteristics (attributes).",
            "comment": "These could be such things as is wheelchair accessible.",
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
                  "valueString": "ServiceCharacteristic"
                }
              ],
              "strength": "example",
              "description": "A custom attribute that could be provided at a service (e.g. Wheelchair accessibiliy)."
            }
          },
          {
            "id": "HealthcareService.communication",
            "path": "HealthcareService.communication",
            "short": "The language that this service is offered in",
            "definition": "Some services are specifically made available in multiple languages, this property permits a directory to declare the languages this is offered in. Typically this is only provided where a service operates in communities with mixed languages used.",
            "comment": "When using this property it indicates that the service is available with this language, it is not derived from the practitioners, and not all are required to use this language, just that this language is available while scheduling.",
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
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-maxValueSet",
                  "valueCanonical": "http://hl7.org/fhir/ValueSet/all-languages"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "Language"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "preferred",
              "description": "A human language.",
              "valueSet": "http://hl7.org/fhir/ValueSet/languages"
            }
          },
          {
            "id": "HealthcareService.referralMethod",
            "path": "HealthcareService.referralMethod",
            "short": "Ways that the service accepts referrals",
            "definition": "Ways that the service accepts referrals, if this is not provided then it is implied that no referral is required.",
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
                  "valueString": "ReferralMethod"
                }
              ],
              "strength": "example",
              "description": "The methods of referral can be used when referring to a specific HealthCareService resource.",
              "valueSet": "http://hl7.org/fhir/ValueSet/service-referral-method"
            }
          },
          {
            "id": "HealthcareService.appointmentRequired",
            "path": "HealthcareService.appointmentRequired",
            "short": "If an appointment is required for access to this service",
            "definition": "Indicates whether or not a prospective consumer will require an appointment for a particular service at a site to be provided by the Organization. Indicates if an appointment is required for access to this service.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ]
          },
          {
            "id": "HealthcareService.availableTime",
            "path": "HealthcareService.availableTime",
            "short": "Times the Service Site is available",
            "definition": "A collection of times that the Service Site is available.",
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
            "id": "HealthcareService.availableTime.daysOfWeek",
            "path": "HealthcareService.availableTime.daysOfWeek",
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
            "id": "HealthcareService.availableTime.allDay",
            "path": "HealthcareService.availableTime.allDay",
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
            "id": "HealthcareService.availableTime.availableStartTime",
            "path": "HealthcareService.availableTime.availableStartTime",
            "short": "Opening time of day (ignored if allDay = true)",
            "definition": "The opening time of day. Note: If the AllDay flag is set, then this time is ignored.",
            "comment": "The time zone is expected to be for where this HealthcareService is provided at.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "time"
              }
            ]
          },
          {
            "id": "HealthcareService.availableTime.availableEndTime",
            "path": "HealthcareService.availableTime.availableEndTime",
            "short": "Closing time of day (ignored if allDay = true)",
            "definition": "The closing time of day. Note: If the AllDay flag is set, then this time is ignored.",
            "comment": "The time zone is expected to be for where this HealthcareService is provided at.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "time"
              }
            ]
          },
          {
            "id": "HealthcareService.notAvailable",
            "path": "HealthcareService.notAvailable",
            "short": "Not available during this time due to provided reason",
            "definition": "The HealthcareService is not available during this period of time due to the provided reason.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "HealthcareService.notAvailable.description",
            "path": "HealthcareService.notAvailable.description",
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
            "id": "HealthcareService.notAvailable.during",
            "path": "HealthcareService.notAvailable.during",
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
            "id": "HealthcareService.availabilityExceptions",
            "path": "HealthcareService.availabilityExceptions",
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
            "id": "HealthcareService.endpoint",
            "path": "HealthcareService.endpoint",
            "short": "Technical endpoints providing access to electronic services operated for the healthcare service",
            "definition": "Technical endpoints providing access to services operated for the specific healthcare services defined at this resource.",
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
    #endregion                                                                                                                              // MakerGen.cs:444
    /// <summary>
    /// Fhir resource 'HealthcareService'
    /// </summary>
    // 0. HealthcareService
    public partial class Resource_HealthcareService : FhirKhit.Maker.Common.Resource.Resource_DomainResource                                // MakerGen.cs:381
    {                                                                                                                                       // MakerGen.cs:382
        // 15. HealthcareService.eligibility
        public partial class Type_Eligibility : FhirKhit.Maker.Common.Complex.ComplexBase                                                   // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 16. HealthcareService.eligibility.code
            public ElementDefinitionInfo Element_Code;                                                                                      // MakerGen.cs:217
            // 17. HealthcareService.eligibility.comment
            public ElementDefinitionInfo Element_Comment;                                                                                   // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:388
            {                                                                                                                               // MakerGen.cs:389
                base.Write(sDef);                                                                                                           // MakerGen.cs:390
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:391
                {                                                                                                                           // MakerGen.cs:392
                    Path = "HealthcareService.eligibility",                                                                                 // MakerGen.cs:393
                    ElementId = "HealthcareService.eligibility"                                                                             // MakerGen.cs:394
                });                                                                                                                         // MakerGen.cs:395
                Element_Code.Write(sDef);                                                                                                   // MakerGen.cs:221
                Element_Comment.Write(sDef);                                                                                                // MakerGen.cs:221
            }                                                                                                                               // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
            public Type_Eligibility()                                                                                                       // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:232
                    // 16. HealthcareService.eligibility.code
                    this.Element_Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Code",                                                                                              // MakerGen.cs:236
                        Path= "HealthcareService.eligibility.code",                                                                         // MakerGen.cs:237
                        Id = "HealthcareService.eligibility.code",                                                                          // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:316
                            {                                                                                                               // MakerGen.cs:317
                            }                                                                                                               // MakerGen.cs:320
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 17. HealthcareService.eligibility.comment
                    this.Element_Comment = new ElementDefinitionInfo                                                                        // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Comment",                                                                                           // MakerGen.cs:236
                        Path= "HealthcareService.eligibility.comment",                                                                      // MakerGen.cs:237
                        Id = "HealthcareService.eligibility.comment",                                                                       // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_Markdown                                                          // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
            }                                                                                                                               // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:405
        // 23. HealthcareService.availableTime
        public partial class Type_AvailableTime : FhirKhit.Maker.Common.Complex.ComplexBase                                                 // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 24. HealthcareService.availableTime.daysOfWeek
            public ElementDefinitionInfo Element_DaysOfWeek;                                                                                // MakerGen.cs:217
            // 25. HealthcareService.availableTime.allDay
            public ElementDefinitionInfo Element_AllDay;                                                                                    // MakerGen.cs:217
            // 26. HealthcareService.availableTime.availableStartTime
            public ElementDefinitionInfo Element_AvailableStartTime;                                                                        // MakerGen.cs:217
            // 27. HealthcareService.availableTime.availableEndTime
            public ElementDefinitionInfo Element_AvailableEndTime;                                                                          // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:388
            {                                                                                                                               // MakerGen.cs:389
                base.Write(sDef);                                                                                                           // MakerGen.cs:390
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:391
                {                                                                                                                           // MakerGen.cs:392
                    Path = "HealthcareService.availableTime",                                                                               // MakerGen.cs:393
                    ElementId = "HealthcareService.availableTime"                                                                           // MakerGen.cs:394
                });                                                                                                                         // MakerGen.cs:395
                Element_DaysOfWeek.Write(sDef);                                                                                             // MakerGen.cs:221
                Element_AllDay.Write(sDef);                                                                                                 // MakerGen.cs:221
                Element_AvailableStartTime.Write(sDef);                                                                                     // MakerGen.cs:221
                Element_AvailableEndTime.Write(sDef);                                                                                       // MakerGen.cs:221
            }                                                                                                                               // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
            public Type_AvailableTime()                                                                                                     // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:232
                    // 24. HealthcareService.availableTime.daysOfWeek
                    this.Element_DaysOfWeek = new ElementDefinitionInfo                                                                     // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_DaysOfWeek",                                                                                        // MakerGen.cs:236
                        Path= "HealthcareService.availableTime.daysOfWeek",                                                                 // MakerGen.cs:237
                        Id = "HealthcareService.availableTime.daysOfWeek",                                                                  // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = -1,                                                                                                           // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                              // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 25. HealthcareService.availableTime.allDay
                    this.Element_AllDay = new ElementDefinitionInfo                                                                         // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_AllDay",                                                                                            // MakerGen.cs:236
                        Path= "HealthcareService.availableTime.allDay",                                                                     // MakerGen.cs:237
                        Id = "HealthcareService.availableTime.allDay",                                                                      // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                           // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 26. HealthcareService.availableTime.availableStartTime
                    this.Element_AvailableStartTime = new ElementDefinitionInfo                                                             // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_AvailableStartTime",                                                                                // MakerGen.cs:236
                        Path= "HealthcareService.availableTime.availableStartTime",                                                         // MakerGen.cs:237
                        Id = "HealthcareService.availableTime.availableStartTime",                                                          // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_Time                                                              // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 27. HealthcareService.availableTime.availableEndTime
                    this.Element_AvailableEndTime = new ElementDefinitionInfo                                                               // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_AvailableEndTime",                                                                                  // MakerGen.cs:236
                        Path= "HealthcareService.availableTime.availableEndTime",                                                           // MakerGen.cs:237
                        Id = "HealthcareService.availableTime.availableEndTime",                                                            // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_Time                                                              // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
            }                                                                                                                               // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:405
        // 28. HealthcareService.notAvailable
        public partial class Type_NotAvailable : FhirKhit.Maker.Common.Complex.ComplexBase                                                  // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 29. HealthcareService.notAvailable.description
            public ElementDefinitionInfo Element_Description;                                                                               // MakerGen.cs:217
            // 30. HealthcareService.notAvailable.during
            public ElementDefinitionInfo Element_During;                                                                                    // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:388
            {                                                                                                                               // MakerGen.cs:389
                base.Write(sDef);                                                                                                           // MakerGen.cs:390
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:391
                {                                                                                                                           // MakerGen.cs:392
                    Path = "HealthcareService.notAvailable",                                                                                // MakerGen.cs:393
                    ElementId = "HealthcareService.notAvailable"                                                                            // MakerGen.cs:394
                });                                                                                                                         // MakerGen.cs:395
                Element_Description.Write(sDef);                                                                                            // MakerGen.cs:221
                Element_During.Write(sDef);                                                                                                 // MakerGen.cs:221
            }                                                                                                                               // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
            public Type_NotAvailable()                                                                                                      // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:232
                    // 29. HealthcareService.notAvailable.description
                    this.Element_Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Description",                                                                                       // MakerGen.cs:236
                        Path= "HealthcareService.notAvailable.description",                                                                 // MakerGen.cs:237
                        Id = "HealthcareService.notAvailable.description",                                                                  // MakerGen.cs:238
                        Min = 1,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 30. HealthcareService.notAvailable.during
                    this.Element_During = new ElementDefinitionInfo                                                                         // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_During",                                                                                            // MakerGen.cs:236
                        Path= "HealthcareService.notAvailable.during",                                                                      // MakerGen.cs:237
                        Id = "HealthcareService.notAvailable.during",                                                                       // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_Period                                                                   // MakerGen.cs:356
                            {                                                                                                               // MakerGen.cs:357
                            }                                                                                                               // MakerGen.cs:358
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
            }                                                                                                                               // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:405
        // 1. HealthcareService.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:217
        // 2. HealthcareService.active
        public ElementDefinitionInfo Element_Active;                                                                                        // MakerGen.cs:217
        // 3. HealthcareService.providedBy
        public ElementDefinitionInfo Element_ProvidedBy;                                                                                    // MakerGen.cs:217
        // 4. HealthcareService.category
        public ElementDefinitionInfo Element_Category;                                                                                      // MakerGen.cs:217
        // 5. HealthcareService.type
        public ElementDefinitionInfo Element_Type;                                                                                          // MakerGen.cs:217
        // 6. HealthcareService.specialty
        public ElementDefinitionInfo Element_Specialty;                                                                                     // MakerGen.cs:217
        // 7. HealthcareService.location
        public ElementDefinitionInfo Element_Location;                                                                                      // MakerGen.cs:217
        // 8. HealthcareService.name
        public ElementDefinitionInfo Element_Name;                                                                                          // MakerGen.cs:217
        // 9. HealthcareService.comment
        public ElementDefinitionInfo Element_Comment;                                                                                       // MakerGen.cs:217
        // 10. HealthcareService.extraDetails
        public ElementDefinitionInfo Element_ExtraDetails;                                                                                  // MakerGen.cs:217
        // 11. HealthcareService.photo
        public ElementDefinitionInfo Element_Photo;                                                                                         // MakerGen.cs:217
        // 12. HealthcareService.telecom
        public ElementDefinitionInfo Element_Telecom;                                                                                       // MakerGen.cs:217
        // 13. HealthcareService.coverageArea
        public ElementDefinitionInfo Element_CoverageArea;                                                                                  // MakerGen.cs:217
        // 14. HealthcareService.serviceProvisionCode
        public ElementDefinitionInfo Element_ServiceProvisionCode;                                                                          // MakerGen.cs:217
        // 15. HealthcareService.eligibility
        public ElementDefinitionInfo Element_Eligibility;                                                                                   // MakerGen.cs:217
        // 18. HealthcareService.program
        public ElementDefinitionInfo Element_Program;                                                                                       // MakerGen.cs:217
        // 19. HealthcareService.characteristic
        public ElementDefinitionInfo Element_Characteristic;                                                                                // MakerGen.cs:217
        // 20. HealthcareService.communication
        public ElementDefinitionInfo Element_Communication;                                                                                 // MakerGen.cs:217
        // 21. HealthcareService.referralMethod
        public ElementDefinitionInfo Element_ReferralMethod;                                                                                // MakerGen.cs:217
        // 22. HealthcareService.appointmentRequired
        public ElementDefinitionInfo Element_AppointmentRequired;                                                                           // MakerGen.cs:217
        // 23. HealthcareService.availableTime
        public ElementDefinitionInfo Element_AvailableTime;                                                                                 // MakerGen.cs:217
        // 28. HealthcareService.notAvailable
        public ElementDefinitionInfo Element_NotAvailable;                                                                                  // MakerGen.cs:217
        // 31. HealthcareService.availabilityExceptions
        public ElementDefinitionInfo Element_AvailabilityExceptions;                                                                        // MakerGen.cs:217
        // 32. HealthcareService.endpoint
        public ElementDefinitionInfo Element_Endpoint;                                                                                      // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:388
        {                                                                                                                                   // MakerGen.cs:389
            base.Write(sDef);                                                                                                               // MakerGen.cs:390
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:391
            {                                                                                                                               // MakerGen.cs:392
                Path = "HealthcareService",                                                                                                 // MakerGen.cs:393
                ElementId = "HealthcareService"                                                                                             // MakerGen.cs:394
            });                                                                                                                             // MakerGen.cs:395
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:221
            Element_Active.Write(sDef);                                                                                                     // MakerGen.cs:221
            Element_ProvidedBy.Write(sDef);                                                                                                 // MakerGen.cs:221
            Element_Category.Write(sDef);                                                                                                   // MakerGen.cs:221
            Element_Type.Write(sDef);                                                                                                       // MakerGen.cs:221
            Element_Specialty.Write(sDef);                                                                                                  // MakerGen.cs:221
            Element_Location.Write(sDef);                                                                                                   // MakerGen.cs:221
            Element_Name.Write(sDef);                                                                                                       // MakerGen.cs:221
            Element_Comment.Write(sDef);                                                                                                    // MakerGen.cs:221
            Element_ExtraDetails.Write(sDef);                                                                                               // MakerGen.cs:221
            Element_Photo.Write(sDef);                                                                                                      // MakerGen.cs:221
            Element_Telecom.Write(sDef);                                                                                                    // MakerGen.cs:221
            Element_CoverageArea.Write(sDef);                                                                                               // MakerGen.cs:221
            Element_ServiceProvisionCode.Write(sDef);                                                                                       // MakerGen.cs:221
            Element_Eligibility.Write(sDef);                                                                                                // MakerGen.cs:221
            Element_Program.Write(sDef);                                                                                                    // MakerGen.cs:221
            Element_Characteristic.Write(sDef);                                                                                             // MakerGen.cs:221
            Element_Communication.Write(sDef);                                                                                              // MakerGen.cs:221
            Element_ReferralMethod.Write(sDef);                                                                                             // MakerGen.cs:221
            Element_AppointmentRequired.Write(sDef);                                                                                        // MakerGen.cs:221
            Element_AvailableTime.Write(sDef);                                                                                              // MakerGen.cs:221
            Element_NotAvailable.Write(sDef);                                                                                               // MakerGen.cs:221
            Element_AvailabilityExceptions.Write(sDef);                                                                                     // MakerGen.cs:221
            Element_Endpoint.Write(sDef);                                                                                                   // MakerGen.cs:221
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
        public Resource_HealthcareService()                                                                                                 // MakerGen.cs:400
        {                                                                                                                                   // MakerGen.cs:401
            {                                                                                                                               // MakerGen.cs:232
                // 1. HealthcareService.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:236
                    Path= "HealthcareService.identifier",                                                                                   // MakerGen.cs:237
                    Id = "HealthcareService.identifier",                                                                                    // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Identifier                                                                   // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        }                                                                                                                   // MakerGen.cs:358
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 2. HealthcareService.active
                this.Element_Active = new ElementDefinitionInfo                                                                             // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Active",                                                                                                // MakerGen.cs:236
                    Path= "HealthcareService.active",                                                                                       // MakerGen.cs:237
                    Id = "HealthcareService.active",                                                                                        // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                               // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 3. HealthcareService.providedBy
                this.Element_ProvidedBy = new ElementDefinitionInfo                                                                         // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_ProvidedBy",                                                                                            // MakerGen.cs:236
                    Path= "HealthcareService.providedBy",                                                                                   // MakerGen.cs:237
                    Id = "HealthcareService.providedBy",                                                                                    // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:344
                        {                                                                                                                   // MakerGen.cs:345
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:347
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Organization"                                                      // MakerGen.cs:347
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:348
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 4. HealthcareService.category
                this.Element_Category = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Category",                                                                                              // MakerGen.cs:236
                    Path= "HealthcareService.category",                                                                                     // MakerGen.cs:237
                    Id = "HealthcareService.category",                                                                                      // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:316
                        {                                                                                                                   // MakerGen.cs:317
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 5. HealthcareService.type
                this.Element_Type = new ElementDefinitionInfo                                                                               // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Type",                                                                                                  // MakerGen.cs:236
                    Path= "HealthcareService.type",                                                                                         // MakerGen.cs:237
                    Id = "HealthcareService.type",                                                                                          // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:316
                        {                                                                                                                   // MakerGen.cs:317
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 6. HealthcareService.specialty
                this.Element_Specialty = new ElementDefinitionInfo                                                                          // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Specialty",                                                                                             // MakerGen.cs:236
                    Path= "HealthcareService.specialty",                                                                                    // MakerGen.cs:237
                    Id = "HealthcareService.specialty",                                                                                     // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:316
                        {                                                                                                                   // MakerGen.cs:317
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 7. HealthcareService.location
                this.Element_Location = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Location",                                                                                              // MakerGen.cs:236
                    Path= "HealthcareService.location",                                                                                     // MakerGen.cs:237
                    Id = "HealthcareService.location",                                                                                      // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:344
                        {                                                                                                                   // MakerGen.cs:345
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:347
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Location"                                                          // MakerGen.cs:347
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:348
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 8. HealthcareService.name
                this.Element_Name = new ElementDefinitionInfo                                                                               // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Name",                                                                                                  // MakerGen.cs:236
                    Path= "HealthcareService.name",                                                                                         // MakerGen.cs:237
                    Id = "HealthcareService.name",                                                                                          // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 9. HealthcareService.comment
                this.Element_Comment = new ElementDefinitionInfo                                                                            // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Comment",                                                                                               // MakerGen.cs:236
                    Path= "HealthcareService.comment",                                                                                      // MakerGen.cs:237
                    Id = "HealthcareService.comment",                                                                                       // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 10. HealthcareService.extraDetails
                this.Element_ExtraDetails = new ElementDefinitionInfo                                                                       // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_ExtraDetails",                                                                                          // MakerGen.cs:236
                    Path= "HealthcareService.extraDetails",                                                                                 // MakerGen.cs:237
                    Id = "HealthcareService.extraDetails",                                                                                  // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Markdown                                                              // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 11. HealthcareService.photo
                this.Element_Photo = new ElementDefinitionInfo                                                                              // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Photo",                                                                                                 // MakerGen.cs:236
                    Path= "HealthcareService.photo",                                                                                        // MakerGen.cs:237
                    Id = "HealthcareService.photo",                                                                                         // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Attachment                                                                   // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        }                                                                                                                   // MakerGen.cs:358
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 12. HealthcareService.telecom
                this.Element_Telecom = new ElementDefinitionInfo                                                                            // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Telecom",                                                                                               // MakerGen.cs:236
                    Path= "HealthcareService.telecom",                                                                                      // MakerGen.cs:237
                    Id = "HealthcareService.telecom",                                                                                       // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_ContactPoint                                                                 // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        }                                                                                                                   // MakerGen.cs:358
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 13. HealthcareService.coverageArea
                this.Element_CoverageArea = new ElementDefinitionInfo                                                                       // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_CoverageArea",                                                                                          // MakerGen.cs:236
                    Path= "HealthcareService.coverageArea",                                                                                 // MakerGen.cs:237
                    Id = "HealthcareService.coverageArea",                                                                                  // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:344
                        {                                                                                                                   // MakerGen.cs:345
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:347
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Location"                                                          // MakerGen.cs:347
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:348
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 14. HealthcareService.serviceProvisionCode
                this.Element_ServiceProvisionCode = new ElementDefinitionInfo                                                               // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_ServiceProvisionCode",                                                                                  // MakerGen.cs:236
                    Path= "HealthcareService.serviceProvisionCode",                                                                         // MakerGen.cs:237
                    Id = "HealthcareService.serviceProvisionCode",                                                                          // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:316
                        {                                                                                                                   // MakerGen.cs:317
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 15. HealthcareService.eligibility
                this.Element_Eligibility = new ElementDefinitionInfo                                                                        // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Eligibility",                                                                                           // MakerGen.cs:236
                    Path= "HealthcareService.eligibility",                                                                                  // MakerGen.cs:237
                    Id = "HealthcareService.eligibility",                                                                                   // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new Type_Eligibility                                                                                                // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:262
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 18. HealthcareService.program
                this.Element_Program = new ElementDefinitionInfo                                                                            // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Program",                                                                                               // MakerGen.cs:236
                    Path= "HealthcareService.program",                                                                                      // MakerGen.cs:237
                    Id = "HealthcareService.program",                                                                                       // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:316
                        {                                                                                                                   // MakerGen.cs:317
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 19. HealthcareService.characteristic
                this.Element_Characteristic = new ElementDefinitionInfo                                                                     // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Characteristic",                                                                                        // MakerGen.cs:236
                    Path= "HealthcareService.characteristic",                                                                               // MakerGen.cs:237
                    Id = "HealthcareService.characteristic",                                                                                // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:316
                        {                                                                                                                   // MakerGen.cs:317
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 20. HealthcareService.communication
                this.Element_Communication = new ElementDefinitionInfo                                                                      // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Communication",                                                                                         // MakerGen.cs:236
                    Path= "HealthcareService.communication",                                                                                // MakerGen.cs:237
                    Id = "HealthcareService.communication",                                                                                 // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:316
                        {                                                                                                                   // MakerGen.cs:317
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 21. HealthcareService.referralMethod
                this.Element_ReferralMethod = new ElementDefinitionInfo                                                                     // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_ReferralMethod",                                                                                        // MakerGen.cs:236
                    Path= "HealthcareService.referralMethod",                                                                               // MakerGen.cs:237
                    Id = "HealthcareService.referralMethod",                                                                                // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:316
                        {                                                                                                                   // MakerGen.cs:317
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 22. HealthcareService.appointmentRequired
                this.Element_AppointmentRequired = new ElementDefinitionInfo                                                                // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_AppointmentRequired",                                                                                   // MakerGen.cs:236
                    Path= "HealthcareService.appointmentRequired",                                                                          // MakerGen.cs:237
                    Id = "HealthcareService.appointmentRequired",                                                                           // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                               // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 23. HealthcareService.availableTime
                this.Element_AvailableTime = new ElementDefinitionInfo                                                                      // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_AvailableTime",                                                                                         // MakerGen.cs:236
                    Path= "HealthcareService.availableTime",                                                                                // MakerGen.cs:237
                    Id = "HealthcareService.availableTime",                                                                                 // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new Type_AvailableTime                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:262
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 28. HealthcareService.notAvailable
                this.Element_NotAvailable = new ElementDefinitionInfo                                                                       // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_NotAvailable",                                                                                          // MakerGen.cs:236
                    Path= "HealthcareService.notAvailable",                                                                                 // MakerGen.cs:237
                    Id = "HealthcareService.notAvailable",                                                                                  // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new Type_NotAvailable                                                                                               // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:262
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 31. HealthcareService.availabilityExceptions
                this.Element_AvailabilityExceptions = new ElementDefinitionInfo                                                             // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_AvailabilityExceptions",                                                                                // MakerGen.cs:236
                    Path= "HealthcareService.availabilityExceptions",                                                                       // MakerGen.cs:237
                    Id = "HealthcareService.availabilityExceptions",                                                                        // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 32. HealthcareService.endpoint
                this.Element_Endpoint = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Endpoint",                                                                                              // MakerGen.cs:236
                    Path= "HealthcareService.endpoint",                                                                                     // MakerGen.cs:237
                    Id = "HealthcareService.endpoint",                                                                                      // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:344
                        {                                                                                                                   // MakerGen.cs:345
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:347
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Endpoint"                                                          // MakerGen.cs:347
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:348
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            this.Name = "HealthcareService";                                                                                                // MakerGen.cs:468
            this.Uri = "http://hl7.org/fhir/StructureDefinition/HealthcareService";                                                         // MakerGen.cs:469
        }                                                                                                                                   // MakerGen.cs:403
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:449
