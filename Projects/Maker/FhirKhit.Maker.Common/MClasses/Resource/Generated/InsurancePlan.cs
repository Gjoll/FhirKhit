using System;                                                                                                                               // MakerGen.cs:449
using System.Diagnostics;                                                                                                                   // MakerGen.cs:450
using System.IO;                                                                                                                            // MakerGen.cs:451
using System.Linq;                                                                                                                          // MakerGen.cs:452
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:453
                                                                                                                                            // MakerGen.cs:454
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:455
{                                                                                                                                           // MakerGen.cs:456
    #region Json                                                                                                                            // MakerGen.cs:457
    #if NEVER                                                                                                                               // MakerGen.cs:458
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
    #endregion                                                                                                                              // MakerGen.cs:461
    /// <summary>
    /// Fhir resource 'InsurancePlan'
    /// </summary>
    // 0. InsurancePlan
    public class InsurancePlan : FhirKhit.Maker.Common.Resource.ResourceBase                                                                // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        public class InsurancePlan_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                   // MakerGen.cs:385
        {                                                                                                                                   // MakerGen.cs:386
            // 10. InsurancePlan.contact
            public class Type_Contact : FhirKhit.Maker.Common.Complex.ComplexBase                                                           // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                public class Type_Contact_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                            // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:386
                    // 11. InsurancePlan.contact.purpose
                    public ElementDefinitionInfo Purpose;                                                                                   // MakerGen.cs:216
                    // 12. InsurancePlan.contact.name
                    public ElementDefinitionInfo Name;                                                                                      // MakerGen.cs:216
                    // 13. InsurancePlan.contact.telecom
                    public ElementDefinitionInfo Telecom;                                                                                   // MakerGen.cs:216
                    // 14. InsurancePlan.contact.address
                    public ElementDefinitionInfo Address;                                                                                   // MakerGen.cs:216
                    public Type_Contact_Elements()                                                                                          // MakerGen.cs:407
                    {                                                                                                                       // MakerGen.cs:408
                        {                                                                                                                   // MakerGen.cs:231
                            // 11. InsurancePlan.contact.purpose
                            this.Purpose = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Purpose",                                                                                           // MakerGen.cs:235
                                Path= "InsurancePlan.contact.purpose",                                                                      // MakerGen.cs:236
                                Id = "InsurancePlan.contact.purpose",                                                                       // MakerGen.cs:237
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
                            // 12. InsurancePlan.contact.name
                            this.Name = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Name",                                                                                              // MakerGen.cs:235
                                Path= "InsurancePlan.contact.name",                                                                         // MakerGen.cs:236
                                Id = "InsurancePlan.contact.name",                                                                          // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.HumanName                                                             // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    }                                                                                                       // MakerGen.cs:360
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 13. InsurancePlan.contact.telecom
                            this.Telecom = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Telecom",                                                                                           // MakerGen.cs:235
                                Path= "InsurancePlan.contact.telecom",                                                                      // MakerGen.cs:236
                                Id = "InsurancePlan.contact.telecom",                                                                       // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.ContactPoint                                                          // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    }                                                                                                       // MakerGen.cs:360
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 14. InsurancePlan.contact.address
                            this.Address = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Address",                                                                                           // MakerGen.cs:235
                                Path= "InsurancePlan.contact.address",                                                                      // MakerGen.cs:236
                                Id = "InsurancePlan.contact.address",                                                                       // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Address                                                               // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    }                                                                                                       // MakerGen.cs:360
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:427
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:412
                    {                                                                                                                       // MakerGen.cs:413
                        base.Write(sDef);                                                                                                   // MakerGen.cs:414
                        Purpose.Write(sDef);                                                                                                // MakerGen.cs:220
                        Name.Write(sDef);                                                                                                   // MakerGen.cs:220
                        Telecom.Write(sDef);                                                                                                // MakerGen.cs:220
                        Address.Write(sDef);                                                                                                // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:431
                }                                                                                                                           // MakerGen.cs:391
                public Type_Contact_Elements Elements { get; }                                                                              // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                public Type_Contact()                                                                                                       // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:395
                    this.Elements = new Type_Contact_Elements();                                                                            // MakerGen.cs:396
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:399
                {                                                                                                                           // MakerGen.cs:400
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:401
                }                                                                                                                           // MakerGen.cs:402
            }                                                                                                                               // MakerGen.cs:403
            // 17. InsurancePlan.coverage
            public class Type_Coverage : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                public class Type_Coverage_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                           // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:386
                    // 20. InsurancePlan.coverage.benefit
                    public class Type_Benefit : FhirKhit.Maker.Common.Complex.ComplexBase                                                   // MakerGen.cs:383
                    {                                                                                                                       // MakerGen.cs:384
                        public class Type_Benefit_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                    // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:386
                            // 23. InsurancePlan.coverage.benefit.limit
                            public class Type_Limit : FhirKhit.Maker.Common.Complex.ComplexBase                                             // MakerGen.cs:383
                            {                                                                                                               // MakerGen.cs:384
                                public class Type_Limit_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                              // MakerGen.cs:385
                                {                                                                                                           // MakerGen.cs:386
                                    // 24. InsurancePlan.coverage.benefit.limit.value
                                    public ElementDefinitionInfo Value;                                                                     // MakerGen.cs:216
                                    // 25. InsurancePlan.coverage.benefit.limit.code
                                    public ElementDefinitionInfo Code;                                                                      // MakerGen.cs:216
                                    public Type_Limit_Elements()                                                                            // MakerGen.cs:407
                                    {                                                                                                       // MakerGen.cs:408
                                        {                                                                                                   // MakerGen.cs:231
                                            // 24. InsurancePlan.coverage.benefit.limit.value
                                            this.Value = new ElementDefinitionInfo                                                          // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Value",                                                                             // MakerGen.cs:235
                                                Path= "InsurancePlan.coverage.benefit.limit.value",                                         // MakerGen.cs:236
                                                Id = "InsurancePlan.coverage.benefit.limit.value",                                          // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Complex.Quantity                                              // MakerGen.cs:358
                                                    {                                                                                       // MakerGen.cs:359
                                                    }                                                                                       // MakerGen.cs:360
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 25. InsurancePlan.coverage.benefit.limit.code
                                            this.Code = new ElementDefinitionInfo                                                           // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Code",                                                                              // MakerGen.cs:235
                                                Path= "InsurancePlan.coverage.benefit.limit.code",                                          // MakerGen.cs:236
                                                Id = "InsurancePlan.coverage.benefit.limit.code",                                           // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                       // MakerGen.cs:315
                                                    {                                                                                       // MakerGen.cs:316
                                                    }                                                                                       // MakerGen.cs:319
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                    }                                                                                                       // MakerGen.cs:427
                                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                     // MakerGen.cs:412
                                    {                                                                                                       // MakerGen.cs:413
                                        base.Write(sDef);                                                                                   // MakerGen.cs:414
                                        Value.Write(sDef);                                                                                  // MakerGen.cs:220
                                        Code.Write(sDef);                                                                                   // MakerGen.cs:220
                                    }                                                                                                       // MakerGen.cs:431
                                }                                                                                                           // MakerGen.cs:391
                                public Type_Limit_Elements Elements { get; }                                                                // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                                public Type_Limit()                                                                                         // MakerGen.cs:394
                                {                                                                                                           // MakerGen.cs:395
                                    this.Elements = new Type_Limit_Elements();                                                              // MakerGen.cs:396
                                }                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                         // MakerGen.cs:399
                                {                                                                                                           // MakerGen.cs:400
                                    this.Elements.Write(sDef);                                                                              // MakerGen.cs:401
                                }                                                                                                           // MakerGen.cs:402
                            }                                                                                                               // MakerGen.cs:403
                            // 21. InsurancePlan.coverage.benefit.type
                            public ElementDefinitionInfo Type;                                                                              // MakerGen.cs:216
                            // 22. InsurancePlan.coverage.benefit.requirement
                            public ElementDefinitionInfo Requirement;                                                                       // MakerGen.cs:216
                            // 23. InsurancePlan.coverage.benefit.limit
                            public ElementDefinitionInfo Limit;                                                                             // MakerGen.cs:216
                            public Type_Benefit_Elements()                                                                                  // MakerGen.cs:407
                            {                                                                                                               // MakerGen.cs:408
                                {                                                                                                           // MakerGen.cs:231
                                    // 21. InsurancePlan.coverage.benefit.type
                                    this.Type = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Type",                                                                                      // MakerGen.cs:235
                                        Path= "InsurancePlan.coverage.benefit.type",                                                        // MakerGen.cs:236
                                        Id = "InsurancePlan.coverage.benefit.type",                                                         // MakerGen.cs:237
                                        Min = 1,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:315
                                            {                                                                                               // MakerGen.cs:316
                                            }                                                                                               // MakerGen.cs:319
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 22. InsurancePlan.coverage.benefit.requirement
                                    this.Requirement = new ElementDefinitionInfo                                                            // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Requirement",                                                                               // MakerGen.cs:235
                                        Path= "InsurancePlan.coverage.benefit.requirement",                                                 // MakerGen.cs:236
                                        Id = "InsurancePlan.coverage.benefit.requirement",                                                  // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 23. InsurancePlan.coverage.benefit.limit
                                    this.Limit = new ElementDefinitionInfo                                                                  // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Limit",                                                                                     // MakerGen.cs:235
                                        Path= "InsurancePlan.coverage.benefit.limit",                                                       // MakerGen.cs:236
                                        Id = "InsurancePlan.coverage.benefit.limit",                                                        // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new Type_Limit                                                                                  // MakerGen.cs:259
                                            {                                                                                               // MakerGen.cs:260
                                            }                                                                                               // MakerGen.cs:261
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                            }                                                                                                               // MakerGen.cs:427
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:412
                            {                                                                                                               // MakerGen.cs:413
                                base.Write(sDef);                                                                                           // MakerGen.cs:414
                                Type.Write(sDef);                                                                                           // MakerGen.cs:220
                                Requirement.Write(sDef);                                                                                    // MakerGen.cs:220
                                Limit.Write(sDef);                                                                                          // MakerGen.cs:220
                            }                                                                                                               // MakerGen.cs:431
                        }                                                                                                                   // MakerGen.cs:391
                        public Type_Benefit_Elements Elements { get; }                                                                      // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                        public Type_Benefit()                                                                                               // MakerGen.cs:394
                        {                                                                                                                   // MakerGen.cs:395
                            this.Elements = new Type_Benefit_Elements();                                                                    // MakerGen.cs:396
                        }                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:399
                        {                                                                                                                   // MakerGen.cs:400
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:401
                        }                                                                                                                   // MakerGen.cs:402
                    }                                                                                                                       // MakerGen.cs:403
                    // 18. InsurancePlan.coverage.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:216
                    // 19. InsurancePlan.coverage.network
                    public ElementDefinitionInfo Network;                                                                                   // MakerGen.cs:216
                    // 20. InsurancePlan.coverage.benefit
                    public ElementDefinitionInfo Benefit;                                                                                   // MakerGen.cs:216
                    public Type_Coverage_Elements()                                                                                         // MakerGen.cs:407
                    {                                                                                                                       // MakerGen.cs:408
                        {                                                                                                                   // MakerGen.cs:231
                            // 18. InsurancePlan.coverage.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Type",                                                                                              // MakerGen.cs:235
                                Path= "InsurancePlan.coverage.type",                                                                        // MakerGen.cs:236
                                Id = "InsurancePlan.coverage.type",                                                                         // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
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
                            // 19. InsurancePlan.coverage.network
                            this.Network = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Network",                                                                                           // MakerGen.cs:235
                                Path= "InsurancePlan.coverage.network",                                                                     // MakerGen.cs:236
                                Id = "InsurancePlan.coverage.network",                                                                      // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Organization"                                          // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 20. InsurancePlan.coverage.benefit
                            this.Benefit = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Benefit",                                                                                           // MakerGen.cs:235
                                Path= "InsurancePlan.coverage.benefit",                                                                     // MakerGen.cs:236
                                Id = "InsurancePlan.coverage.benefit",                                                                      // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new Type_Benefit                                                                                        // MakerGen.cs:259
                                    {                                                                                                       // MakerGen.cs:260
                                    }                                                                                                       // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:427
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:412
                    {                                                                                                                       // MakerGen.cs:413
                        base.Write(sDef);                                                                                                   // MakerGen.cs:414
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:220
                        Network.Write(sDef);                                                                                                // MakerGen.cs:220
                        Benefit.Write(sDef);                                                                                                // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:431
                }                                                                                                                           // MakerGen.cs:391
                public Type_Coverage_Elements Elements { get; }                                                                             // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                public Type_Coverage()                                                                                                      // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:395
                    this.Elements = new Type_Coverage_Elements();                                                                           // MakerGen.cs:396
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:399
                {                                                                                                                           // MakerGen.cs:400
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:401
                }                                                                                                                           // MakerGen.cs:402
            }                                                                                                                               // MakerGen.cs:403
            // 26. InsurancePlan.plan
            public class Type_Plan : FhirKhit.Maker.Common.Complex.ComplexBase                                                              // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                public class Type_Plan_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                               // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:386
                    // 31. InsurancePlan.plan.generalCost
                    public class Type_GeneralCost : FhirKhit.Maker.Common.Complex.ComplexBase                                               // MakerGen.cs:383
                    {                                                                                                                       // MakerGen.cs:384
                        public class Type_GeneralCost_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:386
                            // 32. InsurancePlan.plan.generalCost.type
                            public ElementDefinitionInfo Type;                                                                              // MakerGen.cs:216
                            // 33. InsurancePlan.plan.generalCost.groupSize
                            public ElementDefinitionInfo GroupSize;                                                                         // MakerGen.cs:216
                            // 34. InsurancePlan.plan.generalCost.cost
                            public ElementDefinitionInfo Cost;                                                                              // MakerGen.cs:216
                            // 35. InsurancePlan.plan.generalCost.comment
                            public ElementDefinitionInfo Comment;                                                                           // MakerGen.cs:216
                            public Type_GeneralCost_Elements()                                                                              // MakerGen.cs:407
                            {                                                                                                               // MakerGen.cs:408
                                {                                                                                                           // MakerGen.cs:231
                                    // 32. InsurancePlan.plan.generalCost.type
                                    this.Type = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Type",                                                                                      // MakerGen.cs:235
                                        Path= "InsurancePlan.plan.generalCost.type",                                                        // MakerGen.cs:236
                                        Id = "InsurancePlan.plan.generalCost.type",                                                         // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:315
                                            {                                                                                               // MakerGen.cs:316
                                            }                                                                                               // MakerGen.cs:319
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 33. InsurancePlan.plan.generalCost.groupSize
                                    this.GroupSize = new ElementDefinitionInfo                                                              // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "GroupSize",                                                                                 // MakerGen.cs:235
                                        Path= "InsurancePlan.plan.generalCost.groupSize",                                                   // MakerGen.cs:236
                                        Id = "InsurancePlan.plan.generalCost.groupSize",                                                    // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.PositiveInt                                                 // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 34. InsurancePlan.plan.generalCost.cost
                                    this.Cost = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Cost",                                                                                      // MakerGen.cs:235
                                        Path= "InsurancePlan.plan.generalCost.cost",                                                        // MakerGen.cs:236
                                        Id = "InsurancePlan.plan.generalCost.cost",                                                         // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.Money                                                         // MakerGen.cs:358
                                            {                                                                                               // MakerGen.cs:359
                                            }                                                                                               // MakerGen.cs:360
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 35. InsurancePlan.plan.generalCost.comment
                                    this.Comment = new ElementDefinitionInfo                                                                // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Comment",                                                                                   // MakerGen.cs:235
                                        Path= "InsurancePlan.plan.generalCost.comment",                                                     // MakerGen.cs:236
                                        Id = "InsurancePlan.plan.generalCost.comment",                                                      // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                            }                                                                                                               // MakerGen.cs:427
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:412
                            {                                                                                                               // MakerGen.cs:413
                                base.Write(sDef);                                                                                           // MakerGen.cs:414
                                Type.Write(sDef);                                                                                           // MakerGen.cs:220
                                GroupSize.Write(sDef);                                                                                      // MakerGen.cs:220
                                Cost.Write(sDef);                                                                                           // MakerGen.cs:220
                                Comment.Write(sDef);                                                                                        // MakerGen.cs:220
                            }                                                                                                               // MakerGen.cs:431
                        }                                                                                                                   // MakerGen.cs:391
                        public Type_GeneralCost_Elements Elements { get; }                                                                  // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                        public Type_GeneralCost()                                                                                           // MakerGen.cs:394
                        {                                                                                                                   // MakerGen.cs:395
                            this.Elements = new Type_GeneralCost_Elements();                                                                // MakerGen.cs:396
                        }                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:399
                        {                                                                                                                   // MakerGen.cs:400
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:401
                        }                                                                                                                   // MakerGen.cs:402
                    }                                                                                                                       // MakerGen.cs:403
                    // 36. InsurancePlan.plan.specificCost
                    public class Type_SpecificCost : FhirKhit.Maker.Common.Complex.ComplexBase                                              // MakerGen.cs:383
                    {                                                                                                                       // MakerGen.cs:384
                        public class Type_SpecificCost_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                               // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:386
                            // 38. InsurancePlan.plan.specificCost.benefit
                            public class Type_Benefit : FhirKhit.Maker.Common.Complex.ComplexBase                                           // MakerGen.cs:383
                            {                                                                                                               // MakerGen.cs:384
                                public class Type_Benefit_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                            // MakerGen.cs:385
                                {                                                                                                           // MakerGen.cs:386
                                    // 40. InsurancePlan.plan.specificCost.benefit.cost
                                    public class Type_Cost : FhirKhit.Maker.Common.Complex.ComplexBase                                      // MakerGen.cs:383
                                    {                                                                                                       // MakerGen.cs:384
                                        public class Type_Cost_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                       // MakerGen.cs:385
                                        {                                                                                                   // MakerGen.cs:386
                                            // 41. InsurancePlan.plan.specificCost.benefit.cost.type
                                            public ElementDefinitionInfo Type;                                                              // MakerGen.cs:216
                                            // 42. InsurancePlan.plan.specificCost.benefit.cost.applicability
                                            public ElementDefinitionInfo Applicability;                                                     // MakerGen.cs:216
                                            // 43. InsurancePlan.plan.specificCost.benefit.cost.qualifiers
                                            public ElementDefinitionInfo Qualifiers;                                                        // MakerGen.cs:216
                                            // 44. InsurancePlan.plan.specificCost.benefit.cost.value
                                            public ElementDefinitionInfo Value;                                                             // MakerGen.cs:216
                                            public Type_Cost_Elements()                                                                     // MakerGen.cs:407
                                            {                                                                                               // MakerGen.cs:408
                                                {                                                                                           // MakerGen.cs:231
                                                    // 41. InsurancePlan.plan.specificCost.benefit.cost.type
                                                    this.Type = new ElementDefinitionInfo                                                   // MakerGen.cs:233
                                                    {                                                                                       // MakerGen.cs:234
                                                        Name = "Type",                                                                      // MakerGen.cs:235
                                                        Path= "InsurancePlan.plan.specificCost.benefit.cost.type",                          // MakerGen.cs:236
                                                        Id = "InsurancePlan.plan.specificCost.benefit.cost.type",                           // MakerGen.cs:237
                                                        Min = 1,                                                                            // MakerGen.cs:238
                                                        Max = 1,                                                                            // MakerGen.cs:239
                                                        Types = new BaseType[]                                                              // MakerGen.cs:240
                                                        {                                                                                   // MakerGen.cs:241
                                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                               // MakerGen.cs:315
                                                            {                                                                               // MakerGen.cs:316
                                                            }                                                                               // MakerGen.cs:319
                                                        }                                                                                   // MakerGen.cs:243
                                                    };                                                                                      // MakerGen.cs:244
                                                }                                                                                           // MakerGen.cs:245
                                                {                                                                                           // MakerGen.cs:231
                                                    // 42. InsurancePlan.plan.specificCost.benefit.cost.applicability
                                                    this.Applicability = new ElementDefinitionInfo                                          // MakerGen.cs:233
                                                    {                                                                                       // MakerGen.cs:234
                                                        Name = "Applicability",                                                             // MakerGen.cs:235
                                                        Path= "InsurancePlan.plan.specificCost.benefit.cost.applicability",                 // MakerGen.cs:236
                                                        Id = "InsurancePlan.plan.specificCost.benefit.cost.applicability",                  // MakerGen.cs:237
                                                        Min = 0,                                                                            // MakerGen.cs:238
                                                        Max = 1,                                                                            // MakerGen.cs:239
                                                        Types = new BaseType[]                                                              // MakerGen.cs:240
                                                        {                                                                                   // MakerGen.cs:241
                                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                               // MakerGen.cs:315
                                                            {                                                                               // MakerGen.cs:316
                                                            }                                                                               // MakerGen.cs:319
                                                        }                                                                                   // MakerGen.cs:243
                                                    };                                                                                      // MakerGen.cs:244
                                                }                                                                                           // MakerGen.cs:245
                                                {                                                                                           // MakerGen.cs:231
                                                    // 43. InsurancePlan.plan.specificCost.benefit.cost.qualifiers
                                                    this.Qualifiers = new ElementDefinitionInfo                                             // MakerGen.cs:233
                                                    {                                                                                       // MakerGen.cs:234
                                                        Name = "Qualifiers",                                                                // MakerGen.cs:235
                                                        Path= "InsurancePlan.plan.specificCost.benefit.cost.qualifiers",                    // MakerGen.cs:236
                                                        Id = "InsurancePlan.plan.specificCost.benefit.cost.qualifiers",                     // MakerGen.cs:237
                                                        Min = 0,                                                                            // MakerGen.cs:238
                                                        Max = -1,                                                                           // MakerGen.cs:239
                                                        Types = new BaseType[]                                                              // MakerGen.cs:240
                                                        {                                                                                   // MakerGen.cs:241
                                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                               // MakerGen.cs:315
                                                            {                                                                               // MakerGen.cs:316
                                                            }                                                                               // MakerGen.cs:319
                                                        }                                                                                   // MakerGen.cs:243
                                                    };                                                                                      // MakerGen.cs:244
                                                }                                                                                           // MakerGen.cs:245
                                                {                                                                                           // MakerGen.cs:231
                                                    // 44. InsurancePlan.plan.specificCost.benefit.cost.value
                                                    this.Value = new ElementDefinitionInfo                                                  // MakerGen.cs:233
                                                    {                                                                                       // MakerGen.cs:234
                                                        Name = "Value",                                                                     // MakerGen.cs:235
                                                        Path= "InsurancePlan.plan.specificCost.benefit.cost.value",                         // MakerGen.cs:236
                                                        Id = "InsurancePlan.plan.specificCost.benefit.cost.value",                          // MakerGen.cs:237
                                                        Min = 0,                                                                            // MakerGen.cs:238
                                                        Max = 1,                                                                            // MakerGen.cs:239
                                                        Types = new BaseType[]                                                              // MakerGen.cs:240
                                                        {                                                                                   // MakerGen.cs:241
                                                            new FhirKhit.Maker.Common.Complex.Quantity                                      // MakerGen.cs:358
                                                            {                                                                               // MakerGen.cs:359
                                                            }                                                                               // MakerGen.cs:360
                                                        }                                                                                   // MakerGen.cs:243
                                                    };                                                                                      // MakerGen.cs:244
                                                }                                                                                           // MakerGen.cs:245
                                            }                                                                                               // MakerGen.cs:427
                                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                             // MakerGen.cs:412
                                            {                                                                                               // MakerGen.cs:413
                                                base.Write(sDef);                                                                           // MakerGen.cs:414
                                                Type.Write(sDef);                                                                           // MakerGen.cs:220
                                                Applicability.Write(sDef);                                                                  // MakerGen.cs:220
                                                Qualifiers.Write(sDef);                                                                     // MakerGen.cs:220
                                                Value.Write(sDef);                                                                          // MakerGen.cs:220
                                            }                                                                                               // MakerGen.cs:431
                                        }                                                                                                   // MakerGen.cs:391
                                        public Type_Cost_Elements Elements { get; }                                                         // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                                        public Type_Cost()                                                                                  // MakerGen.cs:394
                                        {                                                                                                   // MakerGen.cs:395
                                            this.Elements = new Type_Cost_Elements();                                                       // MakerGen.cs:396
                                        }                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                 // MakerGen.cs:399
                                        {                                                                                                   // MakerGen.cs:400
                                            this.Elements.Write(sDef);                                                                      // MakerGen.cs:401
                                        }                                                                                                   // MakerGen.cs:402
                                    }                                                                                                       // MakerGen.cs:403
                                    // 39. InsurancePlan.plan.specificCost.benefit.type
                                    public ElementDefinitionInfo Type;                                                                      // MakerGen.cs:216
                                    // 40. InsurancePlan.plan.specificCost.benefit.cost
                                    public ElementDefinitionInfo Cost;                                                                      // MakerGen.cs:216
                                    public Type_Benefit_Elements()                                                                          // MakerGen.cs:407
                                    {                                                                                                       // MakerGen.cs:408
                                        {                                                                                                   // MakerGen.cs:231
                                            // 39. InsurancePlan.plan.specificCost.benefit.type
                                            this.Type = new ElementDefinitionInfo                                                           // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Type",                                                                              // MakerGen.cs:235
                                                Path= "InsurancePlan.plan.specificCost.benefit.type",                                       // MakerGen.cs:236
                                                Id = "InsurancePlan.plan.specificCost.benefit.type",                                        // MakerGen.cs:237
                                                Min = 1,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                       // MakerGen.cs:315
                                                    {                                                                                       // MakerGen.cs:316
                                                    }                                                                                       // MakerGen.cs:319
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 40. InsurancePlan.plan.specificCost.benefit.cost
                                            this.Cost = new ElementDefinitionInfo                                                           // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Cost",                                                                              // MakerGen.cs:235
                                                Path= "InsurancePlan.plan.specificCost.benefit.cost",                                       // MakerGen.cs:236
                                                Id = "InsurancePlan.plan.specificCost.benefit.cost",                                        // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = -1,                                                                                   // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new Type_Cost                                                                           // MakerGen.cs:259
                                                    {                                                                                       // MakerGen.cs:260
                                                    }                                                                                       // MakerGen.cs:261
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                    }                                                                                                       // MakerGen.cs:427
                                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                     // MakerGen.cs:412
                                    {                                                                                                       // MakerGen.cs:413
                                        base.Write(sDef);                                                                                   // MakerGen.cs:414
                                        Type.Write(sDef);                                                                                   // MakerGen.cs:220
                                        Cost.Write(sDef);                                                                                   // MakerGen.cs:220
                                    }                                                                                                       // MakerGen.cs:431
                                }                                                                                                           // MakerGen.cs:391
                                public Type_Benefit_Elements Elements { get; }                                                              // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                                public Type_Benefit()                                                                                       // MakerGen.cs:394
                                {                                                                                                           // MakerGen.cs:395
                                    this.Elements = new Type_Benefit_Elements();                                                            // MakerGen.cs:396
                                }                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                         // MakerGen.cs:399
                                {                                                                                                           // MakerGen.cs:400
                                    this.Elements.Write(sDef);                                                                              // MakerGen.cs:401
                                }                                                                                                           // MakerGen.cs:402
                            }                                                                                                               // MakerGen.cs:403
                            // 37. InsurancePlan.plan.specificCost.category
                            public ElementDefinitionInfo Category;                                                                          // MakerGen.cs:216
                            // 38. InsurancePlan.plan.specificCost.benefit
                            public ElementDefinitionInfo Benefit;                                                                           // MakerGen.cs:216
                            public Type_SpecificCost_Elements()                                                                             // MakerGen.cs:407
                            {                                                                                                               // MakerGen.cs:408
                                {                                                                                                           // MakerGen.cs:231
                                    // 37. InsurancePlan.plan.specificCost.category
                                    this.Category = new ElementDefinitionInfo                                                               // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Category",                                                                                  // MakerGen.cs:235
                                        Path= "InsurancePlan.plan.specificCost.category",                                                   // MakerGen.cs:236
                                        Id = "InsurancePlan.plan.specificCost.category",                                                    // MakerGen.cs:237
                                        Min = 1,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:315
                                            {                                                                                               // MakerGen.cs:316
                                            }                                                                                               // MakerGen.cs:319
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 38. InsurancePlan.plan.specificCost.benefit
                                    this.Benefit = new ElementDefinitionInfo                                                                // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Benefit",                                                                                   // MakerGen.cs:235
                                        Path= "InsurancePlan.plan.specificCost.benefit",                                                    // MakerGen.cs:236
                                        Id = "InsurancePlan.plan.specificCost.benefit",                                                     // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new Type_Benefit                                                                                // MakerGen.cs:259
                                            {                                                                                               // MakerGen.cs:260
                                            }                                                                                               // MakerGen.cs:261
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                            }                                                                                                               // MakerGen.cs:427
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:412
                            {                                                                                                               // MakerGen.cs:413
                                base.Write(sDef);                                                                                           // MakerGen.cs:414
                                Category.Write(sDef);                                                                                       // MakerGen.cs:220
                                Benefit.Write(sDef);                                                                                        // MakerGen.cs:220
                            }                                                                                                               // MakerGen.cs:431
                        }                                                                                                                   // MakerGen.cs:391
                        public Type_SpecificCost_Elements Elements { get; }                                                                 // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                        public Type_SpecificCost()                                                                                          // MakerGen.cs:394
                        {                                                                                                                   // MakerGen.cs:395
                            this.Elements = new Type_SpecificCost_Elements();                                                               // MakerGen.cs:396
                        }                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:399
                        {                                                                                                                   // MakerGen.cs:400
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:401
                        }                                                                                                                   // MakerGen.cs:402
                    }                                                                                                                       // MakerGen.cs:403
                    // 27. InsurancePlan.plan.identifier
                    public ElementDefinitionInfo Identifier;                                                                                // MakerGen.cs:216
                    // 28. InsurancePlan.plan.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:216
                    // 29. InsurancePlan.plan.coverageArea
                    public ElementDefinitionInfo CoverageArea;                                                                              // MakerGen.cs:216
                    // 30. InsurancePlan.plan.network
                    public ElementDefinitionInfo Network;                                                                                   // MakerGen.cs:216
                    // 31. InsurancePlan.plan.generalCost
                    public ElementDefinitionInfo GeneralCost;                                                                               // MakerGen.cs:216
                    // 36. InsurancePlan.plan.specificCost
                    public ElementDefinitionInfo SpecificCost;                                                                              // MakerGen.cs:216
                    public Type_Plan_Elements()                                                                                             // MakerGen.cs:407
                    {                                                                                                                       // MakerGen.cs:408
                        {                                                                                                                   // MakerGen.cs:231
                            // 27. InsurancePlan.plan.identifier
                            this.Identifier = new ElementDefinitionInfo                                                                     // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Identifier",                                                                                        // MakerGen.cs:235
                                Path= "InsurancePlan.plan.identifier",                                                                      // MakerGen.cs:236
                                Id = "InsurancePlan.plan.identifier",                                                                       // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Identifier                                                            // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    }                                                                                                       // MakerGen.cs:360
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 28. InsurancePlan.plan.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Type",                                                                                              // MakerGen.cs:235
                                Path= "InsurancePlan.plan.type",                                                                            // MakerGen.cs:236
                                Id = "InsurancePlan.plan.type",                                                                             // MakerGen.cs:237
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
                            // 29. InsurancePlan.plan.coverageArea
                            this.CoverageArea = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "CoverageArea",                                                                                      // MakerGen.cs:235
                                Path= "InsurancePlan.plan.coverageArea",                                                                    // MakerGen.cs:236
                                Id = "InsurancePlan.plan.coverageArea",                                                                     // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Location"                                              // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 30. InsurancePlan.plan.network
                            this.Network = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Network",                                                                                           // MakerGen.cs:235
                                Path= "InsurancePlan.plan.network",                                                                         // MakerGen.cs:236
                                Id = "InsurancePlan.plan.network",                                                                          // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Organization"                                          // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 31. InsurancePlan.plan.generalCost
                            this.GeneralCost = new ElementDefinitionInfo                                                                    // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "GeneralCost",                                                                                       // MakerGen.cs:235
                                Path= "InsurancePlan.plan.generalCost",                                                                     // MakerGen.cs:236
                                Id = "InsurancePlan.plan.generalCost",                                                                      // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new Type_GeneralCost                                                                                    // MakerGen.cs:259
                                    {                                                                                                       // MakerGen.cs:260
                                    }                                                                                                       // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 36. InsurancePlan.plan.specificCost
                            this.SpecificCost = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "SpecificCost",                                                                                      // MakerGen.cs:235
                                Path= "InsurancePlan.plan.specificCost",                                                                    // MakerGen.cs:236
                                Id = "InsurancePlan.plan.specificCost",                                                                     // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new Type_SpecificCost                                                                                   // MakerGen.cs:259
                                    {                                                                                                       // MakerGen.cs:260
                                    }                                                                                                       // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:427
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:412
                    {                                                                                                                       // MakerGen.cs:413
                        base.Write(sDef);                                                                                                   // MakerGen.cs:414
                        Identifier.Write(sDef);                                                                                             // MakerGen.cs:220
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:220
                        CoverageArea.Write(sDef);                                                                                           // MakerGen.cs:220
                        Network.Write(sDef);                                                                                                // MakerGen.cs:220
                        GeneralCost.Write(sDef);                                                                                            // MakerGen.cs:220
                        SpecificCost.Write(sDef);                                                                                           // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:431
                }                                                                                                                           // MakerGen.cs:391
                public Type_Plan_Elements Elements { get; }                                                                                 // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                public Type_Plan()                                                                                                          // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:395
                    this.Elements = new Type_Plan_Elements();                                                                               // MakerGen.cs:396
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:399
                {                                                                                                                           // MakerGen.cs:400
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:401
                }                                                                                                                           // MakerGen.cs:402
            }                                                                                                                               // MakerGen.cs:403
            // 1. InsurancePlan.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:216
            // 2. InsurancePlan.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:216
            // 3. InsurancePlan.type
            public ElementDefinitionInfo Type;                                                                                              // MakerGen.cs:216
            // 4. InsurancePlan.name
            public ElementDefinitionInfo Name;                                                                                              // MakerGen.cs:216
            // 5. InsurancePlan.alias
            public ElementDefinitionInfo Alias;                                                                                             // MakerGen.cs:216
            // 6. InsurancePlan.period
            public ElementDefinitionInfo Period;                                                                                            // MakerGen.cs:216
            // 7. InsurancePlan.ownedBy
            public ElementDefinitionInfo OwnedBy;                                                                                           // MakerGen.cs:216
            // 8. InsurancePlan.administeredBy
            public ElementDefinitionInfo AdministeredBy;                                                                                    // MakerGen.cs:216
            // 9. InsurancePlan.coverageArea
            public ElementDefinitionInfo CoverageArea;                                                                                      // MakerGen.cs:216
            // 10. InsurancePlan.contact
            public ElementDefinitionInfo Contact;                                                                                           // MakerGen.cs:216
            // 15. InsurancePlan.endpoint
            public ElementDefinitionInfo Endpoint;                                                                                          // MakerGen.cs:216
            // 16. InsurancePlan.network
            public ElementDefinitionInfo Network;                                                                                           // MakerGen.cs:216
            // 17. InsurancePlan.coverage
            public ElementDefinitionInfo Coverage;                                                                                          // MakerGen.cs:216
            // 26. InsurancePlan.plan
            public ElementDefinitionInfo Plan;                                                                                              // MakerGen.cs:216
            public InsurancePlan_Elements()                                                                                                 // MakerGen.cs:407
            {                                                                                                                               // MakerGen.cs:408
                {                                                                                                                           // MakerGen.cs:231
                    // 1. InsurancePlan.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Identifier",                                                                                                // MakerGen.cs:235
                        Path= "InsurancePlan.identifier",                                                                                   // MakerGen.cs:236
                        Id = "InsurancePlan.identifier",                                                                                    // MakerGen.cs:237
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
                    // 2. InsurancePlan.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Status",                                                                                                    // MakerGen.cs:235
                        Path= "InsurancePlan.status",                                                                                       // MakerGen.cs:236
                        Id = "InsurancePlan.status",                                                                                        // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 3. InsurancePlan.type
                    this.Type = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Type",                                                                                                      // MakerGen.cs:235
                        Path= "InsurancePlan.type",                                                                                         // MakerGen.cs:236
                        Id = "InsurancePlan.type",                                                                                          // MakerGen.cs:237
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
                    // 4. InsurancePlan.name
                    this.Name = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Name",                                                                                                      // MakerGen.cs:235
                        Path= "InsurancePlan.name",                                                                                         // MakerGen.cs:236
                        Id = "InsurancePlan.name",                                                                                          // MakerGen.cs:237
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
                    // 5. InsurancePlan.alias
                    this.Alias = new ElementDefinitionInfo                                                                                  // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Alias",                                                                                                     // MakerGen.cs:235
                        Path= "InsurancePlan.alias",                                                                                        // MakerGen.cs:236
                        Id = "InsurancePlan.alias",                                                                                         // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 6. InsurancePlan.period
                    this.Period = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Period",                                                                                                    // MakerGen.cs:235
                        Path= "InsurancePlan.period",                                                                                       // MakerGen.cs:236
                        Id = "InsurancePlan.period",                                                                                        // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Period                                                                        // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 7. InsurancePlan.ownedBy
                    this.OwnedBy = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "OwnedBy",                                                                                                   // MakerGen.cs:235
                        Path= "InsurancePlan.ownedBy",                                                                                      // MakerGen.cs:236
                        Id = "InsurancePlan.ownedBy",                                                                                       // MakerGen.cs:237
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
                    // 8. InsurancePlan.administeredBy
                    this.AdministeredBy = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "AdministeredBy",                                                                                            // MakerGen.cs:235
                        Path= "InsurancePlan.administeredBy",                                                                               // MakerGen.cs:236
                        Id = "InsurancePlan.administeredBy",                                                                                // MakerGen.cs:237
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
                    // 9. InsurancePlan.coverageArea
                    this.CoverageArea = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "CoverageArea",                                                                                              // MakerGen.cs:235
                        Path= "InsurancePlan.coverageArea",                                                                                 // MakerGen.cs:236
                        Id = "InsurancePlan.coverageArea",                                                                                  // MakerGen.cs:237
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
                    // 10. InsurancePlan.contact
                    this.Contact = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Contact",                                                                                                   // MakerGen.cs:235
                        Path= "InsurancePlan.contact",                                                                                      // MakerGen.cs:236
                        Id = "InsurancePlan.contact",                                                                                       // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Contact                                                                                                // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 15. InsurancePlan.endpoint
                    this.Endpoint = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Endpoint",                                                                                                  // MakerGen.cs:235
                        Path= "InsurancePlan.endpoint",                                                                                     // MakerGen.cs:236
                        Id = "InsurancePlan.endpoint",                                                                                      // MakerGen.cs:237
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
                {                                                                                                                           // MakerGen.cs:231
                    // 16. InsurancePlan.network
                    this.Network = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Network",                                                                                                   // MakerGen.cs:235
                        Path= "InsurancePlan.network",                                                                                      // MakerGen.cs:236
                        Id = "InsurancePlan.network",                                                                                       // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
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
                    // 17. InsurancePlan.coverage
                    this.Coverage = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Coverage",                                                                                                  // MakerGen.cs:235
                        Path= "InsurancePlan.coverage",                                                                                     // MakerGen.cs:236
                        Id = "InsurancePlan.coverage",                                                                                      // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Coverage                                                                                               // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 26. InsurancePlan.plan
                    this.Plan = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Plan",                                                                                                      // MakerGen.cs:235
                        Path= "InsurancePlan.plan",                                                                                         // MakerGen.cs:236
                        Id = "InsurancePlan.plan",                                                                                          // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Plan                                                                                                   // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:427
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:412
            {                                                                                                                               // MakerGen.cs:413
                base.Write(sDef);                                                                                                           // MakerGen.cs:414
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:220
                Status.Write(sDef);                                                                                                         // MakerGen.cs:220
                Type.Write(sDef);                                                                                                           // MakerGen.cs:220
                Name.Write(sDef);                                                                                                           // MakerGen.cs:220
                Alias.Write(sDef);                                                                                                          // MakerGen.cs:220
                Period.Write(sDef);                                                                                                         // MakerGen.cs:220
                OwnedBy.Write(sDef);                                                                                                        // MakerGen.cs:220
                AdministeredBy.Write(sDef);                                                                                                 // MakerGen.cs:220
                CoverageArea.Write(sDef);                                                                                                   // MakerGen.cs:220
                Contact.Write(sDef);                                                                                                        // MakerGen.cs:220
                Endpoint.Write(sDef);                                                                                                       // MakerGen.cs:220
                Network.Write(sDef);                                                                                                        // MakerGen.cs:220
                Coverage.Write(sDef);                                                                                                       // MakerGen.cs:220
                Plan.Write(sDef);                                                                                                           // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:431
        }                                                                                                                                   // MakerGen.cs:391
        public InsurancePlan_Elements Elements { get; }                                                                                     // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
        public InsurancePlan()                                                                                                              // MakerGen.cs:394
        {                                                                                                                                   // MakerGen.cs:395
            this.Elements = new InsurancePlan_Elements();                                                                                   // MakerGen.cs:396
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:399
        {                                                                                                                                   // MakerGen.cs:400
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:401
        }                                                                                                                                   // MakerGen.cs:402
    }                                                                                                                                       // MakerGen.cs:403
}                                                                                                                                           // MakerGen.cs:466
