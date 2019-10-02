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
    #endregion
    /// <summary>
    /// Fhir resource 'HealthcareService'
    /// </summary>
    // 0. HealthcareService
    public partial class Resource_HealthcareService : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 15. HealthcareService.eligibility
        public partial class Type_Eligibility : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 16. HealthcareService.eligibility.code
            public ElementDefinitionInfo Element_Code;
            // 17. HealthcareService.eligibility.comment
            public ElementDefinitionInfo Element_Comment;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "HealthcareService.eligibility",
                    ElementId = "HealthcareService.eligibility"
                });
                Element_Code.Write(sDef);
                Element_Comment.Write(sDef);
            }
            
            public Type_Eligibility()
            {
                {
                    // 16. HealthcareService.eligibility.code
                    this.Element_Code = new ElementDefinitionInfo
                    {
                        Name = "Element_Code",
                        Path= "HealthcareService.eligibility.code",
                        Id = "HealthcareService.eligibility.code",
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
                    // 17. HealthcareService.eligibility.comment
                    this.Element_Comment = new ElementDefinitionInfo
                    {
                        Name = "Element_Comment",
                        Path= "HealthcareService.eligibility.comment",
                        Id = "HealthcareService.eligibility.comment",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Markdown
                            {
                            }
                        }
                    };
                }
            }
        }
        // 23. HealthcareService.availableTime
        public partial class Type_AvailableTime : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 24. HealthcareService.availableTime.daysOfWeek
            public ElementDefinitionInfo Element_DaysOfWeek;
            // 25. HealthcareService.availableTime.allDay
            public ElementDefinitionInfo Element_AllDay;
            // 26. HealthcareService.availableTime.availableStartTime
            public ElementDefinitionInfo Element_AvailableStartTime;
            // 27. HealthcareService.availableTime.availableEndTime
            public ElementDefinitionInfo Element_AvailableEndTime;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "HealthcareService.availableTime",
                    ElementId = "HealthcareService.availableTime"
                });
                Element_DaysOfWeek.Write(sDef);
                Element_AllDay.Write(sDef);
                Element_AvailableStartTime.Write(sDef);
                Element_AvailableEndTime.Write(sDef);
            }
            
            public Type_AvailableTime()
            {
                {
                    // 24. HealthcareService.availableTime.daysOfWeek
                    this.Element_DaysOfWeek = new ElementDefinitionInfo
                    {
                        Name = "Element_DaysOfWeek",
                        Path= "HealthcareService.availableTime.daysOfWeek",
                        Id = "HealthcareService.availableTime.daysOfWeek",
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
                    // 25. HealthcareService.availableTime.allDay
                    this.Element_AllDay = new ElementDefinitionInfo
                    {
                        Name = "Element_AllDay",
                        Path= "HealthcareService.availableTime.allDay",
                        Id = "HealthcareService.availableTime.allDay",
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
                    // 26. HealthcareService.availableTime.availableStartTime
                    this.Element_AvailableStartTime = new ElementDefinitionInfo
                    {
                        Name = "Element_AvailableStartTime",
                        Path= "HealthcareService.availableTime.availableStartTime",
                        Id = "HealthcareService.availableTime.availableStartTime",
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
                    // 27. HealthcareService.availableTime.availableEndTime
                    this.Element_AvailableEndTime = new ElementDefinitionInfo
                    {
                        Name = "Element_AvailableEndTime",
                        Path= "HealthcareService.availableTime.availableEndTime",
                        Id = "HealthcareService.availableTime.availableEndTime",
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
        // 28. HealthcareService.notAvailable
        public partial class Type_NotAvailable : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 29. HealthcareService.notAvailable.description
            public ElementDefinitionInfo Element_Description;
            // 30. HealthcareService.notAvailable.during
            public ElementDefinitionInfo Element_During;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "HealthcareService.notAvailable",
                    ElementId = "HealthcareService.notAvailable"
                });
                Element_Description.Write(sDef);
                Element_During.Write(sDef);
            }
            
            public Type_NotAvailable()
            {
                {
                    // 29. HealthcareService.notAvailable.description
                    this.Element_Description = new ElementDefinitionInfo
                    {
                        Name = "Element_Description",
                        Path= "HealthcareService.notAvailable.description",
                        Id = "HealthcareService.notAvailable.description",
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
                    // 30. HealthcareService.notAvailable.during
                    this.Element_During = new ElementDefinitionInfo
                    {
                        Name = "Element_During",
                        Path= "HealthcareService.notAvailable.during",
                        Id = "HealthcareService.notAvailable.during",
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
        // 1. HealthcareService.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. HealthcareService.active
        public ElementDefinitionInfo Element_Active;
        // 3. HealthcareService.providedBy
        public ElementDefinitionInfo Element_ProvidedBy;
        // 4. HealthcareService.category
        public ElementDefinitionInfo Element_Category;
        // 5. HealthcareService.type
        public ElementDefinitionInfo Element_Type;
        // 6. HealthcareService.specialty
        public ElementDefinitionInfo Element_Specialty;
        // 7. HealthcareService.location
        public ElementDefinitionInfo Element_Location;
        // 8. HealthcareService.name
        public ElementDefinitionInfo Element_Name;
        // 9. HealthcareService.comment
        public ElementDefinitionInfo Element_Comment;
        // 10. HealthcareService.extraDetails
        public ElementDefinitionInfo Element_ExtraDetails;
        // 11. HealthcareService.photo
        public ElementDefinitionInfo Element_Photo;
        // 12. HealthcareService.telecom
        public ElementDefinitionInfo Element_Telecom;
        // 13. HealthcareService.coverageArea
        public ElementDefinitionInfo Element_CoverageArea;
        // 14. HealthcareService.serviceProvisionCode
        public ElementDefinitionInfo Element_ServiceProvisionCode;
        // 15. HealthcareService.eligibility
        public ElementDefinitionInfo Element_Eligibility;
        // 18. HealthcareService.program
        public ElementDefinitionInfo Element_Program;
        // 19. HealthcareService.characteristic
        public ElementDefinitionInfo Element_Characteristic;
        // 20. HealthcareService.communication
        public ElementDefinitionInfo Element_Communication;
        // 21. HealthcareService.referralMethod
        public ElementDefinitionInfo Element_ReferralMethod;
        // 22. HealthcareService.appointmentRequired
        public ElementDefinitionInfo Element_AppointmentRequired;
        // 23. HealthcareService.availableTime
        public ElementDefinitionInfo Element_AvailableTime;
        // 28. HealthcareService.notAvailable
        public ElementDefinitionInfo Element_NotAvailable;
        // 31. HealthcareService.availabilityExceptions
        public ElementDefinitionInfo Element_AvailabilityExceptions;
        // 32. HealthcareService.endpoint
        public ElementDefinitionInfo Element_Endpoint;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "HealthcareService",
                ElementId = "HealthcareService"
            });
            Element_Identifier.Write(sDef);
            Element_Active.Write(sDef);
            Element_ProvidedBy.Write(sDef);
            Element_Category.Write(sDef);
            Element_Type.Write(sDef);
            Element_Specialty.Write(sDef);
            Element_Location.Write(sDef);
            Element_Name.Write(sDef);
            Element_Comment.Write(sDef);
            Element_ExtraDetails.Write(sDef);
            Element_Photo.Write(sDef);
            Element_Telecom.Write(sDef);
            Element_CoverageArea.Write(sDef);
            Element_ServiceProvisionCode.Write(sDef);
            Element_Eligibility.Write(sDef);
            Element_Program.Write(sDef);
            Element_Characteristic.Write(sDef);
            Element_Communication.Write(sDef);
            Element_ReferralMethod.Write(sDef);
            Element_AppointmentRequired.Write(sDef);
            Element_AvailableTime.Write(sDef);
            Element_NotAvailable.Write(sDef);
            Element_AvailabilityExceptions.Write(sDef);
            Element_Endpoint.Write(sDef);
        }
        
        public Resource_HealthcareService()
        {
            {
                // 1. HealthcareService.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "HealthcareService.identifier",
                    Id = "HealthcareService.identifier",
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
                // 2. HealthcareService.active
                this.Element_Active = new ElementDefinitionInfo
                {
                    Name = "Element_Active",
                    Path= "HealthcareService.active",
                    Id = "HealthcareService.active",
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
                // 3. HealthcareService.providedBy
                this.Element_ProvidedBy = new ElementDefinitionInfo
                {
                    Name = "Element_ProvidedBy",
                    Path= "HealthcareService.providedBy",
                    Id = "HealthcareService.providedBy",
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
                // 4. HealthcareService.category
                this.Element_Category = new ElementDefinitionInfo
                {
                    Name = "Element_Category",
                    Path= "HealthcareService.category",
                    Id = "HealthcareService.category",
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
                // 5. HealthcareService.type
                this.Element_Type = new ElementDefinitionInfo
                {
                    Name = "Element_Type",
                    Path= "HealthcareService.type",
                    Id = "HealthcareService.type",
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
                // 6. HealthcareService.specialty
                this.Element_Specialty = new ElementDefinitionInfo
                {
                    Name = "Element_Specialty",
                    Path= "HealthcareService.specialty",
                    Id = "HealthcareService.specialty",
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
                // 7. HealthcareService.location
                this.Element_Location = new ElementDefinitionInfo
                {
                    Name = "Element_Location",
                    Path= "HealthcareService.location",
                    Id = "HealthcareService.location",
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
                // 8. HealthcareService.name
                this.Element_Name = new ElementDefinitionInfo
                {
                    Name = "Element_Name",
                    Path= "HealthcareService.name",
                    Id = "HealthcareService.name",
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
                // 9. HealthcareService.comment
                this.Element_Comment = new ElementDefinitionInfo
                {
                    Name = "Element_Comment",
                    Path= "HealthcareService.comment",
                    Id = "HealthcareService.comment",
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
                // 10. HealthcareService.extraDetails
                this.Element_ExtraDetails = new ElementDefinitionInfo
                {
                    Name = "Element_ExtraDetails",
                    Path= "HealthcareService.extraDetails",
                    Id = "HealthcareService.extraDetails",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Markdown
                        {
                        }
                    }
                };
            }
            {
                // 11. HealthcareService.photo
                this.Element_Photo = new ElementDefinitionInfo
                {
                    Name = "Element_Photo",
                    Path= "HealthcareService.photo",
                    Id = "HealthcareService.photo",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Attachment
                        {
                        }
                    }
                };
            }
            {
                // 12. HealthcareService.telecom
                this.Element_Telecom = new ElementDefinitionInfo
                {
                    Name = "Element_Telecom",
                    Path= "HealthcareService.telecom",
                    Id = "HealthcareService.telecom",
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
                // 13. HealthcareService.coverageArea
                this.Element_CoverageArea = new ElementDefinitionInfo
                {
                    Name = "Element_CoverageArea",
                    Path= "HealthcareService.coverageArea",
                    Id = "HealthcareService.coverageArea",
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
                // 14. HealthcareService.serviceProvisionCode
                this.Element_ServiceProvisionCode = new ElementDefinitionInfo
                {
                    Name = "Element_ServiceProvisionCode",
                    Path= "HealthcareService.serviceProvisionCode",
                    Id = "HealthcareService.serviceProvisionCode",
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
                // 15. HealthcareService.eligibility
                this.Element_Eligibility = new ElementDefinitionInfo
                {
                    Name = "Element_Eligibility",
                    Path= "HealthcareService.eligibility",
                    Id = "HealthcareService.eligibility",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Eligibility
                        {
                        }
                    }
                };
            }
            {
                // 18. HealthcareService.program
                this.Element_Program = new ElementDefinitionInfo
                {
                    Name = "Element_Program",
                    Path= "HealthcareService.program",
                    Id = "HealthcareService.program",
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
                // 19. HealthcareService.characteristic
                this.Element_Characteristic = new ElementDefinitionInfo
                {
                    Name = "Element_Characteristic",
                    Path= "HealthcareService.characteristic",
                    Id = "HealthcareService.characteristic",
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
                // 20. HealthcareService.communication
                this.Element_Communication = new ElementDefinitionInfo
                {
                    Name = "Element_Communication",
                    Path= "HealthcareService.communication",
                    Id = "HealthcareService.communication",
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
                // 21. HealthcareService.referralMethod
                this.Element_ReferralMethod = new ElementDefinitionInfo
                {
                    Name = "Element_ReferralMethod",
                    Path= "HealthcareService.referralMethod",
                    Id = "HealthcareService.referralMethod",
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
                // 22. HealthcareService.appointmentRequired
                this.Element_AppointmentRequired = new ElementDefinitionInfo
                {
                    Name = "Element_AppointmentRequired",
                    Path= "HealthcareService.appointmentRequired",
                    Id = "HealthcareService.appointmentRequired",
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
                // 23. HealthcareService.availableTime
                this.Element_AvailableTime = new ElementDefinitionInfo
                {
                    Name = "Element_AvailableTime",
                    Path= "HealthcareService.availableTime",
                    Id = "HealthcareService.availableTime",
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
                // 28. HealthcareService.notAvailable
                this.Element_NotAvailable = new ElementDefinitionInfo
                {
                    Name = "Element_NotAvailable",
                    Path= "HealthcareService.notAvailable",
                    Id = "HealthcareService.notAvailable",
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
                // 31. HealthcareService.availabilityExceptions
                this.Element_AvailabilityExceptions = new ElementDefinitionInfo
                {
                    Name = "Element_AvailabilityExceptions",
                    Path= "HealthcareService.availabilityExceptions",
                    Id = "HealthcareService.availabilityExceptions",
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
                // 32. HealthcareService.endpoint
                this.Element_Endpoint = new ElementDefinitionInfo
                {
                    Name = "Element_Endpoint",
                    Path= "HealthcareService.endpoint",
                    Id = "HealthcareService.endpoint",
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
            this.Name = "HealthcareService";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/HealthcareService";
        }
    }
}
