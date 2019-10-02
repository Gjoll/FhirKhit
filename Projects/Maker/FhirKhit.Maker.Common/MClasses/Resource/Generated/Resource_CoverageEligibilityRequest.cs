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
    #endregion
    /// <summary>
    /// Fhir resource 'CoverageEligibilityRequest'
    /// </summary>
    // 0. CoverageEligibilityRequest
    public class Resource_CoverageEligibilityRequest : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 12. CoverageEligibilityRequest.supportingInfo
        public class Type_SupportingInfo : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 13. CoverageEligibilityRequest.supportingInfo.sequence
            public ElementDefinitionInfo Element_Sequence;
            // 14. CoverageEligibilityRequest.supportingInfo.information
            public ElementDefinitionInfo Element_Information;
            // 15. CoverageEligibilityRequest.supportingInfo.appliesToAll
            public ElementDefinitionInfo Element_AppliesToAll;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "CoverageEligibilityRequest.supportingInfo",
                    ElementId = "CoverageEligibilityRequest.supportingInfo"
                });
                Element_Sequence.Write(sDef);
                Element_Information.Write(sDef);
                Element_AppliesToAll.Write(sDef);
            }
            
            public Type_SupportingInfo()
            {
                {
                    // 13. CoverageEligibilityRequest.supportingInfo.sequence
                    this.Element_Sequence = new ElementDefinitionInfo
                    {
                        Name = "Element_Sequence",
                        Path= "CoverageEligibilityRequest.supportingInfo.sequence",
                        Id = "CoverageEligibilityRequest.supportingInfo.sequence",
                        Min = 1,
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
                    // 14. CoverageEligibilityRequest.supportingInfo.information
                    this.Element_Information = new ElementDefinitionInfo
                    {
                        Name = "Element_Information",
                        Path= "CoverageEligibilityRequest.supportingInfo.information",
                        Id = "CoverageEligibilityRequest.supportingInfo.information",
                        Min = 1,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/Resource"
                                }
                            }
                        }
                    };
                }
                {
                    // 15. CoverageEligibilityRequest.supportingInfo.appliesToAll
                    this.Element_AppliesToAll = new ElementDefinitionInfo
                    {
                        Name = "Element_AppliesToAll",
                        Path= "CoverageEligibilityRequest.supportingInfo.appliesToAll",
                        Id = "CoverageEligibilityRequest.supportingInfo.appliesToAll",
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
            }
        }
        // 16. CoverageEligibilityRequest.insurance
        public class Type_Insurance : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 17. CoverageEligibilityRequest.insurance.focal
            public ElementDefinitionInfo Element_Focal;
            // 18. CoverageEligibilityRequest.insurance.coverage
            public ElementDefinitionInfo Element_Coverage;
            // 19. CoverageEligibilityRequest.insurance.businessArrangement
            public ElementDefinitionInfo Element_BusinessArrangement;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "CoverageEligibilityRequest.insurance",
                    ElementId = "CoverageEligibilityRequest.insurance"
                });
                Element_Focal.Write(sDef);
                Element_Coverage.Write(sDef);
                Element_BusinessArrangement.Write(sDef);
            }
            
            public Type_Insurance()
            {
                {
                    // 17. CoverageEligibilityRequest.insurance.focal
                    this.Element_Focal = new ElementDefinitionInfo
                    {
                        Name = "Element_Focal",
                        Path= "CoverageEligibilityRequest.insurance.focal",
                        Id = "CoverageEligibilityRequest.insurance.focal",
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
                    // 18. CoverageEligibilityRequest.insurance.coverage
                    this.Element_Coverage = new ElementDefinitionInfo
                    {
                        Name = "Element_Coverage",
                        Path= "CoverageEligibilityRequest.insurance.coverage",
                        Id = "CoverageEligibilityRequest.insurance.coverage",
                        Min = 1,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/Coverage"
                                }
                            }
                        }
                    };
                }
                {
                    // 19. CoverageEligibilityRequest.insurance.businessArrangement
                    this.Element_BusinessArrangement = new ElementDefinitionInfo
                    {
                        Name = "Element_BusinessArrangement",
                        Path= "CoverageEligibilityRequest.insurance.businessArrangement",
                        Id = "CoverageEligibilityRequest.insurance.businessArrangement",
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
        // 20. CoverageEligibilityRequest.item
        public class Type_Item : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 29. CoverageEligibilityRequest.item.diagnosis
            public class Type_Diagnosis : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 30. CoverageEligibilityRequest.item.diagnosis.diagnosis[x]
                public ElementDefinitionInfo Element_Diagnosis;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "CoverageEligibilityRequest.item.diagnosis",
                        ElementId = "CoverageEligibilityRequest.item.diagnosis"
                    });
                    Element_Diagnosis.Write(sDef);
                }
                
                public Type_Diagnosis()
                {
                    {
                        // 30. CoverageEligibilityRequest.item.diagnosis.diagnosis[x]
                        this.Element_Diagnosis = new ElementDefinitionInfo
                        {
                            Name = "Element_Diagnosis",
                            Path= "CoverageEligibilityRequest.item.diagnosis.diagnosis[x]",
                            Id = "CoverageEligibilityRequest.item.diagnosis.diagnosis[x]",
                            Min = 0,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                                {
                                },
                                new FhirKhit.Maker.Common.Complex.Type_Reference
                                {
                                    TargetProfile = new String[]
                                    {
                                        "http://hl7.org/fhir/StructureDefinition/Condition"
                                    }
                                }
                            }
                        };
                    }
                }
            }
            // 21. CoverageEligibilityRequest.item.supportingInfoSequence
            public ElementDefinitionInfo Element_SupportingInfoSequence;
            // 22. CoverageEligibilityRequest.item.category
            public ElementDefinitionInfo Element_Category;
            // 23. CoverageEligibilityRequest.item.productOrService
            public ElementDefinitionInfo Element_ProductOrService;
            // 24. CoverageEligibilityRequest.item.modifier
            public ElementDefinitionInfo Element_Modifier;
            // 25. CoverageEligibilityRequest.item.provider
            public ElementDefinitionInfo Element_Provider;
            // 26. CoverageEligibilityRequest.item.quantity
            public ElementDefinitionInfo Element_Quantity;
            // 27. CoverageEligibilityRequest.item.unitPrice
            public ElementDefinitionInfo Element_UnitPrice;
            // 28. CoverageEligibilityRequest.item.facility
            public ElementDefinitionInfo Element_Facility;
            // 29. CoverageEligibilityRequest.item.diagnosis
            public ElementDefinitionInfo Element_Diagnosis;
            // 31. CoverageEligibilityRequest.item.detail
            public ElementDefinitionInfo Element_Detail;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "CoverageEligibilityRequest.item",
                    ElementId = "CoverageEligibilityRequest.item"
                });
                Element_SupportingInfoSequence.Write(sDef);
                Element_Category.Write(sDef);
                Element_ProductOrService.Write(sDef);
                Element_Modifier.Write(sDef);
                Element_Provider.Write(sDef);
                Element_Quantity.Write(sDef);
                Element_UnitPrice.Write(sDef);
                Element_Facility.Write(sDef);
                Element_Diagnosis.Write(sDef);
                Element_Detail.Write(sDef);
            }
            
            public Type_Item()
            {
                {
                    // 21. CoverageEligibilityRequest.item.supportingInfoSequence
                    this.Element_SupportingInfoSequence = new ElementDefinitionInfo
                    {
                        Name = "Element_SupportingInfoSequence",
                        Path= "CoverageEligibilityRequest.item.supportingInfoSequence",
                        Id = "CoverageEligibilityRequest.item.supportingInfoSequence",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_PositiveInt
                            {
                            }
                        }
                    };
                }
                {
                    // 22. CoverageEligibilityRequest.item.category
                    this.Element_Category = new ElementDefinitionInfo
                    {
                        Name = "Element_Category",
                        Path= "CoverageEligibilityRequest.item.category",
                        Id = "CoverageEligibilityRequest.item.category",
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
                    // 23. CoverageEligibilityRequest.item.productOrService
                    this.Element_ProductOrService = new ElementDefinitionInfo
                    {
                        Name = "Element_ProductOrService",
                        Path= "CoverageEligibilityRequest.item.productOrService",
                        Id = "CoverageEligibilityRequest.item.productOrService",
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
                    // 24. CoverageEligibilityRequest.item.modifier
                    this.Element_Modifier = new ElementDefinitionInfo
                    {
                        Name = "Element_Modifier",
                        Path= "CoverageEligibilityRequest.item.modifier",
                        Id = "CoverageEligibilityRequest.item.modifier",
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
                    // 25. CoverageEligibilityRequest.item.provider
                    this.Element_Provider = new ElementDefinitionInfo
                    {
                        Name = "Element_Provider",
                        Path= "CoverageEligibilityRequest.item.provider",
                        Id = "CoverageEligibilityRequest.item.provider",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole"
                                }
                            }
                        }
                    };
                }
                {
                    // 26. CoverageEligibilityRequest.item.quantity
                    this.Element_Quantity = new ElementDefinitionInfo
                    {
                        Name = "Element_Quantity",
                        Path= "CoverageEligibilityRequest.item.quantity",
                        Id = "CoverageEligibilityRequest.item.quantity",
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
                    // 27. CoverageEligibilityRequest.item.unitPrice
                    this.Element_UnitPrice = new ElementDefinitionInfo
                    {
                        Name = "Element_UnitPrice",
                        Path= "CoverageEligibilityRequest.item.unitPrice",
                        Id = "CoverageEligibilityRequest.item.unitPrice",
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
                    // 28. CoverageEligibilityRequest.item.facility
                    this.Element_Facility = new ElementDefinitionInfo
                    {
                        Name = "Element_Facility",
                        Path= "CoverageEligibilityRequest.item.facility",
                        Id = "CoverageEligibilityRequest.item.facility",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/Location",
                                    "http://hl7.org/fhir/StructureDefinition/Organization"
                                }
                            }
                        }
                    };
                }
                {
                    // 29. CoverageEligibilityRequest.item.diagnosis
                    this.Element_Diagnosis = new ElementDefinitionInfo
                    {
                        Name = "Element_Diagnosis",
                        Path= "CoverageEligibilityRequest.item.diagnosis",
                        Id = "CoverageEligibilityRequest.item.diagnosis",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Diagnosis
                            {
                            }
                        }
                    };
                }
                {
                    // 31. CoverageEligibilityRequest.item.detail
                    this.Element_Detail = new ElementDefinitionInfo
                    {
                        Name = "Element_Detail",
                        Path= "CoverageEligibilityRequest.item.detail",
                        Id = "CoverageEligibilityRequest.item.detail",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/Resource"
                                }
                            }
                        }
                    };
                }
            }
        }
        // 1. CoverageEligibilityRequest.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. CoverageEligibilityRequest.status
        public ElementDefinitionInfo Element_Status;
        // 3. CoverageEligibilityRequest.priority
        public ElementDefinitionInfo Element_Priority;
        // 4. CoverageEligibilityRequest.purpose
        public ElementDefinitionInfo Element_Purpose;
        // 5. CoverageEligibilityRequest.patient
        public ElementDefinitionInfo Element_Patient;
        // 6. CoverageEligibilityRequest.serviced[x]
        public ElementDefinitionInfo Element_Serviced;
        // 7. CoverageEligibilityRequest.created
        public ElementDefinitionInfo Element_Created;
        // 8. CoverageEligibilityRequest.enterer
        public ElementDefinitionInfo Element_Enterer;
        // 9. CoverageEligibilityRequest.provider
        public ElementDefinitionInfo Element_Provider;
        // 10. CoverageEligibilityRequest.insurer
        public ElementDefinitionInfo Element_Insurer;
        // 11. CoverageEligibilityRequest.facility
        public ElementDefinitionInfo Element_Facility;
        // 12. CoverageEligibilityRequest.supportingInfo
        public ElementDefinitionInfo Element_SupportingInfo;
        // 16. CoverageEligibilityRequest.insurance
        public ElementDefinitionInfo Element_Insurance;
        // 20. CoverageEligibilityRequest.item
        public ElementDefinitionInfo Element_Item;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "CoverageEligibilityRequest",
                ElementId = "CoverageEligibilityRequest"
            });
            Element_Identifier.Write(sDef);
            Element_Status.Write(sDef);
            Element_Priority.Write(sDef);
            Element_Purpose.Write(sDef);
            Element_Patient.Write(sDef);
            Element_Serviced.Write(sDef);
            Element_Created.Write(sDef);
            Element_Enterer.Write(sDef);
            Element_Provider.Write(sDef);
            Element_Insurer.Write(sDef);
            Element_Facility.Write(sDef);
            Element_SupportingInfo.Write(sDef);
            Element_Insurance.Write(sDef);
            Element_Item.Write(sDef);
        }
        
        public Resource_CoverageEligibilityRequest()
        {
            {
                // 1. CoverageEligibilityRequest.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "CoverageEligibilityRequest.identifier",
                    Id = "CoverageEligibilityRequest.identifier",
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
                // 2. CoverageEligibilityRequest.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "CoverageEligibilityRequest.status",
                    Id = "CoverageEligibilityRequest.status",
                    Min = 1,
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
                // 3. CoverageEligibilityRequest.priority
                this.Element_Priority = new ElementDefinitionInfo
                {
                    Name = "Element_Priority",
                    Path= "CoverageEligibilityRequest.priority",
                    Id = "CoverageEligibilityRequest.priority",
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
                // 4. CoverageEligibilityRequest.purpose
                this.Element_Purpose = new ElementDefinitionInfo
                {
                    Name = "Element_Purpose",
                    Path= "CoverageEligibilityRequest.purpose",
                    Id = "CoverageEligibilityRequest.purpose",
                    Min = 1,
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
                // 5. CoverageEligibilityRequest.patient
                this.Element_Patient = new ElementDefinitionInfo
                {
                    Name = "Element_Patient",
                    Path= "CoverageEligibilityRequest.patient",
                    Id = "CoverageEligibilityRequest.patient",
                    Min = 1,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Patient"
                            }
                        }
                    }
                };
            }
            {
                // 6. CoverageEligibilityRequest.serviced[x]
                this.Element_Serviced = new ElementDefinitionInfo
                {
                    Name = "Element_Serviced",
                    Path= "CoverageEligibilityRequest.serviced[x]",
                    Id = "CoverageEligibilityRequest.serviced[x]",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Date
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Period
                        {
                        }
                    }
                };
            }
            {
                // 7. CoverageEligibilityRequest.created
                this.Element_Created = new ElementDefinitionInfo
                {
                    Name = "Element_Created",
                    Path= "CoverageEligibilityRequest.created",
                    Id = "CoverageEligibilityRequest.created",
                    Min = 1,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime
                        {
                        }
                    }
                };
            }
            {
                // 8. CoverageEligibilityRequest.enterer
                this.Element_Enterer = new ElementDefinitionInfo
                {
                    Name = "Element_Enterer",
                    Path= "CoverageEligibilityRequest.enterer",
                    Id = "CoverageEligibilityRequest.enterer",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole"
                            }
                        }
                    }
                };
            }
            {
                // 9. CoverageEligibilityRequest.provider
                this.Element_Provider = new ElementDefinitionInfo
                {
                    Name = "Element_Provider",
                    Path= "CoverageEligibilityRequest.provider",
                    Id = "CoverageEligibilityRequest.provider",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                                "http://hl7.org/fhir/StructureDefinition/Organization"
                            }
                        }
                    }
                };
            }
            {
                // 10. CoverageEligibilityRequest.insurer
                this.Element_Insurer = new ElementDefinitionInfo
                {
                    Name = "Element_Insurer",
                    Path= "CoverageEligibilityRequest.insurer",
                    Id = "CoverageEligibilityRequest.insurer",
                    Min = 1,
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
                // 11. CoverageEligibilityRequest.facility
                this.Element_Facility = new ElementDefinitionInfo
                {
                    Name = "Element_Facility",
                    Path= "CoverageEligibilityRequest.facility",
                    Id = "CoverageEligibilityRequest.facility",
                    Min = 0,
                    Max = 1,
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
                // 12. CoverageEligibilityRequest.supportingInfo
                this.Element_SupportingInfo = new ElementDefinitionInfo
                {
                    Name = "Element_SupportingInfo",
                    Path= "CoverageEligibilityRequest.supportingInfo",
                    Id = "CoverageEligibilityRequest.supportingInfo",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_SupportingInfo
                        {
                        }
                    }
                };
            }
            {
                // 16. CoverageEligibilityRequest.insurance
                this.Element_Insurance = new ElementDefinitionInfo
                {
                    Name = "Element_Insurance",
                    Path= "CoverageEligibilityRequest.insurance",
                    Id = "CoverageEligibilityRequest.insurance",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Insurance
                        {
                        }
                    }
                };
            }
            {
                // 20. CoverageEligibilityRequest.item
                this.Element_Item = new ElementDefinitionInfo
                {
                    Name = "Element_Item",
                    Path= "CoverageEligibilityRequest.item",
                    Id = "CoverageEligibilityRequest.item",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Item
                        {
                        }
                    }
                };
            }
            this.Name = "CoverageEligibilityRequest";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/CoverageEligibilityRequest";
        }
    }
}
