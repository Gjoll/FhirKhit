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
      "id": "InsurancePlan",
      "url": "http://hl7.org/fhir/StructureDefinition/InsurancePlan",
      "version": "4.0.0",
      "name": "InsurancePlan",
      "status": "draft",
      "publisher": "Health Level Seven International (Patient Administration)",
      "description": "Details of a Health Insurance product/plan provided by an organization.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "InsurancePlan",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "InsurancePlan",
            "path": "InsurancePlan",
            "short": "Details of a Health Insurance product/plan provided by an organization",
            "definition": "Details of a Health Insurance product/plan provided by an organization.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "InsurancePlan.identifier",
            "path": "InsurancePlan.identifier",
            "short": "Business Identifier for Product",
            "definition": "Business identifiers assigned to this health insurance product which remain constant as the resource is updated and propagates from server to server.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Identifier"
              }
            ],
            "condition": [
              "ipn-1"
            ],
            "isSummary": true
          },
          {
            "id": "InsurancePlan.status",
            "path": "InsurancePlan.status",
            "short": "draft | active | retired | unknown",
            "definition": "The current state of the health insurance product.",
            "requirements": "Need a flag to indicate a record is no longer to be used and should generally be hidden for the user in the UI.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "meaningWhenMissing": "Default interpretation is active.",
            "isModifier": true,
            "isModifierReason": "This element is labeled as a modifier because it is a status element that contains codes which means that the resource should not be treated as valid",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "PublicationStatus"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "required",
              "description": "The lifecycle status of an artifact.",
              "valueSet": "http://hl7.org/fhir/ValueSet/publication-status|4.0.0"
            }
          },
          {
            "id": "InsurancePlan.type",
            "path": "InsurancePlan.type",
            "short": "Kind of product",
            "definition": "The kind of health insurance product.",
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
                  "valueString": "InsurancePlanType"
                }
              ],
              "strength": "example",
              "description": "Used to categorize the product/plan.",
              "valueSet": "http://hl7.org/fhir/ValueSet/insuranceplan-type"
            }
          },
          {
            "id": "InsurancePlan.name",
            "path": "InsurancePlan.name",
            "short": "Official name",
            "definition": "Official name of the health insurance product as designated by the owner.",
            "comment": "If the name of the product/plan changes, consider putting the old name in the alias column so that it can still be located through searches.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "condition": [
              "ipn-1"
            ],
            "isSummary": true
          },
          {
            "id": "InsurancePlan.alias",
            "path": "InsurancePlan.alias",
            "short": "Alternate names",
            "definition": "A list of alternate names that the product is known as, or was known as in the past.",
            "comment": "There are no dates associated with the alias/historic names, as this is not intended to track when names were used, but to assist in searching so that older names can still result in identifying the product/plan.",
            "requirements": "Over time products/plans go through many changes and can be known by different names.\n\nFor searching knowing previous names that the product/plan was known by can be very useful.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "InsurancePlan.period",
            "path": "InsurancePlan.period",
            "short": "When the product is available",
            "definition": "The period of time that the health insurance product is available.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Period"
              }
            ]
          },
          {
            "id": "InsurancePlan.ownedBy",
            "path": "InsurancePlan.ownedBy",
            "short": "Plan issuer",
            "definition": "The entity that is providing  the health insurance product and underwriting the risk.  This is typically an insurance carriers, other third-party payers, or health plan sponsors comonly referred to as 'payers'.",
            "alias": [
              "Payer"
            ],
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
            "id": "InsurancePlan.administeredBy",
            "path": "InsurancePlan.administeredBy",
            "short": "Product administrator",
            "definition": "An organization which administer other services such as underwriting, customer service and/or claims processing on behalf of the health insurance product owner.",
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
            "id": "InsurancePlan.coverageArea",
            "path": "InsurancePlan.coverageArea",
            "short": "Where product applies",
            "definition": "The geographic region in which a health insurance product's benefits apply.",
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
            "id": "InsurancePlan.contact",
            "path": "InsurancePlan.contact",
            "short": "Contact for the product",
            "definition": "The contact for the health insurance product for a certain purpose.",
            "comment": "Where multiple contacts for the same purpose are provided there is a standard extension that can be used to determine which one is the preferred contact to use.",
            "requirements": "Need to keep track of assigned contact points within bigger organization.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "InsurancePlan.contact.purpose",
            "path": "InsurancePlan.contact.purpose",
            "short": "The type of contact",
            "definition": "Indicates a purpose for which the contact can be reached.",
            "requirements": "Need to distinguish between multiple contact persons.",
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
                  "valueString": "ContactPartyType"
                }
              ],
              "strength": "extensible",
              "description": "The purpose for which you would contact a contact party.",
              "valueSet": "http://hl7.org/fhir/ValueSet/contactentity-type"
            }
          },
          {
            "id": "InsurancePlan.contact.name",
            "path": "InsurancePlan.contact.name",
            "short": "A name associated with the contact",
            "definition": "A name associated with the contact.",
            "requirements": "Need to be able to track the person by name.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "HumanName"
              }
            ]
          },
          {
            "id": "InsurancePlan.contact.telecom",
            "path": "InsurancePlan.contact.telecom",
            "short": "Contact details (telephone, email, etc.)  for a contact",
            "definition": "A contact detail (e.g. a telephone number or an email address) by which the party may be contacted.",
            "requirements": "People have (primary) ways to contact them in some way such as phone, email.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "ContactPoint"
              }
            ]
          },
          {
            "id": "InsurancePlan.contact.address",
            "path": "InsurancePlan.contact.address",
            "short": "Visiting or postal addresses for the contact",
            "definition": "Visiting or postal addresses for the contact.",
            "requirements": "May need to keep track of a contact party's address for contacting, billing or reporting requirements.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Address"
              }
            ]
          },
          {
            "id": "InsurancePlan.endpoint",
            "path": "InsurancePlan.endpoint",
            "short": "Technical endpoint",
            "definition": "The technical endpoints providing access to services operated for the health insurance product.",
            "requirements": "Organizations have multiple systems that provide various services and need to be able to define the technical connection details for how to connect to them, and for what purpose.",
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
          },
          {
            "id": "InsurancePlan.network",
            "path": "InsurancePlan.network",
            "short": "What networks are Included",
            "definition": "Reference to the network included in the health insurance product.",
            "comment": "Networks are represented as a hierarchy of organization resources.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ]
          },
          {
            "id": "InsurancePlan.coverage",
            "path": "InsurancePlan.coverage",
            "short": "Coverage details",
            "definition": "Details about the coverage offered by the insurance product.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "InsurancePlan.coverage.type",
            "path": "InsurancePlan.coverage.type",
            "short": "Type of coverage",
            "definition": "Type of coverage  (Medical; Dental; Mental Health; Substance Abuse; Vision; Drug; Short Term; Long Term Care; Hospice; Home Health).",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ]
          },
          {
            "id": "InsurancePlan.coverage.network",
            "path": "InsurancePlan.coverage.network",
            "short": "What networks provide coverage",
            "definition": "Reference to the network that providing the type of coverage.",
            "comment": "Networks are represented as a hierarchy of organization resources.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ]
          },
          {
            "id": "InsurancePlan.coverage.benefit",
            "path": "InsurancePlan.coverage.benefit",
            "short": "List of benefits",
            "definition": "Specific benefits under this type of coverage.",
            "min": 1,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "InsurancePlan.coverage.benefit.type",
            "path": "InsurancePlan.coverage.benefit.type",
            "short": "Type of benefit",
            "definition": "Type of benefit (primary care; speciality care; inpatient; outpatient).",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ]
          },
          {
            "id": "InsurancePlan.coverage.benefit.requirement",
            "path": "InsurancePlan.coverage.benefit.requirement",
            "short": "Referral requirements",
            "definition": "The referral requirements to have access/coverage for this benefit.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "InsurancePlan.coverage.benefit.limit",
            "path": "InsurancePlan.coverage.benefit.limit",
            "short": "Benefit limits",
            "definition": "The specific limits on the benefit.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "InsurancePlan.coverage.benefit.limit.value",
            "path": "InsurancePlan.coverage.benefit.limit.value",
            "short": "Maximum value allowed",
            "definition": "The maximum amount of a service item a plan will pay for a covered benefit.  For examples. wellness visits, or eyeglasses.",
            "comment": "May also be called “eligible expense,” “payment allowance,” or “negotiated rate.”.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Quantity"
              }
            ]
          },
          {
            "id": "InsurancePlan.coverage.benefit.limit.code",
            "path": "InsurancePlan.coverage.benefit.limit.code",
            "short": "Benefit limit details",
            "definition": "The specific limit on the benefit.",
            "comment": "Use `CodeableConcept.text` element if the data is free (uncoded) text.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ]
          },
          {
            "id": "InsurancePlan.plan",
            "path": "InsurancePlan.plan",
            "short": "Plan details",
            "definition": "Details about an insurance plan.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "InsurancePlan.plan.identifier",
            "path": "InsurancePlan.plan.identifier",
            "short": "Business Identifier for Product",
            "definition": "Business identifiers assigned to this health insurance plan which remain constant as the resource is updated and propagates from server to server.",
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
            "id": "InsurancePlan.plan.type",
            "path": "InsurancePlan.plan.type",
            "short": "Type of plan",
            "definition": "Type of plan. For example, \"Platinum\" or \"High Deductable\".",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ]
          },
          {
            "id": "InsurancePlan.plan.coverageArea",
            "path": "InsurancePlan.plan.coverageArea",
            "short": "Where product applies",
            "definition": "The geographic region in which a health insurance plan's benefits apply.",
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
            "id": "InsurancePlan.plan.network",
            "path": "InsurancePlan.plan.network",
            "short": "What networks provide coverage",
            "definition": "Reference to the network that providing the type of coverage.",
            "comment": "Networks are represented as a hierarchy of organization resources.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ]
          },
          {
            "id": "InsurancePlan.plan.generalCost",
            "path": "InsurancePlan.plan.generalCost",
            "short": "Overall costs",
            "definition": "Overall costs associated with the plan.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "InsurancePlan.plan.generalCost.type",
            "path": "InsurancePlan.plan.generalCost.type",
            "short": "Type of cost",
            "definition": "Type of cost.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ]
          },
          {
            "id": "InsurancePlan.plan.generalCost.groupSize",
            "path": "InsurancePlan.plan.generalCost.groupSize",
            "short": "Number of enrollees",
            "definition": "Number of participants enrolled in the plan.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "positiveInt"
              }
            ]
          },
          {
            "id": "InsurancePlan.plan.generalCost.cost",
            "path": "InsurancePlan.plan.generalCost.cost",
            "short": "Cost value",
            "definition": "Value of the cost.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Money"
              }
            ]
          },
          {
            "id": "InsurancePlan.plan.generalCost.comment",
            "path": "InsurancePlan.plan.generalCost.comment",
            "short": "Additional cost information",
            "definition": "Additional information about the general costs associated with this plan.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "InsurancePlan.plan.specificCost",
            "path": "InsurancePlan.plan.specificCost",
            "short": "Specific costs",
            "definition": "Costs associated with the coverage provided by the product.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "InsurancePlan.plan.specificCost.category",
            "path": "InsurancePlan.plan.specificCost.category",
            "short": "General category of benefit",
            "definition": "General category of benefit (Medical; Dental; Vision; Drug; Mental Health; Substance Abuse; Hospice, Home Health).",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ]
          },
          {
            "id": "InsurancePlan.plan.specificCost.benefit",
            "path": "InsurancePlan.plan.specificCost.benefit",
            "short": "Benefits list",
            "definition": "List of the specific benefits under this category of benefit.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "InsurancePlan.plan.specificCost.benefit.type",
            "path": "InsurancePlan.plan.specificCost.benefit.type",
            "short": "Type of specific benefit",
            "definition": "Type of specific benefit (preventative; primary care office visit; speciality office visit; hospitalization; emergency room; urgent care).",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ]
          },
          {
            "id": "InsurancePlan.plan.specificCost.benefit.cost",
            "path": "InsurancePlan.plan.specificCost.benefit.cost",
            "short": "List of the costs",
            "definition": "List of the costs associated with a specific benefit.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "InsurancePlan.plan.specificCost.benefit.cost.type",
            "path": "InsurancePlan.plan.specificCost.benefit.cost.type",
            "short": "Type of cost",
            "definition": "Type of cost (copay; individual cap; family cap; coinsurance; deductible).",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ]
          },
          {
            "id": "InsurancePlan.plan.specificCost.benefit.cost.applicability",
            "path": "InsurancePlan.plan.specificCost.benefit.cost.applicability",
            "short": "in-network | out-of-network | other",
            "definition": "Whether the cost applies to in-network or out-of-network providers (in-network; out-of-network; other).",
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
                  "valueString": "BenefitCostApplicability"
                }
              ],
              "strength": "required",
              "description": "Whether the cost applies to in-network or out-of-network providers.",
              "valueSet": "http://hl7.org/fhir/ValueSet/insuranceplan-applicability|4.0.0"
            }
          },
          {
            "id": "InsurancePlan.plan.specificCost.benefit.cost.qualifiers",
            "path": "InsurancePlan.plan.specificCost.benefit.cost.qualifiers",
            "short": "Additional information about the cost",
            "definition": "Additional information about the cost, such as information about funding sources (e.g. HSA, HRA, FSA, RRA).",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ]
          },
          {
            "id": "InsurancePlan.plan.specificCost.benefit.cost.value",
            "path": "InsurancePlan.plan.specificCost.benefit.cost.value",
            "short": "The actual cost value",
            "definition": "The actual cost value. (some of the costs may be represented as percentages rather than currency, e.g. 10% coinsurance).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Quantity"
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion
    /// <summary>
    /// Fhir resource 'InsurancePlan'
    /// </summary>
    // 0. InsurancePlan
    public class Resource_InsurancePlan : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 10. InsurancePlan.contact
        public class Type_Contact : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 11. InsurancePlan.contact.purpose
            public ElementDefinitionInfo Element_Purpose;
            // 12. InsurancePlan.contact.name
            public ElementDefinitionInfo Element_Name;
            // 13. InsurancePlan.contact.telecom
            public ElementDefinitionInfo Element_Telecom;
            // 14. InsurancePlan.contact.address
            public ElementDefinitionInfo Element_Address;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "InsurancePlan.contact",
                    ElementId = "InsurancePlan.contact"
                });
                Element_Purpose.Write(sDef);
                Element_Name.Write(sDef);
                Element_Telecom.Write(sDef);
                Element_Address.Write(sDef);
            }
            
            public Type_Contact()
            {
                {
                    // 11. InsurancePlan.contact.purpose
                    this.Element_Purpose = new ElementDefinitionInfo
                    {
                        Name = "Element_Purpose",
                        Path= "InsurancePlan.contact.purpose",
                        Id = "InsurancePlan.contact.purpose",
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
                    // 12. InsurancePlan.contact.name
                    this.Element_Name = new ElementDefinitionInfo
                    {
                        Name = "Element_Name",
                        Path= "InsurancePlan.contact.name",
                        Id = "InsurancePlan.contact.name",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_HumanName
                            {
                            }
                        }
                    };
                }
                {
                    // 13. InsurancePlan.contact.telecom
                    this.Element_Telecom = new ElementDefinitionInfo
                    {
                        Name = "Element_Telecom",
                        Path= "InsurancePlan.contact.telecom",
                        Id = "InsurancePlan.contact.telecom",
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
                    // 14. InsurancePlan.contact.address
                    this.Element_Address = new ElementDefinitionInfo
                    {
                        Name = "Element_Address",
                        Path= "InsurancePlan.contact.address",
                        Id = "InsurancePlan.contact.address",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Address
                            {
                            }
                        }
                    };
                }
            }
        }
        // 17. InsurancePlan.coverage
        public class Type_Coverage : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 20. InsurancePlan.coverage.benefit
            public class Type_Benefit : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 23. InsurancePlan.coverage.benefit.limit
                public class Type_Limit : FhirKhit.Maker.Common.Complex.ComplexBase
                {
                    // 24. InsurancePlan.coverage.benefit.limit.value
                    public ElementDefinitionInfo Element_Value;
                    // 25. InsurancePlan.coverage.benefit.limit.code
                    public ElementDefinitionInfo Element_Code;
                    
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                    {
                        base.Write(sDef);
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                        {
                            Path = "InsurancePlan.coverage.benefit.limit",
                            ElementId = "InsurancePlan.coverage.benefit.limit"
                        });
                        Element_Value.Write(sDef);
                        Element_Code.Write(sDef);
                    }
                    
                    public Type_Limit()
                    {
                        {
                            // 24. InsurancePlan.coverage.benefit.limit.value
                            this.Element_Value = new ElementDefinitionInfo
                            {
                                Name = "Element_Value",
                                Path= "InsurancePlan.coverage.benefit.limit.value",
                                Id = "InsurancePlan.coverage.benefit.limit.value",
                                Min = 0,
                                Max = 1,
                                Types = new BaseType[]
                                {
                                    new FhirKhit.Maker.Common.Complex.Type_Quantity
                                    {
                                    }
                                }
                            };
                        }
                        {
                            // 25. InsurancePlan.coverage.benefit.limit.code
                            this.Element_Code = new ElementDefinitionInfo
                            {
                                Name = "Element_Code",
                                Path= "InsurancePlan.coverage.benefit.limit.code",
                                Id = "InsurancePlan.coverage.benefit.limit.code",
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
                    }
                }
                // 21. InsurancePlan.coverage.benefit.type
                public ElementDefinitionInfo Element_Type;
                // 22. InsurancePlan.coverage.benefit.requirement
                public ElementDefinitionInfo Element_Requirement;
                // 23. InsurancePlan.coverage.benefit.limit
                public ElementDefinitionInfo Element_Limit;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "InsurancePlan.coverage.benefit",
                        ElementId = "InsurancePlan.coverage.benefit"
                    });
                    Element_Type.Write(sDef);
                    Element_Requirement.Write(sDef);
                    Element_Limit.Write(sDef);
                }
                
                public Type_Benefit()
                {
                    {
                        // 21. InsurancePlan.coverage.benefit.type
                        this.Element_Type = new ElementDefinitionInfo
                        {
                            Name = "Element_Type",
                            Path= "InsurancePlan.coverage.benefit.type",
                            Id = "InsurancePlan.coverage.benefit.type",
                            Min = 1,
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
                        // 22. InsurancePlan.coverage.benefit.requirement
                        this.Element_Requirement = new ElementDefinitionInfo
                        {
                            Name = "Element_Requirement",
                            Path= "InsurancePlan.coverage.benefit.requirement",
                            Id = "InsurancePlan.coverage.benefit.requirement",
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
                        // 23. InsurancePlan.coverage.benefit.limit
                        this.Element_Limit = new ElementDefinitionInfo
                        {
                            Name = "Element_Limit",
                            Path= "InsurancePlan.coverage.benefit.limit",
                            Id = "InsurancePlan.coverage.benefit.limit",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                                new Type_Limit
                                {
                                }
                            }
                        };
                    }
                }
            }
            // 18. InsurancePlan.coverage.type
            public ElementDefinitionInfo Element_Type;
            // 19. InsurancePlan.coverage.network
            public ElementDefinitionInfo Element_Network;
            // 20. InsurancePlan.coverage.benefit
            public ElementDefinitionInfo Element_Benefit;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "InsurancePlan.coverage",
                    ElementId = "InsurancePlan.coverage"
                });
                Element_Type.Write(sDef);
                Element_Network.Write(sDef);
                Element_Benefit.Write(sDef);
            }
            
            public Type_Coverage()
            {
                {
                    // 18. InsurancePlan.coverage.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "InsurancePlan.coverage.type",
                        Id = "InsurancePlan.coverage.type",
                        Min = 1,
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
                    // 19. InsurancePlan.coverage.network
                    this.Element_Network = new ElementDefinitionInfo
                    {
                        Name = "Element_Network",
                        Path= "InsurancePlan.coverage.network",
                        Id = "InsurancePlan.coverage.network",
                        Min = 0,
                        Max = -1,
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
                    // 20. InsurancePlan.coverage.benefit
                    this.Element_Benefit = new ElementDefinitionInfo
                    {
                        Name = "Element_Benefit",
                        Path= "InsurancePlan.coverage.benefit",
                        Id = "InsurancePlan.coverage.benefit",
                        Min = 1,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Benefit
                            {
                            }
                        }
                    };
                }
            }
        }
        // 26. InsurancePlan.plan
        public class Type_Plan : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 31. InsurancePlan.plan.generalCost
            public class Type_GeneralCost : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 32. InsurancePlan.plan.generalCost.type
                public ElementDefinitionInfo Element_Type;
                // 33. InsurancePlan.plan.generalCost.groupSize
                public ElementDefinitionInfo Element_GroupSize;
                // 34. InsurancePlan.plan.generalCost.cost
                public ElementDefinitionInfo Element_Cost;
                // 35. InsurancePlan.plan.generalCost.comment
                public ElementDefinitionInfo Element_Comment;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "InsurancePlan.plan.generalCost",
                        ElementId = "InsurancePlan.plan.generalCost"
                    });
                    Element_Type.Write(sDef);
                    Element_GroupSize.Write(sDef);
                    Element_Cost.Write(sDef);
                    Element_Comment.Write(sDef);
                }
                
                public Type_GeneralCost()
                {
                    {
                        // 32. InsurancePlan.plan.generalCost.type
                        this.Element_Type = new ElementDefinitionInfo
                        {
                            Name = "Element_Type",
                            Path= "InsurancePlan.plan.generalCost.type",
                            Id = "InsurancePlan.plan.generalCost.type",
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
                        // 33. InsurancePlan.plan.generalCost.groupSize
                        this.Element_GroupSize = new ElementDefinitionInfo
                        {
                            Name = "Element_GroupSize",
                            Path= "InsurancePlan.plan.generalCost.groupSize",
                            Id = "InsurancePlan.plan.generalCost.groupSize",
                            Min = 0,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_PositiveInt
                                {
                                }
                            }
                        };
                    }
                    {
                        // 34. InsurancePlan.plan.generalCost.cost
                        this.Element_Cost = new ElementDefinitionInfo
                        {
                            Name = "Element_Cost",
                            Path= "InsurancePlan.plan.generalCost.cost",
                            Id = "InsurancePlan.plan.generalCost.cost",
                            Min = 0,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Complex.Type_Money
                                {
                                }
                            }
                        };
                    }
                    {
                        // 35. InsurancePlan.plan.generalCost.comment
                        this.Element_Comment = new ElementDefinitionInfo
                        {
                            Name = "Element_Comment",
                            Path= "InsurancePlan.plan.generalCost.comment",
                            Id = "InsurancePlan.plan.generalCost.comment",
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
                }
            }
            // 36. InsurancePlan.plan.specificCost
            public class Type_SpecificCost : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 38. InsurancePlan.plan.specificCost.benefit
                public class Type_Benefit : FhirKhit.Maker.Common.Complex.ComplexBase
                {
                    // 40. InsurancePlan.plan.specificCost.benefit.cost
                    public class Type_Cost : FhirKhit.Maker.Common.Complex.ComplexBase
                    {
                        // 41. InsurancePlan.plan.specificCost.benefit.cost.type
                        public ElementDefinitionInfo Element_Type;
                        // 42. InsurancePlan.plan.specificCost.benefit.cost.applicability
                        public ElementDefinitionInfo Element_Applicability;
                        // 43. InsurancePlan.plan.specificCost.benefit.cost.qualifiers
                        public ElementDefinitionInfo Element_Qualifiers;
                        // 44. InsurancePlan.plan.specificCost.benefit.cost.value
                        public ElementDefinitionInfo Element_Value;
                        
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                        {
                            base.Write(sDef);
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                            {
                                Path = "InsurancePlan.plan.specificCost.benefit.cost",
                                ElementId = "InsurancePlan.plan.specificCost.benefit.cost"
                            });
                            Element_Type.Write(sDef);
                            Element_Applicability.Write(sDef);
                            Element_Qualifiers.Write(sDef);
                            Element_Value.Write(sDef);
                        }
                        
                        public Type_Cost()
                        {
                            {
                                // 41. InsurancePlan.plan.specificCost.benefit.cost.type
                                this.Element_Type = new ElementDefinitionInfo
                                {
                                    Name = "Element_Type",
                                    Path= "InsurancePlan.plan.specificCost.benefit.cost.type",
                                    Id = "InsurancePlan.plan.specificCost.benefit.cost.type",
                                    Min = 1,
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
                                // 42. InsurancePlan.plan.specificCost.benefit.cost.applicability
                                this.Element_Applicability = new ElementDefinitionInfo
                                {
                                    Name = "Element_Applicability",
                                    Path= "InsurancePlan.plan.specificCost.benefit.cost.applicability",
                                    Id = "InsurancePlan.plan.specificCost.benefit.cost.applicability",
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
                                // 43. InsurancePlan.plan.specificCost.benefit.cost.qualifiers
                                this.Element_Qualifiers = new ElementDefinitionInfo
                                {
                                    Name = "Element_Qualifiers",
                                    Path= "InsurancePlan.plan.specificCost.benefit.cost.qualifiers",
                                    Id = "InsurancePlan.plan.specificCost.benefit.cost.qualifiers",
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
                                // 44. InsurancePlan.plan.specificCost.benefit.cost.value
                                this.Element_Value = new ElementDefinitionInfo
                                {
                                    Name = "Element_Value",
                                    Path= "InsurancePlan.plan.specificCost.benefit.cost.value",
                                    Id = "InsurancePlan.plan.specificCost.benefit.cost.value",
                                    Min = 0,
                                    Max = 1,
                                    Types = new BaseType[]
                                    {
                                        new FhirKhit.Maker.Common.Complex.Type_Quantity
                                        {
                                        }
                                    }
                                };
                            }
                        }
                    }
                    // 39. InsurancePlan.plan.specificCost.benefit.type
                    public ElementDefinitionInfo Element_Type;
                    // 40. InsurancePlan.plan.specificCost.benefit.cost
                    public ElementDefinitionInfo Element_Cost;
                    
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                    {
                        base.Write(sDef);
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                        {
                            Path = "InsurancePlan.plan.specificCost.benefit",
                            ElementId = "InsurancePlan.plan.specificCost.benefit"
                        });
                        Element_Type.Write(sDef);
                        Element_Cost.Write(sDef);
                    }
                    
                    public Type_Benefit()
                    {
                        {
                            // 39. InsurancePlan.plan.specificCost.benefit.type
                            this.Element_Type = new ElementDefinitionInfo
                            {
                                Name = "Element_Type",
                                Path= "InsurancePlan.plan.specificCost.benefit.type",
                                Id = "InsurancePlan.plan.specificCost.benefit.type",
                                Min = 1,
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
                            // 40. InsurancePlan.plan.specificCost.benefit.cost
                            this.Element_Cost = new ElementDefinitionInfo
                            {
                                Name = "Element_Cost",
                                Path= "InsurancePlan.plan.specificCost.benefit.cost",
                                Id = "InsurancePlan.plan.specificCost.benefit.cost",
                                Min = 0,
                                Max = -1,
                                Types = new BaseType[]
                                {
                                    new Type_Cost
                                    {
                                    }
                                }
                            };
                        }
                    }
                }
                // 37. InsurancePlan.plan.specificCost.category
                public ElementDefinitionInfo Element_Category;
                // 38. InsurancePlan.plan.specificCost.benefit
                public ElementDefinitionInfo Element_Benefit;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "InsurancePlan.plan.specificCost",
                        ElementId = "InsurancePlan.plan.specificCost"
                    });
                    Element_Category.Write(sDef);
                    Element_Benefit.Write(sDef);
                }
                
                public Type_SpecificCost()
                {
                    {
                        // 37. InsurancePlan.plan.specificCost.category
                        this.Element_Category = new ElementDefinitionInfo
                        {
                            Name = "Element_Category",
                            Path= "InsurancePlan.plan.specificCost.category",
                            Id = "InsurancePlan.plan.specificCost.category",
                            Min = 1,
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
                        // 38. InsurancePlan.plan.specificCost.benefit
                        this.Element_Benefit = new ElementDefinitionInfo
                        {
                            Name = "Element_Benefit",
                            Path= "InsurancePlan.plan.specificCost.benefit",
                            Id = "InsurancePlan.plan.specificCost.benefit",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                                new Type_Benefit
                                {
                                }
                            }
                        };
                    }
                }
            }
            // 27. InsurancePlan.plan.identifier
            public ElementDefinitionInfo Element_Identifier;
            // 28. InsurancePlan.plan.type
            public ElementDefinitionInfo Element_Type;
            // 29. InsurancePlan.plan.coverageArea
            public ElementDefinitionInfo Element_CoverageArea;
            // 30. InsurancePlan.plan.network
            public ElementDefinitionInfo Element_Network;
            // 31. InsurancePlan.plan.generalCost
            public ElementDefinitionInfo Element_GeneralCost;
            // 36. InsurancePlan.plan.specificCost
            public ElementDefinitionInfo Element_SpecificCost;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "InsurancePlan.plan",
                    ElementId = "InsurancePlan.plan"
                });
                Element_Identifier.Write(sDef);
                Element_Type.Write(sDef);
                Element_CoverageArea.Write(sDef);
                Element_Network.Write(sDef);
                Element_GeneralCost.Write(sDef);
                Element_SpecificCost.Write(sDef);
            }
            
            public Type_Plan()
            {
                {
                    // 27. InsurancePlan.plan.identifier
                    this.Element_Identifier = new ElementDefinitionInfo
                    {
                        Name = "Element_Identifier",
                        Path= "InsurancePlan.plan.identifier",
                        Id = "InsurancePlan.plan.identifier",
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
                    // 28. InsurancePlan.plan.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "InsurancePlan.plan.type",
                        Id = "InsurancePlan.plan.type",
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
                    // 29. InsurancePlan.plan.coverageArea
                    this.Element_CoverageArea = new ElementDefinitionInfo
                    {
                        Name = "Element_CoverageArea",
                        Path= "InsurancePlan.plan.coverageArea",
                        Id = "InsurancePlan.plan.coverageArea",
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
                    // 30. InsurancePlan.plan.network
                    this.Element_Network = new ElementDefinitionInfo
                    {
                        Name = "Element_Network",
                        Path= "InsurancePlan.plan.network",
                        Id = "InsurancePlan.plan.network",
                        Min = 0,
                        Max = -1,
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
                    // 31. InsurancePlan.plan.generalCost
                    this.Element_GeneralCost = new ElementDefinitionInfo
                    {
                        Name = "Element_GeneralCost",
                        Path= "InsurancePlan.plan.generalCost",
                        Id = "InsurancePlan.plan.generalCost",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_GeneralCost
                            {
                            }
                        }
                    };
                }
                {
                    // 36. InsurancePlan.plan.specificCost
                    this.Element_SpecificCost = new ElementDefinitionInfo
                    {
                        Name = "Element_SpecificCost",
                        Path= "InsurancePlan.plan.specificCost",
                        Id = "InsurancePlan.plan.specificCost",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_SpecificCost
                            {
                            }
                        }
                    };
                }
            }
        }
        // 1. InsurancePlan.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. InsurancePlan.status
        public ElementDefinitionInfo Element_Status;
        // 3. InsurancePlan.type
        public ElementDefinitionInfo Element_Type;
        // 4. InsurancePlan.name
        public ElementDefinitionInfo Element_Name;
        // 5. InsurancePlan.alias
        public ElementDefinitionInfo Element_Alias;
        // 6. InsurancePlan.period
        public ElementDefinitionInfo Element_Period;
        // 7. InsurancePlan.ownedBy
        public ElementDefinitionInfo Element_OwnedBy;
        // 8. InsurancePlan.administeredBy
        public ElementDefinitionInfo Element_AdministeredBy;
        // 9. InsurancePlan.coverageArea
        public ElementDefinitionInfo Element_CoverageArea;
        // 10. InsurancePlan.contact
        public ElementDefinitionInfo Element_Contact;
        // 15. InsurancePlan.endpoint
        public ElementDefinitionInfo Element_Endpoint;
        // 16. InsurancePlan.network
        public ElementDefinitionInfo Element_Network;
        // 17. InsurancePlan.coverage
        public ElementDefinitionInfo Element_Coverage;
        // 26. InsurancePlan.plan
        public ElementDefinitionInfo Element_Plan;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "InsurancePlan",
                ElementId = "InsurancePlan"
            });
            Element_Identifier.Write(sDef);
            Element_Status.Write(sDef);
            Element_Type.Write(sDef);
            Element_Name.Write(sDef);
            Element_Alias.Write(sDef);
            Element_Period.Write(sDef);
            Element_OwnedBy.Write(sDef);
            Element_AdministeredBy.Write(sDef);
            Element_CoverageArea.Write(sDef);
            Element_Contact.Write(sDef);
            Element_Endpoint.Write(sDef);
            Element_Network.Write(sDef);
            Element_Coverage.Write(sDef);
            Element_Plan.Write(sDef);
        }
        
        public Resource_InsurancePlan()
        {
            {
                // 1. InsurancePlan.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "InsurancePlan.identifier",
                    Id = "InsurancePlan.identifier",
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
                // 2. InsurancePlan.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "InsurancePlan.status",
                    Id = "InsurancePlan.status",
                    Min = 0,
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
                // 3. InsurancePlan.type
                this.Element_Type = new ElementDefinitionInfo
                {
                    Name = "Element_Type",
                    Path= "InsurancePlan.type",
                    Id = "InsurancePlan.type",
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
                // 4. InsurancePlan.name
                this.Element_Name = new ElementDefinitionInfo
                {
                    Name = "Element_Name",
                    Path= "InsurancePlan.name",
                    Id = "InsurancePlan.name",
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
                // 5. InsurancePlan.alias
                this.Element_Alias = new ElementDefinitionInfo
                {
                    Name = "Element_Alias",
                    Path= "InsurancePlan.alias",
                    Id = "InsurancePlan.alias",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_String
                        {
                        }
                    }
                };
            }
            {
                // 6. InsurancePlan.period
                this.Element_Period = new ElementDefinitionInfo
                {
                    Name = "Element_Period",
                    Path= "InsurancePlan.period",
                    Id = "InsurancePlan.period",
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
                // 7. InsurancePlan.ownedBy
                this.Element_OwnedBy = new ElementDefinitionInfo
                {
                    Name = "Element_OwnedBy",
                    Path= "InsurancePlan.ownedBy",
                    Id = "InsurancePlan.ownedBy",
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
                // 8. InsurancePlan.administeredBy
                this.Element_AdministeredBy = new ElementDefinitionInfo
                {
                    Name = "Element_AdministeredBy",
                    Path= "InsurancePlan.administeredBy",
                    Id = "InsurancePlan.administeredBy",
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
                // 9. InsurancePlan.coverageArea
                this.Element_CoverageArea = new ElementDefinitionInfo
                {
                    Name = "Element_CoverageArea",
                    Path= "InsurancePlan.coverageArea",
                    Id = "InsurancePlan.coverageArea",
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
                // 10. InsurancePlan.contact
                this.Element_Contact = new ElementDefinitionInfo
                {
                    Name = "Element_Contact",
                    Path= "InsurancePlan.contact",
                    Id = "InsurancePlan.contact",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Contact
                        {
                        }
                    }
                };
            }
            {
                // 15. InsurancePlan.endpoint
                this.Element_Endpoint = new ElementDefinitionInfo
                {
                    Name = "Element_Endpoint",
                    Path= "InsurancePlan.endpoint",
                    Id = "InsurancePlan.endpoint",
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
            {
                // 16. InsurancePlan.network
                this.Element_Network = new ElementDefinitionInfo
                {
                    Name = "Element_Network",
                    Path= "InsurancePlan.network",
                    Id = "InsurancePlan.network",
                    Min = 0,
                    Max = -1,
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
                // 17. InsurancePlan.coverage
                this.Element_Coverage = new ElementDefinitionInfo
                {
                    Name = "Element_Coverage",
                    Path= "InsurancePlan.coverage",
                    Id = "InsurancePlan.coverage",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Coverage
                        {
                        }
                    }
                };
            }
            {
                // 26. InsurancePlan.plan
                this.Element_Plan = new ElementDefinitionInfo
                {
                    Name = "Element_Plan",
                    Path= "InsurancePlan.plan",
                    Id = "InsurancePlan.plan",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Plan
                        {
                        }
                    }
                };
            }
            this.Name = "InsurancePlan";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/InsurancePlan";
        }
    }
}
