using System;                                                                                                                               // MakerGen.cs:454
using System.Diagnostics;                                                                                                                   // MakerGen.cs:455
using System.IO;                                                                                                                            // MakerGen.cs:456
using System.Linq;                                                                                                                          // MakerGen.cs:457
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:458
                                                                                                                                            // MakerGen.cs:459
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:460
{                                                                                                                                           // MakerGen.cs:461
    #region Json                                                                                                                            // MakerGen.cs:462
    #if NEVER                                                                                                                               // MakerGen.cs:463
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
    #endregion                                                                                                                              // MakerGen.cs:466
    /// <summary>
    /// Fhir resource 'ClaimResponse'
    /// </summary>
    // 0. ClaimResponse
    public class Resource_ClaimResponse : FhirKhit.Maker.Common.Resource.ResourceBase                                                       // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        public class Resource_ClaimResponse_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                          // MakerGen.cs:378
        {                                                                                                                                   // MakerGen.cs:379
            // 16. ClaimResponse.item
            public class Type_Item : FhirKhit.Maker.Common.Complex.ComplexBase                                                              // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                public class Type_Item_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                               // MakerGen.cs:378
                {                                                                                                                           // MakerGen.cs:379
                    // 19. ClaimResponse.item.adjudication
                    public class Type_Adjudication : FhirKhit.Maker.Common.Complex.ComplexBase                                              // MakerGen.cs:376
                    {                                                                                                                       // MakerGen.cs:377
                        public class Type_Adjudication_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                               // MakerGen.cs:378
                        {                                                                                                                   // MakerGen.cs:379
                            // 20. ClaimResponse.item.adjudication.category
                            public ElementDefinitionInfo Element_Category;                                                                  // MakerGen.cs:211
                            // 21. ClaimResponse.item.adjudication.reason
                            public ElementDefinitionInfo Element_Reason;                                                                    // MakerGen.cs:211
                            // 22. ClaimResponse.item.adjudication.amount
                            public ElementDefinitionInfo Element_Amount;                                                                    // MakerGen.cs:211
                            // 23. ClaimResponse.item.adjudication.value
                            public ElementDefinitionInfo Element_Value;                                                                     // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                            public Type_Adjudication_Elements()                                                                             // MakerGen.cs:384
                            {                                                                                                               // MakerGen.cs:385
                                {                                                                                                           // MakerGen.cs:226
                                    // 20. ClaimResponse.item.adjudication.category
                                    this.Element_Category = new ElementDefinitionInfo                                                       // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_Category",                                                                          // MakerGen.cs:230
                                        Path= "ClaimResponse.item.adjudication.category",                                                   // MakerGen.cs:231
                                        Id = "ClaimResponse.item.adjudication.category",                                                    // MakerGen.cs:232
                                        Min = 1,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                          // MakerGen.cs:310
                                            {                                                                                               // MakerGen.cs:311
                                            }                                                                                               // MakerGen.cs:314
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 21. ClaimResponse.item.adjudication.reason
                                    this.Element_Reason = new ElementDefinitionInfo                                                         // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_Reason",                                                                            // MakerGen.cs:230
                                        Path= "ClaimResponse.item.adjudication.reason",                                                     // MakerGen.cs:231
                                        Id = "ClaimResponse.item.adjudication.reason",                                                      // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                          // MakerGen.cs:310
                                            {                                                                                               // MakerGen.cs:311
                                            }                                                                                               // MakerGen.cs:314
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 22. ClaimResponse.item.adjudication.amount
                                    this.Element_Amount = new ElementDefinitionInfo                                                         // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_Amount",                                                                            // MakerGen.cs:230
                                        Path= "ClaimResponse.item.adjudication.amount",                                                     // MakerGen.cs:231
                                        Id = "ClaimResponse.item.adjudication.amount",                                                      // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.Type_Money                                                    // MakerGen.cs:350
                                            {                                                                                               // MakerGen.cs:351
                                            }                                                                                               // MakerGen.cs:352
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 23. ClaimResponse.item.adjudication.value
                                    this.Element_Value = new ElementDefinitionInfo                                                          // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_Value",                                                                             // MakerGen.cs:230
                                        Path= "ClaimResponse.item.adjudication.value",                                                      // MakerGen.cs:231
                                        Id = "ClaimResponse.item.adjudication.value",                                                       // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.Decimal                                                     // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:390
                            {                                                                                                               // MakerGen.cs:391
                                base.Write(sDef);                                                                                           // MakerGen.cs:392
                                Element_Category.Write(sDef);                                                                               // MakerGen.cs:215
                                Element_Reason.Write(sDef);                                                                                 // MakerGen.cs:215
                                Element_Amount.Write(sDef);                                                                                 // MakerGen.cs:215
                                Element_Value.Write(sDef);                                                                                  // MakerGen.cs:215
                            }                                                                                                               // MakerGen.cs:394
                        }                                                                                                                   // MakerGen.cs:396
                        public Type_Adjudication_Elements Elements                                                                          // MakerGen.cs:398
                        {                                                                                                                   // MakerGen.cs:399
                            get                                                                                                             // MakerGen.cs:400
                            {                                                                                                               // MakerGen.cs:401
                                if (this.elements == null)                                                                                  // MakerGen.cs:402
                                    this.elements = new Type_Adjudication_Elements();                                                       // MakerGen.cs:403
                                return this.elements;                                                                                       // MakerGen.cs:404
                            }                                                                                                               // MakerGen.cs:405
                        }                                                                                                                   // MakerGen.cs:406
                        Type_Adjudication_Elements elements;                                                                                // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                        public Type_Adjudication()                                                                                          // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:411
                        }                                                                                                                   // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:416
                        {                                                                                                                   // MakerGen.cs:417
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:418
                            {                                                                                                               // MakerGen.cs:419
                                Path = "ClaimResponse.item.adjudication",                                                                   // MakerGen.cs:420
                                ElementId = "ClaimResponse.item.adjudication"                                                               // MakerGen.cs:421
                            });                                                                                                             // MakerGen.cs:422
                            if (this.elements != null)                                                                                      // MakerGen.cs:423
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:424
                        }                                                                                                                   // MakerGen.cs:425
                    }                                                                                                                       // MakerGen.cs:426
                    // 24. ClaimResponse.item.detail
                    public class Type_Detail : FhirKhit.Maker.Common.Complex.ComplexBase                                                    // MakerGen.cs:376
                    {                                                                                                                       // MakerGen.cs:377
                        public class Type_Detail_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                     // MakerGen.cs:378
                        {                                                                                                                   // MakerGen.cs:379
                            // 28. ClaimResponse.item.detail.subDetail
                            public class Type_SubDetail : FhirKhit.Maker.Common.Complex.ComplexBase                                         // MakerGen.cs:376
                            {                                                                                                               // MakerGen.cs:377
                                public class Type_SubDetail_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                          // MakerGen.cs:378
                                {                                                                                                           // MakerGen.cs:379
                                    // 29. ClaimResponse.item.detail.subDetail.subDetailSequence
                                    public ElementDefinitionInfo Element_SubDetailSequence;                                                 // MakerGen.cs:211
                                    // 30. ClaimResponse.item.detail.subDetail.noteNumber
                                    public ElementDefinitionInfo Element_NoteNumber;                                                        // MakerGen.cs:211
                                    // 31. ClaimResponse.item.detail.subDetail.adjudication
                                    public ElementDefinitionInfo Element_Adjudication;                                                      // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                                    public Type_SubDetail_Elements()                                                                        // MakerGen.cs:384
                                    {                                                                                                       // MakerGen.cs:385
                                        {                                                                                                   // MakerGen.cs:226
                                            // 29. ClaimResponse.item.detail.subDetail.subDetailSequence
                                            this.Element_SubDetailSequence = new ElementDefinitionInfo                                      // MakerGen.cs:228
                                            {                                                                                               // MakerGen.cs:229
                                                Name = "Element_SubDetailSequence",                                                         // MakerGen.cs:230
                                                Path= "ClaimResponse.item.detail.subDetail.subDetailSequence",                              // MakerGen.cs:231
                                                Id = "ClaimResponse.item.detail.subDetail.subDetailSequence",                               // MakerGen.cs:232
                                                Min = 1,                                                                                    // MakerGen.cs:233
                                                Max = 1,                                                                                    // MakerGen.cs:234
                                                Types = new BaseType[]                                                                      // MakerGen.cs:235
                                                {                                                                                           // MakerGen.cs:236
                                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                         // MakerGen.cs:295
                                                    {                                                                                       // MakerGen.cs:296
                                                    }                                                                                       // MakerGen.cs:299
                                                }                                                                                           // MakerGen.cs:238
                                            };                                                                                              // MakerGen.cs:239
                                        }                                                                                                   // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:226
                                            // 30. ClaimResponse.item.detail.subDetail.noteNumber
                                            this.Element_NoteNumber = new ElementDefinitionInfo                                             // MakerGen.cs:228
                                            {                                                                                               // MakerGen.cs:229
                                                Name = "Element_NoteNumber",                                                                // MakerGen.cs:230
                                                Path= "ClaimResponse.item.detail.subDetail.noteNumber",                                     // MakerGen.cs:231
                                                Id = "ClaimResponse.item.detail.subDetail.noteNumber",                                      // MakerGen.cs:232
                                                Min = 0,                                                                                    // MakerGen.cs:233
                                                Max = -1,                                                                                   // MakerGen.cs:234
                                                Types = new BaseType[]                                                                      // MakerGen.cs:235
                                                {                                                                                           // MakerGen.cs:236
                                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                         // MakerGen.cs:295
                                                    {                                                                                       // MakerGen.cs:296
                                                    }                                                                                       // MakerGen.cs:299
                                                }                                                                                           // MakerGen.cs:238
                                            };                                                                                              // MakerGen.cs:239
                                        }                                                                                                   // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:226
                                            // 31. ClaimResponse.item.detail.subDetail.adjudication
                                            this.Element_Adjudication = new ElementDefinitionInfo                                           // MakerGen.cs:228
                                            {                                                                                               // MakerGen.cs:229
                                                Name = "Element_Adjudication",                                                              // MakerGen.cs:230
                                                Path= "ClaimResponse.item.detail.subDetail.adjudication",                                   // MakerGen.cs:231
                                                Id = "ClaimResponse.item.detail.subDetail.adjudication",                                    // MakerGen.cs:232
                                                Min = 0,                                                                                    // MakerGen.cs:233
                                                Max = -1,                                                                                   // MakerGen.cs:234
                                                Types = new BaseType[]                                                                      // MakerGen.cs:235
                                                {                                                                                           // MakerGen.cs:236
                                                }                                                                                           // MakerGen.cs:238
                                            };                                                                                              // MakerGen.cs:239
                                        }                                                                                                   // MakerGen.cs:240
                                    }                                                                                                       // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
                                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                     // MakerGen.cs:390
                                    {                                                                                                       // MakerGen.cs:391
                                        base.Write(sDef);                                                                                   // MakerGen.cs:392
                                        Element_SubDetailSequence.Write(sDef);                                                              // MakerGen.cs:215
                                        Element_NoteNumber.Write(sDef);                                                                     // MakerGen.cs:215
                                        Element_Adjudication.Write(sDef);                                                                   // MakerGen.cs:215
                                    }                                                                                                       // MakerGen.cs:394
                                }                                                                                                           // MakerGen.cs:396
                                public Type_SubDetail_Elements Elements                                                                     // MakerGen.cs:398
                                {                                                                                                           // MakerGen.cs:399
                                    get                                                                                                     // MakerGen.cs:400
                                    {                                                                                                       // MakerGen.cs:401
                                        if (this.elements == null)                                                                          // MakerGen.cs:402
                                            this.elements = new Type_SubDetail_Elements();                                                  // MakerGen.cs:403
                                        return this.elements;                                                                               // MakerGen.cs:404
                                    }                                                                                                       // MakerGen.cs:405
                                }                                                                                                           // MakerGen.cs:406
                                Type_SubDetail_Elements elements;                                                                           // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                                public Type_SubDetail()                                                                                     // MakerGen.cs:410
                                {                                                                                                           // MakerGen.cs:411
                                }                                                                                                           // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                         // MakerGen.cs:416
                                {                                                                                                           // MakerGen.cs:417
                                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                      // MakerGen.cs:418
                                    {                                                                                                       // MakerGen.cs:419
                                        Path = "ClaimResponse.item.detail.subDetail",                                                       // MakerGen.cs:420
                                        ElementId = "ClaimResponse.item.detail.subDetail"                                                   // MakerGen.cs:421
                                    });                                                                                                     // MakerGen.cs:422
                                    if (this.elements != null)                                                                              // MakerGen.cs:423
                                        this.elements.Write(sDef);                                                                          // MakerGen.cs:424
                                }                                                                                                           // MakerGen.cs:425
                            }                                                                                                               // MakerGen.cs:426
                            // 25. ClaimResponse.item.detail.detailSequence
                            public ElementDefinitionInfo Element_DetailSequence;                                                            // MakerGen.cs:211
                            // 26. ClaimResponse.item.detail.noteNumber
                            public ElementDefinitionInfo Element_NoteNumber;                                                                // MakerGen.cs:211
                            // 27. ClaimResponse.item.detail.adjudication
                            public ElementDefinitionInfo Element_Adjudication;                                                              // MakerGen.cs:211
                            // 28. ClaimResponse.item.detail.subDetail
                            public ElementDefinitionInfo Element_SubDetail;                                                                 // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                            public Type_Detail_Elements()                                                                                   // MakerGen.cs:384
                            {                                                                                                               // MakerGen.cs:385
                                {                                                                                                           // MakerGen.cs:226
                                    // 25. ClaimResponse.item.detail.detailSequence
                                    this.Element_DetailSequence = new ElementDefinitionInfo                                                 // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_DetailSequence",                                                                    // MakerGen.cs:230
                                        Path= "ClaimResponse.item.detail.detailSequence",                                                   // MakerGen.cs:231
                                        Id = "ClaimResponse.item.detail.detailSequence",                                                    // MakerGen.cs:232
                                        Min = 1,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.PositiveInt                                                 // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 26. ClaimResponse.item.detail.noteNumber
                                    this.Element_NoteNumber = new ElementDefinitionInfo                                                     // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_NoteNumber",                                                                        // MakerGen.cs:230
                                        Path= "ClaimResponse.item.detail.noteNumber",                                                       // MakerGen.cs:231
                                        Id = "ClaimResponse.item.detail.noteNumber",                                                        // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = -1,                                                                                           // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.PositiveInt                                                 // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 27. ClaimResponse.item.detail.adjudication
                                    this.Element_Adjudication = new ElementDefinitionInfo                                                   // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_Adjudication",                                                                      // MakerGen.cs:230
                                        Path= "ClaimResponse.item.detail.adjudication",                                                     // MakerGen.cs:231
                                        Id = "ClaimResponse.item.detail.adjudication",                                                      // MakerGen.cs:232
                                        Min = 1,                                                                                            // MakerGen.cs:233
                                        Max = -1,                                                                                           // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 28. ClaimResponse.item.detail.subDetail
                                    this.Element_SubDetail = new ElementDefinitionInfo                                                      // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_SubDetail",                                                                         // MakerGen.cs:230
                                        Path= "ClaimResponse.item.detail.subDetail",                                                        // MakerGen.cs:231
                                        Id = "ClaimResponse.item.detail.subDetail",                                                         // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = -1,                                                                                           // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new Type_SubDetail                                                                              // MakerGen.cs:254
                                            {                                                                                               // MakerGen.cs:255
                                            }                                                                                               // MakerGen.cs:256
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:390
                            {                                                                                                               // MakerGen.cs:391
                                base.Write(sDef);                                                                                           // MakerGen.cs:392
                                Element_DetailSequence.Write(sDef);                                                                         // MakerGen.cs:215
                                Element_NoteNumber.Write(sDef);                                                                             // MakerGen.cs:215
                                Element_Adjudication.Write(sDef);                                                                           // MakerGen.cs:215
                                Element_SubDetail.Write(sDef);                                                                              // MakerGen.cs:215
                            }                                                                                                               // MakerGen.cs:394
                        }                                                                                                                   // MakerGen.cs:396
                        public Type_Detail_Elements Elements                                                                                // MakerGen.cs:398
                        {                                                                                                                   // MakerGen.cs:399
                            get                                                                                                             // MakerGen.cs:400
                            {                                                                                                               // MakerGen.cs:401
                                if (this.elements == null)                                                                                  // MakerGen.cs:402
                                    this.elements = new Type_Detail_Elements();                                                             // MakerGen.cs:403
                                return this.elements;                                                                                       // MakerGen.cs:404
                            }                                                                                                               // MakerGen.cs:405
                        }                                                                                                                   // MakerGen.cs:406
                        Type_Detail_Elements elements;                                                                                      // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                        public Type_Detail()                                                                                                // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:411
                        }                                                                                                                   // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:416
                        {                                                                                                                   // MakerGen.cs:417
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:418
                            {                                                                                                               // MakerGen.cs:419
                                Path = "ClaimResponse.item.detail",                                                                         // MakerGen.cs:420
                                ElementId = "ClaimResponse.item.detail"                                                                     // MakerGen.cs:421
                            });                                                                                                             // MakerGen.cs:422
                            if (this.elements != null)                                                                                      // MakerGen.cs:423
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:424
                        }                                                                                                                   // MakerGen.cs:425
                    }                                                                                                                       // MakerGen.cs:426
                    // 17. ClaimResponse.item.itemSequence
                    public ElementDefinitionInfo Element_ItemSequence;                                                                      // MakerGen.cs:211
                    // 18. ClaimResponse.item.noteNumber
                    public ElementDefinitionInfo Element_NoteNumber;                                                                        // MakerGen.cs:211
                    // 19. ClaimResponse.item.adjudication
                    public ElementDefinitionInfo Element_Adjudication;                                                                      // MakerGen.cs:211
                    // 24. ClaimResponse.item.detail
                    public ElementDefinitionInfo Element_Detail;                                                                            // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                    public Type_Item_Elements()                                                                                             // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:226
                            // 17. ClaimResponse.item.itemSequence
                            this.Element_ItemSequence = new ElementDefinitionInfo                                                           // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_ItemSequence",                                                                              // MakerGen.cs:230
                                Path= "ClaimResponse.item.itemSequence",                                                                    // MakerGen.cs:231
                                Id = "ClaimResponse.item.itemSequence",                                                                     // MakerGen.cs:232
                                Min = 1,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                                         // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 18. ClaimResponse.item.noteNumber
                            this.Element_NoteNumber = new ElementDefinitionInfo                                                             // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_NoteNumber",                                                                                // MakerGen.cs:230
                                Path= "ClaimResponse.item.noteNumber",                                                                      // MakerGen.cs:231
                                Id = "ClaimResponse.item.noteNumber",                                                                       // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                                         // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 19. ClaimResponse.item.adjudication
                            this.Element_Adjudication = new ElementDefinitionInfo                                                           // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Adjudication",                                                                              // MakerGen.cs:230
                                Path= "ClaimResponse.item.adjudication",                                                                    // MakerGen.cs:231
                                Id = "ClaimResponse.item.adjudication",                                                                     // MakerGen.cs:232
                                Min = 1,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new Type_Adjudication                                                                                   // MakerGen.cs:254
                                    {                                                                                                       // MakerGen.cs:255
                                    }                                                                                                       // MakerGen.cs:256
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 24. ClaimResponse.item.detail
                            this.Element_Detail = new ElementDefinitionInfo                                                                 // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Detail",                                                                                    // MakerGen.cs:230
                                Path= "ClaimResponse.item.detail",                                                                          // MakerGen.cs:231
                                Id = "ClaimResponse.item.detail",                                                                           // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new Type_Detail                                                                                         // MakerGen.cs:254
                                    {                                                                                                       // MakerGen.cs:255
                                    }                                                                                                       // MakerGen.cs:256
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:390
                    {                                                                                                                       // MakerGen.cs:391
                        base.Write(sDef);                                                                                                   // MakerGen.cs:392
                        Element_ItemSequence.Write(sDef);                                                                                   // MakerGen.cs:215
                        Element_NoteNumber.Write(sDef);                                                                                     // MakerGen.cs:215
                        Element_Adjudication.Write(sDef);                                                                                   // MakerGen.cs:215
                        Element_Detail.Write(sDef);                                                                                         // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:394
                }                                                                                                                           // MakerGen.cs:396
                public Type_Item_Elements Elements                                                                                          // MakerGen.cs:398
                {                                                                                                                           // MakerGen.cs:399
                    get                                                                                                                     // MakerGen.cs:400
                    {                                                                                                                       // MakerGen.cs:401
                        if (this.elements == null)                                                                                          // MakerGen.cs:402
                            this.elements = new Type_Item_Elements();                                                                       // MakerGen.cs:403
                        return this.elements;                                                                                               // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                }                                                                                                                           // MakerGen.cs:406
                Type_Item_Elements elements;                                                                                                // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                public Type_Item()                                                                                                          // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:411
                }                                                                                                                           // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:416
                {                                                                                                                           // MakerGen.cs:417
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:418
                    {                                                                                                                       // MakerGen.cs:419
                        Path = "ClaimResponse.item",                                                                                        // MakerGen.cs:420
                        ElementId = "ClaimResponse.item"                                                                                    // MakerGen.cs:421
                    });                                                                                                                     // MakerGen.cs:422
                    if (this.elements != null)                                                                                              // MakerGen.cs:423
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:424
                }                                                                                                                           // MakerGen.cs:425
            }                                                                                                                               // MakerGen.cs:426
            // 32. ClaimResponse.addItem
            public class Type_AddItem : FhirKhit.Maker.Common.Complex.ComplexBase                                                           // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                public class Type_AddItem_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                            // MakerGen.cs:378
                {                                                                                                                           // MakerGen.cs:379
                    // 50. ClaimResponse.addItem.detail
                    public class Type_Detail : FhirKhit.Maker.Common.Complex.ComplexBase                                                    // MakerGen.cs:376
                    {                                                                                                                       // MakerGen.cs:377
                        public class Type_Detail_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                     // MakerGen.cs:378
                        {                                                                                                                   // MakerGen.cs:379
                            // 59. ClaimResponse.addItem.detail.subDetail
                            public class Type_SubDetail : FhirKhit.Maker.Common.Complex.ComplexBase                                         // MakerGen.cs:376
                            {                                                                                                               // MakerGen.cs:377
                                public class Type_SubDetail_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                          // MakerGen.cs:378
                                {                                                                                                           // MakerGen.cs:379
                                    // 60. ClaimResponse.addItem.detail.subDetail.productOrService
                                    public ElementDefinitionInfo Element_ProductOrService;                                                  // MakerGen.cs:211
                                    // 61. ClaimResponse.addItem.detail.subDetail.modifier
                                    public ElementDefinitionInfo Element_Modifier;                                                          // MakerGen.cs:211
                                    // 62. ClaimResponse.addItem.detail.subDetail.quantity
                                    public ElementDefinitionInfo Element_Quantity;                                                          // MakerGen.cs:211
                                    // 63. ClaimResponse.addItem.detail.subDetail.unitPrice
                                    public ElementDefinitionInfo Element_UnitPrice;                                                         // MakerGen.cs:211
                                    // 64. ClaimResponse.addItem.detail.subDetail.factor
                                    public ElementDefinitionInfo Element_Factor;                                                            // MakerGen.cs:211
                                    // 65. ClaimResponse.addItem.detail.subDetail.net
                                    public ElementDefinitionInfo Element_Net;                                                               // MakerGen.cs:211
                                    // 66. ClaimResponse.addItem.detail.subDetail.noteNumber
                                    public ElementDefinitionInfo Element_NoteNumber;                                                        // MakerGen.cs:211
                                    // 67. ClaimResponse.addItem.detail.subDetail.adjudication
                                    public ElementDefinitionInfo Element_Adjudication;                                                      // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                                    public Type_SubDetail_Elements()                                                                        // MakerGen.cs:384
                                    {                                                                                                       // MakerGen.cs:385
                                        {                                                                                                   // MakerGen.cs:226
                                            // 60. ClaimResponse.addItem.detail.subDetail.productOrService
                                            this.Element_ProductOrService = new ElementDefinitionInfo                                       // MakerGen.cs:228
                                            {                                                                                               // MakerGen.cs:229
                                                Name = "Element_ProductOrService",                                                          // MakerGen.cs:230
                                                Path= "ClaimResponse.addItem.detail.subDetail.productOrService",                            // MakerGen.cs:231
                                                Id = "ClaimResponse.addItem.detail.subDetail.productOrService",                             // MakerGen.cs:232
                                                Min = 1,                                                                                    // MakerGen.cs:233
                                                Max = 1,                                                                                    // MakerGen.cs:234
                                                Types = new BaseType[]                                                                      // MakerGen.cs:235
                                                {                                                                                           // MakerGen.cs:236
                                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                  // MakerGen.cs:310
                                                    {                                                                                       // MakerGen.cs:311
                                                    }                                                                                       // MakerGen.cs:314
                                                }                                                                                           // MakerGen.cs:238
                                            };                                                                                              // MakerGen.cs:239
                                        }                                                                                                   // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:226
                                            // 61. ClaimResponse.addItem.detail.subDetail.modifier
                                            this.Element_Modifier = new ElementDefinitionInfo                                               // MakerGen.cs:228
                                            {                                                                                               // MakerGen.cs:229
                                                Name = "Element_Modifier",                                                                  // MakerGen.cs:230
                                                Path= "ClaimResponse.addItem.detail.subDetail.modifier",                                    // MakerGen.cs:231
                                                Id = "ClaimResponse.addItem.detail.subDetail.modifier",                                     // MakerGen.cs:232
                                                Min = 0,                                                                                    // MakerGen.cs:233
                                                Max = -1,                                                                                   // MakerGen.cs:234
                                                Types = new BaseType[]                                                                      // MakerGen.cs:235
                                                {                                                                                           // MakerGen.cs:236
                                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                  // MakerGen.cs:310
                                                    {                                                                                       // MakerGen.cs:311
                                                    }                                                                                       // MakerGen.cs:314
                                                }                                                                                           // MakerGen.cs:238
                                            };                                                                                              // MakerGen.cs:239
                                        }                                                                                                   // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:226
                                            // 62. ClaimResponse.addItem.detail.subDetail.quantity
                                            this.Element_Quantity = new ElementDefinitionInfo                                               // MakerGen.cs:228
                                            {                                                                                               // MakerGen.cs:229
                                                Name = "Element_Quantity",                                                                  // MakerGen.cs:230
                                                Path= "ClaimResponse.addItem.detail.subDetail.quantity",                                    // MakerGen.cs:231
                                                Id = "ClaimResponse.addItem.detail.subDetail.quantity",                                     // MakerGen.cs:232
                                                Min = 0,                                                                                    // MakerGen.cs:233
                                                Max = 1,                                                                                    // MakerGen.cs:234
                                                Types = new BaseType[]                                                                      // MakerGen.cs:235
                                                {                                                                                           // MakerGen.cs:236
                                                    new FhirKhit.Maker.Common.Complex.Type_Quantity                                         // MakerGen.cs:350
                                                    {                                                                                       // MakerGen.cs:351
                                                    }                                                                                       // MakerGen.cs:352
                                                }                                                                                           // MakerGen.cs:238
                                            };                                                                                              // MakerGen.cs:239
                                        }                                                                                                   // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:226
                                            // 63. ClaimResponse.addItem.detail.subDetail.unitPrice
                                            this.Element_UnitPrice = new ElementDefinitionInfo                                              // MakerGen.cs:228
                                            {                                                                                               // MakerGen.cs:229
                                                Name = "Element_UnitPrice",                                                                 // MakerGen.cs:230
                                                Path= "ClaimResponse.addItem.detail.subDetail.unitPrice",                                   // MakerGen.cs:231
                                                Id = "ClaimResponse.addItem.detail.subDetail.unitPrice",                                    // MakerGen.cs:232
                                                Min = 0,                                                                                    // MakerGen.cs:233
                                                Max = 1,                                                                                    // MakerGen.cs:234
                                                Types = new BaseType[]                                                                      // MakerGen.cs:235
                                                {                                                                                           // MakerGen.cs:236
                                                    new FhirKhit.Maker.Common.Complex.Type_Money                                            // MakerGen.cs:350
                                                    {                                                                                       // MakerGen.cs:351
                                                    }                                                                                       // MakerGen.cs:352
                                                }                                                                                           // MakerGen.cs:238
                                            };                                                                                              // MakerGen.cs:239
                                        }                                                                                                   // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:226
                                            // 64. ClaimResponse.addItem.detail.subDetail.factor
                                            this.Element_Factor = new ElementDefinitionInfo                                                 // MakerGen.cs:228
                                            {                                                                                               // MakerGen.cs:229
                                                Name = "Element_Factor",                                                                    // MakerGen.cs:230
                                                Path= "ClaimResponse.addItem.detail.subDetail.factor",                                      // MakerGen.cs:231
                                                Id = "ClaimResponse.addItem.detail.subDetail.factor",                                       // MakerGen.cs:232
                                                Min = 0,                                                                                    // MakerGen.cs:233
                                                Max = 1,                                                                                    // MakerGen.cs:234
                                                Types = new BaseType[]                                                                      // MakerGen.cs:235
                                                {                                                                                           // MakerGen.cs:236
                                                    new FhirKhit.Maker.Common.Primitive.Decimal                                             // MakerGen.cs:295
                                                    {                                                                                       // MakerGen.cs:296
                                                    }                                                                                       // MakerGen.cs:299
                                                }                                                                                           // MakerGen.cs:238
                                            };                                                                                              // MakerGen.cs:239
                                        }                                                                                                   // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:226
                                            // 65. ClaimResponse.addItem.detail.subDetail.net
                                            this.Element_Net = new ElementDefinitionInfo                                                    // MakerGen.cs:228
                                            {                                                                                               // MakerGen.cs:229
                                                Name = "Element_Net",                                                                       // MakerGen.cs:230
                                                Path= "ClaimResponse.addItem.detail.subDetail.net",                                         // MakerGen.cs:231
                                                Id = "ClaimResponse.addItem.detail.subDetail.net",                                          // MakerGen.cs:232
                                                Min = 0,                                                                                    // MakerGen.cs:233
                                                Max = 1,                                                                                    // MakerGen.cs:234
                                                Types = new BaseType[]                                                                      // MakerGen.cs:235
                                                {                                                                                           // MakerGen.cs:236
                                                    new FhirKhit.Maker.Common.Complex.Type_Money                                            // MakerGen.cs:350
                                                    {                                                                                       // MakerGen.cs:351
                                                    }                                                                                       // MakerGen.cs:352
                                                }                                                                                           // MakerGen.cs:238
                                            };                                                                                              // MakerGen.cs:239
                                        }                                                                                                   // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:226
                                            // 66. ClaimResponse.addItem.detail.subDetail.noteNumber
                                            this.Element_NoteNumber = new ElementDefinitionInfo                                             // MakerGen.cs:228
                                            {                                                                                               // MakerGen.cs:229
                                                Name = "Element_NoteNumber",                                                                // MakerGen.cs:230
                                                Path= "ClaimResponse.addItem.detail.subDetail.noteNumber",                                  // MakerGen.cs:231
                                                Id = "ClaimResponse.addItem.detail.subDetail.noteNumber",                                   // MakerGen.cs:232
                                                Min = 0,                                                                                    // MakerGen.cs:233
                                                Max = -1,                                                                                   // MakerGen.cs:234
                                                Types = new BaseType[]                                                                      // MakerGen.cs:235
                                                {                                                                                           // MakerGen.cs:236
                                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                         // MakerGen.cs:295
                                                    {                                                                                       // MakerGen.cs:296
                                                    }                                                                                       // MakerGen.cs:299
                                                }                                                                                           // MakerGen.cs:238
                                            };                                                                                              // MakerGen.cs:239
                                        }                                                                                                   // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:226
                                            // 67. ClaimResponse.addItem.detail.subDetail.adjudication
                                            this.Element_Adjudication = new ElementDefinitionInfo                                           // MakerGen.cs:228
                                            {                                                                                               // MakerGen.cs:229
                                                Name = "Element_Adjudication",                                                              // MakerGen.cs:230
                                                Path= "ClaimResponse.addItem.detail.subDetail.adjudication",                                // MakerGen.cs:231
                                                Id = "ClaimResponse.addItem.detail.subDetail.adjudication",                                 // MakerGen.cs:232
                                                Min = 1,                                                                                    // MakerGen.cs:233
                                                Max = -1,                                                                                   // MakerGen.cs:234
                                                Types = new BaseType[]                                                                      // MakerGen.cs:235
                                                {                                                                                           // MakerGen.cs:236
                                                }                                                                                           // MakerGen.cs:238
                                            };                                                                                              // MakerGen.cs:239
                                        }                                                                                                   // MakerGen.cs:240
                                    }                                                                                                       // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
                                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                     // MakerGen.cs:390
                                    {                                                                                                       // MakerGen.cs:391
                                        base.Write(sDef);                                                                                   // MakerGen.cs:392
                                        Element_ProductOrService.Write(sDef);                                                               // MakerGen.cs:215
                                        Element_Modifier.Write(sDef);                                                                       // MakerGen.cs:215
                                        Element_Quantity.Write(sDef);                                                                       // MakerGen.cs:215
                                        Element_UnitPrice.Write(sDef);                                                                      // MakerGen.cs:215
                                        Element_Factor.Write(sDef);                                                                         // MakerGen.cs:215
                                        Element_Net.Write(sDef);                                                                            // MakerGen.cs:215
                                        Element_NoteNumber.Write(sDef);                                                                     // MakerGen.cs:215
                                        Element_Adjudication.Write(sDef);                                                                   // MakerGen.cs:215
                                    }                                                                                                       // MakerGen.cs:394
                                }                                                                                                           // MakerGen.cs:396
                                public Type_SubDetail_Elements Elements                                                                     // MakerGen.cs:398
                                {                                                                                                           // MakerGen.cs:399
                                    get                                                                                                     // MakerGen.cs:400
                                    {                                                                                                       // MakerGen.cs:401
                                        if (this.elements == null)                                                                          // MakerGen.cs:402
                                            this.elements = new Type_SubDetail_Elements();                                                  // MakerGen.cs:403
                                        return this.elements;                                                                               // MakerGen.cs:404
                                    }                                                                                                       // MakerGen.cs:405
                                }                                                                                                           // MakerGen.cs:406
                                Type_SubDetail_Elements elements;                                                                           // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                                public Type_SubDetail()                                                                                     // MakerGen.cs:410
                                {                                                                                                           // MakerGen.cs:411
                                }                                                                                                           // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                         // MakerGen.cs:416
                                {                                                                                                           // MakerGen.cs:417
                                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                      // MakerGen.cs:418
                                    {                                                                                                       // MakerGen.cs:419
                                        Path = "ClaimResponse.addItem.detail.subDetail",                                                    // MakerGen.cs:420
                                        ElementId = "ClaimResponse.addItem.detail.subDetail"                                                // MakerGen.cs:421
                                    });                                                                                                     // MakerGen.cs:422
                                    if (this.elements != null)                                                                              // MakerGen.cs:423
                                        this.elements.Write(sDef);                                                                          // MakerGen.cs:424
                                }                                                                                                           // MakerGen.cs:425
                            }                                                                                                               // MakerGen.cs:426
                            // 51. ClaimResponse.addItem.detail.productOrService
                            public ElementDefinitionInfo Element_ProductOrService;                                                          // MakerGen.cs:211
                            // 52. ClaimResponse.addItem.detail.modifier
                            public ElementDefinitionInfo Element_Modifier;                                                                  // MakerGen.cs:211
                            // 53. ClaimResponse.addItem.detail.quantity
                            public ElementDefinitionInfo Element_Quantity;                                                                  // MakerGen.cs:211
                            // 54. ClaimResponse.addItem.detail.unitPrice
                            public ElementDefinitionInfo Element_UnitPrice;                                                                 // MakerGen.cs:211
                            // 55. ClaimResponse.addItem.detail.factor
                            public ElementDefinitionInfo Element_Factor;                                                                    // MakerGen.cs:211
                            // 56. ClaimResponse.addItem.detail.net
                            public ElementDefinitionInfo Element_Net;                                                                       // MakerGen.cs:211
                            // 57. ClaimResponse.addItem.detail.noteNumber
                            public ElementDefinitionInfo Element_NoteNumber;                                                                // MakerGen.cs:211
                            // 58. ClaimResponse.addItem.detail.adjudication
                            public ElementDefinitionInfo Element_Adjudication;                                                              // MakerGen.cs:211
                            // 59. ClaimResponse.addItem.detail.subDetail
                            public ElementDefinitionInfo Element_SubDetail;                                                                 // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                            public Type_Detail_Elements()                                                                                   // MakerGen.cs:384
                            {                                                                                                               // MakerGen.cs:385
                                {                                                                                                           // MakerGen.cs:226
                                    // 51. ClaimResponse.addItem.detail.productOrService
                                    this.Element_ProductOrService = new ElementDefinitionInfo                                               // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_ProductOrService",                                                                  // MakerGen.cs:230
                                        Path= "ClaimResponse.addItem.detail.productOrService",                                              // MakerGen.cs:231
                                        Id = "ClaimResponse.addItem.detail.productOrService",                                               // MakerGen.cs:232
                                        Min = 1,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                          // MakerGen.cs:310
                                            {                                                                                               // MakerGen.cs:311
                                            }                                                                                               // MakerGen.cs:314
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 52. ClaimResponse.addItem.detail.modifier
                                    this.Element_Modifier = new ElementDefinitionInfo                                                       // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_Modifier",                                                                          // MakerGen.cs:230
                                        Path= "ClaimResponse.addItem.detail.modifier",                                                      // MakerGen.cs:231
                                        Id = "ClaimResponse.addItem.detail.modifier",                                                       // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = -1,                                                                                           // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                          // MakerGen.cs:310
                                            {                                                                                               // MakerGen.cs:311
                                            }                                                                                               // MakerGen.cs:314
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 53. ClaimResponse.addItem.detail.quantity
                                    this.Element_Quantity = new ElementDefinitionInfo                                                       // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_Quantity",                                                                          // MakerGen.cs:230
                                        Path= "ClaimResponse.addItem.detail.quantity",                                                      // MakerGen.cs:231
                                        Id = "ClaimResponse.addItem.detail.quantity",                                                       // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.Type_Quantity                                                 // MakerGen.cs:350
                                            {                                                                                               // MakerGen.cs:351
                                            }                                                                                               // MakerGen.cs:352
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 54. ClaimResponse.addItem.detail.unitPrice
                                    this.Element_UnitPrice = new ElementDefinitionInfo                                                      // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_UnitPrice",                                                                         // MakerGen.cs:230
                                        Path= "ClaimResponse.addItem.detail.unitPrice",                                                     // MakerGen.cs:231
                                        Id = "ClaimResponse.addItem.detail.unitPrice",                                                      // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.Type_Money                                                    // MakerGen.cs:350
                                            {                                                                                               // MakerGen.cs:351
                                            }                                                                                               // MakerGen.cs:352
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 55. ClaimResponse.addItem.detail.factor
                                    this.Element_Factor = new ElementDefinitionInfo                                                         // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_Factor",                                                                            // MakerGen.cs:230
                                        Path= "ClaimResponse.addItem.detail.factor",                                                        // MakerGen.cs:231
                                        Id = "ClaimResponse.addItem.detail.factor",                                                         // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.Decimal                                                     // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 56. ClaimResponse.addItem.detail.net
                                    this.Element_Net = new ElementDefinitionInfo                                                            // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_Net",                                                                               // MakerGen.cs:230
                                        Path= "ClaimResponse.addItem.detail.net",                                                           // MakerGen.cs:231
                                        Id = "ClaimResponse.addItem.detail.net",                                                            // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.Type_Money                                                    // MakerGen.cs:350
                                            {                                                                                               // MakerGen.cs:351
                                            }                                                                                               // MakerGen.cs:352
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 57. ClaimResponse.addItem.detail.noteNumber
                                    this.Element_NoteNumber = new ElementDefinitionInfo                                                     // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_NoteNumber",                                                                        // MakerGen.cs:230
                                        Path= "ClaimResponse.addItem.detail.noteNumber",                                                    // MakerGen.cs:231
                                        Id = "ClaimResponse.addItem.detail.noteNumber",                                                     // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = -1,                                                                                           // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.PositiveInt                                                 // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 58. ClaimResponse.addItem.detail.adjudication
                                    this.Element_Adjudication = new ElementDefinitionInfo                                                   // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_Adjudication",                                                                      // MakerGen.cs:230
                                        Path= "ClaimResponse.addItem.detail.adjudication",                                                  // MakerGen.cs:231
                                        Id = "ClaimResponse.addItem.detail.adjudication",                                                   // MakerGen.cs:232
                                        Min = 1,                                                                                            // MakerGen.cs:233
                                        Max = -1,                                                                                           // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 59. ClaimResponse.addItem.detail.subDetail
                                    this.Element_SubDetail = new ElementDefinitionInfo                                                      // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Element_SubDetail",                                                                         // MakerGen.cs:230
                                        Path= "ClaimResponse.addItem.detail.subDetail",                                                     // MakerGen.cs:231
                                        Id = "ClaimResponse.addItem.detail.subDetail",                                                      // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = -1,                                                                                           // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new Type_SubDetail                                                                              // MakerGen.cs:254
                                            {                                                                                               // MakerGen.cs:255
                                            }                                                                                               // MakerGen.cs:256
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:390
                            {                                                                                                               // MakerGen.cs:391
                                base.Write(sDef);                                                                                           // MakerGen.cs:392
                                Element_ProductOrService.Write(sDef);                                                                       // MakerGen.cs:215
                                Element_Modifier.Write(sDef);                                                                               // MakerGen.cs:215
                                Element_Quantity.Write(sDef);                                                                               // MakerGen.cs:215
                                Element_UnitPrice.Write(sDef);                                                                              // MakerGen.cs:215
                                Element_Factor.Write(sDef);                                                                                 // MakerGen.cs:215
                                Element_Net.Write(sDef);                                                                                    // MakerGen.cs:215
                                Element_NoteNumber.Write(sDef);                                                                             // MakerGen.cs:215
                                Element_Adjudication.Write(sDef);                                                                           // MakerGen.cs:215
                                Element_SubDetail.Write(sDef);                                                                              // MakerGen.cs:215
                            }                                                                                                               // MakerGen.cs:394
                        }                                                                                                                   // MakerGen.cs:396
                        public Type_Detail_Elements Elements                                                                                // MakerGen.cs:398
                        {                                                                                                                   // MakerGen.cs:399
                            get                                                                                                             // MakerGen.cs:400
                            {                                                                                                               // MakerGen.cs:401
                                if (this.elements == null)                                                                                  // MakerGen.cs:402
                                    this.elements = new Type_Detail_Elements();                                                             // MakerGen.cs:403
                                return this.elements;                                                                                       // MakerGen.cs:404
                            }                                                                                                               // MakerGen.cs:405
                        }                                                                                                                   // MakerGen.cs:406
                        Type_Detail_Elements elements;                                                                                      // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                        public Type_Detail()                                                                                                // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:411
                        }                                                                                                                   // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:416
                        {                                                                                                                   // MakerGen.cs:417
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:418
                            {                                                                                                               // MakerGen.cs:419
                                Path = "ClaimResponse.addItem.detail",                                                                      // MakerGen.cs:420
                                ElementId = "ClaimResponse.addItem.detail"                                                                  // MakerGen.cs:421
                            });                                                                                                             // MakerGen.cs:422
                            if (this.elements != null)                                                                                      // MakerGen.cs:423
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:424
                        }                                                                                                                   // MakerGen.cs:425
                    }                                                                                                                       // MakerGen.cs:426
                    // 33. ClaimResponse.addItem.itemSequence
                    public ElementDefinitionInfo Element_ItemSequence;                                                                      // MakerGen.cs:211
                    // 34. ClaimResponse.addItem.detailSequence
                    public ElementDefinitionInfo Element_DetailSequence;                                                                    // MakerGen.cs:211
                    // 35. ClaimResponse.addItem.subdetailSequence
                    public ElementDefinitionInfo Element_SubdetailSequence;                                                                 // MakerGen.cs:211
                    // 36. ClaimResponse.addItem.provider
                    public ElementDefinitionInfo Element_Provider;                                                                          // MakerGen.cs:211
                    // 37. ClaimResponse.addItem.productOrService
                    public ElementDefinitionInfo Element_ProductOrService;                                                                  // MakerGen.cs:211
                    // 38. ClaimResponse.addItem.modifier
                    public ElementDefinitionInfo Element_Modifier;                                                                          // MakerGen.cs:211
                    // 39. ClaimResponse.addItem.programCode
                    public ElementDefinitionInfo Element_ProgramCode;                                                                       // MakerGen.cs:211
                    // 40. ClaimResponse.addItem.serviced[x]
                    public ElementDefinitionInfo Element_Serviced;                                                                          // MakerGen.cs:211
                    // 41. ClaimResponse.addItem.location[x]
                    public ElementDefinitionInfo Element_Location;                                                                          // MakerGen.cs:211
                    // 42. ClaimResponse.addItem.quantity
                    public ElementDefinitionInfo Element_Quantity;                                                                          // MakerGen.cs:211
                    // 43. ClaimResponse.addItem.unitPrice
                    public ElementDefinitionInfo Element_UnitPrice;                                                                         // MakerGen.cs:211
                    // 44. ClaimResponse.addItem.factor
                    public ElementDefinitionInfo Element_Factor;                                                                            // MakerGen.cs:211
                    // 45. ClaimResponse.addItem.net
                    public ElementDefinitionInfo Element_Net;                                                                               // MakerGen.cs:211
                    // 46. ClaimResponse.addItem.bodySite
                    public ElementDefinitionInfo Element_BodySite;                                                                          // MakerGen.cs:211
                    // 47. ClaimResponse.addItem.subSite
                    public ElementDefinitionInfo Element_SubSite;                                                                           // MakerGen.cs:211
                    // 48. ClaimResponse.addItem.noteNumber
                    public ElementDefinitionInfo Element_NoteNumber;                                                                        // MakerGen.cs:211
                    // 49. ClaimResponse.addItem.adjudication
                    public ElementDefinitionInfo Element_Adjudication;                                                                      // MakerGen.cs:211
                    // 50. ClaimResponse.addItem.detail
                    public ElementDefinitionInfo Element_Detail;                                                                            // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                    public Type_AddItem_Elements()                                                                                          // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:226
                            // 33. ClaimResponse.addItem.itemSequence
                            this.Element_ItemSequence = new ElementDefinitionInfo                                                           // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_ItemSequence",                                                                              // MakerGen.cs:230
                                Path= "ClaimResponse.addItem.itemSequence",                                                                 // MakerGen.cs:231
                                Id = "ClaimResponse.addItem.itemSequence",                                                                  // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                                         // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 34. ClaimResponse.addItem.detailSequence
                            this.Element_DetailSequence = new ElementDefinitionInfo                                                         // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_DetailSequence",                                                                            // MakerGen.cs:230
                                Path= "ClaimResponse.addItem.detailSequence",                                                               // MakerGen.cs:231
                                Id = "ClaimResponse.addItem.detailSequence",                                                                // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                                         // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 35. ClaimResponse.addItem.subdetailSequence
                            this.Element_SubdetailSequence = new ElementDefinitionInfo                                                      // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_SubdetailSequence",                                                                         // MakerGen.cs:230
                                Path= "ClaimResponse.addItem.subdetailSequence",                                                            // MakerGen.cs:231
                                Id = "ClaimResponse.addItem.subdetailSequence",                                                             // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                                         // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 36. ClaimResponse.addItem.provider
                            this.Element_Provider = new ElementDefinitionInfo                                                               // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Provider",                                                                                  // MakerGen.cs:230
                                Path= "ClaimResponse.addItem.provider",                                                                     // MakerGen.cs:231
                                Id = "ClaimResponse.addItem.provider",                                                                      // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_Reference                                                        // MakerGen.cs:338
                                    {                                                                                                       // MakerGen.cs:339
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:341
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Practitioner",                                         // MakerGen.cs:341
                                            "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                     // MakerGen.cs:341
                                            "http://hl7.org/fhir/StructureDefinition/Organization"                                          // MakerGen.cs:341
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:342
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 37. ClaimResponse.addItem.productOrService
                            this.Element_ProductOrService = new ElementDefinitionInfo                                                       // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_ProductOrService",                                                                          // MakerGen.cs:230
                                Path= "ClaimResponse.addItem.productOrService",                                                             // MakerGen.cs:231
                                Id = "ClaimResponse.addItem.productOrService",                                                              // MakerGen.cs:232
                                Min = 1,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                  // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 38. ClaimResponse.addItem.modifier
                            this.Element_Modifier = new ElementDefinitionInfo                                                               // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Modifier",                                                                                  // MakerGen.cs:230
                                Path= "ClaimResponse.addItem.modifier",                                                                     // MakerGen.cs:231
                                Id = "ClaimResponse.addItem.modifier",                                                                      // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                  // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 39. ClaimResponse.addItem.programCode
                            this.Element_ProgramCode = new ElementDefinitionInfo                                                            // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_ProgramCode",                                                                               // MakerGen.cs:230
                                Path= "ClaimResponse.addItem.programCode",                                                                  // MakerGen.cs:231
                                Id = "ClaimResponse.addItem.programCode",                                                                   // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                  // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 40. ClaimResponse.addItem.serviced[x]
                            this.Element_Serviced = new ElementDefinitionInfo                                                               // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Serviced",                                                                                  // MakerGen.cs:230
                                Path= "ClaimResponse.addItem.serviced[x]",                                                                  // MakerGen.cs:231
                                Id = "ClaimResponse.addItem.serviced[x]",                                                                   // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Date                                                                // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    },                                                                                                      // MakerGen.cs:299
                                    new FhirKhit.Maker.Common.Complex.Type_Period                                                           // MakerGen.cs:350
                                    {                                                                                                       // MakerGen.cs:351
                                    }                                                                                                       // MakerGen.cs:352
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 41. ClaimResponse.addItem.location[x]
                            this.Element_Location = new ElementDefinitionInfo                                                               // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Location",                                                                                  // MakerGen.cs:230
                                Path= "ClaimResponse.addItem.location[x]",                                                                  // MakerGen.cs:231
                                Id = "ClaimResponse.addItem.location[x]",                                                                   // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                  // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    },                                                                                                      // MakerGen.cs:314
                                    new FhirKhit.Maker.Common.Complex.Type_Address                                                          // MakerGen.cs:350
                                    {                                                                                                       // MakerGen.cs:351
                                    },                                                                                                      // MakerGen.cs:352
                                    new FhirKhit.Maker.Common.Complex.Type_Reference                                                        // MakerGen.cs:338
                                    {                                                                                                       // MakerGen.cs:339
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:341
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Location"                                              // MakerGen.cs:341
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:342
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 42. ClaimResponse.addItem.quantity
                            this.Element_Quantity = new ElementDefinitionInfo                                                               // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Quantity",                                                                                  // MakerGen.cs:230
                                Path= "ClaimResponse.addItem.quantity",                                                                     // MakerGen.cs:231
                                Id = "ClaimResponse.addItem.quantity",                                                                      // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_Quantity                                                         // MakerGen.cs:350
                                    {                                                                                                       // MakerGen.cs:351
                                    }                                                                                                       // MakerGen.cs:352
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 43. ClaimResponse.addItem.unitPrice
                            this.Element_UnitPrice = new ElementDefinitionInfo                                                              // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_UnitPrice",                                                                                 // MakerGen.cs:230
                                Path= "ClaimResponse.addItem.unitPrice",                                                                    // MakerGen.cs:231
                                Id = "ClaimResponse.addItem.unitPrice",                                                                     // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_Money                                                            // MakerGen.cs:350
                                    {                                                                                                       // MakerGen.cs:351
                                    }                                                                                                       // MakerGen.cs:352
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 44. ClaimResponse.addItem.factor
                            this.Element_Factor = new ElementDefinitionInfo                                                                 // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Factor",                                                                                    // MakerGen.cs:230
                                Path= "ClaimResponse.addItem.factor",                                                                       // MakerGen.cs:231
                                Id = "ClaimResponse.addItem.factor",                                                                        // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Decimal                                                             // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 45. ClaimResponse.addItem.net
                            this.Element_Net = new ElementDefinitionInfo                                                                    // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Net",                                                                                       // MakerGen.cs:230
                                Path= "ClaimResponse.addItem.net",                                                                          // MakerGen.cs:231
                                Id = "ClaimResponse.addItem.net",                                                                           // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_Money                                                            // MakerGen.cs:350
                                    {                                                                                                       // MakerGen.cs:351
                                    }                                                                                                       // MakerGen.cs:352
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 46. ClaimResponse.addItem.bodySite
                            this.Element_BodySite = new ElementDefinitionInfo                                                               // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_BodySite",                                                                                  // MakerGen.cs:230
                                Path= "ClaimResponse.addItem.bodySite",                                                                     // MakerGen.cs:231
                                Id = "ClaimResponse.addItem.bodySite",                                                                      // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                  // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 47. ClaimResponse.addItem.subSite
                            this.Element_SubSite = new ElementDefinitionInfo                                                                // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_SubSite",                                                                                   // MakerGen.cs:230
                                Path= "ClaimResponse.addItem.subSite",                                                                      // MakerGen.cs:231
                                Id = "ClaimResponse.addItem.subSite",                                                                       // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                  // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 48. ClaimResponse.addItem.noteNumber
                            this.Element_NoteNumber = new ElementDefinitionInfo                                                             // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_NoteNumber",                                                                                // MakerGen.cs:230
                                Path= "ClaimResponse.addItem.noteNumber",                                                                   // MakerGen.cs:231
                                Id = "ClaimResponse.addItem.noteNumber",                                                                    // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                                         // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 49. ClaimResponse.addItem.adjudication
                            this.Element_Adjudication = new ElementDefinitionInfo                                                           // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Adjudication",                                                                              // MakerGen.cs:230
                                Path= "ClaimResponse.addItem.adjudication",                                                                 // MakerGen.cs:231
                                Id = "ClaimResponse.addItem.adjudication",                                                                  // MakerGen.cs:232
                                Min = 1,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 50. ClaimResponse.addItem.detail
                            this.Element_Detail = new ElementDefinitionInfo                                                                 // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Detail",                                                                                    // MakerGen.cs:230
                                Path= "ClaimResponse.addItem.detail",                                                                       // MakerGen.cs:231
                                Id = "ClaimResponse.addItem.detail",                                                                        // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new Type_Detail                                                                                         // MakerGen.cs:254
                                    {                                                                                                       // MakerGen.cs:255
                                    }                                                                                                       // MakerGen.cs:256
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:390
                    {                                                                                                                       // MakerGen.cs:391
                        base.Write(sDef);                                                                                                   // MakerGen.cs:392
                        Element_ItemSequence.Write(sDef);                                                                                   // MakerGen.cs:215
                        Element_DetailSequence.Write(sDef);                                                                                 // MakerGen.cs:215
                        Element_SubdetailSequence.Write(sDef);                                                                              // MakerGen.cs:215
                        Element_Provider.Write(sDef);                                                                                       // MakerGen.cs:215
                        Element_ProductOrService.Write(sDef);                                                                               // MakerGen.cs:215
                        Element_Modifier.Write(sDef);                                                                                       // MakerGen.cs:215
                        Element_ProgramCode.Write(sDef);                                                                                    // MakerGen.cs:215
                        Element_Serviced.Write(sDef);                                                                                       // MakerGen.cs:215
                        Element_Location.Write(sDef);                                                                                       // MakerGen.cs:215
                        Element_Quantity.Write(sDef);                                                                                       // MakerGen.cs:215
                        Element_UnitPrice.Write(sDef);                                                                                      // MakerGen.cs:215
                        Element_Factor.Write(sDef);                                                                                         // MakerGen.cs:215
                        Element_Net.Write(sDef);                                                                                            // MakerGen.cs:215
                        Element_BodySite.Write(sDef);                                                                                       // MakerGen.cs:215
                        Element_SubSite.Write(sDef);                                                                                        // MakerGen.cs:215
                        Element_NoteNumber.Write(sDef);                                                                                     // MakerGen.cs:215
                        Element_Adjudication.Write(sDef);                                                                                   // MakerGen.cs:215
                        Element_Detail.Write(sDef);                                                                                         // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:394
                }                                                                                                                           // MakerGen.cs:396
                public Type_AddItem_Elements Elements                                                                                       // MakerGen.cs:398
                {                                                                                                                           // MakerGen.cs:399
                    get                                                                                                                     // MakerGen.cs:400
                    {                                                                                                                       // MakerGen.cs:401
                        if (this.elements == null)                                                                                          // MakerGen.cs:402
                            this.elements = new Type_AddItem_Elements();                                                                    // MakerGen.cs:403
                        return this.elements;                                                                                               // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                }                                                                                                                           // MakerGen.cs:406
                Type_AddItem_Elements elements;                                                                                             // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                public Type_AddItem()                                                                                                       // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:411
                }                                                                                                                           // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:416
                {                                                                                                                           // MakerGen.cs:417
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:418
                    {                                                                                                                       // MakerGen.cs:419
                        Path = "ClaimResponse.addItem",                                                                                     // MakerGen.cs:420
                        ElementId = "ClaimResponse.addItem"                                                                                 // MakerGen.cs:421
                    });                                                                                                                     // MakerGen.cs:422
                    if (this.elements != null)                                                                                              // MakerGen.cs:423
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:424
                }                                                                                                                           // MakerGen.cs:425
            }                                                                                                                               // MakerGen.cs:426
            // 69. ClaimResponse.total
            public class Type_Total : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                public class Type_Total_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                              // MakerGen.cs:378
                {                                                                                                                           // MakerGen.cs:379
                    // 70. ClaimResponse.total.category
                    public ElementDefinitionInfo Element_Category;                                                                          // MakerGen.cs:211
                    // 71. ClaimResponse.total.amount
                    public ElementDefinitionInfo Element_Amount;                                                                            // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                    public Type_Total_Elements()                                                                                            // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:226
                            // 70. ClaimResponse.total.category
                            this.Element_Category = new ElementDefinitionInfo                                                               // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Category",                                                                                  // MakerGen.cs:230
                                Path= "ClaimResponse.total.category",                                                                       // MakerGen.cs:231
                                Id = "ClaimResponse.total.category",                                                                        // MakerGen.cs:232
                                Min = 1,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                  // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 71. ClaimResponse.total.amount
                            this.Element_Amount = new ElementDefinitionInfo                                                                 // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Amount",                                                                                    // MakerGen.cs:230
                                Path= "ClaimResponse.total.amount",                                                                         // MakerGen.cs:231
                                Id = "ClaimResponse.total.amount",                                                                          // MakerGen.cs:232
                                Min = 1,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_Money                                                            // MakerGen.cs:350
                                    {                                                                                                       // MakerGen.cs:351
                                    }                                                                                                       // MakerGen.cs:352
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:390
                    {                                                                                                                       // MakerGen.cs:391
                        base.Write(sDef);                                                                                                   // MakerGen.cs:392
                        Element_Category.Write(sDef);                                                                                       // MakerGen.cs:215
                        Element_Amount.Write(sDef);                                                                                         // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:394
                }                                                                                                                           // MakerGen.cs:396
                public Type_Total_Elements Elements                                                                                         // MakerGen.cs:398
                {                                                                                                                           // MakerGen.cs:399
                    get                                                                                                                     // MakerGen.cs:400
                    {                                                                                                                       // MakerGen.cs:401
                        if (this.elements == null)                                                                                          // MakerGen.cs:402
                            this.elements = new Type_Total_Elements();                                                                      // MakerGen.cs:403
                        return this.elements;                                                                                               // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                }                                                                                                                           // MakerGen.cs:406
                Type_Total_Elements elements;                                                                                               // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                public Type_Total()                                                                                                         // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:411
                }                                                                                                                           // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:416
                {                                                                                                                           // MakerGen.cs:417
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:418
                    {                                                                                                                       // MakerGen.cs:419
                        Path = "ClaimResponse.total",                                                                                       // MakerGen.cs:420
                        ElementId = "ClaimResponse.total"                                                                                   // MakerGen.cs:421
                    });                                                                                                                     // MakerGen.cs:422
                    if (this.elements != null)                                                                                              // MakerGen.cs:423
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:424
                }                                                                                                                           // MakerGen.cs:425
            }                                                                                                                               // MakerGen.cs:426
            // 72. ClaimResponse.payment
            public class Type_Payment : FhirKhit.Maker.Common.Complex.ComplexBase                                                           // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                public class Type_Payment_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                            // MakerGen.cs:378
                {                                                                                                                           // MakerGen.cs:379
                    // 73. ClaimResponse.payment.type
                    public ElementDefinitionInfo Element_Type;                                                                              // MakerGen.cs:211
                    // 74. ClaimResponse.payment.adjustment
                    public ElementDefinitionInfo Element_Adjustment;                                                                        // MakerGen.cs:211
                    // 75. ClaimResponse.payment.adjustmentReason
                    public ElementDefinitionInfo Element_AdjustmentReason;                                                                  // MakerGen.cs:211
                    // 76. ClaimResponse.payment.date
                    public ElementDefinitionInfo Element_Date;                                                                              // MakerGen.cs:211
                    // 77. ClaimResponse.payment.amount
                    public ElementDefinitionInfo Element_Amount;                                                                            // MakerGen.cs:211
                    // 78. ClaimResponse.payment.identifier
                    public ElementDefinitionInfo Element_Identifier;                                                                        // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                    public Type_Payment_Elements()                                                                                          // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:226
                            // 73. ClaimResponse.payment.type
                            this.Element_Type = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Type",                                                                                      // MakerGen.cs:230
                                Path= "ClaimResponse.payment.type",                                                                         // MakerGen.cs:231
                                Id = "ClaimResponse.payment.type",                                                                          // MakerGen.cs:232
                                Min = 1,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                  // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 74. ClaimResponse.payment.adjustment
                            this.Element_Adjustment = new ElementDefinitionInfo                                                             // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Adjustment",                                                                                // MakerGen.cs:230
                                Path= "ClaimResponse.payment.adjustment",                                                                   // MakerGen.cs:231
                                Id = "ClaimResponse.payment.adjustment",                                                                    // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_Money                                                            // MakerGen.cs:350
                                    {                                                                                                       // MakerGen.cs:351
                                    }                                                                                                       // MakerGen.cs:352
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 75. ClaimResponse.payment.adjustmentReason
                            this.Element_AdjustmentReason = new ElementDefinitionInfo                                                       // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_AdjustmentReason",                                                                          // MakerGen.cs:230
                                Path= "ClaimResponse.payment.adjustmentReason",                                                             // MakerGen.cs:231
                                Id = "ClaimResponse.payment.adjustmentReason",                                                              // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                  // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 76. ClaimResponse.payment.date
                            this.Element_Date = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Date",                                                                                      // MakerGen.cs:230
                                Path= "ClaimResponse.payment.date",                                                                         // MakerGen.cs:231
                                Id = "ClaimResponse.payment.date",                                                                          // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Date                                                                // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 77. ClaimResponse.payment.amount
                            this.Element_Amount = new ElementDefinitionInfo                                                                 // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Amount",                                                                                    // MakerGen.cs:230
                                Path= "ClaimResponse.payment.amount",                                                                       // MakerGen.cs:231
                                Id = "ClaimResponse.payment.amount",                                                                        // MakerGen.cs:232
                                Min = 1,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_Money                                                            // MakerGen.cs:350
                                    {                                                                                                       // MakerGen.cs:351
                                    }                                                                                                       // MakerGen.cs:352
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 78. ClaimResponse.payment.identifier
                            this.Element_Identifier = new ElementDefinitionInfo                                                             // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Identifier",                                                                                // MakerGen.cs:230
                                Path= "ClaimResponse.payment.identifier",                                                                   // MakerGen.cs:231
                                Id = "ClaimResponse.payment.identifier",                                                                    // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_Identifier                                                       // MakerGen.cs:350
                                    {                                                                                                       // MakerGen.cs:351
                                    }                                                                                                       // MakerGen.cs:352
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:390
                    {                                                                                                                       // MakerGen.cs:391
                        base.Write(sDef);                                                                                                   // MakerGen.cs:392
                        Element_Type.Write(sDef);                                                                                           // MakerGen.cs:215
                        Element_Adjustment.Write(sDef);                                                                                     // MakerGen.cs:215
                        Element_AdjustmentReason.Write(sDef);                                                                               // MakerGen.cs:215
                        Element_Date.Write(sDef);                                                                                           // MakerGen.cs:215
                        Element_Amount.Write(sDef);                                                                                         // MakerGen.cs:215
                        Element_Identifier.Write(sDef);                                                                                     // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:394
                }                                                                                                                           // MakerGen.cs:396
                public Type_Payment_Elements Elements                                                                                       // MakerGen.cs:398
                {                                                                                                                           // MakerGen.cs:399
                    get                                                                                                                     // MakerGen.cs:400
                    {                                                                                                                       // MakerGen.cs:401
                        if (this.elements == null)                                                                                          // MakerGen.cs:402
                            this.elements = new Type_Payment_Elements();                                                                    // MakerGen.cs:403
                        return this.elements;                                                                                               // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                }                                                                                                                           // MakerGen.cs:406
                Type_Payment_Elements elements;                                                                                             // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                public Type_Payment()                                                                                                       // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:411
                }                                                                                                                           // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:416
                {                                                                                                                           // MakerGen.cs:417
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:418
                    {                                                                                                                       // MakerGen.cs:419
                        Path = "ClaimResponse.payment",                                                                                     // MakerGen.cs:420
                        ElementId = "ClaimResponse.payment"                                                                                 // MakerGen.cs:421
                    });                                                                                                                     // MakerGen.cs:422
                    if (this.elements != null)                                                                                              // MakerGen.cs:423
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:424
                }                                                                                                                           // MakerGen.cs:425
            }                                                                                                                               // MakerGen.cs:426
            // 82. ClaimResponse.processNote
            public class Type_ProcessNote : FhirKhit.Maker.Common.Complex.ComplexBase                                                       // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                public class Type_ProcessNote_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                        // MakerGen.cs:378
                {                                                                                                                           // MakerGen.cs:379
                    // 83. ClaimResponse.processNote.number
                    public ElementDefinitionInfo Element_Number;                                                                            // MakerGen.cs:211
                    // 84. ClaimResponse.processNote.type
                    public ElementDefinitionInfo Element_Type;                                                                              // MakerGen.cs:211
                    // 85. ClaimResponse.processNote.text
                    public ElementDefinitionInfo Element_Text;                                                                              // MakerGen.cs:211
                    // 86. ClaimResponse.processNote.language
                    public ElementDefinitionInfo Element_Language;                                                                          // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                    public Type_ProcessNote_Elements()                                                                                      // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:226
                            // 83. ClaimResponse.processNote.number
                            this.Element_Number = new ElementDefinitionInfo                                                                 // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Number",                                                                                    // MakerGen.cs:230
                                Path= "ClaimResponse.processNote.number",                                                                   // MakerGen.cs:231
                                Id = "ClaimResponse.processNote.number",                                                                    // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                                         // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 84. ClaimResponse.processNote.type
                            this.Element_Type = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Type",                                                                                      // MakerGen.cs:230
                                Path= "ClaimResponse.processNote.type",                                                                     // MakerGen.cs:231
                                Id = "ClaimResponse.processNote.type",                                                                      // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 85. ClaimResponse.processNote.text
                            this.Element_Text = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Text",                                                                                      // MakerGen.cs:230
                                Path= "ClaimResponse.processNote.text",                                                                     // MakerGen.cs:231
                                Id = "ClaimResponse.processNote.text",                                                                      // MakerGen.cs:232
                                Min = 1,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 86. ClaimResponse.processNote.language
                            this.Element_Language = new ElementDefinitionInfo                                                               // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Language",                                                                                  // MakerGen.cs:230
                                Path= "ClaimResponse.processNote.language",                                                                 // MakerGen.cs:231
                                Id = "ClaimResponse.processNote.language",                                                                  // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                  // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:390
                    {                                                                                                                       // MakerGen.cs:391
                        base.Write(sDef);                                                                                                   // MakerGen.cs:392
                        Element_Number.Write(sDef);                                                                                         // MakerGen.cs:215
                        Element_Type.Write(sDef);                                                                                           // MakerGen.cs:215
                        Element_Text.Write(sDef);                                                                                           // MakerGen.cs:215
                        Element_Language.Write(sDef);                                                                                       // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:394
                }                                                                                                                           // MakerGen.cs:396
                public Type_ProcessNote_Elements Elements                                                                                   // MakerGen.cs:398
                {                                                                                                                           // MakerGen.cs:399
                    get                                                                                                                     // MakerGen.cs:400
                    {                                                                                                                       // MakerGen.cs:401
                        if (this.elements == null)                                                                                          // MakerGen.cs:402
                            this.elements = new Type_ProcessNote_Elements();                                                                // MakerGen.cs:403
                        return this.elements;                                                                                               // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                }                                                                                                                           // MakerGen.cs:406
                Type_ProcessNote_Elements elements;                                                                                         // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                public Type_ProcessNote()                                                                                                   // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:411
                }                                                                                                                           // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:416
                {                                                                                                                           // MakerGen.cs:417
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:418
                    {                                                                                                                       // MakerGen.cs:419
                        Path = "ClaimResponse.processNote",                                                                                 // MakerGen.cs:420
                        ElementId = "ClaimResponse.processNote"                                                                             // MakerGen.cs:421
                    });                                                                                                                     // MakerGen.cs:422
                    if (this.elements != null)                                                                                              // MakerGen.cs:423
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:424
                }                                                                                                                           // MakerGen.cs:425
            }                                                                                                                               // MakerGen.cs:426
            // 88. ClaimResponse.insurance
            public class Type_Insurance : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                public class Type_Insurance_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                          // MakerGen.cs:378
                {                                                                                                                           // MakerGen.cs:379
                    // 89. ClaimResponse.insurance.sequence
                    public ElementDefinitionInfo Element_Sequence;                                                                          // MakerGen.cs:211
                    // 90. ClaimResponse.insurance.focal
                    public ElementDefinitionInfo Element_Focal;                                                                             // MakerGen.cs:211
                    // 91. ClaimResponse.insurance.coverage
                    public ElementDefinitionInfo Element_Coverage;                                                                          // MakerGen.cs:211
                    // 92. ClaimResponse.insurance.businessArrangement
                    public ElementDefinitionInfo Element_BusinessArrangement;                                                               // MakerGen.cs:211
                    // 93. ClaimResponse.insurance.claimResponse
                    public ElementDefinitionInfo Element_ClaimResponse;                                                                     // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                    public Type_Insurance_Elements()                                                                                        // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:226
                            // 89. ClaimResponse.insurance.sequence
                            this.Element_Sequence = new ElementDefinitionInfo                                                               // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Sequence",                                                                                  // MakerGen.cs:230
                                Path= "ClaimResponse.insurance.sequence",                                                                   // MakerGen.cs:231
                                Id = "ClaimResponse.insurance.sequence",                                                                    // MakerGen.cs:232
                                Min = 1,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                                         // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 90. ClaimResponse.insurance.focal
                            this.Element_Focal = new ElementDefinitionInfo                                                                  // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Focal",                                                                                     // MakerGen.cs:230
                                Path= "ClaimResponse.insurance.focal",                                                                      // MakerGen.cs:231
                                Id = "ClaimResponse.insurance.focal",                                                                       // MakerGen.cs:232
                                Min = 1,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Boolean                                                             // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 91. ClaimResponse.insurance.coverage
                            this.Element_Coverage = new ElementDefinitionInfo                                                               // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Coverage",                                                                                  // MakerGen.cs:230
                                Path= "ClaimResponse.insurance.coverage",                                                                   // MakerGen.cs:231
                                Id = "ClaimResponse.insurance.coverage",                                                                    // MakerGen.cs:232
                                Min = 1,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_Reference                                                        // MakerGen.cs:338
                                    {                                                                                                       // MakerGen.cs:339
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:341
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Coverage"                                              // MakerGen.cs:341
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:342
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 92. ClaimResponse.insurance.businessArrangement
                            this.Element_BusinessArrangement = new ElementDefinitionInfo                                                    // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_BusinessArrangement",                                                                       // MakerGen.cs:230
                                Path= "ClaimResponse.insurance.businessArrangement",                                                        // MakerGen.cs:231
                                Id = "ClaimResponse.insurance.businessArrangement",                                                         // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 93. ClaimResponse.insurance.claimResponse
                            this.Element_ClaimResponse = new ElementDefinitionInfo                                                          // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_ClaimResponse",                                                                             // MakerGen.cs:230
                                Path= "ClaimResponse.insurance.claimResponse",                                                              // MakerGen.cs:231
                                Id = "ClaimResponse.insurance.claimResponse",                                                               // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_Reference                                                        // MakerGen.cs:338
                                    {                                                                                                       // MakerGen.cs:339
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:341
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/ClaimResponse"                                         // MakerGen.cs:341
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:342
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:390
                    {                                                                                                                       // MakerGen.cs:391
                        base.Write(sDef);                                                                                                   // MakerGen.cs:392
                        Element_Sequence.Write(sDef);                                                                                       // MakerGen.cs:215
                        Element_Focal.Write(sDef);                                                                                          // MakerGen.cs:215
                        Element_Coverage.Write(sDef);                                                                                       // MakerGen.cs:215
                        Element_BusinessArrangement.Write(sDef);                                                                            // MakerGen.cs:215
                        Element_ClaimResponse.Write(sDef);                                                                                  // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:394
                }                                                                                                                           // MakerGen.cs:396
                public Type_Insurance_Elements Elements                                                                                     // MakerGen.cs:398
                {                                                                                                                           // MakerGen.cs:399
                    get                                                                                                                     // MakerGen.cs:400
                    {                                                                                                                       // MakerGen.cs:401
                        if (this.elements == null)                                                                                          // MakerGen.cs:402
                            this.elements = new Type_Insurance_Elements();                                                                  // MakerGen.cs:403
                        return this.elements;                                                                                               // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                }                                                                                                                           // MakerGen.cs:406
                Type_Insurance_Elements elements;                                                                                           // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                public Type_Insurance()                                                                                                     // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:411
                }                                                                                                                           // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:416
                {                                                                                                                           // MakerGen.cs:417
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:418
                    {                                                                                                                       // MakerGen.cs:419
                        Path = "ClaimResponse.insurance",                                                                                   // MakerGen.cs:420
                        ElementId = "ClaimResponse.insurance"                                                                               // MakerGen.cs:421
                    });                                                                                                                     // MakerGen.cs:422
                    if (this.elements != null)                                                                                              // MakerGen.cs:423
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:424
                }                                                                                                                           // MakerGen.cs:425
            }                                                                                                                               // MakerGen.cs:426
            // 94. ClaimResponse.error
            public class Type_Error : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                public class Type_Error_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                              // MakerGen.cs:378
                {                                                                                                                           // MakerGen.cs:379
                    // 95. ClaimResponse.error.itemSequence
                    public ElementDefinitionInfo Element_ItemSequence;                                                                      // MakerGen.cs:211
                    // 96. ClaimResponse.error.detailSequence
                    public ElementDefinitionInfo Element_DetailSequence;                                                                    // MakerGen.cs:211
                    // 97. ClaimResponse.error.subDetailSequence
                    public ElementDefinitionInfo Element_SubDetailSequence;                                                                 // MakerGen.cs:211
                    // 98. ClaimResponse.error.code
                    public ElementDefinitionInfo Element_Code;                                                                              // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                    public Type_Error_Elements()                                                                                            // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:226
                            // 95. ClaimResponse.error.itemSequence
                            this.Element_ItemSequence = new ElementDefinitionInfo                                                           // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_ItemSequence",                                                                              // MakerGen.cs:230
                                Path= "ClaimResponse.error.itemSequence",                                                                   // MakerGen.cs:231
                                Id = "ClaimResponse.error.itemSequence",                                                                    // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                                         // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 96. ClaimResponse.error.detailSequence
                            this.Element_DetailSequence = new ElementDefinitionInfo                                                         // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_DetailSequence",                                                                            // MakerGen.cs:230
                                Path= "ClaimResponse.error.detailSequence",                                                                 // MakerGen.cs:231
                                Id = "ClaimResponse.error.detailSequence",                                                                  // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                                         // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 97. ClaimResponse.error.subDetailSequence
                            this.Element_SubDetailSequence = new ElementDefinitionInfo                                                      // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_SubDetailSequence",                                                                         // MakerGen.cs:230
                                Path= "ClaimResponse.error.subDetailSequence",                                                              // MakerGen.cs:231
                                Id = "ClaimResponse.error.subDetailSequence",                                                               // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                                         // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 98. ClaimResponse.error.code
                            this.Element_Code = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Code",                                                                                      // MakerGen.cs:230
                                Path= "ClaimResponse.error.code",                                                                           // MakerGen.cs:231
                                Id = "ClaimResponse.error.code",                                                                            // MakerGen.cs:232
                                Min = 1,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                  // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:390
                    {                                                                                                                       // MakerGen.cs:391
                        base.Write(sDef);                                                                                                   // MakerGen.cs:392
                        Element_ItemSequence.Write(sDef);                                                                                   // MakerGen.cs:215
                        Element_DetailSequence.Write(sDef);                                                                                 // MakerGen.cs:215
                        Element_SubDetailSequence.Write(sDef);                                                                              // MakerGen.cs:215
                        Element_Code.Write(sDef);                                                                                           // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:394
                }                                                                                                                           // MakerGen.cs:396
                public Type_Error_Elements Elements                                                                                         // MakerGen.cs:398
                {                                                                                                                           // MakerGen.cs:399
                    get                                                                                                                     // MakerGen.cs:400
                    {                                                                                                                       // MakerGen.cs:401
                        if (this.elements == null)                                                                                          // MakerGen.cs:402
                            this.elements = new Type_Error_Elements();                                                                      // MakerGen.cs:403
                        return this.elements;                                                                                               // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                }                                                                                                                           // MakerGen.cs:406
                Type_Error_Elements elements;                                                                                               // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                public Type_Error()                                                                                                         // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:411
                }                                                                                                                           // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:416
                {                                                                                                                           // MakerGen.cs:417
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:418
                    {                                                                                                                       // MakerGen.cs:419
                        Path = "ClaimResponse.error",                                                                                       // MakerGen.cs:420
                        ElementId = "ClaimResponse.error"                                                                                   // MakerGen.cs:421
                    });                                                                                                                     // MakerGen.cs:422
                    if (this.elements != null)                                                                                              // MakerGen.cs:423
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:424
                }                                                                                                                           // MakerGen.cs:425
            }                                                                                                                               // MakerGen.cs:426
            // 1. ClaimResponse.identifier
            public ElementDefinitionInfo Element_Identifier;                                                                                // MakerGen.cs:211
            // 2. ClaimResponse.status
            public ElementDefinitionInfo Element_Status;                                                                                    // MakerGen.cs:211
            // 3. ClaimResponse.type
            public ElementDefinitionInfo Element_Type;                                                                                      // MakerGen.cs:211
            // 4. ClaimResponse.subType
            public ElementDefinitionInfo Element_SubType;                                                                                   // MakerGen.cs:211
            // 5. ClaimResponse.use
            public ElementDefinitionInfo Element_Use;                                                                                       // MakerGen.cs:211
            // 6. ClaimResponse.patient
            public ElementDefinitionInfo Element_Patient;                                                                                   // MakerGen.cs:211
            // 7. ClaimResponse.created
            public ElementDefinitionInfo Element_Created;                                                                                   // MakerGen.cs:211
            // 8. ClaimResponse.insurer
            public ElementDefinitionInfo Element_Insurer;                                                                                   // MakerGen.cs:211
            // 9. ClaimResponse.requestor
            public ElementDefinitionInfo Element_Requestor;                                                                                 // MakerGen.cs:211
            // 10. ClaimResponse.request
            public ElementDefinitionInfo Element_Request;                                                                                   // MakerGen.cs:211
            // 11. ClaimResponse.outcome
            public ElementDefinitionInfo Element_Outcome;                                                                                   // MakerGen.cs:211
            // 12. ClaimResponse.disposition
            public ElementDefinitionInfo Element_Disposition;                                                                               // MakerGen.cs:211
            // 13. ClaimResponse.preAuthRef
            public ElementDefinitionInfo Element_PreAuthRef;                                                                                // MakerGen.cs:211
            // 14. ClaimResponse.preAuthPeriod
            public ElementDefinitionInfo Element_PreAuthPeriod;                                                                             // MakerGen.cs:211
            // 15. ClaimResponse.payeeType
            public ElementDefinitionInfo Element_PayeeType;                                                                                 // MakerGen.cs:211
            // 16. ClaimResponse.item
            public ElementDefinitionInfo Element_Item;                                                                                      // MakerGen.cs:211
            // 32. ClaimResponse.addItem
            public ElementDefinitionInfo Element_AddItem;                                                                                   // MakerGen.cs:211
            // 68. ClaimResponse.adjudication
            public ElementDefinitionInfo Element_Adjudication;                                                                              // MakerGen.cs:211
            // 69. ClaimResponse.total
            public ElementDefinitionInfo Element_Total;                                                                                     // MakerGen.cs:211
            // 72. ClaimResponse.payment
            public ElementDefinitionInfo Element_Payment;                                                                                   // MakerGen.cs:211
            // 79. ClaimResponse.fundsReserve
            public ElementDefinitionInfo Element_FundsReserve;                                                                              // MakerGen.cs:211
            // 80. ClaimResponse.formCode
            public ElementDefinitionInfo Element_FormCode;                                                                                  // MakerGen.cs:211
            // 81. ClaimResponse.form
            public ElementDefinitionInfo Element_Form;                                                                                      // MakerGen.cs:211
            // 82. ClaimResponse.processNote
            public ElementDefinitionInfo Element_ProcessNote;                                                                               // MakerGen.cs:211
            // 87. ClaimResponse.communicationRequest
            public ElementDefinitionInfo Element_CommunicationRequest;                                                                      // MakerGen.cs:211
            // 88. ClaimResponse.insurance
            public ElementDefinitionInfo Element_Insurance;                                                                                 // MakerGen.cs:211
            // 94. ClaimResponse.error
            public ElementDefinitionInfo Element_Error;                                                                                     // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
            public Resource_ClaimResponse_Elements()                                                                                        // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:226
                    // 1. ClaimResponse.identifier
                    this.Element_Identifier = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Identifier",                                                                                        // MakerGen.cs:230
                        Path= "ClaimResponse.identifier",                                                                                   // MakerGen.cs:231
                        Id = "ClaimResponse.identifier",                                                                                    // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Identifier                                                               // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            }                                                                                                               // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 2. ClaimResponse.status
                    this.Element_Status = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Status",                                                                                            // MakerGen.cs:230
                        Path= "ClaimResponse.status",                                                                                       // MakerGen.cs:231
                        Id = "ClaimResponse.status",                                                                                        // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 3. ClaimResponse.type
                    this.Element_Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Type",                                                                                              // MakerGen.cs:230
                        Path= "ClaimResponse.type",                                                                                         // MakerGen.cs:231
                        Id = "ClaimResponse.type",                                                                                          // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 4. ClaimResponse.subType
                    this.Element_SubType = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_SubType",                                                                                           // MakerGen.cs:230
                        Path= "ClaimResponse.subType",                                                                                      // MakerGen.cs:231
                        Id = "ClaimResponse.subType",                                                                                       // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 5. ClaimResponse.use
                    this.Element_Use = new ElementDefinitionInfo                                                                            // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Use",                                                                                               // MakerGen.cs:230
                        Path= "ClaimResponse.use",                                                                                          // MakerGen.cs:231
                        Id = "ClaimResponse.use",                                                                                           // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 6. ClaimResponse.patient
                    this.Element_Patient = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Patient",                                                                                           // MakerGen.cs:230
                        Path= "ClaimResponse.patient",                                                                                      // MakerGen.cs:231
                        Id = "ClaimResponse.patient",                                                                                       // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient"                                                       // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 7. ClaimResponse.created
                    this.Element_Created = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Created",                                                                                           // MakerGen.cs:230
                        Path= "ClaimResponse.created",                                                                                      // MakerGen.cs:231
                        Id = "ClaimResponse.created",                                                                                       // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 8. ClaimResponse.insurer
                    this.Element_Insurer = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Insurer",                                                                                           // MakerGen.cs:230
                        Path= "ClaimResponse.insurer",                                                                                      // MakerGen.cs:231
                        Id = "ClaimResponse.insurer",                                                                                       // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 9. ClaimResponse.requestor
                    this.Element_Requestor = new ElementDefinitionInfo                                                                      // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Requestor",                                                                                         // MakerGen.cs:230
                        Path= "ClaimResponse.requestor",                                                                                    // MakerGen.cs:231
                        Id = "ClaimResponse.requestor",                                                                                     // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 10. ClaimResponse.request
                    this.Element_Request = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Request",                                                                                           // MakerGen.cs:230
                        Path= "ClaimResponse.request",                                                                                      // MakerGen.cs:231
                        Id = "ClaimResponse.request",                                                                                       // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Claim"                                                         // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 11. ClaimResponse.outcome
                    this.Element_Outcome = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Outcome",                                                                                           // MakerGen.cs:230
                        Path= "ClaimResponse.outcome",                                                                                      // MakerGen.cs:231
                        Id = "ClaimResponse.outcome",                                                                                       // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 12. ClaimResponse.disposition
                    this.Element_Disposition = new ElementDefinitionInfo                                                                    // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Disposition",                                                                                       // MakerGen.cs:230
                        Path= "ClaimResponse.disposition",                                                                                  // MakerGen.cs:231
                        Id = "ClaimResponse.disposition",                                                                                   // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 13. ClaimResponse.preAuthRef
                    this.Element_PreAuthRef = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_PreAuthRef",                                                                                        // MakerGen.cs:230
                        Path= "ClaimResponse.preAuthRef",                                                                                   // MakerGen.cs:231
                        Id = "ClaimResponse.preAuthRef",                                                                                    // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 14. ClaimResponse.preAuthPeriod
                    this.Element_PreAuthPeriod = new ElementDefinitionInfo                                                                  // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_PreAuthPeriod",                                                                                     // MakerGen.cs:230
                        Path= "ClaimResponse.preAuthPeriod",                                                                                // MakerGen.cs:231
                        Id = "ClaimResponse.preAuthPeriod",                                                                                 // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Period                                                                   // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            }                                                                                                               // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 15. ClaimResponse.payeeType
                    this.Element_PayeeType = new ElementDefinitionInfo                                                                      // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_PayeeType",                                                                                         // MakerGen.cs:230
                        Path= "ClaimResponse.payeeType",                                                                                    // MakerGen.cs:231
                        Id = "ClaimResponse.payeeType",                                                                                     // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 16. ClaimResponse.item
                    this.Element_Item = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Item",                                                                                              // MakerGen.cs:230
                        Path= "ClaimResponse.item",                                                                                         // MakerGen.cs:231
                        Id = "ClaimResponse.item",                                                                                          // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Item                                                                                                   // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 32. ClaimResponse.addItem
                    this.Element_AddItem = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_AddItem",                                                                                           // MakerGen.cs:230
                        Path= "ClaimResponse.addItem",                                                                                      // MakerGen.cs:231
                        Id = "ClaimResponse.addItem",                                                                                       // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_AddItem                                                                                                // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 68. ClaimResponse.adjudication
                    this.Element_Adjudication = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Adjudication",                                                                                      // MakerGen.cs:230
                        Path= "ClaimResponse.adjudication",                                                                                 // MakerGen.cs:231
                        Id = "ClaimResponse.adjudication",                                                                                  // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 69. ClaimResponse.total
                    this.Element_Total = new ElementDefinitionInfo                                                                          // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Total",                                                                                             // MakerGen.cs:230
                        Path= "ClaimResponse.total",                                                                                        // MakerGen.cs:231
                        Id = "ClaimResponse.total",                                                                                         // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Total                                                                                                  // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 72. ClaimResponse.payment
                    this.Element_Payment = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Payment",                                                                                           // MakerGen.cs:230
                        Path= "ClaimResponse.payment",                                                                                      // MakerGen.cs:231
                        Id = "ClaimResponse.payment",                                                                                       // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Payment                                                                                                // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 79. ClaimResponse.fundsReserve
                    this.Element_FundsReserve = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_FundsReserve",                                                                                      // MakerGen.cs:230
                        Path= "ClaimResponse.fundsReserve",                                                                                 // MakerGen.cs:231
                        Id = "ClaimResponse.fundsReserve",                                                                                  // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 80. ClaimResponse.formCode
                    this.Element_FormCode = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_FormCode",                                                                                          // MakerGen.cs:230
                        Path= "ClaimResponse.formCode",                                                                                     // MakerGen.cs:231
                        Id = "ClaimResponse.formCode",                                                                                      // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 81. ClaimResponse.form
                    this.Element_Form = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Form",                                                                                              // MakerGen.cs:230
                        Path= "ClaimResponse.form",                                                                                         // MakerGen.cs:231
                        Id = "ClaimResponse.form",                                                                                          // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Attachment                                                               // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            }                                                                                                               // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 82. ClaimResponse.processNote
                    this.Element_ProcessNote = new ElementDefinitionInfo                                                                    // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_ProcessNote",                                                                                       // MakerGen.cs:230
                        Path= "ClaimResponse.processNote",                                                                                  // MakerGen.cs:231
                        Id = "ClaimResponse.processNote",                                                                                   // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_ProcessNote                                                                                            // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 87. ClaimResponse.communicationRequest
                    this.Element_CommunicationRequest = new ElementDefinitionInfo                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_CommunicationRequest",                                                                              // MakerGen.cs:230
                        Path= "ClaimResponse.communicationRequest",                                                                         // MakerGen.cs:231
                        Id = "ClaimResponse.communicationRequest",                                                                          // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/CommunicationRequest"                                          // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 88. ClaimResponse.insurance
                    this.Element_Insurance = new ElementDefinitionInfo                                                                      // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Insurance",                                                                                         // MakerGen.cs:230
                        Path= "ClaimResponse.insurance",                                                                                    // MakerGen.cs:231
                        Id = "ClaimResponse.insurance",                                                                                     // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Insurance                                                                                              // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 94. ClaimResponse.error
                    this.Element_Error = new ElementDefinitionInfo                                                                          // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Error",                                                                                             // MakerGen.cs:230
                        Path= "ClaimResponse.error",                                                                                        // MakerGen.cs:231
                        Id = "ClaimResponse.error",                                                                                         // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Error                                                                                                  // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                Element_Identifier.Write(sDef);                                                                                             // MakerGen.cs:215
                Element_Status.Write(sDef);                                                                                                 // MakerGen.cs:215
                Element_Type.Write(sDef);                                                                                                   // MakerGen.cs:215
                Element_SubType.Write(sDef);                                                                                                // MakerGen.cs:215
                Element_Use.Write(sDef);                                                                                                    // MakerGen.cs:215
                Element_Patient.Write(sDef);                                                                                                // MakerGen.cs:215
                Element_Created.Write(sDef);                                                                                                // MakerGen.cs:215
                Element_Insurer.Write(sDef);                                                                                                // MakerGen.cs:215
                Element_Requestor.Write(sDef);                                                                                              // MakerGen.cs:215
                Element_Request.Write(sDef);                                                                                                // MakerGen.cs:215
                Element_Outcome.Write(sDef);                                                                                                // MakerGen.cs:215
                Element_Disposition.Write(sDef);                                                                                            // MakerGen.cs:215
                Element_PreAuthRef.Write(sDef);                                                                                             // MakerGen.cs:215
                Element_PreAuthPeriod.Write(sDef);                                                                                          // MakerGen.cs:215
                Element_PayeeType.Write(sDef);                                                                                              // MakerGen.cs:215
                Element_Item.Write(sDef);                                                                                                   // MakerGen.cs:215
                Element_AddItem.Write(sDef);                                                                                                // MakerGen.cs:215
                Element_Adjudication.Write(sDef);                                                                                           // MakerGen.cs:215
                Element_Total.Write(sDef);                                                                                                  // MakerGen.cs:215
                Element_Payment.Write(sDef);                                                                                                // MakerGen.cs:215
                Element_FundsReserve.Write(sDef);                                                                                           // MakerGen.cs:215
                Element_FormCode.Write(sDef);                                                                                               // MakerGen.cs:215
                Element_Form.Write(sDef);                                                                                                   // MakerGen.cs:215
                Element_ProcessNote.Write(sDef);                                                                                            // MakerGen.cs:215
                Element_CommunicationRequest.Write(sDef);                                                                                   // MakerGen.cs:215
                Element_Insurance.Write(sDef);                                                                                              // MakerGen.cs:215
                Element_Error.Write(sDef);                                                                                                  // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:394
        }                                                                                                                                   // MakerGen.cs:396
        public Resource_ClaimResponse_Elements Elements                                                                                     // MakerGen.cs:398
        {                                                                                                                                   // MakerGen.cs:399
            get                                                                                                                             // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                if (this.elements == null)                                                                                                  // MakerGen.cs:402
                    this.elements = new Resource_ClaimResponse_Elements();                                                                  // MakerGen.cs:403
                return this.elements;                                                                                                       // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:406
        Resource_ClaimResponse_Elements elements;                                                                                           // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
        public Resource_ClaimResponse()                                                                                                     // MakerGen.cs:410
        {                                                                                                                                   // MakerGen.cs:411
            this.Name = "ClaimResponse";                                                                                                    // MakerGen.cs:484
            this.Uri = "http://hl7.org/fhir/StructureDefinition/ClaimResponse";                                                             // MakerGen.cs:485
        }                                                                                                                                   // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:416
        {                                                                                                                                   // MakerGen.cs:417
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:418
            {                                                                                                                               // MakerGen.cs:419
                Path = "ClaimResponse",                                                                                                     // MakerGen.cs:420
                ElementId = "ClaimResponse"                                                                                                 // MakerGen.cs:421
            });                                                                                                                             // MakerGen.cs:422
            if (this.elements != null)                                                                                                      // MakerGen.cs:423
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:424
        }                                                                                                                                   // MakerGen.cs:425
    }                                                                                                                                       // MakerGen.cs:426
}                                                                                                                                           // MakerGen.cs:471
