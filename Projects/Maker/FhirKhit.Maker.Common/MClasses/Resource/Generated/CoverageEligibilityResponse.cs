using System;                                                                                                                               // MakerGen.cs:451
using System.Diagnostics;                                                                                                                   // MakerGen.cs:452
using System.IO;                                                                                                                            // MakerGen.cs:453
using System.Linq;                                                                                                                          // MakerGen.cs:454
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:455
                                                                                                                                            // MakerGen.cs:456
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:457
{                                                                                                                                           // MakerGen.cs:458
    #region Json                                                                                                                            // MakerGen.cs:459
    #if NEVER                                                                                                                               // MakerGen.cs:460
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
    #endregion                                                                                                                              // MakerGen.cs:463
    /// <summary>
    /// Fhir resource 'CoverageEligibilityResponse'
    /// </summary>
    // 0. CoverageEligibilityResponse
    public class CoverageEligibilityResponse : FhirKhit.Maker.Common.Resource.ResourceBase                                                  // MakerGen.cs:385
    {                                                                                                                                       // MakerGen.cs:386
        public class CoverageEligibilityResponse_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                     // MakerGen.cs:387
        {                                                                                                                                   // MakerGen.cs:388
            // 12. CoverageEligibilityResponse.insurance
            public class Type_Insurance : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Insurance_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                          // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 16. CoverageEligibilityResponse.insurance.item
                    public class Type_Item : FhirKhit.Maker.Common.Complex.ComplexBase                                                      // MakerGen.cs:385
                    {                                                                                                                       // MakerGen.cs:386
                        public class Type_Item_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                       // MakerGen.cs:387
                        {                                                                                                                   // MakerGen.cs:388
                            // 27. CoverageEligibilityResponse.insurance.item.benefit
                            public class Type_Benefit : FhirKhit.Maker.Common.Complex.ComplexBase                                           // MakerGen.cs:385
                            {                                                                                                               // MakerGen.cs:386
                                public class Type_Benefit_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                            // MakerGen.cs:387
                                {                                                                                                           // MakerGen.cs:388
                                    // 28. CoverageEligibilityResponse.insurance.item.benefit.type
                                    public ElementDefinitionInfo Type;                                                                      // MakerGen.cs:236
                                    // 29. CoverageEligibilityResponse.insurance.item.benefit.allowed[x]
                                    public ElementDefinitionInfo Allowed;                                                                   // MakerGen.cs:236
                                    // 30. CoverageEligibilityResponse.insurance.item.benefit.used[x]
                                    public ElementDefinitionInfo Used;                                                                      // MakerGen.cs:236
                                    public Type_Benefit_Elements()                                                                          // MakerGen.cs:409
                                    {                                                                                                       // MakerGen.cs:410
                                        {                                                                                                   // MakerGen.cs:251
                                            // 28. CoverageEligibilityResponse.insurance.item.benefit.type
                                            this.Type = new ElementDefinitionInfo                                                           // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "Type",                                                                              // MakerGen.cs:255
                                                Path= "CoverageEligibilityResponse.insurance.item.benefit.type",                            // MakerGen.cs:256
                                                Id = "CoverageEligibilityResponse.insurance.item.benefit.type",                             // MakerGen.cs:257
                                                Min = 1,                                                                                    // MakerGen.cs:258
                                                Max = 1,                                                                                    // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                       // MakerGen.cs:314
                                                    {                                                                                       // MakerGen.cs:315
                                                    }                                                                                       // MakerGen.cs:318
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                        {                                                                                                   // MakerGen.cs:251
                                            // 29. CoverageEligibilityResponse.insurance.item.benefit.allowed[x]
                                            this.Allowed = new ElementDefinitionInfo                                                        // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "Allowed",                                                                           // MakerGen.cs:255
                                                Path= "CoverageEligibilityResponse.insurance.item.benefit.allowed[x]",                      // MakerGen.cs:256
                                                Id = "CoverageEligibilityResponse.insurance.item.benefit.allowed[x]",                       // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
                                                Max = 1,                                                                                    // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                    new FhirKhit.Maker.Common.Primitive.UnsignedInt                                         // MakerGen.cs:299
                                                    {                                                                                       // MakerGen.cs:300
                                                    },                                                                                      // MakerGen.cs:303
                                                    new FhirKhit.Maker.Common.Primitive.String                                              // MakerGen.cs:299
                                                    {                                                                                       // MakerGen.cs:300
                                                    },                                                                                      // MakerGen.cs:303
                                                    new FhirKhit.Maker.Common.Complex.Money                                                 // MakerGen.cs:357
                                                    {                                                                                       // MakerGen.cs:358
                                                    }                                                                                       // MakerGen.cs:359
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                        {                                                                                                   // MakerGen.cs:251
                                            // 30. CoverageEligibilityResponse.insurance.item.benefit.used[x]
                                            this.Used = new ElementDefinitionInfo                                                           // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "Used",                                                                              // MakerGen.cs:255
                                                Path= "CoverageEligibilityResponse.insurance.item.benefit.used[x]",                         // MakerGen.cs:256
                                                Id = "CoverageEligibilityResponse.insurance.item.benefit.used[x]",                          // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
                                                Max = 1,                                                                                    // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                    new FhirKhit.Maker.Common.Primitive.UnsignedInt                                         // MakerGen.cs:299
                                                    {                                                                                       // MakerGen.cs:300
                                                    },                                                                                      // MakerGen.cs:303
                                                    new FhirKhit.Maker.Common.Primitive.String                                              // MakerGen.cs:299
                                                    {                                                                                       // MakerGen.cs:300
                                                    },                                                                                      // MakerGen.cs:303
                                                    new FhirKhit.Maker.Common.Complex.Money                                                 // MakerGen.cs:357
                                                    {                                                                                       // MakerGen.cs:358
                                                    }                                                                                       // MakerGen.cs:359
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                    }                                                                                                       // MakerGen.cs:429
                                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                     // MakerGen.cs:414
                                    {                                                                                                       // MakerGen.cs:415
                                        base.Write(sDef);                                                                                   // MakerGen.cs:416
                                        Type.Write(sDef);                                                                                   // MakerGen.cs:240
                                        Allowed.Write(sDef);                                                                                // MakerGen.cs:240
                                        Used.Write(sDef);                                                                                   // MakerGen.cs:240
                                    }                                                                                                       // MakerGen.cs:433
                                }                                                                                                           // MakerGen.cs:393
                                public Type_Benefit_Elements Elements { get; }                                                              // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                                public Type_Benefit()                                                                                       // MakerGen.cs:396
                                {                                                                                                           // MakerGen.cs:397
                                    this.Elements = new Type_Benefit_Elements();                                                            // MakerGen.cs:398
                                }                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                         // MakerGen.cs:401
                                {                                                                                                           // MakerGen.cs:402
                                    this.Elements.Write(sDef);                                                                              // MakerGen.cs:403
                                }                                                                                                           // MakerGen.cs:404
                            }                                                                                                               // MakerGen.cs:405
                            // 17. CoverageEligibilityResponse.insurance.item.category
                            public ElementDefinitionInfo Category;                                                                          // MakerGen.cs:236
                            // 18. CoverageEligibilityResponse.insurance.item.productOrService
                            public ElementDefinitionInfo ProductOrService;                                                                  // MakerGen.cs:236
                            // 19. CoverageEligibilityResponse.insurance.item.modifier
                            public ElementDefinitionInfo Modifier;                                                                          // MakerGen.cs:236
                            // 20. CoverageEligibilityResponse.insurance.item.provider
                            public ElementDefinitionInfo Provider;                                                                          // MakerGen.cs:236
                            // 21. CoverageEligibilityResponse.insurance.item.excluded
                            public ElementDefinitionInfo Excluded;                                                                          // MakerGen.cs:236
                            // 22. CoverageEligibilityResponse.insurance.item.name
                            public ElementDefinitionInfo Name;                                                                              // MakerGen.cs:236
                            // 23. CoverageEligibilityResponse.insurance.item.description
                            public ElementDefinitionInfo Description;                                                                       // MakerGen.cs:236
                            // 24. CoverageEligibilityResponse.insurance.item.network
                            public ElementDefinitionInfo Network;                                                                           // MakerGen.cs:236
                            // 25. CoverageEligibilityResponse.insurance.item.unit
                            public ElementDefinitionInfo Unit;                                                                              // MakerGen.cs:236
                            // 26. CoverageEligibilityResponse.insurance.item.term
                            public ElementDefinitionInfo Term;                                                                              // MakerGen.cs:236
                            // 31. CoverageEligibilityResponse.insurance.item.authorizationRequired
                            public ElementDefinitionInfo AuthorizationRequired;                                                             // MakerGen.cs:236
                            // 32. CoverageEligibilityResponse.insurance.item.authorizationSupporting
                            public ElementDefinitionInfo AuthorizationSupporting;                                                           // MakerGen.cs:236
                            // 33. CoverageEligibilityResponse.insurance.item.authorizationUrl
                            public ElementDefinitionInfo AuthorizationUrl;                                                                  // MakerGen.cs:236
                            public Type_Item_Elements()                                                                                     // MakerGen.cs:409
                            {                                                                                                               // MakerGen.cs:410
                                {                                                                                                           // MakerGen.cs:251
                                    // 17. CoverageEligibilityResponse.insurance.item.category
                                    this.Category = new ElementDefinitionInfo                                                               // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Category",                                                                                  // MakerGen.cs:255
                                        Path= "CoverageEligibilityResponse.insurance.item.category",                                        // MakerGen.cs:256
                                        Id = "CoverageEligibilityResponse.insurance.item.category",                                         // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:314
                                            {                                                                                               // MakerGen.cs:315
                                            }                                                                                               // MakerGen.cs:318
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 18. CoverageEligibilityResponse.insurance.item.productOrService
                                    this.ProductOrService = new ElementDefinitionInfo                                                       // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "ProductOrService",                                                                          // MakerGen.cs:255
                                        Path= "CoverageEligibilityResponse.insurance.item.productOrService",                                // MakerGen.cs:256
                                        Id = "CoverageEligibilityResponse.insurance.item.productOrService",                                 // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:314
                                            {                                                                                               // MakerGen.cs:315
                                            }                                                                                               // MakerGen.cs:318
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 19. CoverageEligibilityResponse.insurance.item.modifier
                                    this.Modifier = new ElementDefinitionInfo                                                               // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Modifier",                                                                                  // MakerGen.cs:255
                                        Path= "CoverageEligibilityResponse.insurance.item.modifier",                                        // MakerGen.cs:256
                                        Id = "CoverageEligibilityResponse.insurance.item.modifier",                                         // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = -1,                                                                                           // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:314
                                            {                                                                                               // MakerGen.cs:315
                                            }                                                                                               // MakerGen.cs:318
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 20. CoverageEligibilityResponse.insurance.item.provider
                                    this.Provider = new ElementDefinitionInfo                                                               // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Provider",                                                                                  // MakerGen.cs:255
                                        Path= "CoverageEligibilityResponse.insurance.item.provider",                                        // MakerGen.cs:256
                                        Id = "CoverageEligibilityResponse.insurance.item.provider",                                         // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Complex.Reference                                                     // MakerGen.cs:345
                                            {                                                                                               // MakerGen.cs:346
                                                TargetProfile = new String[]                                                                // MakerGen.cs:348
                                                {                                                                                           // CodeEditorExtensions.cs:28
                                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                 // MakerGen.cs:348
                                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                              // MakerGen.cs:348
                                                }                                                                                           // CodeEditorExtensions.cs:34
                                            }                                                                                               // MakerGen.cs:349
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 21. CoverageEligibilityResponse.insurance.item.excluded
                                    this.Excluded = new ElementDefinitionInfo                                                               // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Excluded",                                                                                  // MakerGen.cs:255
                                        Path= "CoverageEligibilityResponse.insurance.item.excluded",                                        // MakerGen.cs:256
                                        Id = "CoverageEligibilityResponse.insurance.item.excluded",                                         // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Primitive.Boolean                                                     // MakerGen.cs:299
                                            {                                                                                               // MakerGen.cs:300
                                            }                                                                                               // MakerGen.cs:303
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 22. CoverageEligibilityResponse.insurance.item.name
                                    this.Name = new ElementDefinitionInfo                                                                   // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Name",                                                                                      // MakerGen.cs:255
                                        Path= "CoverageEligibilityResponse.insurance.item.name",                                            // MakerGen.cs:256
                                        Id = "CoverageEligibilityResponse.insurance.item.name",                                             // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:299
                                            {                                                                                               // MakerGen.cs:300
                                            }                                                                                               // MakerGen.cs:303
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 23. CoverageEligibilityResponse.insurance.item.description
                                    this.Description = new ElementDefinitionInfo                                                            // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Description",                                                                               // MakerGen.cs:255
                                        Path= "CoverageEligibilityResponse.insurance.item.description",                                     // MakerGen.cs:256
                                        Id = "CoverageEligibilityResponse.insurance.item.description",                                      // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:299
                                            {                                                                                               // MakerGen.cs:300
                                            }                                                                                               // MakerGen.cs:303
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 24. CoverageEligibilityResponse.insurance.item.network
                                    this.Network = new ElementDefinitionInfo                                                                // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Network",                                                                                   // MakerGen.cs:255
                                        Path= "CoverageEligibilityResponse.insurance.item.network",                                         // MakerGen.cs:256
                                        Id = "CoverageEligibilityResponse.insurance.item.network",                                          // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:314
                                            {                                                                                               // MakerGen.cs:315
                                            }                                                                                               // MakerGen.cs:318
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 25. CoverageEligibilityResponse.insurance.item.unit
                                    this.Unit = new ElementDefinitionInfo                                                                   // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Unit",                                                                                      // MakerGen.cs:255
                                        Path= "CoverageEligibilityResponse.insurance.item.unit",                                            // MakerGen.cs:256
                                        Id = "CoverageEligibilityResponse.insurance.item.unit",                                             // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:314
                                            {                                                                                               // MakerGen.cs:315
                                            }                                                                                               // MakerGen.cs:318
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 26. CoverageEligibilityResponse.insurance.item.term
                                    this.Term = new ElementDefinitionInfo                                                                   // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Term",                                                                                      // MakerGen.cs:255
                                        Path= "CoverageEligibilityResponse.insurance.item.term",                                            // MakerGen.cs:256
                                        Id = "CoverageEligibilityResponse.insurance.item.term",                                             // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:314
                                            {                                                                                               // MakerGen.cs:315
                                            }                                                                                               // MakerGen.cs:318
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 31. CoverageEligibilityResponse.insurance.item.authorizationRequired
                                    this.AuthorizationRequired = new ElementDefinitionInfo                                                  // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "AuthorizationRequired",                                                                     // MakerGen.cs:255
                                        Path= "CoverageEligibilityResponse.insurance.item.authorizationRequired",                           // MakerGen.cs:256
                                        Id = "CoverageEligibilityResponse.insurance.item.authorizationRequired",                            // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Primitive.Boolean                                                     // MakerGen.cs:299
                                            {                                                                                               // MakerGen.cs:300
                                            }                                                                                               // MakerGen.cs:303
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 32. CoverageEligibilityResponse.insurance.item.authorizationSupporting
                                    this.AuthorizationSupporting = new ElementDefinitionInfo                                                // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "AuthorizationSupporting",                                                                   // MakerGen.cs:255
                                        Path= "CoverageEligibilityResponse.insurance.item.authorizationSupporting",                         // MakerGen.cs:256
                                        Id = "CoverageEligibilityResponse.insurance.item.authorizationSupporting",                          // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = -1,                                                                                           // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:314
                                            {                                                                                               // MakerGen.cs:315
                                            }                                                                                               // MakerGen.cs:318
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 33. CoverageEligibilityResponse.insurance.item.authorizationUrl
                                    this.AuthorizationUrl = new ElementDefinitionInfo                                                       // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "AuthorizationUrl",                                                                          // MakerGen.cs:255
                                        Path= "CoverageEligibilityResponse.insurance.item.authorizationUrl",                                // MakerGen.cs:256
                                        Id = "CoverageEligibilityResponse.insurance.item.authorizationUrl",                                 // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Primitive.Uri                                                         // MakerGen.cs:299
                                            {                                                                                               // MakerGen.cs:300
                                            }                                                                                               // MakerGen.cs:303
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                            }                                                                                                               // MakerGen.cs:429
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:414
                            {                                                                                                               // MakerGen.cs:415
                                base.Write(sDef);                                                                                           // MakerGen.cs:416
                                Category.Write(sDef);                                                                                       // MakerGen.cs:240
                                ProductOrService.Write(sDef);                                                                               // MakerGen.cs:240
                                Modifier.Write(sDef);                                                                                       // MakerGen.cs:240
                                Provider.Write(sDef);                                                                                       // MakerGen.cs:240
                                Excluded.Write(sDef);                                                                                       // MakerGen.cs:240
                                Name.Write(sDef);                                                                                           // MakerGen.cs:240
                                Description.Write(sDef);                                                                                    // MakerGen.cs:240
                                Network.Write(sDef);                                                                                        // MakerGen.cs:240
                                Unit.Write(sDef);                                                                                           // MakerGen.cs:240
                                Term.Write(sDef);                                                                                           // MakerGen.cs:240
                                AuthorizationRequired.Write(sDef);                                                                          // MakerGen.cs:240
                                AuthorizationSupporting.Write(sDef);                                                                        // MakerGen.cs:240
                                AuthorizationUrl.Write(sDef);                                                                               // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:433
                        }                                                                                                                   // MakerGen.cs:393
                        public Type_Item_Elements Elements { get; }                                                                         // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                        public Type_Item()                                                                                                  // MakerGen.cs:396
                        {                                                                                                                   // MakerGen.cs:397
                            this.Elements = new Type_Item_Elements();                                                                       // MakerGen.cs:398
                        }                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:403
                        }                                                                                                                   // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                    // 13. CoverageEligibilityResponse.insurance.coverage
                    public ElementDefinitionInfo Coverage;                                                                                  // MakerGen.cs:236
                    // 14. CoverageEligibilityResponse.insurance.inforce
                    public ElementDefinitionInfo Inforce;                                                                                   // MakerGen.cs:236
                    // 15. CoverageEligibilityResponse.insurance.benefitPeriod
                    public ElementDefinitionInfo BenefitPeriod;                                                                             // MakerGen.cs:236
                    public Type_Insurance_Elements()                                                                                        // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 13. CoverageEligibilityResponse.insurance.coverage
                            this.Coverage = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Coverage",                                                                                          // MakerGen.cs:255
                                Path= "CoverageEligibilityResponse.insurance.coverage",                                                     // MakerGen.cs:256
                                Id = "CoverageEligibilityResponse.insurance.coverage",                                                      // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:345
                                    {                                                                                                       // MakerGen.cs:346
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:348
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Coverage"                                              // MakerGen.cs:348
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 14. CoverageEligibilityResponse.insurance.inforce
                            this.Inforce = new ElementDefinitionInfo                                                                        // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Inforce",                                                                                           // MakerGen.cs:255
                                Path= "CoverageEligibilityResponse.insurance.inforce",                                                      // MakerGen.cs:256
                                Id = "CoverageEligibilityResponse.insurance.inforce",                                                       // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Boolean                                                             // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 15. CoverageEligibilityResponse.insurance.benefitPeriod
                            this.BenefitPeriod = new ElementDefinitionInfo                                                                  // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "BenefitPeriod",                                                                                     // MakerGen.cs:255
                                Path= "CoverageEligibilityResponse.insurance.benefitPeriod",                                                // MakerGen.cs:256
                                Id = "CoverageEligibilityResponse.insurance.benefitPeriod",                                                 // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Period                                                                // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Coverage.Write(sDef);                                                                                               // MakerGen.cs:240
                        Inforce.Write(sDef);                                                                                                // MakerGen.cs:240
                        BenefitPeriod.Write(sDef);                                                                                          // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Insurance_Elements Elements { get; }                                                                            // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Insurance()                                                                                                     // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Insurance_Elements();                                                                          // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 36. CoverageEligibilityResponse.error
            public class Type_Error : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Error_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                              // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 37. CoverageEligibilityResponse.error.code
                    public ElementDefinitionInfo Code;                                                                                      // MakerGen.cs:236
                    public Type_Error_Elements()                                                                                            // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 37. CoverageEligibilityResponse.error.code
                            this.Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Code",                                                                                              // MakerGen.cs:255
                                Path= "CoverageEligibilityResponse.error.code",                                                             // MakerGen.cs:256
                                Id = "CoverageEligibilityResponse.error.code",                                                              // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Code.Write(sDef);                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Error_Elements Elements { get; }                                                                                // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Error()                                                                                                         // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Error_Elements();                                                                              // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 1. CoverageEligibilityResponse.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:236
            // 2. CoverageEligibilityResponse.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:236
            // 3. CoverageEligibilityResponse.purpose
            public ElementDefinitionInfo Purpose;                                                                                           // MakerGen.cs:236
            // 4. CoverageEligibilityResponse.patient
            public ElementDefinitionInfo Patient;                                                                                           // MakerGen.cs:236
            // 5. CoverageEligibilityResponse.serviced[x]
            public ElementDefinitionInfo Serviced;                                                                                          // MakerGen.cs:236
            // 6. CoverageEligibilityResponse.created
            public ElementDefinitionInfo Created;                                                                                           // MakerGen.cs:236
            // 7. CoverageEligibilityResponse.requestor
            public ElementDefinitionInfo Requestor;                                                                                         // MakerGen.cs:236
            // 8. CoverageEligibilityResponse.request
            public ElementDefinitionInfo Request;                                                                                           // MakerGen.cs:236
            // 9. CoverageEligibilityResponse.outcome
            public ElementDefinitionInfo Outcome;                                                                                           // MakerGen.cs:236
            // 10. CoverageEligibilityResponse.disposition
            public ElementDefinitionInfo Disposition;                                                                                       // MakerGen.cs:236
            // 11. CoverageEligibilityResponse.insurer
            public ElementDefinitionInfo Insurer;                                                                                           // MakerGen.cs:236
            // 34. CoverageEligibilityResponse.preAuthRef
            public ElementDefinitionInfo PreAuthRef;                                                                                        // MakerGen.cs:236
            // 35. CoverageEligibilityResponse.form
            public ElementDefinitionInfo Form;                                                                                              // MakerGen.cs:236
            public CoverageEligibilityResponse_Elements()                                                                                   // MakerGen.cs:409
            {                                                                                                                               // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:251
                    // 1. CoverageEligibilityResponse.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Identifier",                                                                                                // MakerGen.cs:255
                        Path= "CoverageEligibilityResponse.identifier",                                                                     // MakerGen.cs:256
                        Id = "CoverageEligibilityResponse.identifier",                                                                      // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 2. CoverageEligibilityResponse.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Status",                                                                                                    // MakerGen.cs:255
                        Path= "CoverageEligibilityResponse.status",                                                                         // MakerGen.cs:256
                        Id = "CoverageEligibilityResponse.status",                                                                          // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 3. CoverageEligibilityResponse.purpose
                    this.Purpose = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Purpose",                                                                                                   // MakerGen.cs:255
                        Path= "CoverageEligibilityResponse.purpose",                                                                        // MakerGen.cs:256
                        Id = "CoverageEligibilityResponse.purpose",                                                                         // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 4. CoverageEligibilityResponse.patient
                    this.Patient = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Patient",                                                                                                   // MakerGen.cs:255
                        Path= "CoverageEligibilityResponse.patient",                                                                        // MakerGen.cs:256
                        Id = "CoverageEligibilityResponse.patient",                                                                         // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient"                                                       // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 5. CoverageEligibilityResponse.serviced[x]
                    this.Serviced = new ElementDefinitionInfo                                                                               // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Serviced",                                                                                                  // MakerGen.cs:255
                        Path= "CoverageEligibilityResponse.serviced[x]",                                                                    // MakerGen.cs:256
                        Id = "CoverageEligibilityResponse.serviced[x]",                                                                     // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Date                                                                        // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            },                                                                                                              // MakerGen.cs:303
                            new FhirKhit.Maker.Common.Complex.Period                                                                        // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 6. CoverageEligibilityResponse.created
                    this.Created = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Created",                                                                                                   // MakerGen.cs:255
                        Path= "CoverageEligibilityResponse.created",                                                                        // MakerGen.cs:256
                        Id = "CoverageEligibilityResponse.created",                                                                         // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 7. CoverageEligibilityResponse.requestor
                    this.Requestor = new ElementDefinitionInfo                                                                              // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Requestor",                                                                                                 // MakerGen.cs:255
                        Path= "CoverageEligibilityResponse.requestor",                                                                      // MakerGen.cs:256
                        Id = "CoverageEligibilityResponse.requestor",                                                                       // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 8. CoverageEligibilityResponse.request
                    this.Request = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Request",                                                                                                   // MakerGen.cs:255
                        Path= "CoverageEligibilityResponse.request",                                                                        // MakerGen.cs:256
                        Id = "CoverageEligibilityResponse.request",                                                                         // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/CoverageEligibilityRequest"                                    // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 9. CoverageEligibilityResponse.outcome
                    this.Outcome = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Outcome",                                                                                                   // MakerGen.cs:255
                        Path= "CoverageEligibilityResponse.outcome",                                                                        // MakerGen.cs:256
                        Id = "CoverageEligibilityResponse.outcome",                                                                         // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 10. CoverageEligibilityResponse.disposition
                    this.Disposition = new ElementDefinitionInfo                                                                            // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Disposition",                                                                                               // MakerGen.cs:255
                        Path= "CoverageEligibilityResponse.disposition",                                                                    // MakerGen.cs:256
                        Id = "CoverageEligibilityResponse.disposition",                                                                     // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 11. CoverageEligibilityResponse.insurer
                    this.Insurer = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Insurer",                                                                                                   // MakerGen.cs:255
                        Path= "CoverageEligibilityResponse.insurer",                                                                        // MakerGen.cs:256
                        Id = "CoverageEligibilityResponse.insurer",                                                                         // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 34. CoverageEligibilityResponse.preAuthRef
                    this.PreAuthRef = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "PreAuthRef",                                                                                                // MakerGen.cs:255
                        Path= "CoverageEligibilityResponse.preAuthRef",                                                                     // MakerGen.cs:256
                        Id = "CoverageEligibilityResponse.preAuthRef",                                                                      // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 35. CoverageEligibilityResponse.form
                    this.Form = new ElementDefinitionInfo                                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Form",                                                                                                      // MakerGen.cs:255
                        Path= "CoverageEligibilityResponse.form",                                                                           // MakerGen.cs:256
                        Id = "CoverageEligibilityResponse.form",                                                                            // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:314
                            {                                                                                                               // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:318
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
            }                                                                                                                               // MakerGen.cs:429
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:414
            {                                                                                                                               // MakerGen.cs:415
                base.Write(sDef);                                                                                                           // MakerGen.cs:416
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:240
                Status.Write(sDef);                                                                                                         // MakerGen.cs:240
                Purpose.Write(sDef);                                                                                                        // MakerGen.cs:240
                Patient.Write(sDef);                                                                                                        // MakerGen.cs:240
                Serviced.Write(sDef);                                                                                                       // MakerGen.cs:240
                Created.Write(sDef);                                                                                                        // MakerGen.cs:240
                Requestor.Write(sDef);                                                                                                      // MakerGen.cs:240
                Request.Write(sDef);                                                                                                        // MakerGen.cs:240
                Outcome.Write(sDef);                                                                                                        // MakerGen.cs:240
                Disposition.Write(sDef);                                                                                                    // MakerGen.cs:240
                Insurer.Write(sDef);                                                                                                        // MakerGen.cs:240
                PreAuthRef.Write(sDef);                                                                                                     // MakerGen.cs:240
                Form.Write(sDef);                                                                                                           // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:433
        }                                                                                                                                   // MakerGen.cs:393
        public CoverageEligibilityResponse_Elements Elements { get; }                                                                       // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
        public CoverageEligibilityResponse()                                                                                                // MakerGen.cs:396
        {                                                                                                                                   // MakerGen.cs:397
            this.Elements = new CoverageEligibilityResponse_Elements();                                                                     // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:404
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:468
