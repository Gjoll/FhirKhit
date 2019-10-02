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
      "id": "CoverageEligibilityRequest",
      "url": "http://hl7.org/fhir/StructureDefinition/CoverageEligibilityRequest",
      "version": "4.0.0",
      "name": "CoverageEligibilityRequest",
      "status": "draft",
      "publisher": "Health Level Seven International (Financial Management)",
      "description": "The CoverageEligibilityRequest provides patient and insurance coverage information to an insurer for them to respond, in the form of an CoverageEligibilityResponse, with information regarding whether the stated coverage is valid and in-force and optionally to provide the insurance details of the policy.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "CoverageEligibilityRequest",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "CoverageEligibilityRequest",
            "path": "CoverageEligibilityRequest",
            "short": "CoverageEligibilityRequest resource",
            "definition": "The CoverageEligibilityRequest provides patient and insurance coverage information to an insurer for them to respond, in the form of an CoverageEligibilityResponse, with information regarding whether the stated coverage is valid and in-force and optionally to provide the insurance details of the policy.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "CoverageEligibilityRequest.identifier",
            "path": "CoverageEligibilityRequest.identifier",
            "short": "Business Identifier for coverage eligiblity request",
            "definition": "A unique identifier assigned to this coverage eligiblity request.",
            "requirements": "Allows coverage eligibility requests to be distinguished and referenced.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Identifier"
              }
            ]
          },
          {
            "id": "CoverageEligibilityRequest.status",
            "path": "CoverageEligibilityRequest.status",
            "short": "active | cancelled | draft | entered-in-error",
            "definition": "The status of the resource instance.",
            "comment": "This element is labeled as a modifier because the status contains codes that mark the resource as not currently valid.",
            "requirements": "Need to track the status of the resource as 'draft' resources may undergo further edits while 'active' resources are immutable and may only have their status changed to 'cancelled'.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isModifier": true,
            "isModifierReason": "This element is labeled as a modifier because it is a status element that contains status entered-in-error which means that the resource should not be treated as valid",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "EligibilityRequestStatus"
                }
              ],
              "strength": "required",
              "description": "A code specifying the state of the resource instance.",
              "valueSet": "http://hl7.org/fhir/ValueSet/fm-status|4.0.0"
            }
          },
          {
            "id": "CoverageEligibilityRequest.priority",
            "path": "CoverageEligibilityRequest.priority",
            "short": "Desired processing priority",
            "definition": "When the requestor expects the processor to complete processing.",
            "requirements": "Needed to advise the prossesor on the urgency of the request.",
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
                  "valueString": "ProcessPriority"
                }
              ],
              "strength": "example",
              "description": "The timeliness with which processing is required: STAT, normal, Deferred.",
              "valueSet": "http://hl7.org/fhir/ValueSet/process-priority"
            }
          },
          {
            "id": "CoverageEligibilityRequest.purpose",
            "path": "CoverageEligibilityRequest.purpose",
            "short": "auth-requirements | benefits | discovery | validation",
            "definition": "Code to specify whether requesting: prior authorization requirements for some service categories or billing codes; benefits for coverages specified or discovered; discovery and return of coverages for the patient; and/or validation that the specified coverage is in-force at the date/period specified or 'now' if not specified.",
            "requirements": "To indicate the processing actions requested.",
            "min": 1,
            "max": "*",
            "type": [
              {
                "code": "code"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "EligibilityRequestPurpose"
                }
              ],
              "strength": "required",
              "description": "A code specifying the types of information being requested.",
              "valueSet": "http://hl7.org/fhir/ValueSet/eligibilityrequest-purpose|4.0.0"
            }
          },
          {
            "id": "CoverageEligibilityRequest.patient",
            "path": "CoverageEligibilityRequest.patient",
            "short": "Intended recipient of products and services",
            "definition": "The party who is the beneficiary of the supplied coverage and for whom eligibility is sought.",
            "comment": "1..1.",
            "requirements": "Required to provide context and coverage validation.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "CoverageEligibilityRequest.serviced[x]",
            "path": "CoverageEligibilityRequest.serviced[x]",
            "short": "Estimated date or dates of service",
            "definition": "The date or dates when the enclosed suite of services were performed or completed.",
            "requirements": "Required to provide time context for the request.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "date"
              },
              {
                "code": "Period"
              }
            ]
          },
          {
            "id": "CoverageEligibilityRequest.created",
            "path": "CoverageEligibilityRequest.created",
            "short": "Creation date",
            "definition": "The date when this resource was created.",
            "requirements": "Need to record a timestamp for use by both the recipient and the issuer.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ],
            "isSummary": true
          },
          {
            "id": "CoverageEligibilityRequest.enterer",
            "path": "CoverageEligibilityRequest.enterer",
            "short": "Author",
            "definition": "Person who created the request.",
            "requirements": "Some jurisdictions require the contact information for personnel completing eligibility requests.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole"
                ]
              }
            ]
          },
          {
            "id": "CoverageEligibilityRequest.provider",
            "path": "CoverageEligibilityRequest.provider",
            "short": "Party responsible for the request",
            "definition": "The provider which is responsible for the request.",
            "comment": "Typically this field would be 1..1 where this party is responsible for the eligibility request but not necessarily professionally responsible for the provision of the individual products and services listed below.",
            "requirements": "Needed to identify the requestor.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ]
          },
          {
            "id": "CoverageEligibilityRequest.insurer",
            "path": "CoverageEligibilityRequest.insurer",
            "short": "Coverage issuer",
            "definition": "The Insurer who issued the coverage in question and is the recipient of the request.",
            "requirements": "Need to identify the recipient.",
            "min": 1,
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
            "id": "CoverageEligibilityRequest.facility",
            "path": "CoverageEligibilityRequest.facility",
            "short": "Servicing facility",
            "definition": "Facility where the services are intended to be provided.",
            "requirements": "Insurance adjudication can be dependant on where services were delivered.",
            "min": 0,
            "max": "1",
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
            "id": "CoverageEligibilityRequest.supportingInfo",
            "path": "CoverageEligibilityRequest.supportingInfo",
            "short": "Supporting information",
            "definition": "Additional information codes regarding exceptions, special considerations, the condition, situation, prior or concurrent issues.",
            "comment": "Often there are multiple jurisdiction specific valuesets which are required.",
            "requirements": "Typically these information codes are required to support the services rendered or the adjudication of the services rendered.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "CoverageEligibilityRequest.supportingInfo.sequence",
            "path": "CoverageEligibilityRequest.supportingInfo.sequence",
            "short": "Information instance identifier",
            "definition": "A number to uniquely identify supporting information entries.",
            "requirements": "Necessary to maintain the order of the supporting information items and provide a mechanism to link to claim details.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "positiveInt"
              }
            ]
          },
          {
            "id": "CoverageEligibilityRequest.supportingInfo.information",
            "path": "CoverageEligibilityRequest.supportingInfo.information",
            "short": "Data to be provided",
            "definition": "Additional data or information such as resources, documents, images etc. including references to the data or the actual inclusion of the data.",
            "comment": "Could be used to provide references to other resources, document. For example could contain a PDF in an Attachment of the Police Report for an Accident.",
            "requirements": "To convey the data content to be provided when the information is more than a simple code or period.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Resource"
                ]
              }
            ]
          },
          {
            "id": "CoverageEligibilityRequest.supportingInfo.appliesToAll",
            "path": "CoverageEligibilityRequest.supportingInfo.appliesToAll",
            "short": "Applies to all items",
            "definition": "The supporting materials are applicable for all detail items, product/servce categories and specific billing codes.",
            "requirements": "Needed to convey that the information is universal to the request.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ]
          },
          {
            "id": "CoverageEligibilityRequest.insurance",
            "path": "CoverageEligibilityRequest.insurance",
            "short": "Patient insurance information",
            "definition": "Financial instruments for reimbursement for the health care products and services.",
            "comment": "All insurance coverages for the patient which may be applicable for reimbursement, of the products and services listed in the claim, are typically provided in the claim to allow insurers to confirm the ordering of the insurance coverages relative to local 'coordination of benefit' rules. One coverage (and only one) with 'focal=true' is to be used in the adjudication of this claim. Coverages appearing before the focal Coverage in the list, and where 'subrogation=false', should provide a reference to the ClaimResponse containing the adjudication results of the prior claim.",
            "requirements": "There must be at least one coverage for which eligibility is requested.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "CoverageEligibilityRequest.insurance.focal",
            "path": "CoverageEligibilityRequest.insurance.focal",
            "short": "Applicable coverage",
            "definition": "A flag to indicate that this Coverage is to be used for evaluation of this request when set to true.",
            "comment": "A patient may (will) have multiple insurance policies which provide reimburement for healthcare services and products. For example a person may also be covered by their spouse's policy and both appear in the list (and may be from the same insurer). This flag will be set to true for only one of the listed policies and that policy will be used for evaluating this request. Other requests would be created to request evaluation against the other listed policies.",
            "requirements": "To identify which coverage in the list is being used to evaluate this request.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ]
          },
          {
            "id": "CoverageEligibilityRequest.insurance.coverage",
            "path": "CoverageEligibilityRequest.insurance.coverage",
            "short": "Insurance information",
            "definition": "Reference to the insurance card level information contained in the Coverage resource. The coverage issuing insurer will use these details to locate the patient's actual coverage within the insurer's information system.",
            "requirements": "Required to allow the adjudicator to locate the correct policy and history within their information system.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Coverage"
                ]
              }
            ]
          },
          {
            "id": "CoverageEligibilityRequest.insurance.businessArrangement",
            "path": "CoverageEligibilityRequest.insurance.businessArrangement",
            "short": "Additional provider contract number",
            "definition": "A business agreement number established between the provider and the insurer for special business processing purposes.",
            "requirements": "Providers may have multiple business arrangements with a given insurer and must supply the specific contract number for adjudication.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "CoverageEligibilityRequest.item",
            "path": "CoverageEligibilityRequest.item",
            "short": "Item to be evaluated for eligibiity",
            "definition": "Service categories or billable services for which benefit details and/or an authorization prior to service delivery may be required by the payor.",
            "requirements": "The items to be processed for the request.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "CoverageEligibilityRequest.item.supportingInfoSequence",
            "path": "CoverageEligibilityRequest.item.supportingInfoSequence",
            "short": "Applicable exception or supporting information",
            "definition": "Exceptions, special conditions and supporting information applicable for this service or product line.",
            "requirements": "Needed to support or inform the consideration for eligibility.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "positiveInt"
              }
            ]
          },
          {
            "id": "CoverageEligibilityRequest.item.category",
            "path": "CoverageEligibilityRequest.item.category",
            "short": "Benefit classification",
            "definition": "Code to identify the general type of benefits under which products and services are provided.",
            "comment": "Examples include Medical Care, Periodontics, Renal Dialysis, Vision Coverage.",
            "requirements": "Needed to convey the category of service or product for which eligibility is sought.",
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
                  "valueString": "BenefitCategory"
                }
              ],
              "strength": "example",
              "description": "Benefit categories such as: oral, medical, vision etc.",
              "valueSet": "http://hl7.org/fhir/ValueSet/ex-benefitcategory"
            }
          },
          {
            "id": "CoverageEligibilityRequest.item.productOrService",
            "path": "CoverageEligibilityRequest.item.productOrService",
            "short": "Billing, service, product, or drug code",
            "definition": "This contains the product, service, drug or other billing code for the item.",
            "comment": "Code to indicate the Professional Service or Product supplied (e.g. CTP, HCPCS, USCLS, ICD10, NCPDP, DIN, RxNorm, ACHI, CCI).",
            "requirements": "Needed to convey the actual service or product for which eligibility is sought.",
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
                  "valueString": "ServiceProduct"
                }
              ],
              "strength": "example",
              "description": "Allowable service and product codes.",
              "valueSet": "http://hl7.org/fhir/ValueSet/service-uscls"
            }
          },
          {
            "id": "CoverageEligibilityRequest.item.modifier",
            "path": "CoverageEligibilityRequest.item.modifier",
            "short": "Product or service billing modifiers",
            "definition": "Item typification or modifiers codes to convey additional context for the product or service.",
            "comment": "For example in Oral whether the treatment is cosmetic or associated with TMJ, or for Medical whether the treatment was outside the clinic or out of office hours.",
            "requirements": "To support provision of the item or to charge an elevated fee.",
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
                  "valueString": "Modifiers"
                }
              ],
              "strength": "example",
              "description": "Item type or modifiers codes, eg for Oral whether the treatment is cosmetic or associated with TMJ, or an appliance was lost or stolen.",
              "valueSet": "http://hl7.org/fhir/ValueSet/claim-modifiers"
            }
          },
          {
            "id": "CoverageEligibilityRequest.item.provider",
            "path": "CoverageEligibilityRequest.item.provider",
            "short": "Perfoming practitioner",
            "definition": "The practitioner who is responsible for the product or service to be rendered to the patient.",
            "requirements": "Needed to support the evaluation of the eligibility.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole"
                ]
              }
            ]
          },
          {
            "id": "CoverageEligibilityRequest.item.quantity",
            "path": "CoverageEligibilityRequest.item.quantity",
            "short": "Count of products or services",
            "definition": "The number of repetitions of a service or product.",
            "requirements": "Required when the product or service code does not convey the quantity provided.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Quantity",
                "profile": [
                  "http://hl7.org/fhir/StructureDefinition/SimpleQuantity"
                ]
              }
            ]
          },
          {
            "id": "CoverageEligibilityRequest.item.unitPrice",
            "path": "CoverageEligibilityRequest.item.unitPrice",
            "short": "Fee, charge or cost per item",
            "definition": "The amount charged to the patient by the provider for a single unit.",
            "requirements": "Needed to support the evaluation of the eligibility.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Money"
              }
            ]
          },
          {
            "id": "CoverageEligibilityRequest.item.facility",
            "path": "CoverageEligibilityRequest.item.facility",
            "short": "Servicing facility",
            "definition": "Facility where the services will be provided.",
            "requirements": "Needed to support the evaluation of the eligibility.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Location",
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ]
          },
          {
            "id": "CoverageEligibilityRequest.item.diagnosis",
            "path": "CoverageEligibilityRequest.item.diagnosis",
            "short": "Applicable diagnosis",
            "definition": "Patient diagnosis for which care is sought.",
            "requirements": "Needed to support the evaluation of the eligibility.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "CoverageEligibilityRequest.item.diagnosis.diagnosis[x]",
            "path": "CoverageEligibilityRequest.item.diagnosis.diagnosis[x]",
            "short": "Nature of illness or problem",
            "definition": "The nature of illness or problem in a coded form or as a reference to an external defined Condition.",
            "requirements": "Provides health context for the evaluation of the products and/or services.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              },
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Condition"
                ]
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ICD10"
                }
              ],
              "strength": "example",
              "description": "ICD10 Diagnostic codes.",
              "valueSet": "http://hl7.org/fhir/ValueSet/icd-10"
            }
          },
          {
            "id": "CoverageEligibilityRequest.item.detail",
            "path": "CoverageEligibilityRequest.item.detail",
            "short": "Product or service details",
            "definition": "The plan/proposal/order describing the proposed service in detail.",
            "requirements": "Needed to provide complex service proposal such as a Device or a plan.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Resource"
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
    /// Fhir resource 'CoverageEligibilityRequest'
    /// </summary>
    // 0. CoverageEligibilityRequest
    public class Resource_CoverageEligibilityRequest : FhirKhit.Maker.Common.Resource.Resource_DomainResource                               // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        // 12. CoverageEligibilityRequest.supportingInfo
        public class Type_SupportingInfo : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 13. CoverageEligibilityRequest.supportingInfo.sequence
            public ElementDefinitionInfo Element_Sequence;                                                                                  // MakerGen.cs:219
            // 14. CoverageEligibilityRequest.supportingInfo.information
            public ElementDefinitionInfo Element_Information;                                                                               // MakerGen.cs:219
            // 15. CoverageEligibilityRequest.supportingInfo.appliesToAll
            public ElementDefinitionInfo Element_AppliesToAll;                                                                              // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "CoverageEligibilityRequest.supportingInfo",                                                                     // MakerGen.cs:395
                    ElementId = "CoverageEligibilityRequest.supportingInfo"                                                                 // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Sequence.Write(sDef);                                                                                               // MakerGen.cs:223
                Element_Information.Write(sDef);                                                                                            // MakerGen.cs:223
                Element_AppliesToAll.Write(sDef);                                                                                           // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_SupportingInfo()                                                                                                    // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 13. CoverageEligibilityRequest.supportingInfo.sequence
                    this.Element_Sequence = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Sequence",                                                                                          // MakerGen.cs:238
                        Path= "CoverageEligibilityRequest.supportingInfo.sequence",                                                         // MakerGen.cs:239
                        Id = "CoverageEligibilityRequest.supportingInfo.sequence",                                                          // MakerGen.cs:240
                        Min = 1,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_PositiveInt                                                       // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 14. CoverageEligibilityRequest.supportingInfo.information
                    this.Element_Information = new ElementDefinitionInfo                                                                    // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Information",                                                                                       // MakerGen.cs:238
                        Path= "CoverageEligibilityRequest.supportingInfo.information",                                                      // MakerGen.cs:239
                        Id = "CoverageEligibilityRequest.supportingInfo.information",                                                       // MakerGen.cs:240
                        Min = 1,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Resource"                                                      // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 15. CoverageEligibilityRequest.supportingInfo.appliesToAll
                    this.Element_AppliesToAll = new ElementDefinitionInfo                                                                   // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_AppliesToAll",                                                                                      // MakerGen.cs:238
                        Path= "CoverageEligibilityRequest.supportingInfo.appliesToAll",                                                     // MakerGen.cs:239
                        Id = "CoverageEligibilityRequest.supportingInfo.appliesToAll",                                                      // MakerGen.cs:240
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
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 16. CoverageEligibilityRequest.insurance
        public class Type_Insurance : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 17. CoverageEligibilityRequest.insurance.focal
            public ElementDefinitionInfo Element_Focal;                                                                                     // MakerGen.cs:219
            // 18. CoverageEligibilityRequest.insurance.coverage
            public ElementDefinitionInfo Element_Coverage;                                                                                  // MakerGen.cs:219
            // 19. CoverageEligibilityRequest.insurance.businessArrangement
            public ElementDefinitionInfo Element_BusinessArrangement;                                                                       // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "CoverageEligibilityRequest.insurance",                                                                          // MakerGen.cs:395
                    ElementId = "CoverageEligibilityRequest.insurance"                                                                      // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Focal.Write(sDef);                                                                                                  // MakerGen.cs:223
                Element_Coverage.Write(sDef);                                                                                               // MakerGen.cs:223
                Element_BusinessArrangement.Write(sDef);                                                                                    // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_Insurance()                                                                                                         // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 17. CoverageEligibilityRequest.insurance.focal
                    this.Element_Focal = new ElementDefinitionInfo                                                                          // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Focal",                                                                                             // MakerGen.cs:238
                        Path= "CoverageEligibilityRequest.insurance.focal",                                                                 // MakerGen.cs:239
                        Id = "CoverageEligibilityRequest.insurance.focal",                                                                  // MakerGen.cs:240
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
                    // 18. CoverageEligibilityRequest.insurance.coverage
                    this.Element_Coverage = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Coverage",                                                                                          // MakerGen.cs:238
                        Path= "CoverageEligibilityRequest.insurance.coverage",                                                              // MakerGen.cs:239
                        Id = "CoverageEligibilityRequest.insurance.coverage",                                                               // MakerGen.cs:240
                        Min = 1,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Coverage"                                                      // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 19. CoverageEligibilityRequest.insurance.businessArrangement
                    this.Element_BusinessArrangement = new ElementDefinitionInfo                                                            // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_BusinessArrangement",                                                                               // MakerGen.cs:238
                        Path= "CoverageEligibilityRequest.insurance.businessArrangement",                                                   // MakerGen.cs:239
                        Id = "CoverageEligibilityRequest.insurance.businessArrangement",                                                    // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 20. CoverageEligibilityRequest.item
        public class Type_Item : FhirKhit.Maker.Common.Complex.ComplexBase                                                                  // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 29. CoverageEligibilityRequest.item.diagnosis
            public class Type_Diagnosis : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                // 30. CoverageEligibilityRequest.item.diagnosis.diagnosis[x]
                public ElementDefinitionInfo Element_Diagnosis;                                                                             // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:390
                {                                                                                                                           // MakerGen.cs:391
                    base.Write(sDef);                                                                                                       // MakerGen.cs:392
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        Path = "CoverageEligibilityRequest.item.diagnosis",                                                                 // MakerGen.cs:395
                        ElementId = "CoverageEligibilityRequest.item.diagnosis"                                                             // MakerGen.cs:396
                    });                                                                                                                     // MakerGen.cs:397
                    Element_Diagnosis.Write(sDef);                                                                                          // MakerGen.cs:223
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
                public Type_Diagnosis()                                                                                                     // MakerGen.cs:402
                {                                                                                                                           // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:234
                        // 30. CoverageEligibilityRequest.item.diagnosis.diagnosis[x]
                        this.Element_Diagnosis = new ElementDefinitionInfo                                                                  // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Diagnosis",                                                                                     // MakerGen.cs:238
                            Path= "CoverageEligibilityRequest.item.diagnosis.diagnosis[x]",                                                 // MakerGen.cs:239
                            Id = "CoverageEligibilityRequest.item.diagnosis.diagnosis[x]",                                                  // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:318
                                {                                                                                                           // MakerGen.cs:319
                                },                                                                                                          // MakerGen.cs:322
                                new FhirKhit.Maker.Common.Complex.Type_Reference                                                            // MakerGen.cs:346
                                {                                                                                                           // MakerGen.cs:347
                                    TargetProfile = new String[]                                                                            // MakerGen.cs:349
                                    {                                                                                                       // CodeEditorExtensions.cs:28
                                        "http://hl7.org/fhir/StructureDefinition/Condition"                                                 // MakerGen.cs:349
                                    }                                                                                                       // CodeEditorExtensions.cs:34
                                }                                                                                                           // MakerGen.cs:350
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                }                                                                                                                           // MakerGen.cs:405
            }                                                                                                                               // MakerGen.cs:407
            // 21. CoverageEligibilityRequest.item.supportingInfoSequence
            public ElementDefinitionInfo Element_SupportingInfoSequence;                                                                    // MakerGen.cs:219
            // 22. CoverageEligibilityRequest.item.category
            public ElementDefinitionInfo Element_Category;                                                                                  // MakerGen.cs:219
            // 23. CoverageEligibilityRequest.item.productOrService
            public ElementDefinitionInfo Element_ProductOrService;                                                                          // MakerGen.cs:219
            // 24. CoverageEligibilityRequest.item.modifier
            public ElementDefinitionInfo Element_Modifier;                                                                                  // MakerGen.cs:219
            // 25. CoverageEligibilityRequest.item.provider
            public ElementDefinitionInfo Element_Provider;                                                                                  // MakerGen.cs:219
            // 26. CoverageEligibilityRequest.item.quantity
            public ElementDefinitionInfo Element_Quantity;                                                                                  // MakerGen.cs:219
            // 27. CoverageEligibilityRequest.item.unitPrice
            public ElementDefinitionInfo Element_UnitPrice;                                                                                 // MakerGen.cs:219
            // 28. CoverageEligibilityRequest.item.facility
            public ElementDefinitionInfo Element_Facility;                                                                                  // MakerGen.cs:219
            // 29. CoverageEligibilityRequest.item.diagnosis
            public ElementDefinitionInfo Element_Diagnosis;                                                                                 // MakerGen.cs:219
            // 31. CoverageEligibilityRequest.item.detail
            public ElementDefinitionInfo Element_Detail;                                                                                    // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "CoverageEligibilityRequest.item",                                                                               // MakerGen.cs:395
                    ElementId = "CoverageEligibilityRequest.item"                                                                           // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_SupportingInfoSequence.Write(sDef);                                                                                 // MakerGen.cs:223
                Element_Category.Write(sDef);                                                                                               // MakerGen.cs:223
                Element_ProductOrService.Write(sDef);                                                                                       // MakerGen.cs:223
                Element_Modifier.Write(sDef);                                                                                               // MakerGen.cs:223
                Element_Provider.Write(sDef);                                                                                               // MakerGen.cs:223
                Element_Quantity.Write(sDef);                                                                                               // MakerGen.cs:223
                Element_UnitPrice.Write(sDef);                                                                                              // MakerGen.cs:223
                Element_Facility.Write(sDef);                                                                                               // MakerGen.cs:223
                Element_Diagnosis.Write(sDef);                                                                                              // MakerGen.cs:223
                Element_Detail.Write(sDef);                                                                                                 // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_Item()                                                                                                              // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 21. CoverageEligibilityRequest.item.supportingInfoSequence
                    this.Element_SupportingInfoSequence = new ElementDefinitionInfo                                                         // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_SupportingInfoSequence",                                                                            // MakerGen.cs:238
                        Path= "CoverageEligibilityRequest.item.supportingInfoSequence",                                                     // MakerGen.cs:239
                        Id = "CoverageEligibilityRequest.item.supportingInfoSequence",                                                      // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = -1,                                                                                                           // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_PositiveInt                                                       // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 22. CoverageEligibilityRequest.item.category
                    this.Element_Category = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Category",                                                                                          // MakerGen.cs:238
                        Path= "CoverageEligibilityRequest.item.category",                                                                   // MakerGen.cs:239
                        Id = "CoverageEligibilityRequest.item.category",                                                                    // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:318
                            {                                                                                                               // MakerGen.cs:319
                            }                                                                                                               // MakerGen.cs:322
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 23. CoverageEligibilityRequest.item.productOrService
                    this.Element_ProductOrService = new ElementDefinitionInfo                                                               // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_ProductOrService",                                                                                  // MakerGen.cs:238
                        Path= "CoverageEligibilityRequest.item.productOrService",                                                           // MakerGen.cs:239
                        Id = "CoverageEligibilityRequest.item.productOrService",                                                            // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:318
                            {                                                                                                               // MakerGen.cs:319
                            }                                                                                                               // MakerGen.cs:322
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 24. CoverageEligibilityRequest.item.modifier
                    this.Element_Modifier = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Modifier",                                                                                          // MakerGen.cs:238
                        Path= "CoverageEligibilityRequest.item.modifier",                                                                   // MakerGen.cs:239
                        Id = "CoverageEligibilityRequest.item.modifier",                                                                    // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = -1,                                                                                                           // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:318
                            {                                                                                                               // MakerGen.cs:319
                            }                                                                                                               // MakerGen.cs:322
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 25. CoverageEligibilityRequest.item.provider
                    this.Element_Provider = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Provider",                                                                                          // MakerGen.cs:238
                        Path= "CoverageEligibilityRequest.item.provider",                                                                   // MakerGen.cs:239
                        Id = "CoverageEligibilityRequest.item.provider",                                                                    // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                                              // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 26. CoverageEligibilityRequest.item.quantity
                    this.Element_Quantity = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Quantity",                                                                                          // MakerGen.cs:238
                        Path= "CoverageEligibilityRequest.item.quantity",                                                                   // MakerGen.cs:239
                        Id = "CoverageEligibilityRequest.item.quantity",                                                                    // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                 // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 27. CoverageEligibilityRequest.item.unitPrice
                    this.Element_UnitPrice = new ElementDefinitionInfo                                                                      // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_UnitPrice",                                                                                         // MakerGen.cs:238
                        Path= "CoverageEligibilityRequest.item.unitPrice",                                                                  // MakerGen.cs:239
                        Id = "CoverageEligibilityRequest.item.unitPrice",                                                                   // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Money                                                                    // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 28. CoverageEligibilityRequest.item.facility
                    this.Element_Facility = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Facility",                                                                                          // MakerGen.cs:238
                        Path= "CoverageEligibilityRequest.item.facility",                                                                   // MakerGen.cs:239
                        Id = "CoverageEligibilityRequest.item.facility",                                                                    // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Location",                                                     // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 29. CoverageEligibilityRequest.item.diagnosis
                    this.Element_Diagnosis = new ElementDefinitionInfo                                                                      // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Diagnosis",                                                                                         // MakerGen.cs:238
                        Path= "CoverageEligibilityRequest.item.diagnosis",                                                                  // MakerGen.cs:239
                        Id = "CoverageEligibilityRequest.item.diagnosis",                                                                   // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = -1,                                                                                                           // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new Type_Diagnosis                                                                                              // MakerGen.cs:262
                            {                                                                                                               // MakerGen.cs:263
                            }                                                                                                               // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 31. CoverageEligibilityRequest.item.detail
                    this.Element_Detail = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Detail",                                                                                            // MakerGen.cs:238
                        Path= "CoverageEligibilityRequest.item.detail",                                                                     // MakerGen.cs:239
                        Id = "CoverageEligibilityRequest.item.detail",                                                                      // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = -1,                                                                                                           // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Resource"                                                      // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 1. CoverageEligibilityRequest.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:219
        // 2. CoverageEligibilityRequest.status
        public ElementDefinitionInfo Element_Status;                                                                                        // MakerGen.cs:219
        // 3. CoverageEligibilityRequest.priority
        public ElementDefinitionInfo Element_Priority;                                                                                      // MakerGen.cs:219
        // 4. CoverageEligibilityRequest.purpose
        public ElementDefinitionInfo Element_Purpose;                                                                                       // MakerGen.cs:219
        // 5. CoverageEligibilityRequest.patient
        public ElementDefinitionInfo Element_Patient;                                                                                       // MakerGen.cs:219
        // 6. CoverageEligibilityRequest.serviced[x]
        public ElementDefinitionInfo Element_Serviced;                                                                                      // MakerGen.cs:219
        // 7. CoverageEligibilityRequest.created
        public ElementDefinitionInfo Element_Created;                                                                                       // MakerGen.cs:219
        // 8. CoverageEligibilityRequest.enterer
        public ElementDefinitionInfo Element_Enterer;                                                                                       // MakerGen.cs:219
        // 9. CoverageEligibilityRequest.provider
        public ElementDefinitionInfo Element_Provider;                                                                                      // MakerGen.cs:219
        // 10. CoverageEligibilityRequest.insurer
        public ElementDefinitionInfo Element_Insurer;                                                                                       // MakerGen.cs:219
        // 11. CoverageEligibilityRequest.facility
        public ElementDefinitionInfo Element_Facility;                                                                                      // MakerGen.cs:219
        // 12. CoverageEligibilityRequest.supportingInfo
        public ElementDefinitionInfo Element_SupportingInfo;                                                                                // MakerGen.cs:219
        // 16. CoverageEligibilityRequest.insurance
        public ElementDefinitionInfo Element_Insurance;                                                                                     // MakerGen.cs:219
        // 20. CoverageEligibilityRequest.item
        public ElementDefinitionInfo Element_Item;                                                                                          // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:390
        {                                                                                                                                   // MakerGen.cs:391
            base.Write(sDef);                                                                                                               // MakerGen.cs:392
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                Path = "CoverageEligibilityRequest",                                                                                        // MakerGen.cs:395
                ElementId = "CoverageEligibilityRequest"                                                                                    // MakerGen.cs:396
            });                                                                                                                             // MakerGen.cs:397
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_Status.Write(sDef);                                                                                                     // MakerGen.cs:223
            Element_Priority.Write(sDef);                                                                                                   // MakerGen.cs:223
            Element_Purpose.Write(sDef);                                                                                                    // MakerGen.cs:223
            Element_Patient.Write(sDef);                                                                                                    // MakerGen.cs:223
            Element_Serviced.Write(sDef);                                                                                                   // MakerGen.cs:223
            Element_Created.Write(sDef);                                                                                                    // MakerGen.cs:223
            Element_Enterer.Write(sDef);                                                                                                    // MakerGen.cs:223
            Element_Provider.Write(sDef);                                                                                                   // MakerGen.cs:223
            Element_Insurer.Write(sDef);                                                                                                    // MakerGen.cs:223
            Element_Facility.Write(sDef);                                                                                                   // MakerGen.cs:223
            Element_SupportingInfo.Write(sDef);                                                                                             // MakerGen.cs:223
            Element_Insurance.Write(sDef);                                                                                                  // MakerGen.cs:223
            Element_Item.Write(sDef);                                                                                                       // MakerGen.cs:223
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
        public Resource_CoverageEligibilityRequest()                                                                                        // MakerGen.cs:402
        {                                                                                                                                   // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:234
                // 1. CoverageEligibilityRequest.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:238
                    Path= "CoverageEligibilityRequest.identifier",                                                                          // MakerGen.cs:239
                    Id = "CoverageEligibilityRequest.identifier",                                                                           // MakerGen.cs:240
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
                // 2. CoverageEligibilityRequest.status
                this.Element_Status = new ElementDefinitionInfo                                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Status",                                                                                                // MakerGen.cs:238
                    Path= "CoverageEligibilityRequest.status",                                                                              // MakerGen.cs:239
                    Id = "CoverageEligibilityRequest.status",                                                                               // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 3. CoverageEligibilityRequest.priority
                this.Element_Priority = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Priority",                                                                                              // MakerGen.cs:238
                    Path= "CoverageEligibilityRequest.priority",                                                                            // MakerGen.cs:239
                    Id = "CoverageEligibilityRequest.priority",                                                                             // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:322
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 4. CoverageEligibilityRequest.purpose
                this.Element_Purpose = new ElementDefinitionInfo                                                                            // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Purpose",                                                                                               // MakerGen.cs:238
                    Path= "CoverageEligibilityRequest.purpose",                                                                             // MakerGen.cs:239
                    Id = "CoverageEligibilityRequest.purpose",                                                                              // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 5. CoverageEligibilityRequest.patient
                this.Element_Patient = new ElementDefinitionInfo                                                                            // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Patient",                                                                                               // MakerGen.cs:238
                    Path= "CoverageEligibilityRequest.patient",                                                                             // MakerGen.cs:239
                    Id = "CoverageEligibilityRequest.patient",                                                                              // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Patient"                                                           // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 6. CoverageEligibilityRequest.serviced[x]
                this.Element_Serviced = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Serviced",                                                                                              // MakerGen.cs:238
                    Path= "CoverageEligibilityRequest.serviced[x]",                                                                         // MakerGen.cs:239
                    Id = "CoverageEligibilityRequest.serviced[x]",                                                                          // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Date                                                                  // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        },                                                                                                                  // MakerGen.cs:307
                        new FhirKhit.Maker.Common.Complex.Type_Period                                                                       // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 7. CoverageEligibilityRequest.created
                this.Element_Created = new ElementDefinitionInfo                                                                            // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Created",                                                                                               // MakerGen.cs:238
                    Path= "CoverageEligibilityRequest.created",                                                                             // MakerGen.cs:239
                    Id = "CoverageEligibilityRequest.created",                                                                              // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                              // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 8. CoverageEligibilityRequest.enterer
                this.Element_Enterer = new ElementDefinitionInfo                                                                            // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Enterer",                                                                                               // MakerGen.cs:238
                    Path= "CoverageEligibilityRequest.enterer",                                                                             // MakerGen.cs:239
                    Id = "CoverageEligibilityRequest.enterer",                                                                              // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                     // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                                                  // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 9. CoverageEligibilityRequest.provider
                this.Element_Provider = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Provider",                                                                                              // MakerGen.cs:238
                    Path= "CoverageEligibilityRequest.provider",                                                                            // MakerGen.cs:239
                    Id = "CoverageEligibilityRequest.provider",                                                                             // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                     // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                                 // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/Organization"                                                      // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 10. CoverageEligibilityRequest.insurer
                this.Element_Insurer = new ElementDefinitionInfo                                                                            // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Insurer",                                                                                               // MakerGen.cs:238
                    Path= "CoverageEligibilityRequest.insurer",                                                                             // MakerGen.cs:239
                    Id = "CoverageEligibilityRequest.insurer",                                                                              // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
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
                // 11. CoverageEligibilityRequest.facility
                this.Element_Facility = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Facility",                                                                                              // MakerGen.cs:238
                    Path= "CoverageEligibilityRequest.facility",                                                                            // MakerGen.cs:239
                    Id = "CoverageEligibilityRequest.facility",                                                                             // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
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
                // 12. CoverageEligibilityRequest.supportingInfo
                this.Element_SupportingInfo = new ElementDefinitionInfo                                                                     // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_SupportingInfo",                                                                                        // MakerGen.cs:238
                    Path= "CoverageEligibilityRequest.supportingInfo",                                                                      // MakerGen.cs:239
                    Id = "CoverageEligibilityRequest.supportingInfo",                                                                       // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_SupportingInfo                                                                                             // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 16. CoverageEligibilityRequest.insurance
                this.Element_Insurance = new ElementDefinitionInfo                                                                          // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Insurance",                                                                                             // MakerGen.cs:238
                    Path= "CoverageEligibilityRequest.insurance",                                                                           // MakerGen.cs:239
                    Id = "CoverageEligibilityRequest.insurance",                                                                            // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_Insurance                                                                                                  // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 20. CoverageEligibilityRequest.item
                this.Element_Item = new ElementDefinitionInfo                                                                               // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Item",                                                                                                  // MakerGen.cs:238
                    Path= "CoverageEligibilityRequest.item",                                                                                // MakerGen.cs:239
                    Id = "CoverageEligibilityRequest.item",                                                                                 // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_Item                                                                                                       // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            this.Name = "CoverageEligibilityRequest";                                                                                       // MakerGen.cs:471
            this.Uri = "http://hl7.org/fhir/StructureDefinition/CoverageEligibilityRequest";                                                // MakerGen.cs:472
        }                                                                                                                                   // MakerGen.cs:405
    }                                                                                                                                       // MakerGen.cs:407
}                                                                                                                                           // MakerGen.cs:452
