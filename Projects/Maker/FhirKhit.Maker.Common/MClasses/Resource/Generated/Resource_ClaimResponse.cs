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
      "id": "ClaimResponse",
      "url": "http://hl7.org/fhir/StructureDefinition/ClaimResponse",
      "version": "4.0.0",
      "name": "ClaimResponse",
      "status": "draft",
      "publisher": "Health Level Seven International (Financial Management)",
      "description": "This resource provides the adjudication details from the processing of a Claim resource.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "ClaimResponse",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "ClaimResponse",
            "path": "ClaimResponse",
            "short": "Response to a claim predetermination or preauthorization",
            "definition": "This resource provides the adjudication details from the processing of a Claim resource.",
            "alias": [
              "Remittance Advice"
            ],
            "min": 0,
            "max": "*"
          },
          {
            "id": "ClaimResponse.identifier",
            "path": "ClaimResponse.identifier",
            "short": "Business Identifier for a claim response",
            "definition": "A unique identifier assigned to this claim response.",
            "requirements": "Allows claim responses to be distinguished and referenced.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Identifier"
              }
            ]
          },
          {
            "id": "ClaimResponse.status",
            "path": "ClaimResponse.status",
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
                  "valueString": "ClaimResponseStatus"
                }
              ],
              "strength": "required",
              "description": "A code specifying the state of the resource instance.",
              "valueSet": "http://hl7.org/fhir/ValueSet/fm-status|4.0.0"
            }
          },
          {
            "id": "ClaimResponse.type",
            "path": "ClaimResponse.type",
            "short": "More granular claim type",
            "definition": "A finer grained suite of claim type codes which may convey additional information such as Inpatient vs Outpatient and/or a specialty service.",
            "comment": "This may contain the local bill type codes, for example the US UB-04 bill type code or the CMS bill type.",
            "requirements": "Some jurisdictions need a finer grained claim type for routing and adjudication.",
            "min": 1,
            "max": "1",
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
                  "valueString": "ClaimType"
                }
              ],
              "strength": "extensible",
              "description": "The type or discipline-style of the claim.",
              "valueSet": "http://hl7.org/fhir/ValueSet/claim-type"
            }
          },
          {
            "id": "ClaimResponse.subType",
            "path": "ClaimResponse.subType",
            "short": "More granular claim type",
            "definition": "A finer grained suite of claim type codes which may convey additional information such as Inpatient vs Outpatient and/or a specialty service.",
            "comment": "This may contain the local bill type codes, for example the US UB-04 bill type code or the CMS bill type.",
            "requirements": "Some jurisdictions need a finer grained claim type for routing and adjudication.",
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
                  "valueString": "ClaimSubType"
                }
              ],
              "strength": "example",
              "description": "A more granular claim typecode.",
              "valueSet": "http://hl7.org/fhir/ValueSet/claim-subtype"
            }
          },
          {
            "id": "ClaimResponse.use",
            "path": "ClaimResponse.use",
            "short": "claim | preauthorization | predetermination",
            "definition": "A code to indicate whether the nature of the request is: to request adjudication of products and services previously rendered; or requesting authorization and adjudication for provision in the future; or requesting the non-binding adjudication of the listed products and services which could be provided in the future.",
            "requirements": "This element is required to understand the nature of the request for adjudication.",
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
                  "valueString": "Use"
                }
              ],
              "strength": "required",
              "description": "Claim, preauthorization, predetermination.",
              "valueSet": "http://hl7.org/fhir/ValueSet/claim-use|4.0.0"
            }
          },
          {
            "id": "ClaimResponse.patient",
            "path": "ClaimResponse.patient",
            "short": "The recipient of the products and services",
            "definition": "The party to whom the professional services and/or products have been supplied or are being considered and for whom actual for facast reimbursement is sought.",
            "requirements": "The patient must be supplied to the insurer so that confirmation of coverage and service hstory may be considered as part of the authorization and/or adjudiction.",
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
            "id": "ClaimResponse.created",
            "path": "ClaimResponse.created",
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
            "id": "ClaimResponse.insurer",
            "path": "ClaimResponse.insurer",
            "short": "Party responsible for reimbursement",
            "definition": "The party responsible for authorization, adjudication and reimbursement.",
            "requirements": "To be a valid claim, preauthorization or predetermination there must be a party who is responsible for adjudicating the contents against a policy which provides benefits for the patient.",
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
            "id": "ClaimResponse.requestor",
            "path": "ClaimResponse.requestor",
            "short": "Party responsible for the claim",
            "definition": "The provider which is responsible for the claim, predetermination or preauthorization.",
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
            "id": "ClaimResponse.request",
            "path": "ClaimResponse.request",
            "short": "Id of resource triggering adjudication",
            "definition": "Original request resource reference.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Claim"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "ClaimResponse.outcome",
            "path": "ClaimResponse.outcome",
            "short": "queued | complete | error | partial",
            "definition": "The outcome of the claim, predetermination, or preauthorization processing.",
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
                }
              ],
              "strength": "required",
              "description": "The result of the claim processing.",
              "valueSet": "http://hl7.org/fhir/ValueSet/remittance-outcome|4.0.0"
            }
          },
          {
            "id": "ClaimResponse.disposition",
            "path": "ClaimResponse.disposition",
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
            "id": "ClaimResponse.preAuthRef",
            "path": "ClaimResponse.preAuthRef",
            "short": "Preauthorization reference",
            "definition": "Reference from the Insurer which is used in later communications which refers to this adjudication.",
            "comment": "This value is only present on preauthorization adjudications.",
            "requirements": "On subsequent claims, the insurer may require the provider to quote this value.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ClaimResponse.preAuthPeriod",
            "path": "ClaimResponse.preAuthPeriod",
            "short": "Preauthorization reference effective period",
            "definition": "The time frame during which this authorization is effective.",
            "requirements": "To convey to the provider when the authorized products and services must be supplied for the authorized adjudication to apply.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Period"
              }
            ]
          },
          {
            "id": "ClaimResponse.payeeType",
            "path": "ClaimResponse.payeeType",
            "short": "Party to be paid any benefits payable",
            "definition": "Type of Party to be reimbursed: subscriber, provider, other.",
            "requirements": "Need to know who should receive payment with the most common situations being the Provider (assignment of benefits) or the Subscriber.",
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
                  "valueString": "PayeeType"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "example",
              "description": "A code for the party to be reimbursed.",
              "valueSet": "http://hl7.org/fhir/ValueSet/payeetype"
            }
          },
          {
            "id": "ClaimResponse.item",
            "path": "ClaimResponse.item",
            "short": "Adjudication for claim line items",
            "definition": "A claim line. Either a simple (a product or service) or a 'group' of details which can also be a simple items or groups of sub-details.",
            "requirements": "The adjudication for items provided on the claim.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ClaimResponse.item.itemSequence",
            "path": "ClaimResponse.item.itemSequence",
            "short": "Claim item instance identifier",
            "definition": "A number to uniquely reference the claim item entries.",
            "requirements": "Necessary to provide a mechanism to link the adjudication result to the submitted claim item.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "positiveInt"
              }
            ]
          },
          {
            "id": "ClaimResponse.item.noteNumber",
            "path": "ClaimResponse.item.noteNumber",
            "short": "Applicable note numbers",
            "definition": "The numbers associated with notes below which apply to the adjudication of this item.",
            "requirements": "Provides a condensed manner for associating human readable descriptive explanations for adjudications on the line item.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "positiveInt"
              }
            ]
          },
          {
            "id": "ClaimResponse.item.adjudication",
            "path": "ClaimResponse.item.adjudication",
            "short": "Adjudication details",
            "definition": "If this item is a group then the values here are a summary of the adjudication of the detail items. If this item is a simple product or service then this is the result of the adjudication of this item.",
            "requirements": "The adjudication results conveys the insurer's assessment of the item provided in the claim under the terms of the patient's insurance coverage.",
            "min": 1,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ClaimResponse.item.adjudication.category",
            "path": "ClaimResponse.item.adjudication.category",
            "short": "Type of adjudication information",
            "definition": "A code to indicate the information type of this adjudication record. Information types may include the value submitted, maximum values or percentages allowed or payable under the plan, amounts that: the patient is responsible for in aggregate or pertaining to this item; amounts paid by other coverages; and, the benefit payable for this item.",
            "comment": "For example codes indicating: Co-Pay, deductible, eligible, benefit, tax, etc.",
            "requirements": "Needed to enable understanding of the context of the other information in the adjudication.",
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
                  "valueString": "Adjudication"
                }
              ],
              "strength": "example",
              "description": "The adjudication codes.",
              "valueSet": "http://hl7.org/fhir/ValueSet/adjudication"
            }
          },
          {
            "id": "ClaimResponse.item.adjudication.reason",
            "path": "ClaimResponse.item.adjudication.reason",
            "short": "Explanation of adjudication outcome",
            "definition": "A code supporting the understanding of the adjudication result and explaining variance from expected amount.",
            "comment": "For example may indicate that the funds for this benefit type have been exhausted.",
            "requirements": "To support understanding of variance from adjudication expectations.",
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
                  "valueString": "AdjudicationReason"
                }
              ],
              "strength": "example",
              "description": "The adjudication reason codes.",
              "valueSet": "http://hl7.org/fhir/ValueSet/adjudication-reason"
            }
          },
          {
            "id": "ClaimResponse.item.adjudication.amount",
            "path": "ClaimResponse.item.adjudication.amount",
            "short": "Monetary amount",
            "definition": "Monetary amount associated with the category.",
            "comment": "For example: amount submitted, eligible amount, co-payment, and benefit payable.",
            "requirements": "Most adjuciation categories convey a monetary amount.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Money"
              }
            ]
          },
          {
            "id": "ClaimResponse.item.adjudication.value",
            "path": "ClaimResponse.item.adjudication.value",
            "short": "Non-monetary value",
            "definition": "A non-monetary value associated with the category. Mutually exclusive to the amount element above.",
            "comment": "For example: eligible percentage or co-payment percentage.",
            "requirements": "Some adjudication categories convey a percentage or a fixed value.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "decimal"
              }
            ]
          },
          {
            "id": "ClaimResponse.item.detail",
            "path": "ClaimResponse.item.detail",
            "short": "Adjudication for claim details",
            "definition": "A claim detail. Either a simple (a product or service) or a 'group' of sub-details which are simple items.",
            "requirements": "The adjudication for details provided on the claim.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ClaimResponse.item.detail.detailSequence",
            "path": "ClaimResponse.item.detail.detailSequence",
            "short": "Claim detail instance identifier",
            "definition": "A number to uniquely reference the claim detail entry.",
            "requirements": "Necessary to provide a mechanism to link the adjudication result to the submitted claim detail.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "positiveInt"
              }
            ]
          },
          {
            "id": "ClaimResponse.item.detail.noteNumber",
            "path": "ClaimResponse.item.detail.noteNumber",
            "short": "Applicable note numbers",
            "definition": "The numbers associated with notes below which apply to the adjudication of this item.",
            "requirements": "Provides a condensed manner for associating human readable descriptive explanations for adjudications on the line item.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "positiveInt"
              }
            ]
          },
          {
            "id": "ClaimResponse.item.detail.adjudication",
            "path": "ClaimResponse.item.detail.adjudication",
            "short": "Detail level adjudication details",
            "definition": "The adjudication results.",
            "min": 1,
            "max": "*",
            "contentReference": "#ClaimResponse.item.adjudication"
          },
          {
            "id": "ClaimResponse.item.detail.subDetail",
            "path": "ClaimResponse.item.detail.subDetail",
            "short": "Adjudication for claim sub-details",
            "definition": "A sub-detail adjudication of a simple product or service.",
            "requirements": "The adjudication for sub-details provided on the claim.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ClaimResponse.item.detail.subDetail.subDetailSequence",
            "path": "ClaimResponse.item.detail.subDetail.subDetailSequence",
            "short": "Claim sub-detail instance identifier",
            "definition": "A number to uniquely reference the claim sub-detail entry.",
            "requirements": "Necessary to provide a mechanism to link the adjudication result to the submitted claim sub-detail.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "positiveInt"
              }
            ]
          },
          {
            "id": "ClaimResponse.item.detail.subDetail.noteNumber",
            "path": "ClaimResponse.item.detail.subDetail.noteNumber",
            "short": "Applicable note numbers",
            "definition": "The numbers associated with notes below which apply to the adjudication of this item.",
            "requirements": "Provides a condensed manner for associating human readable descriptive explanations for adjudications on the line item.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "positiveInt"
              }
            ]
          },
          {
            "id": "ClaimResponse.item.detail.subDetail.adjudication",
            "path": "ClaimResponse.item.detail.subDetail.adjudication",
            "short": "Subdetail level adjudication details",
            "definition": "The adjudication results.",
            "min": 0,
            "max": "*",
            "contentReference": "#ClaimResponse.item.adjudication"
          },
          {
            "id": "ClaimResponse.addItem",
            "path": "ClaimResponse.addItem",
            "short": "Insurer added line items",
            "definition": "The first-tier service adjudications for payor added product or service lines.",
            "requirements": "Insurers may redefine the provided product or service or may package and/or decompose groups of products and services. The addItems allows the insurer to provide their line item list with linkage to the submitted items/details/sub-details. In a preauthorization the insurer may use the addItem structure to provide additional information on authorized products and services.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ClaimResponse.addItem.itemSequence",
            "path": "ClaimResponse.addItem.itemSequence",
            "short": "Item sequence number",
            "definition": "Claim items which this service line is intended to replace.",
            "requirements": "Provides references to the claim items.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "positiveInt"
              }
            ]
          },
          {
            "id": "ClaimResponse.addItem.detailSequence",
            "path": "ClaimResponse.addItem.detailSequence",
            "short": "Detail sequence number",
            "definition": "The sequence number of the details within the claim item which this line is intended to replace.",
            "requirements": "Provides references to the claim details within the claim item.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "positiveInt"
              }
            ]
          },
          {
            "id": "ClaimResponse.addItem.subdetailSequence",
            "path": "ClaimResponse.addItem.subdetailSequence",
            "short": "Subdetail sequence number",
            "definition": "The sequence number of the sub-details within the details within the claim item which this line is intended to replace.",
            "requirements": "Provides references to the claim sub-details within the claim detail.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "positiveInt"
              }
            ]
          },
          {
            "id": "ClaimResponse.addItem.provider",
            "path": "ClaimResponse.addItem.provider",
            "short": "Authorized providers",
            "definition": "The providers who are authorized for the services rendered to the patient.",
            "requirements": "Insurer may provide authorization specifically to a restricted set of providers rather than an open authorization.",
            "min": 0,
            "max": "*",
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
            "id": "ClaimResponse.addItem.productOrService",
            "path": "ClaimResponse.addItem.productOrService",
            "short": "Billing, service, product, or drug code",
            "definition": "When the value is a group code then this item collects a set of related claim details, otherwise this contains the product, service, drug or other billing code for the item.",
            "comment": "If this is an actual service or product line, i.e. not a Group, then use code to indicate the Professional Service or Product supplied (e.g. CTP, HCPCS, USCLS, ICD10, NCPDP, DIN, RxNorm, ACHI, CCI). If a grouping item then use a group code to indicate the type of thing being grouped e.g. 'glasses' or 'compound'.",
            "requirements": "Necessary to state what was provided or done.",
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
                  "valueString": "ServiceProduct"
                }
              ],
              "strength": "example",
              "description": "Allowable service and product codes.",
              "valueSet": "http://hl7.org/fhir/ValueSet/service-uscls"
            }
          },
          {
            "id": "ClaimResponse.addItem.modifier",
            "path": "ClaimResponse.addItem.modifier",
            "short": "Service/Product billing modifiers",
            "definition": "Item typification or modifiers codes to convey additional context for the product or service.",
            "comment": "For example in Oral whether the treatment is cosmetic or associated with TMJ, or for Medical whether the treatment was outside the clinic or outside of office hours.",
            "requirements": "To support inclusion of the item for adjudication or to charge an elevated fee.",
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
            "id": "ClaimResponse.addItem.programCode",
            "path": "ClaimResponse.addItem.programCode",
            "short": "Program the product or service is provided under",
            "definition": "Identifies the program under which this may be recovered.",
            "comment": "For example: Neonatal program, child dental program or drug users recovery program.",
            "requirements": "Commonly used in in the identification of publicly provided program focused on population segments or disease classifications.",
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
                  "valueString": "ProgramCode"
                }
              ],
              "strength": "example",
              "description": "Program specific reason codes.",
              "valueSet": "http://hl7.org/fhir/ValueSet/ex-program-code"
            }
          },
          {
            "id": "ClaimResponse.addItem.serviced[x]",
            "path": "ClaimResponse.addItem.serviced[x]",
            "short": "Date or dates of service or product delivery",
            "definition": "The date or dates when the service or product was supplied, performed or completed.",
            "requirements": "Needed to determine whether the  service or product was provided during the term of the insurance coverage.",
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
            "id": "ClaimResponse.addItem.location[x]",
            "path": "ClaimResponse.addItem.location[x]",
            "short": "Place of service or where product was supplied",
            "definition": "Where the product or service was provided.",
            "requirements": "The location can alter whether the item was acceptable for insurance purposes or impact the determination of the benefit amount.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              },
              {
                "code": "Address"
              },
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Location"
                ]
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ServicePlace"
                }
              ],
              "strength": "example",
              "description": "Place of service: pharmacy, school, prison, etc.",
              "valueSet": "http://hl7.org/fhir/ValueSet/service-place"
            }
          },
          {
            "id": "ClaimResponse.addItem.quantity",
            "path": "ClaimResponse.addItem.quantity",
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
            "id": "ClaimResponse.addItem.unitPrice",
            "path": "ClaimResponse.addItem.unitPrice",
            "short": "Fee, charge or cost per item",
            "definition": "If the item is not a group then this is the fee for the product or service, otherwise this is the total of the fees for the details of the group.",
            "requirements": "The amount charged to the patient by the provider for a single unit.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Money"
              }
            ]
          },
          {
            "id": "ClaimResponse.addItem.factor",
            "path": "ClaimResponse.addItem.factor",
            "short": "Price scaling factor",
            "definition": "A real number that represents a multiplier used in determining the overall value of services delivered and/or goods received. The concept of a Factor allows for a discount or surcharge multiplier to be applied to a monetary amount.",
            "comment": "To show a 10% senior's discount, the value entered is: 0.90 (1.00 - 0.10).",
            "requirements": "When discounts are provided to a patient (example: Senior's discount) then this must be documented for adjudication.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "decimal"
              }
            ]
          },
          {
            "id": "ClaimResponse.addItem.net",
            "path": "ClaimResponse.addItem.net",
            "short": "Total item cost",
            "definition": "The quantity times the unit price for an additional service or product or charge.",
            "comment": "For example, the formula: quantity * unitPrice * factor  = net. Quantity and factor are assumed to be 1 if not supplied.",
            "requirements": "Provides the total amount claimed  for the group (if a grouper) or the line item.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Money"
              }
            ]
          },
          {
            "id": "ClaimResponse.addItem.bodySite",
            "path": "ClaimResponse.addItem.bodySite",
            "short": "Anatomical location",
            "definition": "Physical service site on the patient (limb, tooth, etc.).",
            "comment": "For example: Providing a tooth code allows an insurer to identify a provider performing a filling on a tooth that was previously removed.",
            "requirements": "Allows insurer to validate specific procedures.",
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
                  "valueString": "OralSites"
                }
              ],
              "strength": "example",
              "description": "The code for the teeth, quadrant, sextant and arch.",
              "valueSet": "http://hl7.org/fhir/ValueSet/tooth"
            }
          },
          {
            "id": "ClaimResponse.addItem.subSite",
            "path": "ClaimResponse.addItem.subSite",
            "short": "Anatomical sub-location",
            "definition": "A region or surface of the bodySite, e.g. limb region or tooth surface(s).",
            "requirements": "Allows insurer to validate specific procedures.",
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
                  "valueString": "Surface"
                }
              ],
              "strength": "example",
              "description": "The code for the tooth surface and surface combinations.",
              "valueSet": "http://hl7.org/fhir/ValueSet/surface"
            }
          },
          {
            "id": "ClaimResponse.addItem.noteNumber",
            "path": "ClaimResponse.addItem.noteNumber",
            "short": "Applicable note numbers",
            "definition": "The numbers associated with notes below which apply to the adjudication of this item.",
            "requirements": "Provides a condensed manner for associating human readable descriptive explanations for adjudications on the line item.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "positiveInt"
              }
            ]
          },
          {
            "id": "ClaimResponse.addItem.adjudication",
            "path": "ClaimResponse.addItem.adjudication",
            "short": "Added items adjudication",
            "definition": "The adjudication results.",
            "min": 1,
            "max": "*",
            "contentReference": "#ClaimResponse.item.adjudication"
          },
          {
            "id": "ClaimResponse.addItem.detail",
            "path": "ClaimResponse.addItem.detail",
            "short": "Insurer added line details",
            "definition": "The second-tier service adjudications for payor added services.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ClaimResponse.addItem.detail.productOrService",
            "path": "ClaimResponse.addItem.detail.productOrService",
            "short": "Billing, service, product, or drug code",
            "definition": "When the value is a group code then this item collects a set of related claim details, otherwise this contains the product, service, drug or other billing code for the item.",
            "comment": "If this is an actual service or product line, i.e. not a Group, then use code to indicate the Professional Service or Product supplied (e.g. CTP, HCPCS, USCLS, ICD10, NCPDP, DIN, RxNorm, ACHI, CCI). If a grouping item then use a group code to indicate the type of thing being grouped e.g. 'glasses' or 'compound'.",
            "requirements": "Necessary to state what was provided or done.",
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
                  "valueString": "ServiceProduct"
                }
              ],
              "strength": "example",
              "description": "Allowable service and product codes.",
              "valueSet": "http://hl7.org/fhir/ValueSet/service-uscls"
            }
          },
          {
            "id": "ClaimResponse.addItem.detail.modifier",
            "path": "ClaimResponse.addItem.detail.modifier",
            "short": "Service/Product billing modifiers",
            "definition": "Item typification or modifiers codes to convey additional context for the product or service.",
            "comment": "For example in Oral whether the treatment is cosmetic or associated with TMJ, or for Medical whether the treatment was outside the clinic or outside of office hours.",
            "requirements": "To support inclusion of the item for adjudication or to charge an elevated fee.",
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
            "id": "ClaimResponse.addItem.detail.quantity",
            "path": "ClaimResponse.addItem.detail.quantity",
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
            "id": "ClaimResponse.addItem.detail.unitPrice",
            "path": "ClaimResponse.addItem.detail.unitPrice",
            "short": "Fee, charge or cost per item",
            "definition": "If the item is not a group then this is the fee for the product or service, otherwise this is the total of the fees for the details of the group.",
            "requirements": "The amount charged to the patient by the provider for a single unit.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Money"
              }
            ]
          },
          {
            "id": "ClaimResponse.addItem.detail.factor",
            "path": "ClaimResponse.addItem.detail.factor",
            "short": "Price scaling factor",
            "definition": "A real number that represents a multiplier used in determining the overall value of services delivered and/or goods received. The concept of a Factor allows for a discount or surcharge multiplier to be applied to a monetary amount.",
            "comment": "To show a 10% senior's discount, the value entered is: 0.90 (1.00 - 0.10).",
            "requirements": "When discounts are provided to a patient (example: Senior's discount) then this must be documented for adjudication.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "decimal"
              }
            ]
          },
          {
            "id": "ClaimResponse.addItem.detail.net",
            "path": "ClaimResponse.addItem.detail.net",
            "short": "Total item cost",
            "definition": "The quantity times the unit price for an additional service or product or charge.",
            "comment": "For example, the formula: quantity * unitPrice * factor  = net. Quantity and factor are assumed to be 1 if not supplied.",
            "requirements": "Provides the total amount claimed  for the group (if a grouper) or the line item.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Money"
              }
            ]
          },
          {
            "id": "ClaimResponse.addItem.detail.noteNumber",
            "path": "ClaimResponse.addItem.detail.noteNumber",
            "short": "Applicable note numbers",
            "definition": "The numbers associated with notes below which apply to the adjudication of this item.",
            "requirements": "Provides a condensed manner for associating human readable descriptive explanations for adjudications on the line item.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "positiveInt"
              }
            ]
          },
          {
            "id": "ClaimResponse.addItem.detail.adjudication",
            "path": "ClaimResponse.addItem.detail.adjudication",
            "short": "Added items detail adjudication",
            "definition": "The adjudication results.",
            "min": 1,
            "max": "*",
            "contentReference": "#ClaimResponse.item.adjudication"
          },
          {
            "id": "ClaimResponse.addItem.detail.subDetail",
            "path": "ClaimResponse.addItem.detail.subDetail",
            "short": "Insurer added line items",
            "definition": "The third-tier service adjudications for payor added services.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ClaimResponse.addItem.detail.subDetail.productOrService",
            "path": "ClaimResponse.addItem.detail.subDetail.productOrService",
            "short": "Billing, service, product, or drug code",
            "definition": "When the value is a group code then this item collects a set of related claim details, otherwise this contains the product, service, drug or other billing code for the item.",
            "comment": "If this is an actual service or product line, i.e. not a Group, then use code to indicate the Professional Service or Product supplied (e.g. CTP, HCPCS, USCLS, ICD10, NCPDP, DIN, RxNorm, ACHI, CCI). If a grouping item then use a group code to indicate the type of thing being grouped e.g. 'glasses' or 'compound'.",
            "requirements": "Necessary to state what was provided or done.",
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
                  "valueString": "ServiceProduct"
                }
              ],
              "strength": "example",
              "description": "Allowable service and product codes.",
              "valueSet": "http://hl7.org/fhir/ValueSet/service-uscls"
            }
          },
          {
            "id": "ClaimResponse.addItem.detail.subDetail.modifier",
            "path": "ClaimResponse.addItem.detail.subDetail.modifier",
            "short": "Service/Product billing modifiers",
            "definition": "Item typification or modifiers codes to convey additional context for the product or service.",
            "comment": "For example in Oral whether the treatment is cosmetic or associated with TMJ, or for Medical whether the treatment was outside the clinic or outside of office hours.",
            "requirements": "To support inclusion of the item for adjudication or to charge an elevated fee.",
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
            "id": "ClaimResponse.addItem.detail.subDetail.quantity",
            "path": "ClaimResponse.addItem.detail.subDetail.quantity",
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
            "id": "ClaimResponse.addItem.detail.subDetail.unitPrice",
            "path": "ClaimResponse.addItem.detail.subDetail.unitPrice",
            "short": "Fee, charge or cost per item",
            "definition": "If the item is not a group then this is the fee for the product or service, otherwise this is the total of the fees for the details of the group.",
            "requirements": "The amount charged to the patient by the provider for a single unit.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Money"
              }
            ]
          },
          {
            "id": "ClaimResponse.addItem.detail.subDetail.factor",
            "path": "ClaimResponse.addItem.detail.subDetail.factor",
            "short": "Price scaling factor",
            "definition": "A real number that represents a multiplier used in determining the overall value of services delivered and/or goods received. The concept of a Factor allows for a discount or surcharge multiplier to be applied to a monetary amount.",
            "comment": "To show a 10% senior's discount, the value entered is: 0.90 (1.00 - 0.10).",
            "requirements": "When discounts are provided to a patient (example: Senior's discount) then this must be documented for adjudication.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "decimal"
              }
            ]
          },
          {
            "id": "ClaimResponse.addItem.detail.subDetail.net",
            "path": "ClaimResponse.addItem.detail.subDetail.net",
            "short": "Total item cost",
            "definition": "The quantity times the unit price for an additional service or product or charge.",
            "comment": "For example, the formula: quantity * unitPrice * factor  = net. Quantity and factor are assumed to be 1 if not supplied.",
            "requirements": "Provides the total amount claimed  for the group (if a grouper) or the line item.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Money"
              }
            ]
          },
          {
            "id": "ClaimResponse.addItem.detail.subDetail.noteNumber",
            "path": "ClaimResponse.addItem.detail.subDetail.noteNumber",
            "short": "Applicable note numbers",
            "definition": "The numbers associated with notes below which apply to the adjudication of this item.",
            "requirements": "Provides a condensed manner for associating human readable descriptive explanations for adjudications on the line item.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "positiveInt"
              }
            ]
          },
          {
            "id": "ClaimResponse.addItem.detail.subDetail.adjudication",
            "path": "ClaimResponse.addItem.detail.subDetail.adjudication",
            "short": "Added items detail adjudication",
            "definition": "The adjudication results.",
            "min": 1,
            "max": "*",
            "contentReference": "#ClaimResponse.item.adjudication"
          },
          {
            "id": "ClaimResponse.adjudication",
            "path": "ClaimResponse.adjudication",
            "short": "Header-level adjudication",
            "definition": "The adjudication results which are presented at the header level rather than at the line-item or add-item levels.",
            "requirements": "Some insurers will receive line-items but provide the adjudication only at a summary or header-level.",
            "min": 0,
            "max": "*",
            "contentReference": "#ClaimResponse.item.adjudication"
          },
          {
            "id": "ClaimResponse.total",
            "path": "ClaimResponse.total",
            "short": "Adjudication totals",
            "definition": "Categorized monetary totals for the adjudication.",
            "comment": "Totals for amounts submitted, co-pays, benefits payable etc.",
            "requirements": "To provide the requestor with financial totals by category for the adjudication.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ClaimResponse.total.category",
            "path": "ClaimResponse.total.category",
            "short": "Type of adjudication information",
            "definition": "A code to indicate the information type of this adjudication record. Information types may include: the value submitted, maximum values or percentages allowed or payable under the plan, amounts that the patient is responsible for in aggregate or pertaining to this item, amounts paid by other coverages, and the benefit payable for this item.",
            "comment": "For example codes indicating: Co-Pay, deductible, eligible, benefit, tax, etc.",
            "requirements": "Needed to convey the type of total provided.",
            "min": 1,
            "max": "1",
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
                  "valueString": "Adjudication"
                }
              ],
              "strength": "example",
              "description": "The adjudication codes.",
              "valueSet": "http://hl7.org/fhir/ValueSet/adjudication"
            }
          },
          {
            "id": "ClaimResponse.total.amount",
            "path": "ClaimResponse.total.amount",
            "short": "Financial total for the category",
            "definition": "Monetary total amount associated with the category.",
            "requirements": "Needed to convey the total monetary amount.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Money"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ClaimResponse.payment",
            "path": "ClaimResponse.payment",
            "short": "Payment Details",
            "definition": "Payment details for the adjudication of the claim.",
            "requirements": "Needed to convey references to the financial instrument that has been used if payment has been made.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ClaimResponse.payment.type",
            "path": "ClaimResponse.payment.type",
            "short": "Partial or complete payment",
            "definition": "Whether this represents partial or complete payment of the benefits payable.",
            "requirements": "To advise the requestor when the insurer believes all payments to have been completed.",
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
                  "valueString": "PaymentType"
                }
              ],
              "strength": "example",
              "description": "The type (partial, complete) of the payment.",
              "valueSet": "http://hl7.org/fhir/ValueSet/ex-paymenttype"
            }
          },
          {
            "id": "ClaimResponse.payment.adjustment",
            "path": "ClaimResponse.payment.adjustment",
            "short": "Payment adjustment for non-claim issues",
            "definition": "Total amount of all adjustments to this payment included in this transaction which are not related to this claim's adjudication.",
            "comment": "Insurers will deduct amounts owing from the provider (adjustment), such as a prior overpayment, from the amount owing to the provider (benefits payable) when payment is made to the provider.",
            "requirements": "To advise the requestor of adjustments applied to the payment.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Money"
              }
            ]
          },
          {
            "id": "ClaimResponse.payment.adjustmentReason",
            "path": "ClaimResponse.payment.adjustmentReason",
            "short": "Explanation for the adjustment",
            "definition": "Reason for the payment adjustment.",
            "requirements": "Needed to clarify the monetary adjustment.",
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
                  "valueString": "PaymentAdjustmentReason"
                }
              ],
              "strength": "example",
              "description": "Payment Adjustment reason codes.",
              "valueSet": "http://hl7.org/fhir/ValueSet/payment-adjustment-reason"
            }
          },
          {
            "id": "ClaimResponse.payment.date",
            "path": "ClaimResponse.payment.date",
            "short": "Expected date of payment",
            "definition": "Estimated date the payment will be issued or the actual issue date of payment.",
            "requirements": "To advise the payee when payment can be expected.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "date"
              }
            ]
          },
          {
            "id": "ClaimResponse.payment.amount",
            "path": "ClaimResponse.payment.amount",
            "short": "Payable amount after adjustment",
            "definition": "Benefits payable less any payment adjustment.",
            "requirements": "Needed to provide the actual payment amount.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Money"
              }
            ]
          },
          {
            "id": "ClaimResponse.payment.identifier",
            "path": "ClaimResponse.payment.identifier",
            "short": "Business identifier for the payment",
            "definition": "Issuer's unique identifier for the payment instrument.",
            "comment": "For example: EFT number or check number.",
            "requirements": "Enable the receiver to reconcile when payment received.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Identifier"
              }
            ]
          },
          {
            "id": "ClaimResponse.fundsReserve",
            "path": "ClaimResponse.fundsReserve",
            "short": "Funds reserved status",
            "definition": "A code, used only on a response to a preauthorization, to indicate whether the benefits payable have been reserved and for whom.",
            "comment": "Fund would be release by a future claim quoting the preAuthRef of this response. Examples of values include: provider, patient, none.",
            "requirements": "Needed to advise the submitting provider on whether the rquest for reservation of funds has been honored.",
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
                  "valueString": "FundsReserve"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "example",
              "description": "For whom funds are to be reserved: (Patient, Provider, None).",
              "valueSet": "http://hl7.org/fhir/ValueSet/fundsreserve"
            }
          },
          {
            "id": "ClaimResponse.formCode",
            "path": "ClaimResponse.formCode",
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
            "id": "ClaimResponse.form",
            "path": "ClaimResponse.form",
            "short": "Printed reference or actual form",
            "definition": "The actual form, by reference or inclusion, for printing the content or an EOB.",
            "comment": "Needed to permit insurers to include the actual form.",
            "requirements": "Needed to include the specific form used for producing output for this response.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Attachment"
              }
            ]
          },
          {
            "id": "ClaimResponse.processNote",
            "path": "ClaimResponse.processNote",
            "short": "Note concerning adjudication",
            "definition": "A note that describes or explains adjudication results in a human readable form.",
            "requirements": "Provides the insurer specific textual explanations associated with the processing.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ClaimResponse.processNote.number",
            "path": "ClaimResponse.processNote.number",
            "short": "Note instance identifier",
            "definition": "A number to uniquely identify a note entry.",
            "requirements": "Necessary to provide a mechanism to link from adjudications.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "positiveInt"
              }
            ]
          },
          {
            "id": "ClaimResponse.processNote.type",
            "path": "ClaimResponse.processNote.type",
            "short": "display | print | printoper",
            "definition": "The business purpose of the note text.",
            "requirements": "To convey the expectation for when the text is used.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "NoteType"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "required",
              "description": "The presentation types of notes.",
              "valueSet": "http://hl7.org/fhir/ValueSet/note-type|4.0.0"
            }
          },
          {
            "id": "ClaimResponse.processNote.text",
            "path": "ClaimResponse.processNote.text",
            "short": "Note explanatory text",
            "definition": "The explanation or description associated with the processing.",
            "requirements": "Required to provide human readable explanation.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ClaimResponse.processNote.language",
            "path": "ClaimResponse.processNote.language",
            "short": "Language of the text",
            "definition": "A code to define the language used in the text of the note.",
            "comment": "Only required if the language is different from the resource language.",
            "requirements": "Note text may vary from the resource defined language.",
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
            "id": "ClaimResponse.communicationRequest",
            "path": "ClaimResponse.communicationRequest",
            "short": "Request for additional information",
            "definition": "Request for additional supporting or authorizing information.",
            "comment": "For example: professional reports, documents, images, clinical resources, or accident reports.",
            "requirements": "Need to communicate insurer request for additional information required to support the adjudication.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/CommunicationRequest"
                ]
              }
            ]
          },
          {
            "id": "ClaimResponse.insurance",
            "path": "ClaimResponse.insurance",
            "short": "Patient insurance information",
            "definition": "Financial instruments for reimbursement for the health care products and services specified on the claim.",
            "comment": "All insurance coverages for the patient which may be applicable for reimbursement, of the products and services listed in the claim, are typically provided in the claim to allow insurers to confirm the ordering of the insurance coverages relative to local 'coordination of benefit' rules. One coverage (and only one) with 'focal=true' is to be used in the adjudication of this claim. Coverages appearing before the focal Coverage in the list, and where 'subrogation=false', should provide a reference to the ClaimResponse containing the adjudication results of the prior claim.",
            "requirements": "At least one insurer is required for a claim to be a claim.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ClaimResponse.insurance.sequence",
            "path": "ClaimResponse.insurance.sequence",
            "short": "Insurance instance identifier",
            "definition": "A number to uniquely identify insurance entries and provide a sequence of coverages to convey coordination of benefit order.",
            "requirements": "To maintain order of the coverages.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "positiveInt"
              }
            ]
          },
          {
            "id": "ClaimResponse.insurance.focal",
            "path": "ClaimResponse.insurance.focal",
            "short": "Coverage to be used for adjudication",
            "definition": "A flag to indicate that this Coverage is to be used for adjudication of this claim when set to true.",
            "comment": "A patient may (will) have multiple insurance policies which provide reimbursement for healthcare services and products. For example a person may also be covered by their spouse's policy and both appear in the list (and may be from the same insurer). This flag will be set to true for only one of the listed policies and that policy will be used for adjudicating this claim. Other claims would be created to request adjudication against the other listed policies.",
            "requirements": "To identify which coverage in the list is being used to adjudicate this claim.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ]
          },
          {
            "id": "ClaimResponse.insurance.coverage",
            "path": "ClaimResponse.insurance.coverage",
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
            "id": "ClaimResponse.insurance.businessArrangement",
            "path": "ClaimResponse.insurance.businessArrangement",
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
            "id": "ClaimResponse.insurance.claimResponse",
            "path": "ClaimResponse.insurance.claimResponse",
            "short": "Adjudication results",
            "definition": "The result of the adjudication of the line items for the Coverage specified in this insurance.",
            "comment": "Must not be specified when 'focal=true' for this insurance.",
            "requirements": "An insurer need the adjudication results from prior insurers to determine the outstanding balance remaining by item for the items in the curent claim.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/ClaimResponse"
                ]
              }
            ]
          },
          {
            "id": "ClaimResponse.error",
            "path": "ClaimResponse.error",
            "short": "Processing errors",
            "definition": "Errors encountered during the processing of the adjudication.",
            "comment": "If the request contains errors then an error element should be provided and no adjudication related sections (item, addItem, or payment) should be present.",
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
            "id": "ClaimResponse.error.itemSequence",
            "path": "ClaimResponse.error.itemSequence",
            "short": "Item sequence number",
            "definition": "The sequence number of the line item submitted which contains the error. This value is omitted when the error occurs outside of the item structure.",
            "requirements": "Provides references to the claim items.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "positiveInt"
              }
            ]
          },
          {
            "id": "ClaimResponse.error.detailSequence",
            "path": "ClaimResponse.error.detailSequence",
            "short": "Detail sequence number",
            "definition": "The sequence number of the detail within the line item submitted which contains the error. This value is omitted when the error occurs outside of the item structure.",
            "requirements": "Provides references to the claim details within the claim item.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "positiveInt"
              }
            ]
          },
          {
            "id": "ClaimResponse.error.subDetailSequence",
            "path": "ClaimResponse.error.subDetailSequence",
            "short": "Subdetail sequence number",
            "definition": "The sequence number of the sub-detail within the detail within the line item submitted which contains the error. This value is omitted when the error occurs outside of the item structure.",
            "requirements": "Provides references to the claim sub-details within the claim detail.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "positiveInt"
              }
            ]
          },
          {
            "id": "ClaimResponse.error.code",
            "path": "ClaimResponse.error.code",
            "short": "Error code detailing processing issues",
            "definition": "An error code, from a specified code system, which details why the claim could not be adjudicated.",
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
                }
              ],
              "strength": "example",
              "description": "The adjudication error codes.",
              "valueSet": "http://hl7.org/fhir/ValueSet/adjudication-error"
            }
          }
        ]
      }
    }
    #endif
    #endregion
    /// <summary>
    /// Fhir resource 'ClaimResponse'
    /// </summary>
    // 0. ClaimResponse
    public class Resource_ClaimResponse : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 16. ClaimResponse.item
        public class Type_Item : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 19. ClaimResponse.item.adjudication
            public class Type_Adjudication : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 20. ClaimResponse.item.adjudication.category
                public ElementDefinitionInfo Element_Category;
                // 21. ClaimResponse.item.adjudication.reason
                public ElementDefinitionInfo Element_Reason;
                // 22. ClaimResponse.item.adjudication.amount
                public ElementDefinitionInfo Element_Amount;
                // 23. ClaimResponse.item.adjudication.value
                public ElementDefinitionInfo Element_Value;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "ClaimResponse.item.adjudication",
                        ElementId = "ClaimResponse.item.adjudication"
                    });
                    Element_Category.Write(sDef);
                    Element_Reason.Write(sDef);
                    Element_Amount.Write(sDef);
                    Element_Value.Write(sDef);
                }
                
                public Type_Adjudication()
                {
                    {
                        // 20. ClaimResponse.item.adjudication.category
                        this.Element_Category = new ElementDefinitionInfo
                        {
                            Name = "Element_Category",
                            Path= "ClaimResponse.item.adjudication.category",
                            Id = "ClaimResponse.item.adjudication.category",
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
                        // 21. ClaimResponse.item.adjudication.reason
                        this.Element_Reason = new ElementDefinitionInfo
                        {
                            Name = "Element_Reason",
                            Path= "ClaimResponse.item.adjudication.reason",
                            Id = "ClaimResponse.item.adjudication.reason",
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
                        // 22. ClaimResponse.item.adjudication.amount
                        this.Element_Amount = new ElementDefinitionInfo
                        {
                            Name = "Element_Amount",
                            Path= "ClaimResponse.item.adjudication.amount",
                            Id = "ClaimResponse.item.adjudication.amount",
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
                        // 23. ClaimResponse.item.adjudication.value
                        this.Element_Value = new ElementDefinitionInfo
                        {
                            Name = "Element_Value",
                            Path= "ClaimResponse.item.adjudication.value",
                            Id = "ClaimResponse.item.adjudication.value",
                            Min = 0,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_Decimal
                                {
                                }
                            }
                        };
                    }
                }
            }
            // 24. ClaimResponse.item.detail
            public class Type_Detail : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 28. ClaimResponse.item.detail.subDetail
                public class Type_SubDetail : FhirKhit.Maker.Common.Complex.ComplexBase
                {
                    // 29. ClaimResponse.item.detail.subDetail.subDetailSequence
                    public ElementDefinitionInfo Element_SubDetailSequence;
                    // 30. ClaimResponse.item.detail.subDetail.noteNumber
                    public ElementDefinitionInfo Element_NoteNumber;
                    // 31. ClaimResponse.item.detail.subDetail.adjudication
                    public ElementDefinitionInfo Element_Adjudication;
                    
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                    {
                        base.Write(sDef);
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                        {
                            Path = "ClaimResponse.item.detail.subDetail",
                            ElementId = "ClaimResponse.item.detail.subDetail"
                        });
                        Element_SubDetailSequence.Write(sDef);
                        Element_NoteNumber.Write(sDef);
                        Element_Adjudication.Write(sDef);
                    }
                    
                    public Type_SubDetail()
                    {
                        {
                            // 29. ClaimResponse.item.detail.subDetail.subDetailSequence
                            this.Element_SubDetailSequence = new ElementDefinitionInfo
                            {
                                Name = "Element_SubDetailSequence",
                                Path= "ClaimResponse.item.detail.subDetail.subDetailSequence",
                                Id = "ClaimResponse.item.detail.subDetail.subDetailSequence",
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
                            // 30. ClaimResponse.item.detail.subDetail.noteNumber
                            this.Element_NoteNumber = new ElementDefinitionInfo
                            {
                                Name = "Element_NoteNumber",
                                Path= "ClaimResponse.item.detail.subDetail.noteNumber",
                                Id = "ClaimResponse.item.detail.subDetail.noteNumber",
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
                            // 31. ClaimResponse.item.detail.subDetail.adjudication
                            this.Element_Adjudication = new ElementDefinitionInfo
                            {
                                Name = "Element_Adjudication",
                                Path= "ClaimResponse.item.detail.subDetail.adjudication",
                                Id = "ClaimResponse.item.detail.subDetail.adjudication",
                                Min = 0,
                                Max = -1,
                                Types = new BaseType[]
                                {
                                }
                            };
                        }
                    }
                }
                // 25. ClaimResponse.item.detail.detailSequence
                public ElementDefinitionInfo Element_DetailSequence;
                // 26. ClaimResponse.item.detail.noteNumber
                public ElementDefinitionInfo Element_NoteNumber;
                // 27. ClaimResponse.item.detail.adjudication
                public ElementDefinitionInfo Element_Adjudication;
                // 28. ClaimResponse.item.detail.subDetail
                public ElementDefinitionInfo Element_SubDetail;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "ClaimResponse.item.detail",
                        ElementId = "ClaimResponse.item.detail"
                    });
                    Element_DetailSequence.Write(sDef);
                    Element_NoteNumber.Write(sDef);
                    Element_Adjudication.Write(sDef);
                    Element_SubDetail.Write(sDef);
                }
                
                public Type_Detail()
                {
                    {
                        // 25. ClaimResponse.item.detail.detailSequence
                        this.Element_DetailSequence = new ElementDefinitionInfo
                        {
                            Name = "Element_DetailSequence",
                            Path= "ClaimResponse.item.detail.detailSequence",
                            Id = "ClaimResponse.item.detail.detailSequence",
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
                        // 26. ClaimResponse.item.detail.noteNumber
                        this.Element_NoteNumber = new ElementDefinitionInfo
                        {
                            Name = "Element_NoteNumber",
                            Path= "ClaimResponse.item.detail.noteNumber",
                            Id = "ClaimResponse.item.detail.noteNumber",
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
                        // 27. ClaimResponse.item.detail.adjudication
                        this.Element_Adjudication = new ElementDefinitionInfo
                        {
                            Name = "Element_Adjudication",
                            Path= "ClaimResponse.item.detail.adjudication",
                            Id = "ClaimResponse.item.detail.adjudication",
                            Min = 1,
                            Max = -1,
                            Types = new BaseType[]
                            {
                            }
                        };
                    }
                    {
                        // 28. ClaimResponse.item.detail.subDetail
                        this.Element_SubDetail = new ElementDefinitionInfo
                        {
                            Name = "Element_SubDetail",
                            Path= "ClaimResponse.item.detail.subDetail",
                            Id = "ClaimResponse.item.detail.subDetail",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                                new Type_SubDetail
                                {
                                }
                            }
                        };
                    }
                }
            }
            // 17. ClaimResponse.item.itemSequence
            public ElementDefinitionInfo Element_ItemSequence;
            // 18. ClaimResponse.item.noteNumber
            public ElementDefinitionInfo Element_NoteNumber;
            // 19. ClaimResponse.item.adjudication
            public ElementDefinitionInfo Element_Adjudication;
            // 24. ClaimResponse.item.detail
            public ElementDefinitionInfo Element_Detail;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "ClaimResponse.item",
                    ElementId = "ClaimResponse.item"
                });
                Element_ItemSequence.Write(sDef);
                Element_NoteNumber.Write(sDef);
                Element_Adjudication.Write(sDef);
                Element_Detail.Write(sDef);
            }
            
            public Type_Item()
            {
                {
                    // 17. ClaimResponse.item.itemSequence
                    this.Element_ItemSequence = new ElementDefinitionInfo
                    {
                        Name = "Element_ItemSequence",
                        Path= "ClaimResponse.item.itemSequence",
                        Id = "ClaimResponse.item.itemSequence",
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
                    // 18. ClaimResponse.item.noteNumber
                    this.Element_NoteNumber = new ElementDefinitionInfo
                    {
                        Name = "Element_NoteNumber",
                        Path= "ClaimResponse.item.noteNumber",
                        Id = "ClaimResponse.item.noteNumber",
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
                    // 19. ClaimResponse.item.adjudication
                    this.Element_Adjudication = new ElementDefinitionInfo
                    {
                        Name = "Element_Adjudication",
                        Path= "ClaimResponse.item.adjudication",
                        Id = "ClaimResponse.item.adjudication",
                        Min = 1,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Adjudication
                            {
                            }
                        }
                    };
                }
                {
                    // 24. ClaimResponse.item.detail
                    this.Element_Detail = new ElementDefinitionInfo
                    {
                        Name = "Element_Detail",
                        Path= "ClaimResponse.item.detail",
                        Id = "ClaimResponse.item.detail",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Detail
                            {
                            }
                        }
                    };
                }
            }
        }
        // 32. ClaimResponse.addItem
        public class Type_AddItem : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 50. ClaimResponse.addItem.detail
            public class Type_Detail : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 59. ClaimResponse.addItem.detail.subDetail
                public class Type_SubDetail : FhirKhit.Maker.Common.Complex.ComplexBase
                {
                    // 60. ClaimResponse.addItem.detail.subDetail.productOrService
                    public ElementDefinitionInfo Element_ProductOrService;
                    // 61. ClaimResponse.addItem.detail.subDetail.modifier
                    public ElementDefinitionInfo Element_Modifier;
                    // 62. ClaimResponse.addItem.detail.subDetail.quantity
                    public ElementDefinitionInfo Element_Quantity;
                    // 63. ClaimResponse.addItem.detail.subDetail.unitPrice
                    public ElementDefinitionInfo Element_UnitPrice;
                    // 64. ClaimResponse.addItem.detail.subDetail.factor
                    public ElementDefinitionInfo Element_Factor;
                    // 65. ClaimResponse.addItem.detail.subDetail.net
                    public ElementDefinitionInfo Element_Net;
                    // 66. ClaimResponse.addItem.detail.subDetail.noteNumber
                    public ElementDefinitionInfo Element_NoteNumber;
                    // 67. ClaimResponse.addItem.detail.subDetail.adjudication
                    public ElementDefinitionInfo Element_Adjudication;
                    
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                    {
                        base.Write(sDef);
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                        {
                            Path = "ClaimResponse.addItem.detail.subDetail",
                            ElementId = "ClaimResponse.addItem.detail.subDetail"
                        });
                        Element_ProductOrService.Write(sDef);
                        Element_Modifier.Write(sDef);
                        Element_Quantity.Write(sDef);
                        Element_UnitPrice.Write(sDef);
                        Element_Factor.Write(sDef);
                        Element_Net.Write(sDef);
                        Element_NoteNumber.Write(sDef);
                        Element_Adjudication.Write(sDef);
                    }
                    
                    public Type_SubDetail()
                    {
                        {
                            // 60. ClaimResponse.addItem.detail.subDetail.productOrService
                            this.Element_ProductOrService = new ElementDefinitionInfo
                            {
                                Name = "Element_ProductOrService",
                                Path= "ClaimResponse.addItem.detail.subDetail.productOrService",
                                Id = "ClaimResponse.addItem.detail.subDetail.productOrService",
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
                            // 61. ClaimResponse.addItem.detail.subDetail.modifier
                            this.Element_Modifier = new ElementDefinitionInfo
                            {
                                Name = "Element_Modifier",
                                Path= "ClaimResponse.addItem.detail.subDetail.modifier",
                                Id = "ClaimResponse.addItem.detail.subDetail.modifier",
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
                            // 62. ClaimResponse.addItem.detail.subDetail.quantity
                            this.Element_Quantity = new ElementDefinitionInfo
                            {
                                Name = "Element_Quantity",
                                Path= "ClaimResponse.addItem.detail.subDetail.quantity",
                                Id = "ClaimResponse.addItem.detail.subDetail.quantity",
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
                            // 63. ClaimResponse.addItem.detail.subDetail.unitPrice
                            this.Element_UnitPrice = new ElementDefinitionInfo
                            {
                                Name = "Element_UnitPrice",
                                Path= "ClaimResponse.addItem.detail.subDetail.unitPrice",
                                Id = "ClaimResponse.addItem.detail.subDetail.unitPrice",
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
                            // 64. ClaimResponse.addItem.detail.subDetail.factor
                            this.Element_Factor = new ElementDefinitionInfo
                            {
                                Name = "Element_Factor",
                                Path= "ClaimResponse.addItem.detail.subDetail.factor",
                                Id = "ClaimResponse.addItem.detail.subDetail.factor",
                                Min = 0,
                                Max = 1,
                                Types = new BaseType[]
                                {
                                    new FhirKhit.Maker.Common.Primitive.Primitive_Decimal
                                    {
                                    }
                                }
                            };
                        }
                        {
                            // 65. ClaimResponse.addItem.detail.subDetail.net
                            this.Element_Net = new ElementDefinitionInfo
                            {
                                Name = "Element_Net",
                                Path= "ClaimResponse.addItem.detail.subDetail.net",
                                Id = "ClaimResponse.addItem.detail.subDetail.net",
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
                            // 66. ClaimResponse.addItem.detail.subDetail.noteNumber
                            this.Element_NoteNumber = new ElementDefinitionInfo
                            {
                                Name = "Element_NoteNumber",
                                Path= "ClaimResponse.addItem.detail.subDetail.noteNumber",
                                Id = "ClaimResponse.addItem.detail.subDetail.noteNumber",
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
                            // 67. ClaimResponse.addItem.detail.subDetail.adjudication
                            this.Element_Adjudication = new ElementDefinitionInfo
                            {
                                Name = "Element_Adjudication",
                                Path= "ClaimResponse.addItem.detail.subDetail.adjudication",
                                Id = "ClaimResponse.addItem.detail.subDetail.adjudication",
                                Min = 1,
                                Max = -1,
                                Types = new BaseType[]
                                {
                                }
                            };
                        }
                    }
                }
                // 51. ClaimResponse.addItem.detail.productOrService
                public ElementDefinitionInfo Element_ProductOrService;
                // 52. ClaimResponse.addItem.detail.modifier
                public ElementDefinitionInfo Element_Modifier;
                // 53. ClaimResponse.addItem.detail.quantity
                public ElementDefinitionInfo Element_Quantity;
                // 54. ClaimResponse.addItem.detail.unitPrice
                public ElementDefinitionInfo Element_UnitPrice;
                // 55. ClaimResponse.addItem.detail.factor
                public ElementDefinitionInfo Element_Factor;
                // 56. ClaimResponse.addItem.detail.net
                public ElementDefinitionInfo Element_Net;
                // 57. ClaimResponse.addItem.detail.noteNumber
                public ElementDefinitionInfo Element_NoteNumber;
                // 58. ClaimResponse.addItem.detail.adjudication
                public ElementDefinitionInfo Element_Adjudication;
                // 59. ClaimResponse.addItem.detail.subDetail
                public ElementDefinitionInfo Element_SubDetail;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "ClaimResponse.addItem.detail",
                        ElementId = "ClaimResponse.addItem.detail"
                    });
                    Element_ProductOrService.Write(sDef);
                    Element_Modifier.Write(sDef);
                    Element_Quantity.Write(sDef);
                    Element_UnitPrice.Write(sDef);
                    Element_Factor.Write(sDef);
                    Element_Net.Write(sDef);
                    Element_NoteNumber.Write(sDef);
                    Element_Adjudication.Write(sDef);
                    Element_SubDetail.Write(sDef);
                }
                
                public Type_Detail()
                {
                    {
                        // 51. ClaimResponse.addItem.detail.productOrService
                        this.Element_ProductOrService = new ElementDefinitionInfo
                        {
                            Name = "Element_ProductOrService",
                            Path= "ClaimResponse.addItem.detail.productOrService",
                            Id = "ClaimResponse.addItem.detail.productOrService",
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
                        // 52. ClaimResponse.addItem.detail.modifier
                        this.Element_Modifier = new ElementDefinitionInfo
                        {
                            Name = "Element_Modifier",
                            Path= "ClaimResponse.addItem.detail.modifier",
                            Id = "ClaimResponse.addItem.detail.modifier",
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
                        // 53. ClaimResponse.addItem.detail.quantity
                        this.Element_Quantity = new ElementDefinitionInfo
                        {
                            Name = "Element_Quantity",
                            Path= "ClaimResponse.addItem.detail.quantity",
                            Id = "ClaimResponse.addItem.detail.quantity",
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
                        // 54. ClaimResponse.addItem.detail.unitPrice
                        this.Element_UnitPrice = new ElementDefinitionInfo
                        {
                            Name = "Element_UnitPrice",
                            Path= "ClaimResponse.addItem.detail.unitPrice",
                            Id = "ClaimResponse.addItem.detail.unitPrice",
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
                        // 55. ClaimResponse.addItem.detail.factor
                        this.Element_Factor = new ElementDefinitionInfo
                        {
                            Name = "Element_Factor",
                            Path= "ClaimResponse.addItem.detail.factor",
                            Id = "ClaimResponse.addItem.detail.factor",
                            Min = 0,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_Decimal
                                {
                                }
                            }
                        };
                    }
                    {
                        // 56. ClaimResponse.addItem.detail.net
                        this.Element_Net = new ElementDefinitionInfo
                        {
                            Name = "Element_Net",
                            Path= "ClaimResponse.addItem.detail.net",
                            Id = "ClaimResponse.addItem.detail.net",
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
                        // 57. ClaimResponse.addItem.detail.noteNumber
                        this.Element_NoteNumber = new ElementDefinitionInfo
                        {
                            Name = "Element_NoteNumber",
                            Path= "ClaimResponse.addItem.detail.noteNumber",
                            Id = "ClaimResponse.addItem.detail.noteNumber",
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
                        // 58. ClaimResponse.addItem.detail.adjudication
                        this.Element_Adjudication = new ElementDefinitionInfo
                        {
                            Name = "Element_Adjudication",
                            Path= "ClaimResponse.addItem.detail.adjudication",
                            Id = "ClaimResponse.addItem.detail.adjudication",
                            Min = 1,
                            Max = -1,
                            Types = new BaseType[]
                            {
                            }
                        };
                    }
                    {
                        // 59. ClaimResponse.addItem.detail.subDetail
                        this.Element_SubDetail = new ElementDefinitionInfo
                        {
                            Name = "Element_SubDetail",
                            Path= "ClaimResponse.addItem.detail.subDetail",
                            Id = "ClaimResponse.addItem.detail.subDetail",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                                new Type_SubDetail
                                {
                                }
                            }
                        };
                    }
                }
            }
            // 33. ClaimResponse.addItem.itemSequence
            public ElementDefinitionInfo Element_ItemSequence;
            // 34. ClaimResponse.addItem.detailSequence
            public ElementDefinitionInfo Element_DetailSequence;
            // 35. ClaimResponse.addItem.subdetailSequence
            public ElementDefinitionInfo Element_SubdetailSequence;
            // 36. ClaimResponse.addItem.provider
            public ElementDefinitionInfo Element_Provider;
            // 37. ClaimResponse.addItem.productOrService
            public ElementDefinitionInfo Element_ProductOrService;
            // 38. ClaimResponse.addItem.modifier
            public ElementDefinitionInfo Element_Modifier;
            // 39. ClaimResponse.addItem.programCode
            public ElementDefinitionInfo Element_ProgramCode;
            // 40. ClaimResponse.addItem.serviced[x]
            public ElementDefinitionInfo Element_Serviced;
            // 41. ClaimResponse.addItem.location[x]
            public ElementDefinitionInfo Element_Location;
            // 42. ClaimResponse.addItem.quantity
            public ElementDefinitionInfo Element_Quantity;
            // 43. ClaimResponse.addItem.unitPrice
            public ElementDefinitionInfo Element_UnitPrice;
            // 44. ClaimResponse.addItem.factor
            public ElementDefinitionInfo Element_Factor;
            // 45. ClaimResponse.addItem.net
            public ElementDefinitionInfo Element_Net;
            // 46. ClaimResponse.addItem.bodySite
            public ElementDefinitionInfo Element_BodySite;
            // 47. ClaimResponse.addItem.subSite
            public ElementDefinitionInfo Element_SubSite;
            // 48. ClaimResponse.addItem.noteNumber
            public ElementDefinitionInfo Element_NoteNumber;
            // 49. ClaimResponse.addItem.adjudication
            public ElementDefinitionInfo Element_Adjudication;
            // 50. ClaimResponse.addItem.detail
            public ElementDefinitionInfo Element_Detail;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "ClaimResponse.addItem",
                    ElementId = "ClaimResponse.addItem"
                });
                Element_ItemSequence.Write(sDef);
                Element_DetailSequence.Write(sDef);
                Element_SubdetailSequence.Write(sDef);
                Element_Provider.Write(sDef);
                Element_ProductOrService.Write(sDef);
                Element_Modifier.Write(sDef);
                Element_ProgramCode.Write(sDef);
                Element_Serviced.Write(sDef);
                Element_Location.Write(sDef);
                Element_Quantity.Write(sDef);
                Element_UnitPrice.Write(sDef);
                Element_Factor.Write(sDef);
                Element_Net.Write(sDef);
                Element_BodySite.Write(sDef);
                Element_SubSite.Write(sDef);
                Element_NoteNumber.Write(sDef);
                Element_Adjudication.Write(sDef);
                Element_Detail.Write(sDef);
            }
            
            public Type_AddItem()
            {
                {
                    // 33. ClaimResponse.addItem.itemSequence
                    this.Element_ItemSequence = new ElementDefinitionInfo
                    {
                        Name = "Element_ItemSequence",
                        Path= "ClaimResponse.addItem.itemSequence",
                        Id = "ClaimResponse.addItem.itemSequence",
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
                    // 34. ClaimResponse.addItem.detailSequence
                    this.Element_DetailSequence = new ElementDefinitionInfo
                    {
                        Name = "Element_DetailSequence",
                        Path= "ClaimResponse.addItem.detailSequence",
                        Id = "ClaimResponse.addItem.detailSequence",
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
                    // 35. ClaimResponse.addItem.subdetailSequence
                    this.Element_SubdetailSequence = new ElementDefinitionInfo
                    {
                        Name = "Element_SubdetailSequence",
                        Path= "ClaimResponse.addItem.subdetailSequence",
                        Id = "ClaimResponse.addItem.subdetailSequence",
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
                    // 36. ClaimResponse.addItem.provider
                    this.Element_Provider = new ElementDefinitionInfo
                    {
                        Name = "Element_Provider",
                        Path= "ClaimResponse.addItem.provider",
                        Id = "ClaimResponse.addItem.provider",
                        Min = 0,
                        Max = -1,
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
                    // 37. ClaimResponse.addItem.productOrService
                    this.Element_ProductOrService = new ElementDefinitionInfo
                    {
                        Name = "Element_ProductOrService",
                        Path= "ClaimResponse.addItem.productOrService",
                        Id = "ClaimResponse.addItem.productOrService",
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
                    // 38. ClaimResponse.addItem.modifier
                    this.Element_Modifier = new ElementDefinitionInfo
                    {
                        Name = "Element_Modifier",
                        Path= "ClaimResponse.addItem.modifier",
                        Id = "ClaimResponse.addItem.modifier",
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
                    // 39. ClaimResponse.addItem.programCode
                    this.Element_ProgramCode = new ElementDefinitionInfo
                    {
                        Name = "Element_ProgramCode",
                        Path= "ClaimResponse.addItem.programCode",
                        Id = "ClaimResponse.addItem.programCode",
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
                    // 40. ClaimResponse.addItem.serviced[x]
                    this.Element_Serviced = new ElementDefinitionInfo
                    {
                        Name = "Element_Serviced",
                        Path= "ClaimResponse.addItem.serviced[x]",
                        Id = "ClaimResponse.addItem.serviced[x]",
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
                    // 41. ClaimResponse.addItem.location[x]
                    this.Element_Location = new ElementDefinitionInfo
                    {
                        Name = "Element_Location",
                        Path= "ClaimResponse.addItem.location[x]",
                        Id = "ClaimResponse.addItem.location[x]",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Address
                            {
                            },
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
                    // 42. ClaimResponse.addItem.quantity
                    this.Element_Quantity = new ElementDefinitionInfo
                    {
                        Name = "Element_Quantity",
                        Path= "ClaimResponse.addItem.quantity",
                        Id = "ClaimResponse.addItem.quantity",
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
                    // 43. ClaimResponse.addItem.unitPrice
                    this.Element_UnitPrice = new ElementDefinitionInfo
                    {
                        Name = "Element_UnitPrice",
                        Path= "ClaimResponse.addItem.unitPrice",
                        Id = "ClaimResponse.addItem.unitPrice",
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
                    // 44. ClaimResponse.addItem.factor
                    this.Element_Factor = new ElementDefinitionInfo
                    {
                        Name = "Element_Factor",
                        Path= "ClaimResponse.addItem.factor",
                        Id = "ClaimResponse.addItem.factor",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Decimal
                            {
                            }
                        }
                    };
                }
                {
                    // 45. ClaimResponse.addItem.net
                    this.Element_Net = new ElementDefinitionInfo
                    {
                        Name = "Element_Net",
                        Path= "ClaimResponse.addItem.net",
                        Id = "ClaimResponse.addItem.net",
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
                    // 46. ClaimResponse.addItem.bodySite
                    this.Element_BodySite = new ElementDefinitionInfo
                    {
                        Name = "Element_BodySite",
                        Path= "ClaimResponse.addItem.bodySite",
                        Id = "ClaimResponse.addItem.bodySite",
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
                    // 47. ClaimResponse.addItem.subSite
                    this.Element_SubSite = new ElementDefinitionInfo
                    {
                        Name = "Element_SubSite",
                        Path= "ClaimResponse.addItem.subSite",
                        Id = "ClaimResponse.addItem.subSite",
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
                    // 48. ClaimResponse.addItem.noteNumber
                    this.Element_NoteNumber = new ElementDefinitionInfo
                    {
                        Name = "Element_NoteNumber",
                        Path= "ClaimResponse.addItem.noteNumber",
                        Id = "ClaimResponse.addItem.noteNumber",
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
                    // 49. ClaimResponse.addItem.adjudication
                    this.Element_Adjudication = new ElementDefinitionInfo
                    {
                        Name = "Element_Adjudication",
                        Path= "ClaimResponse.addItem.adjudication",
                        Id = "ClaimResponse.addItem.adjudication",
                        Min = 1,
                        Max = -1,
                        Types = new BaseType[]
                        {
                        }
                    };
                }
                {
                    // 50. ClaimResponse.addItem.detail
                    this.Element_Detail = new ElementDefinitionInfo
                    {
                        Name = "Element_Detail",
                        Path= "ClaimResponse.addItem.detail",
                        Id = "ClaimResponse.addItem.detail",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Detail
                            {
                            }
                        }
                    };
                }
            }
        }
        // 69. ClaimResponse.total
        public class Type_Total : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 70. ClaimResponse.total.category
            public ElementDefinitionInfo Element_Category;
            // 71. ClaimResponse.total.amount
            public ElementDefinitionInfo Element_Amount;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "ClaimResponse.total",
                    ElementId = "ClaimResponse.total"
                });
                Element_Category.Write(sDef);
                Element_Amount.Write(sDef);
            }
            
            public Type_Total()
            {
                {
                    // 70. ClaimResponse.total.category
                    this.Element_Category = new ElementDefinitionInfo
                    {
                        Name = "Element_Category",
                        Path= "ClaimResponse.total.category",
                        Id = "ClaimResponse.total.category",
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
                    // 71. ClaimResponse.total.amount
                    this.Element_Amount = new ElementDefinitionInfo
                    {
                        Name = "Element_Amount",
                        Path= "ClaimResponse.total.amount",
                        Id = "ClaimResponse.total.amount",
                        Min = 1,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Money
                            {
                            }
                        }
                    };
                }
            }
        }
        // 72. ClaimResponse.payment
        public class Type_Payment : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 73. ClaimResponse.payment.type
            public ElementDefinitionInfo Element_Type;
            // 74. ClaimResponse.payment.adjustment
            public ElementDefinitionInfo Element_Adjustment;
            // 75. ClaimResponse.payment.adjustmentReason
            public ElementDefinitionInfo Element_AdjustmentReason;
            // 76. ClaimResponse.payment.date
            public ElementDefinitionInfo Element_Date;
            // 77. ClaimResponse.payment.amount
            public ElementDefinitionInfo Element_Amount;
            // 78. ClaimResponse.payment.identifier
            public ElementDefinitionInfo Element_Identifier;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "ClaimResponse.payment",
                    ElementId = "ClaimResponse.payment"
                });
                Element_Type.Write(sDef);
                Element_Adjustment.Write(sDef);
                Element_AdjustmentReason.Write(sDef);
                Element_Date.Write(sDef);
                Element_Amount.Write(sDef);
                Element_Identifier.Write(sDef);
            }
            
            public Type_Payment()
            {
                {
                    // 73. ClaimResponse.payment.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "ClaimResponse.payment.type",
                        Id = "ClaimResponse.payment.type",
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
                    // 74. ClaimResponse.payment.adjustment
                    this.Element_Adjustment = new ElementDefinitionInfo
                    {
                        Name = "Element_Adjustment",
                        Path= "ClaimResponse.payment.adjustment",
                        Id = "ClaimResponse.payment.adjustment",
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
                    // 75. ClaimResponse.payment.adjustmentReason
                    this.Element_AdjustmentReason = new ElementDefinitionInfo
                    {
                        Name = "Element_AdjustmentReason",
                        Path= "ClaimResponse.payment.adjustmentReason",
                        Id = "ClaimResponse.payment.adjustmentReason",
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
                    // 76. ClaimResponse.payment.date
                    this.Element_Date = new ElementDefinitionInfo
                    {
                        Name = "Element_Date",
                        Path= "ClaimResponse.payment.date",
                        Id = "ClaimResponse.payment.date",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Date
                            {
                            }
                        }
                    };
                }
                {
                    // 77. ClaimResponse.payment.amount
                    this.Element_Amount = new ElementDefinitionInfo
                    {
                        Name = "Element_Amount",
                        Path= "ClaimResponse.payment.amount",
                        Id = "ClaimResponse.payment.amount",
                        Min = 1,
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
                    // 78. ClaimResponse.payment.identifier
                    this.Element_Identifier = new ElementDefinitionInfo
                    {
                        Name = "Element_Identifier",
                        Path= "ClaimResponse.payment.identifier",
                        Id = "ClaimResponse.payment.identifier",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Identifier
                            {
                            }
                        }
                    };
                }
            }
        }
        // 82. ClaimResponse.processNote
        public class Type_ProcessNote : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 83. ClaimResponse.processNote.number
            public ElementDefinitionInfo Element_Number;
            // 84. ClaimResponse.processNote.type
            public ElementDefinitionInfo Element_Type;
            // 85. ClaimResponse.processNote.text
            public ElementDefinitionInfo Element_Text;
            // 86. ClaimResponse.processNote.language
            public ElementDefinitionInfo Element_Language;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "ClaimResponse.processNote",
                    ElementId = "ClaimResponse.processNote"
                });
                Element_Number.Write(sDef);
                Element_Type.Write(sDef);
                Element_Text.Write(sDef);
                Element_Language.Write(sDef);
            }
            
            public Type_ProcessNote()
            {
                {
                    // 83. ClaimResponse.processNote.number
                    this.Element_Number = new ElementDefinitionInfo
                    {
                        Name = "Element_Number",
                        Path= "ClaimResponse.processNote.number",
                        Id = "ClaimResponse.processNote.number",
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
                    // 84. ClaimResponse.processNote.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "ClaimResponse.processNote.type",
                        Id = "ClaimResponse.processNote.type",
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
                    // 85. ClaimResponse.processNote.text
                    this.Element_Text = new ElementDefinitionInfo
                    {
                        Name = "Element_Text",
                        Path= "ClaimResponse.processNote.text",
                        Id = "ClaimResponse.processNote.text",
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
                    // 86. ClaimResponse.processNote.language
                    this.Element_Language = new ElementDefinitionInfo
                    {
                        Name = "Element_Language",
                        Path= "ClaimResponse.processNote.language",
                        Id = "ClaimResponse.processNote.language",
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
        // 88. ClaimResponse.insurance
        public class Type_Insurance : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 89. ClaimResponse.insurance.sequence
            public ElementDefinitionInfo Element_Sequence;
            // 90. ClaimResponse.insurance.focal
            public ElementDefinitionInfo Element_Focal;
            // 91. ClaimResponse.insurance.coverage
            public ElementDefinitionInfo Element_Coverage;
            // 92. ClaimResponse.insurance.businessArrangement
            public ElementDefinitionInfo Element_BusinessArrangement;
            // 93. ClaimResponse.insurance.claimResponse
            public ElementDefinitionInfo Element_ClaimResponse;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "ClaimResponse.insurance",
                    ElementId = "ClaimResponse.insurance"
                });
                Element_Sequence.Write(sDef);
                Element_Focal.Write(sDef);
                Element_Coverage.Write(sDef);
                Element_BusinessArrangement.Write(sDef);
                Element_ClaimResponse.Write(sDef);
            }
            
            public Type_Insurance()
            {
                {
                    // 89. ClaimResponse.insurance.sequence
                    this.Element_Sequence = new ElementDefinitionInfo
                    {
                        Name = "Element_Sequence",
                        Path= "ClaimResponse.insurance.sequence",
                        Id = "ClaimResponse.insurance.sequence",
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
                    // 90. ClaimResponse.insurance.focal
                    this.Element_Focal = new ElementDefinitionInfo
                    {
                        Name = "Element_Focal",
                        Path= "ClaimResponse.insurance.focal",
                        Id = "ClaimResponse.insurance.focal",
                        Min = 1,
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
                    // 91. ClaimResponse.insurance.coverage
                    this.Element_Coverage = new ElementDefinitionInfo
                    {
                        Name = "Element_Coverage",
                        Path= "ClaimResponse.insurance.coverage",
                        Id = "ClaimResponse.insurance.coverage",
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
                    // 92. ClaimResponse.insurance.businessArrangement
                    this.Element_BusinessArrangement = new ElementDefinitionInfo
                    {
                        Name = "Element_BusinessArrangement",
                        Path= "ClaimResponse.insurance.businessArrangement",
                        Id = "ClaimResponse.insurance.businessArrangement",
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
                    // 93. ClaimResponse.insurance.claimResponse
                    this.Element_ClaimResponse = new ElementDefinitionInfo
                    {
                        Name = "Element_ClaimResponse",
                        Path= "ClaimResponse.insurance.claimResponse",
                        Id = "ClaimResponse.insurance.claimResponse",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/ClaimResponse"
                                }
                            }
                        }
                    };
                }
            }
        }
        // 94. ClaimResponse.error
        public class Type_Error : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 95. ClaimResponse.error.itemSequence
            public ElementDefinitionInfo Element_ItemSequence;
            // 96. ClaimResponse.error.detailSequence
            public ElementDefinitionInfo Element_DetailSequence;
            // 97. ClaimResponse.error.subDetailSequence
            public ElementDefinitionInfo Element_SubDetailSequence;
            // 98. ClaimResponse.error.code
            public ElementDefinitionInfo Element_Code;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "ClaimResponse.error",
                    ElementId = "ClaimResponse.error"
                });
                Element_ItemSequence.Write(sDef);
                Element_DetailSequence.Write(sDef);
                Element_SubDetailSequence.Write(sDef);
                Element_Code.Write(sDef);
            }
            
            public Type_Error()
            {
                {
                    // 95. ClaimResponse.error.itemSequence
                    this.Element_ItemSequence = new ElementDefinitionInfo
                    {
                        Name = "Element_ItemSequence",
                        Path= "ClaimResponse.error.itemSequence",
                        Id = "ClaimResponse.error.itemSequence",
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
                    // 96. ClaimResponse.error.detailSequence
                    this.Element_DetailSequence = new ElementDefinitionInfo
                    {
                        Name = "Element_DetailSequence",
                        Path= "ClaimResponse.error.detailSequence",
                        Id = "ClaimResponse.error.detailSequence",
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
                    // 97. ClaimResponse.error.subDetailSequence
                    this.Element_SubDetailSequence = new ElementDefinitionInfo
                    {
                        Name = "Element_SubDetailSequence",
                        Path= "ClaimResponse.error.subDetailSequence",
                        Id = "ClaimResponse.error.subDetailSequence",
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
                    // 98. ClaimResponse.error.code
                    this.Element_Code = new ElementDefinitionInfo
                    {
                        Name = "Element_Code",
                        Path= "ClaimResponse.error.code",
                        Id = "ClaimResponse.error.code",
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
        // 1. ClaimResponse.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. ClaimResponse.status
        public ElementDefinitionInfo Element_Status;
        // 3. ClaimResponse.type
        public ElementDefinitionInfo Element_Type;
        // 4. ClaimResponse.subType
        public ElementDefinitionInfo Element_SubType;
        // 5. ClaimResponse.use
        public ElementDefinitionInfo Element_Use;
        // 6. ClaimResponse.patient
        public ElementDefinitionInfo Element_Patient;
        // 7. ClaimResponse.created
        public ElementDefinitionInfo Element_Created;
        // 8. ClaimResponse.insurer
        public ElementDefinitionInfo Element_Insurer;
        // 9. ClaimResponse.requestor
        public ElementDefinitionInfo Element_Requestor;
        // 10. ClaimResponse.request
        public ElementDefinitionInfo Element_Request;
        // 11. ClaimResponse.outcome
        public ElementDefinitionInfo Element_Outcome;
        // 12. ClaimResponse.disposition
        public ElementDefinitionInfo Element_Disposition;
        // 13. ClaimResponse.preAuthRef
        public ElementDefinitionInfo Element_PreAuthRef;
        // 14. ClaimResponse.preAuthPeriod
        public ElementDefinitionInfo Element_PreAuthPeriod;
        // 15. ClaimResponse.payeeType
        public ElementDefinitionInfo Element_PayeeType;
        // 16. ClaimResponse.item
        public ElementDefinitionInfo Element_Item;
        // 32. ClaimResponse.addItem
        public ElementDefinitionInfo Element_AddItem;
        // 68. ClaimResponse.adjudication
        public ElementDefinitionInfo Element_Adjudication;
        // 69. ClaimResponse.total
        public ElementDefinitionInfo Element_Total;
        // 72. ClaimResponse.payment
        public ElementDefinitionInfo Element_Payment;
        // 79. ClaimResponse.fundsReserve
        public ElementDefinitionInfo Element_FundsReserve;
        // 80. ClaimResponse.formCode
        public ElementDefinitionInfo Element_FormCode;
        // 81. ClaimResponse.form
        public ElementDefinitionInfo Element_Form;
        // 82. ClaimResponse.processNote
        public ElementDefinitionInfo Element_ProcessNote;
        // 87. ClaimResponse.communicationRequest
        public ElementDefinitionInfo Element_CommunicationRequest;
        // 88. ClaimResponse.insurance
        public ElementDefinitionInfo Element_Insurance;
        // 94. ClaimResponse.error
        public ElementDefinitionInfo Element_Error;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "ClaimResponse",
                ElementId = "ClaimResponse"
            });
            Element_Identifier.Write(sDef);
            Element_Status.Write(sDef);
            Element_Type.Write(sDef);
            Element_SubType.Write(sDef);
            Element_Use.Write(sDef);
            Element_Patient.Write(sDef);
            Element_Created.Write(sDef);
            Element_Insurer.Write(sDef);
            Element_Requestor.Write(sDef);
            Element_Request.Write(sDef);
            Element_Outcome.Write(sDef);
            Element_Disposition.Write(sDef);
            Element_PreAuthRef.Write(sDef);
            Element_PreAuthPeriod.Write(sDef);
            Element_PayeeType.Write(sDef);
            Element_Item.Write(sDef);
            Element_AddItem.Write(sDef);
            Element_Adjudication.Write(sDef);
            Element_Total.Write(sDef);
            Element_Payment.Write(sDef);
            Element_FundsReserve.Write(sDef);
            Element_FormCode.Write(sDef);
            Element_Form.Write(sDef);
            Element_ProcessNote.Write(sDef);
            Element_CommunicationRequest.Write(sDef);
            Element_Insurance.Write(sDef);
            Element_Error.Write(sDef);
        }
        
        public Resource_ClaimResponse()
        {
            {
                // 1. ClaimResponse.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "ClaimResponse.identifier",
                    Id = "ClaimResponse.identifier",
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
                // 2. ClaimResponse.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "ClaimResponse.status",
                    Id = "ClaimResponse.status",
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
                // 3. ClaimResponse.type
                this.Element_Type = new ElementDefinitionInfo
                {
                    Name = "Element_Type",
                    Path= "ClaimResponse.type",
                    Id = "ClaimResponse.type",
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
                // 4. ClaimResponse.subType
                this.Element_SubType = new ElementDefinitionInfo
                {
                    Name = "Element_SubType",
                    Path= "ClaimResponse.subType",
                    Id = "ClaimResponse.subType",
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
                // 5. ClaimResponse.use
                this.Element_Use = new ElementDefinitionInfo
                {
                    Name = "Element_Use",
                    Path= "ClaimResponse.use",
                    Id = "ClaimResponse.use",
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
                // 6. ClaimResponse.patient
                this.Element_Patient = new ElementDefinitionInfo
                {
                    Name = "Element_Patient",
                    Path= "ClaimResponse.patient",
                    Id = "ClaimResponse.patient",
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
                // 7. ClaimResponse.created
                this.Element_Created = new ElementDefinitionInfo
                {
                    Name = "Element_Created",
                    Path= "ClaimResponse.created",
                    Id = "ClaimResponse.created",
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
                // 8. ClaimResponse.insurer
                this.Element_Insurer = new ElementDefinitionInfo
                {
                    Name = "Element_Insurer",
                    Path= "ClaimResponse.insurer",
                    Id = "ClaimResponse.insurer",
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
                // 9. ClaimResponse.requestor
                this.Element_Requestor = new ElementDefinitionInfo
                {
                    Name = "Element_Requestor",
                    Path= "ClaimResponse.requestor",
                    Id = "ClaimResponse.requestor",
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
                // 10. ClaimResponse.request
                this.Element_Request = new ElementDefinitionInfo
                {
                    Name = "Element_Request",
                    Path= "ClaimResponse.request",
                    Id = "ClaimResponse.request",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Claim"
                            }
                        }
                    }
                };
            }
            {
                // 11. ClaimResponse.outcome
                this.Element_Outcome = new ElementDefinitionInfo
                {
                    Name = "Element_Outcome",
                    Path= "ClaimResponse.outcome",
                    Id = "ClaimResponse.outcome",
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
                // 12. ClaimResponse.disposition
                this.Element_Disposition = new ElementDefinitionInfo
                {
                    Name = "Element_Disposition",
                    Path= "ClaimResponse.disposition",
                    Id = "ClaimResponse.disposition",
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
                // 13. ClaimResponse.preAuthRef
                this.Element_PreAuthRef = new ElementDefinitionInfo
                {
                    Name = "Element_PreAuthRef",
                    Path= "ClaimResponse.preAuthRef",
                    Id = "ClaimResponse.preAuthRef",
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
                // 14. ClaimResponse.preAuthPeriod
                this.Element_PreAuthPeriod = new ElementDefinitionInfo
                {
                    Name = "Element_PreAuthPeriod",
                    Path= "ClaimResponse.preAuthPeriod",
                    Id = "ClaimResponse.preAuthPeriod",
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
                // 15. ClaimResponse.payeeType
                this.Element_PayeeType = new ElementDefinitionInfo
                {
                    Name = "Element_PayeeType",
                    Path= "ClaimResponse.payeeType",
                    Id = "ClaimResponse.payeeType",
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
                // 16. ClaimResponse.item
                this.Element_Item = new ElementDefinitionInfo
                {
                    Name = "Element_Item",
                    Path= "ClaimResponse.item",
                    Id = "ClaimResponse.item",
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
            {
                // 32. ClaimResponse.addItem
                this.Element_AddItem = new ElementDefinitionInfo
                {
                    Name = "Element_AddItem",
                    Path= "ClaimResponse.addItem",
                    Id = "ClaimResponse.addItem",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_AddItem
                        {
                        }
                    }
                };
            }
            {
                // 68. ClaimResponse.adjudication
                this.Element_Adjudication = new ElementDefinitionInfo
                {
                    Name = "Element_Adjudication",
                    Path= "ClaimResponse.adjudication",
                    Id = "ClaimResponse.adjudication",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                    }
                };
            }
            {
                // 69. ClaimResponse.total
                this.Element_Total = new ElementDefinitionInfo
                {
                    Name = "Element_Total",
                    Path= "ClaimResponse.total",
                    Id = "ClaimResponse.total",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Total
                        {
                        }
                    }
                };
            }
            {
                // 72. ClaimResponse.payment
                this.Element_Payment = new ElementDefinitionInfo
                {
                    Name = "Element_Payment",
                    Path= "ClaimResponse.payment",
                    Id = "ClaimResponse.payment",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new Type_Payment
                        {
                        }
                    }
                };
            }
            {
                // 79. ClaimResponse.fundsReserve
                this.Element_FundsReserve = new ElementDefinitionInfo
                {
                    Name = "Element_FundsReserve",
                    Path= "ClaimResponse.fundsReserve",
                    Id = "ClaimResponse.fundsReserve",
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
                // 80. ClaimResponse.formCode
                this.Element_FormCode = new ElementDefinitionInfo
                {
                    Name = "Element_FormCode",
                    Path= "ClaimResponse.formCode",
                    Id = "ClaimResponse.formCode",
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
                // 81. ClaimResponse.form
                this.Element_Form = new ElementDefinitionInfo
                {
                    Name = "Element_Form",
                    Path= "ClaimResponse.form",
                    Id = "ClaimResponse.form",
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
                // 82. ClaimResponse.processNote
                this.Element_ProcessNote = new ElementDefinitionInfo
                {
                    Name = "Element_ProcessNote",
                    Path= "ClaimResponse.processNote",
                    Id = "ClaimResponse.processNote",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_ProcessNote
                        {
                        }
                    }
                };
            }
            {
                // 87. ClaimResponse.communicationRequest
                this.Element_CommunicationRequest = new ElementDefinitionInfo
                {
                    Name = "Element_CommunicationRequest",
                    Path= "ClaimResponse.communicationRequest",
                    Id = "ClaimResponse.communicationRequest",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/CommunicationRequest"
                            }
                        }
                    }
                };
            }
            {
                // 88. ClaimResponse.insurance
                this.Element_Insurance = new ElementDefinitionInfo
                {
                    Name = "Element_Insurance",
                    Path= "ClaimResponse.insurance",
                    Id = "ClaimResponse.insurance",
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
                // 94. ClaimResponse.error
                this.Element_Error = new ElementDefinitionInfo
                {
                    Name = "Element_Error",
                    Path= "ClaimResponse.error",
                    Id = "ClaimResponse.error",
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
            this.Name = "ClaimResponse";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/ClaimResponse";
        }
    }
}
