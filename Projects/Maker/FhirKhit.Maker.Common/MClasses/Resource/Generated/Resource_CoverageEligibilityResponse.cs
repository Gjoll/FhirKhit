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
    #endregion
    /// <summary>
    /// Fhir resource 'CoverageEligibilityResponse'
    /// </summary>
    // 0. CoverageEligibilityResponse
    public partial class Resource_CoverageEligibilityResponse : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 12. CoverageEligibilityResponse.insurance
        public partial class Type_Insurance : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 16. CoverageEligibilityResponse.insurance.item
            public partial class Type_Item : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 27. CoverageEligibilityResponse.insurance.item.benefit
                public partial class Type_Benefit : FhirKhit.Maker.Common.Complex.ComplexBase
                {
                    // 28. CoverageEligibilityResponse.insurance.item.benefit.type
                    public ElementDefinitionInfo Element_Type;
                    // 29. CoverageEligibilityResponse.insurance.item.benefit.allowed[x]
                    public ElementDefinitionInfo Element_Allowed;
                    // 30. CoverageEligibilityResponse.insurance.item.benefit.used[x]
                    public ElementDefinitionInfo Element_Used;
                    
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                    {
                        base.Write(sDef);
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                        {
                            Path = "CoverageEligibilityResponse.insurance.item.benefit",
                            ElementId = "CoverageEligibilityResponse.insurance.item.benefit"
                        });
                        Element_Type.Write(sDef);
                        Element_Allowed.Write(sDef);
                        Element_Used.Write(sDef);
                    }
                    
                    public Type_Benefit()
                    {
                        {
                            // 28. CoverageEligibilityResponse.insurance.item.benefit.type
                            this.Element_Type = new ElementDefinitionInfo
                            {
                                Name = "Element_Type",
                                Path= "CoverageEligibilityResponse.insurance.item.benefit.type",
                                Id = "CoverageEligibilityResponse.insurance.item.benefit.type",
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
                            // 29. CoverageEligibilityResponse.insurance.item.benefit.allowed[x]
                            this.Element_Allowed = new ElementDefinitionInfo
                            {
                                Name = "Element_Allowed",
                                Path= "CoverageEligibilityResponse.insurance.item.benefit.allowed[x]",
                                Id = "CoverageEligibilityResponse.insurance.item.benefit.allowed[x]",
                                Min = 0,
                                Max = 1,
                                Types = new BaseType[]
                                {
                                    new FhirKhit.Maker.Common.Primitive.Primitive_UnsignedInt
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Primitive.Primitive_String
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Complex.Type_Money
                                    {
                                    }
                                }
                            };
                        }
                        {
                            // 30. CoverageEligibilityResponse.insurance.item.benefit.used[x]
                            this.Element_Used = new ElementDefinitionInfo
                            {
                                Name = "Element_Used",
                                Path= "CoverageEligibilityResponse.insurance.item.benefit.used[x]",
                                Id = "CoverageEligibilityResponse.insurance.item.benefit.used[x]",
                                Min = 0,
                                Max = 1,
                                Types = new BaseType[]
                                {
                                    new FhirKhit.Maker.Common.Primitive.Primitive_UnsignedInt
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Primitive.Primitive_String
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Complex.Type_Money
                                    {
                                    }
                                }
                            };
                        }
                    }
                }
                // 17. CoverageEligibilityResponse.insurance.item.category
                public ElementDefinitionInfo Element_Category;
                // 18. CoverageEligibilityResponse.insurance.item.productOrService
                public ElementDefinitionInfo Element_ProductOrService;
                // 19. CoverageEligibilityResponse.insurance.item.modifier
                public ElementDefinitionInfo Element_Modifier;
                // 20. CoverageEligibilityResponse.insurance.item.provider
                public ElementDefinitionInfo Element_Provider;
                // 21. CoverageEligibilityResponse.insurance.item.excluded
                public ElementDefinitionInfo Element_Excluded;
                // 22. CoverageEligibilityResponse.insurance.item.name
                public ElementDefinitionInfo Element_Name;
                // 23. CoverageEligibilityResponse.insurance.item.description
                public ElementDefinitionInfo Element_Description;
                // 24. CoverageEligibilityResponse.insurance.item.network
                public ElementDefinitionInfo Element_Network;
                // 25. CoverageEligibilityResponse.insurance.item.unit
                public ElementDefinitionInfo Element_Unit;
                // 26. CoverageEligibilityResponse.insurance.item.term
                public ElementDefinitionInfo Element_Term;
                // 27. CoverageEligibilityResponse.insurance.item.benefit
                public ElementDefinitionInfo Element_Benefit;
                // 31. CoverageEligibilityResponse.insurance.item.authorizationRequired
                public ElementDefinitionInfo Element_AuthorizationRequired;
                // 32. CoverageEligibilityResponse.insurance.item.authorizationSupporting
                public ElementDefinitionInfo Element_AuthorizationSupporting;
                // 33. CoverageEligibilityResponse.insurance.item.authorizationUrl
                public ElementDefinitionInfo Element_AuthorizationUrl;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "CoverageEligibilityResponse.insurance.item",
                        ElementId = "CoverageEligibilityResponse.insurance.item"
                    });
                    Element_Category.Write(sDef);
                    Element_ProductOrService.Write(sDef);
                    Element_Modifier.Write(sDef);
                    Element_Provider.Write(sDef);
                    Element_Excluded.Write(sDef);
                    Element_Name.Write(sDef);
                    Element_Description.Write(sDef);
                    Element_Network.Write(sDef);
                    Element_Unit.Write(sDef);
                    Element_Term.Write(sDef);
                    Element_Benefit.Write(sDef);
                    Element_AuthorizationRequired.Write(sDef);
                    Element_AuthorizationSupporting.Write(sDef);
                    Element_AuthorizationUrl.Write(sDef);
                }
                
                public Type_Item()
                {
                    {
                        // 17. CoverageEligibilityResponse.insurance.item.category
                        this.Element_Category = new ElementDefinitionInfo
                        {
                            Name = "Element_Category",
                            Path= "CoverageEligibilityResponse.insurance.item.category",
                            Id = "CoverageEligibilityResponse.insurance.item.category",
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
                        // 18. CoverageEligibilityResponse.insurance.item.productOrService
                        this.Element_ProductOrService = new ElementDefinitionInfo
                        {
                            Name = "Element_ProductOrService",
                            Path= "CoverageEligibilityResponse.insurance.item.productOrService",
                            Id = "CoverageEligibilityResponse.insurance.item.productOrService",
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
                        // 19. CoverageEligibilityResponse.insurance.item.modifier
                        this.Element_Modifier = new ElementDefinitionInfo
                        {
                            Name = "Element_Modifier",
                            Path= "CoverageEligibilityResponse.insurance.item.modifier",
                            Id = "CoverageEligibilityResponse.insurance.item.modifier",
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
                        // 20. CoverageEligibilityResponse.insurance.item.provider
                        this.Element_Provider = new ElementDefinitionInfo
                        {
                            Name = "Element_Provider",
                            Path= "CoverageEligibilityResponse.insurance.item.provider",
                            Id = "CoverageEligibilityResponse.insurance.item.provider",
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
                        // 21. CoverageEligibilityResponse.insurance.item.excluded
                        this.Element_Excluded = new ElementDefinitionInfo
                        {
                            Name = "Element_Excluded",
                            Path= "CoverageEligibilityResponse.insurance.item.excluded",
                            Id = "CoverageEligibilityResponse.insurance.item.excluded",
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
                        // 22. CoverageEligibilityResponse.insurance.item.name
                        this.Element_Name = new ElementDefinitionInfo
                        {
                            Name = "Element_Name",
                            Path= "CoverageEligibilityResponse.insurance.item.name",
                            Id = "CoverageEligibilityResponse.insurance.item.name",
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
                        // 23. CoverageEligibilityResponse.insurance.item.description
                        this.Element_Description = new ElementDefinitionInfo
                        {
                            Name = "Element_Description",
                            Path= "CoverageEligibilityResponse.insurance.item.description",
                            Id = "CoverageEligibilityResponse.insurance.item.description",
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
                        // 24. CoverageEligibilityResponse.insurance.item.network
                        this.Element_Network = new ElementDefinitionInfo
                        {
                            Name = "Element_Network",
                            Path= "CoverageEligibilityResponse.insurance.item.network",
                            Id = "CoverageEligibilityResponse.insurance.item.network",
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
                        // 25. CoverageEligibilityResponse.insurance.item.unit
                        this.Element_Unit = new ElementDefinitionInfo
                        {
                            Name = "Element_Unit",
                            Path= "CoverageEligibilityResponse.insurance.item.unit",
                            Id = "CoverageEligibilityResponse.insurance.item.unit",
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
                        // 26. CoverageEligibilityResponse.insurance.item.term
                        this.Element_Term = new ElementDefinitionInfo
                        {
                            Name = "Element_Term",
                            Path= "CoverageEligibilityResponse.insurance.item.term",
                            Id = "CoverageEligibilityResponse.insurance.item.term",
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
                        // 27. CoverageEligibilityResponse.insurance.item.benefit
                        this.Element_Benefit = new ElementDefinitionInfo
                        {
                            Name = "Element_Benefit",
                            Path= "CoverageEligibilityResponse.insurance.item.benefit",
                            Id = "CoverageEligibilityResponse.insurance.item.benefit",
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
                    {
                        // 31. CoverageEligibilityResponse.insurance.item.authorizationRequired
                        this.Element_AuthorizationRequired = new ElementDefinitionInfo
                        {
                            Name = "Element_AuthorizationRequired",
                            Path= "CoverageEligibilityResponse.insurance.item.authorizationRequired",
                            Id = "CoverageEligibilityResponse.insurance.item.authorizationRequired",
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
                        // 32. CoverageEligibilityResponse.insurance.item.authorizationSupporting
                        this.Element_AuthorizationSupporting = new ElementDefinitionInfo
                        {
                            Name = "Element_AuthorizationSupporting",
                            Path= "CoverageEligibilityResponse.insurance.item.authorizationSupporting",
                            Id = "CoverageEligibilityResponse.insurance.item.authorizationSupporting",
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
                        // 33. CoverageEligibilityResponse.insurance.item.authorizationUrl
                        this.Element_AuthorizationUrl = new ElementDefinitionInfo
                        {
                            Name = "Element_AuthorizationUrl",
                            Path= "CoverageEligibilityResponse.insurance.item.authorizationUrl",
                            Id = "CoverageEligibilityResponse.insurance.item.authorizationUrl",
                            Min = 0,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_Uri
                                {
                                }
                            }
                        };
                    }
                }
            }
            // 13. CoverageEligibilityResponse.insurance.coverage
            public ElementDefinitionInfo Element_Coverage;
            // 14. CoverageEligibilityResponse.insurance.inforce
            public ElementDefinitionInfo Element_Inforce;
            // 15. CoverageEligibilityResponse.insurance.benefitPeriod
            public ElementDefinitionInfo Element_BenefitPeriod;
            // 16. CoverageEligibilityResponse.insurance.item
            public ElementDefinitionInfo Element_Item;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "CoverageEligibilityResponse.insurance",
                    ElementId = "CoverageEligibilityResponse.insurance"
                });
                Element_Coverage.Write(sDef);
                Element_Inforce.Write(sDef);
                Element_BenefitPeriod.Write(sDef);
                Element_Item.Write(sDef);
            }
            
            public Type_Insurance()
            {
                {
                    // 13. CoverageEligibilityResponse.insurance.coverage
                    this.Element_Coverage = new ElementDefinitionInfo
                    {
                        Name = "Element_Coverage",
                        Path= "CoverageEligibilityResponse.insurance.coverage",
                        Id = "CoverageEligibilityResponse.insurance.coverage",
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
                    // 14. CoverageEligibilityResponse.insurance.inforce
                    this.Element_Inforce = new ElementDefinitionInfo
                    {
                        Name = "Element_Inforce",
                        Path= "CoverageEligibilityResponse.insurance.inforce",
                        Id = "CoverageEligibilityResponse.insurance.inforce",
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
                    // 15. CoverageEligibilityResponse.insurance.benefitPeriod
                    this.Element_BenefitPeriod = new ElementDefinitionInfo
                    {
                        Name = "Element_BenefitPeriod",
                        Path= "CoverageEligibilityResponse.insurance.benefitPeriod",
                        Id = "CoverageEligibilityResponse.insurance.benefitPeriod",
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
                    // 16. CoverageEligibilityResponse.insurance.item
                    this.Element_Item = new ElementDefinitionInfo
                    {
                        Name = "Element_Item",
                        Path= "CoverageEligibilityResponse.insurance.item",
                        Id = "CoverageEligibilityResponse.insurance.item",
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
            }
        }
        // 36. CoverageEligibilityResponse.error
        public partial class Type_Error : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 37. CoverageEligibilityResponse.error.code
            public ElementDefinitionInfo Element_Code;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "CoverageEligibilityResponse.error",
                    ElementId = "CoverageEligibilityResponse.error"
                });
                Element_Code.Write(sDef);
            }
            
            public Type_Error()
            {
                {
                    // 37. CoverageEligibilityResponse.error.code
                    this.Element_Code = new ElementDefinitionInfo
                    {
                        Name = "Element_Code",
                        Path= "CoverageEligibilityResponse.error.code",
                        Id = "CoverageEligibilityResponse.error.code",
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
            }
        }
        // 1. CoverageEligibilityResponse.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. CoverageEligibilityResponse.status
        public ElementDefinitionInfo Element_Status;
        // 3. CoverageEligibilityResponse.purpose
        public ElementDefinitionInfo Element_Purpose;
        // 4. CoverageEligibilityResponse.patient
        public ElementDefinitionInfo Element_Patient;
        // 5. CoverageEligibilityResponse.serviced[x]
        public ElementDefinitionInfo Element_Serviced;
        // 6. CoverageEligibilityResponse.created
        public ElementDefinitionInfo Element_Created;
        // 7. CoverageEligibilityResponse.requestor
        public ElementDefinitionInfo Element_Requestor;
        // 8. CoverageEligibilityResponse.request
        public ElementDefinitionInfo Element_Request;
        // 9. CoverageEligibilityResponse.outcome
        public ElementDefinitionInfo Element_Outcome;
        // 10. CoverageEligibilityResponse.disposition
        public ElementDefinitionInfo Element_Disposition;
        // 11. CoverageEligibilityResponse.insurer
        public ElementDefinitionInfo Element_Insurer;
        // 12. CoverageEligibilityResponse.insurance
        public ElementDefinitionInfo Element_Insurance;
        // 34. CoverageEligibilityResponse.preAuthRef
        public ElementDefinitionInfo Element_PreAuthRef;
        // 35. CoverageEligibilityResponse.form
        public ElementDefinitionInfo Element_Form;
        // 36. CoverageEligibilityResponse.error
        public ElementDefinitionInfo Element_Error;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "CoverageEligibilityResponse",
                ElementId = "CoverageEligibilityResponse"
            });
            Element_Identifier.Write(sDef);
            Element_Status.Write(sDef);
            Element_Purpose.Write(sDef);
            Element_Patient.Write(sDef);
            Element_Serviced.Write(sDef);
            Element_Created.Write(sDef);
            Element_Requestor.Write(sDef);
            Element_Request.Write(sDef);
            Element_Outcome.Write(sDef);
            Element_Disposition.Write(sDef);
            Element_Insurer.Write(sDef);
            Element_Insurance.Write(sDef);
            Element_PreAuthRef.Write(sDef);
            Element_Form.Write(sDef);
            Element_Error.Write(sDef);
        }
        
        public Resource_CoverageEligibilityResponse()
        {
            {
                // 1. CoverageEligibilityResponse.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "CoverageEligibilityResponse.identifier",
                    Id = "CoverageEligibilityResponse.identifier",
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
                // 2. CoverageEligibilityResponse.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "CoverageEligibilityResponse.status",
                    Id = "CoverageEligibilityResponse.status",
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
                // 3. CoverageEligibilityResponse.purpose
                this.Element_Purpose = new ElementDefinitionInfo
                {
                    Name = "Element_Purpose",
                    Path= "CoverageEligibilityResponse.purpose",
                    Id = "CoverageEligibilityResponse.purpose",
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
                // 4. CoverageEligibilityResponse.patient
                this.Element_Patient = new ElementDefinitionInfo
                {
                    Name = "Element_Patient",
                    Path= "CoverageEligibilityResponse.patient",
                    Id = "CoverageEligibilityResponse.patient",
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
                // 5. CoverageEligibilityResponse.serviced[x]
                this.Element_Serviced = new ElementDefinitionInfo
                {
                    Name = "Element_Serviced",
                    Path= "CoverageEligibilityResponse.serviced[x]",
                    Id = "CoverageEligibilityResponse.serviced[x]",
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
                // 6. CoverageEligibilityResponse.created
                this.Element_Created = new ElementDefinitionInfo
                {
                    Name = "Element_Created",
                    Path= "CoverageEligibilityResponse.created",
                    Id = "CoverageEligibilityResponse.created",
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
                // 7. CoverageEligibilityResponse.requestor
                this.Element_Requestor = new ElementDefinitionInfo
                {
                    Name = "Element_Requestor",
                    Path= "CoverageEligibilityResponse.requestor",
                    Id = "CoverageEligibilityResponse.requestor",
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
                // 8. CoverageEligibilityResponse.request
                this.Element_Request = new ElementDefinitionInfo
                {
                    Name = "Element_Request",
                    Path= "CoverageEligibilityResponse.request",
                    Id = "CoverageEligibilityResponse.request",
                    Min = 1,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/CoverageEligibilityRequest"
                            }
                        }
                    }
                };
            }
            {
                // 9. CoverageEligibilityResponse.outcome
                this.Element_Outcome = new ElementDefinitionInfo
                {
                    Name = "Element_Outcome",
                    Path= "CoverageEligibilityResponse.outcome",
                    Id = "CoverageEligibilityResponse.outcome",
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
                // 10. CoverageEligibilityResponse.disposition
                this.Element_Disposition = new ElementDefinitionInfo
                {
                    Name = "Element_Disposition",
                    Path= "CoverageEligibilityResponse.disposition",
                    Id = "CoverageEligibilityResponse.disposition",
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
                // 11. CoverageEligibilityResponse.insurer
                this.Element_Insurer = new ElementDefinitionInfo
                {
                    Name = "Element_Insurer",
                    Path= "CoverageEligibilityResponse.insurer",
                    Id = "CoverageEligibilityResponse.insurer",
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
                // 12. CoverageEligibilityResponse.insurance
                this.Element_Insurance = new ElementDefinitionInfo
                {
                    Name = "Element_Insurance",
                    Path= "CoverageEligibilityResponse.insurance",
                    Id = "CoverageEligibilityResponse.insurance",
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
                // 34. CoverageEligibilityResponse.preAuthRef
                this.Element_PreAuthRef = new ElementDefinitionInfo
                {
                    Name = "Element_PreAuthRef",
                    Path= "CoverageEligibilityResponse.preAuthRef",
                    Id = "CoverageEligibilityResponse.preAuthRef",
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
                // 35. CoverageEligibilityResponse.form
                this.Element_Form = new ElementDefinitionInfo
                {
                    Name = "Element_Form",
                    Path= "CoverageEligibilityResponse.form",
                    Id = "CoverageEligibilityResponse.form",
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
                // 36. CoverageEligibilityResponse.error
                this.Element_Error = new ElementDefinitionInfo
                {
                    Name = "Element_Error",
                    Path= "CoverageEligibilityResponse.error",
                    Id = "CoverageEligibilityResponse.error",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Error
                        {
                        }
                    }
                };
            }
            this.Name = "CoverageEligibilityResponse";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/CoverageEligibilityResponse";
        }
    }
}
