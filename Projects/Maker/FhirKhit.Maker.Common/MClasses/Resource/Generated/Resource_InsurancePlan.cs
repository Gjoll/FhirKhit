using System;                                                                                                                               // MakerGen.cs:428
using System.Diagnostics;                                                                                                                   // MakerGen.cs:429
using System.IO;                                                                                                                            // MakerGen.cs:430
using System.Linq;                                                                                                                          // MakerGen.cs:431
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:432
                                                                                                                                            // MakerGen.cs:433
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:434
{                                                                                                                                           // MakerGen.cs:435
    #region Json                                                                                                                            // MakerGen.cs:436
    #if NEVER                                                                                                                               // MakerGen.cs:437
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
    #endregion                                                                                                                              // MakerGen.cs:440
    /// <summary>
    /// Fhir resource 'InsurancePlan'
    /// </summary>
    // 0. InsurancePlan
    public class Resource_InsurancePlan : FhirKhit.Maker.Common.Resource.ResourceBase                                                       // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        // 10. InsurancePlan.contact
        public class Type_Contact : FhirKhit.Maker.Common.Complex.ComplexBase                                                               // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 11. InsurancePlan.contact.purpose
            public ElementDefinitionInfo Element_Purpose;                                                                                   // MakerGen.cs:212
            // 12. InsurancePlan.contact.name
            public ElementDefinitionInfo Element_Name;                                                                                      // MakerGen.cs:212
            // 13. InsurancePlan.contact.telecom
            public ElementDefinitionInfo Element_Telecom;                                                                                   // MakerGen.cs:212
            // 14. InsurancePlan.contact.address
            public ElementDefinitionInfo Element_Address;                                                                                   // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "InsurancePlan.contact",                                                                                         // MakerGen.cs:388
                    ElementId = "InsurancePlan.contact"                                                                                     // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Purpose.Write(sDef);                                                                                                // MakerGen.cs:216
                Element_Name.Write(sDef);                                                                                                   // MakerGen.cs:216
                Element_Telecom.Write(sDef);                                                                                                // MakerGen.cs:216
                Element_Address.Write(sDef);                                                                                                // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_Contact()                                                                                                           // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 11. InsurancePlan.contact.purpose
                    this.Element_Purpose = new ElementDefinitionInfo                                                                        // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Purpose",                                                                                           // MakerGen.cs:231
                        Path= "InsurancePlan.contact.purpose",                                                                              // MakerGen.cs:232
                        Id = "InsurancePlan.contact.purpose",                                                                               // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 12. InsurancePlan.contact.name
                    this.Element_Name = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Name",                                                                                              // MakerGen.cs:231
                        Path= "InsurancePlan.contact.name",                                                                                 // MakerGen.cs:232
                        Id = "InsurancePlan.contact.name",                                                                                  // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_HumanName                                                                // MakerGen.cs:351
                            {                                                                                                               // MakerGen.cs:352
                            }                                                                                                               // MakerGen.cs:353
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 13. InsurancePlan.contact.telecom
                    this.Element_Telecom = new ElementDefinitionInfo                                                                        // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Telecom",                                                                                           // MakerGen.cs:231
                        Path= "InsurancePlan.contact.telecom",                                                                              // MakerGen.cs:232
                        Id = "InsurancePlan.contact.telecom",                                                                               // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_ContactPoint                                                             // MakerGen.cs:351
                            {                                                                                                               // MakerGen.cs:352
                            }                                                                                                               // MakerGen.cs:353
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 14. InsurancePlan.contact.address
                    this.Element_Address = new ElementDefinitionInfo                                                                        // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Address",                                                                                           // MakerGen.cs:231
                        Path= "InsurancePlan.contact.address",                                                                              // MakerGen.cs:232
                        Id = "InsurancePlan.contact.address",                                                                               // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Address                                                                  // MakerGen.cs:351
                            {                                                                                                               // MakerGen.cs:352
                            }                                                                                                               // MakerGen.cs:353
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 17. InsurancePlan.coverage
        public class Type_Coverage : FhirKhit.Maker.Common.Complex.ComplexBase                                                              // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 20. InsurancePlan.coverage.benefit
            public class Type_Benefit : FhirKhit.Maker.Common.Complex.ComplexBase                                                           // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                // 23. InsurancePlan.coverage.benefit.limit
                public class Type_Limit : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:376
                {                                                                                                                           // MakerGen.cs:377
                    // 24. InsurancePlan.coverage.benefit.limit.value
                    public ElementDefinitionInfo Element_Value;                                                                             // MakerGen.cs:212
                    // 25. InsurancePlan.coverage.benefit.limit.code
                    public ElementDefinitionInfo Element_Code;                                                                              // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:383
                    {                                                                                                                       // MakerGen.cs:384
                        base.Write(sDef);                                                                                                   // MakerGen.cs:385
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                  // MakerGen.cs:386
                        {                                                                                                                   // MakerGen.cs:387
                            Path = "InsurancePlan.coverage.benefit.limit",                                                                  // MakerGen.cs:388
                            ElementId = "InsurancePlan.coverage.benefit.limit"                                                              // MakerGen.cs:389
                        });                                                                                                                 // MakerGen.cs:390
                        Element_Value.Write(sDef);                                                                                          // MakerGen.cs:216
                        Element_Code.Write(sDef);                                                                                           // MakerGen.cs:216
                    }                                                                                                                       // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
                    public Type_Limit()                                                                                                     // MakerGen.cs:395
                    {                                                                                                                       // MakerGen.cs:396
                        {                                                                                                                   // MakerGen.cs:227
                            // 24. InsurancePlan.coverage.benefit.limit.value
                            this.Element_Value = new ElementDefinitionInfo                                                                  // MakerGen.cs:229
                            {                                                                                                               // MakerGen.cs:230
                                Name = "Element_Value",                                                                                     // MakerGen.cs:231
                                Path= "InsurancePlan.coverage.benefit.limit.value",                                                         // MakerGen.cs:232
                                Id = "InsurancePlan.coverage.benefit.limit.value",                                                          // MakerGen.cs:233
                                Min = 0,                                                                                                    // MakerGen.cs:234
                                Max = 1,                                                                                                    // MakerGen.cs:235
                                Types = new BaseType[]                                                                                      // MakerGen.cs:236
                                {                                                                                                           // MakerGen.cs:237
                                    new FhirKhit.Maker.Common.Complex.Type_Quantity                                                         // MakerGen.cs:351
                                    {                                                                                                       // MakerGen.cs:352
                                    }                                                                                                       // MakerGen.cs:353
                                }                                                                                                           // MakerGen.cs:239
                            };                                                                                                              // MakerGen.cs:240
                        }                                                                                                                   // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:227
                            // 25. InsurancePlan.coverage.benefit.limit.code
                            this.Element_Code = new ElementDefinitionInfo                                                                   // MakerGen.cs:229
                            {                                                                                                               // MakerGen.cs:230
                                Name = "Element_Code",                                                                                      // MakerGen.cs:231
                                Path= "InsurancePlan.coverage.benefit.limit.code",                                                          // MakerGen.cs:232
                                Id = "InsurancePlan.coverage.benefit.limit.code",                                                           // MakerGen.cs:233
                                Min = 0,                                                                                                    // MakerGen.cs:234
                                Max = 1,                                                                                                    // MakerGen.cs:235
                                Types = new BaseType[]                                                                                      // MakerGen.cs:236
                                {                                                                                                           // MakerGen.cs:237
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                  // MakerGen.cs:311
                                    {                                                                                                       // MakerGen.cs:312
                                    }                                                                                                       // MakerGen.cs:315
                                }                                                                                                           // MakerGen.cs:239
                            };                                                                                                              // MakerGen.cs:240
                        }                                                                                                                   // MakerGen.cs:241
                    }                                                                                                                       // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:400
                // 21. InsurancePlan.coverage.benefit.type
                public ElementDefinitionInfo Element_Type;                                                                                  // MakerGen.cs:212
                // 22. InsurancePlan.coverage.benefit.requirement
                public ElementDefinitionInfo Element_Requirement;                                                                           // MakerGen.cs:212
                // 23. InsurancePlan.coverage.benefit.limit
                public ElementDefinitionInfo Element_Limit;                                                                                 // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:383
                {                                                                                                                           // MakerGen.cs:384
                    base.Write(sDef);                                                                                                       // MakerGen.cs:385
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:386
                    {                                                                                                                       // MakerGen.cs:387
                        Path = "InsurancePlan.coverage.benefit",                                                                            // MakerGen.cs:388
                        ElementId = "InsurancePlan.coverage.benefit"                                                                        // MakerGen.cs:389
                    });                                                                                                                     // MakerGen.cs:390
                    Element_Type.Write(sDef);                                                                                               // MakerGen.cs:216
                    Element_Requirement.Write(sDef);                                                                                        // MakerGen.cs:216
                    Element_Limit.Write(sDef);                                                                                              // MakerGen.cs:216
                }                                                                                                                           // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
                public Type_Benefit()                                                                                                       // MakerGen.cs:395
                {                                                                                                                           // MakerGen.cs:396
                    {                                                                                                                       // MakerGen.cs:227
                        // 21. InsurancePlan.coverage.benefit.type
                        this.Element_Type = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Type",                                                                                          // MakerGen.cs:231
                            Path= "InsurancePlan.coverage.benefit.type",                                                                    // MakerGen.cs:232
                            Id = "InsurancePlan.coverage.benefit.type",                                                                     // MakerGen.cs:233
                            Min = 1,                                                                                                        // MakerGen.cs:234
                            Max = 1,                                                                                                        // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:311
                                {                                                                                                           // MakerGen.cs:312
                                }                                                                                                           // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:227
                        // 22. InsurancePlan.coverage.benefit.requirement
                        this.Element_Requirement = new ElementDefinitionInfo                                                                // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Requirement",                                                                                   // MakerGen.cs:231
                            Path= "InsurancePlan.coverage.benefit.requirement",                                                             // MakerGen.cs:232
                            Id = "InsurancePlan.coverage.benefit.requirement",                                                              // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = 1,                                                                                                        // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Primitive.Primitive_String                                                        // MakerGen.cs:296
                                {                                                                                                           // MakerGen.cs:297
                                }                                                                                                           // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:227
                        // 23. InsurancePlan.coverage.benefit.limit
                        this.Element_Limit = new ElementDefinitionInfo                                                                      // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Limit",                                                                                         // MakerGen.cs:231
                            Path= "InsurancePlan.coverage.benefit.limit",                                                                   // MakerGen.cs:232
                            Id = "InsurancePlan.coverage.benefit.limit",                                                                    // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = -1,                                                                                                       // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new Type_Limit                                                                                              // MakerGen.cs:255
                                {                                                                                                           // MakerGen.cs:256
                                }                                                                                                           // MakerGen.cs:257
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                }                                                                                                                           // MakerGen.cs:398
            }                                                                                                                               // MakerGen.cs:400
            // 18. InsurancePlan.coverage.type
            public ElementDefinitionInfo Element_Type;                                                                                      // MakerGen.cs:212
            // 19. InsurancePlan.coverage.network
            public ElementDefinitionInfo Element_Network;                                                                                   // MakerGen.cs:212
            // 20. InsurancePlan.coverage.benefit
            public ElementDefinitionInfo Element_Benefit;                                                                                   // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "InsurancePlan.coverage",                                                                                        // MakerGen.cs:388
                    ElementId = "InsurancePlan.coverage"                                                                                    // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Type.Write(sDef);                                                                                                   // MakerGen.cs:216
                Element_Network.Write(sDef);                                                                                                // MakerGen.cs:216
                Element_Benefit.Write(sDef);                                                                                                // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_Coverage()                                                                                                          // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 18. InsurancePlan.coverage.type
                    this.Element_Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Type",                                                                                              // MakerGen.cs:231
                        Path= "InsurancePlan.coverage.type",                                                                                // MakerGen.cs:232
                        Id = "InsurancePlan.coverage.type",                                                                                 // MakerGen.cs:233
                        Min = 1,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 19. InsurancePlan.coverage.network
                    this.Element_Network = new ElementDefinitionInfo                                                                        // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Network",                                                                                           // MakerGen.cs:231
                        Path= "InsurancePlan.coverage.network",                                                                             // MakerGen.cs:232
                        Id = "InsurancePlan.coverage.network",                                                                              // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:339
                            {                                                                                                               // MakerGen.cs:340
                                TargetProfile = new String[]                                                                                // MakerGen.cs:342
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:342
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:343
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 20. InsurancePlan.coverage.benefit
                    this.Element_Benefit = new ElementDefinitionInfo                                                                        // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Benefit",                                                                                           // MakerGen.cs:231
                        Path= "InsurancePlan.coverage.benefit",                                                                             // MakerGen.cs:232
                        Id = "InsurancePlan.coverage.benefit",                                                                              // MakerGen.cs:233
                        Min = 1,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new Type_Benefit                                                                                                // MakerGen.cs:255
                            {                                                                                                               // MakerGen.cs:256
                            }                                                                                                               // MakerGen.cs:257
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 26. InsurancePlan.plan
        public class Type_Plan : FhirKhit.Maker.Common.Complex.ComplexBase                                                                  // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 31. InsurancePlan.plan.generalCost
            public class Type_GeneralCost : FhirKhit.Maker.Common.Complex.ComplexBase                                                       // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                // 32. InsurancePlan.plan.generalCost.type
                public ElementDefinitionInfo Element_Type;                                                                                  // MakerGen.cs:212
                // 33. InsurancePlan.plan.generalCost.groupSize
                public ElementDefinitionInfo Element_GroupSize;                                                                             // MakerGen.cs:212
                // 34. InsurancePlan.plan.generalCost.cost
                public ElementDefinitionInfo Element_Cost;                                                                                  // MakerGen.cs:212
                // 35. InsurancePlan.plan.generalCost.comment
                public ElementDefinitionInfo Element_Comment;                                                                               // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:383
                {                                                                                                                           // MakerGen.cs:384
                    base.Write(sDef);                                                                                                       // MakerGen.cs:385
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:386
                    {                                                                                                                       // MakerGen.cs:387
                        Path = "InsurancePlan.plan.generalCost",                                                                            // MakerGen.cs:388
                        ElementId = "InsurancePlan.plan.generalCost"                                                                        // MakerGen.cs:389
                    });                                                                                                                     // MakerGen.cs:390
                    Element_Type.Write(sDef);                                                                                               // MakerGen.cs:216
                    Element_GroupSize.Write(sDef);                                                                                          // MakerGen.cs:216
                    Element_Cost.Write(sDef);                                                                                               // MakerGen.cs:216
                    Element_Comment.Write(sDef);                                                                                            // MakerGen.cs:216
                }                                                                                                                           // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
                public Type_GeneralCost()                                                                                                   // MakerGen.cs:395
                {                                                                                                                           // MakerGen.cs:396
                    {                                                                                                                       // MakerGen.cs:227
                        // 32. InsurancePlan.plan.generalCost.type
                        this.Element_Type = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Type",                                                                                          // MakerGen.cs:231
                            Path= "InsurancePlan.plan.generalCost.type",                                                                    // MakerGen.cs:232
                            Id = "InsurancePlan.plan.generalCost.type",                                                                     // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = 1,                                                                                                        // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:311
                                {                                                                                                           // MakerGen.cs:312
                                }                                                                                                           // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:227
                        // 33. InsurancePlan.plan.generalCost.groupSize
                        this.Element_GroupSize = new ElementDefinitionInfo                                                                  // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_GroupSize",                                                                                     // MakerGen.cs:231
                            Path= "InsurancePlan.plan.generalCost.groupSize",                                                               // MakerGen.cs:232
                            Id = "InsurancePlan.plan.generalCost.groupSize",                                                                // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = 1,                                                                                                        // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Primitive.Primitive_PositiveInt                                                   // MakerGen.cs:296
                                {                                                                                                           // MakerGen.cs:297
                                }                                                                                                           // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:227
                        // 34. InsurancePlan.plan.generalCost.cost
                        this.Element_Cost = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Cost",                                                                                          // MakerGen.cs:231
                            Path= "InsurancePlan.plan.generalCost.cost",                                                                    // MakerGen.cs:232
                            Id = "InsurancePlan.plan.generalCost.cost",                                                                     // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = 1,                                                                                                        // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Complex.Type_Money                                                                // MakerGen.cs:351
                                {                                                                                                           // MakerGen.cs:352
                                }                                                                                                           // MakerGen.cs:353
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:227
                        // 35. InsurancePlan.plan.generalCost.comment
                        this.Element_Comment = new ElementDefinitionInfo                                                                    // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Comment",                                                                                       // MakerGen.cs:231
                            Path= "InsurancePlan.plan.generalCost.comment",                                                                 // MakerGen.cs:232
                            Id = "InsurancePlan.plan.generalCost.comment",                                                                  // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = 1,                                                                                                        // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Primitive.Primitive_String                                                        // MakerGen.cs:296
                                {                                                                                                           // MakerGen.cs:297
                                }                                                                                                           // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                }                                                                                                                           // MakerGen.cs:398
            }                                                                                                                               // MakerGen.cs:400
            // 36. InsurancePlan.plan.specificCost
            public class Type_SpecificCost : FhirKhit.Maker.Common.Complex.ComplexBase                                                      // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                // 38. InsurancePlan.plan.specificCost.benefit
                public class Type_Benefit : FhirKhit.Maker.Common.Complex.ComplexBase                                                       // MakerGen.cs:376
                {                                                                                                                           // MakerGen.cs:377
                    // 40. InsurancePlan.plan.specificCost.benefit.cost
                    public class Type_Cost : FhirKhit.Maker.Common.Complex.ComplexBase                                                      // MakerGen.cs:376
                    {                                                                                                                       // MakerGen.cs:377
                        // 41. InsurancePlan.plan.specificCost.benefit.cost.type
                        public ElementDefinitionInfo Element_Type;                                                                          // MakerGen.cs:212
                        // 42. InsurancePlan.plan.specificCost.benefit.cost.applicability
                        public ElementDefinitionInfo Element_Applicability;                                                                 // MakerGen.cs:212
                        // 43. InsurancePlan.plan.specificCost.benefit.cost.qualifiers
                        public ElementDefinitionInfo Element_Qualifiers;                                                                    // MakerGen.cs:212
                        // 44. InsurancePlan.plan.specificCost.benefit.cost.value
                        public ElementDefinitionInfo Element_Value;                                                                         // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:383
                        {                                                                                                                   // MakerGen.cs:384
                            base.Write(sDef);                                                                                               // MakerGen.cs:385
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:386
                            {                                                                                                               // MakerGen.cs:387
                                Path = "InsurancePlan.plan.specificCost.benefit.cost",                                                      // MakerGen.cs:388
                                ElementId = "InsurancePlan.plan.specificCost.benefit.cost"                                                  // MakerGen.cs:389
                            });                                                                                                             // MakerGen.cs:390
                            Element_Type.Write(sDef);                                                                                       // MakerGen.cs:216
                            Element_Applicability.Write(sDef);                                                                              // MakerGen.cs:216
                            Element_Qualifiers.Write(sDef);                                                                                 // MakerGen.cs:216
                            Element_Value.Write(sDef);                                                                                      // MakerGen.cs:216
                        }                                                                                                                   // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
                        public Type_Cost()                                                                                                  // MakerGen.cs:395
                        {                                                                                                                   // MakerGen.cs:396
                            {                                                                                                               // MakerGen.cs:227
                                // 41. InsurancePlan.plan.specificCost.benefit.cost.type
                                this.Element_Type = new ElementDefinitionInfo                                                               // MakerGen.cs:229
                                {                                                                                                           // MakerGen.cs:230
                                    Name = "Element_Type",                                                                                  // MakerGen.cs:231
                                    Path= "InsurancePlan.plan.specificCost.benefit.cost.type",                                              // MakerGen.cs:232
                                    Id = "InsurancePlan.plan.specificCost.benefit.cost.type",                                               // MakerGen.cs:233
                                    Min = 1,                                                                                                // MakerGen.cs:234
                                    Max = 1,                                                                                                // MakerGen.cs:235
                                    Types = new BaseType[]                                                                                  // MakerGen.cs:236
                                    {                                                                                                       // MakerGen.cs:237
                                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                              // MakerGen.cs:311
                                        {                                                                                                   // MakerGen.cs:312
                                        }                                                                                                   // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:239
                                };                                                                                                          // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:227
                                // 42. InsurancePlan.plan.specificCost.benefit.cost.applicability
                                this.Element_Applicability = new ElementDefinitionInfo                                                      // MakerGen.cs:229
                                {                                                                                                           // MakerGen.cs:230
                                    Name = "Element_Applicability",                                                                         // MakerGen.cs:231
                                    Path= "InsurancePlan.plan.specificCost.benefit.cost.applicability",                                     // MakerGen.cs:232
                                    Id = "InsurancePlan.plan.specificCost.benefit.cost.applicability",                                      // MakerGen.cs:233
                                    Min = 0,                                                                                                // MakerGen.cs:234
                                    Max = 1,                                                                                                // MakerGen.cs:235
                                    Types = new BaseType[]                                                                                  // MakerGen.cs:236
                                    {                                                                                                       // MakerGen.cs:237
                                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                              // MakerGen.cs:311
                                        {                                                                                                   // MakerGen.cs:312
                                        }                                                                                                   // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:239
                                };                                                                                                          // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:227
                                // 43. InsurancePlan.plan.specificCost.benefit.cost.qualifiers
                                this.Element_Qualifiers = new ElementDefinitionInfo                                                         // MakerGen.cs:229
                                {                                                                                                           // MakerGen.cs:230
                                    Name = "Element_Qualifiers",                                                                            // MakerGen.cs:231
                                    Path= "InsurancePlan.plan.specificCost.benefit.cost.qualifiers",                                        // MakerGen.cs:232
                                    Id = "InsurancePlan.plan.specificCost.benefit.cost.qualifiers",                                         // MakerGen.cs:233
                                    Min = 0,                                                                                                // MakerGen.cs:234
                                    Max = -1,                                                                                               // MakerGen.cs:235
                                    Types = new BaseType[]                                                                                  // MakerGen.cs:236
                                    {                                                                                                       // MakerGen.cs:237
                                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                              // MakerGen.cs:311
                                        {                                                                                                   // MakerGen.cs:312
                                        }                                                                                                   // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:239
                                };                                                                                                          // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:227
                                // 44. InsurancePlan.plan.specificCost.benefit.cost.value
                                this.Element_Value = new ElementDefinitionInfo                                                              // MakerGen.cs:229
                                {                                                                                                           // MakerGen.cs:230
                                    Name = "Element_Value",                                                                                 // MakerGen.cs:231
                                    Path= "InsurancePlan.plan.specificCost.benefit.cost.value",                                             // MakerGen.cs:232
                                    Id = "InsurancePlan.plan.specificCost.benefit.cost.value",                                              // MakerGen.cs:233
                                    Min = 0,                                                                                                // MakerGen.cs:234
                                    Max = 1,                                                                                                // MakerGen.cs:235
                                    Types = new BaseType[]                                                                                  // MakerGen.cs:236
                                    {                                                                                                       // MakerGen.cs:237
                                        new FhirKhit.Maker.Common.Complex.Type_Quantity                                                     // MakerGen.cs:351
                                        {                                                                                                   // MakerGen.cs:352
                                        }                                                                                                   // MakerGen.cs:353
                                    }                                                                                                       // MakerGen.cs:239
                                };                                                                                                          // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:241
                        }                                                                                                                   // MakerGen.cs:398
                    }                                                                                                                       // MakerGen.cs:400
                    // 39. InsurancePlan.plan.specificCost.benefit.type
                    public ElementDefinitionInfo Element_Type;                                                                              // MakerGen.cs:212
                    // 40. InsurancePlan.plan.specificCost.benefit.cost
                    public ElementDefinitionInfo Element_Cost;                                                                              // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:383
                    {                                                                                                                       // MakerGen.cs:384
                        base.Write(sDef);                                                                                                   // MakerGen.cs:385
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                  // MakerGen.cs:386
                        {                                                                                                                   // MakerGen.cs:387
                            Path = "InsurancePlan.plan.specificCost.benefit",                                                               // MakerGen.cs:388
                            ElementId = "InsurancePlan.plan.specificCost.benefit"                                                           // MakerGen.cs:389
                        });                                                                                                                 // MakerGen.cs:390
                        Element_Type.Write(sDef);                                                                                           // MakerGen.cs:216
                        Element_Cost.Write(sDef);                                                                                           // MakerGen.cs:216
                    }                                                                                                                       // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
                    public Type_Benefit()                                                                                                   // MakerGen.cs:395
                    {                                                                                                                       // MakerGen.cs:396
                        {                                                                                                                   // MakerGen.cs:227
                            // 39. InsurancePlan.plan.specificCost.benefit.type
                            this.Element_Type = new ElementDefinitionInfo                                                                   // MakerGen.cs:229
                            {                                                                                                               // MakerGen.cs:230
                                Name = "Element_Type",                                                                                      // MakerGen.cs:231
                                Path= "InsurancePlan.plan.specificCost.benefit.type",                                                       // MakerGen.cs:232
                                Id = "InsurancePlan.plan.specificCost.benefit.type",                                                        // MakerGen.cs:233
                                Min = 1,                                                                                                    // MakerGen.cs:234
                                Max = 1,                                                                                                    // MakerGen.cs:235
                                Types = new BaseType[]                                                                                      // MakerGen.cs:236
                                {                                                                                                           // MakerGen.cs:237
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                  // MakerGen.cs:311
                                    {                                                                                                       // MakerGen.cs:312
                                    }                                                                                                       // MakerGen.cs:315
                                }                                                                                                           // MakerGen.cs:239
                            };                                                                                                              // MakerGen.cs:240
                        }                                                                                                                   // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:227
                            // 40. InsurancePlan.plan.specificCost.benefit.cost
                            this.Element_Cost = new ElementDefinitionInfo                                                                   // MakerGen.cs:229
                            {                                                                                                               // MakerGen.cs:230
                                Name = "Element_Cost",                                                                                      // MakerGen.cs:231
                                Path= "InsurancePlan.plan.specificCost.benefit.cost",                                                       // MakerGen.cs:232
                                Id = "InsurancePlan.plan.specificCost.benefit.cost",                                                        // MakerGen.cs:233
                                Min = 0,                                                                                                    // MakerGen.cs:234
                                Max = -1,                                                                                                   // MakerGen.cs:235
                                Types = new BaseType[]                                                                                      // MakerGen.cs:236
                                {                                                                                                           // MakerGen.cs:237
                                    new Type_Cost                                                                                           // MakerGen.cs:255
                                    {                                                                                                       // MakerGen.cs:256
                                    }                                                                                                       // MakerGen.cs:257
                                }                                                                                                           // MakerGen.cs:239
                            };                                                                                                              // MakerGen.cs:240
                        }                                                                                                                   // MakerGen.cs:241
                    }                                                                                                                       // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:400
                // 37. InsurancePlan.plan.specificCost.category
                public ElementDefinitionInfo Element_Category;                                                                              // MakerGen.cs:212
                // 38. InsurancePlan.plan.specificCost.benefit
                public ElementDefinitionInfo Element_Benefit;                                                                               // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:383
                {                                                                                                                           // MakerGen.cs:384
                    base.Write(sDef);                                                                                                       // MakerGen.cs:385
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:386
                    {                                                                                                                       // MakerGen.cs:387
                        Path = "InsurancePlan.plan.specificCost",                                                                           // MakerGen.cs:388
                        ElementId = "InsurancePlan.plan.specificCost"                                                                       // MakerGen.cs:389
                    });                                                                                                                     // MakerGen.cs:390
                    Element_Category.Write(sDef);                                                                                           // MakerGen.cs:216
                    Element_Benefit.Write(sDef);                                                                                            // MakerGen.cs:216
                }                                                                                                                           // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
                public Type_SpecificCost()                                                                                                  // MakerGen.cs:395
                {                                                                                                                           // MakerGen.cs:396
                    {                                                                                                                       // MakerGen.cs:227
                        // 37. InsurancePlan.plan.specificCost.category
                        this.Element_Category = new ElementDefinitionInfo                                                                   // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Category",                                                                                      // MakerGen.cs:231
                            Path= "InsurancePlan.plan.specificCost.category",                                                               // MakerGen.cs:232
                            Id = "InsurancePlan.plan.specificCost.category",                                                                // MakerGen.cs:233
                            Min = 1,                                                                                                        // MakerGen.cs:234
                            Max = 1,                                                                                                        // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:311
                                {                                                                                                           // MakerGen.cs:312
                                }                                                                                                           // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:227
                        // 38. InsurancePlan.plan.specificCost.benefit
                        this.Element_Benefit = new ElementDefinitionInfo                                                                    // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Benefit",                                                                                       // MakerGen.cs:231
                            Path= "InsurancePlan.plan.specificCost.benefit",                                                                // MakerGen.cs:232
                            Id = "InsurancePlan.plan.specificCost.benefit",                                                                 // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = -1,                                                                                                       // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new Type_Benefit                                                                                            // MakerGen.cs:255
                                {                                                                                                           // MakerGen.cs:256
                                }                                                                                                           // MakerGen.cs:257
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                }                                                                                                                           // MakerGen.cs:398
            }                                                                                                                               // MakerGen.cs:400
            // 27. InsurancePlan.plan.identifier
            public ElementDefinitionInfo Element_Identifier;                                                                                // MakerGen.cs:212
            // 28. InsurancePlan.plan.type
            public ElementDefinitionInfo Element_Type;                                                                                      // MakerGen.cs:212
            // 29. InsurancePlan.plan.coverageArea
            public ElementDefinitionInfo Element_CoverageArea;                                                                              // MakerGen.cs:212
            // 30. InsurancePlan.plan.network
            public ElementDefinitionInfo Element_Network;                                                                                   // MakerGen.cs:212
            // 31. InsurancePlan.plan.generalCost
            public ElementDefinitionInfo Element_GeneralCost;                                                                               // MakerGen.cs:212
            // 36. InsurancePlan.plan.specificCost
            public ElementDefinitionInfo Element_SpecificCost;                                                                              // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "InsurancePlan.plan",                                                                                            // MakerGen.cs:388
                    ElementId = "InsurancePlan.plan"                                                                                        // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Identifier.Write(sDef);                                                                                             // MakerGen.cs:216
                Element_Type.Write(sDef);                                                                                                   // MakerGen.cs:216
                Element_CoverageArea.Write(sDef);                                                                                           // MakerGen.cs:216
                Element_Network.Write(sDef);                                                                                                // MakerGen.cs:216
                Element_GeneralCost.Write(sDef);                                                                                            // MakerGen.cs:216
                Element_SpecificCost.Write(sDef);                                                                                           // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_Plan()                                                                                                              // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 27. InsurancePlan.plan.identifier
                    this.Element_Identifier = new ElementDefinitionInfo                                                                     // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Identifier",                                                                                        // MakerGen.cs:231
                        Path= "InsurancePlan.plan.identifier",                                                                              // MakerGen.cs:232
                        Id = "InsurancePlan.plan.identifier",                                                                               // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Identifier                                                               // MakerGen.cs:351
                            {                                                                                                               // MakerGen.cs:352
                            }                                                                                                               // MakerGen.cs:353
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 28. InsurancePlan.plan.type
                    this.Element_Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Type",                                                                                              // MakerGen.cs:231
                        Path= "InsurancePlan.plan.type",                                                                                    // MakerGen.cs:232
                        Id = "InsurancePlan.plan.type",                                                                                     // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 29. InsurancePlan.plan.coverageArea
                    this.Element_CoverageArea = new ElementDefinitionInfo                                                                   // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_CoverageArea",                                                                                      // MakerGen.cs:231
                        Path= "InsurancePlan.plan.coverageArea",                                                                            // MakerGen.cs:232
                        Id = "InsurancePlan.plan.coverageArea",                                                                             // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:339
                            {                                                                                                               // MakerGen.cs:340
                                TargetProfile = new String[]                                                                                // MakerGen.cs:342
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Location"                                                      // MakerGen.cs:342
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:343
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 30. InsurancePlan.plan.network
                    this.Element_Network = new ElementDefinitionInfo                                                                        // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Network",                                                                                           // MakerGen.cs:231
                        Path= "InsurancePlan.plan.network",                                                                                 // MakerGen.cs:232
                        Id = "InsurancePlan.plan.network",                                                                                  // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:339
                            {                                                                                                               // MakerGen.cs:340
                                TargetProfile = new String[]                                                                                // MakerGen.cs:342
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:342
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:343
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 31. InsurancePlan.plan.generalCost
                    this.Element_GeneralCost = new ElementDefinitionInfo                                                                    // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_GeneralCost",                                                                                       // MakerGen.cs:231
                        Path= "InsurancePlan.plan.generalCost",                                                                             // MakerGen.cs:232
                        Id = "InsurancePlan.plan.generalCost",                                                                              // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new Type_GeneralCost                                                                                            // MakerGen.cs:255
                            {                                                                                                               // MakerGen.cs:256
                            }                                                                                                               // MakerGen.cs:257
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 36. InsurancePlan.plan.specificCost
                    this.Element_SpecificCost = new ElementDefinitionInfo                                                                   // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_SpecificCost",                                                                                      // MakerGen.cs:231
                        Path= "InsurancePlan.plan.specificCost",                                                                            // MakerGen.cs:232
                        Id = "InsurancePlan.plan.specificCost",                                                                             // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new Type_SpecificCost                                                                                           // MakerGen.cs:255
                            {                                                                                                               // MakerGen.cs:256
                            }                                                                                                               // MakerGen.cs:257
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 1. InsurancePlan.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:212
        // 2. InsurancePlan.status
        public ElementDefinitionInfo Element_Status;                                                                                        // MakerGen.cs:212
        // 3. InsurancePlan.type
        public ElementDefinitionInfo Element_Type;                                                                                          // MakerGen.cs:212
        // 4. InsurancePlan.name
        public ElementDefinitionInfo Element_Name;                                                                                          // MakerGen.cs:212
        // 5. InsurancePlan.alias
        public ElementDefinitionInfo Element_Alias;                                                                                         // MakerGen.cs:212
        // 6. InsurancePlan.period
        public ElementDefinitionInfo Element_Period;                                                                                        // MakerGen.cs:212
        // 7. InsurancePlan.ownedBy
        public ElementDefinitionInfo Element_OwnedBy;                                                                                       // MakerGen.cs:212
        // 8. InsurancePlan.administeredBy
        public ElementDefinitionInfo Element_AdministeredBy;                                                                                // MakerGen.cs:212
        // 9. InsurancePlan.coverageArea
        public ElementDefinitionInfo Element_CoverageArea;                                                                                  // MakerGen.cs:212
        // 10. InsurancePlan.contact
        public ElementDefinitionInfo Element_Contact;                                                                                       // MakerGen.cs:212
        // 15. InsurancePlan.endpoint
        public ElementDefinitionInfo Element_Endpoint;                                                                                      // MakerGen.cs:212
        // 16. InsurancePlan.network
        public ElementDefinitionInfo Element_Network;                                                                                       // MakerGen.cs:212
        // 17. InsurancePlan.coverage
        public ElementDefinitionInfo Element_Coverage;                                                                                      // MakerGen.cs:212
        // 26. InsurancePlan.plan
        public ElementDefinitionInfo Element_Plan;                                                                                          // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            base.Write(sDef);                                                                                                               // MakerGen.cs:385
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:386
            {                                                                                                                               // MakerGen.cs:387
                Path = "InsurancePlan",                                                                                                     // MakerGen.cs:388
                ElementId = "InsurancePlan"                                                                                                 // MakerGen.cs:389
            });                                                                                                                             // MakerGen.cs:390
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_Status.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_Type.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_Name.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_Alias.Write(sDef);                                                                                                      // MakerGen.cs:216
            Element_Period.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_OwnedBy.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_AdministeredBy.Write(sDef);                                                                                             // MakerGen.cs:216
            Element_CoverageArea.Write(sDef);                                                                                               // MakerGen.cs:216
            Element_Contact.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_Endpoint.Write(sDef);                                                                                                   // MakerGen.cs:216
            Element_Network.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_Coverage.Write(sDef);                                                                                                   // MakerGen.cs:216
            Element_Plan.Write(sDef);                                                                                                       // MakerGen.cs:216
        }                                                                                                                                   // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
        public Resource_InsurancePlan()                                                                                                     // MakerGen.cs:395
        {                                                                                                                                   // MakerGen.cs:396
            {                                                                                                                               // MakerGen.cs:227
                // 1. InsurancePlan.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:231
                    Path= "InsurancePlan.identifier",                                                                                       // MakerGen.cs:232
                    Id = "InsurancePlan.identifier",                                                                                        // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Identifier                                                                   // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 2. InsurancePlan.status
                this.Element_Status = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Status",                                                                                                // MakerGen.cs:231
                    Path= "InsurancePlan.status",                                                                                           // MakerGen.cs:232
                    Id = "InsurancePlan.status",                                                                                            // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 3. InsurancePlan.type
                this.Element_Type = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Type",                                                                                                  // MakerGen.cs:231
                    Path= "InsurancePlan.type",                                                                                             // MakerGen.cs:232
                    Id = "InsurancePlan.type",                                                                                              // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 4. InsurancePlan.name
                this.Element_Name = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Name",                                                                                                  // MakerGen.cs:231
                    Path= "InsurancePlan.name",                                                                                             // MakerGen.cs:232
                    Id = "InsurancePlan.name",                                                                                              // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 5. InsurancePlan.alias
                this.Element_Alias = new ElementDefinitionInfo                                                                              // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Alias",                                                                                                 // MakerGen.cs:231
                    Path= "InsurancePlan.alias",                                                                                            // MakerGen.cs:232
                    Id = "InsurancePlan.alias",                                                                                             // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 6. InsurancePlan.period
                this.Element_Period = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Period",                                                                                                // MakerGen.cs:231
                    Path= "InsurancePlan.period",                                                                                           // MakerGen.cs:232
                    Id = "InsurancePlan.period",                                                                                            // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Period                                                                       // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 7. InsurancePlan.ownedBy
                this.Element_OwnedBy = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_OwnedBy",                                                                                               // MakerGen.cs:231
                    Path= "InsurancePlan.ownedBy",                                                                                          // MakerGen.cs:232
                    Id = "InsurancePlan.ownedBy",                                                                                           // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Organization"                                                      // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 8. InsurancePlan.administeredBy
                this.Element_AdministeredBy = new ElementDefinitionInfo                                                                     // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_AdministeredBy",                                                                                        // MakerGen.cs:231
                    Path= "InsurancePlan.administeredBy",                                                                                   // MakerGen.cs:232
                    Id = "InsurancePlan.administeredBy",                                                                                    // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Organization"                                                      // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 9. InsurancePlan.coverageArea
                this.Element_CoverageArea = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_CoverageArea",                                                                                          // MakerGen.cs:231
                    Path= "InsurancePlan.coverageArea",                                                                                     // MakerGen.cs:232
                    Id = "InsurancePlan.coverageArea",                                                                                      // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Location"                                                          // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 10. InsurancePlan.contact
                this.Element_Contact = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Contact",                                                                                               // MakerGen.cs:231
                    Path= "InsurancePlan.contact",                                                                                          // MakerGen.cs:232
                    Id = "InsurancePlan.contact",                                                                                           // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_Contact                                                                                                    // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 15. InsurancePlan.endpoint
                this.Element_Endpoint = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Endpoint",                                                                                              // MakerGen.cs:231
                    Path= "InsurancePlan.endpoint",                                                                                         // MakerGen.cs:232
                    Id = "InsurancePlan.endpoint",                                                                                          // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Endpoint"                                                          // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 16. InsurancePlan.network
                this.Element_Network = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Network",                                                                                               // MakerGen.cs:231
                    Path= "InsurancePlan.network",                                                                                          // MakerGen.cs:232
                    Id = "InsurancePlan.network",                                                                                           // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Organization"                                                      // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 17. InsurancePlan.coverage
                this.Element_Coverage = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Coverage",                                                                                              // MakerGen.cs:231
                    Path= "InsurancePlan.coverage",                                                                                         // MakerGen.cs:232
                    Id = "InsurancePlan.coverage",                                                                                          // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_Coverage                                                                                                   // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 26. InsurancePlan.plan
                this.Element_Plan = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Plan",                                                                                                  // MakerGen.cs:231
                    Path= "InsurancePlan.plan",                                                                                             // MakerGen.cs:232
                    Id = "InsurancePlan.plan",                                                                                              // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_Plan                                                                                                       // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            this.Name = "InsurancePlan";                                                                                                    // MakerGen.cs:458
            this.Uri = "http://hl7.org/fhir/StructureDefinition/InsurancePlan";                                                             // MakerGen.cs:459
        }                                                                                                                                   // MakerGen.cs:398
    }                                                                                                                                       // MakerGen.cs:400
}                                                                                                                                           // MakerGen.cs:445
