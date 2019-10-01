using System;                                                                                                                               // MakerGen.cs:462
using System.Diagnostics;                                                                                                                   // MakerGen.cs:463
using System.IO;                                                                                                                            // MakerGen.cs:464
using System.Linq;                                                                                                                          // MakerGen.cs:465
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:466
                                                                                                                                            // MakerGen.cs:467
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:468
{                                                                                                                                           // MakerGen.cs:469
    #region Json                                                                                                                            // MakerGen.cs:470
    #if NEVER                                                                                                                               // MakerGen.cs:471
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
    #endregion                                                                                                                              // MakerGen.cs:474
    /// <summary>
    /// Fhir resource 'HealthcareService'
    /// </summary>
    // 0. HealthcareService
    public class HealthcareService : FhirKhit.Maker.Common.Resource.ResourceBase                                                            // MakerGen.cs:384
    {                                                                                                                                       // MakerGen.cs:385
        public class HealthcareService_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                               // MakerGen.cs:386
        {                                                                                                                                   // MakerGen.cs:387
            // 15. HealthcareService.eligibility
            public class Type_Eligibility : FhirKhit.Maker.Common.Complex.ComplexBase                                                       // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                public class Type_Eligibility_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                        // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    // 16. HealthcareService.eligibility.code
                    public ElementDefinitionInfo Code;                                                                                      // MakerGen.cs:216
                    // 17. HealthcareService.eligibility.comment
                    public ElementDefinitionInfo Comment;                                                                                   // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                    public Type_Eligibility_Elements()                                                                                      // MakerGen.cs:392
                    {                                                                                                                       // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:231
                            // 16. HealthcareService.eligibility.code
                            this.Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Code",                                                                                              // MakerGen.cs:235
                                Path= "HealthcareService.eligibility.code",                                                                 // MakerGen.cs:236
                                Id = "HealthcareService.eligibility.code",                                                                  // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 17. HealthcareService.eligibility.comment
                            this.Comment = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Comment",                                                                                           // MakerGen.cs:235
                                Path= "HealthcareService.eligibility.comment",                                                              // MakerGen.cs:236
                                Id = "HealthcareService.eligibility.comment",                                                               // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Markdown                                                            // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:398
                    {                                                                                                                       // MakerGen.cs:399
                        base.Write(sDef);                                                                                                   // MakerGen.cs:400
                        Code.Write(sDef);                                                                                                   // MakerGen.cs:220
                        Comment.Write(sDef);                                                                                                // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:402
                }                                                                                                                           // MakerGen.cs:404
                public Type_Eligibility_Elements Elements                                                                                   // MakerGen.cs:406
                {                                                                                                                           // MakerGen.cs:407
                    get                                                                                                                     // MakerGen.cs:408
                    {                                                                                                                       // MakerGen.cs:409
                        if (this.elements == null)                                                                                          // MakerGen.cs:410
                            this.elements = new Type_Eligibility_Elements();                                                                // MakerGen.cs:411
                        return this.elements;                                                                                               // MakerGen.cs:412
                    }                                                                                                                       // MakerGen.cs:413
                }                                                                                                                           // MakerGen.cs:414
                Type_Eligibility_Elements elements;                                                                                         // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                public Type_Eligibility()                                                                                                   // MakerGen.cs:418
                {                                                                                                                           // MakerGen.cs:419
                }                                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:424
                {                                                                                                                           // MakerGen.cs:425
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:426
                    {                                                                                                                       // MakerGen.cs:427
                        Path = "HealthcareService.eligibility",                                                                             // MakerGen.cs:428
                        ElementId = "HealthcareService.eligibility"                                                                         // MakerGen.cs:429
                    });                                                                                                                     // MakerGen.cs:430
                    if (this.elements != null)                                                                                              // MakerGen.cs:431
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:432
                }                                                                                                                           // MakerGen.cs:433
            }                                                                                                                               // MakerGen.cs:434
            // 23. HealthcareService.availableTime
            public class Type_AvailableTime : FhirKhit.Maker.Common.Complex.ComplexBase                                                     // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                public class Type_AvailableTime_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                      // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    // 24. HealthcareService.availableTime.daysOfWeek
                    public ElementDefinitionInfo DaysOfWeek;                                                                                // MakerGen.cs:216
                    // 25. HealthcareService.availableTime.allDay
                    public ElementDefinitionInfo AllDay;                                                                                    // MakerGen.cs:216
                    // 26. HealthcareService.availableTime.availableStartTime
                    public ElementDefinitionInfo AvailableStartTime;                                                                        // MakerGen.cs:216
                    // 27. HealthcareService.availableTime.availableEndTime
                    public ElementDefinitionInfo AvailableEndTime;                                                                          // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                    public Type_AvailableTime_Elements()                                                                                    // MakerGen.cs:392
                    {                                                                                                                       // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:231
                            // 24. HealthcareService.availableTime.daysOfWeek
                            this.DaysOfWeek = new ElementDefinitionInfo                                                                     // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "DaysOfWeek",                                                                                        // MakerGen.cs:235
                                Path= "HealthcareService.availableTime.daysOfWeek",                                                         // MakerGen.cs:236
                                Id = "HealthcareService.availableTime.daysOfWeek",                                                          // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 25. HealthcareService.availableTime.allDay
                            this.AllDay = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "AllDay",                                                                                            // MakerGen.cs:235
                                Path= "HealthcareService.availableTime.allDay",                                                             // MakerGen.cs:236
                                Id = "HealthcareService.availableTime.allDay",                                                              // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Boolean                                                             // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 26. HealthcareService.availableTime.availableStartTime
                            this.AvailableStartTime = new ElementDefinitionInfo                                                             // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "AvailableStartTime",                                                                                // MakerGen.cs:235
                                Path= "HealthcareService.availableTime.availableStartTime",                                                 // MakerGen.cs:236
                                Id = "HealthcareService.availableTime.availableStartTime",                                                  // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Time                                                                // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 27. HealthcareService.availableTime.availableEndTime
                            this.AvailableEndTime = new ElementDefinitionInfo                                                               // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "AvailableEndTime",                                                                                  // MakerGen.cs:235
                                Path= "HealthcareService.availableTime.availableEndTime",                                                   // MakerGen.cs:236
                                Id = "HealthcareService.availableTime.availableEndTime",                                                    // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Time                                                                // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:398
                    {                                                                                                                       // MakerGen.cs:399
                        base.Write(sDef);                                                                                                   // MakerGen.cs:400
                        DaysOfWeek.Write(sDef);                                                                                             // MakerGen.cs:220
                        AllDay.Write(sDef);                                                                                                 // MakerGen.cs:220
                        AvailableStartTime.Write(sDef);                                                                                     // MakerGen.cs:220
                        AvailableEndTime.Write(sDef);                                                                                       // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:402
                }                                                                                                                           // MakerGen.cs:404
                public Type_AvailableTime_Elements Elements                                                                                 // MakerGen.cs:406
                {                                                                                                                           // MakerGen.cs:407
                    get                                                                                                                     // MakerGen.cs:408
                    {                                                                                                                       // MakerGen.cs:409
                        if (this.elements == null)                                                                                          // MakerGen.cs:410
                            this.elements = new Type_AvailableTime_Elements();                                                              // MakerGen.cs:411
                        return this.elements;                                                                                               // MakerGen.cs:412
                    }                                                                                                                       // MakerGen.cs:413
                }                                                                                                                           // MakerGen.cs:414
                Type_AvailableTime_Elements elements;                                                                                       // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                public Type_AvailableTime()                                                                                                 // MakerGen.cs:418
                {                                                                                                                           // MakerGen.cs:419
                }                                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:424
                {                                                                                                                           // MakerGen.cs:425
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:426
                    {                                                                                                                       // MakerGen.cs:427
                        Path = "HealthcareService.availableTime",                                                                           // MakerGen.cs:428
                        ElementId = "HealthcareService.availableTime"                                                                       // MakerGen.cs:429
                    });                                                                                                                     // MakerGen.cs:430
                    if (this.elements != null)                                                                                              // MakerGen.cs:431
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:432
                }                                                                                                                           // MakerGen.cs:433
            }                                                                                                                               // MakerGen.cs:434
            // 28. HealthcareService.notAvailable
            public class Type_NotAvailable : FhirKhit.Maker.Common.Complex.ComplexBase                                                      // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                public class Type_NotAvailable_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                       // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    // 29. HealthcareService.notAvailable.description
                    public ElementDefinitionInfo Description;                                                                               // MakerGen.cs:216
                    // 30. HealthcareService.notAvailable.during
                    public ElementDefinitionInfo During;                                                                                    // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                    public Type_NotAvailable_Elements()                                                                                     // MakerGen.cs:392
                    {                                                                                                                       // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:231
                            // 29. HealthcareService.notAvailable.description
                            this.Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Description",                                                                                       // MakerGen.cs:235
                                Path= "HealthcareService.notAvailable.description",                                                         // MakerGen.cs:236
                                Id = "HealthcareService.notAvailable.description",                                                          // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 30. HealthcareService.notAvailable.during
                            this.During = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "During",                                                                                            // MakerGen.cs:235
                                Path= "HealthcareService.notAvailable.during",                                                              // MakerGen.cs:236
                                Id = "HealthcareService.notAvailable.during",                                                               // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Period                                                                // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    }                                                                                                       // MakerGen.cs:360
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:398
                    {                                                                                                                       // MakerGen.cs:399
                        base.Write(sDef);                                                                                                   // MakerGen.cs:400
                        Description.Write(sDef);                                                                                            // MakerGen.cs:220
                        During.Write(sDef);                                                                                                 // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:402
                }                                                                                                                           // MakerGen.cs:404
                public Type_NotAvailable_Elements Elements                                                                                  // MakerGen.cs:406
                {                                                                                                                           // MakerGen.cs:407
                    get                                                                                                                     // MakerGen.cs:408
                    {                                                                                                                       // MakerGen.cs:409
                        if (this.elements == null)                                                                                          // MakerGen.cs:410
                            this.elements = new Type_NotAvailable_Elements();                                                               // MakerGen.cs:411
                        return this.elements;                                                                                               // MakerGen.cs:412
                    }                                                                                                                       // MakerGen.cs:413
                }                                                                                                                           // MakerGen.cs:414
                Type_NotAvailable_Elements elements;                                                                                        // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                public Type_NotAvailable()                                                                                                  // MakerGen.cs:418
                {                                                                                                                           // MakerGen.cs:419
                }                                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:424
                {                                                                                                                           // MakerGen.cs:425
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:426
                    {                                                                                                                       // MakerGen.cs:427
                        Path = "HealthcareService.notAvailable",                                                                            // MakerGen.cs:428
                        ElementId = "HealthcareService.notAvailable"                                                                        // MakerGen.cs:429
                    });                                                                                                                     // MakerGen.cs:430
                    if (this.elements != null)                                                                                              // MakerGen.cs:431
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:432
                }                                                                                                                           // MakerGen.cs:433
            }                                                                                                                               // MakerGen.cs:434
            // 1. HealthcareService.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:216
            // 2. HealthcareService.active
            public ElementDefinitionInfo Active;                                                                                            // MakerGen.cs:216
            // 3. HealthcareService.providedBy
            public ElementDefinitionInfo ProvidedBy;                                                                                        // MakerGen.cs:216
            // 4. HealthcareService.category
            public ElementDefinitionInfo Category;                                                                                          // MakerGen.cs:216
            // 5. HealthcareService.type
            public ElementDefinitionInfo Type;                                                                                              // MakerGen.cs:216
            // 6. HealthcareService.specialty
            public ElementDefinitionInfo Specialty;                                                                                         // MakerGen.cs:216
            // 7. HealthcareService.location
            public ElementDefinitionInfo Location;                                                                                          // MakerGen.cs:216
            // 8. HealthcareService.name
            public ElementDefinitionInfo Name;                                                                                              // MakerGen.cs:216
            // 9. HealthcareService.comment
            public ElementDefinitionInfo Comment;                                                                                           // MakerGen.cs:216
            // 10. HealthcareService.extraDetails
            public ElementDefinitionInfo ExtraDetails;                                                                                      // MakerGen.cs:216
            // 11. HealthcareService.photo
            public ElementDefinitionInfo Photo;                                                                                             // MakerGen.cs:216
            // 12. HealthcareService.telecom
            public ElementDefinitionInfo Telecom;                                                                                           // MakerGen.cs:216
            // 13. HealthcareService.coverageArea
            public ElementDefinitionInfo CoverageArea;                                                                                      // MakerGen.cs:216
            // 14. HealthcareService.serviceProvisionCode
            public ElementDefinitionInfo ServiceProvisionCode;                                                                              // MakerGen.cs:216
            // 15. HealthcareService.eligibility
            public ElementDefinitionInfo Eligibility;                                                                                       // MakerGen.cs:216
            // 18. HealthcareService.program
            public ElementDefinitionInfo Program;                                                                                           // MakerGen.cs:216
            // 19. HealthcareService.characteristic
            public ElementDefinitionInfo Characteristic;                                                                                    // MakerGen.cs:216
            // 20. HealthcareService.communication
            public ElementDefinitionInfo Communication;                                                                                     // MakerGen.cs:216
            // 21. HealthcareService.referralMethod
            public ElementDefinitionInfo ReferralMethod;                                                                                    // MakerGen.cs:216
            // 22. HealthcareService.appointmentRequired
            public ElementDefinitionInfo AppointmentRequired;                                                                               // MakerGen.cs:216
            // 23. HealthcareService.availableTime
            public ElementDefinitionInfo AvailableTime;                                                                                     // MakerGen.cs:216
            // 28. HealthcareService.notAvailable
            public ElementDefinitionInfo NotAvailable;                                                                                      // MakerGen.cs:216
            // 31. HealthcareService.availabilityExceptions
            public ElementDefinitionInfo AvailabilityExceptions;                                                                            // MakerGen.cs:216
            // 32. HealthcareService.endpoint
            public ElementDefinitionInfo Endpoint;                                                                                          // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
            public HealthcareService_Elements()                                                                                             // MakerGen.cs:392
            {                                                                                                                               // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:231
                    // 1. HealthcareService.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Identifier",                                                                                                // MakerGen.cs:235
                        Path= "HealthcareService.identifier",                                                                               // MakerGen.cs:236
                        Id = "HealthcareService.identifier",                                                                                // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 2. HealthcareService.active
                    this.Active = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Active",                                                                                                    // MakerGen.cs:235
                        Path= "HealthcareService.active",                                                                                   // MakerGen.cs:236
                        Id = "HealthcareService.active",                                                                                    // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Boolean                                                                     // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 3. HealthcareService.providedBy
                    this.ProvidedBy = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "ProvidedBy",                                                                                                // MakerGen.cs:235
                        Path= "HealthcareService.providedBy",                                                                               // MakerGen.cs:236
                        Id = "HealthcareService.providedBy",                                                                                // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 4. HealthcareService.category
                    this.Category = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Category",                                                                                                  // MakerGen.cs:235
                        Path= "HealthcareService.category",                                                                                 // MakerGen.cs:236
                        Id = "HealthcareService.category",                                                                                  // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 5. HealthcareService.type
                    this.Type = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Type",                                                                                                      // MakerGen.cs:235
                        Path= "HealthcareService.type",                                                                                     // MakerGen.cs:236
                        Id = "HealthcareService.type",                                                                                      // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 6. HealthcareService.specialty
                    this.Specialty = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Specialty",                                                                                                 // MakerGen.cs:235
                        Path= "HealthcareService.specialty",                                                                                // MakerGen.cs:236
                        Id = "HealthcareService.specialty",                                                                                 // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 7. HealthcareService.location
                    this.Location = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Location",                                                                                                  // MakerGen.cs:235
                        Path= "HealthcareService.location",                                                                                 // MakerGen.cs:236
                        Id = "HealthcareService.location",                                                                                  // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Location"                                                      // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 8. HealthcareService.name
                    this.Name = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Name",                                                                                                      // MakerGen.cs:235
                        Path= "HealthcareService.name",                                                                                     // MakerGen.cs:236
                        Id = "HealthcareService.name",                                                                                      // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 9. HealthcareService.comment
                    this.Comment = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Comment",                                                                                                   // MakerGen.cs:235
                        Path= "HealthcareService.comment",                                                                                  // MakerGen.cs:236
                        Id = "HealthcareService.comment",                                                                                   // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 10. HealthcareService.extraDetails
                    this.ExtraDetails = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "ExtraDetails",                                                                                              // MakerGen.cs:235
                        Path= "HealthcareService.extraDetails",                                                                             // MakerGen.cs:236
                        Id = "HealthcareService.extraDetails",                                                                              // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Markdown                                                                    // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 11. HealthcareService.photo
                    this.Photo = new ElementDefinitionInfo                                                                                  // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Photo",                                                                                                     // MakerGen.cs:235
                        Path= "HealthcareService.photo",                                                                                    // MakerGen.cs:236
                        Id = "HealthcareService.photo",                                                                                     // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Attachment                                                                    // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 12. HealthcareService.telecom
                    this.Telecom = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Telecom",                                                                                                   // MakerGen.cs:235
                        Path= "HealthcareService.telecom",                                                                                  // MakerGen.cs:236
                        Id = "HealthcareService.telecom",                                                                                   // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.ContactPoint                                                                  // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 13. HealthcareService.coverageArea
                    this.CoverageArea = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "CoverageArea",                                                                                              // MakerGen.cs:235
                        Path= "HealthcareService.coverageArea",                                                                             // MakerGen.cs:236
                        Id = "HealthcareService.coverageArea",                                                                              // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Location"                                                      // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 14. HealthcareService.serviceProvisionCode
                    this.ServiceProvisionCode = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "ServiceProvisionCode",                                                                                      // MakerGen.cs:235
                        Path= "HealthcareService.serviceProvisionCode",                                                                     // MakerGen.cs:236
                        Id = "HealthcareService.serviceProvisionCode",                                                                      // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 15. HealthcareService.eligibility
                    this.Eligibility = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Eligibility",                                                                                               // MakerGen.cs:235
                        Path= "HealthcareService.eligibility",                                                                              // MakerGen.cs:236
                        Id = "HealthcareService.eligibility",                                                                               // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Eligibility                                                                                            // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 18. HealthcareService.program
                    this.Program = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Program",                                                                                                   // MakerGen.cs:235
                        Path= "HealthcareService.program",                                                                                  // MakerGen.cs:236
                        Id = "HealthcareService.program",                                                                                   // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 19. HealthcareService.characteristic
                    this.Characteristic = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Characteristic",                                                                                            // MakerGen.cs:235
                        Path= "HealthcareService.characteristic",                                                                           // MakerGen.cs:236
                        Id = "HealthcareService.characteristic",                                                                            // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 20. HealthcareService.communication
                    this.Communication = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Communication",                                                                                             // MakerGen.cs:235
                        Path= "HealthcareService.communication",                                                                            // MakerGen.cs:236
                        Id = "HealthcareService.communication",                                                                             // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 21. HealthcareService.referralMethod
                    this.ReferralMethod = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "ReferralMethod",                                                                                            // MakerGen.cs:235
                        Path= "HealthcareService.referralMethod",                                                                           // MakerGen.cs:236
                        Id = "HealthcareService.referralMethod",                                                                            // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 22. HealthcareService.appointmentRequired
                    this.AppointmentRequired = new ElementDefinitionInfo                                                                    // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "AppointmentRequired",                                                                                       // MakerGen.cs:235
                        Path= "HealthcareService.appointmentRequired",                                                                      // MakerGen.cs:236
                        Id = "HealthcareService.appointmentRequired",                                                                       // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Boolean                                                                     // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 23. HealthcareService.availableTime
                    this.AvailableTime = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "AvailableTime",                                                                                             // MakerGen.cs:235
                        Path= "HealthcareService.availableTime",                                                                            // MakerGen.cs:236
                        Id = "HealthcareService.availableTime",                                                                             // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_AvailableTime                                                                                          // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 28. HealthcareService.notAvailable
                    this.NotAvailable = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "NotAvailable",                                                                                              // MakerGen.cs:235
                        Path= "HealthcareService.notAvailable",                                                                             // MakerGen.cs:236
                        Id = "HealthcareService.notAvailable",                                                                              // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_NotAvailable                                                                                           // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 31. HealthcareService.availabilityExceptions
                    this.AvailabilityExceptions = new ElementDefinitionInfo                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "AvailabilityExceptions",                                                                                    // MakerGen.cs:235
                        Path= "HealthcareService.availabilityExceptions",                                                                   // MakerGen.cs:236
                        Id = "HealthcareService.availabilityExceptions",                                                                    // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 32. HealthcareService.endpoint
                    this.Endpoint = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Endpoint",                                                                                                  // MakerGen.cs:235
                        Path= "HealthcareService.endpoint",                                                                                 // MakerGen.cs:236
                        Id = "HealthcareService.endpoint",                                                                                  // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Endpoint"                                                      // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:398
            {                                                                                                                               // MakerGen.cs:399
                base.Write(sDef);                                                                                                           // MakerGen.cs:400
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:220
                Active.Write(sDef);                                                                                                         // MakerGen.cs:220
                ProvidedBy.Write(sDef);                                                                                                     // MakerGen.cs:220
                Category.Write(sDef);                                                                                                       // MakerGen.cs:220
                Type.Write(sDef);                                                                                                           // MakerGen.cs:220
                Specialty.Write(sDef);                                                                                                      // MakerGen.cs:220
                Location.Write(sDef);                                                                                                       // MakerGen.cs:220
                Name.Write(sDef);                                                                                                           // MakerGen.cs:220
                Comment.Write(sDef);                                                                                                        // MakerGen.cs:220
                ExtraDetails.Write(sDef);                                                                                                   // MakerGen.cs:220
                Photo.Write(sDef);                                                                                                          // MakerGen.cs:220
                Telecom.Write(sDef);                                                                                                        // MakerGen.cs:220
                CoverageArea.Write(sDef);                                                                                                   // MakerGen.cs:220
                ServiceProvisionCode.Write(sDef);                                                                                           // MakerGen.cs:220
                Eligibility.Write(sDef);                                                                                                    // MakerGen.cs:220
                Program.Write(sDef);                                                                                                        // MakerGen.cs:220
                Characteristic.Write(sDef);                                                                                                 // MakerGen.cs:220
                Communication.Write(sDef);                                                                                                  // MakerGen.cs:220
                ReferralMethod.Write(sDef);                                                                                                 // MakerGen.cs:220
                AppointmentRequired.Write(sDef);                                                                                            // MakerGen.cs:220
                AvailableTime.Write(sDef);                                                                                                  // MakerGen.cs:220
                NotAvailable.Write(sDef);                                                                                                   // MakerGen.cs:220
                AvailabilityExceptions.Write(sDef);                                                                                         // MakerGen.cs:220
                Endpoint.Write(sDef);                                                                                                       // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:402
        }                                                                                                                                   // MakerGen.cs:404
        public HealthcareService_Elements Elements                                                                                          // MakerGen.cs:406
        {                                                                                                                                   // MakerGen.cs:407
            get                                                                                                                             // MakerGen.cs:408
            {                                                                                                                               // MakerGen.cs:409
                if (this.elements == null)                                                                                                  // MakerGen.cs:410
                    this.elements = new HealthcareService_Elements();                                                                       // MakerGen.cs:411
                return this.elements;                                                                                                       // MakerGen.cs:412
            }                                                                                                                               // MakerGen.cs:413
        }                                                                                                                                   // MakerGen.cs:414
        HealthcareService_Elements elements;                                                                                                // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
        public HealthcareService()                                                                                                          // MakerGen.cs:418
        {                                                                                                                                   // MakerGen.cs:419
            this.Name = "HealthcareService";                                                                                                // MakerGen.cs:492
            this.Uri = "http://hl7.org/fhir/StructureDefinition/HealthcareService";                                                         // MakerGen.cs:493
        }                                                                                                                                   // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:424
        {                                                                                                                                   // MakerGen.cs:425
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:426
            {                                                                                                                               // MakerGen.cs:427
                Path = "HealthcareService",                                                                                                 // MakerGen.cs:428
                ElementId = "HealthcareService"                                                                                             // MakerGen.cs:429
            });                                                                                                                             // MakerGen.cs:430
            if (this.elements != null)                                                                                                      // MakerGen.cs:431
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:432
        }                                                                                                                                   // MakerGen.cs:433
    }                                                                                                                                       // MakerGen.cs:434
}                                                                                                                                           // MakerGen.cs:479
