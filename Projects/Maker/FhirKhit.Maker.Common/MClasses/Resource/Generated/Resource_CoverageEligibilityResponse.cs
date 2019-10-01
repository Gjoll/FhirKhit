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
      "id": "CoverageEligibilityResponse",
      "url": "http://hl7.org/fhir/StructureDefinition/CoverageEligibilityResponse",
      "version": "4.0.0",
      "name": "CoverageEligibilityResponse",
      "status": "draft",
      "publisher": "Health Level Seven International (Financial Management)",
      "description": "This resource provides eligibility and plan details from the processing of an CoverageEligibilityRequest resource.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "CoverageEligibilityResponse",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "CoverageEligibilityResponse",
            "path": "CoverageEligibilityResponse",
            "short": "CoverageEligibilityResponse resource",
            "definition": "This resource provides eligibility and plan details from the processing of an CoverageEligibilityRequest resource.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "CoverageEligibilityResponse.identifier",
            "path": "CoverageEligibilityResponse.identifier",
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
            "id": "CoverageEligibilityResponse.status",
            "path": "CoverageEligibilityResponse.status",
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
                  "valueString": "EligibilityResponseStatus"
                }
              ],
              "strength": "required",
              "description": "A code specifying the state of the resource instance.",
              "valueSet": "http://hl7.org/fhir/ValueSet/fm-status|4.0.0"
            }
          },
          {
            "id": "CoverageEligibilityResponse.purpose",
            "path": "CoverageEligibilityResponse.purpose",
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
                  "valueString": "EligibilityResponsePurpose"
                }
              ],
              "strength": "required",
              "description": "A code specifying the types of information being requested.",
              "valueSet": "http://hl7.org/fhir/ValueSet/eligibilityresponse-purpose|4.0.0"
            }
          },
          {
            "id": "CoverageEligibilityResponse.patient",
            "path": "CoverageEligibilityResponse.patient",
            "short": "Intended recipient of products and services",
            "definition": "The party who is the beneficiary of the supplied coverage and for whom eligibility is sought.",
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
            "id": "CoverageEligibilityResponse.serviced[x]",
            "path": "CoverageEligibilityResponse.serviced[x]",
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
            "id": "CoverageEligibilityResponse.created",
            "path": "CoverageEligibilityResponse.created",
            "short": "Response creation date",
            "definition": "The date this resource was created.",
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
            "id": "CoverageEligibilityResponse.requestor",
            "path": "CoverageEligibilityResponse.requestor",
            "short": "Party responsible for the request",
            "definition": "The provider which is responsible for the request.",
            "comment": "Typically this field would be 1..1 where this party is responsible for the claim but not necessarily professionally responsible for the provision of the individual products and services listed below.",
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
            "id": "CoverageEligibilityResponse.request",
            "path": "CoverageEligibilityResponse.request",
            "short": "Eligibility request reference",
            "definition": "Reference to the original request resource.",
            "requirements": "Needed to allow the response to be linked to the request.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/CoverageEligibilityRequest"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "CoverageEligibilityResponse.outcome",
            "path": "CoverageEligibilityResponse.outcome",
            "short": "queued | complete | error | partial",
            "definition": "The outcome of the request processing.",
            "comment": "The resource may be used to indicate that: the request has been held (queued) for processing; that it has been processed and errors found (error); that no errors were found and that some of the adjudication has been undertaken (partial) or that all of the adjudication has been undertaken (complete).",
            "requirements": "To advise the requestor of an overall processing outcome.",
            "min": 1,
            "max": "1",
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
                  "valueString": "RemittanceOutcome"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "required",
              "description": "The outcome of the processing.",
              "valueSet": "http://hl7.org/fhir/ValueSet/remittance-outcome|4.0.0"
            }
          },
          {
            "id": "CoverageEligibilityResponse.disposition",
            "path": "CoverageEligibilityResponse.disposition",
            "short": "Disposition Message",
            "definition": "A human readable description of the status of the adjudication.",
            "requirements": "Provided for user display.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "CoverageEligibilityResponse.insurer",
            "path": "CoverageEligibilityResponse.insurer",
            "short": "Coverage issuer",
            "definition": "The Insurer who issued the coverage in question and is the author of the response.",
            "requirements": "Need to identify the author.",
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
            "id": "CoverageEligibilityResponse.insurance",
            "path": "CoverageEligibilityResponse.insurance",
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
            "id": "CoverageEligibilityResponse.insurance.coverage",
            "path": "CoverageEligibilityResponse.insurance.coverage",
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
            ],
            "isSummary": true
          },
          {
            "id": "CoverageEligibilityResponse.insurance.inforce",
            "path": "CoverageEligibilityResponse.insurance.inforce",
            "short": "Coverage inforce indicator",
            "definition": "Flag indicating if the coverage provided is inforce currently if no service date(s) specified or for the whole duration of the service dates.",
            "requirements": "Needed to convey the answer to the eligibility validation request.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ]
          },
          {
            "id": "CoverageEligibilityResponse.insurance.benefitPeriod",
            "path": "CoverageEligibilityResponse.insurance.benefitPeriod",
            "short": "When the benefits are applicable",
            "definition": "The term of the benefits documented in this response.",
            "requirements": "Needed as coverages may be multi-year while benefits tend to be annual therefore a separate expression of the benefit period is needed.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Period"
              }
            ]
          },
          {
            "id": "CoverageEligibilityResponse.insurance.item",
            "path": "CoverageEligibilityResponse.insurance.item",
            "short": "Benefits and authorization details",
            "definition": "Benefits and optionally current balances, and authorization details by category or service.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "CoverageEligibilityResponse.insurance.item.category",
            "path": "CoverageEligibilityResponse.insurance.item.category",
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
            "id": "CoverageEligibilityResponse.insurance.item.productOrService",
            "path": "CoverageEligibilityResponse.insurance.item.productOrService",
            "short": "Billing, service, product, or drug code",
            "definition": "This contains the product, service, drug or other billing code for the item.",
            "comment": "Code to indicate the Professional Service or Product supplied (e.g. CTP, HCPCS, USCLS, ICD10, NCPDP, DIN, RxNorm, ACHI, CCI).",
            "requirements": "Needed to convey the actual service or product for which eligibility is sought.",
            "alias": [
              "Drug Code",
              "Bill Code",
              "Service Code"
            ],
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
            "id": "CoverageEligibilityResponse.insurance.item.modifier",
            "path": "CoverageEligibilityResponse.insurance.item.modifier",
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
            "id": "CoverageEligibilityResponse.insurance.item.provider",
            "path": "CoverageEligibilityResponse.insurance.item.provider",
            "short": "Performing practitioner",
            "definition": "The practitioner who is eligible for the provision of the product or service.",
            "requirements": "Needed to convey the eligible provider.",
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
            "id": "CoverageEligibilityResponse.insurance.item.excluded",
            "path": "CoverageEligibilityResponse.insurance.item.excluded",
            "short": "Excluded from the plan",
            "definition": "True if the indicated class of service is excluded from the plan, missing or False indicates the product or service is included in the coverage.",
            "requirements": "Needed to identify items that are specifically excluded from the coverage.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ]
          },
          {
            "id": "CoverageEligibilityResponse.insurance.item.name",
            "path": "CoverageEligibilityResponse.insurance.item.name",
            "short": "Short name for the benefit",
            "definition": "A short name or tag for the benefit.",
            "comment": "For example: MED01, or DENT2.",
            "requirements": "Required to align with other plan names.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "CoverageEligibilityResponse.insurance.item.description",
            "path": "CoverageEligibilityResponse.insurance.item.description",
            "short": "Description of the benefit or services covered",
            "definition": "A richer description of the benefit or services covered.",
            "comment": "For example 'DENT2 covers 100% of basic, 50% of major but excludes Ortho, Implants and Cosmetic services'.",
            "requirements": "Needed for human readable reference.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "CoverageEligibilityResponse.insurance.item.network",
            "path": "CoverageEligibilityResponse.insurance.item.network",
            "short": "In or out of network",
            "definition": "Is a flag to indicate whether the benefits refer to in-network providers or out-of-network providers.",
            "requirements": "Needed as in or out of network providers are treated differently under the coverage.",
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
                  "valueString": "BenefitNetwork"
                }
              ],
              "strength": "example",
              "description": "Code to classify in or out of network services.",
              "valueSet": "http://hl7.org/fhir/ValueSet/benefit-network"
            }
          },
          {
            "id": "CoverageEligibilityResponse.insurance.item.unit",
            "path": "CoverageEligibilityResponse.insurance.item.unit",
            "short": "Individual or family",
            "definition": "Indicates if the benefits apply to an individual or to the family.",
            "requirements": "Needed for the understanding of the benefits.",
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
                  "valueString": "BenefitUnit"
                }
              ],
              "strength": "example",
              "description": "Unit covered/serviced - individual or family.",
              "valueSet": "http://hl7.org/fhir/ValueSet/benefit-unit"
            }
          },
          {
            "id": "CoverageEligibilityResponse.insurance.item.term",
            "path": "CoverageEligibilityResponse.insurance.item.term",
            "short": "Annual or lifetime",
            "definition": "The term or period of the values such as 'maximum lifetime benefit' or 'maximum annual visits'.",
            "requirements": "Needed for the understanding of the benefits.",
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
                  "valueString": "BenefitTerm"
                }
              ],
              "strength": "example",
              "description": "Coverage unit - annual, lifetime.",
              "valueSet": "http://hl7.org/fhir/ValueSet/benefit-term"
            }
          },
          {
            "id": "CoverageEligibilityResponse.insurance.item.benefit",
            "path": "CoverageEligibilityResponse.insurance.item.benefit",
            "short": "Benefit Summary",
            "definition": "Benefits used to date.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "CoverageEligibilityResponse.insurance.item.benefit.type",
            "path": "CoverageEligibilityResponse.insurance.item.benefit.type",
            "short": "Benefit classification",
            "definition": "Classification of benefit being provided.",
            "comment": "For example: deductible, visits, benefit amount.",
            "requirements": "Needed to convey the nature of the benefit.",
            "min": 1,
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
                  "valueString": "BenefitType"
                }
              ],
              "strength": "example",
              "description": "Deductable, visits, co-pay, etc.",
              "valueSet": "http://hl7.org/fhir/ValueSet/benefit-type"
            }
          },
          {
            "id": "CoverageEligibilityResponse.insurance.item.benefit.allowed[x]",
            "path": "CoverageEligibilityResponse.insurance.item.benefit.allowed[x]",
            "short": "Benefits allowed",
            "definition": "The quantity of the benefit which is permitted under the coverage.",
            "requirements": "Needed to convey the benefits offered under the coverage.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "unsignedInt"
              },
              {
                "code": "string"
              },
              {
                "code": "Money"
              }
            ]
          },
          {
            "id": "CoverageEligibilityResponse.insurance.item.benefit.used[x]",
            "path": "CoverageEligibilityResponse.insurance.item.benefit.used[x]",
            "short": "Benefits used",
            "definition": "The quantity of the benefit which have been consumed to date.",
            "requirements": "Needed to convey the benefits consumed to date.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "unsignedInt"
              },
              {
                "code": "string"
              },
              {
                "code": "Money"
              }
            ]
          },
          {
            "id": "CoverageEligibilityResponse.insurance.item.authorizationRequired",
            "path": "CoverageEligibilityResponse.insurance.item.authorizationRequired",
            "short": "Authorization required flag",
            "definition": "A boolean flag indicating whether a preauthorization is required prior to actual service delivery.",
            "requirements": "Needed to convey that preauthorization is required.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ]
          },
          {
            "id": "CoverageEligibilityResponse.insurance.item.authorizationSupporting",
            "path": "CoverageEligibilityResponse.insurance.item.authorizationSupporting",
            "short": "Type of required supporting materials",
            "definition": "Codes or comments regarding information or actions associated with the preauthorization.",
            "requirements": "Needed to inform the provider of collateral materials or actions needed for preauthorization.",
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
                  "valueString": "AuthSupporting"
                }
              ],
              "strength": "example",
              "description": "Type of supporting information to provide with a preauthorization.",
              "valueSet": "http://hl7.org/fhir/ValueSet/coverageeligibilityresponse-ex-auth-support"
            }
          },
          {
            "id": "CoverageEligibilityResponse.insurance.item.authorizationUrl",
            "path": "CoverageEligibilityResponse.insurance.item.authorizationUrl",
            "short": "Preauthorization requirements endpoint",
            "definition": "A web location for obtaining requirements or descriptive information regarding the preauthorization.",
            "requirements": "Needed to enable insurers to advise providers of informative information.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "uri"
              }
            ]
          },
          {
            "id": "CoverageEligibilityResponse.preAuthRef",
            "path": "CoverageEligibilityResponse.preAuthRef",
            "short": "Preauthorization reference",
            "definition": "A reference from the Insurer to which these services pertain to be used on further communication and as proof that the request occurred.",
            "requirements": "To provide any preauthorization reference for provider use.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "CoverageEligibilityResponse.form",
            "path": "CoverageEligibilityResponse.form",
            "short": "Printed form identifier",
            "definition": "A code for the form to be used for printing the content.",
            "comment": "May be needed to identify specific jurisdictional forms.",
            "requirements": "Needed to specify the specific form used for producing output for this response.",
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
                  "valueString": "Forms"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "example",
              "description": "The forms codes.",
              "valueSet": "http://hl7.org/fhir/ValueSet/forms"
            }
          },
          {
            "id": "CoverageEligibilityResponse.error",
            "path": "CoverageEligibilityResponse.error",
            "short": "Processing errors",
            "definition": "Errors encountered during the processing of the request.",
            "requirements": "Need to communicate processing issues to the requestor.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "CoverageEligibilityResponse.error.code",
            "path": "CoverageEligibilityResponse.error.code",
            "short": "Error code detailing processing issues",
            "definition": "An error code,from a specified code system, which details why the eligibility check could not be performed.",
            "requirements": "Required to convey processing errors.",
            "min": 1,
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
                  "valueString": "AdjudicationError"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "example",
              "description": "The error codes for adjudication processing.",
              "valueSet": "http://hl7.org/fhir/ValueSet/adjudication-error"
            }
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:440
    /// <summary>
    /// Fhir resource 'CoverageEligibilityResponse'
    /// </summary>
    // 0. CoverageEligibilityResponse
    public class Resource_CoverageEligibilityResponse : FhirKhit.Maker.Common.Resource.ResourceBase                                         // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        // 12. CoverageEligibilityResponse.insurance
        public class Type_Insurance : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 16. CoverageEligibilityResponse.insurance.item
            public class Type_Item : FhirKhit.Maker.Common.Complex.ComplexBase                                                              // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                // 27. CoverageEligibilityResponse.insurance.item.benefit
                public class Type_Benefit : FhirKhit.Maker.Common.Complex.ComplexBase                                                       // MakerGen.cs:376
                {                                                                                                                           // MakerGen.cs:377
                    // 28. CoverageEligibilityResponse.insurance.item.benefit.type
                    public ElementDefinitionInfo Element_Type;                                                                              // MakerGen.cs:212
                    // 29. CoverageEligibilityResponse.insurance.item.benefit.allowed[x]
                    public ElementDefinitionInfo Element_Allowed;                                                                           // MakerGen.cs:212
                    // 30. CoverageEligibilityResponse.insurance.item.benefit.used[x]
                    public ElementDefinitionInfo Element_Used;                                                                              // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:383
                    {                                                                                                                       // MakerGen.cs:384
                        base.Write(sDef);                                                                                                   // MakerGen.cs:385
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                  // MakerGen.cs:386
                        {                                                                                                                   // MakerGen.cs:387
                            Path = "CoverageEligibilityResponse.insurance.item.benefit",                                                    // MakerGen.cs:388
                            ElementId = "CoverageEligibilityResponse.insurance.item.benefit"                                                // MakerGen.cs:389
                        });                                                                                                                 // MakerGen.cs:390
                        Element_Type.Write(sDef);                                                                                           // MakerGen.cs:216
                        Element_Allowed.Write(sDef);                                                                                        // MakerGen.cs:216
                        Element_Used.Write(sDef);                                                                                           // MakerGen.cs:216
                    }                                                                                                                       // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
                    public Type_Benefit()                                                                                                   // MakerGen.cs:395
                    {                                                                                                                       // MakerGen.cs:396
                        {                                                                                                                   // MakerGen.cs:227
                            // 28. CoverageEligibilityResponse.insurance.item.benefit.type
                            this.Element_Type = new ElementDefinitionInfo                                                                   // MakerGen.cs:229
                            {                                                                                                               // MakerGen.cs:230
                                Name = "Element_Type",                                                                                      // MakerGen.cs:231
                                Path= "CoverageEligibilityResponse.insurance.item.benefit.type",                                            // MakerGen.cs:232
                                Id = "CoverageEligibilityResponse.insurance.item.benefit.type",                                             // MakerGen.cs:233
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
                            // 29. CoverageEligibilityResponse.insurance.item.benefit.allowed[x]
                            this.Element_Allowed = new ElementDefinitionInfo                                                                // MakerGen.cs:229
                            {                                                                                                               // MakerGen.cs:230
                                Name = "Element_Allowed",                                                                                   // MakerGen.cs:231
                                Path= "CoverageEligibilityResponse.insurance.item.benefit.allowed[x]",                                      // MakerGen.cs:232
                                Id = "CoverageEligibilityResponse.insurance.item.benefit.allowed[x]",                                       // MakerGen.cs:233
                                Min = 0,                                                                                                    // MakerGen.cs:234
                                Max = 1,                                                                                                    // MakerGen.cs:235
                                Types = new BaseType[]                                                                                      // MakerGen.cs:236
                                {                                                                                                           // MakerGen.cs:237
                                    new FhirKhit.Maker.Common.Primitive.Primitive_UnsignedInt                                               // MakerGen.cs:296
                                    {                                                                                                       // MakerGen.cs:297
                                    },                                                                                                      // MakerGen.cs:300
                                    new FhirKhit.Maker.Common.Primitive.Primitive_String                                                    // MakerGen.cs:296
                                    {                                                                                                       // MakerGen.cs:297
                                    },                                                                                                      // MakerGen.cs:300
                                    new FhirKhit.Maker.Common.Complex.Type_Money                                                            // MakerGen.cs:351
                                    {                                                                                                       // MakerGen.cs:352
                                    }                                                                                                       // MakerGen.cs:353
                                }                                                                                                           // MakerGen.cs:239
                            };                                                                                                              // MakerGen.cs:240
                        }                                                                                                                   // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:227
                            // 30. CoverageEligibilityResponse.insurance.item.benefit.used[x]
                            this.Element_Used = new ElementDefinitionInfo                                                                   // MakerGen.cs:229
                            {                                                                                                               // MakerGen.cs:230
                                Name = "Element_Used",                                                                                      // MakerGen.cs:231
                                Path= "CoverageEligibilityResponse.insurance.item.benefit.used[x]",                                         // MakerGen.cs:232
                                Id = "CoverageEligibilityResponse.insurance.item.benefit.used[x]",                                          // MakerGen.cs:233
                                Min = 0,                                                                                                    // MakerGen.cs:234
                                Max = 1,                                                                                                    // MakerGen.cs:235
                                Types = new BaseType[]                                                                                      // MakerGen.cs:236
                                {                                                                                                           // MakerGen.cs:237
                                    new FhirKhit.Maker.Common.Primitive.Primitive_UnsignedInt                                               // MakerGen.cs:296
                                    {                                                                                                       // MakerGen.cs:297
                                    },                                                                                                      // MakerGen.cs:300
                                    new FhirKhit.Maker.Common.Primitive.Primitive_String                                                    // MakerGen.cs:296
                                    {                                                                                                       // MakerGen.cs:297
                                    },                                                                                                      // MakerGen.cs:300
                                    new FhirKhit.Maker.Common.Complex.Type_Money                                                            // MakerGen.cs:351
                                    {                                                                                                       // MakerGen.cs:352
                                    }                                                                                                       // MakerGen.cs:353
                                }                                                                                                           // MakerGen.cs:239
                            };                                                                                                              // MakerGen.cs:240
                        }                                                                                                                   // MakerGen.cs:241
                    }                                                                                                                       // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:400
                // 17. CoverageEligibilityResponse.insurance.item.category
                public ElementDefinitionInfo Element_Category;                                                                              // MakerGen.cs:212
                // 18. CoverageEligibilityResponse.insurance.item.productOrService
                public ElementDefinitionInfo Element_ProductOrService;                                                                      // MakerGen.cs:212
                // 19. CoverageEligibilityResponse.insurance.item.modifier
                public ElementDefinitionInfo Element_Modifier;                                                                              // MakerGen.cs:212
                // 20. CoverageEligibilityResponse.insurance.item.provider
                public ElementDefinitionInfo Element_Provider;                                                                              // MakerGen.cs:212
                // 21. CoverageEligibilityResponse.insurance.item.excluded
                public ElementDefinitionInfo Element_Excluded;                                                                              // MakerGen.cs:212
                // 22. CoverageEligibilityResponse.insurance.item.name
                public ElementDefinitionInfo Element_Name;                                                                                  // MakerGen.cs:212
                // 23. CoverageEligibilityResponse.insurance.item.description
                public ElementDefinitionInfo Element_Description;                                                                           // MakerGen.cs:212
                // 24. CoverageEligibilityResponse.insurance.item.network
                public ElementDefinitionInfo Element_Network;                                                                               // MakerGen.cs:212
                // 25. CoverageEligibilityResponse.insurance.item.unit
                public ElementDefinitionInfo Element_Unit;                                                                                  // MakerGen.cs:212
                // 26. CoverageEligibilityResponse.insurance.item.term
                public ElementDefinitionInfo Element_Term;                                                                                  // MakerGen.cs:212
                // 27. CoverageEligibilityResponse.insurance.item.benefit
                public ElementDefinitionInfo Element_Benefit;                                                                               // MakerGen.cs:212
                // 31. CoverageEligibilityResponse.insurance.item.authorizationRequired
                public ElementDefinitionInfo Element_AuthorizationRequired;                                                                 // MakerGen.cs:212
                // 32. CoverageEligibilityResponse.insurance.item.authorizationSupporting
                public ElementDefinitionInfo Element_AuthorizationSupporting;                                                               // MakerGen.cs:212
                // 33. CoverageEligibilityResponse.insurance.item.authorizationUrl
                public ElementDefinitionInfo Element_AuthorizationUrl;                                                                      // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:383
                {                                                                                                                           // MakerGen.cs:384
                    base.Write(sDef);                                                                                                       // MakerGen.cs:385
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:386
                    {                                                                                                                       // MakerGen.cs:387
                        Path = "CoverageEligibilityResponse.insurance.item",                                                                // MakerGen.cs:388
                        ElementId = "CoverageEligibilityResponse.insurance.item"                                                            // MakerGen.cs:389
                    });                                                                                                                     // MakerGen.cs:390
                    Element_Category.Write(sDef);                                                                                           // MakerGen.cs:216
                    Element_ProductOrService.Write(sDef);                                                                                   // MakerGen.cs:216
                    Element_Modifier.Write(sDef);                                                                                           // MakerGen.cs:216
                    Element_Provider.Write(sDef);                                                                                           // MakerGen.cs:216
                    Element_Excluded.Write(sDef);                                                                                           // MakerGen.cs:216
                    Element_Name.Write(sDef);                                                                                               // MakerGen.cs:216
                    Element_Description.Write(sDef);                                                                                        // MakerGen.cs:216
                    Element_Network.Write(sDef);                                                                                            // MakerGen.cs:216
                    Element_Unit.Write(sDef);                                                                                               // MakerGen.cs:216
                    Element_Term.Write(sDef);                                                                                               // MakerGen.cs:216
                    Element_Benefit.Write(sDef);                                                                                            // MakerGen.cs:216
                    Element_AuthorizationRequired.Write(sDef);                                                                              // MakerGen.cs:216
                    Element_AuthorizationSupporting.Write(sDef);                                                                            // MakerGen.cs:216
                    Element_AuthorizationUrl.Write(sDef);                                                                                   // MakerGen.cs:216
                }                                                                                                                           // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
                public Type_Item()                                                                                                          // MakerGen.cs:395
                {                                                                                                                           // MakerGen.cs:396
                    {                                                                                                                       // MakerGen.cs:227
                        // 17. CoverageEligibilityResponse.insurance.item.category
                        this.Element_Category = new ElementDefinitionInfo                                                                   // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Category",                                                                                      // MakerGen.cs:231
                            Path= "CoverageEligibilityResponse.insurance.item.category",                                                    // MakerGen.cs:232
                            Id = "CoverageEligibilityResponse.insurance.item.category",                                                     // MakerGen.cs:233
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
                        // 18. CoverageEligibilityResponse.insurance.item.productOrService
                        this.Element_ProductOrService = new ElementDefinitionInfo                                                           // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_ProductOrService",                                                                              // MakerGen.cs:231
                            Path= "CoverageEligibilityResponse.insurance.item.productOrService",                                            // MakerGen.cs:232
                            Id = "CoverageEligibilityResponse.insurance.item.productOrService",                                             // MakerGen.cs:233
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
                        // 19. CoverageEligibilityResponse.insurance.item.modifier
                        this.Element_Modifier = new ElementDefinitionInfo                                                                   // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Modifier",                                                                                      // MakerGen.cs:231
                            Path= "CoverageEligibilityResponse.insurance.item.modifier",                                                    // MakerGen.cs:232
                            Id = "CoverageEligibilityResponse.insurance.item.modifier",                                                     // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = -1,                                                                                                       // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:311
                                {                                                                                                           // MakerGen.cs:312
                                }                                                                                                           // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:227
                        // 20. CoverageEligibilityResponse.insurance.item.provider
                        this.Element_Provider = new ElementDefinitionInfo                                                                   // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Provider",                                                                                      // MakerGen.cs:231
                            Path= "CoverageEligibilityResponse.insurance.item.provider",                                                    // MakerGen.cs:232
                            Id = "CoverageEligibilityResponse.insurance.item.provider",                                                     // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = 1,                                                                                                        // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Complex.Type_Reference                                                            // MakerGen.cs:339
                                {                                                                                                           // MakerGen.cs:340
                                    TargetProfile = new String[]                                                                            // MakerGen.cs:342
                                    {                                                                                                       // CodeEditorExtensions.cs:28
                                        "http://hl7.org/fhir/StructureDefinition/Practitioner",                                             // MakerGen.cs:342
                                        "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                                          // MakerGen.cs:342
                                    }                                                                                                       // CodeEditorExtensions.cs:34
                                }                                                                                                           // MakerGen.cs:343
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:227
                        // 21. CoverageEligibilityResponse.insurance.item.excluded
                        this.Element_Excluded = new ElementDefinitionInfo                                                                   // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Excluded",                                                                                      // MakerGen.cs:231
                            Path= "CoverageEligibilityResponse.insurance.item.excluded",                                                    // MakerGen.cs:232
                            Id = "CoverageEligibilityResponse.insurance.item.excluded",                                                     // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = 1,                                                                                                        // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                       // MakerGen.cs:296
                                {                                                                                                           // MakerGen.cs:297
                                }                                                                                                           // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:227
                        // 22. CoverageEligibilityResponse.insurance.item.name
                        this.Element_Name = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Name",                                                                                          // MakerGen.cs:231
                            Path= "CoverageEligibilityResponse.insurance.item.name",                                                        // MakerGen.cs:232
                            Id = "CoverageEligibilityResponse.insurance.item.name",                                                         // MakerGen.cs:233
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
                        // 23. CoverageEligibilityResponse.insurance.item.description
                        this.Element_Description = new ElementDefinitionInfo                                                                // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Description",                                                                                   // MakerGen.cs:231
                            Path= "CoverageEligibilityResponse.insurance.item.description",                                                 // MakerGen.cs:232
                            Id = "CoverageEligibilityResponse.insurance.item.description",                                                  // MakerGen.cs:233
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
                        // 24. CoverageEligibilityResponse.insurance.item.network
                        this.Element_Network = new ElementDefinitionInfo                                                                    // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Network",                                                                                       // MakerGen.cs:231
                            Path= "CoverageEligibilityResponse.insurance.item.network",                                                     // MakerGen.cs:232
                            Id = "CoverageEligibilityResponse.insurance.item.network",                                                      // MakerGen.cs:233
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
                        // 25. CoverageEligibilityResponse.insurance.item.unit
                        this.Element_Unit = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Unit",                                                                                          // MakerGen.cs:231
                            Path= "CoverageEligibilityResponse.insurance.item.unit",                                                        // MakerGen.cs:232
                            Id = "CoverageEligibilityResponse.insurance.item.unit",                                                         // MakerGen.cs:233
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
                        // 26. CoverageEligibilityResponse.insurance.item.term
                        this.Element_Term = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Term",                                                                                          // MakerGen.cs:231
                            Path= "CoverageEligibilityResponse.insurance.item.term",                                                        // MakerGen.cs:232
                            Id = "CoverageEligibilityResponse.insurance.item.term",                                                         // MakerGen.cs:233
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
                        // 27. CoverageEligibilityResponse.insurance.item.benefit
                        this.Element_Benefit = new ElementDefinitionInfo                                                                    // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Benefit",                                                                                       // MakerGen.cs:231
                            Path= "CoverageEligibilityResponse.insurance.item.benefit",                                                     // MakerGen.cs:232
                            Id = "CoverageEligibilityResponse.insurance.item.benefit",                                                      // MakerGen.cs:233
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
                    {                                                                                                                       // MakerGen.cs:227
                        // 31. CoverageEligibilityResponse.insurance.item.authorizationRequired
                        this.Element_AuthorizationRequired = new ElementDefinitionInfo                                                      // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_AuthorizationRequired",                                                                         // MakerGen.cs:231
                            Path= "CoverageEligibilityResponse.insurance.item.authorizationRequired",                                       // MakerGen.cs:232
                            Id = "CoverageEligibilityResponse.insurance.item.authorizationRequired",                                        // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = 1,                                                                                                        // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                       // MakerGen.cs:296
                                {                                                                                                           // MakerGen.cs:297
                                }                                                                                                           // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:227
                        // 32. CoverageEligibilityResponse.insurance.item.authorizationSupporting
                        this.Element_AuthorizationSupporting = new ElementDefinitionInfo                                                    // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_AuthorizationSupporting",                                                                       // MakerGen.cs:231
                            Path= "CoverageEligibilityResponse.insurance.item.authorizationSupporting",                                     // MakerGen.cs:232
                            Id = "CoverageEligibilityResponse.insurance.item.authorizationSupporting",                                      // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = -1,                                                                                                       // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:311
                                {                                                                                                           // MakerGen.cs:312
                                }                                                                                                           // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:227
                        // 33. CoverageEligibilityResponse.insurance.item.authorizationUrl
                        this.Element_AuthorizationUrl = new ElementDefinitionInfo                                                           // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_AuthorizationUrl",                                                                              // MakerGen.cs:231
                            Path= "CoverageEligibilityResponse.insurance.item.authorizationUrl",                                            // MakerGen.cs:232
                            Id = "CoverageEligibilityResponse.insurance.item.authorizationUrl",                                             // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = 1,                                                                                                        // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Primitive.Primitive_Uri                                                           // MakerGen.cs:296
                                {                                                                                                           // MakerGen.cs:297
                                }                                                                                                           // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                }                                                                                                                           // MakerGen.cs:398
            }                                                                                                                               // MakerGen.cs:400
            // 13. CoverageEligibilityResponse.insurance.coverage
            public ElementDefinitionInfo Element_Coverage;                                                                                  // MakerGen.cs:212
            // 14. CoverageEligibilityResponse.insurance.inforce
            public ElementDefinitionInfo Element_Inforce;                                                                                   // MakerGen.cs:212
            // 15. CoverageEligibilityResponse.insurance.benefitPeriod
            public ElementDefinitionInfo Element_BenefitPeriod;                                                                             // MakerGen.cs:212
            // 16. CoverageEligibilityResponse.insurance.item
            public ElementDefinitionInfo Element_Item;                                                                                      // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "CoverageEligibilityResponse.insurance",                                                                         // MakerGen.cs:388
                    ElementId = "CoverageEligibilityResponse.insurance"                                                                     // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Coverage.Write(sDef);                                                                                               // MakerGen.cs:216
                Element_Inforce.Write(sDef);                                                                                                // MakerGen.cs:216
                Element_BenefitPeriod.Write(sDef);                                                                                          // MakerGen.cs:216
                Element_Item.Write(sDef);                                                                                                   // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_Insurance()                                                                                                         // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 13. CoverageEligibilityResponse.insurance.coverage
                    this.Element_Coverage = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Coverage",                                                                                          // MakerGen.cs:231
                        Path= "CoverageEligibilityResponse.insurance.coverage",                                                             // MakerGen.cs:232
                        Id = "CoverageEligibilityResponse.insurance.coverage",                                                              // MakerGen.cs:233
                        Min = 1,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:339
                            {                                                                                                               // MakerGen.cs:340
                                TargetProfile = new String[]                                                                                // MakerGen.cs:342
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Coverage"                                                      // MakerGen.cs:342
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:343
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 14. CoverageEligibilityResponse.insurance.inforce
                    this.Element_Inforce = new ElementDefinitionInfo                                                                        // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Inforce",                                                                                           // MakerGen.cs:231
                        Path= "CoverageEligibilityResponse.insurance.inforce",                                                              // MakerGen.cs:232
                        Id = "CoverageEligibilityResponse.insurance.inforce",                                                               // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                           // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 15. CoverageEligibilityResponse.insurance.benefitPeriod
                    this.Element_BenefitPeriod = new ElementDefinitionInfo                                                                  // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_BenefitPeriod",                                                                                     // MakerGen.cs:231
                        Path= "CoverageEligibilityResponse.insurance.benefitPeriod",                                                        // MakerGen.cs:232
                        Id = "CoverageEligibilityResponse.insurance.benefitPeriod",                                                         // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Period                                                                   // MakerGen.cs:351
                            {                                                                                                               // MakerGen.cs:352
                            }                                                                                                               // MakerGen.cs:353
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 16. CoverageEligibilityResponse.insurance.item
                    this.Element_Item = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Item",                                                                                              // MakerGen.cs:231
                        Path= "CoverageEligibilityResponse.insurance.item",                                                                 // MakerGen.cs:232
                        Id = "CoverageEligibilityResponse.insurance.item",                                                                  // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new Type_Item                                                                                                   // MakerGen.cs:255
                            {                                                                                                               // MakerGen.cs:256
                            }                                                                                                               // MakerGen.cs:257
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 36. CoverageEligibilityResponse.error
        public class Type_Error : FhirKhit.Maker.Common.Complex.ComplexBase                                                                 // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 37. CoverageEligibilityResponse.error.code
            public ElementDefinitionInfo Element_Code;                                                                                      // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "CoverageEligibilityResponse.error",                                                                             // MakerGen.cs:388
                    ElementId = "CoverageEligibilityResponse.error"                                                                         // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Code.Write(sDef);                                                                                                   // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_Error()                                                                                                             // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 37. CoverageEligibilityResponse.error.code
                    this.Element_Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Code",                                                                                              // MakerGen.cs:231
                        Path= "CoverageEligibilityResponse.error.code",                                                                     // MakerGen.cs:232
                        Id = "CoverageEligibilityResponse.error.code",                                                                      // MakerGen.cs:233
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
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 1. CoverageEligibilityResponse.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:212
        // 2. CoverageEligibilityResponse.status
        public ElementDefinitionInfo Element_Status;                                                                                        // MakerGen.cs:212
        // 3. CoverageEligibilityResponse.purpose
        public ElementDefinitionInfo Element_Purpose;                                                                                       // MakerGen.cs:212
        // 4. CoverageEligibilityResponse.patient
        public ElementDefinitionInfo Element_Patient;                                                                                       // MakerGen.cs:212
        // 5. CoverageEligibilityResponse.serviced[x]
        public ElementDefinitionInfo Element_Serviced;                                                                                      // MakerGen.cs:212
        // 6. CoverageEligibilityResponse.created
        public ElementDefinitionInfo Element_Created;                                                                                       // MakerGen.cs:212
        // 7. CoverageEligibilityResponse.requestor
        public ElementDefinitionInfo Element_Requestor;                                                                                     // MakerGen.cs:212
        // 8. CoverageEligibilityResponse.request
        public ElementDefinitionInfo Element_Request;                                                                                       // MakerGen.cs:212
        // 9. CoverageEligibilityResponse.outcome
        public ElementDefinitionInfo Element_Outcome;                                                                                       // MakerGen.cs:212
        // 10. CoverageEligibilityResponse.disposition
        public ElementDefinitionInfo Element_Disposition;                                                                                   // MakerGen.cs:212
        // 11. CoverageEligibilityResponse.insurer
        public ElementDefinitionInfo Element_Insurer;                                                                                       // MakerGen.cs:212
        // 12. CoverageEligibilityResponse.insurance
        public ElementDefinitionInfo Element_Insurance;                                                                                     // MakerGen.cs:212
        // 34. CoverageEligibilityResponse.preAuthRef
        public ElementDefinitionInfo Element_PreAuthRef;                                                                                    // MakerGen.cs:212
        // 35. CoverageEligibilityResponse.form
        public ElementDefinitionInfo Element_Form;                                                                                          // MakerGen.cs:212
        // 36. CoverageEligibilityResponse.error
        public ElementDefinitionInfo Element_Error;                                                                                         // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            base.Write(sDef);                                                                                                               // MakerGen.cs:385
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:386
            {                                                                                                                               // MakerGen.cs:387
                Path = "CoverageEligibilityResponse",                                                                                       // MakerGen.cs:388
                ElementId = "CoverageEligibilityResponse"                                                                                   // MakerGen.cs:389
            });                                                                                                                             // MakerGen.cs:390
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_Status.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_Purpose.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_Patient.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_Serviced.Write(sDef);                                                                                                   // MakerGen.cs:216
            Element_Created.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_Requestor.Write(sDef);                                                                                                  // MakerGen.cs:216
            Element_Request.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_Outcome.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_Disposition.Write(sDef);                                                                                                // MakerGen.cs:216
            Element_Insurer.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_Insurance.Write(sDef);                                                                                                  // MakerGen.cs:216
            Element_PreAuthRef.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_Form.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_Error.Write(sDef);                                                                                                      // MakerGen.cs:216
        }                                                                                                                                   // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
        public Resource_CoverageEligibilityResponse()                                                                                       // MakerGen.cs:395
        {                                                                                                                                   // MakerGen.cs:396
            {                                                                                                                               // MakerGen.cs:227
                // 1. CoverageEligibilityResponse.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:231
                    Path= "CoverageEligibilityResponse.identifier",                                                                         // MakerGen.cs:232
                    Id = "CoverageEligibilityResponse.identifier",                                                                          // MakerGen.cs:233
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
                // 2. CoverageEligibilityResponse.status
                this.Element_Status = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Status",                                                                                                // MakerGen.cs:231
                    Path= "CoverageEligibilityResponse.status",                                                                             // MakerGen.cs:232
                    Id = "CoverageEligibilityResponse.status",                                                                              // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
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
                // 3. CoverageEligibilityResponse.purpose
                this.Element_Purpose = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Purpose",                                                                                               // MakerGen.cs:231
                    Path= "CoverageEligibilityResponse.purpose",                                                                            // MakerGen.cs:232
                    Id = "CoverageEligibilityResponse.purpose",                                                                             // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 4. CoverageEligibilityResponse.patient
                this.Element_Patient = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Patient",                                                                                               // MakerGen.cs:231
                    Path= "CoverageEligibilityResponse.patient",                                                                            // MakerGen.cs:232
                    Id = "CoverageEligibilityResponse.patient",                                                                             // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Patient"                                                           // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 5. CoverageEligibilityResponse.serviced[x]
                this.Element_Serviced = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Serviced",                                                                                              // MakerGen.cs:231
                    Path= "CoverageEligibilityResponse.serviced[x]",                                                                        // MakerGen.cs:232
                    Id = "CoverageEligibilityResponse.serviced[x]",                                                                         // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Date                                                                  // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        },                                                                                                                  // MakerGen.cs:300
                        new FhirKhit.Maker.Common.Complex.Type_Period                                                                       // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 6. CoverageEligibilityResponse.created
                this.Element_Created = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Created",                                                                                               // MakerGen.cs:231
                    Path= "CoverageEligibilityResponse.created",                                                                            // MakerGen.cs:232
                    Id = "CoverageEligibilityResponse.created",                                                                             // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                              // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 7. CoverageEligibilityResponse.requestor
                this.Element_Requestor = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Requestor",                                                                                             // MakerGen.cs:231
                    Path= "CoverageEligibilityResponse.requestor",                                                                          // MakerGen.cs:232
                    Id = "CoverageEligibilityResponse.requestor",                                                                           // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                     // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                                 // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Organization"                                                      // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 8. CoverageEligibilityResponse.request
                this.Element_Request = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Request",                                                                                               // MakerGen.cs:231
                    Path= "CoverageEligibilityResponse.request",                                                                            // MakerGen.cs:232
                    Id = "CoverageEligibilityResponse.request",                                                                             // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/CoverageEligibilityRequest"                                        // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 9. CoverageEligibilityResponse.outcome
                this.Element_Outcome = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Outcome",                                                                                               // MakerGen.cs:231
                    Path= "CoverageEligibilityResponse.outcome",                                                                            // MakerGen.cs:232
                    Id = "CoverageEligibilityResponse.outcome",                                                                             // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
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
                // 10. CoverageEligibilityResponse.disposition
                this.Element_Disposition = new ElementDefinitionInfo                                                                        // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Disposition",                                                                                           // MakerGen.cs:231
                    Path= "CoverageEligibilityResponse.disposition",                                                                        // MakerGen.cs:232
                    Id = "CoverageEligibilityResponse.disposition",                                                                         // MakerGen.cs:233
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
                // 11. CoverageEligibilityResponse.insurer
                this.Element_Insurer = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Insurer",                                                                                               // MakerGen.cs:231
                    Path= "CoverageEligibilityResponse.insurer",                                                                            // MakerGen.cs:232
                    Id = "CoverageEligibilityResponse.insurer",                                                                             // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
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
                // 12. CoverageEligibilityResponse.insurance
                this.Element_Insurance = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Insurance",                                                                                             // MakerGen.cs:231
                    Path= "CoverageEligibilityResponse.insurance",                                                                          // MakerGen.cs:232
                    Id = "CoverageEligibilityResponse.insurance",                                                                           // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_Insurance                                                                                                  // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 34. CoverageEligibilityResponse.preAuthRef
                this.Element_PreAuthRef = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_PreAuthRef",                                                                                            // MakerGen.cs:231
                    Path= "CoverageEligibilityResponse.preAuthRef",                                                                         // MakerGen.cs:232
                    Id = "CoverageEligibilityResponse.preAuthRef",                                                                          // MakerGen.cs:233
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
                // 35. CoverageEligibilityResponse.form
                this.Element_Form = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Form",                                                                                                  // MakerGen.cs:231
                    Path= "CoverageEligibilityResponse.form",                                                                               // MakerGen.cs:232
                    Id = "CoverageEligibilityResponse.form",                                                                                // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 36. CoverageEligibilityResponse.error
                this.Element_Error = new ElementDefinitionInfo                                                                              // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Error",                                                                                                 // MakerGen.cs:231
                    Path= "CoverageEligibilityResponse.error",                                                                              // MakerGen.cs:232
                    Id = "CoverageEligibilityResponse.error",                                                                               // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_Error                                                                                                      // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            this.Name = "CoverageEligibilityResponse";                                                                                      // MakerGen.cs:458
            this.Uri = "http://hl7.org/fhir/StructureDefinition/CoverageEligibilityResponse";                                               // MakerGen.cs:459
        }                                                                                                                                   // MakerGen.cs:398
    }                                                                                                                                       // MakerGen.cs:400
}                                                                                                                                           // MakerGen.cs:445
