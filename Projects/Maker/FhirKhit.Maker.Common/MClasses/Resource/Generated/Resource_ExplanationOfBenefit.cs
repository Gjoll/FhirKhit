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
      "id": "ExplanationOfBenefit",
      "url": "http://hl7.org/fhir/StructureDefinition/ExplanationOfBenefit",
      "version": "4.0.0",
      "name": "ExplanationOfBenefit",
      "status": "draft",
      "publisher": "Health Level Seven International (Financial Management)",
      "description": "This resource provides: the claim details; adjudication details from the processing of a Claim; and optionally account balance information, for informing the subscriber of the benefits provided.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "ExplanationOfBenefit",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "ExplanationOfBenefit",
            "path": "ExplanationOfBenefit",
            "short": "Explanation of Benefit resource",
            "definition": "This resource provides: the claim details; adjudication details from the processing of a Claim; and optionally account balance information, for informing the subscriber of the benefits provided.",
            "alias": [
              "EOB"
            ],
            "min": 0,
            "max": "*"
          },
          {
            "id": "ExplanationOfBenefit.identifier",
            "path": "ExplanationOfBenefit.identifier",
            "short": "Business Identifier for the resource",
            "definition": "A unique identifier assigned to this explanation of benefit.",
            "requirements": "Allows EOBs to be distinguished and referenced.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Identifier"
              }
            ]
          },
          {
            "id": "ExplanationOfBenefit.status",
            "path": "ExplanationOfBenefit.status",
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
                  "valueString": "ExplanationOfBenefitStatus"
                }
              ],
              "strength": "required",
              "description": "A code specifying the state of the resource instance.",
              "valueSet": "http://hl7.org/fhir/ValueSet/explanationofbenefit-status|4.0.0"
            }
          },
          {
            "id": "ExplanationOfBenefit.type",
            "path": "ExplanationOfBenefit.type",
            "short": "Category or discipline",
            "definition": "The category of claim, e.g. oral, pharmacy, vision, institutional, professional.",
            "comment": "The majority of jurisdictions use: oral, pharmacy, vision, professional and institutional, or variants on those terms, as the general styles of claims. The valueset is extensible to accommodate other jurisdictional requirements.",
            "requirements": "Claim type determine the general sets of business rules applied for information requirements and adjudication.",
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
            "id": "ExplanationOfBenefit.subType",
            "path": "ExplanationOfBenefit.subType",
            "short": "More granular claim type",
            "definition": "A finer grained suite of claim type codes which may convey additional information such as Inpatient vs Outpatient and/or a specialty service.",
            "comment": "This may contain the local bill type codes such as the US UB-04 bill type code.",
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
            "id": "ExplanationOfBenefit.use",
            "path": "ExplanationOfBenefit.use",
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
              "description": "Complete, proposed, exploratory, other.",
              "valueSet": "http://hl7.org/fhir/ValueSet/claim-use|4.0.0"
            }
          },
          {
            "id": "ExplanationOfBenefit.patient",
            "path": "ExplanationOfBenefit.patient",
            "short": "The recipient of the products and services",
            "definition": "The party to whom the professional services and/or products have been supplied or are being considered and for whom actual for forecast reimbursement is sought.",
            "requirements": "The patient must be supplied to the insurer so that confirmation of coverage and service history may be considered as part of the authorization and/or adjudiction.",
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
            "id": "ExplanationOfBenefit.billablePeriod",
            "path": "ExplanationOfBenefit.billablePeriod",
            "short": "Relevant time frame for the claim",
            "definition": "The period for which charges are being submitted.",
            "comment": "Typically this would be today or in the past for a claim, and today or in the future for preauthorizations and prodeterminations. Typically line item dates of service should fall within the billing period if one is specified.",
            "requirements": "A number jurisdictions required the submission of the billing period when submitting claims for example for hospital stays or long-term care.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Period"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ExplanationOfBenefit.created",
            "path": "ExplanationOfBenefit.created",
            "short": "Response creation date",
            "definition": "The date this resource was created.",
            "comment": "This field is independent of the date of creation of the resource as it may reflect the creation date of a source document prior to digitization. Typically for claims all services must be completed as of this date.",
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
            "id": "ExplanationOfBenefit.enterer",
            "path": "ExplanationOfBenefit.enterer",
            "short": "Author of the claim",
            "definition": "Individual who created the claim, predetermination or preauthorization.",
            "requirements": "Some jurisdictions require the contact information for personnel completing claims.",
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
            "id": "ExplanationOfBenefit.insurer",
            "path": "ExplanationOfBenefit.insurer",
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
            "id": "ExplanationOfBenefit.provider",
            "path": "ExplanationOfBenefit.provider",
            "short": "Party responsible for the claim",
            "definition": "The provider which is responsible for the claim, predetermination or preauthorization.",
            "comment": "Typically this field would be 1..1 where this party is responsible for the claim but not necessarily professionally responsible for the provision of the individual products and services listed below.",
            "min": 1,
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
            ],
            "isSummary": true
          },
          {
            "id": "ExplanationOfBenefit.priority",
            "path": "ExplanationOfBenefit.priority",
            "short": "Desired processing urgency",
            "definition": "The provider-required urgency of processing the request. Typical values include: stat, routine deferred.",
            "comment": "If a claim processor is unable to complete the processing as per the priority then they should generate and error and not process the request.",
            "requirements": "The provider may need to indicate their processing requirements so that the processor can indicate if they are unable to comply.",
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
              "description": "The timeliness with which processing is required: stat, normal, deferred.",
              "valueSet": "http://terminology.hl7.org/CodeSystem/processpriority"
            }
          },
          {
            "id": "ExplanationOfBenefit.fundsReserveRequested",
            "path": "ExplanationOfBenefit.fundsReserveRequested",
            "short": "For whom to reserve funds",
            "definition": "A code to indicate whether and for whom funds are to be reserved for future claims.",
            "comment": "This field is only used for preauthorizations.",
            "requirements": "In the case of a Pre-Determination/Pre-Authorization the provider may request that funds in the amount of the expected Benefit be reserved ('Patient' or 'Provider') to pay for the Benefits determined on the subsequent claim(s). 'None' explicitly indicates no funds reserving is requested.",
            "alias": [
              "Fund pre-allocation"
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
            "id": "ExplanationOfBenefit.fundsReserve",
            "path": "ExplanationOfBenefit.fundsReserve",
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
            "id": "ExplanationOfBenefit.related",
            "path": "ExplanationOfBenefit.related",
            "short": "Prior or corollary claims",
            "definition": "Other claims which are related to this claim such as prior submissions or claims for related services or for the same event.",
            "comment": "For example,  for the original treatment and follow-up exams.",
            "requirements": "For workplace or other accidents it is common to relate separate claims arising from the same event.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ExplanationOfBenefit.related.claim",
            "path": "ExplanationOfBenefit.related.claim",
            "short": "Reference to the related claim",
            "definition": "Reference to a related claim.",
            "requirements": "For workplace or other accidents it is common to relate separate claims arising from the same event.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Claim"
                ]
              }
            ]
          },
          {
            "id": "ExplanationOfBenefit.related.relationship",
            "path": "ExplanationOfBenefit.related.relationship",
            "short": "How the reference claim is related",
            "definition": "A code to convey how the claims are related.",
            "comment": "For example, prior claim or umbrella.",
            "requirements": "Some insurers need a declaration of the type of relationship.",
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
                  "valueString": "RelatedClaimRelationship"
                }
              ],
              "strength": "example",
              "description": "Relationship of this claim to a related Claim.",
              "valueSet": "http://hl7.org/fhir/ValueSet/related-claim-relationship"
            }
          },
          {
            "id": "ExplanationOfBenefit.related.reference",
            "path": "ExplanationOfBenefit.related.reference",
            "short": "File or case reference",
            "definition": "An alternate organizational reference to the case or file to which this particular claim pertains.",
            "comment": "For example, Property/Casualty insurer claim number or Workers Compensation case number.",
            "requirements": "In cases where an event-triggered claim is being submitted to an insurer which requires a reference number to be specified on all exchanges.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Identifier"
              }
            ]
          },
          {
            "id": "ExplanationOfBenefit.prescription",
            "path": "ExplanationOfBenefit.prescription",
            "short": "Prescription authorizing services or products",
            "definition": "Prescription to support the dispensing of pharmacy, device or vision products.",
            "requirements": "Required to authorize the dispensing of controlled substances and devices.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/MedicationRequest",
                  "http://hl7.org/fhir/StructureDefinition/VisionPrescription"
                ]
              }
            ]
          },
          {
            "id": "ExplanationOfBenefit.originalPrescription",
            "path": "ExplanationOfBenefit.originalPrescription",
            "short": "Original prescription if superceded by fulfiller",
            "definition": "Original prescription which has been superseded by this prescription to support the dispensing of pharmacy services, medications or products.",
            "comment": "For example, a physician may prescribe a medication which the pharmacy determines is contraindicated, or for which the patient has an intolerance, and therefor issues a new prescription for an alternate medication which has the same therapeutic intent. The prescription from the pharmacy becomes the 'prescription' and that from the physician becomes the 'original prescription'.",
            "requirements": "Often required when a fulfiller varies what is fulfilled from that authorized on the original prescription.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/MedicationRequest"
                ]
              }
            ]
          },
          {
            "id": "ExplanationOfBenefit.payee",
            "path": "ExplanationOfBenefit.payee",
            "short": "Recipient of benefits payable",
            "definition": "The party to be reimbursed for cost of the products and services according to the terms of the policy.",
            "comment": "Often providers agree to receive the benefits payable to reduce the near-term costs to the patient. The insurer may decline to pay the provider and may choose to pay the subscriber instead.",
            "requirements": "The provider needs to specify who they wish to be reimbursed and the claims processor needs express who they will reimburse.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ExplanationOfBenefit.payee.type",
            "path": "ExplanationOfBenefit.payee.type",
            "short": "Category of recipient",
            "definition": "Type of Party to be reimbursed: Subscriber, provider, other.",
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
            "id": "ExplanationOfBenefit.payee.party",
            "path": "ExplanationOfBenefit.payee.party",
            "short": "Recipient reference",
            "definition": "Reference to the individual or organization to whom any payment will be made.",
            "comment": "Not required if the payee is 'subscriber' or 'provider'.",
            "requirements": "Need to provide demographics if the payee is not 'subscriber' nor 'provider'.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/Organization",
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson"
                ]
              }
            ]
          },
          {
            "id": "ExplanationOfBenefit.referral",
            "path": "ExplanationOfBenefit.referral",
            "short": "Treatment Referral",
            "definition": "A reference to a referral resource.",
            "comment": "The referral resource which lists the date, practitioner, reason and other supporting information.",
            "requirements": "Some insurers require proof of referral to pay for services or to pay specialist rates for services.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/ServiceRequest"
                ]
              }
            ]
          },
          {
            "id": "ExplanationOfBenefit.facility",
            "path": "ExplanationOfBenefit.facility",
            "short": "Servicing Facility",
            "definition": "Facility where the services were provided.",
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
            "id": "ExplanationOfBenefit.claim",
            "path": "ExplanationOfBenefit.claim",
            "short": "Claim reference",
            "definition": "The business identifier for the instance of the adjudication request: claim predetermination or preauthorization.",
            "requirements": "To provide a link to the original adjudication request.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Claim"
                ]
              }
            ]
          },
          {
            "id": "ExplanationOfBenefit.claimResponse",
            "path": "ExplanationOfBenefit.claimResponse",
            "short": "Claim response reference",
            "definition": "The business identifier for the instance of the adjudication response: claim, predetermination or preauthorization response.",
            "requirements": "To provide a link to the original adjudication response.",
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
            "id": "ExplanationOfBenefit.outcome",
            "path": "ExplanationOfBenefit.outcome",
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
            "id": "ExplanationOfBenefit.disposition",
            "path": "ExplanationOfBenefit.disposition",
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
            "id": "ExplanationOfBenefit.preAuthRef",
            "path": "ExplanationOfBenefit.preAuthRef",
            "short": "Preauthorization reference",
            "definition": "Reference from the Insurer which is used in later communications which refers to this adjudication.",
            "comment": "This value is only present on preauthorization adjudications.",
            "requirements": "On subsequent claims, the insurer may require the provider to quote this value.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ExplanationOfBenefit.preAuthRefPeriod",
            "path": "ExplanationOfBenefit.preAuthRefPeriod",
            "short": "Preauthorization in-effect period",
            "definition": "The timeframe during which the supplied preauthorization reference may be quoted on claims to obtain the adjudication as provided.",
            "comment": "This value is only present on preauthorization adjudications.",
            "requirements": "On subsequent claims, the insurer may require the provider to quote this value.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Period"
              }
            ]
          },
          {
            "id": "ExplanationOfBenefit.careTeam",
            "path": "ExplanationOfBenefit.careTeam",
            "short": "Care Team members",
            "definition": "The members of the team who provided the products and services.",
            "requirements": "Common to identify the responsible and supporting practitioners.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ExplanationOfBenefit.careTeam.sequence",
            "path": "ExplanationOfBenefit.careTeam.sequence",
            "short": "Order of care team",
            "definition": "A number to uniquely identify care team entries.",
            "requirements": "Necessary to maintain the order of the care team and provide a mechanism to link individuals to claim details.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "positiveInt"
              }
            ]
          },
          {
            "id": "ExplanationOfBenefit.careTeam.provider",
            "path": "ExplanationOfBenefit.careTeam.provider",
            "short": "Practitioner or organization",
            "definition": "Member of the team who provided the product or service.",
            "requirements": "Often a regulatory requirement to specify the responsible provider.",
            "min": 1,
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
            "id": "ExplanationOfBenefit.careTeam.responsible",
            "path": "ExplanationOfBenefit.careTeam.responsible",
            "short": "Indicator of the lead practitioner",
            "definition": "The party who is billing and/or responsible for the claimed products or services.",
            "comment": "Responsible might not be required when there is only a single provider listed.",
            "requirements": "When multiple parties are present it is required to distinguish the lead or responsible individual.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ]
          },
          {
            "id": "ExplanationOfBenefit.careTeam.role",
            "path": "ExplanationOfBenefit.careTeam.role",
            "short": "Function within the team",
            "definition": "The lead, assisting or supervising practitioner and their discipline if a multidisciplinary team.",
            "comment": "Role might not be required when there is only a single provider listed.",
            "requirements": "When multiple parties are present it is required to distinguish the roles performed by each member.",
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
                  "valueString": "CareTeamRole"
                }
              ],
              "strength": "example",
              "description": "The role codes for the care team members.",
              "valueSet": "http://hl7.org/fhir/ValueSet/claim-careteamrole"
            }
          },
          {
            "id": "ExplanationOfBenefit.careTeam.qualification",
            "path": "ExplanationOfBenefit.careTeam.qualification",
            "short": "Practitioner credential or specialization",
            "definition": "The qualification of the practitioner which is applicable for this service.",
            "requirements": "Need to specify which qualification a provider is delivering the product or service under.",
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
                  "valueString": "ProviderQualification"
                }
              ],
              "strength": "example",
              "description": "Provider professional qualifications.",
              "valueSet": "http://hl7.org/fhir/ValueSet/provider-qualification"
            }
          },
          {
            "id": "ExplanationOfBenefit.supportingInfo",
            "path": "ExplanationOfBenefit.supportingInfo",
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
            "id": "ExplanationOfBenefit.supportingInfo.sequence",
            "path": "ExplanationOfBenefit.supportingInfo.sequence",
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
            "id": "ExplanationOfBenefit.supportingInfo.category",
            "path": "ExplanationOfBenefit.supportingInfo.category",
            "short": "Classification of the supplied information",
            "definition": "The general class of the information supplied: information; exception; accident, employment; onset, etc.",
            "comment": "This may contain a category for the local bill type codes.",
            "requirements": "Required to group or associate information items with common characteristics. For example: admission information or prior treatments.",
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
                  "valueString": "InformationCategory"
                }
              ],
              "strength": "example",
              "description": "The valuset used for additional information category codes.",
              "valueSet": "http://hl7.org/fhir/ValueSet/claim-informationcategory"
            }
          },
          {
            "id": "ExplanationOfBenefit.supportingInfo.code",
            "path": "ExplanationOfBenefit.supportingInfo.code",
            "short": "Type of information",
            "definition": "System and code pertaining to the specific information regarding special conditions relating to the setting, treatment or patient  for which care is sought.",
            "comment": "This may contain the local bill type codes such as the US UB-04 bill type code.",
            "requirements": "Required to identify the kind of additional information.",
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
                  "valueString": "InformationCode"
                }
              ],
              "strength": "example",
              "description": "The valuset used for additional information codes.",
              "valueSet": "http://hl7.org/fhir/ValueSet/claim-exception"
            }
          },
          {
            "id": "ExplanationOfBenefit.supportingInfo.timing[x]",
            "path": "ExplanationOfBenefit.supportingInfo.timing[x]",
            "short": "When it occurred",
            "definition": "The date when or period to which this information refers.",
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
            "id": "ExplanationOfBenefit.supportingInfo.value[x]",
            "path": "ExplanationOfBenefit.supportingInfo.value[x]",
            "short": "Data to be provided",
            "definition": "Additional data or information such as resources, documents, images etc. including references to the data or the actual inclusion of the data.",
            "comment": "Could be used to provide references to other resources, document. For example, could contain a PDF in an Attachment of the Police Report for an Accident.",
            "requirements": "To convey the data content to be provided when the information is more than a simple code or period.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              },
              {
                "code": "string"
              },
              {
                "code": "Quantity"
              },
              {
                "code": "Attachment"
              },
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Resource"
                ]
              }
            ]
          },
          {
            "id": "ExplanationOfBenefit.supportingInfo.reason",
            "path": "ExplanationOfBenefit.supportingInfo.reason",
            "short": "Explanation for the information",
            "definition": "Provides the reason in the situation where a reason code is required in addition to the content.",
            "comment": "For example: the reason for the additional stay, or why a tooth is  missing.",
            "requirements": "Needed when the supporting information has both a date and amount/value and requires explanation.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Coding"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "MissingReason"
                }
              ],
              "strength": "example",
              "description": "Reason codes for the missing teeth.",
              "valueSet": "http://hl7.org/fhir/ValueSet/missing-tooth-reason"
            }
          },
          {
            "id": "ExplanationOfBenefit.diagnosis",
            "path": "ExplanationOfBenefit.diagnosis",
            "short": "Pertinent diagnosis information",
            "definition": "Information about diagnoses relevant to the claim items.",
            "requirements": "Required for the adjudication by provided context for the services and product listed.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ExplanationOfBenefit.diagnosis.sequence",
            "path": "ExplanationOfBenefit.diagnosis.sequence",
            "short": "Diagnosis instance identifier",
            "definition": "A number to uniquely identify diagnosis entries.",
            "comment": "Diagnosis are presented in list order to their expected importance: primary, secondary, etc.",
            "requirements": "Necessary to maintain the order of the diagnosis items and provide a mechanism to link to claim details.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "positiveInt"
              }
            ]
          },
          {
            "id": "ExplanationOfBenefit.diagnosis.diagnosis[x]",
            "path": "ExplanationOfBenefit.diagnosis.diagnosis[x]",
            "short": "Nature of illness or problem",
            "definition": "The nature of illness or problem in a coded form or as a reference to an external defined Condition.",
            "requirements": "Provides health context for the evaluation of the products and/or services.",
            "min": 1,
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
            "id": "ExplanationOfBenefit.diagnosis.type",
            "path": "ExplanationOfBenefit.diagnosis.type",
            "short": "Timing or nature of the diagnosis",
            "definition": "When the condition was observed or the relative ranking.",
            "comment": "For example: admitting, primary, secondary, discharge.",
            "requirements": "Often required to capture a particular diagnosis, for example: primary or discharge.",
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
                  "valueString": "DiagnosisType"
                }
              ],
              "strength": "example",
              "description": "The type of the diagnosis: admitting, principal, discharge.",
              "valueSet": "http://hl7.org/fhir/ValueSet/ex-diagnosistype"
            }
          },
          {
            "id": "ExplanationOfBenefit.diagnosis.onAdmission",
            "path": "ExplanationOfBenefit.diagnosis.onAdmission",
            "short": "Present on admission",
            "definition": "Indication of whether the diagnosis was present on admission to a facility.",
            "requirements": "Many systems need to understand for adjudication if the diagnosis was present a time of admission.",
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
                  "valueString": "DiagnosisOnAdmission"
                }
              ],
              "strength": "example",
              "description": "Present on admission.",
              "valueSet": "http://hl7.org/fhir/ValueSet/ex-diagnosis-on-admission"
            }
          },
          {
            "id": "ExplanationOfBenefit.diagnosis.packageCode",
            "path": "ExplanationOfBenefit.diagnosis.packageCode",
            "short": "Package billing code",
            "definition": "A package billing code or bundle code used to group products and services to a particular health condition (such as heart attack) which is based on a predetermined grouping code system.",
            "comment": "For example, DRG (Diagnosis Related Group) or a bundled billing code. A patient may have a diagnosis of a Myocardio-infarction and a DRG for HeartAttack would assigned. The Claim item (and possible subsequent claims) would refer to the DRG for those line items that were for services related to the heart attack event.",
            "requirements": "Required to relate the current  diagnosis to a package billing code that is then referenced on the individual claim items which are specific to the health condition covered by the package code.",
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
                  "valueString": "DiagnosisRelatedGroup"
                }
              ],
              "strength": "example",
              "description": "The DRG codes associated with the diagnosis.",
              "valueSet": "http://hl7.org/fhir/ValueSet/ex-diagnosisrelatedgroup"
            }
          },
          {
            "id": "ExplanationOfBenefit.procedure",
            "path": "ExplanationOfBenefit.procedure",
            "short": "Clinical procedures performed",
            "definition": "Procedures performed on the patient relevant to the billing items with the claim.",
            "requirements": "The specific clinical invention are sometimes required to be provided to justify billing a greater than customary amount for a service.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ExplanationOfBenefit.procedure.sequence",
            "path": "ExplanationOfBenefit.procedure.sequence",
            "short": "Procedure instance identifier",
            "definition": "A number to uniquely identify procedure entries.",
            "requirements": "Necessary to provide a mechanism to link to claim details.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "positiveInt"
              }
            ]
          },
          {
            "id": "ExplanationOfBenefit.procedure.type",
            "path": "ExplanationOfBenefit.procedure.type",
            "short": "Category of Procedure",
            "definition": "When the condition was observed or the relative ranking.",
            "requirements": "Often required to capture a particular diagnosis, for example: primary or discharge.",
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
                  "valueString": "ProcedureType"
                }
              ],
              "strength": "example",
              "description": "Example procedure type codes.",
              "valueSet": "http://hl7.org/fhir/ValueSet/ex-procedure-type"
            }
          },
          {
            "id": "ExplanationOfBenefit.procedure.date",
            "path": "ExplanationOfBenefit.procedure.date",
            "short": "When the procedure was performed",
            "definition": "Date and optionally time the procedure was performed.",
            "requirements": "Required for auditing purposes.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ]
          },
          {
            "id": "ExplanationOfBenefit.procedure.procedure[x]",
            "path": "ExplanationOfBenefit.procedure.procedure[x]",
            "short": "Specific clinical procedure",
            "definition": "The code or reference to a Procedure resource which identifies the clinical intervention performed.",
            "requirements": "This identifies the actual clinical procedure.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              },
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Procedure"
                ]
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ICD10_Procedures"
                }
              ],
              "strength": "example",
              "description": "ICD10 Procedure codes.",
              "valueSet": "http://hl7.org/fhir/ValueSet/icd-10-procedures"
            }
          },
          {
            "id": "ExplanationOfBenefit.procedure.udi",
            "path": "ExplanationOfBenefit.procedure.udi",
            "short": "Unique device identifier",
            "definition": "Unique Device Identifiers associated with this line item.",
            "requirements": "The UDI code allows the insurer to obtain device level information on the product supplied.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Device"
                ]
              }
            ]
          },
          {
            "id": "ExplanationOfBenefit.precedence",
            "path": "ExplanationOfBenefit.precedence",
            "short": "Precedence (primary, secondary, etc.)",
            "definition": "This indicates the relative order of a series of EOBs related to different coverages for the same suite of services.",
            "requirements": "Needed to coordinate between multiple EOBs for the same suite of services.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "positiveInt"
              }
            ]
          },
          {
            "id": "ExplanationOfBenefit.insurance",
            "path": "ExplanationOfBenefit.insurance",
            "short": "Patient insurance information",
            "definition": "Financial instruments for reimbursement for the health care products and services specified on the claim.",
            "comment": "All insurance coverages for the patient which may be applicable for reimbursement, of the products and services listed in the claim, are typically provided in the claim to allow insurers to confirm the ordering of the insurance coverages relative to local 'coordination of benefit' rules. One coverage (and only one) with 'focal=true' is to be used in the adjudication of this claim. Coverages appearing before the focal Coverage in the list, and where 'Coverage.subrogation=false', should provide a reference to the ClaimResponse containing the adjudication results of the prior claim.",
            "requirements": "At least one insurer is required for a claim to be a claim.",
            "min": 1,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ExplanationOfBenefit.insurance.focal",
            "path": "ExplanationOfBenefit.insurance.focal",
            "short": "Coverage to be used for adjudication",
            "definition": "A flag to indicate that this Coverage is to be used for adjudication of this claim when set to true.",
            "comment": "A patient may (will) have multiple insurance policies which provide reimbursement for healthcare services and products. For example, a person may also be covered by their spouse's policy and both appear in the list (and may be from the same insurer). This flag will be set to true for only one of the listed policies and that policy will be used for adjudicating this claim. Other claims would be created to request adjudication against the other listed policies.",
            "requirements": "To identify which coverage in the list is being used to adjudicate this claim.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ExplanationOfBenefit.insurance.coverage",
            "path": "ExplanationOfBenefit.insurance.coverage",
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
            "id": "ExplanationOfBenefit.insurance.preAuthRef",
            "path": "ExplanationOfBenefit.insurance.preAuthRef",
            "short": "Prior authorization reference number",
            "definition": "Reference numbers previously provided by the insurer to the provider to be quoted on subsequent claims containing services or products related to the prior authorization.",
            "comment": "This value is an alphanumeric string that may be provided over the phone, via text, via paper, or within a ClaimResponse resource and is not a FHIR Identifier.",
            "requirements": "Providers must quote previously issued authorization reference numbers in order to obtain adjudication as previously advised on the Preauthorization.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ExplanationOfBenefit.accident",
            "path": "ExplanationOfBenefit.accident",
            "short": "Details of the event",
            "definition": "Details of a accident which resulted in injuries which required the products and services listed in the claim.",
            "requirements": "When healthcare products and services are accident related, benefits may be payable under accident provisions of policies, such as automotive, etc before they are payable under normal health insurance.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ExplanationOfBenefit.accident.date",
            "path": "ExplanationOfBenefit.accident.date",
            "short": "When the incident occurred",
            "definition": "Date of an accident event  related to the products and services contained in the claim.",
            "comment": "The date of the accident has to precede the dates of the products and services but within a reasonable timeframe.",
            "requirements": "Required for audit purposes and adjudication.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "date"
              }
            ]
          },
          {
            "id": "ExplanationOfBenefit.accident.type",
            "path": "ExplanationOfBenefit.accident.type",
            "short": "The nature of the accident",
            "definition": "The type or context of the accident event for the purposes of selection of potential insurance coverages and determination of coordination between insurers.",
            "requirements": "Coverage may be dependant on the type of accident.",
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
                  "valueString": "AccidentType"
                }
              ],
              "strength": "extensible",
              "description": "Type of accident: work place, auto, etc.",
              "valueSet": "http://terminology.hl7.org/ValueSet/v3-ActIncidentCode"
            }
          },
          {
            "id": "ExplanationOfBenefit.accident.location[x]",
            "path": "ExplanationOfBenefit.accident.location[x]",
            "short": "Where the event occurred",
            "definition": "The physical location of the accident event.",
            "requirements": "Required for audit purposes and determination of applicable insurance liability.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Address"
              },
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Location"
                ]
              }
            ]
          },
          {
            "id": "ExplanationOfBenefit.item",
            "path": "ExplanationOfBenefit.item",
            "short": "Product or service provided",
            "definition": "A claim line. Either a simple (a product or service) or a 'group' of details which can also be a simple items or groups of sub-details.",
            "requirements": "The items to be processed for adjudication.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ExplanationOfBenefit.item.sequence",
            "path": "ExplanationOfBenefit.item.sequence",
            "short": "Item instance identifier",
            "definition": "A number to uniquely identify item entries.",
            "requirements": "Necessary to provide a mechanism to link to items from within the claim and within the adjudication details of the ClaimResponse.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "positiveInt"
              }
            ]
          },
          {
            "id": "ExplanationOfBenefit.item.careTeamSequence",
            "path": "ExplanationOfBenefit.item.careTeamSequence",
            "short": "Applicable care team members",
            "definition": "Care team members related to this service or product.",
            "requirements": "Need to identify the individuals and their roles in the provision of the product or service.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "positiveInt"
              }
            ]
          },
          {
            "id": "ExplanationOfBenefit.item.diagnosisSequence",
            "path": "ExplanationOfBenefit.item.diagnosisSequence",
            "short": "Applicable diagnoses",
            "definition": "Diagnoses applicable for this service or product.",
            "requirements": "Need to related the product or service to the associated diagnoses.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "positiveInt"
              }
            ]
          },
          {
            "id": "ExplanationOfBenefit.item.procedureSequence",
            "path": "ExplanationOfBenefit.item.procedureSequence",
            "short": "Applicable procedures",
            "definition": "Procedures applicable for this service or product.",
            "requirements": "Need to provide any listed specific procedures to support the product or service being claimed.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "positiveInt"
              }
            ]
          },
          {
            "id": "ExplanationOfBenefit.item.informationSequence",
            "path": "ExplanationOfBenefit.item.informationSequence",
            "short": "Applicable exception and supporting information",
            "definition": "Exceptions, special conditions and supporting information applicable for this service or product.",
            "requirements": "Need to reference the supporting information items that relate directly to this product or service.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "positiveInt"
              }
            ]
          },
          {
            "id": "ExplanationOfBenefit.item.revenue",
            "path": "ExplanationOfBenefit.item.revenue",
            "short": "Revenue or cost center code",
            "definition": "The type of revenue or cost center providing the product and/or service.",
            "requirements": "Needed in the processing of institutional claims.",
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
                  "valueString": "RevenueCenter"
                }
              ],
              "strength": "example",
              "description": "Codes for the revenue or cost centers supplying the service and/or products.",
              "valueSet": "http://hl7.org/fhir/ValueSet/ex-revenue-center"
            }
          },
          {
            "id": "ExplanationOfBenefit.item.category",
            "path": "ExplanationOfBenefit.item.category",
            "short": "Benefit classification",
            "definition": "Code to identify the general type of benefits under which products and services are provided.",
            "comment": "Examples include Medical Care, Periodontics, Renal Dialysis, Vision Coverage.",
            "requirements": "Needed in the processing of institutional claims as this allows the insurer to determine whether a facial X-Ray is for dental, orthopedic, or facial surgery purposes.",
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
              "description": "Benefit categories such as: oral, medical, vision, oral-basic etc.",
              "valueSet": "http://hl7.org/fhir/ValueSet/ex-benefitcategory"
            }
          },
          {
            "id": "ExplanationOfBenefit.item.productOrService",
            "path": "ExplanationOfBenefit.item.productOrService",
            "short": "Billing, service, product, or drug code",
            "definition": "When the value is a group code then this item collects a set of related claim details, otherwise this contains the product, service, drug or other billing code for the item.",
            "comment": "If this is an actual service or product line, i.e. not a Group, then use code to indicate the Professional Service or Product supplied (e.g. CTP, HCPCS, USCLS, ICD10, NCPDP, DIN, RxNorm, ACHI, CCI). If a grouping item then use a group code to indicate the type of thing being grouped e.g. 'glasses' or 'compound'.",
            "requirements": "Necessary to state what was provided or done.",
            "alias": [
              "Drug Code",
              "Bill Code",
              "Service Code"
            ],
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
            "id": "ExplanationOfBenefit.item.modifier",
            "path": "ExplanationOfBenefit.item.modifier",
            "short": "Product or service billing modifiers",
            "definition": "Item typification or modifiers codes to convey additional context for the product or service.",
            "comment": "For example, in Oral whether the treatment is cosmetic or associated with TMJ, or for Medical whether the treatment was outside the clinic or out of office hours.",
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
            "id": "ExplanationOfBenefit.item.programCode",
            "path": "ExplanationOfBenefit.item.programCode",
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
            "id": "ExplanationOfBenefit.item.serviced[x]",
            "path": "ExplanationOfBenefit.item.serviced[x]",
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
            "id": "ExplanationOfBenefit.item.location[x]",
            "path": "ExplanationOfBenefit.item.location[x]",
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
              "description": "Place where the service is rendered.",
              "valueSet": "http://hl7.org/fhir/ValueSet/service-place"
            }
          },
          {
            "id": "ExplanationOfBenefit.item.quantity",
            "path": "ExplanationOfBenefit.item.quantity",
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
            "id": "ExplanationOfBenefit.item.unitPrice",
            "path": "ExplanationOfBenefit.item.unitPrice",
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
            "id": "ExplanationOfBenefit.item.factor",
            "path": "ExplanationOfBenefit.item.factor",
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
            "id": "ExplanationOfBenefit.item.net",
            "path": "ExplanationOfBenefit.item.net",
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
            "id": "ExplanationOfBenefit.item.udi",
            "path": "ExplanationOfBenefit.item.udi",
            "short": "Unique device identifier",
            "definition": "Unique Device Identifiers associated with this line item.",
            "requirements": "The UDI code allows the insurer to obtain device level information on the product supplied.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Device"
                ]
              }
            ]
          },
          {
            "id": "ExplanationOfBenefit.item.bodySite",
            "path": "ExplanationOfBenefit.item.bodySite",
            "short": "Anatomical location",
            "definition": "Physical service site on the patient (limb, tooth, etc.).",
            "comment": "For example: Providing a tooth code, allows an insurer to identify a provider performing a filling on a tooth that was previously removed.",
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
            "id": "ExplanationOfBenefit.item.subSite",
            "path": "ExplanationOfBenefit.item.subSite",
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
            "id": "ExplanationOfBenefit.item.encounter",
            "path": "ExplanationOfBenefit.item.encounter",
            "short": "Encounters related to this billed item",
            "definition": "A billed item may include goods or services provided in multiple encounters.",
            "requirements": "Used in some jurisdictions to link clinical events to claim items.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Encounter"
                ]
              }
            ]
          },
          {
            "id": "ExplanationOfBenefit.item.noteNumber",
            "path": "ExplanationOfBenefit.item.noteNumber",
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
            "id": "ExplanationOfBenefit.item.adjudication",
            "path": "ExplanationOfBenefit.item.adjudication",
            "short": "Adjudication details",
            "definition": "If this item is a group then the values here are a summary of the adjudication of the detail items. If this item is a simple product or service then this is the result of the adjudication of this item.",
            "requirements": "The adjudication results conveys the insurer's assessment of the item provided in the claim under the terms of the patient's insurance coverage.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ExplanationOfBenefit.item.adjudication.category",
            "path": "ExplanationOfBenefit.item.adjudication.category",
            "short": "Type of adjudication information",
            "definition": "A code to indicate the information type of this adjudication record. Information types may include: the value submitted, maximum values or percentages allowed or payable under the plan, amounts that the patient is responsible for in-aggregate or pertaining to this item, amounts paid by other coverages, and the benefit payable for this item.",
            "comment": "For example, codes indicating: Co-Pay, deductible, eligible, benefit, tax, etc.",
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
            "id": "ExplanationOfBenefit.item.adjudication.reason",
            "path": "ExplanationOfBenefit.item.adjudication.reason",
            "short": "Explanation of adjudication outcome",
            "definition": "A code supporting the understanding of the adjudication result and explaining variance from expected amount.",
            "comment": "For example, may indicate that the funds for this benefit type have been exhausted.",
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
              "description": "Adjudication reason codes.",
              "valueSet": "http://hl7.org/fhir/ValueSet/adjudication-reason"
            }
          },
          {
            "id": "ExplanationOfBenefit.item.adjudication.amount",
            "path": "ExplanationOfBenefit.item.adjudication.amount",
            "short": "Monetary amount",
            "definition": "Monetary amount associated with the category.",
            "comment": "For example, amount submitted, eligible amount, co-payment, and benefit payable.",
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
            "id": "ExplanationOfBenefit.item.adjudication.value",
            "path": "ExplanationOfBenefit.item.adjudication.value",
            "short": "Non-monitary value",
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
            "id": "ExplanationOfBenefit.item.detail",
            "path": "ExplanationOfBenefit.item.detail",
            "short": "Additional items",
            "definition": "Second-tier of goods and services.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ExplanationOfBenefit.item.detail.sequence",
            "path": "ExplanationOfBenefit.item.detail.sequence",
            "short": "Product or service provided",
            "definition": "A claim detail line. Either a simple (a product or service) or a 'group' of sub-details which are simple items.",
            "requirements": "The items to be processed for adjudication.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "positiveInt"
              }
            ]
          },
          {
            "id": "ExplanationOfBenefit.item.detail.revenue",
            "path": "ExplanationOfBenefit.item.detail.revenue",
            "short": "Revenue or cost center code",
            "definition": "The type of revenue or cost center providing the product and/or service.",
            "requirements": "Needed in the processing of institutional claims.",
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
                  "valueString": "RevenueCenter"
                }
              ],
              "strength": "example",
              "description": "Codes for the revenue or cost centers supplying the service and/or products.",
              "valueSet": "http://hl7.org/fhir/ValueSet/ex-revenue-center"
            }
          },
          {
            "id": "ExplanationOfBenefit.item.detail.category",
            "path": "ExplanationOfBenefit.item.detail.category",
            "short": "Benefit classification",
            "definition": "Code to identify the general type of benefits under which products and services are provided.",
            "comment": "Examples include: Medical Care, Periodontics, Renal Dialysis, Vision Coverage.",
            "requirements": "Needed in the processing of institutional claims as this allows the insurer to determine whether a facial X-Ray is for dental, orthopedic, or facial surgery purposes.",
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
              "description": "Benefit categories such as: oral, medical, vision, oral-basic etc.",
              "valueSet": "http://hl7.org/fhir/ValueSet/ex-benefitcategory"
            }
          },
          {
            "id": "ExplanationOfBenefit.item.detail.productOrService",
            "path": "ExplanationOfBenefit.item.detail.productOrService",
            "short": "Billing, service, product, or drug code",
            "definition": "When the value is a group code then this item collects a set of related claim details, otherwise this contains the product, service, drug or other billing code for the item.",
            "comment": "If this is an actual service or product line, i.e. not a Group, then use code to indicate the Professional Service or Product supplied (e.g. CTP, HCPCS, USCLS, ICD10, NCPDP, DIN, RxNorm, ACHI, CCI). If a grouping item then use a group code to indicate the type of thing being grouped e.g. 'glasses' or 'compound'.",
            "requirements": "Necessary to state what was provided or done.",
            "alias": [
              "Drug Code",
              "Bill Code",
              "Service Code"
            ],
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
            "id": "ExplanationOfBenefit.item.detail.modifier",
            "path": "ExplanationOfBenefit.item.detail.modifier",
            "short": "Service/Product billing modifiers",
            "definition": "Item typification or modifiers codes to convey additional context for the product or service.",
            "comment": "For example, in Oral whether the treatment is cosmetic or associated with TMJ, or for Medical whether the treatment was outside the clinic or out of office hours.",
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
            "id": "ExplanationOfBenefit.item.detail.programCode",
            "path": "ExplanationOfBenefit.item.detail.programCode",
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
            "id": "ExplanationOfBenefit.item.detail.quantity",
            "path": "ExplanationOfBenefit.item.detail.quantity",
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
            "id": "ExplanationOfBenefit.item.detail.unitPrice",
            "path": "ExplanationOfBenefit.item.detail.unitPrice",
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
            "id": "ExplanationOfBenefit.item.detail.factor",
            "path": "ExplanationOfBenefit.item.detail.factor",
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
            "id": "ExplanationOfBenefit.item.detail.net",
            "path": "ExplanationOfBenefit.item.detail.net",
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
            "id": "ExplanationOfBenefit.item.detail.udi",
            "path": "ExplanationOfBenefit.item.detail.udi",
            "short": "Unique device identifier",
            "definition": "Unique Device Identifiers associated with this line item.",
            "requirements": "The UDI code allows the insurer to obtain device level information on the product supplied.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Device"
                ]
              }
            ]
          },
          {
            "id": "ExplanationOfBenefit.item.detail.noteNumber",
            "path": "ExplanationOfBenefit.item.detail.noteNumber",
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
            "id": "ExplanationOfBenefit.item.detail.adjudication",
            "path": "ExplanationOfBenefit.item.detail.adjudication",
            "short": "Detail level adjudication details",
            "definition": "The adjudication results.",
            "min": 0,
            "max": "*",
            "contentReference": "#ExplanationOfBenefit.item.adjudication"
          },
          {
            "id": "ExplanationOfBenefit.item.detail.subDetail",
            "path": "ExplanationOfBenefit.item.detail.subDetail",
            "short": "Additional items",
            "definition": "Third-tier of goods and services.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ExplanationOfBenefit.item.detail.subDetail.sequence",
            "path": "ExplanationOfBenefit.item.detail.subDetail.sequence",
            "short": "Product or service provided",
            "definition": "A claim detail line. Either a simple (a product or service) or a 'group' of sub-details which are simple items.",
            "requirements": "The items to be processed for adjudication.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "positiveInt"
              }
            ]
          },
          {
            "id": "ExplanationOfBenefit.item.detail.subDetail.revenue",
            "path": "ExplanationOfBenefit.item.detail.subDetail.revenue",
            "short": "Revenue or cost center code",
            "definition": "The type of revenue or cost center providing the product and/or service.",
            "requirements": "Needed in the processing of institutional claims.",
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
                  "valueString": "RevenueCenter"
                }
              ],
              "strength": "example",
              "description": "Codes for the revenue or cost centers supplying the service and/or products.",
              "valueSet": "http://hl7.org/fhir/ValueSet/ex-revenue-center"
            }
          },
          {
            "id": "ExplanationOfBenefit.item.detail.subDetail.category",
            "path": "ExplanationOfBenefit.item.detail.subDetail.category",
            "short": "Benefit classification",
            "definition": "Code to identify the general type of benefits under which products and services are provided.",
            "comment": "Examples include Medical Care, Periodontics, Renal Dialysis, Vision Coverage.",
            "requirements": "Needed in the processing of institutional claims as this allows the insurer to determine whether a facial X-Ray is for dental, orthopedic, or facial surgery purposes.",
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
              "description": "Benefit categories such as: oral, medical, vision, oral-basic etc.",
              "valueSet": "http://hl7.org/fhir/ValueSet/ex-benefitcategory"
            }
          },
          {
            "id": "ExplanationOfBenefit.item.detail.subDetail.productOrService",
            "path": "ExplanationOfBenefit.item.detail.subDetail.productOrService",
            "short": "Billing, service, product, or drug code",
            "definition": "When the value is a group code then this item collects a set of related claim details, otherwise this contains the product, service, drug or other billing code for the item.",
            "comment": "If this is an actual service or product line, i.e. not a Group, then use code to indicate the Professional Service or Product supplied (e.g. CTP, HCPCS, USCLS, ICD10, NCPDP, DIN, RxNorm, ACHI, CCI). If a grouping item then use a group code to indicate the type of thing being grouped e.g. 'glasses' or 'compound'.",
            "requirements": "Necessary to state what was provided or done.",
            "alias": [
              "Drug Code",
              "Bill Code",
              "Service Code"
            ],
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
            "id": "ExplanationOfBenefit.item.detail.subDetail.modifier",
            "path": "ExplanationOfBenefit.item.detail.subDetail.modifier",
            "short": "Service/Product billing modifiers",
            "definition": "Item typification or modifiers codes to convey additional context for the product or service.",
            "comment": "For example, in Oral whether the treatment is cosmetic or associated with TMJ, or for Medical whether the treatment was outside the clinic or outside of office hours.",
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
            "id": "ExplanationOfBenefit.item.detail.subDetail.programCode",
            "path": "ExplanationOfBenefit.item.detail.subDetail.programCode",
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
            "id": "ExplanationOfBenefit.item.detail.subDetail.quantity",
            "path": "ExplanationOfBenefit.item.detail.subDetail.quantity",
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
            "id": "ExplanationOfBenefit.item.detail.subDetail.unitPrice",
            "path": "ExplanationOfBenefit.item.detail.subDetail.unitPrice",
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
            "id": "ExplanationOfBenefit.item.detail.subDetail.factor",
            "path": "ExplanationOfBenefit.item.detail.subDetail.factor",
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
            "id": "ExplanationOfBenefit.item.detail.subDetail.net",
            "path": "ExplanationOfBenefit.item.detail.subDetail.net",
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
            "id": "ExplanationOfBenefit.item.detail.subDetail.udi",
            "path": "ExplanationOfBenefit.item.detail.subDetail.udi",
            "short": "Unique device identifier",
            "definition": "Unique Device Identifiers associated with this line item.",
            "requirements": "The UDI code allows the insurer to obtain device level information on the product supplied.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Device"
                ]
              }
            ]
          },
          {
            "id": "ExplanationOfBenefit.item.detail.subDetail.noteNumber",
            "path": "ExplanationOfBenefit.item.detail.subDetail.noteNumber",
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
            "id": "ExplanationOfBenefit.item.detail.subDetail.adjudication",
            "path": "ExplanationOfBenefit.item.detail.subDetail.adjudication",
            "short": "Subdetail level adjudication details",
            "definition": "The adjudication results.",
            "min": 0,
            "max": "*",
            "contentReference": "#ExplanationOfBenefit.item.adjudication"
          },
          {
            "id": "ExplanationOfBenefit.addItem",
            "path": "ExplanationOfBenefit.addItem",
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
            "id": "ExplanationOfBenefit.addItem.itemSequence",
            "path": "ExplanationOfBenefit.addItem.itemSequence",
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
            "id": "ExplanationOfBenefit.addItem.detailSequence",
            "path": "ExplanationOfBenefit.addItem.detailSequence",
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
            "id": "ExplanationOfBenefit.addItem.subDetailSequence",
            "path": "ExplanationOfBenefit.addItem.subDetailSequence",
            "short": "Subdetail sequence number",
            "definition": "The sequence number of the sub-details woithin the details within the claim item which this line is intended to replace.",
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
            "id": "ExplanationOfBenefit.addItem.provider",
            "path": "ExplanationOfBenefit.addItem.provider",
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
            "id": "ExplanationOfBenefit.addItem.productOrService",
            "path": "ExplanationOfBenefit.addItem.productOrService",
            "short": "Billing, service, product, or drug code",
            "definition": "When the value is a group code then this item collects a set of related claim details, otherwise this contains the product, service, drug or other billing code for the item.",
            "comment": "If this is an actual service or product line, i.e. not a Group, then use code to indicate the Professional Service or Product supplied (e.g. CTP, HCPCS, USCLS, ICD10, NCPDP, DIN, RxNorm, ACHI, CCI). If a grouping item then use a group code to indicate the type of thing being grouped e.g. 'glasses' or 'compound'.",
            "requirements": "Necessary to state what was provided or done.",
            "alias": [
              "Drug Code",
              "Bill Code",
              "Service Code"
            ],
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
            "id": "ExplanationOfBenefit.addItem.modifier",
            "path": "ExplanationOfBenefit.addItem.modifier",
            "short": "Service/Product billing modifiers",
            "definition": "Item typification or modifiers codes to convey additional context for the product or service.",
            "comment": "For example, in Oral whether the treatment is cosmetic or associated with TMJ, or for Medical whether the treatment was outside the clinic or out of office hours.",
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
            "id": "ExplanationOfBenefit.addItem.programCode",
            "path": "ExplanationOfBenefit.addItem.programCode",
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
            "id": "ExplanationOfBenefit.addItem.serviced[x]",
            "path": "ExplanationOfBenefit.addItem.serviced[x]",
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
            "id": "ExplanationOfBenefit.addItem.location[x]",
            "path": "ExplanationOfBenefit.addItem.location[x]",
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
              "description": "Place where the service is rendered.",
              "valueSet": "http://hl7.org/fhir/ValueSet/service-place"
            }
          },
          {
            "id": "ExplanationOfBenefit.addItem.quantity",
            "path": "ExplanationOfBenefit.addItem.quantity",
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
            "id": "ExplanationOfBenefit.addItem.unitPrice",
            "path": "ExplanationOfBenefit.addItem.unitPrice",
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
            "id": "ExplanationOfBenefit.addItem.factor",
            "path": "ExplanationOfBenefit.addItem.factor",
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
            "id": "ExplanationOfBenefit.addItem.net",
            "path": "ExplanationOfBenefit.addItem.net",
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
            "id": "ExplanationOfBenefit.addItem.bodySite",
            "path": "ExplanationOfBenefit.addItem.bodySite",
            "short": "Anatomical location",
            "definition": "Physical service site on the patient (limb, tooth, etc.).",
            "comment": "For example, providing a tooth code allows an insurer to identify a provider performing a filling on a tooth that was previously removed.",
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
            "id": "ExplanationOfBenefit.addItem.subSite",
            "path": "ExplanationOfBenefit.addItem.subSite",
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
            "id": "ExplanationOfBenefit.addItem.noteNumber",
            "path": "ExplanationOfBenefit.addItem.noteNumber",
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
            "id": "ExplanationOfBenefit.addItem.adjudication",
            "path": "ExplanationOfBenefit.addItem.adjudication",
            "short": "Added items adjudication",
            "definition": "The adjudication results.",
            "min": 0,
            "max": "*",
            "contentReference": "#ExplanationOfBenefit.item.adjudication"
          },
          {
            "id": "ExplanationOfBenefit.addItem.detail",
            "path": "ExplanationOfBenefit.addItem.detail",
            "short": "Insurer added line items",
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
            "id": "ExplanationOfBenefit.addItem.detail.productOrService",
            "path": "ExplanationOfBenefit.addItem.detail.productOrService",
            "short": "Billing, service, product, or drug code",
            "definition": "When the value is a group code then this item collects a set of related claim details, otherwise this contains the product, service, drug or other billing code for the item.",
            "comment": "If this is an actual service or product line, i.e. not a Group, then use code to indicate the Professional Service or Product supplied (e.g. CTP, HCPCS, USCLS, ICD10, NCPDP, DIN, RxNorm, ACHI, CCI). If a grouping item then use a group code to indicate the type of thing being grouped e.g. 'glasses' or 'compound'.",
            "requirements": "Necessary to state what was provided or done.",
            "alias": [
              "Drug Code",
              "Bill Code",
              "Service Code"
            ],
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
            "id": "ExplanationOfBenefit.addItem.detail.modifier",
            "path": "ExplanationOfBenefit.addItem.detail.modifier",
            "short": "Service/Product billing modifiers",
            "definition": "Item typification or modifiers codes to convey additional context for the product or service.",
            "comment": "For example, in Oral whether the treatment is cosmetic or associated with TMJ, or for Medical whether the treatment was outside the clinic or out of office hours.",
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
            "id": "ExplanationOfBenefit.addItem.detail.quantity",
            "path": "ExplanationOfBenefit.addItem.detail.quantity",
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
            "id": "ExplanationOfBenefit.addItem.detail.unitPrice",
            "path": "ExplanationOfBenefit.addItem.detail.unitPrice",
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
            "id": "ExplanationOfBenefit.addItem.detail.factor",
            "path": "ExplanationOfBenefit.addItem.detail.factor",
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
            "id": "ExplanationOfBenefit.addItem.detail.net",
            "path": "ExplanationOfBenefit.addItem.detail.net",
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
            "id": "ExplanationOfBenefit.addItem.detail.noteNumber",
            "path": "ExplanationOfBenefit.addItem.detail.noteNumber",
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
            "id": "ExplanationOfBenefit.addItem.detail.adjudication",
            "path": "ExplanationOfBenefit.addItem.detail.adjudication",
            "short": "Added items adjudication",
            "definition": "The adjudication results.",
            "min": 0,
            "max": "*",
            "contentReference": "#ExplanationOfBenefit.item.adjudication"
          },
          {
            "id": "ExplanationOfBenefit.addItem.detail.subDetail",
            "path": "ExplanationOfBenefit.addItem.detail.subDetail",
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
            "id": "ExplanationOfBenefit.addItem.detail.subDetail.productOrService",
            "path": "ExplanationOfBenefit.addItem.detail.subDetail.productOrService",
            "short": "Billing, service, product, or drug code",
            "definition": "When the value is a group code then this item collects a set of related claim details, otherwise this contains the product, service, drug or other billing code for the item.",
            "comment": "If this is an actual service or product line, i.e. not a Group, then use code to indicate the Professional Service or Product supplied (e.g. CTP, HCPCS, USCLS, ICD10, NCPDP, DIN, RxNorm, ACHI, CCI). If a grouping item then use a group code to indicate the type of thing being grouped e.g. 'glasses' or 'compound'.",
            "requirements": "Necessary to state what was provided or done.",
            "alias": [
              "Drug Code",
              "Bill Code",
              "Service Code"
            ],
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
            "id": "ExplanationOfBenefit.addItem.detail.subDetail.modifier",
            "path": "ExplanationOfBenefit.addItem.detail.subDetail.modifier",
            "short": "Service/Product billing modifiers",
            "definition": "Item typification or modifiers codes to convey additional context for the product or service.",
            "comment": "For example, in Oral whether the treatment is cosmetic or associated with TMJ, or for Medical whether the treatment was outside the clinic or out of office hours.",
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
            "id": "ExplanationOfBenefit.addItem.detail.subDetail.quantity",
            "path": "ExplanationOfBenefit.addItem.detail.subDetail.quantity",
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
            "id": "ExplanationOfBenefit.addItem.detail.subDetail.unitPrice",
            "path": "ExplanationOfBenefit.addItem.detail.subDetail.unitPrice",
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
            "id": "ExplanationOfBenefit.addItem.detail.subDetail.factor",
            "path": "ExplanationOfBenefit.addItem.detail.subDetail.factor",
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
            "id": "ExplanationOfBenefit.addItem.detail.subDetail.net",
            "path": "ExplanationOfBenefit.addItem.detail.subDetail.net",
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
            "id": "ExplanationOfBenefit.addItem.detail.subDetail.noteNumber",
            "path": "ExplanationOfBenefit.addItem.detail.subDetail.noteNumber",
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
            "id": "ExplanationOfBenefit.addItem.detail.subDetail.adjudication",
            "path": "ExplanationOfBenefit.addItem.detail.subDetail.adjudication",
            "short": "Added items adjudication",
            "definition": "The adjudication results.",
            "min": 0,
            "max": "*",
            "contentReference": "#ExplanationOfBenefit.item.adjudication"
          },
          {
            "id": "ExplanationOfBenefit.adjudication",
            "path": "ExplanationOfBenefit.adjudication",
            "short": "Header-level adjudication",
            "definition": "The adjudication results which are presented at the header level rather than at the line-item or add-item levels.",
            "requirements": "Some insurers will receive line-items but provide the adjudication only at a summary or header-level.",
            "min": 0,
            "max": "*",
            "contentReference": "#ExplanationOfBenefit.item.adjudication"
          },
          {
            "id": "ExplanationOfBenefit.total",
            "path": "ExplanationOfBenefit.total",
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
            "id": "ExplanationOfBenefit.total.category",
            "path": "ExplanationOfBenefit.total.category",
            "short": "Type of adjudication information",
            "definition": "A code to indicate the information type of this adjudication record. Information types may include: the value submitted, maximum values or percentages allowed or payable under the plan, amounts that the patient is responsible for in aggregate or pertaining to this item, amounts paid by other coverages, and the benefit payable for this item.",
            "comment": "For example, codes indicating: Co-Pay, deductible, eligible, benefit, tax, etc.",
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
            "id": "ExplanationOfBenefit.total.amount",
            "path": "ExplanationOfBenefit.total.amount",
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
            "id": "ExplanationOfBenefit.payment",
            "path": "ExplanationOfBenefit.payment",
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
            "id": "ExplanationOfBenefit.payment.type",
            "path": "ExplanationOfBenefit.payment.type",
            "short": "Partial or complete payment",
            "definition": "Whether this represents partial or complete payment of the benefits payable.",
            "requirements": "To advise the requestor when the insurer believes all payments to have been completed.",
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
                  "valueString": "PaymentType"
                }
              ],
              "strength": "example",
              "description": "The type (partial, complete) of the payment.",
              "valueSet": "http://hl7.org/fhir/ValueSet/ex-paymenttype"
            }
          },
          {
            "id": "ExplanationOfBenefit.payment.adjustment",
            "path": "ExplanationOfBenefit.payment.adjustment",
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
            "id": "ExplanationOfBenefit.payment.adjustmentReason",
            "path": "ExplanationOfBenefit.payment.adjustmentReason",
            "short": "Explanation for the variance",
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
            "id": "ExplanationOfBenefit.payment.date",
            "path": "ExplanationOfBenefit.payment.date",
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
            "id": "ExplanationOfBenefit.payment.amount",
            "path": "ExplanationOfBenefit.payment.amount",
            "short": "Payable amount after adjustment",
            "definition": "Benefits payable less any payment adjustment.",
            "requirements": "Needed to provide the actual payment amount.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Money"
              }
            ]
          },
          {
            "id": "ExplanationOfBenefit.payment.identifier",
            "path": "ExplanationOfBenefit.payment.identifier",
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
            "id": "ExplanationOfBenefit.formCode",
            "path": "ExplanationOfBenefit.formCode",
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
            "id": "ExplanationOfBenefit.form",
            "path": "ExplanationOfBenefit.form",
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
            "id": "ExplanationOfBenefit.processNote",
            "path": "ExplanationOfBenefit.processNote",
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
            "id": "ExplanationOfBenefit.processNote.number",
            "path": "ExplanationOfBenefit.processNote.number",
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
            "id": "ExplanationOfBenefit.processNote.type",
            "path": "ExplanationOfBenefit.processNote.type",
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
            "id": "ExplanationOfBenefit.processNote.text",
            "path": "ExplanationOfBenefit.processNote.text",
            "short": "Note explanatory text",
            "definition": "The explanation or description associated with the processing.",
            "requirements": "Required to provide human readable explanation.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ExplanationOfBenefit.processNote.language",
            "path": "ExplanationOfBenefit.processNote.language",
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
            "id": "ExplanationOfBenefit.benefitPeriod",
            "path": "ExplanationOfBenefit.benefitPeriod",
            "short": "When the benefits are applicable",
            "definition": "The term of the benefits documented in this response.",
            "comment": "Not applicable when use=claim.",
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
            "id": "ExplanationOfBenefit.benefitBalance",
            "path": "ExplanationOfBenefit.benefitBalance",
            "short": "Balance by Benefit Category",
            "definition": "Balance by Benefit Category.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ExplanationOfBenefit.benefitBalance.category",
            "path": "ExplanationOfBenefit.benefitBalance.category",
            "short": "Benefit classification",
            "definition": "Code to identify the general type of benefits under which products and services are provided.",
            "comment": "Examples include Medical Care, Periodontics, Renal Dialysis, Vision Coverage.",
            "requirements": "Needed to convey the category of service or product for which eligibility is sought.",
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
                  "valueString": "BenefitCategory"
                }
              ],
              "strength": "example",
              "description": "Benefit categories such as: oral, medical, vision, oral-basic etc.",
              "valueSet": "http://hl7.org/fhir/ValueSet/ex-benefitcategory"
            }
          },
          {
            "id": "ExplanationOfBenefit.benefitBalance.excluded",
            "path": "ExplanationOfBenefit.benefitBalance.excluded",
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
            "id": "ExplanationOfBenefit.benefitBalance.name",
            "path": "ExplanationOfBenefit.benefitBalance.name",
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
            "id": "ExplanationOfBenefit.benefitBalance.description",
            "path": "ExplanationOfBenefit.benefitBalance.description",
            "short": "Description of the benefit or services covered",
            "definition": "A richer description of the benefit or services covered.",
            "comment": "For example, 'DENT2 covers 100% of basic, 50% of major but excludes Ortho, Implants and Cosmetic services'.",
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
            "id": "ExplanationOfBenefit.benefitBalance.network",
            "path": "ExplanationOfBenefit.benefitBalance.network",
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
            "id": "ExplanationOfBenefit.benefitBalance.unit",
            "path": "ExplanationOfBenefit.benefitBalance.unit",
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
            "id": "ExplanationOfBenefit.benefitBalance.term",
            "path": "ExplanationOfBenefit.benefitBalance.term",
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
            "id": "ExplanationOfBenefit.benefitBalance.financial",
            "path": "ExplanationOfBenefit.benefitBalance.financial",
            "short": "Benefit Summary",
            "definition": "Benefits Used to date.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ExplanationOfBenefit.benefitBalance.financial.type",
            "path": "ExplanationOfBenefit.benefitBalance.financial.type",
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
            "id": "ExplanationOfBenefit.benefitBalance.financial.allowed[x]",
            "path": "ExplanationOfBenefit.benefitBalance.financial.allowed[x]",
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
            "id": "ExplanationOfBenefit.benefitBalance.financial.used[x]",
            "path": "ExplanationOfBenefit.benefitBalance.financial.used[x]",
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
                "code": "Money"
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion
    /// <summary>
    /// Fhir resource 'ExplanationOfBenefit'
    /// </summary>
    // 0. ExplanationOfBenefit
    public partial class Resource_ExplanationOfBenefit : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 15. ExplanationOfBenefit.related
        public partial class Type_Related : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 16. ExplanationOfBenefit.related.claim
            public ElementDefinitionInfo Element_Claim;
            // 17. ExplanationOfBenefit.related.relationship
            public ElementDefinitionInfo Element_Relationship;
            // 18. ExplanationOfBenefit.related.reference
            public ElementDefinitionInfo Element_Reference;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "ExplanationOfBenefit.related",
                    ElementId = "ExplanationOfBenefit.related"
                });
                Element_Claim.Write(sDef);
                Element_Relationship.Write(sDef);
                Element_Reference.Write(sDef);
            }
            
            public Type_Related()
            {
                {
                    // 16. ExplanationOfBenefit.related.claim
                    this.Element_Claim = new ElementDefinitionInfo
                    {
                        Name = "Element_Claim",
                        Path= "ExplanationOfBenefit.related.claim",
                        Id = "ExplanationOfBenefit.related.claim",
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
                    // 17. ExplanationOfBenefit.related.relationship
                    this.Element_Relationship = new ElementDefinitionInfo
                    {
                        Name = "Element_Relationship",
                        Path= "ExplanationOfBenefit.related.relationship",
                        Id = "ExplanationOfBenefit.related.relationship",
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
                    // 18. ExplanationOfBenefit.related.reference
                    this.Element_Reference = new ElementDefinitionInfo
                    {
                        Name = "Element_Reference",
                        Path= "ExplanationOfBenefit.related.reference",
                        Id = "ExplanationOfBenefit.related.reference",
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
        // 21. ExplanationOfBenefit.payee
        public partial class Type_Payee : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 22. ExplanationOfBenefit.payee.type
            public ElementDefinitionInfo Element_Type;
            // 23. ExplanationOfBenefit.payee.party
            public ElementDefinitionInfo Element_Party;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "ExplanationOfBenefit.payee",
                    ElementId = "ExplanationOfBenefit.payee"
                });
                Element_Type.Write(sDef);
                Element_Party.Write(sDef);
            }
            
            public Type_Payee()
            {
                {
                    // 22. ExplanationOfBenefit.payee.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "ExplanationOfBenefit.payee.type",
                        Id = "ExplanationOfBenefit.payee.type",
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
                    // 23. ExplanationOfBenefit.payee.party
                    this.Element_Party = new ElementDefinitionInfo
                    {
                        Name = "Element_Party",
                        Path= "ExplanationOfBenefit.payee.party",
                        Id = "ExplanationOfBenefit.payee.party",
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
                                    "http://hl7.org/fhir/StructureDefinition/Organization",
                                    "http://hl7.org/fhir/StructureDefinition/Patient",
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson"
                                }
                            }
                        }
                    };
                }
            }
        }
        // 32. ExplanationOfBenefit.careTeam
        public partial class Type_CareTeam : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 33. ExplanationOfBenefit.careTeam.sequence
            public ElementDefinitionInfo Element_Sequence;
            // 34. ExplanationOfBenefit.careTeam.provider
            public ElementDefinitionInfo Element_Provider;
            // 35. ExplanationOfBenefit.careTeam.responsible
            public ElementDefinitionInfo Element_Responsible;
            // 36. ExplanationOfBenefit.careTeam.role
            public ElementDefinitionInfo Element_Role;
            // 37. ExplanationOfBenefit.careTeam.qualification
            public ElementDefinitionInfo Element_Qualification;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "ExplanationOfBenefit.careTeam",
                    ElementId = "ExplanationOfBenefit.careTeam"
                });
                Element_Sequence.Write(sDef);
                Element_Provider.Write(sDef);
                Element_Responsible.Write(sDef);
                Element_Role.Write(sDef);
                Element_Qualification.Write(sDef);
            }
            
            public Type_CareTeam()
            {
                {
                    // 33. ExplanationOfBenefit.careTeam.sequence
                    this.Element_Sequence = new ElementDefinitionInfo
                    {
                        Name = "Element_Sequence",
                        Path= "ExplanationOfBenefit.careTeam.sequence",
                        Id = "ExplanationOfBenefit.careTeam.sequence",
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
                    // 34. ExplanationOfBenefit.careTeam.provider
                    this.Element_Provider = new ElementDefinitionInfo
                    {
                        Name = "Element_Provider",
                        Path= "ExplanationOfBenefit.careTeam.provider",
                        Id = "ExplanationOfBenefit.careTeam.provider",
                        Min = 1,
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
                    // 35. ExplanationOfBenefit.careTeam.responsible
                    this.Element_Responsible = new ElementDefinitionInfo
                    {
                        Name = "Element_Responsible",
                        Path= "ExplanationOfBenefit.careTeam.responsible",
                        Id = "ExplanationOfBenefit.careTeam.responsible",
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
                    // 36. ExplanationOfBenefit.careTeam.role
                    this.Element_Role = new ElementDefinitionInfo
                    {
                        Name = "Element_Role",
                        Path= "ExplanationOfBenefit.careTeam.role",
                        Id = "ExplanationOfBenefit.careTeam.role",
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
                    // 37. ExplanationOfBenefit.careTeam.qualification
                    this.Element_Qualification = new ElementDefinitionInfo
                    {
                        Name = "Element_Qualification",
                        Path= "ExplanationOfBenefit.careTeam.qualification",
                        Id = "ExplanationOfBenefit.careTeam.qualification",
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
        // 38. ExplanationOfBenefit.supportingInfo
        public partial class Type_SupportingInfo : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 39. ExplanationOfBenefit.supportingInfo.sequence
            public ElementDefinitionInfo Element_Sequence;
            // 40. ExplanationOfBenefit.supportingInfo.category
            public ElementDefinitionInfo Element_Category;
            // 41. ExplanationOfBenefit.supportingInfo.code
            public ElementDefinitionInfo Element_Code;
            // 42. ExplanationOfBenefit.supportingInfo.timing[x]
            public ElementDefinitionInfo Element_Timing;
            // 43. ExplanationOfBenefit.supportingInfo.value[x]
            public ElementDefinitionInfo Element_Value;
            // 44. ExplanationOfBenefit.supportingInfo.reason
            public ElementDefinitionInfo Element_Reason;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "ExplanationOfBenefit.supportingInfo",
                    ElementId = "ExplanationOfBenefit.supportingInfo"
                });
                Element_Sequence.Write(sDef);
                Element_Category.Write(sDef);
                Element_Code.Write(sDef);
                Element_Timing.Write(sDef);
                Element_Value.Write(sDef);
                Element_Reason.Write(sDef);
            }
            
            public Type_SupportingInfo()
            {
                {
                    // 39. ExplanationOfBenefit.supportingInfo.sequence
                    this.Element_Sequence = new ElementDefinitionInfo
                    {
                        Name = "Element_Sequence",
                        Path= "ExplanationOfBenefit.supportingInfo.sequence",
                        Id = "ExplanationOfBenefit.supportingInfo.sequence",
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
                    // 40. ExplanationOfBenefit.supportingInfo.category
                    this.Element_Category = new ElementDefinitionInfo
                    {
                        Name = "Element_Category",
                        Path= "ExplanationOfBenefit.supportingInfo.category",
                        Id = "ExplanationOfBenefit.supportingInfo.category",
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
                    // 41. ExplanationOfBenefit.supportingInfo.code
                    this.Element_Code = new ElementDefinitionInfo
                    {
                        Name = "Element_Code",
                        Path= "ExplanationOfBenefit.supportingInfo.code",
                        Id = "ExplanationOfBenefit.supportingInfo.code",
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
                    // 42. ExplanationOfBenefit.supportingInfo.timing[x]
                    this.Element_Timing = new ElementDefinitionInfo
                    {
                        Name = "Element_Timing",
                        Path= "ExplanationOfBenefit.supportingInfo.timing[x]",
                        Id = "ExplanationOfBenefit.supportingInfo.timing[x]",
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
                    // 43. ExplanationOfBenefit.supportingInfo.value[x]
                    this.Element_Value = new ElementDefinitionInfo
                    {
                        Name = "Element_Value",
                        Path= "ExplanationOfBenefit.supportingInfo.value[x]",
                        Id = "ExplanationOfBenefit.supportingInfo.value[x]",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Boolean
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_String
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Quantity
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Attachment
                            {
                            },
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
                    // 44. ExplanationOfBenefit.supportingInfo.reason
                    this.Element_Reason = new ElementDefinitionInfo
                    {
                        Name = "Element_Reason",
                        Path= "ExplanationOfBenefit.supportingInfo.reason",
                        Id = "ExplanationOfBenefit.supportingInfo.reason",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Coding
                            {
                            }
                        }
                    };
                }
            }
        }
        // 45. ExplanationOfBenefit.diagnosis
        public partial class Type_Diagnosis : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 46. ExplanationOfBenefit.diagnosis.sequence
            public ElementDefinitionInfo Element_Sequence;
            // 47. ExplanationOfBenefit.diagnosis.diagnosis[x]
            public ElementDefinitionInfo Element_Diagnosis;
            // 48. ExplanationOfBenefit.diagnosis.type
            public ElementDefinitionInfo Element_Type;
            // 49. ExplanationOfBenefit.diagnosis.onAdmission
            public ElementDefinitionInfo Element_OnAdmission;
            // 50. ExplanationOfBenefit.diagnosis.packageCode
            public ElementDefinitionInfo Element_PackageCode;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "ExplanationOfBenefit.diagnosis",
                    ElementId = "ExplanationOfBenefit.diagnosis"
                });
                Element_Sequence.Write(sDef);
                Element_Diagnosis.Write(sDef);
                Element_Type.Write(sDef);
                Element_OnAdmission.Write(sDef);
                Element_PackageCode.Write(sDef);
            }
            
            public Type_Diagnosis()
            {
                {
                    // 46. ExplanationOfBenefit.diagnosis.sequence
                    this.Element_Sequence = new ElementDefinitionInfo
                    {
                        Name = "Element_Sequence",
                        Path= "ExplanationOfBenefit.diagnosis.sequence",
                        Id = "ExplanationOfBenefit.diagnosis.sequence",
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
                    // 47. ExplanationOfBenefit.diagnosis.diagnosis[x]
                    this.Element_Diagnosis = new ElementDefinitionInfo
                    {
                        Name = "Element_Diagnosis",
                        Path= "ExplanationOfBenefit.diagnosis.diagnosis[x]",
                        Id = "ExplanationOfBenefit.diagnosis.diagnosis[x]",
                        Min = 1,
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
                {
                    // 48. ExplanationOfBenefit.diagnosis.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "ExplanationOfBenefit.diagnosis.type",
                        Id = "ExplanationOfBenefit.diagnosis.type",
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
                    // 49. ExplanationOfBenefit.diagnosis.onAdmission
                    this.Element_OnAdmission = new ElementDefinitionInfo
                    {
                        Name = "Element_OnAdmission",
                        Path= "ExplanationOfBenefit.diagnosis.onAdmission",
                        Id = "ExplanationOfBenefit.diagnosis.onAdmission",
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
                    // 50. ExplanationOfBenefit.diagnosis.packageCode
                    this.Element_PackageCode = new ElementDefinitionInfo
                    {
                        Name = "Element_PackageCode",
                        Path= "ExplanationOfBenefit.diagnosis.packageCode",
                        Id = "ExplanationOfBenefit.diagnosis.packageCode",
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
        // 51. ExplanationOfBenefit.procedure
        public partial class Type_Procedure : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 52. ExplanationOfBenefit.procedure.sequence
            public ElementDefinitionInfo Element_Sequence;
            // 53. ExplanationOfBenefit.procedure.type
            public ElementDefinitionInfo Element_Type;
            // 54. ExplanationOfBenefit.procedure.date
            public ElementDefinitionInfo Element_Date;
            // 55. ExplanationOfBenefit.procedure.procedure[x]
            public ElementDefinitionInfo Element_Procedure;
            // 56. ExplanationOfBenefit.procedure.udi
            public ElementDefinitionInfo Element_Udi;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "ExplanationOfBenefit.procedure",
                    ElementId = "ExplanationOfBenefit.procedure"
                });
                Element_Sequence.Write(sDef);
                Element_Type.Write(sDef);
                Element_Date.Write(sDef);
                Element_Procedure.Write(sDef);
                Element_Udi.Write(sDef);
            }
            
            public Type_Procedure()
            {
                {
                    // 52. ExplanationOfBenefit.procedure.sequence
                    this.Element_Sequence = new ElementDefinitionInfo
                    {
                        Name = "Element_Sequence",
                        Path= "ExplanationOfBenefit.procedure.sequence",
                        Id = "ExplanationOfBenefit.procedure.sequence",
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
                    // 53. ExplanationOfBenefit.procedure.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "ExplanationOfBenefit.procedure.type",
                        Id = "ExplanationOfBenefit.procedure.type",
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
                    // 54. ExplanationOfBenefit.procedure.date
                    this.Element_Date = new ElementDefinitionInfo
                    {
                        Name = "Element_Date",
                        Path= "ExplanationOfBenefit.procedure.date",
                        Id = "ExplanationOfBenefit.procedure.date",
                        Min = 0,
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
                    // 55. ExplanationOfBenefit.procedure.procedure[x]
                    this.Element_Procedure = new ElementDefinitionInfo
                    {
                        Name = "Element_Procedure",
                        Path= "ExplanationOfBenefit.procedure.procedure[x]",
                        Id = "ExplanationOfBenefit.procedure.procedure[x]",
                        Min = 1,
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
                                    "http://hl7.org/fhir/StructureDefinition/Procedure"
                                }
                            }
                        }
                    };
                }
                {
                    // 56. ExplanationOfBenefit.procedure.udi
                    this.Element_Udi = new ElementDefinitionInfo
                    {
                        Name = "Element_Udi",
                        Path= "ExplanationOfBenefit.procedure.udi",
                        Id = "ExplanationOfBenefit.procedure.udi",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/Device"
                                }
                            }
                        }
                    };
                }
            }
        }
        // 58. ExplanationOfBenefit.insurance
        public partial class Type_Insurance : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 59. ExplanationOfBenefit.insurance.focal
            public ElementDefinitionInfo Element_Focal;
            // 60. ExplanationOfBenefit.insurance.coverage
            public ElementDefinitionInfo Element_Coverage;
            // 61. ExplanationOfBenefit.insurance.preAuthRef
            public ElementDefinitionInfo Element_PreAuthRef;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "ExplanationOfBenefit.insurance",
                    ElementId = "ExplanationOfBenefit.insurance"
                });
                Element_Focal.Write(sDef);
                Element_Coverage.Write(sDef);
                Element_PreAuthRef.Write(sDef);
            }
            
            public Type_Insurance()
            {
                {
                    // 59. ExplanationOfBenefit.insurance.focal
                    this.Element_Focal = new ElementDefinitionInfo
                    {
                        Name = "Element_Focal",
                        Path= "ExplanationOfBenefit.insurance.focal",
                        Id = "ExplanationOfBenefit.insurance.focal",
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
                    // 60. ExplanationOfBenefit.insurance.coverage
                    this.Element_Coverage = new ElementDefinitionInfo
                    {
                        Name = "Element_Coverage",
                        Path= "ExplanationOfBenefit.insurance.coverage",
                        Id = "ExplanationOfBenefit.insurance.coverage",
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
                    // 61. ExplanationOfBenefit.insurance.preAuthRef
                    this.Element_PreAuthRef = new ElementDefinitionInfo
                    {
                        Name = "Element_PreAuthRef",
                        Path= "ExplanationOfBenefit.insurance.preAuthRef",
                        Id = "ExplanationOfBenefit.insurance.preAuthRef",
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
            }
        }
        // 62. ExplanationOfBenefit.accident
        public partial class Type_Accident : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 63. ExplanationOfBenefit.accident.date
            public ElementDefinitionInfo Element_Date;
            // 64. ExplanationOfBenefit.accident.type
            public ElementDefinitionInfo Element_Type;
            // 65. ExplanationOfBenefit.accident.location[x]
            public ElementDefinitionInfo Element_Location;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "ExplanationOfBenefit.accident",
                    ElementId = "ExplanationOfBenefit.accident"
                });
                Element_Date.Write(sDef);
                Element_Type.Write(sDef);
                Element_Location.Write(sDef);
            }
            
            public Type_Accident()
            {
                {
                    // 63. ExplanationOfBenefit.accident.date
                    this.Element_Date = new ElementDefinitionInfo
                    {
                        Name = "Element_Date",
                        Path= "ExplanationOfBenefit.accident.date",
                        Id = "ExplanationOfBenefit.accident.date",
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
                    // 64. ExplanationOfBenefit.accident.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "ExplanationOfBenefit.accident.type",
                        Id = "ExplanationOfBenefit.accident.type",
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
                    // 65. ExplanationOfBenefit.accident.location[x]
                    this.Element_Location = new ElementDefinitionInfo
                    {
                        Name = "Element_Location",
                        Path= "ExplanationOfBenefit.accident.location[x]",
                        Id = "ExplanationOfBenefit.accident.location[x]",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
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
            }
        }
        // 66. ExplanationOfBenefit.item
        public partial class Type_Item : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 88. ExplanationOfBenefit.item.adjudication
            public partial class Type_Adjudication : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 89. ExplanationOfBenefit.item.adjudication.category
                public ElementDefinitionInfo Element_Category;
                // 90. ExplanationOfBenefit.item.adjudication.reason
                public ElementDefinitionInfo Element_Reason;
                // 91. ExplanationOfBenefit.item.adjudication.amount
                public ElementDefinitionInfo Element_Amount;
                // 92. ExplanationOfBenefit.item.adjudication.value
                public ElementDefinitionInfo Element_Value;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "ExplanationOfBenefit.item.adjudication",
                        ElementId = "ExplanationOfBenefit.item.adjudication"
                    });
                    Element_Category.Write(sDef);
                    Element_Reason.Write(sDef);
                    Element_Amount.Write(sDef);
                    Element_Value.Write(sDef);
                }
                
                public Type_Adjudication()
                {
                    {
                        // 89. ExplanationOfBenefit.item.adjudication.category
                        this.Element_Category = new ElementDefinitionInfo
                        {
                            Name = "Element_Category",
                            Path= "ExplanationOfBenefit.item.adjudication.category",
                            Id = "ExplanationOfBenefit.item.adjudication.category",
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
                        // 90. ExplanationOfBenefit.item.adjudication.reason
                        this.Element_Reason = new ElementDefinitionInfo
                        {
                            Name = "Element_Reason",
                            Path= "ExplanationOfBenefit.item.adjudication.reason",
                            Id = "ExplanationOfBenefit.item.adjudication.reason",
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
                        // 91. ExplanationOfBenefit.item.adjudication.amount
                        this.Element_Amount = new ElementDefinitionInfo
                        {
                            Name = "Element_Amount",
                            Path= "ExplanationOfBenefit.item.adjudication.amount",
                            Id = "ExplanationOfBenefit.item.adjudication.amount",
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
                        // 92. ExplanationOfBenefit.item.adjudication.value
                        this.Element_Value = new ElementDefinitionInfo
                        {
                            Name = "Element_Value",
                            Path= "ExplanationOfBenefit.item.adjudication.value",
                            Id = "ExplanationOfBenefit.item.adjudication.value",
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
            // 93. ExplanationOfBenefit.item.detail
            public partial class Type_Detail : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 107. ExplanationOfBenefit.item.detail.subDetail
                public partial class Type_SubDetail : FhirKhit.Maker.Common.Complex.ComplexBase
                {
                    // 108. ExplanationOfBenefit.item.detail.subDetail.sequence
                    public ElementDefinitionInfo Element_Sequence;
                    // 109. ExplanationOfBenefit.item.detail.subDetail.revenue
                    public ElementDefinitionInfo Element_Revenue;
                    // 110. ExplanationOfBenefit.item.detail.subDetail.category
                    public ElementDefinitionInfo Element_Category;
                    // 111. ExplanationOfBenefit.item.detail.subDetail.productOrService
                    public ElementDefinitionInfo Element_ProductOrService;
                    // 112. ExplanationOfBenefit.item.detail.subDetail.modifier
                    public ElementDefinitionInfo Element_Modifier;
                    // 113. ExplanationOfBenefit.item.detail.subDetail.programCode
                    public ElementDefinitionInfo Element_ProgramCode;
                    // 114. ExplanationOfBenefit.item.detail.subDetail.quantity
                    public ElementDefinitionInfo Element_Quantity;
                    // 115. ExplanationOfBenefit.item.detail.subDetail.unitPrice
                    public ElementDefinitionInfo Element_UnitPrice;
                    // 116. ExplanationOfBenefit.item.detail.subDetail.factor
                    public ElementDefinitionInfo Element_Factor;
                    // 117. ExplanationOfBenefit.item.detail.subDetail.net
                    public ElementDefinitionInfo Element_Net;
                    // 118. ExplanationOfBenefit.item.detail.subDetail.udi
                    public ElementDefinitionInfo Element_Udi;
                    // 119. ExplanationOfBenefit.item.detail.subDetail.noteNumber
                    public ElementDefinitionInfo Element_NoteNumber;
                    // 120. ExplanationOfBenefit.item.detail.subDetail.adjudication
                    public ElementDefinitionInfo Element_Adjudication;
                    
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                    {
                        base.Write(sDef);
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                        {
                            Path = "ExplanationOfBenefit.item.detail.subDetail",
                            ElementId = "ExplanationOfBenefit.item.detail.subDetail"
                        });
                        Element_Sequence.Write(sDef);
                        Element_Revenue.Write(sDef);
                        Element_Category.Write(sDef);
                        Element_ProductOrService.Write(sDef);
                        Element_Modifier.Write(sDef);
                        Element_ProgramCode.Write(sDef);
                        Element_Quantity.Write(sDef);
                        Element_UnitPrice.Write(sDef);
                        Element_Factor.Write(sDef);
                        Element_Net.Write(sDef);
                        Element_Udi.Write(sDef);
                        Element_NoteNumber.Write(sDef);
                        Element_Adjudication.Write(sDef);
                    }
                    
                    public Type_SubDetail()
                    {
                        {
                            // 108. ExplanationOfBenefit.item.detail.subDetail.sequence
                            this.Element_Sequence = new ElementDefinitionInfo
                            {
                                Name = "Element_Sequence",
                                Path= "ExplanationOfBenefit.item.detail.subDetail.sequence",
                                Id = "ExplanationOfBenefit.item.detail.subDetail.sequence",
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
                            // 109. ExplanationOfBenefit.item.detail.subDetail.revenue
                            this.Element_Revenue = new ElementDefinitionInfo
                            {
                                Name = "Element_Revenue",
                                Path= "ExplanationOfBenefit.item.detail.subDetail.revenue",
                                Id = "ExplanationOfBenefit.item.detail.subDetail.revenue",
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
                            // 110. ExplanationOfBenefit.item.detail.subDetail.category
                            this.Element_Category = new ElementDefinitionInfo
                            {
                                Name = "Element_Category",
                                Path= "ExplanationOfBenefit.item.detail.subDetail.category",
                                Id = "ExplanationOfBenefit.item.detail.subDetail.category",
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
                            // 111. ExplanationOfBenefit.item.detail.subDetail.productOrService
                            this.Element_ProductOrService = new ElementDefinitionInfo
                            {
                                Name = "Element_ProductOrService",
                                Path= "ExplanationOfBenefit.item.detail.subDetail.productOrService",
                                Id = "ExplanationOfBenefit.item.detail.subDetail.productOrService",
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
                            // 112. ExplanationOfBenefit.item.detail.subDetail.modifier
                            this.Element_Modifier = new ElementDefinitionInfo
                            {
                                Name = "Element_Modifier",
                                Path= "ExplanationOfBenefit.item.detail.subDetail.modifier",
                                Id = "ExplanationOfBenefit.item.detail.subDetail.modifier",
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
                            // 113. ExplanationOfBenefit.item.detail.subDetail.programCode
                            this.Element_ProgramCode = new ElementDefinitionInfo
                            {
                                Name = "Element_ProgramCode",
                                Path= "ExplanationOfBenefit.item.detail.subDetail.programCode",
                                Id = "ExplanationOfBenefit.item.detail.subDetail.programCode",
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
                            // 114. ExplanationOfBenefit.item.detail.subDetail.quantity
                            this.Element_Quantity = new ElementDefinitionInfo
                            {
                                Name = "Element_Quantity",
                                Path= "ExplanationOfBenefit.item.detail.subDetail.quantity",
                                Id = "ExplanationOfBenefit.item.detail.subDetail.quantity",
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
                            // 115. ExplanationOfBenefit.item.detail.subDetail.unitPrice
                            this.Element_UnitPrice = new ElementDefinitionInfo
                            {
                                Name = "Element_UnitPrice",
                                Path= "ExplanationOfBenefit.item.detail.subDetail.unitPrice",
                                Id = "ExplanationOfBenefit.item.detail.subDetail.unitPrice",
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
                            // 116. ExplanationOfBenefit.item.detail.subDetail.factor
                            this.Element_Factor = new ElementDefinitionInfo
                            {
                                Name = "Element_Factor",
                                Path= "ExplanationOfBenefit.item.detail.subDetail.factor",
                                Id = "ExplanationOfBenefit.item.detail.subDetail.factor",
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
                            // 117. ExplanationOfBenefit.item.detail.subDetail.net
                            this.Element_Net = new ElementDefinitionInfo
                            {
                                Name = "Element_Net",
                                Path= "ExplanationOfBenefit.item.detail.subDetail.net",
                                Id = "ExplanationOfBenefit.item.detail.subDetail.net",
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
                            // 118. ExplanationOfBenefit.item.detail.subDetail.udi
                            this.Element_Udi = new ElementDefinitionInfo
                            {
                                Name = "Element_Udi",
                                Path= "ExplanationOfBenefit.item.detail.subDetail.udi",
                                Id = "ExplanationOfBenefit.item.detail.subDetail.udi",
                                Min = 0,
                                Max = -1,
                                Types = new BaseType[]
                                {
                                    new FhirKhit.Maker.Common.Complex.Type_Reference
                                    {
                                        TargetProfile = new String[]
                                        {
                                            "http://hl7.org/fhir/StructureDefinition/Device"
                                        }
                                    }
                                }
                            };
                        }
                        {
                            // 119. ExplanationOfBenefit.item.detail.subDetail.noteNumber
                            this.Element_NoteNumber = new ElementDefinitionInfo
                            {
                                Name = "Element_NoteNumber",
                                Path= "ExplanationOfBenefit.item.detail.subDetail.noteNumber",
                                Id = "ExplanationOfBenefit.item.detail.subDetail.noteNumber",
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
                            // 120. ExplanationOfBenefit.item.detail.subDetail.adjudication
                            this.Element_Adjudication = new ElementDefinitionInfo
                            {
                                Name = "Element_Adjudication",
                                Path= "ExplanationOfBenefit.item.detail.subDetail.adjudication",
                                Id = "ExplanationOfBenefit.item.detail.subDetail.adjudication",
                                Min = 0,
                                Max = -1,
                                Types = new BaseType[]
                                {
                                }
                            };
                        }
                    }
                }
                // 94. ExplanationOfBenefit.item.detail.sequence
                public ElementDefinitionInfo Element_Sequence;
                // 95. ExplanationOfBenefit.item.detail.revenue
                public ElementDefinitionInfo Element_Revenue;
                // 96. ExplanationOfBenefit.item.detail.category
                public ElementDefinitionInfo Element_Category;
                // 97. ExplanationOfBenefit.item.detail.productOrService
                public ElementDefinitionInfo Element_ProductOrService;
                // 98. ExplanationOfBenefit.item.detail.modifier
                public ElementDefinitionInfo Element_Modifier;
                // 99. ExplanationOfBenefit.item.detail.programCode
                public ElementDefinitionInfo Element_ProgramCode;
                // 100. ExplanationOfBenefit.item.detail.quantity
                public ElementDefinitionInfo Element_Quantity;
                // 101. ExplanationOfBenefit.item.detail.unitPrice
                public ElementDefinitionInfo Element_UnitPrice;
                // 102. ExplanationOfBenefit.item.detail.factor
                public ElementDefinitionInfo Element_Factor;
                // 103. ExplanationOfBenefit.item.detail.net
                public ElementDefinitionInfo Element_Net;
                // 104. ExplanationOfBenefit.item.detail.udi
                public ElementDefinitionInfo Element_Udi;
                // 105. ExplanationOfBenefit.item.detail.noteNumber
                public ElementDefinitionInfo Element_NoteNumber;
                // 106. ExplanationOfBenefit.item.detail.adjudication
                public ElementDefinitionInfo Element_Adjudication;
                // 107. ExplanationOfBenefit.item.detail.subDetail
                public ElementDefinitionInfo Element_SubDetail;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "ExplanationOfBenefit.item.detail",
                        ElementId = "ExplanationOfBenefit.item.detail"
                    });
                    Element_Sequence.Write(sDef);
                    Element_Revenue.Write(sDef);
                    Element_Category.Write(sDef);
                    Element_ProductOrService.Write(sDef);
                    Element_Modifier.Write(sDef);
                    Element_ProgramCode.Write(sDef);
                    Element_Quantity.Write(sDef);
                    Element_UnitPrice.Write(sDef);
                    Element_Factor.Write(sDef);
                    Element_Net.Write(sDef);
                    Element_Udi.Write(sDef);
                    Element_NoteNumber.Write(sDef);
                    Element_Adjudication.Write(sDef);
                    Element_SubDetail.Write(sDef);
                }
                
                public Type_Detail()
                {
                    {
                        // 94. ExplanationOfBenefit.item.detail.sequence
                        this.Element_Sequence = new ElementDefinitionInfo
                        {
                            Name = "Element_Sequence",
                            Path= "ExplanationOfBenefit.item.detail.sequence",
                            Id = "ExplanationOfBenefit.item.detail.sequence",
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
                        // 95. ExplanationOfBenefit.item.detail.revenue
                        this.Element_Revenue = new ElementDefinitionInfo
                        {
                            Name = "Element_Revenue",
                            Path= "ExplanationOfBenefit.item.detail.revenue",
                            Id = "ExplanationOfBenefit.item.detail.revenue",
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
                        // 96. ExplanationOfBenefit.item.detail.category
                        this.Element_Category = new ElementDefinitionInfo
                        {
                            Name = "Element_Category",
                            Path= "ExplanationOfBenefit.item.detail.category",
                            Id = "ExplanationOfBenefit.item.detail.category",
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
                        // 97. ExplanationOfBenefit.item.detail.productOrService
                        this.Element_ProductOrService = new ElementDefinitionInfo
                        {
                            Name = "Element_ProductOrService",
                            Path= "ExplanationOfBenefit.item.detail.productOrService",
                            Id = "ExplanationOfBenefit.item.detail.productOrService",
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
                        // 98. ExplanationOfBenefit.item.detail.modifier
                        this.Element_Modifier = new ElementDefinitionInfo
                        {
                            Name = "Element_Modifier",
                            Path= "ExplanationOfBenefit.item.detail.modifier",
                            Id = "ExplanationOfBenefit.item.detail.modifier",
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
                        // 99. ExplanationOfBenefit.item.detail.programCode
                        this.Element_ProgramCode = new ElementDefinitionInfo
                        {
                            Name = "Element_ProgramCode",
                            Path= "ExplanationOfBenefit.item.detail.programCode",
                            Id = "ExplanationOfBenefit.item.detail.programCode",
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
                        // 100. ExplanationOfBenefit.item.detail.quantity
                        this.Element_Quantity = new ElementDefinitionInfo
                        {
                            Name = "Element_Quantity",
                            Path= "ExplanationOfBenefit.item.detail.quantity",
                            Id = "ExplanationOfBenefit.item.detail.quantity",
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
                        // 101. ExplanationOfBenefit.item.detail.unitPrice
                        this.Element_UnitPrice = new ElementDefinitionInfo
                        {
                            Name = "Element_UnitPrice",
                            Path= "ExplanationOfBenefit.item.detail.unitPrice",
                            Id = "ExplanationOfBenefit.item.detail.unitPrice",
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
                        // 102. ExplanationOfBenefit.item.detail.factor
                        this.Element_Factor = new ElementDefinitionInfo
                        {
                            Name = "Element_Factor",
                            Path= "ExplanationOfBenefit.item.detail.factor",
                            Id = "ExplanationOfBenefit.item.detail.factor",
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
                        // 103. ExplanationOfBenefit.item.detail.net
                        this.Element_Net = new ElementDefinitionInfo
                        {
                            Name = "Element_Net",
                            Path= "ExplanationOfBenefit.item.detail.net",
                            Id = "ExplanationOfBenefit.item.detail.net",
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
                        // 104. ExplanationOfBenefit.item.detail.udi
                        this.Element_Udi = new ElementDefinitionInfo
                        {
                            Name = "Element_Udi",
                            Path= "ExplanationOfBenefit.item.detail.udi",
                            Id = "ExplanationOfBenefit.item.detail.udi",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Complex.Type_Reference
                                {
                                    TargetProfile = new String[]
                                    {
                                        "http://hl7.org/fhir/StructureDefinition/Device"
                                    }
                                }
                            }
                        };
                    }
                    {
                        // 105. ExplanationOfBenefit.item.detail.noteNumber
                        this.Element_NoteNumber = new ElementDefinitionInfo
                        {
                            Name = "Element_NoteNumber",
                            Path= "ExplanationOfBenefit.item.detail.noteNumber",
                            Id = "ExplanationOfBenefit.item.detail.noteNumber",
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
                        // 106. ExplanationOfBenefit.item.detail.adjudication
                        this.Element_Adjudication = new ElementDefinitionInfo
                        {
                            Name = "Element_Adjudication",
                            Path= "ExplanationOfBenefit.item.detail.adjudication",
                            Id = "ExplanationOfBenefit.item.detail.adjudication",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                            }
                        };
                    }
                    {
                        // 107. ExplanationOfBenefit.item.detail.subDetail
                        this.Element_SubDetail = new ElementDefinitionInfo
                        {
                            Name = "Element_SubDetail",
                            Path= "ExplanationOfBenefit.item.detail.subDetail",
                            Id = "ExplanationOfBenefit.item.detail.subDetail",
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
            // 67. ExplanationOfBenefit.item.sequence
            public ElementDefinitionInfo Element_Sequence;
            // 68. ExplanationOfBenefit.item.careTeamSequence
            public ElementDefinitionInfo Element_CareTeamSequence;
            // 69. ExplanationOfBenefit.item.diagnosisSequence
            public ElementDefinitionInfo Element_DiagnosisSequence;
            // 70. ExplanationOfBenefit.item.procedureSequence
            public ElementDefinitionInfo Element_ProcedureSequence;
            // 71. ExplanationOfBenefit.item.informationSequence
            public ElementDefinitionInfo Element_InformationSequence;
            // 72. ExplanationOfBenefit.item.revenue
            public ElementDefinitionInfo Element_Revenue;
            // 73. ExplanationOfBenefit.item.category
            public ElementDefinitionInfo Element_Category;
            // 74. ExplanationOfBenefit.item.productOrService
            public ElementDefinitionInfo Element_ProductOrService;
            // 75. ExplanationOfBenefit.item.modifier
            public ElementDefinitionInfo Element_Modifier;
            // 76. ExplanationOfBenefit.item.programCode
            public ElementDefinitionInfo Element_ProgramCode;
            // 77. ExplanationOfBenefit.item.serviced[x]
            public ElementDefinitionInfo Element_Serviced;
            // 78. ExplanationOfBenefit.item.location[x]
            public ElementDefinitionInfo Element_Location;
            // 79. ExplanationOfBenefit.item.quantity
            public ElementDefinitionInfo Element_Quantity;
            // 80. ExplanationOfBenefit.item.unitPrice
            public ElementDefinitionInfo Element_UnitPrice;
            // 81. ExplanationOfBenefit.item.factor
            public ElementDefinitionInfo Element_Factor;
            // 82. ExplanationOfBenefit.item.net
            public ElementDefinitionInfo Element_Net;
            // 83. ExplanationOfBenefit.item.udi
            public ElementDefinitionInfo Element_Udi;
            // 84. ExplanationOfBenefit.item.bodySite
            public ElementDefinitionInfo Element_BodySite;
            // 85. ExplanationOfBenefit.item.subSite
            public ElementDefinitionInfo Element_SubSite;
            // 86. ExplanationOfBenefit.item.encounter
            public ElementDefinitionInfo Element_Encounter;
            // 87. ExplanationOfBenefit.item.noteNumber
            public ElementDefinitionInfo Element_NoteNumber;
            // 88. ExplanationOfBenefit.item.adjudication
            public ElementDefinitionInfo Element_Adjudication;
            // 93. ExplanationOfBenefit.item.detail
            public ElementDefinitionInfo Element_Detail;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "ExplanationOfBenefit.item",
                    ElementId = "ExplanationOfBenefit.item"
                });
                Element_Sequence.Write(sDef);
                Element_CareTeamSequence.Write(sDef);
                Element_DiagnosisSequence.Write(sDef);
                Element_ProcedureSequence.Write(sDef);
                Element_InformationSequence.Write(sDef);
                Element_Revenue.Write(sDef);
                Element_Category.Write(sDef);
                Element_ProductOrService.Write(sDef);
                Element_Modifier.Write(sDef);
                Element_ProgramCode.Write(sDef);
                Element_Serviced.Write(sDef);
                Element_Location.Write(sDef);
                Element_Quantity.Write(sDef);
                Element_UnitPrice.Write(sDef);
                Element_Factor.Write(sDef);
                Element_Net.Write(sDef);
                Element_Udi.Write(sDef);
                Element_BodySite.Write(sDef);
                Element_SubSite.Write(sDef);
                Element_Encounter.Write(sDef);
                Element_NoteNumber.Write(sDef);
                Element_Adjudication.Write(sDef);
                Element_Detail.Write(sDef);
            }
            
            public Type_Item()
            {
                {
                    // 67. ExplanationOfBenefit.item.sequence
                    this.Element_Sequence = new ElementDefinitionInfo
                    {
                        Name = "Element_Sequence",
                        Path= "ExplanationOfBenefit.item.sequence",
                        Id = "ExplanationOfBenefit.item.sequence",
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
                    // 68. ExplanationOfBenefit.item.careTeamSequence
                    this.Element_CareTeamSequence = new ElementDefinitionInfo
                    {
                        Name = "Element_CareTeamSequence",
                        Path= "ExplanationOfBenefit.item.careTeamSequence",
                        Id = "ExplanationOfBenefit.item.careTeamSequence",
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
                    // 69. ExplanationOfBenefit.item.diagnosisSequence
                    this.Element_DiagnosisSequence = new ElementDefinitionInfo
                    {
                        Name = "Element_DiagnosisSequence",
                        Path= "ExplanationOfBenefit.item.diagnosisSequence",
                        Id = "ExplanationOfBenefit.item.diagnosisSequence",
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
                    // 70. ExplanationOfBenefit.item.procedureSequence
                    this.Element_ProcedureSequence = new ElementDefinitionInfo
                    {
                        Name = "Element_ProcedureSequence",
                        Path= "ExplanationOfBenefit.item.procedureSequence",
                        Id = "ExplanationOfBenefit.item.procedureSequence",
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
                    // 71. ExplanationOfBenefit.item.informationSequence
                    this.Element_InformationSequence = new ElementDefinitionInfo
                    {
                        Name = "Element_InformationSequence",
                        Path= "ExplanationOfBenefit.item.informationSequence",
                        Id = "ExplanationOfBenefit.item.informationSequence",
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
                    // 72. ExplanationOfBenefit.item.revenue
                    this.Element_Revenue = new ElementDefinitionInfo
                    {
                        Name = "Element_Revenue",
                        Path= "ExplanationOfBenefit.item.revenue",
                        Id = "ExplanationOfBenefit.item.revenue",
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
                    // 73. ExplanationOfBenefit.item.category
                    this.Element_Category = new ElementDefinitionInfo
                    {
                        Name = "Element_Category",
                        Path= "ExplanationOfBenefit.item.category",
                        Id = "ExplanationOfBenefit.item.category",
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
                    // 74. ExplanationOfBenefit.item.productOrService
                    this.Element_ProductOrService = new ElementDefinitionInfo
                    {
                        Name = "Element_ProductOrService",
                        Path= "ExplanationOfBenefit.item.productOrService",
                        Id = "ExplanationOfBenefit.item.productOrService",
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
                    // 75. ExplanationOfBenefit.item.modifier
                    this.Element_Modifier = new ElementDefinitionInfo
                    {
                        Name = "Element_Modifier",
                        Path= "ExplanationOfBenefit.item.modifier",
                        Id = "ExplanationOfBenefit.item.modifier",
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
                    // 76. ExplanationOfBenefit.item.programCode
                    this.Element_ProgramCode = new ElementDefinitionInfo
                    {
                        Name = "Element_ProgramCode",
                        Path= "ExplanationOfBenefit.item.programCode",
                        Id = "ExplanationOfBenefit.item.programCode",
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
                    // 77. ExplanationOfBenefit.item.serviced[x]
                    this.Element_Serviced = new ElementDefinitionInfo
                    {
                        Name = "Element_Serviced",
                        Path= "ExplanationOfBenefit.item.serviced[x]",
                        Id = "ExplanationOfBenefit.item.serviced[x]",
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
                    // 78. ExplanationOfBenefit.item.location[x]
                    this.Element_Location = new ElementDefinitionInfo
                    {
                        Name = "Element_Location",
                        Path= "ExplanationOfBenefit.item.location[x]",
                        Id = "ExplanationOfBenefit.item.location[x]",
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
                    // 79. ExplanationOfBenefit.item.quantity
                    this.Element_Quantity = new ElementDefinitionInfo
                    {
                        Name = "Element_Quantity",
                        Path= "ExplanationOfBenefit.item.quantity",
                        Id = "ExplanationOfBenefit.item.quantity",
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
                    // 80. ExplanationOfBenefit.item.unitPrice
                    this.Element_UnitPrice = new ElementDefinitionInfo
                    {
                        Name = "Element_UnitPrice",
                        Path= "ExplanationOfBenefit.item.unitPrice",
                        Id = "ExplanationOfBenefit.item.unitPrice",
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
                    // 81. ExplanationOfBenefit.item.factor
                    this.Element_Factor = new ElementDefinitionInfo
                    {
                        Name = "Element_Factor",
                        Path= "ExplanationOfBenefit.item.factor",
                        Id = "ExplanationOfBenefit.item.factor",
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
                    // 82. ExplanationOfBenefit.item.net
                    this.Element_Net = new ElementDefinitionInfo
                    {
                        Name = "Element_Net",
                        Path= "ExplanationOfBenefit.item.net",
                        Id = "ExplanationOfBenefit.item.net",
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
                    // 83. ExplanationOfBenefit.item.udi
                    this.Element_Udi = new ElementDefinitionInfo
                    {
                        Name = "Element_Udi",
                        Path= "ExplanationOfBenefit.item.udi",
                        Id = "ExplanationOfBenefit.item.udi",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/Device"
                                }
                            }
                        }
                    };
                }
                {
                    // 84. ExplanationOfBenefit.item.bodySite
                    this.Element_BodySite = new ElementDefinitionInfo
                    {
                        Name = "Element_BodySite",
                        Path= "ExplanationOfBenefit.item.bodySite",
                        Id = "ExplanationOfBenefit.item.bodySite",
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
                    // 85. ExplanationOfBenefit.item.subSite
                    this.Element_SubSite = new ElementDefinitionInfo
                    {
                        Name = "Element_SubSite",
                        Path= "ExplanationOfBenefit.item.subSite",
                        Id = "ExplanationOfBenefit.item.subSite",
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
                    // 86. ExplanationOfBenefit.item.encounter
                    this.Element_Encounter = new ElementDefinitionInfo
                    {
                        Name = "Element_Encounter",
                        Path= "ExplanationOfBenefit.item.encounter",
                        Id = "ExplanationOfBenefit.item.encounter",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/Encounter"
                                }
                            }
                        }
                    };
                }
                {
                    // 87. ExplanationOfBenefit.item.noteNumber
                    this.Element_NoteNumber = new ElementDefinitionInfo
                    {
                        Name = "Element_NoteNumber",
                        Path= "ExplanationOfBenefit.item.noteNumber",
                        Id = "ExplanationOfBenefit.item.noteNumber",
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
                    // 88. ExplanationOfBenefit.item.adjudication
                    this.Element_Adjudication = new ElementDefinitionInfo
                    {
                        Name = "Element_Adjudication",
                        Path= "ExplanationOfBenefit.item.adjudication",
                        Id = "ExplanationOfBenefit.item.adjudication",
                        Min = 0,
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
                    // 93. ExplanationOfBenefit.item.detail
                    this.Element_Detail = new ElementDefinitionInfo
                    {
                        Name = "Element_Detail",
                        Path= "ExplanationOfBenefit.item.detail",
                        Id = "ExplanationOfBenefit.item.detail",
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
        // 121. ExplanationOfBenefit.addItem
        public partial class Type_AddItem : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 139. ExplanationOfBenefit.addItem.detail
            public partial class Type_Detail : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 148. ExplanationOfBenefit.addItem.detail.subDetail
                public partial class Type_SubDetail : FhirKhit.Maker.Common.Complex.ComplexBase
                {
                    // 149. ExplanationOfBenefit.addItem.detail.subDetail.productOrService
                    public ElementDefinitionInfo Element_ProductOrService;
                    // 150. ExplanationOfBenefit.addItem.detail.subDetail.modifier
                    public ElementDefinitionInfo Element_Modifier;
                    // 151. ExplanationOfBenefit.addItem.detail.subDetail.quantity
                    public ElementDefinitionInfo Element_Quantity;
                    // 152. ExplanationOfBenefit.addItem.detail.subDetail.unitPrice
                    public ElementDefinitionInfo Element_UnitPrice;
                    // 153. ExplanationOfBenefit.addItem.detail.subDetail.factor
                    public ElementDefinitionInfo Element_Factor;
                    // 154. ExplanationOfBenefit.addItem.detail.subDetail.net
                    public ElementDefinitionInfo Element_Net;
                    // 155. ExplanationOfBenefit.addItem.detail.subDetail.noteNumber
                    public ElementDefinitionInfo Element_NoteNumber;
                    // 156. ExplanationOfBenefit.addItem.detail.subDetail.adjudication
                    public ElementDefinitionInfo Element_Adjudication;
                    
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                    {
                        base.Write(sDef);
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                        {
                            Path = "ExplanationOfBenefit.addItem.detail.subDetail",
                            ElementId = "ExplanationOfBenefit.addItem.detail.subDetail"
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
                            // 149. ExplanationOfBenefit.addItem.detail.subDetail.productOrService
                            this.Element_ProductOrService = new ElementDefinitionInfo
                            {
                                Name = "Element_ProductOrService",
                                Path= "ExplanationOfBenefit.addItem.detail.subDetail.productOrService",
                                Id = "ExplanationOfBenefit.addItem.detail.subDetail.productOrService",
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
                            // 150. ExplanationOfBenefit.addItem.detail.subDetail.modifier
                            this.Element_Modifier = new ElementDefinitionInfo
                            {
                                Name = "Element_Modifier",
                                Path= "ExplanationOfBenefit.addItem.detail.subDetail.modifier",
                                Id = "ExplanationOfBenefit.addItem.detail.subDetail.modifier",
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
                            // 151. ExplanationOfBenefit.addItem.detail.subDetail.quantity
                            this.Element_Quantity = new ElementDefinitionInfo
                            {
                                Name = "Element_Quantity",
                                Path= "ExplanationOfBenefit.addItem.detail.subDetail.quantity",
                                Id = "ExplanationOfBenefit.addItem.detail.subDetail.quantity",
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
                            // 152. ExplanationOfBenefit.addItem.detail.subDetail.unitPrice
                            this.Element_UnitPrice = new ElementDefinitionInfo
                            {
                                Name = "Element_UnitPrice",
                                Path= "ExplanationOfBenefit.addItem.detail.subDetail.unitPrice",
                                Id = "ExplanationOfBenefit.addItem.detail.subDetail.unitPrice",
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
                            // 153. ExplanationOfBenefit.addItem.detail.subDetail.factor
                            this.Element_Factor = new ElementDefinitionInfo
                            {
                                Name = "Element_Factor",
                                Path= "ExplanationOfBenefit.addItem.detail.subDetail.factor",
                                Id = "ExplanationOfBenefit.addItem.detail.subDetail.factor",
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
                            // 154. ExplanationOfBenefit.addItem.detail.subDetail.net
                            this.Element_Net = new ElementDefinitionInfo
                            {
                                Name = "Element_Net",
                                Path= "ExplanationOfBenefit.addItem.detail.subDetail.net",
                                Id = "ExplanationOfBenefit.addItem.detail.subDetail.net",
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
                            // 155. ExplanationOfBenefit.addItem.detail.subDetail.noteNumber
                            this.Element_NoteNumber = new ElementDefinitionInfo
                            {
                                Name = "Element_NoteNumber",
                                Path= "ExplanationOfBenefit.addItem.detail.subDetail.noteNumber",
                                Id = "ExplanationOfBenefit.addItem.detail.subDetail.noteNumber",
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
                            // 156. ExplanationOfBenefit.addItem.detail.subDetail.adjudication
                            this.Element_Adjudication = new ElementDefinitionInfo
                            {
                                Name = "Element_Adjudication",
                                Path= "ExplanationOfBenefit.addItem.detail.subDetail.adjudication",
                                Id = "ExplanationOfBenefit.addItem.detail.subDetail.adjudication",
                                Min = 0,
                                Max = -1,
                                Types = new BaseType[]
                                {
                                }
                            };
                        }
                    }
                }
                // 140. ExplanationOfBenefit.addItem.detail.productOrService
                public ElementDefinitionInfo Element_ProductOrService;
                // 141. ExplanationOfBenefit.addItem.detail.modifier
                public ElementDefinitionInfo Element_Modifier;
                // 142. ExplanationOfBenefit.addItem.detail.quantity
                public ElementDefinitionInfo Element_Quantity;
                // 143. ExplanationOfBenefit.addItem.detail.unitPrice
                public ElementDefinitionInfo Element_UnitPrice;
                // 144. ExplanationOfBenefit.addItem.detail.factor
                public ElementDefinitionInfo Element_Factor;
                // 145. ExplanationOfBenefit.addItem.detail.net
                public ElementDefinitionInfo Element_Net;
                // 146. ExplanationOfBenefit.addItem.detail.noteNumber
                public ElementDefinitionInfo Element_NoteNumber;
                // 147. ExplanationOfBenefit.addItem.detail.adjudication
                public ElementDefinitionInfo Element_Adjudication;
                // 148. ExplanationOfBenefit.addItem.detail.subDetail
                public ElementDefinitionInfo Element_SubDetail;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "ExplanationOfBenefit.addItem.detail",
                        ElementId = "ExplanationOfBenefit.addItem.detail"
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
                        // 140. ExplanationOfBenefit.addItem.detail.productOrService
                        this.Element_ProductOrService = new ElementDefinitionInfo
                        {
                            Name = "Element_ProductOrService",
                            Path= "ExplanationOfBenefit.addItem.detail.productOrService",
                            Id = "ExplanationOfBenefit.addItem.detail.productOrService",
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
                        // 141. ExplanationOfBenefit.addItem.detail.modifier
                        this.Element_Modifier = new ElementDefinitionInfo
                        {
                            Name = "Element_Modifier",
                            Path= "ExplanationOfBenefit.addItem.detail.modifier",
                            Id = "ExplanationOfBenefit.addItem.detail.modifier",
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
                        // 142. ExplanationOfBenefit.addItem.detail.quantity
                        this.Element_Quantity = new ElementDefinitionInfo
                        {
                            Name = "Element_Quantity",
                            Path= "ExplanationOfBenefit.addItem.detail.quantity",
                            Id = "ExplanationOfBenefit.addItem.detail.quantity",
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
                        // 143. ExplanationOfBenefit.addItem.detail.unitPrice
                        this.Element_UnitPrice = new ElementDefinitionInfo
                        {
                            Name = "Element_UnitPrice",
                            Path= "ExplanationOfBenefit.addItem.detail.unitPrice",
                            Id = "ExplanationOfBenefit.addItem.detail.unitPrice",
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
                        // 144. ExplanationOfBenefit.addItem.detail.factor
                        this.Element_Factor = new ElementDefinitionInfo
                        {
                            Name = "Element_Factor",
                            Path= "ExplanationOfBenefit.addItem.detail.factor",
                            Id = "ExplanationOfBenefit.addItem.detail.factor",
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
                        // 145. ExplanationOfBenefit.addItem.detail.net
                        this.Element_Net = new ElementDefinitionInfo
                        {
                            Name = "Element_Net",
                            Path= "ExplanationOfBenefit.addItem.detail.net",
                            Id = "ExplanationOfBenefit.addItem.detail.net",
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
                        // 146. ExplanationOfBenefit.addItem.detail.noteNumber
                        this.Element_NoteNumber = new ElementDefinitionInfo
                        {
                            Name = "Element_NoteNumber",
                            Path= "ExplanationOfBenefit.addItem.detail.noteNumber",
                            Id = "ExplanationOfBenefit.addItem.detail.noteNumber",
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
                        // 147. ExplanationOfBenefit.addItem.detail.adjudication
                        this.Element_Adjudication = new ElementDefinitionInfo
                        {
                            Name = "Element_Adjudication",
                            Path= "ExplanationOfBenefit.addItem.detail.adjudication",
                            Id = "ExplanationOfBenefit.addItem.detail.adjudication",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                            }
                        };
                    }
                    {
                        // 148. ExplanationOfBenefit.addItem.detail.subDetail
                        this.Element_SubDetail = new ElementDefinitionInfo
                        {
                            Name = "Element_SubDetail",
                            Path= "ExplanationOfBenefit.addItem.detail.subDetail",
                            Id = "ExplanationOfBenefit.addItem.detail.subDetail",
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
            // 122. ExplanationOfBenefit.addItem.itemSequence
            public ElementDefinitionInfo Element_ItemSequence;
            // 123. ExplanationOfBenefit.addItem.detailSequence
            public ElementDefinitionInfo Element_DetailSequence;
            // 124. ExplanationOfBenefit.addItem.subDetailSequence
            public ElementDefinitionInfo Element_SubDetailSequence;
            // 125. ExplanationOfBenefit.addItem.provider
            public ElementDefinitionInfo Element_Provider;
            // 126. ExplanationOfBenefit.addItem.productOrService
            public ElementDefinitionInfo Element_ProductOrService;
            // 127. ExplanationOfBenefit.addItem.modifier
            public ElementDefinitionInfo Element_Modifier;
            // 128. ExplanationOfBenefit.addItem.programCode
            public ElementDefinitionInfo Element_ProgramCode;
            // 129. ExplanationOfBenefit.addItem.serviced[x]
            public ElementDefinitionInfo Element_Serviced;
            // 130. ExplanationOfBenefit.addItem.location[x]
            public ElementDefinitionInfo Element_Location;
            // 131. ExplanationOfBenefit.addItem.quantity
            public ElementDefinitionInfo Element_Quantity;
            // 132. ExplanationOfBenefit.addItem.unitPrice
            public ElementDefinitionInfo Element_UnitPrice;
            // 133. ExplanationOfBenefit.addItem.factor
            public ElementDefinitionInfo Element_Factor;
            // 134. ExplanationOfBenefit.addItem.net
            public ElementDefinitionInfo Element_Net;
            // 135. ExplanationOfBenefit.addItem.bodySite
            public ElementDefinitionInfo Element_BodySite;
            // 136. ExplanationOfBenefit.addItem.subSite
            public ElementDefinitionInfo Element_SubSite;
            // 137. ExplanationOfBenefit.addItem.noteNumber
            public ElementDefinitionInfo Element_NoteNumber;
            // 138. ExplanationOfBenefit.addItem.adjudication
            public ElementDefinitionInfo Element_Adjudication;
            // 139. ExplanationOfBenefit.addItem.detail
            public ElementDefinitionInfo Element_Detail;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "ExplanationOfBenefit.addItem",
                    ElementId = "ExplanationOfBenefit.addItem"
                });
                Element_ItemSequence.Write(sDef);
                Element_DetailSequence.Write(sDef);
                Element_SubDetailSequence.Write(sDef);
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
                    // 122. ExplanationOfBenefit.addItem.itemSequence
                    this.Element_ItemSequence = new ElementDefinitionInfo
                    {
                        Name = "Element_ItemSequence",
                        Path= "ExplanationOfBenefit.addItem.itemSequence",
                        Id = "ExplanationOfBenefit.addItem.itemSequence",
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
                    // 123. ExplanationOfBenefit.addItem.detailSequence
                    this.Element_DetailSequence = new ElementDefinitionInfo
                    {
                        Name = "Element_DetailSequence",
                        Path= "ExplanationOfBenefit.addItem.detailSequence",
                        Id = "ExplanationOfBenefit.addItem.detailSequence",
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
                    // 124. ExplanationOfBenefit.addItem.subDetailSequence
                    this.Element_SubDetailSequence = new ElementDefinitionInfo
                    {
                        Name = "Element_SubDetailSequence",
                        Path= "ExplanationOfBenefit.addItem.subDetailSequence",
                        Id = "ExplanationOfBenefit.addItem.subDetailSequence",
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
                    // 125. ExplanationOfBenefit.addItem.provider
                    this.Element_Provider = new ElementDefinitionInfo
                    {
                        Name = "Element_Provider",
                        Path= "ExplanationOfBenefit.addItem.provider",
                        Id = "ExplanationOfBenefit.addItem.provider",
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
                    // 126. ExplanationOfBenefit.addItem.productOrService
                    this.Element_ProductOrService = new ElementDefinitionInfo
                    {
                        Name = "Element_ProductOrService",
                        Path= "ExplanationOfBenefit.addItem.productOrService",
                        Id = "ExplanationOfBenefit.addItem.productOrService",
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
                    // 127. ExplanationOfBenefit.addItem.modifier
                    this.Element_Modifier = new ElementDefinitionInfo
                    {
                        Name = "Element_Modifier",
                        Path= "ExplanationOfBenefit.addItem.modifier",
                        Id = "ExplanationOfBenefit.addItem.modifier",
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
                    // 128. ExplanationOfBenefit.addItem.programCode
                    this.Element_ProgramCode = new ElementDefinitionInfo
                    {
                        Name = "Element_ProgramCode",
                        Path= "ExplanationOfBenefit.addItem.programCode",
                        Id = "ExplanationOfBenefit.addItem.programCode",
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
                    // 129. ExplanationOfBenefit.addItem.serviced[x]
                    this.Element_Serviced = new ElementDefinitionInfo
                    {
                        Name = "Element_Serviced",
                        Path= "ExplanationOfBenefit.addItem.serviced[x]",
                        Id = "ExplanationOfBenefit.addItem.serviced[x]",
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
                    // 130. ExplanationOfBenefit.addItem.location[x]
                    this.Element_Location = new ElementDefinitionInfo
                    {
                        Name = "Element_Location",
                        Path= "ExplanationOfBenefit.addItem.location[x]",
                        Id = "ExplanationOfBenefit.addItem.location[x]",
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
                    // 131. ExplanationOfBenefit.addItem.quantity
                    this.Element_Quantity = new ElementDefinitionInfo
                    {
                        Name = "Element_Quantity",
                        Path= "ExplanationOfBenefit.addItem.quantity",
                        Id = "ExplanationOfBenefit.addItem.quantity",
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
                    // 132. ExplanationOfBenefit.addItem.unitPrice
                    this.Element_UnitPrice = new ElementDefinitionInfo
                    {
                        Name = "Element_UnitPrice",
                        Path= "ExplanationOfBenefit.addItem.unitPrice",
                        Id = "ExplanationOfBenefit.addItem.unitPrice",
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
                    // 133. ExplanationOfBenefit.addItem.factor
                    this.Element_Factor = new ElementDefinitionInfo
                    {
                        Name = "Element_Factor",
                        Path= "ExplanationOfBenefit.addItem.factor",
                        Id = "ExplanationOfBenefit.addItem.factor",
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
                    // 134. ExplanationOfBenefit.addItem.net
                    this.Element_Net = new ElementDefinitionInfo
                    {
                        Name = "Element_Net",
                        Path= "ExplanationOfBenefit.addItem.net",
                        Id = "ExplanationOfBenefit.addItem.net",
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
                    // 135. ExplanationOfBenefit.addItem.bodySite
                    this.Element_BodySite = new ElementDefinitionInfo
                    {
                        Name = "Element_BodySite",
                        Path= "ExplanationOfBenefit.addItem.bodySite",
                        Id = "ExplanationOfBenefit.addItem.bodySite",
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
                    // 136. ExplanationOfBenefit.addItem.subSite
                    this.Element_SubSite = new ElementDefinitionInfo
                    {
                        Name = "Element_SubSite",
                        Path= "ExplanationOfBenefit.addItem.subSite",
                        Id = "ExplanationOfBenefit.addItem.subSite",
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
                    // 137. ExplanationOfBenefit.addItem.noteNumber
                    this.Element_NoteNumber = new ElementDefinitionInfo
                    {
                        Name = "Element_NoteNumber",
                        Path= "ExplanationOfBenefit.addItem.noteNumber",
                        Id = "ExplanationOfBenefit.addItem.noteNumber",
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
                    // 138. ExplanationOfBenefit.addItem.adjudication
                    this.Element_Adjudication = new ElementDefinitionInfo
                    {
                        Name = "Element_Adjudication",
                        Path= "ExplanationOfBenefit.addItem.adjudication",
                        Id = "ExplanationOfBenefit.addItem.adjudication",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                        }
                    };
                }
                {
                    // 139. ExplanationOfBenefit.addItem.detail
                    this.Element_Detail = new ElementDefinitionInfo
                    {
                        Name = "Element_Detail",
                        Path= "ExplanationOfBenefit.addItem.detail",
                        Id = "ExplanationOfBenefit.addItem.detail",
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
        // 158. ExplanationOfBenefit.total
        public partial class Type_Total : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 159. ExplanationOfBenefit.total.category
            public ElementDefinitionInfo Element_Category;
            // 160. ExplanationOfBenefit.total.amount
            public ElementDefinitionInfo Element_Amount;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "ExplanationOfBenefit.total",
                    ElementId = "ExplanationOfBenefit.total"
                });
                Element_Category.Write(sDef);
                Element_Amount.Write(sDef);
            }
            
            public Type_Total()
            {
                {
                    // 159. ExplanationOfBenefit.total.category
                    this.Element_Category = new ElementDefinitionInfo
                    {
                        Name = "Element_Category",
                        Path= "ExplanationOfBenefit.total.category",
                        Id = "ExplanationOfBenefit.total.category",
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
                    // 160. ExplanationOfBenefit.total.amount
                    this.Element_Amount = new ElementDefinitionInfo
                    {
                        Name = "Element_Amount",
                        Path= "ExplanationOfBenefit.total.amount",
                        Id = "ExplanationOfBenefit.total.amount",
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
        // 161. ExplanationOfBenefit.payment
        public partial class Type_Payment : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 162. ExplanationOfBenefit.payment.type
            public ElementDefinitionInfo Element_Type;
            // 163. ExplanationOfBenefit.payment.adjustment
            public ElementDefinitionInfo Element_Adjustment;
            // 164. ExplanationOfBenefit.payment.adjustmentReason
            public ElementDefinitionInfo Element_AdjustmentReason;
            // 165. ExplanationOfBenefit.payment.date
            public ElementDefinitionInfo Element_Date;
            // 166. ExplanationOfBenefit.payment.amount
            public ElementDefinitionInfo Element_Amount;
            // 167. ExplanationOfBenefit.payment.identifier
            public ElementDefinitionInfo Element_Identifier;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "ExplanationOfBenefit.payment",
                    ElementId = "ExplanationOfBenefit.payment"
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
                    // 162. ExplanationOfBenefit.payment.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "ExplanationOfBenefit.payment.type",
                        Id = "ExplanationOfBenefit.payment.type",
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
                    // 163. ExplanationOfBenefit.payment.adjustment
                    this.Element_Adjustment = new ElementDefinitionInfo
                    {
                        Name = "Element_Adjustment",
                        Path= "ExplanationOfBenefit.payment.adjustment",
                        Id = "ExplanationOfBenefit.payment.adjustment",
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
                    // 164. ExplanationOfBenefit.payment.adjustmentReason
                    this.Element_AdjustmentReason = new ElementDefinitionInfo
                    {
                        Name = "Element_AdjustmentReason",
                        Path= "ExplanationOfBenefit.payment.adjustmentReason",
                        Id = "ExplanationOfBenefit.payment.adjustmentReason",
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
                    // 165. ExplanationOfBenefit.payment.date
                    this.Element_Date = new ElementDefinitionInfo
                    {
                        Name = "Element_Date",
                        Path= "ExplanationOfBenefit.payment.date",
                        Id = "ExplanationOfBenefit.payment.date",
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
                    // 166. ExplanationOfBenefit.payment.amount
                    this.Element_Amount = new ElementDefinitionInfo
                    {
                        Name = "Element_Amount",
                        Path= "ExplanationOfBenefit.payment.amount",
                        Id = "ExplanationOfBenefit.payment.amount",
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
                    // 167. ExplanationOfBenefit.payment.identifier
                    this.Element_Identifier = new ElementDefinitionInfo
                    {
                        Name = "Element_Identifier",
                        Path= "ExplanationOfBenefit.payment.identifier",
                        Id = "ExplanationOfBenefit.payment.identifier",
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
        // 170. ExplanationOfBenefit.processNote
        public partial class Type_ProcessNote : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 171. ExplanationOfBenefit.processNote.number
            public ElementDefinitionInfo Element_Number;
            // 172. ExplanationOfBenefit.processNote.type
            public ElementDefinitionInfo Element_Type;
            // 173. ExplanationOfBenefit.processNote.text
            public ElementDefinitionInfo Element_Text;
            // 174. ExplanationOfBenefit.processNote.language
            public ElementDefinitionInfo Element_Language;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "ExplanationOfBenefit.processNote",
                    ElementId = "ExplanationOfBenefit.processNote"
                });
                Element_Number.Write(sDef);
                Element_Type.Write(sDef);
                Element_Text.Write(sDef);
                Element_Language.Write(sDef);
            }
            
            public Type_ProcessNote()
            {
                {
                    // 171. ExplanationOfBenefit.processNote.number
                    this.Element_Number = new ElementDefinitionInfo
                    {
                        Name = "Element_Number",
                        Path= "ExplanationOfBenefit.processNote.number",
                        Id = "ExplanationOfBenefit.processNote.number",
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
                    // 172. ExplanationOfBenefit.processNote.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "ExplanationOfBenefit.processNote.type",
                        Id = "ExplanationOfBenefit.processNote.type",
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
                    // 173. ExplanationOfBenefit.processNote.text
                    this.Element_Text = new ElementDefinitionInfo
                    {
                        Name = "Element_Text",
                        Path= "ExplanationOfBenefit.processNote.text",
                        Id = "ExplanationOfBenefit.processNote.text",
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
                    // 174. ExplanationOfBenefit.processNote.language
                    this.Element_Language = new ElementDefinitionInfo
                    {
                        Name = "Element_Language",
                        Path= "ExplanationOfBenefit.processNote.language",
                        Id = "ExplanationOfBenefit.processNote.language",
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
        // 176. ExplanationOfBenefit.benefitBalance
        public partial class Type_BenefitBalance : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 184. ExplanationOfBenefit.benefitBalance.financial
            public partial class Type_Financial : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 185. ExplanationOfBenefit.benefitBalance.financial.type
                public ElementDefinitionInfo Element_Type;
                // 186. ExplanationOfBenefit.benefitBalance.financial.allowed[x]
                public ElementDefinitionInfo Element_Allowed;
                // 187. ExplanationOfBenefit.benefitBalance.financial.used[x]
                public ElementDefinitionInfo Element_Used;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "ExplanationOfBenefit.benefitBalance.financial",
                        ElementId = "ExplanationOfBenefit.benefitBalance.financial"
                    });
                    Element_Type.Write(sDef);
                    Element_Allowed.Write(sDef);
                    Element_Used.Write(sDef);
                }
                
                public Type_Financial()
                {
                    {
                        // 185. ExplanationOfBenefit.benefitBalance.financial.type
                        this.Element_Type = new ElementDefinitionInfo
                        {
                            Name = "Element_Type",
                            Path= "ExplanationOfBenefit.benefitBalance.financial.type",
                            Id = "ExplanationOfBenefit.benefitBalance.financial.type",
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
                        // 186. ExplanationOfBenefit.benefitBalance.financial.allowed[x]
                        this.Element_Allowed = new ElementDefinitionInfo
                        {
                            Name = "Element_Allowed",
                            Path= "ExplanationOfBenefit.benefitBalance.financial.allowed[x]",
                            Id = "ExplanationOfBenefit.benefitBalance.financial.allowed[x]",
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
                        // 187. ExplanationOfBenefit.benefitBalance.financial.used[x]
                        this.Element_Used = new ElementDefinitionInfo
                        {
                            Name = "Element_Used",
                            Path= "ExplanationOfBenefit.benefitBalance.financial.used[x]",
                            Id = "ExplanationOfBenefit.benefitBalance.financial.used[x]",
                            Min = 0,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_UnsignedInt
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
            // 177. ExplanationOfBenefit.benefitBalance.category
            public ElementDefinitionInfo Element_Category;
            // 178. ExplanationOfBenefit.benefitBalance.excluded
            public ElementDefinitionInfo Element_Excluded;
            // 179. ExplanationOfBenefit.benefitBalance.name
            public ElementDefinitionInfo Element_Name;
            // 180. ExplanationOfBenefit.benefitBalance.description
            public ElementDefinitionInfo Element_Description;
            // 181. ExplanationOfBenefit.benefitBalance.network
            public ElementDefinitionInfo Element_Network;
            // 182. ExplanationOfBenefit.benefitBalance.unit
            public ElementDefinitionInfo Element_Unit;
            // 183. ExplanationOfBenefit.benefitBalance.term
            public ElementDefinitionInfo Element_Term;
            // 184. ExplanationOfBenefit.benefitBalance.financial
            public ElementDefinitionInfo Element_Financial;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "ExplanationOfBenefit.benefitBalance",
                    ElementId = "ExplanationOfBenefit.benefitBalance"
                });
                Element_Category.Write(sDef);
                Element_Excluded.Write(sDef);
                Element_Name.Write(sDef);
                Element_Description.Write(sDef);
                Element_Network.Write(sDef);
                Element_Unit.Write(sDef);
                Element_Term.Write(sDef);
                Element_Financial.Write(sDef);
            }
            
            public Type_BenefitBalance()
            {
                {
                    // 177. ExplanationOfBenefit.benefitBalance.category
                    this.Element_Category = new ElementDefinitionInfo
                    {
                        Name = "Element_Category",
                        Path= "ExplanationOfBenefit.benefitBalance.category",
                        Id = "ExplanationOfBenefit.benefitBalance.category",
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
                    // 178. ExplanationOfBenefit.benefitBalance.excluded
                    this.Element_Excluded = new ElementDefinitionInfo
                    {
                        Name = "Element_Excluded",
                        Path= "ExplanationOfBenefit.benefitBalance.excluded",
                        Id = "ExplanationOfBenefit.benefitBalance.excluded",
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
                    // 179. ExplanationOfBenefit.benefitBalance.name
                    this.Element_Name = new ElementDefinitionInfo
                    {
                        Name = "Element_Name",
                        Path= "ExplanationOfBenefit.benefitBalance.name",
                        Id = "ExplanationOfBenefit.benefitBalance.name",
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
                    // 180. ExplanationOfBenefit.benefitBalance.description
                    this.Element_Description = new ElementDefinitionInfo
                    {
                        Name = "Element_Description",
                        Path= "ExplanationOfBenefit.benefitBalance.description",
                        Id = "ExplanationOfBenefit.benefitBalance.description",
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
                    // 181. ExplanationOfBenefit.benefitBalance.network
                    this.Element_Network = new ElementDefinitionInfo
                    {
                        Name = "Element_Network",
                        Path= "ExplanationOfBenefit.benefitBalance.network",
                        Id = "ExplanationOfBenefit.benefitBalance.network",
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
                    // 182. ExplanationOfBenefit.benefitBalance.unit
                    this.Element_Unit = new ElementDefinitionInfo
                    {
                        Name = "Element_Unit",
                        Path= "ExplanationOfBenefit.benefitBalance.unit",
                        Id = "ExplanationOfBenefit.benefitBalance.unit",
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
                    // 183. ExplanationOfBenefit.benefitBalance.term
                    this.Element_Term = new ElementDefinitionInfo
                    {
                        Name = "Element_Term",
                        Path= "ExplanationOfBenefit.benefitBalance.term",
                        Id = "ExplanationOfBenefit.benefitBalance.term",
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
                    // 184. ExplanationOfBenefit.benefitBalance.financial
                    this.Element_Financial = new ElementDefinitionInfo
                    {
                        Name = "Element_Financial",
                        Path= "ExplanationOfBenefit.benefitBalance.financial",
                        Id = "ExplanationOfBenefit.benefitBalance.financial",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Financial
                            {
                            }
                        }
                    };
                }
            }
        }
        // 1. ExplanationOfBenefit.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. ExplanationOfBenefit.status
        public ElementDefinitionInfo Element_Status;
        // 3. ExplanationOfBenefit.type
        public ElementDefinitionInfo Element_Type;
        // 4. ExplanationOfBenefit.subType
        public ElementDefinitionInfo Element_SubType;
        // 5. ExplanationOfBenefit.use
        public ElementDefinitionInfo Element_Use;
        // 6. ExplanationOfBenefit.patient
        public ElementDefinitionInfo Element_Patient;
        // 7. ExplanationOfBenefit.billablePeriod
        public ElementDefinitionInfo Element_BillablePeriod;
        // 8. ExplanationOfBenefit.created
        public ElementDefinitionInfo Element_Created;
        // 9. ExplanationOfBenefit.enterer
        public ElementDefinitionInfo Element_Enterer;
        // 10. ExplanationOfBenefit.insurer
        public ElementDefinitionInfo Element_Insurer;
        // 11. ExplanationOfBenefit.provider
        public ElementDefinitionInfo Element_Provider;
        // 12. ExplanationOfBenefit.priority
        public ElementDefinitionInfo Element_Priority;
        // 13. ExplanationOfBenefit.fundsReserveRequested
        public ElementDefinitionInfo Element_FundsReserveRequested;
        // 14. ExplanationOfBenefit.fundsReserve
        public ElementDefinitionInfo Element_FundsReserve;
        // 15. ExplanationOfBenefit.related
        public ElementDefinitionInfo Element_Related;
        // 19. ExplanationOfBenefit.prescription
        public ElementDefinitionInfo Element_Prescription;
        // 20. ExplanationOfBenefit.originalPrescription
        public ElementDefinitionInfo Element_OriginalPrescription;
        // 21. ExplanationOfBenefit.payee
        public ElementDefinitionInfo Element_Payee;
        // 24. ExplanationOfBenefit.referral
        public ElementDefinitionInfo Element_Referral;
        // 25. ExplanationOfBenefit.facility
        public ElementDefinitionInfo Element_Facility;
        // 26. ExplanationOfBenefit.claim
        public ElementDefinitionInfo Element_Claim;
        // 27. ExplanationOfBenefit.claimResponse
        public ElementDefinitionInfo Element_ClaimResponse;
        // 28. ExplanationOfBenefit.outcome
        public ElementDefinitionInfo Element_Outcome;
        // 29. ExplanationOfBenefit.disposition
        public ElementDefinitionInfo Element_Disposition;
        // 30. ExplanationOfBenefit.preAuthRef
        public ElementDefinitionInfo Element_PreAuthRef;
        // 31. ExplanationOfBenefit.preAuthRefPeriod
        public ElementDefinitionInfo Element_PreAuthRefPeriod;
        // 32. ExplanationOfBenefit.careTeam
        public ElementDefinitionInfo Element_CareTeam;
        // 38. ExplanationOfBenefit.supportingInfo
        public ElementDefinitionInfo Element_SupportingInfo;
        // 45. ExplanationOfBenefit.diagnosis
        public ElementDefinitionInfo Element_Diagnosis;
        // 51. ExplanationOfBenefit.procedure
        public ElementDefinitionInfo Element_Procedure;
        // 57. ExplanationOfBenefit.precedence
        public ElementDefinitionInfo Element_Precedence;
        // 58. ExplanationOfBenefit.insurance
        public ElementDefinitionInfo Element_Insurance;
        // 62. ExplanationOfBenefit.accident
        public ElementDefinitionInfo Element_Accident;
        // 66. ExplanationOfBenefit.item
        public ElementDefinitionInfo Element_Item;
        // 121. ExplanationOfBenefit.addItem
        public ElementDefinitionInfo Element_AddItem;
        // 157. ExplanationOfBenefit.adjudication
        public ElementDefinitionInfo Element_Adjudication;
        // 158. ExplanationOfBenefit.total
        public ElementDefinitionInfo Element_Total;
        // 161. ExplanationOfBenefit.payment
        public ElementDefinitionInfo Element_Payment;
        // 168. ExplanationOfBenefit.formCode
        public ElementDefinitionInfo Element_FormCode;
        // 169. ExplanationOfBenefit.form
        public ElementDefinitionInfo Element_Form;
        // 170. ExplanationOfBenefit.processNote
        public ElementDefinitionInfo Element_ProcessNote;
        // 175. ExplanationOfBenefit.benefitPeriod
        public ElementDefinitionInfo Element_BenefitPeriod;
        // 176. ExplanationOfBenefit.benefitBalance
        public ElementDefinitionInfo Element_BenefitBalance;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "ExplanationOfBenefit",
                ElementId = "ExplanationOfBenefit"
            });
            Element_Identifier.Write(sDef);
            Element_Status.Write(sDef);
            Element_Type.Write(sDef);
            Element_SubType.Write(sDef);
            Element_Use.Write(sDef);
            Element_Patient.Write(sDef);
            Element_BillablePeriod.Write(sDef);
            Element_Created.Write(sDef);
            Element_Enterer.Write(sDef);
            Element_Insurer.Write(sDef);
            Element_Provider.Write(sDef);
            Element_Priority.Write(sDef);
            Element_FundsReserveRequested.Write(sDef);
            Element_FundsReserve.Write(sDef);
            Element_Related.Write(sDef);
            Element_Prescription.Write(sDef);
            Element_OriginalPrescription.Write(sDef);
            Element_Payee.Write(sDef);
            Element_Referral.Write(sDef);
            Element_Facility.Write(sDef);
            Element_Claim.Write(sDef);
            Element_ClaimResponse.Write(sDef);
            Element_Outcome.Write(sDef);
            Element_Disposition.Write(sDef);
            Element_PreAuthRef.Write(sDef);
            Element_PreAuthRefPeriod.Write(sDef);
            Element_CareTeam.Write(sDef);
            Element_SupportingInfo.Write(sDef);
            Element_Diagnosis.Write(sDef);
            Element_Procedure.Write(sDef);
            Element_Precedence.Write(sDef);
            Element_Insurance.Write(sDef);
            Element_Accident.Write(sDef);
            Element_Item.Write(sDef);
            Element_AddItem.Write(sDef);
            Element_Adjudication.Write(sDef);
            Element_Total.Write(sDef);
            Element_Payment.Write(sDef);
            Element_FormCode.Write(sDef);
            Element_Form.Write(sDef);
            Element_ProcessNote.Write(sDef);
            Element_BenefitPeriod.Write(sDef);
            Element_BenefitBalance.Write(sDef);
        }
        
        public Resource_ExplanationOfBenefit()
        {
            {
                // 1. ExplanationOfBenefit.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "ExplanationOfBenefit.identifier",
                    Id = "ExplanationOfBenefit.identifier",
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
                // 2. ExplanationOfBenefit.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "ExplanationOfBenefit.status",
                    Id = "ExplanationOfBenefit.status",
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
                // 3. ExplanationOfBenefit.type
                this.Element_Type = new ElementDefinitionInfo
                {
                    Name = "Element_Type",
                    Path= "ExplanationOfBenefit.type",
                    Id = "ExplanationOfBenefit.type",
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
                // 4. ExplanationOfBenefit.subType
                this.Element_SubType = new ElementDefinitionInfo
                {
                    Name = "Element_SubType",
                    Path= "ExplanationOfBenefit.subType",
                    Id = "ExplanationOfBenefit.subType",
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
                // 5. ExplanationOfBenefit.use
                this.Element_Use = new ElementDefinitionInfo
                {
                    Name = "Element_Use",
                    Path= "ExplanationOfBenefit.use",
                    Id = "ExplanationOfBenefit.use",
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
                // 6. ExplanationOfBenefit.patient
                this.Element_Patient = new ElementDefinitionInfo
                {
                    Name = "Element_Patient",
                    Path= "ExplanationOfBenefit.patient",
                    Id = "ExplanationOfBenefit.patient",
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
                // 7. ExplanationOfBenefit.billablePeriod
                this.Element_BillablePeriod = new ElementDefinitionInfo
                {
                    Name = "Element_BillablePeriod",
                    Path= "ExplanationOfBenefit.billablePeriod",
                    Id = "ExplanationOfBenefit.billablePeriod",
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
                // 8. ExplanationOfBenefit.created
                this.Element_Created = new ElementDefinitionInfo
                {
                    Name = "Element_Created",
                    Path= "ExplanationOfBenefit.created",
                    Id = "ExplanationOfBenefit.created",
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
                // 9. ExplanationOfBenefit.enterer
                this.Element_Enterer = new ElementDefinitionInfo
                {
                    Name = "Element_Enterer",
                    Path= "ExplanationOfBenefit.enterer",
                    Id = "ExplanationOfBenefit.enterer",
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
                // 10. ExplanationOfBenefit.insurer
                this.Element_Insurer = new ElementDefinitionInfo
                {
                    Name = "Element_Insurer",
                    Path= "ExplanationOfBenefit.insurer",
                    Id = "ExplanationOfBenefit.insurer",
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
                // 11. ExplanationOfBenefit.provider
                this.Element_Provider = new ElementDefinitionInfo
                {
                    Name = "Element_Provider",
                    Path= "ExplanationOfBenefit.provider",
                    Id = "ExplanationOfBenefit.provider",
                    Min = 1,
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
                // 12. ExplanationOfBenefit.priority
                this.Element_Priority = new ElementDefinitionInfo
                {
                    Name = "Element_Priority",
                    Path= "ExplanationOfBenefit.priority",
                    Id = "ExplanationOfBenefit.priority",
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
                // 13. ExplanationOfBenefit.fundsReserveRequested
                this.Element_FundsReserveRequested = new ElementDefinitionInfo
                {
                    Name = "Element_FundsReserveRequested",
                    Path= "ExplanationOfBenefit.fundsReserveRequested",
                    Id = "ExplanationOfBenefit.fundsReserveRequested",
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
                // 14. ExplanationOfBenefit.fundsReserve
                this.Element_FundsReserve = new ElementDefinitionInfo
                {
                    Name = "Element_FundsReserve",
                    Path= "ExplanationOfBenefit.fundsReserve",
                    Id = "ExplanationOfBenefit.fundsReserve",
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
                // 15. ExplanationOfBenefit.related
                this.Element_Related = new ElementDefinitionInfo
                {
                    Name = "Element_Related",
                    Path= "ExplanationOfBenefit.related",
                    Id = "ExplanationOfBenefit.related",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Related
                        {
                        }
                    }
                };
            }
            {
                // 19. ExplanationOfBenefit.prescription
                this.Element_Prescription = new ElementDefinitionInfo
                {
                    Name = "Element_Prescription",
                    Path= "ExplanationOfBenefit.prescription",
                    Id = "ExplanationOfBenefit.prescription",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/MedicationRequest",
                                "http://hl7.org/fhir/StructureDefinition/VisionPrescription"
                            }
                        }
                    }
                };
            }
            {
                // 20. ExplanationOfBenefit.originalPrescription
                this.Element_OriginalPrescription = new ElementDefinitionInfo
                {
                    Name = "Element_OriginalPrescription",
                    Path= "ExplanationOfBenefit.originalPrescription",
                    Id = "ExplanationOfBenefit.originalPrescription",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/MedicationRequest"
                            }
                        }
                    }
                };
            }
            {
                // 21. ExplanationOfBenefit.payee
                this.Element_Payee = new ElementDefinitionInfo
                {
                    Name = "Element_Payee",
                    Path= "ExplanationOfBenefit.payee",
                    Id = "ExplanationOfBenefit.payee",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new Type_Payee
                        {
                        }
                    }
                };
            }
            {
                // 24. ExplanationOfBenefit.referral
                this.Element_Referral = new ElementDefinitionInfo
                {
                    Name = "Element_Referral",
                    Path= "ExplanationOfBenefit.referral",
                    Id = "ExplanationOfBenefit.referral",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/ServiceRequest"
                            }
                        }
                    }
                };
            }
            {
                // 25. ExplanationOfBenefit.facility
                this.Element_Facility = new ElementDefinitionInfo
                {
                    Name = "Element_Facility",
                    Path= "ExplanationOfBenefit.facility",
                    Id = "ExplanationOfBenefit.facility",
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
                // 26. ExplanationOfBenefit.claim
                this.Element_Claim = new ElementDefinitionInfo
                {
                    Name = "Element_Claim",
                    Path= "ExplanationOfBenefit.claim",
                    Id = "ExplanationOfBenefit.claim",
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
                // 27. ExplanationOfBenefit.claimResponse
                this.Element_ClaimResponse = new ElementDefinitionInfo
                {
                    Name = "Element_ClaimResponse",
                    Path= "ExplanationOfBenefit.claimResponse",
                    Id = "ExplanationOfBenefit.claimResponse",
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
            {
                // 28. ExplanationOfBenefit.outcome
                this.Element_Outcome = new ElementDefinitionInfo
                {
                    Name = "Element_Outcome",
                    Path= "ExplanationOfBenefit.outcome",
                    Id = "ExplanationOfBenefit.outcome",
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
                // 29. ExplanationOfBenefit.disposition
                this.Element_Disposition = new ElementDefinitionInfo
                {
                    Name = "Element_Disposition",
                    Path= "ExplanationOfBenefit.disposition",
                    Id = "ExplanationOfBenefit.disposition",
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
                // 30. ExplanationOfBenefit.preAuthRef
                this.Element_PreAuthRef = new ElementDefinitionInfo
                {
                    Name = "Element_PreAuthRef",
                    Path= "ExplanationOfBenefit.preAuthRef",
                    Id = "ExplanationOfBenefit.preAuthRef",
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
                // 31. ExplanationOfBenefit.preAuthRefPeriod
                this.Element_PreAuthRefPeriod = new ElementDefinitionInfo
                {
                    Name = "Element_PreAuthRefPeriod",
                    Path= "ExplanationOfBenefit.preAuthRefPeriod",
                    Id = "ExplanationOfBenefit.preAuthRefPeriod",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Period
                        {
                        }
                    }
                };
            }
            {
                // 32. ExplanationOfBenefit.careTeam
                this.Element_CareTeam = new ElementDefinitionInfo
                {
                    Name = "Element_CareTeam",
                    Path= "ExplanationOfBenefit.careTeam",
                    Id = "ExplanationOfBenefit.careTeam",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_CareTeam
                        {
                        }
                    }
                };
            }
            {
                // 38. ExplanationOfBenefit.supportingInfo
                this.Element_SupportingInfo = new ElementDefinitionInfo
                {
                    Name = "Element_SupportingInfo",
                    Path= "ExplanationOfBenefit.supportingInfo",
                    Id = "ExplanationOfBenefit.supportingInfo",
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
                // 45. ExplanationOfBenefit.diagnosis
                this.Element_Diagnosis = new ElementDefinitionInfo
                {
                    Name = "Element_Diagnosis",
                    Path= "ExplanationOfBenefit.diagnosis",
                    Id = "ExplanationOfBenefit.diagnosis",
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
                // 51. ExplanationOfBenefit.procedure
                this.Element_Procedure = new ElementDefinitionInfo
                {
                    Name = "Element_Procedure",
                    Path= "ExplanationOfBenefit.procedure",
                    Id = "ExplanationOfBenefit.procedure",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Procedure
                        {
                        }
                    }
                };
            }
            {
                // 57. ExplanationOfBenefit.precedence
                this.Element_Precedence = new ElementDefinitionInfo
                {
                    Name = "Element_Precedence",
                    Path= "ExplanationOfBenefit.precedence",
                    Id = "ExplanationOfBenefit.precedence",
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
                // 58. ExplanationOfBenefit.insurance
                this.Element_Insurance = new ElementDefinitionInfo
                {
                    Name = "Element_Insurance",
                    Path= "ExplanationOfBenefit.insurance",
                    Id = "ExplanationOfBenefit.insurance",
                    Min = 1,
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
                // 62. ExplanationOfBenefit.accident
                this.Element_Accident = new ElementDefinitionInfo
                {
                    Name = "Element_Accident",
                    Path= "ExplanationOfBenefit.accident",
                    Id = "ExplanationOfBenefit.accident",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new Type_Accident
                        {
                        }
                    }
                };
            }
            {
                // 66. ExplanationOfBenefit.item
                this.Element_Item = new ElementDefinitionInfo
                {
                    Name = "Element_Item",
                    Path= "ExplanationOfBenefit.item",
                    Id = "ExplanationOfBenefit.item",
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
                // 121. ExplanationOfBenefit.addItem
                this.Element_AddItem = new ElementDefinitionInfo
                {
                    Name = "Element_AddItem",
                    Path= "ExplanationOfBenefit.addItem",
                    Id = "ExplanationOfBenefit.addItem",
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
                // 157. ExplanationOfBenefit.adjudication
                this.Element_Adjudication = new ElementDefinitionInfo
                {
                    Name = "Element_Adjudication",
                    Path= "ExplanationOfBenefit.adjudication",
                    Id = "ExplanationOfBenefit.adjudication",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                    }
                };
            }
            {
                // 158. ExplanationOfBenefit.total
                this.Element_Total = new ElementDefinitionInfo
                {
                    Name = "Element_Total",
                    Path= "ExplanationOfBenefit.total",
                    Id = "ExplanationOfBenefit.total",
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
                // 161. ExplanationOfBenefit.payment
                this.Element_Payment = new ElementDefinitionInfo
                {
                    Name = "Element_Payment",
                    Path= "ExplanationOfBenefit.payment",
                    Id = "ExplanationOfBenefit.payment",
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
                // 168. ExplanationOfBenefit.formCode
                this.Element_FormCode = new ElementDefinitionInfo
                {
                    Name = "Element_FormCode",
                    Path= "ExplanationOfBenefit.formCode",
                    Id = "ExplanationOfBenefit.formCode",
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
                // 169. ExplanationOfBenefit.form
                this.Element_Form = new ElementDefinitionInfo
                {
                    Name = "Element_Form",
                    Path= "ExplanationOfBenefit.form",
                    Id = "ExplanationOfBenefit.form",
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
                // 170. ExplanationOfBenefit.processNote
                this.Element_ProcessNote = new ElementDefinitionInfo
                {
                    Name = "Element_ProcessNote",
                    Path= "ExplanationOfBenefit.processNote",
                    Id = "ExplanationOfBenefit.processNote",
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
                // 175. ExplanationOfBenefit.benefitPeriod
                this.Element_BenefitPeriod = new ElementDefinitionInfo
                {
                    Name = "Element_BenefitPeriod",
                    Path= "ExplanationOfBenefit.benefitPeriod",
                    Id = "ExplanationOfBenefit.benefitPeriod",
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
                // 176. ExplanationOfBenefit.benefitBalance
                this.Element_BenefitBalance = new ElementDefinitionInfo
                {
                    Name = "Element_BenefitBalance",
                    Path= "ExplanationOfBenefit.benefitBalance",
                    Id = "ExplanationOfBenefit.benefitBalance",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_BenefitBalance
                        {
                        }
                    }
                };
            }
            this.Name = "ExplanationOfBenefit";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/ExplanationOfBenefit";
        }
    }
}
